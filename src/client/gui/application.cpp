#include "application.h"
#include <QApplication>
#include <QMainWindow>
#include "../globals.h"
#include "windows/mainwindow.h"
#include <iostream>
#include <QSettings>
#include <QMessageBox>

#include "../ext/steamclient.h"
#include "../ext/steamservice.h"

#include "../interop/appmanager.h"

#include "../startup/bootstrapper.h"

Application *Application::instance;

Application::Application()
{
  Global_ThreadController = new ThreadController();

  Application::instance = this;
  if (!IsGUIBoot())
  {
    QApp = new QCoreApplication(Global_CommandLine->argc, Global_CommandLine->argv);
  }
  else
  {
    QApp = new QApplication(Global_CommandLine->argc, Global_CommandLine->argv);
  }
}


Application::~Application()
{
  Application::instance = nullptr;
}

Application *Application::GetApplication() {
    if (Application::instance == nullptr) {
        return new Application();
    }
    return Application::instance;
}
bool Application::IsGUIBoot() {
    return !Global_CommandLine->HasOption("--no-gui");
}

class IConCommandBaseAccessor;

class ConCommandBase {
public:
  void *vtable;
  ConCommandBase *m_pNext; // 0x04
	bool m_bRegistered; // 0x08
	const char *m_pszName; // 0x0C
	const char *m_pszHelpString; // 0x10
	int m_nFlags; // 0x14
 
	ConCommandBase *s_pConCommandBases; // 0x18
	IConCommandBaseAccessor *s_pAccessor; // 0x1C
};



typedef bool (*RegisterConCommandBase_ptr)(IConCommandBaseAccessor*, ConCommandBase*);
typedef RegisterConCommandBase_ptr *RegisterConCommandBase_ptr_ptr;

//-----------------------------------------------------------------------------
// Any executable that wants to use ConVars need to implement one of
// these to hook up access to console variables.
//-----------------------------------------------------------------------------
struct IConCommandBaseAccessor
{
    RegisterConCommandBase_ptr_ptr accessorFunc;
};

bool RegisterConCommandBase(IConCommandBaseAccessor *acc, ConCommandBase *pVar)
{
    //TODO: console support, this is an ok starting point for making it work
    //NOTE: some commands aren't listed, like download_depot. Why?
    //NOTE: I don't know if the steam client contains ConVars as well as ConCommands
    DEBUG_MSG << "[ConCommands] ConCommand added: " << pVar->m_pszName << " : " << pVar->m_pszHelpString << ", flags: " << pVar->m_nFlags << std::endl;
    pVar->m_bRegistered = true;
    return true;
}

void Application::InitApplication()
{
    if (qobject_cast<QApplication *>(QApp))
    {
      // start GUI version
      std::cout << "[Application] Starting GUI" << std::endl;

      // Loading settings
      settings = new QSettings("OpenSteamClient", "OpenSteam");

      // First we start the service, as it is used almost immediately
      int serviceStartCode = Global_SteamServiceMgr->StartRemoteService();
      if (serviceStartCode != 0) {
        std::cout << "[Application] Failed to start steamserviced. VAC may not work. " << std::endl;
      }

      QMetaObject::invokeMethod(Global_ThreadController, &ThreadController::startThreads, Qt::ConnectionType::DirectConnection);

      Global_SteamClientMgr->CreateClientEngine();
      Global_SteamClientMgr->InitHSteamPipeAndHSteamUser();
      Global_SteamClientMgr->CreateUserlessInterfaces();
      Global_SteamClientMgr->ClientUtils->SetLauncherType(k_ELauncherTypeClientUI);
      Global_SteamClientMgr->ClientEngine->SetClientCommandLine(Global_CommandLine->argc, Global_CommandLine->argv);

      // I'm not exactly sure how this works and why it's done like this....
      IConCommandBaseAccessor acc;
      RegisterConCommandBase_ptr ptr = &RegisterConCommandBase;
      acc.accessorFunc = &ptr;
      Global_SteamClientMgr->ClientEngine->ConCommandInit((void *)&acc);

      // Create the appmanager and register handlers
      appManager = new AppManager();

      // Set the .desktop file name (needed for the icon to work)
      qobject_cast<QApplication *>(QApp)->setDesktopFileName("opensteamclient");

      // Connect loading screen logic
      connect(Global_ThreadController->callbackThread, &CallbackThread::PostLogonState, this, &Application::postLogonState);
    }
    else
    {
      //TODO: non-gui version (maybe a cli)
      std::cerr << "[Application] No GUIless version yet" << std::endl;
      exit(EXIT_FAILURE);
    }
}
int Application::StartApplication() {
  int returncode;
  if (IsGUIBoot()) {
    progDialog = new StartupProgressDialog();
    loginWindow = new LoginWindow();
    Global_SteamClientMgr->ClientUtils->SetClientUIProcess();
    QString loginUser = settings->value("LoginInfo/LoginUser").value<QString>();

    if (loginUser.isEmpty()) {
      loginWindow->show();
    }
    else
    {
      progDialog->UpdateProgressText(QString("Logging on %1").arg(loginUser));
      progDialog->show();

      connect(Global_ThreadController->callbackThread, &CallbackThread::SteamServerConnectFailure, this, &Application::loginFailed);
      connect(Global_ThreadController->callbackThread, &CallbackThread::SteamServersConnected, this, &Application::loginSucceeded);

      // Check that there is cached credentials first
      std::string loginUserStr = loginUser.toStdString();

      // Set the username incase the user needs to re-enter their credentials
      loginWindow->setUsername(loginUser.toStdString());

      if (Global_SteamClientMgr->ClientUser->BHasCachedCredentials(loginUserStr.c_str())) {
        Global_SteamClientMgr->ClientUser->SetLogonNameForCachedCredentialLogin(loginUserStr.c_str());
        auto steamid = Global_SteamClientMgr->ClientUser->GetSteamId(loginUserStr.c_str());

        this->currentUserSteamID = steamid.ConvertToUint64();
        
        Global_SteamClientMgr->ClientUser->LogOn(steamid, true);
      } else {
        loginFailed(*new SteamServerConnectFailure_t {m_eResult: EResult::k_EResultRequirePasswordReEntry});
      }
    }
    
    returncode = QApplication::instance()->exec();
  } else {
    // CLI/daemon/other startup here
    returncode = -1;
  }
  Shutdown();
  return returncode;
}

void Application::Shutdown(bool bRestoreValveSteam) {
  std::cout << "[Application] Stopping OpenSteam" << std::endl;

  // Kill the service first, these other steps fail often
  Global_SteamServiceMgr->KillRemoteService();

  QApp->quit();
  Global_ThreadController->StopThreadsBlocking();
  Global_SteamClientMgr->ClientAppManager->SetDownloadingEnabled(false);
  Global_SteamClientMgr->ClientUser->LogOff();
  Global_SteamClientMgr->Shutdown();

  if (bRestoreValveSteam) {
    Global_Bootstrapper->Relaunch(true, {"--bootstrapper-restore-valvesteam"});
  }

  exit(EXIT_SUCCESS);
}

void Application::quitApp() {
  mainWindow->hide();
  Shutdown();
}

void Application::quitAppAndRestoreValveSteam() {
  mainWindow->hide();
  Shutdown(true);
}

void Application::loginFailed(SteamServerConnectFailure_t result) {
  QMessageBox msgBox;
  msgBox.setText("Failed to log on.");
  msgBox.setInformativeText(QString("Error code is %1").arg(result.m_eResult));
  msgBox.exec();
  progDialog->hide();
  loginWindow->show();
  disconnect(Global_ThreadController->callbackThread, &CallbackThread::SteamServerConnectFailure, this, &Application::loginFailed);
  disconnect(Global_ThreadController->callbackThread, &CallbackThread::SteamServersConnected, this, &Application::loginSucceeded);
}

void Application::loginSucceeded(SteamServersConnected_t result) {
  progDialog->UpdateProgressText("Waiting for steamclient...");
}

void Application::postLogonState(PostLogonState_t state) {
  if (state.logonComplete) {
    if (hasLogonCompleted) {
      std::cerr << "[Application] Received PostLogonState_t with logonComplete true but it had been already sent before?" << std::endl;
      return;
    }
    hasLogonCompleted = true;

    progDialog->hide();
    mainWindow = new MainWindow();
    mainWindow->show();
  }
}
#include "startup.h"
#include "../globals.h"
#include "../gui/application.h"
#include "../interop/appmanager.h"
#include "../urlprotocol.h"
#include "updater.h"
#include "bootstrapper.h"
#include "../ext/steamservice.h"
#include "../misc_logic/singleinstance.h"
#include <sys/resource.h>
#include <QMainWindow>
#include <QApplication>
#include <QThread>
#include <QDialog>
#include <QProgressDialog>

SteamClientMgr     *Global_SteamClientMgr;
SteamServiceMgr    *Global_SteamServiceMgr;
bool                Global_debugCbLogging = false;
ThreadController   *Global_ThreadController;

URLProtocolHandler *Global_URLProtocolHandler;
AppManager         *Global_AppManager;

CommandLine        *Global_CommandLine;

Updater            *Global_Updater;

void Startup::InitQT() {
    // This creates the Application class if it didn't already exist
    Application::GetApplication();
}

void Startup::SetLaunchArgs(int argc, char *argv[]) {
    Global_CommandLine = new CommandLine();
    Global_CommandLine->SetLaunchCommandLine(argc, argv);
}

void Startup::InitGlobals() {
    Global_Updater = new Updater();
    Global_AppManager = new AppManager();
    Global_URLProtocolHandler = new URLProtocolHandler();
}

void Startup::MaxOpenDescriptorsCheck() {
    rlimit limit;
    rlim_t was;
    getrlimit(RLIMIT_NOFILE, &limit);
    was = limit.rlim_cur;
    if (limit.rlim_cur < limit.rlim_max) {
        limit.rlim_cur = limit.rlim_max;
        setrlimit(RLIMIT_NOFILE, &limit);
    }
    if (Global_debugCbLogging) {
        std::cout << "RLIMIT_NOFILE set to " << limit.rlim_cur << ", was " << was << std::endl;
    }
}

void Startup::SetUpdaterFilesDir() {
//TODO: this should be moved somewhere more appropriate
// When this is packaged all our binaries should reside in the same folder so the bootstrapper can copy them (like in /usr/lib/opensteam/)

    if (getenv("UPDATER_FILES_DIR") == NULL)
    {
        auto newpath = std::filesystem::canonical(std::filesystem::read_symlink("/proc/self/exe")).parent_path();
        DEBUG_MSG << "Setting UPDATER_FILES_DIR to " << newpath << std::endl;
        setenv("UPDATER_FILES_DIR", newpath.string().c_str(), 0);
    }

}
void Startup::SingleInstanceChecks() {
    auto thispid = PIDUtils::GetPid();
    DEBUG_MSG << "Our PID is " << thispid << std::endl;

    //TODO: implement signals and make global
    auto singleinstancemgr = new SingleInstanceMgr(thispid);
    if (singleinstancemgr->BCheckForInstance()) {
        std::cout << "OpenSteamClient is already running; sending args to instance [PID:" << singleinstancemgr->GetInstancePid() << "]" << std::endl;
        singleinstancemgr->SendArgvToInstance(Global_CommandLine->argc, Global_CommandLine->argv);
        exit(EXIT_SUCCESS);
    } else {
        singleinstancemgr->SetThisProcessAsInstance();
        DEBUG_MSG << "Registered this process as the instance." << std::endl;
    }
}
void Startup::RunBootstrapper() {
    DEBUG_MSG << "RunBootstrapper" << std::endl;
    auto bootstrapper = new Bootstrapper();
    if (Global_CommandLine->HasOption("--bootstrapper-restore-valvesteam")) {
        try
        {
            bootstrapper->SetValveSteamActive();
        }
        catch(const std::exception& e)
        {
            std::cerr << "Failed to restore ValveSteam: " << e.what() << std::endl;
            exit(EXIT_FAILURE);
        }

        std::cout << "ValveSteam has been restored, you can now safely start it. " << std::endl;
        exit(EXIT_SUCCESS);
    }

    DEBUG_MSG << "RunBootstrap" << std::endl;
    bootstrapper->RunBootstrap();

    Global_SteamClientMgr = new SteamClientMgr();
    Global_SteamServiceMgr = new SteamServiceMgr();

    if (Global_SteamClientMgr->BFailedLoad()) {
        if (getenv("UPDATER_RAN_ONCE") == NULL)
        {
            std::cerr << "Failed to load steamclient.so; verifying and restarting. " << std::endl;
            Global_Updater->Verify(true);
            bootstrapper->Restart(true);
        } else {
            std::cerr << "Failed to load steamclient.so after verification. " << std::endl;
            exit(EXIT_FAILURE);
        }
    }
}

int Startup::UIMain() {
    return Application::GetApplication()->StartApplication();
}

void Startup::InitApplication() {
    Application::GetApplication()->InitApplication();
}

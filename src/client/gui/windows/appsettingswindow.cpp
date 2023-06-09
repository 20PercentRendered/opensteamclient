#include "appsettingswindow.h"
#include "ui_appsettingswindow.h"
#include "../../ext/steamclient.h"
#include <QTabBar>
#include <QFileDialog>
#include <opensteamworks/IClientAppManager.h>
#include <opensteamworks/IClientCompat.h>
#include "../application.h"
#include "../../interop/appmanager.h"

//TODO: setting the default compat tool
// This is done by using appid 0 instead of an actual app's id
// If this isn't done, some games will download EmptySteamDepot's or otherwise unsupported linux depots.

AppSettingsWindow::AppSettingsWindow(QWidget *parent) :
    QDialog(parent),
    ui(new Ui::AppSettingsWindow)
{
    ui->setupUi(this);

    LoadLibraryFolders();
    LoadCheckboxValues();
    LoadCompatData();
}

void AppSettingsWindow::LoadLibraryFolders() 
{
    Global_SteamClientMgr->ClientAppManager->RefreshLibraryFolders();
    ui->libraryFolders->clear();
    char *path = new char[4096];
    char *label = new char[256];

    for (size_t i = 0; i < Global_SteamClientMgr->ClientAppManager->GetNumLibraryFolders(); i++)
    {
        auto item = new QListWidgetItem();

        Global_SteamClientMgr->ClientAppManager->GetLibraryFolderPath(i, path, 4096);
        Global_SteamClientMgr->ClientAppManager->GetLibraryFolderLabel(i, label, 256);

        item->setText(QString::fromStdString(std::to_string(i).append(": ").append(path).append(" (").append(label).append(")")));
        item->setData(Qt::UserRole, QVariant((int)i));

        ui->libraryFolders->addItem(item);

    }

    delete[] path;
    delete[] label;
    
    ui->libraryFolders->setCurrentRow(0);
}

void AppSettingsWindow::LoadCheckboxValues() {
    ui->allowDownloadsWhilePlayingCheck->setChecked(Global_SteamClientMgr->ClientAppManager->BAllowDownloadsWhileAnyAppRunning());
    ui->autoLoginFriendsNetwork_box->setChecked(Application::GetApplication()->settings->value("Settings_Friends/AutoLoginToFriendsNetwork").toBool());
}

void AppSettingsWindow::LoadCompatData() 
{
    ui->enableCompatToolsCheck->setChecked(Global_SteamClientMgr->ClientCompat->BIsCompatLayerEnabled());

    ui->defaultWOLCompatTool->clear();

    std::string currentCompatTool;
    if (ui->enableCompatToolsCheck->isChecked()) {
        for (auto &&i : Application::GetApplication()->appManager->compatTools)
        {
            if (!i->windowsOnLinuxTool) {
                std::cout << "nop" << std::endl;
                continue;
            }

            std::cout << "tool is " << i->humanName << std::endl;
            ui->defaultWOLCompatTool->addItem(QString::fromStdString(i->humanName), QString::fromStdString(i->name));
            if (i->name == Global_SteamClientMgr->ClientCompat->GetCompatToolName(0)) {
                currentCompatTool = i->name;
            }
        }
    }

    std::cout << "default tool is " << currentCompatTool << std::endl;
    
    ui->defaultWOLCompatTool->setCurrentText(QString::fromStdString(currentCompatTool));
}

AppSettingsWindow::~AppSettingsWindow()
{
    delete ui;
}

void AppSettingsWindow::on_libraryFolders_currentItemChanged(QListWidgetItem *current, QListWidgetItem *previous)
{
    if (ui->libraryFolders->currentItem() == nullptr) {
        return;
    }

    //TODO: show installed games and the library folder size 
    
    //LibraryFolder_t folder = current->data(Qt::UserRole).toInt();

}

void AppSettingsWindow::on_addFolderButton_clicked()
{
    QString path = QFileDialog::getExistingDirectory(this, ("Select library folder"), QDir::currentPath());
    if (path.isEmpty()) {
        return;
    }

    std::string pathStr = path.toStdString();
    Global_SteamClientMgr->ClientAppManager->AddLibraryFolder(pathStr.c_str());
    LoadLibraryFolders();
}

void AppSettingsWindow::on_deleteFolderButton_clicked()
{   
    if (ui->libraryFolders->currentItem() == nullptr) {
        return;
    }
    LibraryFolder_t folder = ui->libraryFolders->currentItem()->data(Qt::UserRole).toInt();
    // Note: no idea what those two bools do, but the official client uses false for both
    Global_SteamClientMgr->ClientAppManager->RemoveLibraryFolder(folder, false, false);
    LoadLibraryFolders();
}


void AppSettingsWindow::on_enableCompatToolsCheck_stateChanged(int arg1)
{
    Global_SteamClientMgr->ClientCompat->EnableCompat((bool)arg1);
}


void AppSettingsWindow::on_allowDownloadsWhilePlayingCheck_stateChanged(int arg1)
{
    Global_SteamClientMgr->ClientAppManager->SetAllowDownloadsWhileAnyAppRunning((bool)arg1);
}


void AppSettingsWindow::on_autoLoginFriendsNetwork_box_stateChanged(int arg1)
{
    Application::GetApplication()->settings->setValue("Settings_Friends/AutoLoginToFriendsNetwork", QVariant::fromValue<bool>((bool)arg1));
}

void AppSettingsWindow::on_defaultWOLCompatTool_currentIndexChanged(int index)
{
    QString name;
    std::string nameStdString;
    if (index > -1) {
        name = ui->defaultWOLCompatTool->itemData(index).toString();
        nameStdString = name.toStdString();
    }

    Global_SteamClientMgr->ClientCompat->SpecifyCompatTool(0, nameStdString.c_str(), "", 75);
}



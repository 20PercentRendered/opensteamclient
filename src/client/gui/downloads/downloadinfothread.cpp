#include "downloadinfothread.h"
#include "../../ext/steamclient.h"

std::string DownloadInfoThread::ThreadName() {
    return "DownloadInfoPoller";
}

void DownloadInfoThread::ThreadMain()
{
    uint64 totalDownloadedLast = 0;
    DownloadSpeedInfo speedInfo;
    AppId_t prevDownloadingApp = 0;
    do
    {
        DownloadStats_s stats;
        Global_SteamClientMgr->ClientAppManager->GetDownloadStats(&stats);

        speedInfo.downloadSpeed = (stats.totalDownloaded - totalDownloadedLast);
        totalDownloadedLast = stats.totalDownloaded;
        speedInfo.totalDownloaded = stats.totalDownloaded;

        if (speedInfo.downloadSpeed > speedInfo.topDownloadSpeed) {
            speedInfo.topDownloadSpeed = speedInfo.downloadSpeed;
        }

        DEBUG_MSG << "[DownloadInfoThread] DOWNLOAD STAT DEBUG: connectedServers: " << stats.currentConnectionsCount << " total: " << stats.totalDownloaded << " estimatedSpeed: " << stats.estimatedDownloadSpeed << " speed: " << std::to_string(speedInfo.downloadSpeed) << " topspeed: " << std::to_string(speedInfo.topDownloadSpeed) << std::endl;
        emit DownloadSpeedUpdate(speedInfo);

        if (prevDownloadingApp != Global_SteamClientMgr->ClientAppManager->GetDownloadingAppID()) {
            prevDownloadingApp = Global_SteamClientMgr->ClientAppManager->GetDownloadingAppID();
            emit DownloadingAppChange(prevDownloadingApp);
        }
        
        std::this_thread::sleep_for(std::chrono::milliseconds(1000));
    } while (!shouldStop);
}
void DownloadInfoThread::StopThread() {
    this->shouldStop = true;
}
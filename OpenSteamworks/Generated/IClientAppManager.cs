//==========================  AUTO-GENERATED FILE  ================================
//
// This file is partially auto-generated.
// If functions are removed, your changes to that function will be lost.
// Parameter types and names however are preserved if the function stays unchanged.
// Feel free to change parameters to be more accurate. 
// Do not use C#s unsafe features in these files. It breaks JIT.
//
//=============================================================================

using System;

namespace OpenSteamworks.Generated;

public interface IClientAppManager
{
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret InstallApp();  // argc: 3, index: 1
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UninstallApp();  // argc: 1, index: 2
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret LaunchApp();  // argc: 4, index: 3
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ShutdownApp();  // argc: 2, index: 4
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAppInstallState();  // argc: 1, index: 5
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAppInstallDir();  // argc: 3, index: 6
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAppContentInfo();  // argc: 6, index: 7
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAppStagingInfo();  // argc: 3, index: 8
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IsAppDlcInstalled();  // argc: 2, index: 9
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetDlcDownloadProgress();  // argc: 4, index: 10
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BIsDlcEnabled();  // argc: 3, index: 11
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetDlcEnabled();  // argc: 3, index: 12
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetDlcContext();  // argc: 2, index: 13
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetDlcSizes();  // argc: 4, index: 14
    public unknown_ret GetNumInstalledApps();  // argc: 0, index: 15
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetInstalledApps();  // argc: 2, index: 16
    public unknown_ret BIsWaitingForInstalledApps();  // argc: 0, index: 17
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAppDependencies();  // argc: 3, index: 18
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetDependentApps();  // argc: 3, index: 19
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetUpdateInfo();  // argc: 2, index: 20
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAppConfigValue();  // argc: 4, index: 21
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetAppConfigValue();  // argc: 3, index: 22
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BIsAppUpToDate();  // argc: 1, index: 23
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAvailableLanguages();  // argc: 4, index: 24
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetCurrentLanguage(AppId_t app, ref string outLang, uint unk1);  // argc: 3, index: 25
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetCurrentLanguage(AppId_t app);  // argc: 1, index: 26
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFallbackLanguage();  // argc: 2, index: 27
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetCurrentLanguage();  // argc: 2, index: 28
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret StartValidatingApp();  // argc: 1, index: 29
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CancelValidation();  // argc: 1, index: 30
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret MarkContentCorrupt();  // argc: 2, index: 31
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetInstalledDepots();  // argc: 3, index: 32
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFileDetails();  // argc: 2, index: 33
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret VerifySignedFiles();  // argc: 1, index: 34
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAvailableBetas();  // argc: 5, index: 35
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CheckBetaPassword();  // argc: 2, index: 36
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BHasCachedBetaPassword();  // argc: 2, index: 37
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetActiveBeta();  // argc: 3, index: 38
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BGetActiveBetaForApps();  // argc: 2, index: 39
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetDownloadingEnabled();  // argc: 1, index: 40
    public unknown_ret BIsDownloadingEnabled();  // argc: 0, index: 41
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetDownloadStats();  // argc: 1, index: 42
    public unknown_ret GetDownloadingAppID();  // argc: 0, index: 43
    public unknown_ret GetAutoUpdateTimeRestrictionEnabled();  // argc: 0, index: 44
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetAutoUpdateTimeRestrictionEnabled();  // argc: 1, index: 45
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAutoUpdateTimeRestrictionHours();  // argc: 2, index: 46
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetAutoUpdateTimeRestrictionStartHour();  // argc: 1, index: 47
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetAutoUpdateTimeRestrictionEndHour();  // argc: 1, index: 48
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAppAutoUpdateBehavior();  // argc: 1, index: 49
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetAppAutoUpdateBehavior();  // argc: 2, index: 50
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetAppAllowDownloadsWhileRunningBehavior();  // argc: 2, index: 51
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAppAllowDownloadsWhileRunningBehavior();  // argc: 1, index: 52
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetAllowDownloadsWhileAnyAppRunning();  // argc: 1, index: 53
    public unknown_ret BAllowDownloadsWhileAnyAppRunning();  // argc: 0, index: 54
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ChangeAppDownloadQueuePlacement();  // argc: 2, index: 55
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetAppDownloadQueueIndex();  // argc: 2, index: 56
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAppDownloadQueueIndex();  // argc: 1, index: 57
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAppAutoUpdateDelayedUntilTime();  // argc: 1, index: 58
    public unknown_ret GetNumAppsInDownloadQueue();  // argc: 0, index: 59
    public unknown_ret BHasLocalContentServer();  // argc: 0, index: 60
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BuildBackup();  // argc: 4, index: 61
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BuildInstaller();  // argc: 4, index: 62
    public unknown_ret CancelBackup();  // argc: 0, index: 63
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RestoreAppFromBackup();  // argc: 2, index: 64
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RecoverAppFromFolder();  // argc: 2, index: 65
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CanMoveApp();  // argc: 2, index: 66
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret MoveApp();  // argc: 2, index: 67
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetMoveAppProgress();  // argc: 4, index: 68
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CancelMoveApp();  // argc: 1, index: 69
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAppStateInfo();  // argc: 2, index: 70
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BGetAppStateInfoForApps();  // argc: 2, index: 71
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BIsAvailableOnPlatform();  // argc: 2, index: 72
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BCanRemotePlayTogether();  // argc: 1, index: 73
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BIsLocalMultiplayerApp();  // argc: 1, index: 74
    public unknown_ret GetNumLibraryFolders();  // argc: 0, index: 75
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLibraryFolderPath();  // argc: 3, index: 76
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddLibraryFolder();  // argc: 1, index: 77
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetLibraryFolderLabel();  // argc: 2, index: 78
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLibraryFolderLabel();  // argc: 3, index: 79
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RemoveLibraryFolder();  // argc: 3, index: 80
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BGetLibraryFolderInfo();  // argc: 4, index: 81
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAppLibraryFolder();  // argc: 1, index: 82
    public unknown_ret RefreshLibraryFolders();  // argc: 0, index: 83
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetNumAppsInFolder();  // argc: 1, index: 84
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAppsInFolder();  // argc: 3, index: 85
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ForceInstallDirOverride();  // argc: 1, index: 86
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetDownloadThrottleRateKbps();  // argc: 2, index: 87
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetDownloadThrottleRateKbps();  // argc: 1, index: 88
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SuspendDownloadThrottling();  // argc: 1, index: 89
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetThrottleDownloadsWhileStreaming();  // argc: 1, index: 90
    public unknown_ret BThrottleDownloadsWhileStreaming();  // argc: 0, index: 91
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLaunchQueryParam();  // argc: 2, index: 92
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BeginLaunchQueryParams();  // argc: 1, index: 93
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetLaunchQueryParam();  // argc: 3, index: 94
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CommitLaunchQueryParams();  // argc: 2, index: 95
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLaunchCommandLine();  // argc: 3, index: 96
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddContentLogLine();  // argc: 1, index: 97
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetUseHTTPSForDownloads();  // argc: 1, index: 98
    public unknown_ret GetUseHTTPSForDownloads();  // argc: 0, index: 99
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetPeerContentServerMode();  // argc: 1, index: 100
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetPeerContentClientMode();  // argc: 1, index: 101
    public unknown_ret GetPeerContentServerMode();  // argc: 0, index: 102
    public unknown_ret GetPeerContentClientMode();  // argc: 0, index: 103
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetPeerContentServerStats();  // argc: 1, index: 104
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SuspendPeerContentClient();  // argc: 1, index: 105
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SuspendPeerContentServer();  // argc: 1, index: 106
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetPeerContentServerForApp();  // argc: 3, index: 107
}
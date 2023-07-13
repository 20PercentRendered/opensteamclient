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
using OpenSteamworks.Enums;

namespace OpenSteamworks.Generated;

public interface IClientUtils
{
    public string GetInstallPath();  // argc: 0, index: 1
    public string GetUserBaseFolderInstallImage();  // argc: 0, index: 2
    public string GetManagedContentRoot();  // argc: 0, index: 3
    public RTime32 GetSecondsSinceAppActive();  // argc: 0, index: 4
    public RTime32 GetSecondsSinceComputerActive();  // argc: 0, index: 5
    public void SetComputerActive();  // argc: 0, index: 6
    public EUniverse GetConnectedUniverse();  // argc: 0, index: 7
    public unknown_ret GetSteamRealm();  // argc: 0, index: 8
    public unknown_ret GetServerRealTime();  // argc: 0, index: 9
    public unknown_ret GetIPCountry();  // argc: 0, index: 10
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetImageSize();  // argc: 3, index: 11
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetImageRGBA();  // argc: 3, index: 12
    public unknown_ret GetNumRunningApps();  // argc: 0, index: 13
    public unknown_ret GetCurrentBatteryPower();  // argc: 0, index: 14
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetBatteryInformation();  // argc: 2, index: 15
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetOfflineMode(bool offline);  // argc: 1, index: 16
    public bool GetOfflineMode();  // argc: 0, index: 17
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetAppIDForCurrentPipe();  // argc: 2, index: 18
    public AppId_t GetAppID();  // argc: 0, index: 19
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetAPIDebuggingActive();  // argc: 2, index: 20
    public unknown_ret AllocPendingAPICallHandle();  // argc: 0, index: 21
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IsAPICallCompleted();  // argc: 3, index: 22
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAPICallFailureReason();  // argc: 2, index: 23
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAPICallResult();  // argc: 6, index: 24
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetAPICallResultWithoutPostingCallback();  // argc: 5, index: 25
    public unknown_ret SignalAppsToShutDown();  // argc: 0, index: 26
    public unknown_ret SignalServiceAppsToDisconnect();  // argc: 0, index: 27
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret TerminateAllApps();  // argc: 1, index: 28
    public unknown_ret GetCellID();  // argc: 0, index: 29
    public unknown_ret BIsGlobalInstance();  // argc: 0, index: 30
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CheckFileSignature();  // argc: 1, index: 31
    public unknown_ret GetBuildID();  // argc: 0, index: 32
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetCurrentUIMode();  // argc: 1, index: 33
    public unknown_ret GetCurrentUIMode();  // argc: 0, index: 34
    public unknown_ret BIsWebBasedUIMode();  // argc: 0, index: 35
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ShutdownLauncher();  // argc: 2, index: 36
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetLauncherType();  // argc: 1, index: 37
    public unknown_ret GetLauncherType();  // argc: 0, index: 38
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ShowGamepadTextInput();  // argc: 5, index: 39
    public unknown_ret GetEnteredGamepadTextLength();  // argc: 0, index: 40
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetEnteredGamepadTextInput();  // argc: 2, index: 41
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GamepadTextInputClosed();  // argc: 3, index: 42
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ShowControllerLayoutPreview();  // argc: 3, index: 43
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetSpew();  // argc: 3, index: 44
    public bool BDownloadsDisabled();  // argc: 0, index: 45
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetFocusedWindow();  // argc: 4, index: 46
    public unknown_ret GetSteamUILanguage();  // argc: 0, index: 47
    public unknown_ret CheckSteamReachable();  // argc: 0, index: 48
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetLastGameLaunchMethod();  // argc: 1, index: 49
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetVideoAdapterInfo();  // argc: 7, index: 50
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetOverlayWindowFocusForPipe();  // argc: 3, index: 51
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetGameOverlayUIInstanceFocusGameID();  // argc: 2, index: 52
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFocusedGameWindow();  // argc: 2, index: 53
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetControllerConfigFileForAppID();  // argc: 2, index: 54
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetControllerConfigFileForAppID();  // argc: 3, index: 55
    public unknown_ret IsSteamRunningInVR();  // argc: 0, index: 56
    public unknown_ret BIsRunningOnAlienwareAlpha();  // argc: 0, index: 57
    public unknown_ret StartVRDashboard();  // argc: 0, index: 58
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IsVRHeadsetStreamingEnabled();  // argc: 1, index: 59
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetVRHeadsetStreamingEnabled();  // argc: 2, index: 60
    public unknown_ret GenerateSupportSystemReport();  // argc: 0, index: 61
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetSupportSystemReport();  // argc: 4, index: 62
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAppIdForPid();  // argc: 2, index: 63
    public unknown_ret SetClientUIProcess();  // argc: 0, index: 64
    public unknown_ret BIsClientUIInForeground();  // argc: 0, index: 65
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AllowSetForegroundThroughWebhelper();  // argc: 1, index: 66
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetOverlayBrowserInfo();  // argc: 8, index: 67
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ClearOverlayBrowserInfo();  // argc: 1, index: 68
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetOverlayBrowserInfo();  // argc: 3, index: 69
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetOverlayNotificationPosition();  // argc: 2, index: 70
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetOverlayNotificationInset();  // argc: 3, index: 71
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DispatchClientUINotification();  // argc: 3, index: 72
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RespondToClientUINotification();  // argc: 3, index: 73
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DispatchClientUICommand();  // argc: 2, index: 74
    public unknown_ret DispatchComputerActiveStateChange();  // argc: 0, index: 75
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DispatchOpenURLInClient();  // argc: 3, index: 76
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdateWideVineCDM();  // argc: 1, index: 77
    public unknown_ret DispatchClearAllBrowsingData();  // argc: 0, index: 78
    public unknown_ret DispatchClientSettingsChanged();  // argc: 0, index: 79
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DispatchClientPostMessage();  // argc: 3, index: 80
    public unknown_ret IsSteamChina();  // argc: 0, index: 81
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret NeedsSteamChinaWorkshop();  // argc: 1, index: 82
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret InitFilterText();  // argc: 2, index: 83
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FilterText();  // argc: 7, index: 84
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetIPv6ConnectivityState();  // argc: 1, index: 85
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ScheduleConnectivityTest();  // argc: 2, index: 86
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetConnectivityTestState();  // argc: 1, index: 87
    public unknown_ret GetCaptivePortalURL();  // argc: 0, index: 88
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RecordSteamInterfaceCreation();  // argc: 2, index: 89
    public unknown_ret GetCloudGamingPlatform();  // argc: 0, index: 90
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BGetMacAddresses();  // argc: 3, index: 91
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BGetDiskSerialNumber();  // argc: 2, index: 92
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetSteamEnvironmentForApp();  // argc: 3, index: 93
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret TestHTTP();  // argc: 1, index: 94
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DumpJobs();  // argc: 1, index: 95
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ShowFloatingGamepadTextInput();  // argc: 6, index: 96
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DismissFloatingGamepadTextInput();  // argc: 1, index: 97
    public unknown_ret FloatingGamepadTextInputDismissed();  // argc: 0, index: 98
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetGameLauncherMode();  // argc: 2, index: 99
    public unknown_ret ClearAllHTTPCaches();  // argc: 0, index: 100
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFocusedGameID();  // argc: 1, index: 101
    public unknown_ret GetFocusedWindowPID();  // argc: 0, index: 102
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetWebUITransportWebhelperPID();  // argc: 1, index: 103
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetWebUITransportInfo();  // argc: 1, index: 104
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RecordFakeReactRouteMetric();  // argc: 1, index: 105
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SteamRuntimeSystemInfo();  // argc: 1, index: 106
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DumpHTTPClients();  // argc: 1, index: 107
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BGetMachineID();  // argc: 1, index: 108
}
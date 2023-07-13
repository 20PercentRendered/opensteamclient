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

public interface IClientControllerSerialized
{
    // WARNING: Do not use this function! Unknown behaviour will occur!
    public unknown_ret Unknown_0_DONTUSE();  // argc: -1, index: 1
    // WARNING: Do not use this function! Unknown behaviour will occur!
    public unknown_ret Unknown_1_DONTUSE();  // argc: -1, index: 2
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ShowBindingPanel();  // argc: 3, index: 3
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetControllerTypeForHandle();  // argc: 2, index: 4
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetGamepadIndexForHandle();  // argc: 2, index: 5
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetHandleForGamepadIndex();  // argc: 1, index: 6
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetActionSetHandle();  // argc: 2, index: 7
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetActionSetHandleByTitle();  // argc: 2, index: 8
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ActivateActionSet();  // argc: 5, index: 9
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ActivateActionSetLayer();  // argc: 5, index: 10
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DeactivateActionSetLayer();  // argc: 5, index: 11
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DeactivateAllActionSetLayers();  // argc: 3, index: 12
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetActiveActionSetLayers();  // argc: 4, index: 13
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetDigitalActionHandle();  // argc: 3, index: 14
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAnalogActionHandle();  // argc: 3, index: 15
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret StopAnalogActionMomentum();  // argc: 4, index: 16
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnableDeviceCallbacks();  // argc: 1, index: 17
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetStringForDigitalActionName();  // argc: 5, index: 18
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetStringForAnalogActionName();  // argc: 5, index: 19
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BCheckGameDirectoryAndReloadConfigIfNecessary();  // argc: 3, index: 20
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetActionManifestPath(bool unk1);  // argc: 1, index: 21
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetActionManifestPath(double unk1, bool unk2);  // argc: 2, index: 22
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DumpConfigurationToDisk();  // argc: 1, index: 23
    public unknown_ret FlushCloudedConfigFilesToDisk();  // argc: 0, index: 24
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret StartBindingVisualization();  // argc: 3, index: 25
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret StopBindingVisualization();  // argc: 2, index: 26
    public unknown_ret GetNumConnectedControllers();  // argc: 0, index: 27
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAllControllersStatus();  // argc: 1, index: 28
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetControllerDetails();  // argc: 1, index: 29
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FactoryReset();  // argc: 1, index: 30
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetDefaultConfig();  // argc: 1, index: 31
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CalibrateTrackpads();  // argc: 1, index: 32
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CalibrateJoystick();  // argc: 1, index: 33
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CalibrateIMU();  // argc: 1, index: 34
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetAudioMapping();  // argc: 2, index: 35
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret PlayAudio();  // argc: 2, index: 36
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ResetStickExtents();  // argc: 1, index: 37
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BIsStreamingController();  // argc: 1, index: 38
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetUserLedColor();  // argc: 4, index: 39
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetRumble();  // argc: 5, index: 40
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetRumbleExtended();  // argc: 7, index: 41
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IdentifyControllerRumbleEffect();  // argc: 1, index: 42
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetGyroAutoCalibrate();  // argc: 2, index: 43
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestGyroActive();  // argc: 3, index: 44
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetGyroCalibrating();  // argc: 2, index: 45
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret LoadConfigFromVDFString();  // argc: 7, index: 46
    public unknown_ret InvalidateBindingCache();  // argc: 0, index: 47
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ActivateConfig();  // argc: 2, index: 48
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret WarmOptInStatus();  // argc: 2, index: 49
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetCurrentActionSetHandleForRunningApp();  // argc: 2, index: 50
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BAnyControllerOptedInAndAvailable();  // argc: 1, index: 51
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetGamepadIndexForControllerIndex();  // argc: 1, index: 52
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CreateBindingInstanceFromVDFString();  // argc: 1, index: 53
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FreeBindingInstance();  // argc: 1, index: 54
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetControllerConfiguration();  // argc: 2, index: 55
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetControllerActionSet();  // argc: 3, index: 56
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetControllerSourceMode();  // argc: 3, index: 57
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DuplicateControllerSourceMode();  // argc: 3, index: 58
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetControllerInputActivator();  // argc: 3, index: 59
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetControllerInputBinding();  // argc: 3, index: 60
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetControllerInputActivatorEnabled();  // argc: 3, index: 61
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetControllerMiscMappingSettings();  // argc: 3, index: 62
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SwapControllerModeInputBindings();  // argc: 3, index: 63
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetControllerModeShiftBinding();  // argc: 3, index: 64
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IsModified();  // argc: 1, index: 65
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ClearModified();  // argc: 1, index: 66
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalizationTokenCount();  // argc: 1, index: 67
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalizationToken();  // argc: 3, index: 68
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalizedString();  // argc: 2, index: 69
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetBindingSetting();  // argc: 3, index: 70
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetBindingSetting();  // argc: 3, index: 71
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetBindingVDFString();  // argc: 1, index: 72
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetSourceGroupBindingCount();  // argc: 2, index: 73
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetSourceGroupBindingInfo();  // argc: 5, index: 74
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetSourceGroupBindingActive();  // argc: 5, index: 75
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CreateSourceGroupBinding();  // argc: 6, index: 76
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BAreLayerAndParentModesEquivalent();  // argc: 3, index: 77
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetGroupSetting();  // argc: 4, index: 78
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetGroupSetting();  // argc: 4, index: 79
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetGroupSettingDefault();  // argc: 4, index: 80
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetGroupSettingUIRange();  // argc: 5, index: 81
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetActivatorSetting();  // argc: 6, index: 82
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetActivatorSetting();  // argc: 6, index: 83
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetActivatorSettingDefault();  // argc: 6, index: 84
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetGroupBinding();  // argc: 7, index: 85
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetGroupBinding();  // argc: 7, index: 86
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RemoveGroupBinding();  // argc: 4, index: 87
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetParentGroupForLayerGroup();  // argc: 3, index: 88
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetParentPresetForLayerPreset();  // argc: 3, index: 89
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetGroupActivatorsForInput();  // argc: 4, index: 90
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ReplaceActivator();  // argc: 5, index: 91
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddActivator();  // argc: 3, index: 92
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RemoveActivator();  // argc: 4, index: 93
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CopyActivator();  // argc: 5, index: 94
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IsActivatorSettingsDefault();  // argc: 4, index: 95
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetModeShiftBinding();  // argc: 5, index: 96
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetModeShiftBinding();  // argc: 6, index: 97
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddActionSet();  // argc: 2, index: 98
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RenameActionSet();  // argc: 2, index: 99
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DeleteActionSet();  // argc: 2, index: 100
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetBindingTitle();  // argc: 2, index: 101
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetBindingTitle();  // argc: 2, index: 102
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetBindingDescription();  // argc: 2, index: 103
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetBindingRevision();  // argc: 3, index: 104
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BBindingMajorRevisionMismatch();  // argc: 1, index: 105
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetBindingDescription();  // argc: 2, index: 106
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetBindingTitleForIndex();  // argc: 4, index: 107
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetBindingDescForIndex();  // argc: 4, index: 108
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetBindingTypeForIndex();  // argc: 2, index: 109
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetConfigBindingInfo();  // argc: 2, index: 110
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetBindingControllerType();  // argc: 2, index: 111
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetBindingControllerType();  // argc: 1, index: 112
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetBindingCreator();  // argc: 3, index: 113
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetBindingCreator();  // argc: 1, index: 114
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetBindingProgenitor();  // argc: 1, index: 115
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetBindingProgenitor();  // argc: 2, index: 116
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetBindingURL();  // argc: 1, index: 117
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetBindingURL();  // argc: 2, index: 118
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetBindingExportType();  // argc: 1, index: 119
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetBindingExportType();  // argc: 2, index: 120
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetConfigFeatures();  // argc: 2, index: 121
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAllBindings();  // argc: 3, index: 122
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BIsXInputActiveForController();  // argc: 1, index: 123
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret PS4SettingsChanged();  // argc: 1, index: 124
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SwitchSettingsChanged();  // argc: 1, index: 125
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ControllerSettingsChanged();  // argc: 1, index: 126
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetTrackpadPressureCurve();  // argc: 3, index: 127
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetDefaultNintendoButtonLayout();  // argc: 1, index: 128
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IsControllerConnected();  // argc: 2, index: 129
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetControllerState();  // argc: 2, index: 130
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret TriggerHapticPulse();  // argc: 6, index: 131
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret TriggerSimpleHapticEvent();  // argc: 5, index: 132
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret TriggerVibration();  // argc: 4, index: 133
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret TriggerVibrationExtended();  // argc: 6, index: 134
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetLEDColor();  // argc: 5, index: 135
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetDonglePairingMode();  // argc: 2, index: 136
    public unknown_ret ReserveSteamController();  // argc: 0, index: 137
    public unknown_ret CancelSteamControllerReservations();  // argc: 0, index: 138
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret OpenStreamingSession();  // argc: 2, index: 139
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CloseStreamingSession();  // argc: 2, index: 140
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdateStreamingSessionInputPermissions();  // argc: 1, index: 141
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret InitiateISPFirmwareUpdate();  // argc: 1, index: 142
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret InitiateBootloaderFirmwareUpdate();  // argc: 1, index: 143
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FlashControllerFirmware();  // argc: 4, index: 144
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret TurnOffController();  // argc: 1, index: 145
    public unknown_ret EnumerateControllers();  // argc: 0, index: 146
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetControllerStatusEvent();  // argc: 2, index: 147
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetActualControllerDetails();  // argc: 2, index: 148
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetControllerIdentity();  // argc: 2, index: 149
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetControllerPersonalization();  // argc: 2, index: 150
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetControllerReverseDiamondLayout();  // argc: 1, index: 151
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BRumbleEnabledByUser();  // argc: 1, index: 152
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BHapticsEnabledByUser();  // argc: 1, index: 153
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetControllerSerialNumber();  // argc: 3, index: 154
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetControllerChipID();  // argc: 3, index: 155
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BSupportsControllerLEDBrightness();  // argc: 1, index: 156
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BSupportsControllerLEDColor();  // argc: 1, index: 157
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BSupportsControllerRumble();  // argc: 1, index: 158
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BSupportsControllerHaptics();  // argc: 1, index: 159
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetControllerPairingConnectionState();  // argc: 2, index: 160
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetControllerKeyboardMouseState();  // argc: 2, index: 161
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetTouchKeysForPopupMenu();  // argc: 4, index: 162
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret PopupMenuTouchKeyClicked();  // argc: 3, index: 163
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AccessControllerInputGeneratorMouseButton();  // argc: 3, index: 164
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetGameActionSets();  // argc: 2, index: 165
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetBaseGameActionSets();  // argc: 2, index: 166
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLayerGameActionSets();  // argc: 2, index: 167
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetGameActionSetById();  // argc: 2, index: 168
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetControllerSetting();  // argc: 2, index: 169
    public unknown_ret GetEmulatedOutputState();  // argc: 0, index: 170
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetSelectedConfigForApp();  // argc: 7, index: 171
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BControllerHasUniqueConfigForAppID();  // argc: 2, index: 172
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DeRegisterController();  // argc: 2, index: 173
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SendOSKeyboardEvent();  // argc: 1, index: 174
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetOSKeyboardKey();  // argc: 2, index: 175
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetMousePosition();  // argc: 3, index: 176
    public unknown_ret GetGamepadIndexChangeCounter();  // argc: 0, index: 177
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BSwapGamepadIndex();  // argc: 3, index: 178
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetGamepadIndexForXInputIndex();  // argc: 1, index: 179
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetControllerIndexForGamepadIndex();  // argc: 1, index: 180
    public unknown_ret GetNumControllersWithDetails();  // argc: 0, index: 181
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ConvertBindingToNewControllerType();  // argc: 2, index: 182
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetControllerActiveAccount();  // argc: 2, index: 183
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret StartControllerRegistrationToAccount();  // argc: 2, index: 184
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CompleteControllerRegistrationToAccount();  // argc: 2, index: 185
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AutoRegisterControllerRegistrationToAccount();  // argc: 2, index: 186
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetConfigForAppAndController();  // argc: 4, index: 187
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetControllerPersonalization();  // argc: 4, index: 188
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetPersonalizationFile();  // argc: 4, index: 189
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetGameWindowPos();  // argc: 4, index: 190
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetGameWindowPos();  // argc: 4, index: 191
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret HasGameMapping();  // argc: 1, index: 192
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetControllerUsageData();  // argc: 2, index: 193
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BAllowAppConfigForController();  // argc: 2, index: 194
    public unknown_ret ResetControllerEnableCache();  // argc: 0, index: 195
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetControllerEnableSupport();  // argc: 1, index: 196
    public unknown_ret BInputGenerated();  // argc: 0, index: 197
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetControllerActivityByType();  // argc: 1, index: 198
    public unknown_ret GetLastActiveControllerVID();  // argc: 0, index: 199
    public unknown_ret GetLastActiveControllerPID();  // argc: 0, index: 200
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret LoadControllerPersonalizationFile();  // argc: 4, index: 201
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SaveControllerPersonalizationFile();  // argc: 4, index: 202
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret LoadRemotePlayControllerPersonalizationVDF();  // argc: 2, index: 203
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FindControllerByPath();  // argc: 1, index: 204
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetControllerPath();  // argc: 2, index: 205
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetControllerProductName();  // argc: 2, index: 206
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetControllerHapticsSetting();  // argc: 2, index: 207
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetControllerRumbleSetting();  // argc: 2, index: 208
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetControllerNintendoLayoutSetting();  // argc: 2, index: 209
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BGetTouchConfigData();  // argc: 6, index: 210
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BSaveTouchConfigLayout();  // argc: 3, index: 211
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetGyroOn();  // argc: 3, index: 212
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CursorVisibilityChanged();  // argc: 1, index: 213
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ForceSimpleHapticEvent();  // argc: 5, index: 214
}
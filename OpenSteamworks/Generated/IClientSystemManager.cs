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

public interface IClientSystemManager
{
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetSettings();  // argc: 1, index: 1
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdateSettings();  // argc: 1, index: 2
    public unknown_ret ShutdownSystem();  // argc: 0, index: 3
    public unknown_ret SuspendSystem();  // argc: 0, index: 4
    public unknown_ret RestartSystem();  // argc: 0, index: 5
    public unknown_ret FactoryReset();  // argc: 0, index: 6
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RebootToFactoryTestImage();  // argc: 1, index: 7
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetDisplayBrightness();  // argc: 1, index: 8
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetDisplayBrightness();  // argc: 1, index: 9
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FormatRemovableStorage();  // argc: 1, index: 10
    public unknown_ret GetOSBranchList();  // argc: 0, index: 11
    public unknown_ret GetCurrentOSBranch();  // argc: 0, index: 12
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SelectOSBranch();  // argc: 1, index: 13
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetUpdateState();  // argc: 1, index: 14
    public unknown_ret CheckForUpdate();  // argc: 0, index: 15
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ApplyUpdate();  // argc: 1, index: 16
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetBackgroundUpdateCheckInterval();  // argc: 1, index: 17
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ClearAudioDefaults();  // argc: 1, index: 18
    public unknown_ret RunDeckMicEnableHack();  // argc: 0, index: 19
    public unknown_ret RunDeckEchoCancellationHack();  // argc: 0, index: 20
}
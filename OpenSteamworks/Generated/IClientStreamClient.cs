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

public interface IClientStreamClient
{
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret Launched();  // argc: 1, index: 1
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FocusGained();  // argc: 2, index: 2
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FocusLost();  // argc: 1, index: 3
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret Finished();  // argc: 2, index: 4
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BGetStreamingClientConfig();  // argc: 1, index: 5
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BSaveStreamingClientConfig();  // argc: 1, index: 6
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetQualityOverride();  // argc: 1, index: 7
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetBitrateOverride();  // argc: 1, index: 8
    public unknown_ret ShowOnScreenKeyboard();  // argc: 0, index: 9
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BQueueControllerConfigMessageForLocal();  // argc: 1, index: 10
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BGetControllerConfigMessageForRemote();  // argc: 1, index: 11
    public unknown_ret GetSystemInfo();  // argc: 0, index: 12
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret StartStreamingSession();  // argc: 1, index: 13
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ReportStreamingSessionEvent();  // argc: 2, index: 14
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FinishStreamingSession();  // argc: 3, index: 15
}
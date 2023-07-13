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

public interface IClientAudio
{
    public unknown_ret StartVoiceRecording();  // argc: 0, index: 1
    public unknown_ret StopVoiceRecording();  // argc: 0, index: 2
    public unknown_ret ResetVoiceRecording();  // argc: 0, index: 3
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAvailableVoice();  // argc: 3, index: 4
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetVoice();  // argc: 9, index: 5
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetCompressedVoice();  // argc: 3, index: 6
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DecompressVoice();  // argc: 6, index: 7
    public unknown_ret GetVoiceOptimalSampleRate();  // argc: 0, index: 8
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BAppUsesVoice();  // argc: 1, index: 9
    public unknown_ret GetGameSystemVolume();  // argc: 0, index: 10
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetGameSystemVolume();  // argc: 1, index: 11
}
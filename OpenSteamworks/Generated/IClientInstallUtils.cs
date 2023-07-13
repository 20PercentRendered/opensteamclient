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

public interface IClientInstallUtils
{
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetUniverse();  // argc: 1, index: 1
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddShortcut();  // argc: 5, index: 2
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RemoveShortcut();  // argc: 1, index: 3
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddUninstallEntry();  // argc: 7, index: 4
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RemoveUninstallEntry();  // argc: 1, index: 5
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddToFirewall();  // argc: 2, index: 6
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RemoveFromFirewall();  // argc: 1, index: 7
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RegisterSteamProtocolHandler();  // argc: 2, index: 8
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddInstallScriptToWhiteList();  // argc: 2, index: 9
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RunInstallScript();  // argc: 3, index: 10
    public unknown_ret GetInstallScriptExitCode();  // argc: 0, index: 11
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ConfigureNetworDeviceIPAddresses();  // argc: 7, index: 12
}
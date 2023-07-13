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

public interface IClientNetworkingUtilsSerialized
{
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetNetworkConfigJSON_DEPRECATED();  // argc: 3, index: 1
    public unknown_ret GetLauncherType();  // argc: 0, index: 2
    public unknown_ret TEST_ClearCachedNetworkConfig();  // argc: 0, index: 3
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret PostConnectionStateMsg();  // argc: 2, index: 4
    public unknown_ret PostConnectionStateUpdatesForAllConnections();  // argc: 0, index: 5
    public unknown_ret PostAppSummaryUpdates();  // argc: 0, index: 6
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GotLocationString();  // argc: 1, index: 7
}
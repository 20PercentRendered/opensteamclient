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

public interface IClientNetworkingSocketsSerialized
{
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SendP2PRendezvous();  // argc: 5, index: 1
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SendP2PConnectionFailureLegacy();  // argc: 5, index: 2
    public unknown_ret GetCertAsync();  // argc: 0, index: 3
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CacheRelayTicket();  // argc: 2, index: 4
    public unknown_ret GetCachedRelayTicketCount();  // argc: 0, index: 5
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetCachedRelayTicket();  // argc: 3, index: 6
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetSTUNServer();  // argc: 3, index: 7
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AllowDirectConnectToPeerString(bool unk1);  // argc: 1, index: 8
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BeginAsyncRequestFakeIP();  // argc: 1, index: 9
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AllowDirectConnectToPeerString(double unk1, bool unk2);  // argc: 1, index: 10
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetAllowShareIPUserSetting();  // argc: 1, index: 11
    public unknown_ret GetAllowShareIPUserSetting();  // argc: 0, index: 12
    public unknown_ret TEST_ClearInMemoryCachedCredentials();  // argc: 0, index: 13
}
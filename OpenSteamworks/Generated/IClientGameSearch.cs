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

public interface IClientGameSearch
{
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddGameSearchParams();  // argc: 2, index: 1
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SearchForGameWithLobby();  // argc: 4, index: 2
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SearchForGameSolo();  // argc: 2, index: 3
    public unknown_ret AcceptGame();  // argc: 0, index: 4
    public unknown_ret DeclineGame();  // argc: 0, index: 5
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RetrieveConnectionDetails();  // argc: 4, index: 6
    public unknown_ret EndGameSearch();  // argc: 0, index: 7
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetGameHostParams();  // argc: 2, index: 8
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetConnectionDetails();  // argc: 2, index: 9
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestPlayersForGame();  // argc: 3, index: 10
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret HostConfirmGameStart();  // argc: 2, index: 11
    public unknown_ret CancelRequestPlayersForGame();  // argc: 0, index: 12
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SubmitPlayerResult();  // argc: 5, index: 13
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EndGame();  // argc: 2, index: 14
}
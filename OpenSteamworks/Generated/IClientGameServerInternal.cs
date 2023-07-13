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

public interface IClientGameServerInternal
{
    // WARNING: Do not use this function! Unknown behaviour will occur!
    public unknown_ret Unknown_0_DONTUSE();  // argc: -1, index: 1
    // WARNING: Do not use this function! Unknown behaviour will occur!
    public unknown_ret Unknown_1_DONTUSE();  // argc: -1, index: 2
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetSDRLogin();  // argc: 1, index: 3
    // WARNING: Do not use this function! Unknown behaviour will occur!
    public unknown_ret Unknown_3_DONTUSE();  // argc: -1, index: 4
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret InitGameServerSerialized();  // argc: 6, index: 5
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetProduct();  // argc: 1, index: 6
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetGameDescription();  // argc: 1, index: 7
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetModDir();  // argc: 1, index: 8
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetDedicatedServer();  // argc: 1, index: 9
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret LogOn();  // argc: 1, index: 10
    public unknown_ret LogOnAnonymous();  // argc: 0, index: 11
    public unknown_ret LogOff();  // argc: 0, index: 12
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetSteamID();  // argc: 1, index: 13
    public unknown_ret BLoggedOn();  // argc: 0, index: 14
    public unknown_ret BSecure();  // argc: 0, index: 15
    public unknown_ret WasRestartRequested();  // argc: 0, index: 16
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetMaxPlayerCount();  // argc: 1, index: 17
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetBotPlayerCount();  // argc: 1, index: 18
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetServerName();  // argc: 1, index: 19
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetMapName();  // argc: 1, index: 20
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetPasswordProtected();  // argc: 1, index: 21
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetSpectatorPort();  // argc: 1, index: 22
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetSpectatorServerName();  // argc: 1, index: 23
    public unknown_ret ClearAllKeyValues();  // argc: 0, index: 24
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetKeyValue();  // argc: 2, index: 25
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetGameTags();  // argc: 1, index: 26
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetGameData();  // argc: 1, index: 27
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetRegion();  // argc: 1, index: 28
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SendUserConnectAndAuthenticate();  // argc: 4, index: 29
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CreateUnauthenticatedUserConnection();  // argc: 1, index: 30
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SendUserDisconnect();  // argc: 2, index: 31
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BUpdateUserData();  // argc: 4, index: 32
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAuthSessionTicket();  // argc: 3, index: 33
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAuthSessionTicketV2();  // argc: 4, index: 34
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BeginAuthSession();  // argc: 4, index: 35
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EndAuthSession();  // argc: 2, index: 36
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CancelAuthTicket();  // argc: 1, index: 37
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IsUserSubscribedAppInTicket();  // argc: 3, index: 38
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestUserGroupStatus();  // argc: 4, index: 39
    public unknown_ret GetGameplayStats();  // argc: 0, index: 40
    public unknown_ret GetServerReputation();  // argc: 0, index: 41
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetPublicIP();  // argc: 1, index: 42
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnableHeartbeats();  // argc: 1, index: 43
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetHeartbeatInterval();  // argc: 1, index: 44
    public unknown_ret ForceHeartbeat();  // argc: 0, index: 45
    public unknown_ret GetLogonState();  // argc: 0, index: 46
    public unknown_ret BConnected();  // argc: 0, index: 47
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RaiseConnectionPriority();  // argc: 1, index: 48
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ResetConnectionPriority();  // argc: 1, index: 49
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetCellID();  // argc: 1, index: 50
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret TrackSteamUsageEvent();  // argc: 3, index: 51
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetCountOfSimultaneousGuestUsersPerSteamAccount();  // argc: 1, index: 52
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnumerateConnectedUsers();  // argc: 2, index: 53
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AssociateWithClan();  // argc: 2, index: 54
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ComputeNewPlayerCompatibility();  // argc: 2, index: 55
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret _BGetUserAchievementStatus();  // argc: 3, index: 56
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret _GSSetSpawnCount();  // argc: 1, index: 57
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret _GSGetSteam2GetEncryptionKeyToSendToNewClient();  // argc: 3, index: 58
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret _GSSendSteam2UserConnect();  // argc: 7, index: 59
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret _GSSendSteam3UserConnect();  // argc: 5, index: 60
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret _GSSendUserConnect();  // argc: 5, index: 61
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret _GSRemoveUserConnect();  // argc: 1, index: 62
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret _GSUpdateStatus();  // argc: 6, index: 63
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret _GSCreateUnauthenticatedUser();  // argc: 1, index: 64
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret _GSSetServerType();  // argc: 9, index: 65
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret _SetBasicServerData();  // argc: 7, index: 66
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret _GSSendUserDisconnect();  // argc: 3, index: 67
}
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

public interface IClientFriends
{
    public unknown_ret GetPersonaName();  // argc: 0, index: 1
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetPersonaName();  // argc: 1, index: 2
    public unknown_ret IsPersonaNameSet();  // argc: 0, index: 3
    public unknown_ret GetPersonaState();  // argc: 0, index: 4
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetPersonaState();  // argc: 1, index: 5
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret NotifyUIOfMenuChange();  // argc: 4, index: 6
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendCount();  // argc: 1, index: 7
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendArray();  // argc: 4, index: 8
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendArrayInGame();  // argc: 3, index: 9
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendByIndex();  // argc: 3, index: 10
    public unknown_ret GetOnlineFriendCount();  // argc: 0, index: 11
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendRelationship();  // argc: 2, index: 12
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendPersonaState();  // argc: 2, index: 13
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendPersonaName();  // argc: 2, index: 14
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetSmallFriendAvatar();  // argc: 2, index: 15
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetMediumFriendAvatar();  // argc: 2, index: 16
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLargeFriendAvatar();  // argc: 2, index: 17
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BGetFriendAvatarURL();  // argc: 5, index: 18
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendAvatarHash();  // argc: 4, index: 19
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetFriendRegValue();  // argc: 4, index: 20
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendRegValue();  // argc: 3, index: 21
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DeleteFriendRegValue();  // argc: 3, index: 22
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendGamePlayed();  // argc: 3, index: 23
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendGamePlayedExtraInfo();  // argc: 2, index: 24
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendGameServer();  // argc: 3, index: 25
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendPersonaStateFlags();  // argc: 2, index: 26
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendSessionStateInfo();  // argc: 3, index: 27
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendRestrictions();  // argc: 2, index: 28
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendBroadcastID();  // argc: 2, index: 29
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendPersonaNameHistory();  // argc: 3, index: 30
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestPersonaNameHistory();  // argc: 2, index: 31
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendPersonaNameHistoryAndDate();  // argc: 4, index: 32
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddFriend();  // argc: 2, index: 33
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RemoveFriend();  // argc: 2, index: 34
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret HasFriend();  // argc: 3, index: 35
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestUserInformation();  // argc: 3, index: 36
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetIgnoreFriend();  // argc: 3, index: 37
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ReportChatDeclined();  // argc: 2, index: 38
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CreateFriendsGroup();  // argc: 1, index: 39
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DeleteFriendsGroup();  // argc: 1, index: 40
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RenameFriendsGroup();  // argc: 2, index: 41
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddFriendToGroup();  // argc: 3, index: 42
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RemoveFriendFromGroup();  // argc: 3, index: 43
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IsFriendMemberOfFriendsGroup();  // argc: 3, index: 44
    public unknown_ret GetFriendsGroupCount();  // argc: 0, index: 45
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendsGroupIDByIndex();  // argc: 1, index: 46
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendsGroupName();  // argc: 1, index: 47
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendsGroupMembershipCount();  // argc: 1, index: 48
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFirstFriendsGroupMember();  // argc: 2, index: 49
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetNextFriendsGroupMember();  // argc: 2, index: 50
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetGroupFriendsMembershipCount();  // argc: 2, index: 51
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFirstGroupFriendsMember();  // argc: 2, index: 52
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetNextGroupFriendsMember();  // argc: 2, index: 53
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetPlayerNickname();  // argc: 2, index: 54
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetPlayerNickname();  // argc: 3, index: 55
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendSteamLevel();  // argc: 2, index: 56
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetChatMessagesCount();  // argc: 2, index: 57
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetChatMessage();  // argc: 8, index: 58
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SendMsgToFriend();  // argc: 4, index: 59
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ClearChatHistory();  // argc: 2, index: 60
    public unknown_ret GetKnownClanCount();  // argc: 0, index: 61
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetKnownClanByIndex();  // argc: 2, index: 62
    public unknown_ret GetClanCount();  // argc: 0, index: 63
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetClanByIndex();  // argc: 2, index: 64
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetClanName();  // argc: 2, index: 65
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetClanTag();  // argc: 2, index: 66
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendActivityCounts();  // argc: 3, index: 67
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetClanActivityCounts();  // argc: 5, index: 68
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DownloadClanActivityCounts();  // argc: 2, index: 69
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendsGroupActivityCounts();  // argc: 3, index: 70
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IsClanPublic();  // argc: 2, index: 71
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IsClanOfficialGameGroup();  // argc: 2, index: 72
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret JoinClanChatRoom();  // argc: 2, index: 73
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret LeaveClanChatRoom();  // argc: 2, index: 74
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetClanChatMemberCount();  // argc: 2, index: 75
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetChatMemberByIndex();  // argc: 4, index: 76
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SendClanChatMessage();  // argc: 3, index: 77
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetClanChatMessage();  // argc: 7, index: 78
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IsClanChatAdmin();  // argc: 4, index: 79
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IsClanChatWindowOpenInSteam();  // argc: 2, index: 80
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret OpenClanChatWindowInSteam();  // argc: 2, index: 81
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CloseClanChatWindowInSteam();  // argc: 2, index: 82
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetListenForFriendsMessages();  // argc: 1, index: 83
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ReplyToFriendMessage();  // argc: 3, index: 84
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendMessage();  // argc: 6, index: 85
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret InviteFriendToClan();  // argc: 4, index: 86
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AcknowledgeInviteToClan();  // argc: 3, index: 87
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendCountFromSource();  // argc: 2, index: 88
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendFromSourceByIndex();  // argc: 4, index: 89
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IsUserInSource();  // argc: 4, index: 90
    public unknown_ret GetCoplayFriendCount();  // argc: 0, index: 91
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetCoplayFriend();  // argc: 2, index: 92
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendCoplayTime();  // argc: 2, index: 93
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendCoplayGame();  // argc: 2, index: 94
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetRichPresence();  // argc: 3, index: 95
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ClearRichPresence();  // argc: 1, index: 96
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendRichPresence();  // argc: 4, index: 97
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendRichPresenceKeyCount();  // argc: 3, index: 98
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendRichPresenceKeyByIndex();  // argc: 4, index: 99
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestFriendRichPresence();  // argc: 3, index: 100
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret JoinChatRoom();  // argc: 2, index: 101
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret LeaveChatRoom();  // argc: 2, index: 102
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret InviteUserToChatRoom();  // argc: 4, index: 103
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SendChatMsg();  // argc: 4, index: 104
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetChatRoomMessagesCount();  // argc: 2, index: 105
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetChatRoomEntry();  // argc: 7, index: 106
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ClearChatRoomHistory();  // argc: 2, index: 107
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SerializeChatRoomDlg();  // argc: 4, index: 108
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetSizeOfSerializedChatRoomDlg();  // argc: 2, index: 109
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetSerializedChatRoomDlg();  // argc: 6, index: 110
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ClearSerializedChatRoomDlg();  // argc: 2, index: 111
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret KickChatMember();  // argc: 4, index: 112
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BanChatMember();  // argc: 4, index: 113
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UnBanChatMember();  // argc: 4, index: 114
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetChatRoomType();  // argc: 3, index: 115
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetChatRoomLockState();  // argc: 3, index: 116
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetChatRoomPermissions();  // argc: 3, index: 117
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetChatRoomModerated();  // argc: 3, index: 118
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BChatRoomModerated();  // argc: 2, index: 119
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret NotifyChatRoomDlgsOfUIChange();  // argc: 6, index: 120
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret TerminateChatRoom();  // argc: 2, index: 121
    public unknown_ret GetChatRoomCount();  // argc: 0, index: 122
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetChatRoomByIndex();  // argc: 2, index: 123
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetChatRoomName();  // argc: 2, index: 124
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BGetChatRoomMemberDetails();  // argc: 6, index: 125
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CreateChatRoom();  // argc: 14, index: 126
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret JoinChatRoomGroup();  // argc: 4, index: 127
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ShowChatRoomGroupInvite();  // argc: 1, index: 128
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret VoiceCallNew();  // argc: 4, index: 129
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret VoiceCall();  // argc: 4, index: 130
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret VoiceHangUp();  // argc: 3, index: 131
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetVoiceSpeakerVolume();  // argc: 1, index: 132
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetVoiceMicrophoneVolume();  // argc: 1, index: 133
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetAutoAnswer();  // argc: 1, index: 134
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret VoiceAnswer();  // argc: 1, index: 135
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AcceptVoiceCall();  // argc: 4, index: 136
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret VoicePutOnHold();  // argc: 2, index: 137
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BVoiceIsLocalOnHold();  // argc: 1, index: 138
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BVoiceIsRemoteOnHold();  // argc: 1, index: 139
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetDoNotDisturb();  // argc: 1, index: 140
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnableVoiceNotificationSounds();  // argc: 1, index: 141
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetPushToTalkEnabled();  // argc: 2, index: 142
    public unknown_ret IsPushToTalkEnabled();  // argc: 0, index: 143
    public unknown_ret IsPushToMuteEnabled();  // argc: 0, index: 144
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetPushToTalkKey();  // argc: 1, index: 145
    public unknown_ret GetPushToTalkKey();  // argc: 0, index: 146
    public unknown_ret IsPushToTalkKeyDown();  // argc: 0, index: 147
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnableVoiceCalibration();  // argc: 1, index: 148
    public unknown_ret IsVoiceCalibrating();  // argc: 0, index: 149
    public unknown_ret GetVoiceCalibrationSamplePeak();  // argc: 0, index: 150
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetMicBoost();  // argc: 1, index: 151
    public unknown_ret GetMicBoost();  // argc: 0, index: 152
    public unknown_ret HasHardwareMicBoost();  // argc: 0, index: 153
    public unknown_ret GetMicDeviceName();  // argc: 0, index: 154
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret StartTalking();  // argc: 1, index: 155
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EndTalking();  // argc: 1, index: 156
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret VoiceIsValid();  // argc: 1, index: 157
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetAutoReflectVoice();  // argc: 1, index: 158
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetCallState();  // argc: 1, index: 159
    public unknown_ret GetVoiceMicrophoneVolume();  // argc: 0, index: 160
    public unknown_ret GetVoiceSpeakerVolume();  // argc: 0, index: 161
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret TimeSinceLastVoiceDataReceived();  // argc: 1, index: 162
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret TimeSinceLastVoiceDataSend();  // argc: 1, index: 163
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BCanSend();  // argc: 1, index: 164
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BCanReceive();  // argc: 1, index: 165
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetEstimatedBitsPerSecond();  // argc: 2, index: 166
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetPeakSample();  // argc: 2, index: 167
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SendResumeRequest();  // argc: 1, index: 168
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret OpenFriendsDialog();  // argc: 2, index: 169
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret OpenChatDialog();  // argc: 2, index: 170
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret OpenInviteToTradeDialog();  // argc: 2, index: 171
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret StartChatRoomVoiceSpeaking();  // argc: 4, index: 172
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EndChatRoomVoiceSpeaking();  // argc: 4, index: 173
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendLastLogonTime();  // argc: 2, index: 174
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendLastLogoffTime();  // argc: 2, index: 175
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetChatRoomVoiceTotalSlotCount();  // argc: 2, index: 176
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetChatRoomVoiceUsedSlotCount();  // argc: 2, index: 177
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetChatRoomVoiceUsedSlot();  // argc: 4, index: 178
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetChatRoomVoiceStatus();  // argc: 4, index: 179
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BChatRoomHasAvailableVoiceSlots();  // argc: 2, index: 180
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BIsChatRoomVoiceSpeaking();  // argc: 4, index: 181
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetChatRoomPeakSample();  // argc: 5, index: 182
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ChatRoomVoiceRetryConnections();  // argc: 2, index: 183
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetPortTypes();  // argc: 1, index: 184
    public unknown_ret ReinitAudio();  // argc: 0, index: 185
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetInGameVoiceSpeaking();  // argc: 3, index: 186
    public unknown_ret IsInGameVoiceSpeaking();  // argc: 0, index: 187
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ActivateGameOverlay();  // argc: 1, index: 188
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ActivateGameOverlayToUser();  // argc: 3, index: 189
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ActivateGameOverlayToWebPage();  // argc: 2, index: 190
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ActivateGameOverlayToStore();  // argc: 2, index: 191
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ActivateGameOverlayInviteDialog();  // argc: 2, index: 192
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ActivateGameOverlayRemotePlayTogetherInviteDialog();  // argc: 2, index: 193
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ActivateGameOverlayInviteDialogConnectString();  // argc: 1, index: 194
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ProcessActivateGameOverlayInMainUI();  // argc: 6, index: 195
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret NotifyGameOverlayStateChanged();  // argc: 3, index: 196
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret NotifyGameServerChangeRequested();  // argc: 2, index: 197
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret NotifyLobbyJoinRequested();  // argc: 5, index: 198
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret NotifyRichPresenceJoinRequested();  // argc: 4, index: 199
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetClanRelationship();  // argc: 2, index: 200
    public unknown_ret GetClanInviteCount();  // argc: 0, index: 201
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendClanRank();  // argc: 4, index: 202
    public unknown_ret VoiceIsAvailable();  // argc: 0, index: 203
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret TestVoiceDisconnect();  // argc: 1, index: 204
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret TestChatRoomPeerDisconnect();  // argc: 4, index: 205
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret TestVoicePacketLoss();  // argc: 1, index: 206
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FindFriendVoiceChatHandle();  // argc: 2, index: 207
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestFriendsWhoPlayGame();  // argc: 1, index: 208
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetCountFriendsWhoPlayGame();  // argc: 1, index: 209
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendWhoPlaysGame();  // argc: 3, index: 210
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetCountFriendsInGame();  // argc: 1, index: 211
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetPlayedWith();  // argc: 2, index: 212
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestClanOfficerList();  // argc: 2, index: 213
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetClanOwner();  // argc: 3, index: 214
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetClanOfficerCount();  // argc: 2, index: 215
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetClanOfficerByIndex();  // argc: 4, index: 216
    public unknown_ret GetUserRestrictions();  // argc: 0, index: 217
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestFriendProfileInfo();  // argc: 2, index: 218
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendProfileInfo();  // argc: 3, index: 219
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret InviteUserToGame();  // argc: 4, index: 220
    public unknown_ret GetOnlineConsoleFriendCount();  // argc: 0, index: 221
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestTrade();  // argc: 2, index: 222
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret TradeResponse();  // argc: 2, index: 223
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CancelTradeRequest();  // argc: 2, index: 224
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret HideFriend();  // argc: 3, index: 225
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFollowerCount();  // argc: 2, index: 226
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IsFollowing();  // argc: 2, index: 227
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnumerateFollowingList();  // argc: 1, index: 228
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestFriendMessageHistory();  // argc: 2, index: 229
    public unknown_ret RequestFriendMessageHistoryForOfflineMessages();  // argc: 0, index: 230
    public unknown_ret GetCountFriendsWithOfflineMessages();  // argc: 0, index: 231
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendWithOfflineMessage();  // argc: 1, index: 232
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ClearFriendHasOfflineMessage();  // argc: 1, index: 233
    public unknown_ret RequestEmoticonList();  // argc: 0, index: 234
    public unknown_ret GetEmoticonCount();  // argc: 0, index: 235
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetEmoticonName();  // argc: 1, index: 236
    public unknown_ret ClientLinkFilterInit();  // argc: 0, index: 237
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret LinkDisposition();  // argc: 1, index: 238
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFriendPersonaName_Public();  // argc: 2, index: 239
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetPlayerNickname_Public();  // argc: 2, index: 240
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetFriendsUIActiveClanChatList();  // argc: 2, index: 241
    public unknown_ret GetNumChatsWithUnreadPriorityMessages();  // argc: 0, index: 242
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetNumChatsWithUnreadPriorityMessages();  // argc: 1, index: 243
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RegisterProtocolInOverlayBrowser();  // argc: 1, index: 244
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret HandleProtocolForOverlayBrowser();  // argc: 2, index: 245
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestEquippedProfileItems();  // argc: 2, index: 246
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BHasEquippedProfileItem();  // argc: 3, index: 247
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetProfileItemPropertyString();  // argc: 4, index: 248
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetProfileItemPropertyUint();  // argc: 4, index: 249
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DownloadCommunityItemAsset();  // argc: 4, index: 250
}
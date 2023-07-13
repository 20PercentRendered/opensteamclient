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

public interface IClientUserStats
{
    public UInt32 GetNumStats(CGameID nGameID);  // argc: 1, index: 1
    public string GetStatName(CGameID nGameID, UInt32 iStat);  // argc: 2, index: 2
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetStatType();  // argc: 2, index: 3
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetNumAchievements();  // argc: 1, index: 4
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAchievementName();  // argc: 2, index: 5
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestCurrentStats();  // argc: 1, index: 6
    public unknown_ret GetStat(CGameID nGameID, string pchName, ref Int32 pData);  // argc: 3, index: 7
    public unknown_ret GetStat(CGameID nGameID, string pchName, ref float pData);  // argc: 3, index: 8
    public unknown_ret SetStat(CGameID nGameID, string pchName, Int32 nData);  // argc: 3, index: 9
    public unknown_ret SetStat(CGameID nGameID, string pchName, float nData);  // argc: 3, index: 10
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdateAvgRateStat();  // argc: 4, index: 11
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAchievement();  // argc: 4, index: 12
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetAchievement();  // argc: 2, index: 13
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ClearAchievement();  // argc: 2, index: 14
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAchievementProgress();  // argc: 5, index: 15
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret StoreStats();  // argc: 1, index: 16
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAchievementIcon();  // argc: 3, index: 17
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BGetAchievementIconURL();  // argc: 5, index: 18
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAchievementDisplayAttribute();  // argc: 4, index: 19
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IndicateAchievementProgress();  // argc: 4, index: 20
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetMaxStatsLoaded();  // argc: 1, index: 21
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestUserStats();  // argc: 3, index: 22
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetUserStat(CSteamID steamIDUser, CGameID nGameID, string pchName, ref Int32 pData);  // argc: 5, index: 23
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetUserStat(CSteamID steamIDUser, CGameID nGameID, string pchName, ref float pData);  // argc: 5, index: 24
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetUserAchievement();  // argc: 6, index: 25
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetUserAchievementProgress();  // argc: 7, index: 26
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ResetAllStats();  // argc: 2, index: 27
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FindOrCreateLeaderboard();  // argc: 3, index: 28
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FindLeaderboard();  // argc: 1, index: 29
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLeaderboardName();  // argc: 2, index: 30
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLeaderboardEntryCount();  // argc: 2, index: 31
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLeaderboardSortMethod();  // argc: 2, index: 32
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLeaderboardDisplayType();  // argc: 2, index: 33
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DownloadLeaderboardEntries();  // argc: 5, index: 34
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DownloadLeaderboardEntriesForUsers();  // argc: 4, index: 35
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetDownloadedLeaderboardEntry();  // argc: 6, index: 36
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AttachLeaderboardUGC();  // argc: 4, index: 37
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UploadLeaderboardScore();  // argc: 6, index: 38
    public unknown_ret GetNumberOfCurrentPlayers();  // argc: 0, index: 39
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetNumAchievedAchievements();  // argc: 1, index: 40
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLastAchievementUnlocked();  // argc: 1, index: 41
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetMostRecentAchievementUnlocked();  // argc: 2, index: 42
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestGlobalAchievementPercentages();  // argc: 1, index: 43
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetMostAchievedAchievementInfo();  // argc: 5, index: 44
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetNextMostAchievedAchievementInfo();  // argc: 6, index: 45
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAchievementAchievedPercent();  // argc: 3, index: 46
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestGlobalStats();  // argc: 2, index: 47
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetGlobalStat(CGameID nGameID, string pchName, ref Int64 pData);  // argc: 3, index: 48
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetGlobalStat(CGameID nGameID, string pchName, ref double pData);  // argc: 3, index: 49
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetGlobalStatHistory(CGameID nGameID, string pchName, ref Int64 pData, UInt32 cubData);  // argc: 4, index: 50
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetGlobalStatHistory(CGameID nGameID, string pchName, ref double pData, UInt32 cubData);  // argc: 4, index: 51
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAchievementProgressLimits(CGameID nGameID, string pchName, ref Int64 pData, UInt32 cubData);  // argc: 4, index: 52
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAchievementProgressLimits(CGameID nGameID, string pchName, ref double pData, UInt32 cubData);  // argc: 4, index: 53
}
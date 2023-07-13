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

public interface IClientMusic
{
    public bool BIsEnabled();  // argc: 0, index: 1
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret Enable();  // argc: 1, index: 2
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnableCrawlLogging();  // argc: 1, index: 3
    public unknown_ret BIsPlaying();  // argc: 0, index: 4
    public unknown_ret GetQueueCount();  // argc: 0, index: 5
    public unknown_ret GetCurrentQueueEntry();  // argc: 0, index: 6
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetQueueEntryURI();  // argc: 3, index: 7
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetQueueEntryData();  // argc: 10, index: 8
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetQueueEntryOrigin();  // argc: 3, index: 9
    public unknown_ret EmptyQueue();  // argc: 0, index: 10
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RemoveQueueEntry();  // argc: 2, index: 11
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddArtistToQueue();  // argc: 3, index: 12
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddTracksOfAlbumIDToQueue();  // argc: 7, index: 13
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddAllTracksOfAlbumIDToQueue();  // argc: 5, index: 14
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddTracksOfPlaylistIDToQueue();  // argc: 6, index: 15
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetSuppressAutoTrackAdvance();  // argc: 1, index: 16
    public unknown_ret GetPlaybackStatus();  // argc: 0, index: 17
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetPlayingRepeatStatus();  // argc: 1, index: 18
    public unknown_ret GetPlayingRepeatStatus();  // argc: 0, index: 19
    public unknown_ret TogglePlayingRepeatStatus();  // argc: 0, index: 20
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetPlayingShuffled();  // argc: 1, index: 21
    public unknown_ret IsPlayingShuffled();  // argc: 0, index: 22
    public unknown_ret Play();  // argc: 0, index: 23
    public unknown_ret Pause();  // argc: 0, index: 24
    public unknown_ret PlayPrevious();  // argc: 0, index: 25
    public unknown_ret PlayNext();  // argc: 0, index: 26
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret PlayEntry();  // argc: 1, index: 27
    public unknown_ret TogglePlayPause();  // argc: 0, index: 28
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetVolume();  // argc: 1, index: 29
    public unknown_ret GetVolume();  // argc: 0, index: 30
    public unknown_ret ToggleMuteVolume();  // argc: 0, index: 31
    public unknown_ret IncreaseVolume();  // argc: 0, index: 32
    public unknown_ret DecreaseVolume();  // argc: 0, index: 33
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetPlaybackPosition();  // argc: 1, index: 34
    public unknown_ret GetPlaybackPosition();  // argc: 0, index: 35
    public unknown_ret GetPlaybackDuration();  // argc: 0, index: 36
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret LocalLibraryCrawlTrack();  // argc: 1, index: 37
    public unknown_ret ResetLocalLibrary();  // argc: 0, index: 38
    public unknown_ret GetStatusLocalLibrary();  // argc: 0, index: 39
    public unknown_ret SaveLocalLibraryDirectorySettings();  // argc: 0, index: 40
    public unknown_ret GetLocalLibraryDirectoryEntryCount();  // argc: 0, index: 41
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalLibraryDirectoryEntry();  // argc: 3, index: 42
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddLocalLibraryDirectoryEntry();  // argc: 1, index: 43
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ResetLocalLibraryDirectories();  // argc: 1, index: 44
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetDefaultLocalLibraryDirectory();  // argc: 2, index: 45
    public unknown_ret LocalLibraryStopCrawling();  // argc: 0, index: 46
    public unknown_ret UpdateLocalLibraryDirectoriesToCrawl();  // argc: 0, index: 47
    public unknown_ret BLocalLibraryIsCrawling();  // argc: 0, index: 48
    public unknown_ret GetLocalLibraryTrackCount();  // argc: 0, index: 49
    public unknown_ret GetLocalLibraryAlbumCount();  // argc: 0, index: 50
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalLibraryAlbumID();  // argc: 2, index: 51
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalLibraryAlbumIDEntry();  // argc: 8, index: 52
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalLibraryAlbumIDTrackEntry();  // argc: 9, index: 53
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalLibraryAlbumDirectoryForAlbumID();  // argc: 3, index: 54
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalLibraryAlbumSortNameForAlbumID();  // argc: 3, index: 55
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalLibraryArtistSortNameForAlbumID();  // argc: 3, index: 56
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalLibraryTrackCountForAlbumID();  // argc: 1, index: 57
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalLibraryAlbumIDTrackKey();  // argc: 4, index: 58
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalLibraryAlbumIDForTrackKey();  // argc: 1, index: 59
    public unknown_ret GetLocalLibraryArtistCount();  // argc: 0, index: 60
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalLibraryArtistName();  // argc: 5, index: 61
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalLibraryAlbumCountForArtistName();  // argc: 1, index: 62
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalLibraryTrackAndAlbumCountOfArtistName();  // argc: 3, index: 63
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalLibraryAlbumIDForArtist();  // argc: 2, index: 64
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalLibraryRepresentativeAlbumIDForArtist();  // argc: 2, index: 65
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalLibraryTrackEntry();  // argc: 6, index: 66
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BRequestAllArtistListData();  // argc: 1, index: 67
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BRequestAllAlbumListData();  // argc: 1, index: 68
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BRequestAllTracksListDataForAlbumID();  // argc: 2, index: 69
    public unknown_ret GetPlaylistCount();  // argc: 0, index: 70
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetPlaylistID();  // argc: 1, index: 71
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetPositionForPlaylistID();  // argc: 1, index: 72
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetPlaylistIDForPosition();  // argc: 1, index: 73
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BRequestAllPlayListData();  // argc: 1, index: 74
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetNextPlaylistName();  // argc: 3, index: 75
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret InsertPlaylistWithNameAtPosition();  // argc: 2, index: 76
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret MovePlaylistFromPositionToPosition();  // argc: 2, index: 77
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DeletePlaylistWithID();  // argc: 1, index: 78
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RenamePlaylistWithID();  // argc: 2, index: 79
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddRandomTracksToPlaylistID();  // argc: 2, index: 80
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetPlaylistIDData();  // argc: 8, index: 81
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetPlaylistIDTrackCount();  // argc: 1, index: 82
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BRequestAllTracksListDataForPlaylistID();  // argc: 2, index: 83
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetPlaylistIDTrackKey();  // argc: 5, index: 84
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetPositionForPlaylistItemID();  // argc: 1, index: 85
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddTrackKeyToPlaylistID();  // argc: 2, index: 86
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddAlbumIDToPlaylistID();  // argc: 3, index: 87
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddArtistNameToPlaylistID();  // argc: 2, index: 88
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddPlaylistIDToPlaylistID();  // argc: 2, index: 89
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RemovePlaylistPositionFromPlaylistID();  // argc: 2, index: 90
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RemoveAllTracksFromPlaylistID();  // argc: 2, index: 91
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret MoveTrackFromPositionToPositonInPlaylistID();  // argc: 3, index: 92
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AppendQueueToPlaylistID();  // argc: 2, index: 93
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalLibraryRepresentativeAlbumIDForPlaylist();  // argc: 2, index: 94
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret MarkTrackKeyAsPlayed();  // argc: 1, index: 95
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetMostRecentlyPlayedAlbums();  // argc: 2, index: 96
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetMostRecentlyAddedAlbums();  // argc: 2, index: 97
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ActivateRemotePlayerWithID();  // argc: 1, index: 98
    public unknown_ret GetActiveRemotePlayerID();  // argc: 0, index: 99
    public unknown_ret GetRemotePlayerCount();  // argc: 0, index: 100
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetRemotePlayerIDAndName();  // argc: 4, index: 101
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetCurrentEntryTextForRemotePlayerWithID();  // argc: 3, index: 102
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RegisterSteamMusicRemote();  // argc: 1, index: 103
    public unknown_ret DeregisterSteamMusicRemote();  // argc: 0, index: 104
    public unknown_ret BIsCurrentMusicRemote();  // argc: 0, index: 105
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BActivationSuccess();  // argc: 1, index: 106
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetDisplayName();  // argc: 1, index: 107
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetPNGIcon_64x64();  // argc: 2, index: 108
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnablePlayPrevious();  // argc: 1, index: 109
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnablePlayNext();  // argc: 1, index: 110
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnableShuffled();  // argc: 1, index: 111
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnableLooped();  // argc: 1, index: 112
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnableQueue();  // argc: 1, index: 113
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnablePlaylists();  // argc: 1, index: 114
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdatePlaybackStatus();  // argc: 1, index: 115
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdateShuffled();  // argc: 1, index: 116
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdateLooped();  // argc: 1, index: 117
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdateVolume();  // argc: 1, index: 118
    public unknown_ret CurrentEntryWillChange();  // argc: 0, index: 119
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CurrentEntryIsAvailable();  // argc: 1, index: 120
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdateCurrentEntryText();  // argc: 1, index: 121
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdateCurrentEntryElapsedSeconds();  // argc: 1, index: 122
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdateCurrentEntryCoverArt();  // argc: 2, index: 123
    public unknown_ret CurrentEntryDidChange();  // argc: 0, index: 124
    public unknown_ret QueueWillChange();  // argc: 0, index: 125
    public unknown_ret ResetQueueEntries();  // argc: 0, index: 126
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetQueueEntry();  // argc: 3, index: 127
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetCurrentQueueEntry();  // argc: 1, index: 128
    public unknown_ret QueueDidChange();  // argc: 0, index: 129
    public unknown_ret PlaylistWillChange();  // argc: 0, index: 130
    public unknown_ret ResetPlaylistEntries();  // argc: 0, index: 131
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetPlaylistEntry();  // argc: 3, index: 132
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetCurrentPlaylistEntry();  // argc: 1, index: 133
    public unknown_ret PlaylistDidChange();  // argc: 0, index: 134
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestAlbumCoverForAlbumID();  // argc: 1, index: 135
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestAlbumCoverForTrackKey();  // argc: 1, index: 136
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAlbumCoverForIndex();  // argc: 3, index: 137
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CancelAlbumCoverRequestForIndex();  // argc: 1, index: 138
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAlbumCoverURLForAlbumID();  // argc: 3, index: 139
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAlbumCoverURLForTrackKey();  // argc: 3, index: 140
    public unknown_ret StartUsingSpotify();  // argc: 0, index: 141
    public unknown_ret StopUsingSpotify();  // argc: 0, index: 142
    public unknown_ret GetStatusSpotify();  // argc: 0, index: 143
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret LoginSpotify();  // argc: 2, index: 144
    public unknown_ret ReloginSpotify();  // argc: 0, index: 145
    public unknown_ret GetCurrentUserSpotify();  // argc: 0, index: 146
    public unknown_ret ForgetCurrentUserSpotify();  // argc: 0, index: 147
    public unknown_ret LogoutSpotify();  // argc: 0, index: 148
    public unknown_ret DumpStatusToConsole();  // argc: 0, index: 149
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ReplacePlaylistWithSoundtrackAlbum();  // argc: 1, index: 150
    public unknown_ret GetQueueSoundtrackAppID();  // argc: 0, index: 151
}
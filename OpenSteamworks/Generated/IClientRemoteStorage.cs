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

public interface IClientRemoteStorage
{
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FileWrite();  // argc: 5, index: 1
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFileSize();  // argc: 3, index: 2
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FileWriteAsync();  // argc: 4, index: 3
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FileReadAsync();  // argc: 5, index: 4
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FileReadAsyncComplete();  // argc: 5, index: 5
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FileRead();  // argc: 5, index: 6
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FileForget();  // argc: 3, index: 7
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FileDelete();  // argc: 3, index: 8
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FileShare();  // argc: 3, index: 9
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FileExists();  // argc: 3, index: 10
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FilePersisted();  // argc: 3, index: 11
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFileTimestamp();  // argc: 3, index: 12
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetSyncPlatforms();  // argc: 4, index: 13
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetSyncPlatforms();  // argc: 3, index: 14
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FileWriteStreamOpen();  // argc: 3, index: 15
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FileWriteStreamClose();  // argc: 2, index: 16
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FileWriteStreamCancel();  // argc: 2, index: 17
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FileWriteStreamWriteChunk();  // argc: 4, index: 18
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFileCount();  // argc: 2, index: 19
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetFileNameAndSize();  // argc: 5, index: 20
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetQuota();  // argc: 3, index: 21
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetUGCQuotaUsage();  // argc: 5, index: 22
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret InitializeUGCQuotaUsage();  // argc: 1, index: 23
    public unknown_ret IsCloudEnabledForAccount();  // argc: 0, index: 24
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IsCloudEnabledForApp();  // argc: 1, index: 25
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetCloudEnabledForApp();  // argc: 2, index: 26
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IsCloudSyncOnSuspendAvailableForApp();  // argc: 1, index: 27
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IsCloudSyncOnSuspendEnabledForApp();  // argc: 1, index: 28
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetCloudSyncOnSuspendEnabledForApp();  // argc: 2, index: 29
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UGCDownload();  // argc: 4, index: 30
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UGCDownloadToLocation();  // argc: 4, index: 31
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetUGCDownloadProgress();  // argc: 4, index: 32
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetUGCDetails();  // argc: 6, index: 33
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UGCRead();  // argc: 6, index: 34
    public unknown_ret GetCachedUGCCount();  // argc: 0, index: 35
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetCachedUGCHandle();  // argc: 1, index: 36
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret PublishFile();  // argc: 10, index: 37
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret PublishVideo();  // argc: 11, index: 38
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret PublishVideoFromURL();  // argc: 9, index: 39
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CreatePublishedFileUpdateRequest();  // argc: 3, index: 40
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdatePublishedFileFile();  // argc: 3, index: 41
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdatePublishedFilePreviewFile();  // argc: 3, index: 42
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdatePublishedFileTitle();  // argc: 3, index: 43
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdatePublishedFileDescription();  // argc: 3, index: 44
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdatePublishedFileSetChangeDescription();  // argc: 3, index: 45
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdatePublishedFileVisibility();  // argc: 3, index: 46
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdatePublishedFileTags();  // argc: 3, index: 47
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdatePublishedFileURL();  // argc: 3, index: 48
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CommitPublishedFileUpdate();  // argc: 4, index: 49
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetPublishedFileDetails();  // argc: 4, index: 50
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DeletePublishedFile();  // argc: 2, index: 51
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnumerateUserPublishedFiles();  // argc: 3, index: 52
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SubscribePublishedFile();  // argc: 3, index: 53
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnumerateUserSubscribedFiles();  // argc: 4, index: 54
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UnsubscribePublishedFile();  // argc: 3, index: 55
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetUserPublishedFileAction();  // argc: 4, index: 56
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnumeratePublishedFilesByUserAction();  // argc: 3, index: 57
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnumerateUserSubscribedFilesWithUpdates();  // argc: 3, index: 58
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetCREItemVoteSummary();  // argc: 2, index: 59
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret UpdateUserPublishedItemVote();  // argc: 3, index: 60
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetUserPublishedItemVoteDetails();  // argc: 2, index: 61
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnumerateUserSharedWorkshopFiles();  // argc: 6, index: 62
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnumeratePublishedWorkshopFiles();  // argc: 8, index: 63
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EGetFileSyncState();  // argc: 3, index: 64
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BIsFileSyncing();  // argc: 3, index: 65
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FilePersist();  // argc: 3, index: 66
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FileFetch();  // argc: 3, index: 67
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ResolvePath();  // argc: 5, index: 68
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret FileTouch();  // argc: 4, index: 69
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetCloudEnabledForAccount();  // argc: 1, index: 70
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret LoadLocalFileInfoCache();  // argc: 1, index: 71
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EvaluateRemoteStorageSyncState();  // argc: 2, index: 72
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLastKnownSyncState();  // argc: 1, index: 73
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetRemoteStorageSyncState();  // argc: 1, index: 74
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret HaveLatestFilesLocally();  // argc: 1, index: 75
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetConflictingFileTimestamps();  // argc: 3, index: 76
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetPendingRemoteOperationInfo();  // argc: 2, index: 77
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ResolveSyncConflict();  // argc: 2, index: 78
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SynchronizeApp();  // argc: 4, index: 79
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret IsAppSyncInProgress();  // argc: 1, index: 80
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RunAutoCloudOnAppLaunch();  // argc: 1, index: 81
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RunAutoCloudOnAppExit();  // argc: 1, index: 82
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ResetFileRequestState();  // argc: 1, index: 83
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ClearPublishFileUpdateRequests();  // argc: 1, index: 84
    public unknown_ret GetSubscribedFileDownloadCount();  // argc: 0, index: 85
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BGetSubscribedFileDownloadInfo(bool unk1);  // argc: 5, index: 86
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BGetSubscribedFileDownloadInfo(double unk1, bool unk2);  // argc: 5, index: 87
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret PauseSubscribedFileDownloadsForApp();  // argc: 1, index: 88
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ResumeSubscribedFileDownloadsForApp();  // argc: 1, index: 89
    public unknown_ret PauseAllSubscribedFileDownloads();  // argc: 0, index: 90
    public unknown_ret ResumeAllSubscribedFileDownloads();  // argc: 0, index: 91
    public unknown_ret CancelCurrentAndPendingOperations();  // argc: 0, index: 92
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalFileChangeCount();  // argc: 1, index: 93
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLocalFileChange();  // argc: 4, index: 94
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BeginFileWriteBatch();  // argc: 1, index: 95
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EndFileWriteBatch();  // argc: 1, index: 96
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetCloudEnabledForAppMap();  // argc: 1, index: 97
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetLastKnownSyncStateMap();  // argc: 2, index: 98
}
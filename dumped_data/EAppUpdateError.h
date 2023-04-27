typedef enum EAppUpdateError
{
    k_EAppUpdateErrorNoError = 0,
    k_EAppUpdateErrorUnspecifiedError = 1,
    k_EAppUpdateErrorPaused = 2,
    k_EAppUpdateErrorCanceled = 3,
    k_EAppUpdateErrorSuspended = 4,
    k_EAppUpdateErrorNoSubscription = 5,
    k_EAppUpdateErrorNoConnection = 6,
    k_EAppUpdateErrorConnectionTimeout = 7,
    k_EAppUpdateErrorMissingDecryptionKey = 8,
    k_EAppUpdateErrorMissingConfiguration = 9,
    k_EAppUpdateErrorDiskReadFailure = 10,
    k_EAppUpdateErrorDiskWriteFailure = 11,
    k_EAppUpdateErrorNotEnoughDiskSpace = 12,
    k_EAppUpdateErrorCorruptGameFiles = 13,
    k_EAppUpdateErrorWaitingForDisk = 14,
    k_EAppUpdateErrorInvalidInstallPath = 15,
    k_EAppUpdateErrorApplicationRunning = 16,
    k_EAppUpdateErrorDependencyFailure = 17,
    k_EAppUpdateErrorNotInstalled = 18,
    k_EAppUpdateErrorUpdateRequired = 19,
    k_EAppUpdateErrorStillBusy = 20,
    k_EAppUpdateErrorNoConnectionToContentServers = 21,
    k_EAppUpdateErrorInvalidApplicationConfiguration = 22,
    k_EAppUpdateErrorInvalidContentConfiguration = 23,
    k_EAppUpdateErrorManifestUnavailable = 24,
    k_EAppUpdateErrorNotReleased = 25,
    k_EAppUpdateErrorRegionRestricted = 26,
    k_EAppUpdateErrorCorruptDepotCache = 27,
    k_EAppUpdateErrorMissingExecutable = 28,
    k_EAppUpdateErrorInvalidPlatform = 29,
    k_EAppUpdateErrorInvalidFileSystem = 30,
    k_EAppUpdateErrorCorruptUpdateFiles = 31,
    k_EAppUpdateErrorDownloadDisabled = 32,
    k_EAppUpdateErrorSharedLibraryLocked = 33,
    k_EAppUpdateErrorPurchasePending = 34,
    k_EAppUpdateErrorOtherSessionPlaying = 35,
    k_EAppUpdateErrorCorruptDownload = 36,
    k_EAppUpdateErrorCorruptDisk = 37,
    k_EAppUpdateErrorMissingFilePermissions = 38,
    k_EAppUpdateErrorFileLocked = 39,
    k_EAppUpdateErrorContentUnavailable = 40,
    k_EAppUpdateErrorRequires64bitOperatingSystem = 41,
    k_EAppUpdateErrorMissingUpdateFiles = 42,
    k_EAppUpdateErrorNotEnoughDiskQuota = 43,
    k_EAppUpdateErrorSiteLicenseLocked = 44,
    k_EAppUpdateErrorParentalControlBlocked = 45,
    k_EAppUpdateErrorCreateProcessFailed = 46,
    k_EAppUpdateErrorSteamClientOutOfDate = 47,
    k_EAppUpdateErrorAllowedPlaytimeExceeded = 48,
    k_EAppUpdateErrorCorruptFileSignature = 49,
    k_EAppUpdateErrorMissingGameFiles = 50,
    k_EAppUpdateErrorCompatToolFailed = 51,
    k_EAppUpdateErrorInstallPathRemoved = 52,
} EAppUpdateError;
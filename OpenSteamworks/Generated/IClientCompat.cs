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

public interface IClientCompat
{
    public unknown_ret BIsCompatLayerEnabled();  // argc: 0, index: 1
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EnableCompat();  // argc: 1, index: 2
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAvailableCompatTools();  // argc: 1, index: 3
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAvailableCompatToolsFiltered();  // argc: 2, index: 4
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAvailableCompatToolsForApp();  // argc: 2, index: 5
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SpecifyCompatTool();  // argc: 4, index: 6
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BIsCompatibilityToolEnabled();  // argc: 1, index: 7
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetCompatToolName();  // argc: 1, index: 8
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetCompatToolMappingPriority();  // argc: 1, index: 9
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetCompatToolDisplayName();  // argc: 1, index: 10
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetWhitelistedGameList();  // argc: 1, index: 11
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetControllerConfigOverrides();  // argc: 1, index: 12
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret StartSession();  // argc: 1, index: 13
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ReleaseSession();  // argc: 3, index: 14
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BIsLauncherServiceEnabled();  // argc: 1, index: 15
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DeleteCompatData();  // argc: 1, index: 16
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetCompatibilityDataDiskSize();  // argc: 1, index: 17
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret BNeedsUnlockH264();  // argc: 1, index: 18
}
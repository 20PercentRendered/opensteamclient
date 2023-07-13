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

public interface IClientGameStats
{
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetNewSession();  // argc: 5, index: 1
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret EndSession();  // argc: 4, index: 2
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddSessionAttributeInt();  // argc: 4, index: 3
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddSessionAttributeString();  // argc: 4, index: 4
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddSessionAttributeFloat();  // argc: 4, index: 5
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddNewRow();  // argc: 4, index: 6
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CommitRow();  // argc: 2, index: 7
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CommitOutstandingRows();  // argc: 2, index: 8
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddRowAttributeInt();  // argc: 4, index: 9
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddRowAttributeString();  // argc: 4, index: 10
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddRowAttributeFloat();  // argc: 4, index: 11
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddSessionAttributeInt64();  // argc: 5, index: 12
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddRowAttributeInt64();  // argc: 5, index: 13
}
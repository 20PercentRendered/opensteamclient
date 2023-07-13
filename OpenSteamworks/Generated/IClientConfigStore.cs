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
using OpenSteamworks.Enums;

namespace OpenSteamworks.Generated;

public interface IClientConfigStore
{
    public bool IsSet( EConfigStore eConfigStore, string pszKeyNameIn );  // argc: 2, index: 1
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public bool GetBool( EConfigStore eConfigStore, string pszKeyNameIn, bool defaultValue );  // argc: 3, index: 2
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public Int32 GetInt( EConfigStore eConfigStore, string pszKeyName, Int32 defaultValue );  // argc: 3, index: 3
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public UInt64 GetUint64( EConfigStore eConfigStore, string pszKeyName, UInt64 defaultValue );  // argc: 4, index: 4
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public float GetFloat(EConfigStore eConfigStore, string pszKeyName, float defaultValue);  // argc: 3, index: 5
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public string GetString(EConfigStore eConfigStore, string pszKeyName, string defaultValue);  // argc: 3, index: 6
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public UInt32 GetBinary(EConfigStore eConfigStore, string pszKeyName, ref UInt8 pubBuf, UInt32 cubBuf);  // argc: 4, index: 7
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public UInt32 GetBinary(EConfigStore eConfigStore, string pszKeyName, ref CUtlBuffer pUtlBuf);  // argc: 3, index: 8
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public UInt32 GetBinaryWatermarked(EConfigStore eConfigStore, string pszKeyName, ref UInt8 pubBuf, UInt32 cubBuf);  // argc: 4, index: 9
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public bool SetBool(EConfigStore eConfigStore, string pszKeyNameIn, bool value);  // argc: 3, index: 10
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public bool SetInt(EConfigStore eConfigStore, string pszKeyNameIn, Int32 nValue);  // argc: 3, index: 11
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public bool SetUint64(EConfigStore eConfigStore, string pszKeyNameIn, UInt64 unValue);  // argc: 4, index: 12
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public bool SetFloat(EConfigStore eConfigStore, string pszKeyNameIn, float flValue);  // argc: 3, index: 13
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public bool SetString(EConfigStore eConfigStore, string pszKeyNameIn, ref string pszValue);  // argc: 3, index: 14
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public bool SetBinary(EConfigStore eConfigStore, string pszKeyName, ref UInt8 pubData, UInt32 cubData);  // argc: 4, index: 15
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public bool SetBinaryWatermarked(EConfigStore eConfigStore, string pszKeyName, ref UInt8 pubData, UInt32 cubData);  // argc: 4, index: 16
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public bool RemoveKey(EConfigStore eConfigStore, string pszKeyName);  // argc: 2, index: 17
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public Int32 GetKeySerialized(EConfigStore eConfigStore, string pszKeyNameIn, ref UInt8 pchBuffer, Int32 cbBufferMax);  // argc: 4, index: 18
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public bool FlushToDisk(bool bIsShuttingDown);  // argc: 1, index: 19
}
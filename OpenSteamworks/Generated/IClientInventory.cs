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

public interface IClientInventory
{
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetResultStatus();  // argc: 1, index: 1
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DestroyResult();  // argc: 1, index: 2
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetResultItems();  // argc: 4, index: 3
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetResultItemProperty();  // argc: 6, index: 4
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetResultTimestamp();  // argc: 1, index: 5
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret CheckResultSteamID();  // argc: 3, index: 6
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SerializeResult();  // argc: 4, index: 7
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret DeserializeResult();  // argc: 4, index: 8
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetAllItems();  // argc: 1, index: 9
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetItemsByID();  // argc: 3, index: 10
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GenerateItems();  // argc: 5, index: 11
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret AddPromoItems();  // argc: 3, index: 12
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ConsumeItem();  // argc: 4, index: 13
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret ExchangeItems();  // argc: 9, index: 14
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret TransferItemQuantity();  // argc: 6, index: 15
    public unknown_ret SendItemDropHeartbeat();  // argc: 0, index: 16
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret TriggerItemDrop();  // argc: 2, index: 17
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret TradeItems();  // argc: 11, index: 18
    public unknown_ret LoadItemDefinitions();  // argc: 0, index: 19
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetItemDefinitionIDs();  // argc: 3, index: 20
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetItemDefinitionProperty();  // argc: 5, index: 21
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RequestEligiblePromoItemDefinitionsIDs();  // argc: 2, index: 22
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetEligiblePromoItemDefinitionIDs();  // argc: 5, index: 23
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret StartPurchase();  // argc: 4, index: 24
    public unknown_ret RequestPrices();  // argc: 0, index: 25
    public unknown_ret GetNumItemsWithPrices();  // argc: 0, index: 26
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetItemsWithPrices();  // argc: 4, index: 27
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret GetItemPrice();  // argc: 3, index: 28
    public unknown_ret StartUpdateProperties();  // argc: 0, index: 29
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret RemoveProperty();  // argc: 5, index: 30
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetProperty(bool unk1);  // argc: 6, index: 31
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetProperty(double unk1, bool unk2);  // argc: 6, index: 32
    // WARNING: Do not use this function! Unknown behaviour will occur!
    public unknown_ret Unknown_32_DONTUSE();  // argc: -1, index: 33
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SetProperty(int unk1, bool unk2, double unk3);  // argc: 6, index: 34
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret SubmitUpdateProperties();  // argc: 3, index: 35
    // WARNING: Argument count doesn't match argc! Remove this once this has been corrected!
    public unknown_ret InspectItem();  // argc: 2, index: 36
}
# cashfree-dotnet-pg-sdk.Model.DeletedInstrumentEntity
Delete saved card instrument object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerId** | **string** | Customer ID against which the card is saved. | [optional] 
**AfaReference** | **string** | cf_payment_id of the successful transaction done while saving instrument. | [optional] 
**InstrumentId** | **string** | Identifier for the card saved at Cashfree, which was requested to be deleted. | [optional] 
**InstrumentType** | **string** | Type of the saved instrument. | [optional] 
**InstrumentUid** | **string** | Unique identifier for the saved card, used to identify a specific card. | [optional] 
**InstrumentDisplay** | **string** | Last four digits of actual card number. | [optional] 
**InstrumentStatus** | **string** | Status of the saved instrument. This would be &#x60;INACTIVE&#x60; when the instrument is successfully deleted. | [optional] 
**CreatedAt** | **string** | Timestamp at which instrument was saved. | [optional] 
**InstrumentMeta** | [**SavedInstrumentMeta**](SavedInstrumentMeta.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


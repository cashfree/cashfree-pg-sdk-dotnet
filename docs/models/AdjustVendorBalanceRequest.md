# cashfree-dotnet-pg-sdk.Model.AdjustVendorBalanceRequest
Adjust Vendor Balance Request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransferFrom** | **string** | Mention to whom you want to transfer the on demand balance. Possible values - MERCHANT, VENDOR. | 
**TransferType** | **string** | Mention the type of transfer. Possible values: ON_DEMAND. | 
**TransferAmount** | **decimal** | Mention the on demand transfer amount. | 
**Remark** | **string** | Mention remarks if any for the on demand transfer. | [optional] 
**Tags** | **Object** | Provide additional data fields using tags. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


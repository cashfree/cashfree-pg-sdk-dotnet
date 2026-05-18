# cashfree-dotnet-pg-sdk.Model.VendorAdjustmentRequest
Vendor Adjustment Request Body.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VendorId** | **string** | The unique identifier of the vendor to whom the adjustment is applied. | 
**AdjustmentId** | **long** | The unique identifier for the adjustment transaction. | 
**Amount** | **decimal** | The adjustment amount to be applied. | 
**Type** | **string** | The type of adjustment. Possible values: CREDIT, DEBIT. | 
**Remarks** | **string** | Remarks for the adjustment transaction, if any. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


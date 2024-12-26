# cashfree_pg.Model.VendorAdjustmentRequest
Vendor Adjustment Request Body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**vendor_id** | **string** | The unique identifier of the vendor to whom the adjustment is applied | 
**adjustment_id** | **long** | The unique identifier for the adjustment transaction. | 
**amount** | **decimal** | The adjustment amount to be applied. | 
**type** | **string** | The type of adjustment. Possible values: CREDIT, DEBIT. | 
**remarks** | **string** | Remarks for the adjustment transaction, if any. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


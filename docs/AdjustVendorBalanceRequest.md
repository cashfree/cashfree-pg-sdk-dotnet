# cashfree_pg.Model.AdjustVendorBalanceRequest
Adjust Vendor Balance Request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**transfer_from** | **string** | Mention to whom you want to transfer the on demand balance. Possible values - MERCHANT, VENDOR. | 
**transfer_type** | **string** | Mention the type of transfer. Possible values: ON_DEMAND. | 
**transfer_amount** | **decimal** | Mention the on demand transfer amount. | 
**remark** | **string** | Mention remarks if any for the on demand transfer. | [optional] 
**tags** | **Object** | Provide additional data fields using tags. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


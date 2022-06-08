# cashfreepg.Model.CFRefundRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RefundAmount** | **double** | Amount to be refunded. Should be lesser than or equal to the transaction amount. (Decimals allowed) | 
**RefundId** | **string** | An unique ID to associate the refund with. Provie alphanumeric values | 
**RefundNote** | **string** | A refund note for your reference. | [optional] 
**RefundSplits** | [**List&lt;CFVendorSplit&gt;**](CFVendorSplit.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# cashfree_pg.Model.OrderCreateRefundRequest
create refund request object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**refund_amount** | **double** | Amount to be refunded. Should be lesser than or equal to the transaction amount. (Decimals allowed) | 
**refund_id** | **string** | An unique ID to associate the refund with. Provie alphanumeric values | 
**refund_note** | **string** | A refund note for your reference. | [optional] 
**refund_speed** | **string** | Speed at which the refund is processed. It&#39;s an optional field with default being STANDARD | [optional] 
**refund_splits** | [**List&lt;VendorSplit&gt;**](VendorSplit.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


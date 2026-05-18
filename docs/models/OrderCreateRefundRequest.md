# cashfree-dotnet-pg-sdk.Model.OrderCreateRefundRequest
create refund request object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RefundAmount** | **double** | Amount to be refunded. Should be lesser than or equal to the transaction amount. (Decimals allowed). | 
**RefundId** | **string** | An unique ID to associate the refund with. Provie alphanumeric values. | [optional] 
**RefundNote** | **string** | A refund note for your reference. To simulate refund status in Sandbox, pass SUCCESS, FAILED, PENDING, or ACTIVE in the refund_note field. This is a case-sensitive parameter. | [optional] 
**RefundSpeed** | **string** | Speed at which the refund is processed. It&#39;s an optional field with default being STANDARD. | [optional] 
**RefundSplits** | [**List&lt;OrderCreateRefundRequestRefundSplitsInner&gt;**](OrderCreateRefundRequestRefundSplitsInner.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


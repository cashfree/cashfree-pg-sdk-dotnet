# cashfree-dotnet-pg-sdk.Model.SubscriptionPaymentRefundEntity
Get/Create Subscription Payment Refund Response.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentId** | **string** | A unique ID passed by merchant for identifying the transaction. | [optional] 
**CfPaymentId** | **string** | Cashfree subscription payment reference number. | [optional] 
**RefundId** | **string** | A unique ID passed by merchant for identifying the refund. | [optional] 
**CfRefundId** | **string** | Cashfree subscription payment refund reference number. | [optional] 
**RefundAmount** | **decimal** | The refund amount. | [optional] 
**RefundNote** | **string** | Refund note for merchant reference. | [optional] 
**RefundSpeed** | **string** | Refund speed. Can be INSTANT or NORMAL. | [optional] 
**RefundStatus** | **string** | Status of the refund. Can be INITIALIZED, SUCCESS, CANCEL, PENDING or FAILED. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


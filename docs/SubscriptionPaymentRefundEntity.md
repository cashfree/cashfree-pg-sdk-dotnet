# cashfree-dotnet-pg-sdk.Model.SubscriptionPaymentRefundEntity
Get/Create Subscription Payment Refund Response.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**payment_id** | **string** | A unique ID passed by merchant for identifying the transaction. | [optional] 
**cf_payment_id** | **string** | Cashfree subscription payment reference number. | [optional] 
**refund_id** | **string** | A unique ID passed by merchant for identifying the refund. | [optional] 
**cf_refund_id** | **string** | Cashfree subscription payment refund reference number. | [optional] 
**refund_amount** | **decimal** | The refund amount. | [optional] 
**refund_note** | **string** | Refund note for merchant reference. | [optional] 
**refund_speed** | **string** | Refund speed. Can be INSTANT or NORMAL. | [optional] 
**refund_status** | **string** | Status of the refund. Can be INITIALIZED, SUCCESS, CANCEL, PENDING or FAILED. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


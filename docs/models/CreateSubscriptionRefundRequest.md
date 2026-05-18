# cashfree-dotnet-pg-sdk.Model.CreateSubscriptionRefundRequest
Request body to create a subscription refund.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubscriptionId** | **string** | A unique ID passed by merchant for identifying the subscription. | 
**PaymentId** | **string** | A unique ID passed by merchant for identifying the transaction. | 
**RefundId** | **string** | A unique ID passed by merchant for identifying the refund. | 
**RefundAmount** | **decimal** | The amount to be refunded. Can be partial or full amount of the payment. | 
**CfPaymentId** | **decimal** | Cashfree subscription payment reference number. | [optional] 
**RefundNote** | **string** | Refund note for merchant reference. To simulate refund status in Sandbox, pass SUCCESS, FAILED, PENDING, or ACTIVE in the refund_note field. This is a case-sensitive parameter. | [optional] 
**RefundSpeed** | **string** | Refund speed. Can be INSTANT or STANDARD. UPI supports only STANDARD refunds, Enach and Pnach supports only INSTANT refunds. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


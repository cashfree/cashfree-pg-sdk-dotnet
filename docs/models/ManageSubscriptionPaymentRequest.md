# cashfree-dotnet-pg-sdk.Model.ManageSubscriptionPaymentRequest
Request body to manage a subscription payment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubscriptionId** | **string** | The unique ID which was used to create subscription. | 
**PaymentId** | **string** | The unique ID which was used to create payment. | 
**Action** | **string** | Action to be performed on the payment. Possible values - CANCEL, RETRY. | 
**ActionDetails** | [**ManageSubscriptionPaymentRequestActionDetails**](ManageSubscriptionPaymentRequestActionDetails.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


# cashfree-dotnet-pg-sdk.Model.CreateSubscriptionPaymentResponse
The response returned is Create Subscription Auth or Charge APIs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CfPaymentId** | **string** | Cashfree subscription payment reference number. | [optional] 
**FailureDetails** | [**SubscriptionPaymentEntityFailureDetails**](SubscriptionPaymentEntityFailureDetails.md) |  | [optional] 
**PaymentAmount** | **decimal** | The charge amount of the payment. | [optional] 
**PaymentId** | **string** | A unique ID passed by merchant for identifying the transaction. | [optional] 
**PaymentInitiatedDate** | **string** | The date on which the payment was initiated. We store timestamps in IST. | [optional] 
**PaymentStatus** | **string** | Status of the payment. | [optional] 
**PaymentType** | **string** | Payment type. Can be AUTH or CHARGE. | [optional] 
**SubscriptionId** | **string** | A unique ID passed by merchant for identifying the subscription. | [optional] 
**Data** | **Object** | Contains a payload for auth app links in case of AUTH. For charge, the payload is empty. | [optional] 
**PaymentMethod** | **string** | Payment method used for the authorisation. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


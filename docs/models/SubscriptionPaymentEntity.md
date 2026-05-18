# cashfree-dotnet-pg-sdk.Model.SubscriptionPaymentEntity
The response returned in Get, Create or Manage Subscription Payment APIs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthorizationDetails** | [**AuthorizationDetails**](AuthorizationDetails.md) |  | [optional] 
**CfPaymentId** | **string** | Cashfree subscription payment reference number. | [optional] 
**CfSubscriptionId** | **string** | Cashfree subscription reference number. | [optional] 
**CfTxnId** | **string** | Cashfree subscription payment transaction ID. | [optional] 
**CfOrderId** | **string** | Cashfree subscription payment order ID. | [optional] 
**FailureDetails** | [**SubscriptionPaymentEntityFailureDetails**](SubscriptionPaymentEntityFailureDetails.md) |  | [optional] 
**PaymentAmount** | **decimal** | The charge amount of the payment. | [optional] 
**PaymentId** | **string** | A unique ID passed by merchant for identifying the transaction. | [optional] 
**PaymentInitiatedDate** | **string** | The date on which the payment was initiated. Cashfree stores timestamps in IST. | [optional] 
**PaymentRemarks** | **string** | Payment remarks. | [optional] 
**PaymentScheduleDate** | **string** | The date on which the payment is scheduled to be processed. Cashfree stores timestamps in IST, but you can provide them in a valid ISO 8601 time format.  For IST this &#x60;2025-06-01T10:20:12+05:30&#x60; translates to &#x60;2025-06-01 10:20:12&#x60;    For UTC this &#x60;2025-06-01T10:20:12Z&#x60; translates to &#x60;2025-06-01 15:50:12+05:30&#x60;. | [optional] 
**PaymentStatus** | **string** | Status of the payment. | [optional] 
**PaymentType** | **string** | Payment type. Can be AUTH or CHARGE. | [optional] 
**RetryAttempts** | **int** | Retry attempts. | [optional] 
**SubscriptionId** | **string** | A unique ID passed by merchant for identifying the subscription. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


# cashfree-dotnet-pg-sdk.Model.OrderAuthenticateEntity
Success response for submitting or resending OTP.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CfPaymentId** | **string** | Cashfree payment ID for which this request was sent. | [optional] 
**Action** | **string** | The action that was requested. | [optional] 
**AuthenticateStatus** | **string** | Status of this action - will be either success or failed. If the action is success, you should still call [payment status API](https://www.cashfree.com/docs/api-reference/payments/latest/payments/get) to verify the final payment status. | [optional] 
**PaymentMessage** | **string** | Human readable message which describes the status in more detail. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


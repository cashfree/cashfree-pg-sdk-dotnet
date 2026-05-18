# cashfree-dotnet-pg-sdk.Model.OrderAuthenticatePaymentRequest
To use this API, Native OTP needs to be enabled for your account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | Action intended for this request - can be SUBMIT_OTP or RESEND_OTP. | 
**Otp** | **string** | OTP collected from the customer. Mandatory only when action is SUBMIT_OTP. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


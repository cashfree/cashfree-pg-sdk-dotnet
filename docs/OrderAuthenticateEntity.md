# cashfree_pg.Model.OrderAuthenticateEntity
This is the response shared when merchant inovkes the OTP submit or resend API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cf_payment_id** | **decimal** | The payment id for which this request was sent | [optional] 
**action** | **string** | The action that was invoked for this request. | [optional] 
**authenticate_status** | **string** | Status of the is action. Will be either failed or successful. If the action is successful, you should still call the authorization status to verify the final payment status. | [optional] 
**payment_message** | **string** | Human readable message which describes the status in more detail | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


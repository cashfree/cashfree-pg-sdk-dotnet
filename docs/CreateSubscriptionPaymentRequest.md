# cashfree_pg.Model.CreateSubscriptionPaymentRequest
The request to be passed for the create subscription payment API.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**subscription_id** | **string** | A unique ID passed by merchant for identifying the subscription. | 
**subscription_session_id** | **string** | Session ID for the subscription. Required only for Auth. | [optional] 
**payment_id** | **string** | A unique ID passed by merchant for identifying the subscription payment. | 
**payment_amount** | **decimal** | The charge amount of the payment. Required in case of charge. | [optional] 
**payment_schedule_date** | **string** | The date on which the payment is scheduled to be processed. Required for UPI and CARD payment modes. | [optional] 
**payment_remarks** | **string** | Payment remarks. | [optional] 
**payment_type** | **string** | Payment type. Can be AUTH or CHARGE. | 
**payment_method** | [**CreateSubscriptionPaymentRequestPaymentMethod**](CreateSubscriptionPaymentRequestPaymentMethod.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


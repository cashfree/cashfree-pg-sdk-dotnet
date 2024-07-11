# cashfree_pg.Model.ManageSubscriptionPaymentRequest
Request body to manage a subscription payment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**subscription_id** | **string** | The unique ID which was used to create subscription. | 
**payment_id** | **string** | The unique ID which was used to create payment. | 
**action** | **string** | Action to be performed on the payment. Possible values - CANCEL, RETRY. | 
**action_details** | [**ManageSubscriptionPaymentRequestActionDetails**](ManageSubscriptionPaymentRequestActionDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


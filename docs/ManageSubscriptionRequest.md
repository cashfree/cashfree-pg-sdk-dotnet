# cashfree_pg.Model.ManageSubscriptionRequest
Request body to manage a subscription.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**subscription_id** | **string** | The unique ID which was used to create subscription. | 
**action** | **string** | Action to be performed on the subscription. Possible values - CANCEL, PAUSE, ACTIVATE, CHANGE_PLAN. | 
**action_details** | [**ManageSubscriptionRequestActionDetails**](ManageSubscriptionRequestActionDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


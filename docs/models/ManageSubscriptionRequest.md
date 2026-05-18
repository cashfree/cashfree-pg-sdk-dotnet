# cashfree-dotnet-pg-sdk.Model.ManageSubscriptionRequest
Request body to manage a subscription.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SubscriptionId** | **string** | The unique ID which was used to create subscription. | 
**Action** | **string** | Action to be performed on the subscription. Possible values - CANCEL, PAUSE, ACTIVATE, CHANGE_PLAN. | 
**ActionDetails** | [**ManageSubscriptionRequestActionDetails**](ManageSubscriptionRequestActionDetails.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


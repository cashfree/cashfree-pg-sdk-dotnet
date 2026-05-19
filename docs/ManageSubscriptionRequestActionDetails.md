# cashfree-dotnet-pg-sdk.Model.ManageSubscriptionRequestActionDetails
Details of the action to be performed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**next_scheduled_time** | **string** | Next scheduled time for the action. Required for ACTIVATE action.   Please note that only the date component is considered. Any time value provided will be ignored. | [optional] 
**plan_id** | **string** | Plan ID to update. Required for CHANGE_PLAN action. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# cashfree-dotnet-pg-sdk.Model.AuthorizeOrderRequest
Request to capture or void transaction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | Type of authorisation to run. Available options are &#x60;CAPTURE&#x60;, &#x60;VOID&#x60;. | 
**Amount** | **decimal** | The amount you want to capture. This is required only when action is &#x60;CAPTURE&#x60;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


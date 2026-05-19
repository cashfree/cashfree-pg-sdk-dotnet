# cashfree-dotnet-pg-sdk.Model.SimulateSettlementRequest
Object to simulate a settlement request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**merchantOrderIds** | **List&lt;string&gt;** | A list of orders for which you want to simulate settlement. | [optional] 
**txnTime** | **string** | The start time (YYYY-MM-DD HH:mm:ss) from which transactions are picked for simulating settlement. You can pass a &#x60;txnTime&#x60; value for up to the last seven days. | [optional] 
**status** | **string** | The simulation status. Possible values are SUCCESS, FAILED or PENDING. | [optional] 
**errorReason** | **string** | Specifies the reason for settlement failure. The default value is used if this is not provided. This is required only if the status is FAILED. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


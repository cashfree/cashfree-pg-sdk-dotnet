# cashfree_pg.Model.SimulateRequest
simulate payment request object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**entity** | **string** | Entity type should be PAYMENTS or SUBS_PAYMENTS only. | 
**entity_id** | **string** | If the entity type is PAYMENTS, the entity_id will be the transactionId. If the entity type is SUBS_PAYMENTS, the entity_id will be the merchantTxnId | 
**entity_simulation** | [**EntitySimulationRequest**](EntitySimulationRequest.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


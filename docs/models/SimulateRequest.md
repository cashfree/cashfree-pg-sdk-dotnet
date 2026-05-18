# cashfree-dotnet-pg-sdk.Model.SimulateRequest
Request body for simulation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | **string** | Entity type should be PAYMENTS, SUBS_PAYMENTS OR VBA_TRANSFER only. | 
**EntityId** | **string** | If the entity type is PAYMENTS, the entity_id will be the cf_payment_id. If the entity type is SUBS_PAYMENTS, the entity_id will be the payment_id. If the entity type is VBA_TRANSFER, the entity_id will be the vba_account_number. | [optional] 
**EntitySimulation** | [**EntitySimulationRequest**](EntitySimulationRequest.md) |  | [optional] 
**VbaSimulation** | [**VBASimulationRequest**](VBASimulationRequest.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


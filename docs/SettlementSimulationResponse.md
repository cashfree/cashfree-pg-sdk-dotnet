# cashfree_pg.Model.SettlementSimulationResponse
Object to simulate a settlement request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**simulation_id** | **string** | A unique identifier for the simulation request. | [optional] 
**entity** | **string** | Entity type for which the simulation is performed. Example: \&quot;SETTLEMENTS\&quot;. | [optional] 
**settlement_ids** | **List&lt;decimal&gt;** | List of simulated settlement IDs. | [optional] 
**simulation_status** | **string** | Status of the simulation request. Example: \&quot;SUCCESS/FAILED/PENDING\&quot;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


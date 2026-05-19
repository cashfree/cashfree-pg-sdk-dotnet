# cashfree-dotnet-pg-sdk.Model.IncidentObject
Represents an active incident entry in the ecosystem.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**incident_id** | **string** | Unique identifier for the incident. | [optional] 
**incident_impact** | **string** | Impact level of the incident. | [optional] 
**incident_message** | **string** | Description of the incident. | [optional] 
**incident_start_time** | **string** | Start time of the incident. | [optional] 
**incident_end_time** | **string** | End time of the incident, or null if ongoing. | [optional] 
**incident_status** | **string** | Status of the incident. | [optional] 
**incident_type** | **string** | Type of the incident. | [optional] 
**payment_method** | [**IncidentObjectPaymentMethod**](IncidentObjectPaymentMethod.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# cashfree-dotnet-pg-sdk.Model.IncidentObject
Represents an active incident entry in the ecosystem.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncidentId** | **string** | Unique identifier for the incident. | [optional] 
**IncidentImpact** | **string** | Impact level of the incident. | [optional] 
**IncidentMessage** | **string** | Description of the incident. | [optional] 
**IncidentStartTime** | **string** | Start time of the incident. | [optional] 
**IncidentEndTime** | **string** | End time of the incident, or null if ongoing. | [optional] 
**IncidentStatus** | **string** | Status of the incident. | [optional] 
**IncidentType** | **string** | Type of the incident. | [optional] 
**PaymentMethod** | [**IncidentObjectPaymentMethod**](IncidentObjectPaymentMethod.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


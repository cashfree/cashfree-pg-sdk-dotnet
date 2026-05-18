# cashfree-dotnet-pg-sdk.Model.IncidentByIdResponse
Success response for Fetch Downtime by ID.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncidentId** | **string** | Unique identifier for the incident. | [optional] 
**IncidentImpact** | **string** | Impact level of the incident. | [optional] 
**IncidentMessage** | **string** | Description of the issue. | [optional] 
**IncidentStartTime** | **string** | Start time of the incident. | [optional] 
**IncidentEndTime** | **string** | End time of the incident, if applicable; null if still ongoing. | [optional] 
**IncidentStatus** | **string** | Current status of the incident. | [optional] 
**IncidentType** | **string** | Type of the incident. | [optional] 
**PaymentMethod** | [**IncidentObjectPaymentMethod**](IncidentObjectPaymentMethod.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


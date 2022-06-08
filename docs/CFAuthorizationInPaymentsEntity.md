# cashfreepg.Model.CFAuthorizationInPaymentsEntity
The authorization details are present for payments which go through the preauthorization workflow. Or else this parameter will be null.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Action** | **string** | One of CAPTURE or VOID | [optional] 
**Status** | **string** | One of SUCCESS or PENDING | [optional] 
**CapturedAmount** | **decimal** | The captured amount for this authorization request | [optional] 
**StartTime** | **string** | Start time of this authorization hold (only for UPI) | [optional] 
**EndTime** | **string** | End time of this authorization hold (only for UPI) | [optional] 
**ApproveBy** | **string** | Approve by time as passed in the authorization request (only for UPI) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


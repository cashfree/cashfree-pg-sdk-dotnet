# cashfree_pg.Model.AuthorizationInPaymentsEntity
If preauth enabled for account you will get this body

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**action** | **string** | One of CAPTURE or VOID | [optional] 
**status** | **string** | One of SUCCESS or PENDING | [optional] 
**captured_amount** | **decimal** | The captured amount for this authorization request | [optional] 
**start_time** | **string** | Start time of this authorization hold (only for UPI) | [optional] 
**end_time** | **string** | End time of this authorization hold (only for UPI) | [optional] 
**approve_by** | **string** | Approve by time as passed in the authorization request (only for UPI) | [optional] 
**action_reference** | **string** | CAPTURE or VOID reference number based on action  | [optional] 
**action_time** | **string** | Time of action (CAPTURE or VOID) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


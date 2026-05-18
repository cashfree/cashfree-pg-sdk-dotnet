# cashfree-dotnet-pg-sdk.Model.TerminalDetails
Use this if you are creating an order for cashfree's softPOS.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TerminalType** | **string** | To identify the type of terminal product in use, in this case it is SPOS. | 
**AddedOn** | **string** | date time at which terminal is added. | [optional] 
**CfTerminalId** | **long** | Cashfree terminal ID, this is a required parameter when you do not provide the terminal phone number. | [optional] 
**LastUpdatedOn** | **string** | last instant when this terminal was updated. | [optional] 
**TerminalAddress** | **string** | location of terminal. | [optional] 
**TerminalId** | **string** | terminal id for merchant reference. | [optional] 
**TerminalName** | **string** | name of terminal/agent/storefront. | [optional] 
**TerminalNote** | **string** | note given by merchant while creating the terminal. | [optional] 
**TerminalPhoneNo** | **string** | mobile num of the terminal/agent/storefront,This is a required parameter when you do not provide the cf_terminal_id. | [optional] 
**TerminalStatus** | **string** | status of terminal active/inactive. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


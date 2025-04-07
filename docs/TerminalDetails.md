# cashfree_pg.Model.TerminalDetails
Use this if you are creating an order for cashfree's softPOS

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**added_on** | **string** | date time at which terminal is added | [optional] 
**cf_terminal_id** | **string** | Cashfree terminal id, this is a required parameter when you do not provide the terminal phone number. | [optional] 
**last_updated_on** | **string** | last instant when this terminal was updated | [optional] 
**terminal_address** | **string** | location of terminal | [optional] 
**terminal_id** | **string** | terminal id for merchant reference | [optional] 
**terminal_name** | **string** | name of terminal/agent/storefront | [optional] 
**terminal_note** | **string** | note given by merchant while creating the terminal | [optional] 
**terminal_phone_no** | **string** | mobile num of the terminal/agent/storefront,This is a required parameter when you do not provide the cf_terminal_id. | [optional] 
**terminal_status** | **string** | status of terminal active/inactive | [optional] 
**terminal_type** | **string** | To identify the type of terminal product in use, in this case it is SPOS. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


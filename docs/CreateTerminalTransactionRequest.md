# cashfree_pg.Model.CreateTerminalTransactionRequest
Request body to create a terminal transaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cf_order_id** | **string** | cashfree order ID that was returned while creating an order. | 
**cf_terminal_id** | **string** | cashfree terminal id. this is a required parameter when you do not provide the terminal phone number. | [optional] 
**payment_method** | **string** | mention the payment method used for the transaction. possible values - QR_CODE, LINK. | 
**terminal_phone_no** | **string** | agent mobile number assigned to the terminal. this is a required parameter when you do not provide the cf_terminal_id. | [optional] 
**add_invoice** | **bool** | make it true to have request be sent to create a Dynamic GST QR Code. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


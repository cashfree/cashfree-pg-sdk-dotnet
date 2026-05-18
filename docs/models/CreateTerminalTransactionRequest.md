# cashfree-dotnet-pg-sdk.Model.CreateTerminalTransactionRequest
Request body to create a terminal transaction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CfOrderId** | **string** | cashfree order ID that was returned while creating an order. | 
**CfTerminalId** | **long** | Cashfree terminal ID, this is a required parameter when you do not provide the terminal phone number. | [optional] 
**PaymentMethod** | **string** | mention the payment method used for the transaction. possible values - QR_CODE, LINK. | [optional] 
**TerminalPhoneNo** | **string** | agent mobile number assigned to the terminal. this is a required parameter when you do not provide the cf_terminal_id. | [optional] 
**AddInvoice** | **bool** | make it true to have request be sent to create a Dynamic GST QR Code. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


# cashfree-dotnet-pg-sdk.Model.GetAllTerminalPaymentEntity
Response object containing detailed information about a terminal payment transaction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cf_terminal_id** | **int** | Unique Cashfree terminal identifier. | [optional] 
**terminal_id** | **string** | Merchant-defined terminal identifier. | [optional] 
**terminal_vpa** | **string** | Virtual payment address (VPA) associated with the terminal. | [optional] 
**cf_payment_id** | **int** | Unique Cashfree payment identifier. | [optional] 
**payment_amount** | **decimal** | Payment transaction amount in the specified currency. | [optional] 
**payment_mode** | **string** | Payment method used for the transaction (for example, UPI_OFFLINE_STATIC). | [optional] 
**payment_status** | **string** | Current status of the payment transaction (SUCCESS, FAILED, or PENDING). | [optional] 
**payment_time** | **string** | Timestamp when the payment was processed in ISO8601 format. | [optional] 
**error_details** | [**ErrorDetailsInPaymentsEntity**](ErrorDetailsInPaymentsEntity.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


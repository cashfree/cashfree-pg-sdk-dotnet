# cashfree-dotnet-pg-sdk.Model.GetAllTerminalPaymentEntity
Response object containing detailed information about a terminal payment transaction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CfTerminalId** | **int** | Unique Cashfree terminal identifier. | [optional] 
**TerminalId** | **string** | Merchant-defined terminal identifier. | [optional] 
**TerminalVpa** | **string** | Virtual payment address (VPA) associated with the terminal. | [optional] 
**CfPaymentId** | **int** | Unique Cashfree payment identifier. | [optional] 
**PaymentAmount** | **decimal** | Payment transaction amount in the specified currency. | [optional] 
**PaymentMode** | **string** | Payment method used for the transaction (for example, UPI_OFFLINE_STATIC). | [optional] 
**PaymentStatus** | **string** | Current status of the payment transaction (SUCCESS, FAILED, or PENDING). | [optional] 
**PaymentTime** | **string** | Timestamp when the payment was processed in ISO8601 format. | [optional] 
**ErrorDetails** | [**ErrorDetailsInPaymentsEntity**](ErrorDetailsInPaymentsEntity.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


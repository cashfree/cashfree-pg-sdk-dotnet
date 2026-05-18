# cashfree-dotnet-pg-sdk.Model.CustomerDetailsResponse
The customer details that are necessary. Note that you can pass dummy details if your use case does not require the customer details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerId** | **string** | A unique identifier for the customer. Use alphanumeric values only. | [optional] 
**CustomerEmail** | **string** | Customer email address. | [optional] 
**CustomerPhone** | **string** | Customer phone number. | [optional] 
**CustomerName** | **string** | Name of the customer. | [optional] 
**CustomerBankAccountNumber** | **string** | Customer bank account. Required if you want to do a bank account check (TPV). | [optional] 
**CustomerBankIfsc** | **string** | Customer bank IFSC. Required if you want to do a bank account check (TPV). | [optional] 
**CustomerBankCode** | **decimal** | Customer bank code. Required for net banking payments, if you want to do a bank account check (TPV). | [optional] 
**CustomerUid** | **string** | Customer identifier at Cashfree. You will get this when you create/get customer. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


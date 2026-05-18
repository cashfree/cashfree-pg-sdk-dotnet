# cashfree-dotnet-pg-sdk.Model.CustomerDetails
The customer details that are necessary. Note that you can pass dummy details if your use case does not require the customer details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerId** | **string** | A unique identifier for the customer. Use alphanumeric values only. | 
**CustomerPhone** | **string** | Customer phone number. To accommodate international phone numbers, ensure the number is prefixed with a &#39;+&#39; to override the 10-digit limitation. | 
**CustomerEmail** | **string** | Customer email address. | [optional] 
**CustomerName** | **string** | Name of the customer. | [optional] 
**CustomerBankAccountNumber** | **string** | Customer&#39;s bank account number. This field is required only if you want to perform a bank account check (TPV). | [optional] 
**CustomerBankIfsc** | **string** | Customer&#39;s bank IFSC. Required if you want to do a bank account check (TPV). | [optional] 
**CustomerBankCode** | **decimal** | Customer&#39;s bank code. Required for net banking payments, if you want to do a bank account check (TPV). | [optional] 
**CustomerUid** | **string** | Customer&#39;s identifier at Cashfree. You will get this when you create/get customer. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


# cashfree-dotnet-pg-sdk.Model.SubscriptionCustomerDetails
Subscription customer details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomerEmail** | **string** | Email of the customer. | 
**CustomerPhone** | **string** | Phone number of the customer. | 
**CustomerName** | **string** | Name of the customer. | [optional] 
**CustomerBankAccountHolderName** | **string** | Bank holder name of the customer. Account holder name is mandatory for TPV transaction. Max character allowed is 40. | [optional] 
**CustomerBankAccountNumber** | **string** | Bank account number of the customer. Conditional Parameter. Max character allowed is 35. | [optional] 
**CustomerBankIfsc** | **string** | IFSC code of the customer. For a TPV transaction, send at least one out of &#x60;customer_bank_code&#x60; or &#x60;customer_bank_ifsc&#x60;. | [optional] 
**CustomerBankCode** | **string** | Bank code of the customer. Refer to the list of Live Banks in API E-Mandate [here](https://www.npci.org.in/product/nach/all-members). For a TPV transactions, include at least one of &#x60;customer_bank_code&#x60; or &#x60;customer_bank_ifsc&#x60;. | [optional] 
**CustomerBankAccountType** | **string** | Bank account type of the customer. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


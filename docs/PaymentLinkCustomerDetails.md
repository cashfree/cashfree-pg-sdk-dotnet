# cashfree_pg.Model.PaymentLinkCustomerDetails
The customer details that are necessary. Note that you can pass dummy details if your use case does not require the customer details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**customer_id** | **string** | A unique identifier for the customer. Use alphanumeric values only. | [optional] 
**customer_email** | **string** | Customer email address. | [optional] 
**customer_phone** | **string** | Customer phone number. | 
**customer_name** | **string** | Name of the customer. | [optional] 
**customer_bank_account_number** | **string** | Customer bank account. Required if you want to do a bank account check (TPV) | [optional] 
**customer_bank_ifsc** | **string** | Customer bank IFSC. Required if you want to do a bank account check (TPV) | [optional] 
**customer_bank_code** | **decimal** | Customer bank code. Required for net banking payments, if you want to do a bank account check (TPV) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


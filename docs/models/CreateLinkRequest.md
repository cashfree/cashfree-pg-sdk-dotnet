# cashfree-dotnet-pg-sdk.Model.CreateLinkRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LinkAmount** | **double** | Amount to be collected using this link. Provide upto two decimals for paise. | 
**LinkCurrency** | **string** | Currency for the payment link. Default is INR. Submit [Support Form](https://merchant.cashfree.com/auth/login) to enable new currencies. | 
**CustomerDetails** | [**LinkCustomerDetailsEntity**](LinkCustomerDetailsEntity.md) |  | 
**LinkId** | **string** | Unique Identifier (provided by merchant) for the Link. Alphanumeric and only - and _ allowed (50 character limit). Use this for other link-related APIs. | [optional] 
**LinkPurpose** | **string** | A brief description for which payment must be collected. This is shown to the customer. | [optional] 
**LinkPartialPayments** | **bool** | If \&quot;true\&quot;, customer can make partial payments for the link. | [optional] 
**LinkMinimumPartialAmount** | **double** | Minimum amount in first installment that needs to be paid by the customer if partial payments are enabled. This should be less than the link_amount. | [optional] 
**LinkExpiryTime** | **string** | Time after which the link expires. Customers will not be able to make the payment beyond the time specified here. You can provide them in a valid ISO 8601 time format. Default is 30 days. | [optional] 
**LinkNotify** | [**LinkNotifyEntity**](LinkNotifyEntity.md) |  | [optional] 
**LinkAutoReminders** | **bool** | If \&quot;true\&quot;, reminders will be sent to customers for collecting payments. | [optional] 
**LinkNotes** | **Dictionary&lt;string, string&gt;** | Key-value pair that can be used to store additional information about the entity. Maximum 5 key-value pairs. | [optional] 
**LinkMeta** | [**LinkMetaResponseEntity**](LinkMetaResponseEntity.md) |  | [optional] 
**OrderSplits** | [**List&lt;VendorSplit&gt;**](VendorSplit.md) | If you have Easy split enabled in your Cashfree account then you can use this option to split the order amount. | [optional] 
**EnableInvoice** | **bool** | Enable or disable invoice generation for this payment link. | [optional] 
**Subscription** | [**Subscription**](Subscription.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


# cashfree-dotnet-pg-sdk.Model.EligibilityMethodItemEntityDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountTypes** | **List&lt;string&gt;** | List of account types associated with the payment method. (e.g. SAVINGS or CURRENT). | [optional] 
**FrequentBankDetails** | [**List&lt;SubscriptionBankDetails&gt;**](SubscriptionBankDetails.md) | List of the most frequently used banks. | [optional] 
**AllBankDetails** | [**List&lt;SubscriptionBankDetails&gt;**](SubscriptionBankDetails.md) | Details about all banks associated with the payment method. | [optional] 
**AvailableHandles** | [**List&lt;EligibilityMethodItemEntityDetailsAvailableHandlesInner&gt;**](EligibilityMethodItemEntityDetailsAvailableHandlesInner.md) | List of supported VPA handles. | [optional] 
**AllowedCardTypes** | **List&lt;string&gt;** | List of allowed card types. (e.g. DEBIT_CARD, CREDIT_CARD). | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


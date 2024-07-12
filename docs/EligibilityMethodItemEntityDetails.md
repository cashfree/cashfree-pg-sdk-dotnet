# cashfree_pg.Model.EligibilityMethodItemEntityDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**account_types** | **List&lt;string&gt;** | List of account types associated with the payment method. (e.g. SAVINGS or CURRENT) | [optional] 
**frequent_bank_details** | [**List&lt;SubscriptionBankDetails&gt;**](SubscriptionBankDetails.md) | List of the most frequently used banks. | [optional] 
**all_bank_details** | [**List&lt;SubscriptionBankDetails&gt;**](SubscriptionBankDetails.md) | Details about all banks associated with the payment method. | [optional] 
**available_handles** | [**List&lt;EligibilityMethodItemEntityDetailsAvailableHandlesInner&gt;**](EligibilityMethodItemEntityDetailsAvailableHandlesInner.md) | List of supported VPA handles. | [optional] 
**allowed_card_types** | **List&lt;string&gt;** | List of allowed card types. (e.g. DEBIT_CARD, CREDIT_CARD) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


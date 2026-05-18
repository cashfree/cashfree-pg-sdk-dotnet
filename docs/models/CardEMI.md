# cashfree-dotnet-pg-sdk.Model.CardEMI
Payment method for card EMI.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Channel** | **string** | The channel for card payments will always be \&quot;link\&quot;. | 
**CardNumber** | **string** | Customer card number. | 
**CardExpiryMm** | **string** | Card expiry month. | 
**CardExpiryYy** | **string** | Card expiry year. | 
**CardCvv** | **string** | CVV mentioned on the card. | 
**CardBankName** | **string** | Card bank name, required for EMI payments. This is the bank user has selected for EMI. One of [\&quot;hdfc, \&quot;kotak\&quot;, \&quot;icici\&quot;, \&quot;rbl\&quot;, \&quot;bob\&quot;, \&quot;standard chartered\&quot;, \&quot;axis\&quot;, \&quot;au\&quot;, \&quot;yes\&quot;, \&quot;sbi\&quot;, \&quot;fed\&quot;, \&quot;hsbc\&quot;, \&quot;citi\&quot;, \&quot;amex\&quot;]. | 
**EmiTenure** | **int** | EMI tenure selected by the user. | 
**CardHolderName** | **string** | Customer name mentioned on the card. | [optional] 
**CardAlias** | **string** | Card alias as returned by Cashfree Vault API. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


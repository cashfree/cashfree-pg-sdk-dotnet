# cashfreepg.Model.CFCardEMI

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Channel** | **string** | The channel for card payments will always be \&quot;link\&quot; | [default to ChannelEnum.Link]
**CardNumber** | **string** | Customer card number. | 
**CardHolderName** | **string** | Customer name mentioned on the card. | [optional] 
**CardExpiryMm** | **string** | Card expiry month. | 
**CardExpiryYy** | **string** | Card expiry year. | 
**CardCvv** | **string** | CVV mentioned on the card. | 
**CardAlias** | **string** | Card alias as returned by Cashfree Vault API | [optional] 
**CardBankName** | **string** | Card bank name, required for EMI payments. This is the bank user has selected for EMI. One of [\&quot;Kotak\&quot;, \&quot;ICICI\&quot;, \&quot;RBL\&quot;, \&quot;BOB\&quot;, \&quot;Standard Chartered\&quot;, \&quot;HDFC\&quot;] | 
**EmiTenure** | **int** | EMI tenure selected by the user | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


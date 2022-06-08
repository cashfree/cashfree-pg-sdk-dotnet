# cashfreepg.Model.CFCard

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Channel** | **string** | The channel for card payments will always be \&quot;link\&quot; | 
**CardNumber** | **string** | Customer card number for plain card transactions. Token pan number for tokenized card transactions. | 
**CardHolderName** | **string** | Customer name mentioned on the card. | 
**CardExpiryMm** | **string** | Card expiry month for plain card transactions. Token expiry month for tokenized card transactions. | 
**CardExpiryYy** | **string** | Card expiry year for plain card transactions. Token expiry year for tokenized card transactions. | 
**CardCvv** | **string** | CVV mentioned on the card. | 
**InstrumentId** | **string** | instrument id of saved card. Required only to make payment using saved instrument. | 
**Cryptogram** | **string** | cryptogram received from card network. Required only for tokenized card transactions. | 
**TokenRequestorId** | **string** | TRID issued by card networks. Required only for tokenized card transactions. | 
**CardDisplay** | **string** | last 4 digits of original card number. Required only for tokenized card transactions. | 
**CardAlias** | **string** | Card alias as returned by Cashfree Vault API. | 
**CardBankName** | **string** | One of [\&quot;Kotak\&quot;, \&quot;ICICI\&quot;, \&quot;RBL\&quot;, \&quot;BOB\&quot;, \&quot;Standard Chartered\&quot;]. Card bank name, required for EMI payments. This is the bank user has selected for EMI | 
**EmiTenure** | **int** | EMI tenure selected by the user | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


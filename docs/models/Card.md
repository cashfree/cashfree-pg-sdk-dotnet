# cashfree-dotnet-pg-sdk.Model.Card
The card payment object can be used to make payments using a plain card, a card saved with Cashfree, an externally saved card, or an external Alt ID for guest checkout transactions. Refer to the examples in the Sample Request section for different payloads, and refer [Token Vault](https://www.cashfree.com/docs/payments/features/token-vault#token-vault) for more details on tokenisation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Channel** | **string** | The channel for card payments can be \&quot;link\&quot; or \&quot;post\&quot;. Use \&quot;post\&quot; to request [Native OTP](https://www.cashfree.com/docs/payments/features/native-otp) authentication, where the merchant must render the Native OTP UI to collect the OTP. Otherwise, use link for the redirection flow. | 
**CardNumber** | **string** | Customer’s card number for plain card transactions, or token number for external token transactions, or Alt ID number for external Alt ID transactions. | [optional] 
**CardHolderName** | **string** | Name on the customer’s card. Optional for external token or external Alt ID transactions. | [optional] 
**CardExpiryMm** | **string** | Card expiry month for plain card transactions, or token expiry month for external token transactions, or Alt ID expiry month for external Alt ID transactions. | [optional] 
**CardExpiryYy** | **string** | Card expiry year for plain card transactions, or token expiry year for external token transactions and Alt ID expiry year for external Alt ID transactions. | [optional] 
**CardCvv** | **string** | CVV mentioned on the card. Mandatory for plain card and external Alt ID transactions; optional for saved card transactions. | [optional] 
**InstrumentId** | **string** | Instrument ID of the saved card, as received in response from [Fetch All Saved Card Instrument API](https://www.cashfree.com/docs/api-reference/payments/latest/token-vault/get-all). Required only when making payments using cards saved with Cashfree. | [optional] 
**Cryptogram** | **string** | Cryptogram received from the card network. Required only for external token or external Alt ID transactions; provided by the merchant’s token requestor. | [optional] 
**TokenRequestorId** | **string** | Token Requestor ID (TRID) issued by the respective card network. Required only for external token transactions; provided by the merchant’s token requestor. | [optional] 
**TokenReferenceId** | **string** | Token Reference ID, required only for external Alt ID transactions for Diners; provided by the merchant’s token requestor. | [optional] 
**TokenType** | **string** | Token type enum. Mandatory only for external Alt ID transactions. | [optional] 
**CardDisplay** | **string** | Last 4 digits of original card number, required only for external token or external Alt ID transactions, used for bookkeeping purposes. | [optional] 
**CardBankName** | **string** | One of [\&quot;Kotak\&quot;, \&quot;ICICI\&quot;, \&quot;RBL\&quot;, \&quot;BOB\&quot;, \&quot;Standard Chartered\&quot;]. Card bank name, required for EMI payments. This is the bank user has selected for EMI. | [optional] 
**AddressLineOne** | **string** | First line of the address. | [optional] 
**AddressLineTwo** | **string** | Second line of the address. | [optional] 
**City** | **string** | City Name. | [optional] 
**ZipCode** | **string** | Pin Code/Zip Code. | [optional] 
**Country** | **string** | Country Name. | [optional] 
**CountryCode** | **string** | Country Code. Should be in ISO 2 format (ie. US for United States). | [optional] 
**State** | **string** | State Name. | [optional] 
**StateCode** | **string** | State Code. Should be in ISO 2 format (ie. FL for Florida). | [optional] 
**EmiTenure** | **int** | EMI tenure selected by the user. | [optional] 
**Par** | **string** | Par received from network. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


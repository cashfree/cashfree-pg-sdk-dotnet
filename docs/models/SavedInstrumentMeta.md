# cashfree-dotnet-pg-sdk.Model.SavedInstrumentMeta
Card instrument meta information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardNetwork** | **string** | Card scheme/network of the saved card. Available options are &#x60;visa&#x60;, &#x60;mastercard&#x60;, &#x60;rupay&#x60;, &#x60;amex&#x60;, and &#x60;diners&#x60;. | [optional] 
**CardBankName** | **string** | Issuing bank name of the saved card. For example, &#x60;HDFC BANK&#x60;, &#x60;AXIS BANK&#x60;, or &#x60;ICICI BANK&#x60;. | [optional] 
**CardCountry** | **string** | Issuing country of the saved card. For example, &#x60;IN&#x60;. | [optional] 
**CardType** | **string** | Type of the saved card. Available options are &#x60;credit_card&#x60;, &#x60;debit_card&#x60;, and &#x60;prepaid_card&#x60;. | [optional] 
**CardSubType** | **string** | Subtype of the saved card. R indicates retail, P indicates premium, and C indicates corporate. Available options are &#x60;R&#x60;, &#x60;P&#x60;, and &#x60;C&#x60;. | [optional] 
**CardTokenDetails** | [**SavedInstrumentMetaCardTokenDetails**](SavedInstrumentMetaCardTokenDetails.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


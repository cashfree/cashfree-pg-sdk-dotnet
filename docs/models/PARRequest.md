# cashfree-dotnet-pg-sdk.Model.PARRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CardNumber** | **string** | The card number, containing 15 to 19 numeric digits without spaces or special characters. | 
**CardCvv** | **string** | The Card Verification Value (CVV), a 3-digit code for most cards (Visa, Mastercard) and a 4-digit code for American Express, used for transaction authentication. | 
**CardExpiryMm** | **string** | The two-digit expiry month (01-12), indicating when the card will expire. | 
**CardExpiryYy** | **string** | The two-digit expiry year, representing the last two digits of the card’s expiration year. | 
**CardType** | **string** | Specifies the type of card, with the only accepted value being &#x60;PLAIN_CARD&#x60;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


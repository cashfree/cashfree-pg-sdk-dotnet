# cashfree_pg.Model.InstrumentEntity
Use this API to fetch specific saved card stored for the customer in Cashfree’s [Token Vault](https://www.cashfree.com/docs/payments/features/token-vault).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**customer_id** | **string** | Customer ID that merchant sends during [Create Order API](https://www.cashfree.com/docs/api-reference/payments/latest/orders/create), against which the cards are saved for the customer. | [optional] 
**afa_reference** | **string** | cf_payment_id of the successful transaction done while saving instrument. | [optional] 
**instrument_id** | **string** | Identifier for the card saved at Cashfree. | [optional] 
**instrument_type** | **string** | Type of the saved instrument. Available option is &#x60;card&#x60;. | [optional] 
**instrument_uid** | **string** | Unique identifier for the saved card, used to identify a specific card. | [optional] 
**instrument_display** | **string** | Last four digits of actual card number. | [optional] 
**instrument_status** | **string** | Status of the saved instrument. Available options are &#x60;ACTIVE&#x60;, &#x60;INACTIVE&#x60;. | [optional] 
**created_at** | **string** | Timestamp at which instrument was saved. | [optional] 
**instrument_meta** | [**SavedInstrumentMeta**](SavedInstrumentMeta.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


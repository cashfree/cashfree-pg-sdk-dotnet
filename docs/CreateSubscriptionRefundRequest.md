# cashfree_pg.Model.CreateSubscriptionRefundRequest
Request body to create a subscription refund.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cf_payment_id** | **decimal** | Cashfree subscription payment reference number. | [optional] 
**subscription_id** | **string** | A unique ID passed by merchant for identifying the subscription. | 
**payment_id** | **string** | A unique ID passed by merchant for identifying the transaction. | [optional] 
**refund_id** | **string** | A unique ID passed by merchant for identifying the refund. | 
**refund_amount** | **decimal** | The amount to be refunded. Can be partial or full amount of the payment. | 
**refund_note** | **string** | Refund note. | [optional] 
**refund_speed** | **string** | Refund speed. Can be INSTANT or STANDARD. UPI supports only STANDARD refunds, Enach and Pnach supports only INSTANT refunds. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# cashfree_pg.Model.PayOrderRequest
Complete object for the pay api that uses payment method objects

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**payment_session_id** | **string** |  | 
**payment_method** | [**PayOrderRequestPaymentMethod**](PayOrderRequestPaymentMethod.md) |  | 
**save_instrument** | **bool** |  | [optional] 
**offer_id** | **string** | This is required if any offers needs to be applied to the order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


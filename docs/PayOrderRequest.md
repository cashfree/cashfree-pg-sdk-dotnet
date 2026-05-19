# cashfree-dotnet-pg-sdk.Model.PayOrderRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**payment_session_id** | **string** | Unique identifier for the payment session, returned in the response of the Create Order API. | 
**payment_method** | [**PayOrderRequestPaymentMethod**](PayOrderRequestPaymentMethod.md) |  | 
**save_instrument** | **bool** | Send as **true** if the customer has given consent to save or tokenise the card; otherwise, send as false. | [optional] 
**offer_id** | **string** | This is required if any offers needs to be applied to the order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


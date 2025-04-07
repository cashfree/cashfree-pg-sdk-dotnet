# cashfree_pg.Model.CartDetails
The cart details that are necessary like shipping address, billing address and more.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**customer_note** | **string** |  | [optional] 
**shipping_charge** | **double** |  | [optional] 
**cart_name** | **string** | Name of the cart. | [optional] 
**customer_shipping_address** | [**CartAddress**](CartAddress.md) |  | [optional] 
**customer_billing_address** | [**CartAddress**](CartAddress.md) |  | [optional] 
**cart_items** | [**List&lt;CartItem&gt;**](CartItem.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


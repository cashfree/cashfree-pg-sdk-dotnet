# cashfree_pg.Model.CreateOrderRequest
Request body to create an order at cashfree

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**order_id** | **string** | Order identifier present in your system. Alphanumeric, &#39;_&#39; and &#39;-&#39; only | [optional] 
**order_amount** | **double** | Bill amount for the order. Provide upto two decimals. 10.15 means Rs 10 and 15 paisa | 
**order_currency** | **string** | Currency for the order. INR if left empty. Contact care@cashfree.com to enable new currencies. | 
**cart_details** | [**CartDetails**](CartDetails.md) |  | [optional] 
**customer_details** | [**CustomerDetails**](CustomerDetails.md) |  | 
**terminal** | [**TerminalDetails**](TerminalDetails.md) |  | [optional] 
**order_meta** | [**OrderMeta**](OrderMeta.md) |  | [optional] 
**order_expiry_time** | **string** | Time after which the order expires. Customers will not be able to make the payment beyond the time specified here. We store timestamps in IST, but you can provide them in a valid ISO 8601 time format. Example 2021-07-02T10:20:12+05:30 for IST, 2021-07-02T10:20:12Z for UTC | [optional] 
**order_note** | **string** | Order note for reference. | [optional] 
**order_tags** | **Dictionary&lt;string, string&gt;** | Custom Tags in thr form of {\&quot;key\&quot;:\&quot;value\&quot;} which can be passed for an order. A maximum of 10 tags can be added | [optional] 
**order_splits** | [**List&lt;VendorSplit&gt;**](VendorSplit.md) | If you have Easy split enabled in your Cashfree account then you can use this option to split the order amount. | [optional] 
**products** | [**Products**](Products.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


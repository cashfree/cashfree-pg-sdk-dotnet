# cashfreepg.Model.CFOrderRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | **string** | Order identifier present in your system. Alphanumeric and only - and _ allowed. | [optional] 
**OrderAmount** | **double** | Bill amount for the order. Provide upto two decimals. 10.15 means Rs 10 and 15 paisa | 
**OrderCurrency** | **string** | Currency for the order. INR if left empty. Contact care@cashfree.com to enable new currencies.  | 
**CustomerDetails** | [**CFCustomerDetails**](CFCustomerDetails.md) |  | 
**OrderMeta** | [**CFOrderMeta**](CFOrderMeta.md) |  | [optional] 
**OrderExpiryTime** | **string** | Time after which the order expires. Customers will not be able to make the payment beyond the time specified here. We store timestamps in IST, but you can provide them in a valid ISO 8601 time format. | [optional] 
**OrderNote** | **string** | Order note for reference. | [optional] 
**OrderTags** | **Dictionary&lt;string, string&gt;** | Custom Tags which can be passed for an order. A maximum of 6 tags can be added | [optional] 
**OrderSplits** | [**List&lt;CFVendorSplit&gt;**](CFVendorSplit.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


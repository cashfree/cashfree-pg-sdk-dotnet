# cashfree-dotnet-pg-sdk.Model.CreateOrderRequest
Request body to create an order at Cashfree.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderAmount** | **double** | Bill amount for the order. Provide upto two decimals. 10.15 means Rs 10 and 15 paisa. For orders in non-INR currency, please refer to [supported amounts](https://www.cashfree.com/docs/payments/international-payments/ipg/currencies-supported#decimal-support) per currency. | 
**OrderCurrency** | **string** | Currency for the order. INR if left empty. For support currency list, refer [here](https://www.cashfree.com/docs/payments/international-payments/ipg/currencies-supported#full-currency-list). Submit [Support Form](https://merchant.cashfree.com/auth/login) to enable new currencies. | 
**OrderId** | **string** | Order identifier present in your system. Alphanumeric, &#39;_&#39; and &#39;-&#39; only. | [optional] 
**CartDetails** | [**CartDetails**](CartDetails.md) |  | [optional] 
**CustomerDetails** | [**CustomerDetails**](CustomerDetails.md) |  | [optional] 
**Terminal** | [**TerminalDetails**](TerminalDetails.md) |  | [optional] 
**OrderMeta** | [**OrderMeta**](OrderMeta.md) |  | [optional] 
**OrderExpiryTime** | **string** | Time after which the order expires. Customers will not be able to make the payment beyond the time specified here. We store timestamps in IST, but you can provide them in a valid ISO 8601 time format. Example 2021-07-02T10:20:12+05:30 for IST, 2021-07-02T10:20:12Z for UTC | [optional] 
**OrderNote** | **string** | Order note for reference. | [optional] 
**OrderTags** | **Dictionary&lt;string, string&gt;** | Custom Tags in the form of {\&quot;key\&quot;:\&quot;value\&quot;} which can be passed for an order. A maximum of 10 tags can be added. | [optional] 
**OrderSplits** | [**List&lt;VendorSplit&gt;**](VendorSplit.md) | If you have Easy split enabled in your Cashfree account then you can use this option to split the order amount. | [optional] 
**Products** | [**Products**](Products.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


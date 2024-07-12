# cashfree_pg.Model.PaymentLinkOrderEntity
The complete order entity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cf_order_id** | **string** | unique id generated by cashfree for your order | [optional] 
**link_id** | **string** | link id of the order | [optional] 
**order_id** | **string** | order_id sent during the api request | [optional] 
**entity** | **string** | Type of the entity. | [optional] 
**order_currency** | **string** | Currency of the order. Example INR | [optional] 
**order_amount** | **decimal** |  | [optional] 
**order_status** | **string** | Possible values are  - &#x60;ACTIVE&#x60;: Order does not have a sucessful transaction yet - &#x60;PAID&#x60;: Order is PAID with one successful transaction - &#x60;EXPIRED&#x60;: Order was not PAID and not it has expired. No transaction can be initiated for an EXPIRED order.  | [optional] 
**payment_session_id** | **string** |  | [optional] 
**order_expiry_time** | **DateTime** |  | [optional] 
**order_note** | **string** | Additional note for order | [optional] 
**created_at** | **DateTime** | When the order was created at cashfree&#39;s server | [optional] 
**order_splits** | [**List&lt;VendorSplit&gt;**](VendorSplit.md) |  | [optional] 
**customer_details** | [**PaymentLinkCustomerDetails**](PaymentLinkCustomerDetails.md) |  | [optional] 
**order_meta** | [**OrderMeta**](OrderMeta.md) |  | [optional] 
**order_tags** | **Dictionary&lt;string, string&gt;** | Custom Tags in thr form of {\&quot;key\&quot;:\&quot;value\&quot;} which can be passed for an order. A maximum of 10 tags can be added | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

# cashfree_pg.Model.LinkEntity
Payment link success creation response object

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cf_link_id** | **string** |  | [optional] 
**link_id** | **string** |  | [optional] 
**link_status** | **string** |  | [optional] 
**link_currency** | **string** |  | [optional] 
**link_amount** | **decimal** |  | [optional] 
**link_amount_paid** | **decimal** |  | [optional] 
**link_partial_payments** | **bool** |  | [optional] 
**link_minimum_partial_amount** | **decimal** |  | [optional] 
**link_purpose** | **string** |  | [optional] 
**link_created_at** | **string** |  | [optional] 
**customer_details** | [**LinkCustomerDetailsEntity**](LinkCustomerDetailsEntity.md) |  | [optional] 
**link_meta** | [**LinkMetaResponseEntity**](LinkMetaResponseEntity.md) |  | [optional] 
**link_url** | **string** |  | [optional] 
**link_expiry_time** | **string** |  | [optional] 
**link_notes** | **Dictionary&lt;string, string&gt;** | Key-value pair that can be used to store additional information about the entity. Maximum 5 key-value pairs | [optional] 
**link_auto_reminders** | **bool** |  | [optional] 
**link_notify** | [**LinkNotifyEntity**](LinkNotifyEntity.md) |  | [optional] 
**link_qrcode** | **string** | Base64 encoded string for payment link. You can scan with camera to open a link in the browser to complete the payment. | [optional] 
**order_splits** | [**List&lt;VendorSplit&gt;**](VendorSplit.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


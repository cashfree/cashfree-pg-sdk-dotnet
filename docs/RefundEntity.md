# cashfree_pg.Model.RefundEntity
The refund entity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cf_payment_id** | **long** | Cashfree Payments ID of the payment for which refund is initiated | [optional] 
**cf_refund_id** | **string** | Cashfree Payments ID for a refund | [optional] 
**order_id** | **string** | Merchant’s order Id of the order for which refund is initiated | [optional] 
**refund_id** | **string** | Merchant’s refund ID of the refund | [optional] 
**entity** | **string** | Type of object | [optional] 
**refund_amount** | **decimal** | Amount that is refunded | [optional] 
**refund_currency** | **string** | Currency of the refund amount | [optional] 
**refund_note** | **string** | Note added by merchant for the refund | [optional] 
**refund_status** | **string** | This can be one of [\&quot;SUCCESS\&quot;, \&quot;PENDING\&quot;, \&quot;CANCELLED\&quot;, \&quot;ONHOLD\&quot;, \&quot;FAILED\&quot;] | [optional] 
**refund_arn** | **string** | The bank reference number for refund | [optional] 
**refund_charge** | **decimal** | Charges in INR for processing refund | [optional] 
**status_description** | **string** | Description of refund status | [optional] 
**metadata** | **Object** | Key-value pair that can be used to store additional information about the entity. Maximum 5 key-value pairs | [optional] 
**refund_splits** | [**List&lt;VendorSplit&gt;**](VendorSplit.md) |  | [optional] 
**refund_type** | **string** | This can be one of [\&quot;PAYMENT_AUTO_REFUND\&quot;, \&quot;MERCHANT_INITIATED\&quot;, \&quot;UNRECONCILED_AUTO_REFUND\&quot;] | [optional] 
**refund_mode** | **string** | Method or speed of processing refund | [optional] 
**created_at** | **string** | Time of refund creation | [optional] 
**processed_at** | **string** | Time when refund was processed successfully | [optional] 
**refund_speed** | [**RefundSpeed**](RefundSpeed.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# cashfreepg.Model.CFRefund

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CfPaymentId** | **int** | Cashfree Payments ID of the payment for which refund is initiated | [optional] 
**CfRefundId** | **string** | Cashfree Payments ID for a refund | [optional] 
**OrderId** | **string** | Merchant’s order Id of the order for which refund is initiated | [optional] 
**RefundId** | **string** | Merchant’s refund ID of the refund | [optional] 
**Entity** | **string** | Type of object | [optional] 
**RefundAmount** | **decimal** | Amount that is refunded | [optional] 
**RefundCurrency** | **string** | Currency of the refund amount | [optional] 
**RefundNote** | **string** | Note added by merchant for the refund | [optional] 
**RefundStatus** | **string** | This can be one of [\&quot;SUCCESS\&quot;, \&quot;PENDING\&quot;, \&quot;CANCELLED\&quot;, \&quot;ONHOLD\&quot;] | [optional] 
**RefundArn** | **string** | The bank reference number for refund | [optional] 
**RefundCharge** | **decimal** | Charges in INR for processing refund | [optional] 
**StatusDescription** | **string** | Description of refund status | [optional] 
**Metadata** | **Object** | Key-value pair that can be used to store additional information about the entity. Maximum 5 key-value pairs | [optional] 
**RefundSplits** | [**List&lt;CFVendorSplit&gt;**](CFVendorSplit.md) |  | [optional] 
**RefundType** | **string** | This can be one of [\&quot;PAYMENT_AUTO_REFUND\&quot;, \&quot;MERCHANT_INITIATED\&quot;, \&quot;UNRECONCILED_AUTO_REFUND\&quot;] | [optional] 
**RefundMode** | **string** | Method or speed of processing refund | [optional] 
**CreatedAt** | **string** | Time of refund creation | [optional] 
**ProcessedAt** | **string** | Time when refund was processed successfully | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


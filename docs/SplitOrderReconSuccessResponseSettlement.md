# cashfree_pg.Model.SplitOrderReconSuccessResponseSettlement
Details of the settlement information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**entity** | **string** | Type of entity. Example: \&quot;settlement\&quot;. | [optional] 
**cf_settlement_id** | **long** | Unique Cashfree settlement ID. | [optional] 
**cf_payment_id** | **long** | Unique Cashfree payment ID associated with the order. | [optional] 
**order_id** | **string** | Unique identifier for the order. | [optional] 
**order_currency** | **string** | Currency of the order. Example: \&quot;INR\&quot;. | [optional] 
**transfer_id** | **string** | Unique transfer ID if available, otherwise null. | [optional] 
**order_amount** | **decimal** | Total amount of the order. | [optional] 
**service_charge** | **decimal** | Service charge for the order. | [optional] 
**service_tax** | **decimal** | Service tax for the order. | [optional] 
**settlement_amount** | **decimal** | Amount to be settled after charges and tax. | [optional] 
**settlement_currency** | **string** | Currency of the settlement. Example: \&quot;INR\&quot;. | [optional] 
**transfer_utr** | **string** | UTR (Unique Transaction Reference) for the transfer if available, otherwise null. | [optional] 
**transfer_time** | **DateTime?** | Time of transfer if available, otherwise null. | [optional] 
**payment_time** | **DateTime** | Timestamp when payment was made. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# cashfree_pg.Model.GetAllSettlementsResponseDataInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cf_settlement_id** | **string** | Unique ID to identify the settlement. | [optional] 
**status** | **string** | Status of the settlement. | [optional] 
**status_description** | **string** | Human-readable description of the settlement status. | [optional] 
**settlement_utr** | **string** | Unique transaction reference number of the settlement. | [optional] 
**payment_from** | **string** | Start of the payment period included in this settlement. | [optional] 
**payment_till** | **string** | End of the payment period included in this settlement. | [optional] 
**settlement_initiated_on** | **string** | Date and time when the settlement was initiated. | [optional] 
**settlement_processed_on** | **string** | Date and time when the settlement was processed. | [optional] 
**payment_amount** | **decimal** | Net amount of transactions that was a part of this settlement. | [optional] [default to 0.0M]
**pg_service_charge** | **decimal** | PG service charges that were deducted in this settlement. | [optional] [default to 0.0M]
**pg_service_tax** | **decimal** | PG service taxes that were deducted in this settlement. | [optional] [default to 0.0M]
**adjustment** | **decimal** | Adjustments that were a part of this settlement. | [optional] [default to 0.0M]
**settlement_charge** | **decimal** | Settlement charges that were deducted in this settlement. | [optional] [default to 0.0M]
**settlement_tax** | **decimal** | Settlement taxes that were deducted in this settlement. | [optional] [default to 0.0M]
**split_service_charge** | **decimal** | Split service charges that were deducted in this settlement. | [optional] [default to 0.0M]
**split_service_tax** | **decimal** | Split service taxes that were deducted in this settlement. | [optional] [default to 0.0M]
**vendor_commission** | **decimal** | Vendor commission/split that was deducted in this settlement. | [optional] [default to 0.0M]
**amount_settled** | **decimal** | Amount that was settled to the merchant&#39;s bank account. | [optional] [default to 0.0M]
**charge_type** | **string** | Indicates how Cashfree&#39;s service charges are applied for this settlement. | [optional] 
**settlement_type** | **string** | Type of settlement. Example - NORMAL_SETTLEMENT. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


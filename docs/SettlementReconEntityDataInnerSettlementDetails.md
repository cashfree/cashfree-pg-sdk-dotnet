# cashfree_pg.Model.SettlementReconEntityDataInnerSettlementDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cf_settlement_id** | **string** | Unique ID to identify the settlement. | [optional] 
**settlement_date** | **string** | Date and time when the settlement was processed. | [optional] 
**utr** | **string** | Unique transaction reference number of the settlement. | [optional] 
**split_service_charge** | **decimal** | Service charge that is applicable for splitting the payment. | [optional] 
**split_service_tax** | **decimal** | Service tax applicable for splitting the amount to vendors. | [optional] 
**vendor_commission** | **decimal** | Vendor commission applicable for this transaction. | [optional] 
**payment_from** | **string** | Date and time from settlement computed. | [optional] 
**payment_till** | **string** | Date and time till settlement computed. | [optional] 
**reason** | **string** | If any reason for settlement failure. | [optional] 
**remarks** | **string** | Remarks related for settlement. | [optional] 
**service_charge** | **decimal** | Service charge for the transactions. | [optional] 
**service_tax** | **decimal** | Service tax for the transactions. | [optional] 
**settlement_charge** | **decimal** | Settlement Service Charge. | [optional] 
**settlement_initiated_on** | **string** | Date and time when Settlement initiated. | [optional] 
**settlement_tax** | **decimal** | Settlement Service Tax. | [optional] 
**settlement_type** | **string** | Type of Settlement, Example - Normal Settlement. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


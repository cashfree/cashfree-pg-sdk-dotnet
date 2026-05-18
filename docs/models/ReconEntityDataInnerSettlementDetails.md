# cashfree-dotnet-pg-sdk.Model.ReconEntityDataInnerSettlementDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CfSettlementId** | **string** | Unique ID to identify the settlement. | [optional] 
**SettlementDate** | **string** | Date and time when the settlement was processed. | [optional] 
**Utr** | **string** | Unique transaction reference number of the settlement. | [optional] 
**SplitServiceCharge** | **decimal** | Service charge that is applicable for splitting the payment. | [optional] 
**SplitServiceTax** | **decimal** | Service tax applicable for splitting the amount to vendors. | [optional] 
**VendorCommission** | **decimal** | Vendor commission applicable for this transaction. | [optional] 
**PaymentFrom** | **string** | Date and time from settlement computed. | [optional] 
**PaymentTill** | **string** | Date and time till settlement computed. | [optional] 
**Reason** | **string** | If any reason for settlement failure. | [optional] 
**Remarks** | **string** | Remarks related for settlement. | [optional] 
**ServiceCharge** | **decimal** | Service charge for the transactions. | [optional] 
**ServiceTax** | **decimal** | Service tax for the transactions. | [optional] 
**SettlementCharge** | **decimal** | Settlement Service Charge. | [optional] 
**SettlementInitiatedOn** | **string** | Date and time when Settlement initiated. | [optional] 
**SettlementTax** | **decimal** | Settlement Service Tax. | [optional] 
**SettlementType** | **string** | Type of Settlement, Example - Normal Settlement. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


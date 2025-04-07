# cashfree_pg.Model.SettlementReconEntityDataInnerEventDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**event_id** | **string** | Unique ID associated with the event. | [optional] 
**event_type** | **string** | The event type can be PAYMENT, REFUND, REFUND_REVERSAL, DISPUTE, DISPUTE_REVERSAL, CHARGEBACK, CHARGEBACK_REVERSAL, OTHER_ADJUSTMENT. | [optional] 
**event_settlement_amount** | **decimal** | Amount that is part of the settlement corresponding to the event. | [optional] 
**event_amount** | **decimal** | Amount corresponding to the event. Example, refund amount, dispute amount, payment amount, etc. | [optional] 
**sale_type** | **string** | Indicates if it is CREDIT/DEBIT sale. | [optional] 
**event_status** | **string** | Status of the event. Example - SUCCESS, FAILED, PENDING, CANCELLED. | [optional] 
**entity** | **string** | Recon | [optional] 
**event_time** | **string** | Time associated with the event. Example, transaction time, dispute initiation time | [optional] 
**event_currency** | **string** | Curreny type - INR. | [optional] 
**event_service_charge** | **decimal** | Service charge for above event_type. | [optional] 
**event_service_tax** | **decimal** | Service tax for above event_type. | [optional] 
**event_remarks** | **decimal** | Remarks for above event_type. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


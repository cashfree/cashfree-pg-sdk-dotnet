# cashfree-dotnet-pg-sdk.Model.ReconEntityDataInnerEventDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventId** | **string** | Unique ID associated with the event. | [optional] 
**EventType** | **string** | The event type can be PAYMENT, REFUND, REFUND_REVERSAL, DISPUTE, DISPUTE_REVERSAL, CHARGEBACK, CHARGEBACK_REVERSAL, OTHER_ADJUSTMENT. | [optional] 
**EventSettlementAmount** | **decimal** | Amount that is part of the settlement corresponding to the event. | [optional] 
**EventAmount** | **decimal** | Amount corresponding to the event. Example, refund amount, dispute amount, payment amount, etc. | [optional] 
**SaleType** | **string** | Indicates if it is CREDIT/DEBIT sale. | [optional] 
**EventStatus** | **string** | Status of the event. Example - SUCCESS, FAILED, PENDING, CANCELLED. | [optional] 
**Entity** | **string** | Recon. | [optional] 
**EventTime** | **string** | Time associated with the event. Example, transaction time, dispute initiation time. | [optional] 
**EventCurrency** | **string** | Curreny type - INR. | [optional] 
**EventServiceCharge** | **decimal** | Service charge for above event_type. | [optional] 
**EventServiceTax** | **decimal** | Service tax for above event_type. | [optional] 
**EventRemarks** | **decimal** | Remarks for above event_type. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


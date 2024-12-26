# cashfree_pg.Model.DisputesEntityMerchantAccepted

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**dispute_id** | **int** |  | [optional] 
**dispute_type** | **string** |  | [optional] 
**reason_code** | **string** |  | [optional] 
**reason_description** | **string** |  | [optional] 
**dispute_amount** | **decimal** | Dispute amount may differ from transaction amount for partial cases. | [optional] 
**created_at** | **string** | This is the time when the dispute was created. | [optional] 
**respond_by** | **string** | This is the time by which evidence should be submitted to contest the dispute. | [optional] 
**updated_at** | **string** | This is the time when the dispute case was updated. | [optional] 
**resolved_at** | **string** | This is the time when the dispute case was closed. | [optional] 
**dispute_status** | **string** |  | [optional] 
**cf_dispute_remarks** | **string** |  | [optional] 
**preferred_evidence** | [**List&lt;EvidencesToContestDispute&gt;**](EvidencesToContestDispute.md) |  | [optional] 
**dispute_evidence** | [**List&lt;Evidence&gt;**](Evidence.md) |  | [optional] 
**order_details** | [**OrderDetailsInDisputesEntity**](OrderDetailsInDisputesEntity.md) |  | [optional] 
**customer_details** | [**CustomerDetailsInDisputesEntity**](CustomerDetailsInDisputesEntity.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


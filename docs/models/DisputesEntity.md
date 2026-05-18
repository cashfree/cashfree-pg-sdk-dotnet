# cashfree-dotnet-pg-sdk.Model.DisputesEntity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisputeId** | **int** |  | [optional] 
**DisputeType** | **string** |  | [optional] 
**ReasonCode** | **string** |  | [optional] 
**ReasonDescription** | **string** |  | [optional] 
**DisputeAmount** | **decimal** | Dispute amount may differ from transaction amount for partial cases. | [optional] 
**DisputeAmountCurrency** | **string** | Dispute amount currency for a dispute. | [optional] 
**CreatedAt** | **string** | This is the time when the dispute was created. | [optional] 
**RespondBy** | **string** | This is the time by which evidence should be submitted to contest the dispute. | [optional] 
**UpdatedAt** | **string** | This is the time when the dispute case was updated. | [optional] 
**ResolvedAt** | **string** | This is the time when the dispute case was closed. | [optional] 
**DisputeStatus** | **string** |  | [optional] 
**CfDisputeRemarks** | **string** |  | [optional] 
**PreferredEvidence** | [**List&lt;EvidencesToContestDispute&gt;**](EvidencesToContestDispute.md) |  | [optional] 
**DisputeEvidence** | [**List&lt;Evidence&gt;**](Evidence.md) |  | [optional] 
**OrderDetails** | [**OrderDetailsInDisputesEntity**](OrderDetailsInDisputesEntity.md) |  | [optional] 
**CustomerDetails** | [**CustomerDetailsInDisputesEntity**](CustomerDetailsInDisputesEntity.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


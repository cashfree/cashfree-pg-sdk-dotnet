# cashfree-dotnet-pg-sdk.Model.SettlementFetchReconRequestFilters
Specify either the Settlement ID, Settlement UTR, or start date and end date to fetch the settlement details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CfSettlementIds** | **List&lt;int&gt;** | List of settlement IDs for which you want the settlement reconciliation details. | [optional] 
**SettlementUtrs** | **List&lt;string&gt;** | List of settlement UTRs for which you want the settlement reconciliation details. | [optional] 
**StartDate** | **string** | Specify the start date from when you want the settlement reconciliation details. | [optional] 
**EndDate** | **string** | Specify the end date till when you want the settlement reconciliation details. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


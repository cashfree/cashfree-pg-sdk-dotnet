# cashfree_pg.Model.SettlementFetchReconRequestFilters
Specify either the Settlement ID, Settlement UTR, or date range filters to fetch the settlement details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cf_settlement_ids** | **List&lt;int&gt;** | List of settlement IDs for which you want the settlement reconciliation details. | [optional] 
**settlement_utrs** | **List&lt;string&gt;** | List of settlement UTRs for which you want the settlement reconciliation details. | [optional] 
**start_date_initiated_on** | **string** | Filter events by settlement initiation start date. Use ISO8601 format. | [optional] 
**end_date_initiated_on** | **string** | Filter events by settlement initiation end date. Use ISO8601 format. | [optional] 
**start_date_processed_on** | **string** | Filter events by settlement processed start date. Use ISO8601 format. | [optional] 
**end_date_processed_on** | **string** | Filter events by settlement processed end date. Use ISO8601 format. | [optional] 
**start_date** | **string** | Deprecated: Use start_date_initiated_on or start_date_processed_on instead. Specify the start date from when you want the settlement reconciliation details. | [optional] 
**end_date** | **string** | Deprecated: Use end_date_initiated_on or end_date_processed_on instead. Specify the end date till when you want the settlement reconciliation details. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


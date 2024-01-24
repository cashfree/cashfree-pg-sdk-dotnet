# cashfree_pg.Model.FetchSettlementsRequestFilters
Specify either the Settlement ID, Settlement UTR, or start date and end date to fetch the settlement details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cf_settlement_ids** | **List&lt;long&gt;** | List of settlement IDs for which you want the settlement reconciliation details. | [optional] 
**settlement_utrs** | **List&lt;string&gt;** | List of settlement UTRs for which you want the settlement reconciliation details. | [optional] 
**start_date** | **string** | Specify the start date from when you want the settlement reconciliation details. | [optional] 
**end_date** | **string** | Specify the end date till when you want the settlement reconciliation details. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# cashfree_pg.Model.FetchSettlementsRequestPagination
To fetch the next set of settlements, pass the cursor received in the response to the next API call.   To receive the data for the first time, pass the cursor as null.   Limit would be number of settlements that you want to receive.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**limit** | **int** | The number of settlements you want to fetch. Maximum limit is 1000, default value is 10. | 
**cursor** | **string** | Specifies from where the next set of settlement details should be fetched. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


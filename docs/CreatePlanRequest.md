# cashfree_pg.Model.CreatePlanRequest
Request body to create a plan.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**plan_id** | **string** | Unique ID to identify the plan. Only alpha-numerics, dot, hyphen and underscore allowed. | 
**plan_name** | **string** | Name of the plan. | 
**plan_type** | **string** | Type of the plan. Possible values - PERIODIC, ON_DEMAND. | 
**plan_currency** | **string** | Currency of the plan. | [optional] 
**plan_recurring_amount** | **decimal** | Recurring amount for the plan. Required for PERIODIC plan_type. | [optional] 
**plan_max_amount** | **decimal** | Maximum amount for the plan. | 
**plan_max_cycles** | **int** | Maximum number of payment cycles for the plan. | [optional] 
**plan_intervals** | **int** | Number of billing cycles between charges. For instance, if set to 2 and the interval type is &#39;week&#39;, the service will be billed every 2 weeks. Similarly, if set to 3 and the interval type is &#39;month&#39;, the service will be billed every 3 months. Required for PERIODIC plan_type. | [optional] 
**plan_interval_type** | **string** | Interval type for the plan. Possible values - DAY, WEEK, MONTH, YEAR. | [optional] 
**plan_note** | **string** | Note for the plan. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


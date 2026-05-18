# cashfree-dotnet-pg-sdk.Model.CreateLinkPlanRequest
Request body to create a plan.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlanId** | **string** | Unique ID to identify the plan. Only alpha-numerics, dot, hyphen and underscore allowed. | 
**PlanName** | **string** | Name of the plan. | 
**PlanType** | **string** | Type of the plan. Possible values - PERIODIC, ON_DEMAND. | 
**PlanMaxAmount** | **decimal** | Maximum amount for the plan. | 
**PlanCurrency** | **string** | Currency of the plan. | [optional] 
**PlanAmount** | **decimal** | The amount to be charged for PERIODIC plan. This is a conditional parameter, only required for PERIODIC plans. | [optional] 
**PlanMaxCycles** | **int** | Maximum number of payment cycles for the plan. | [optional] 
**PlanIntervals** | **int** | Number of billing cycles between charges. | [optional] 
**PlanIntervalType** | **string** | Interval type for the plan. Possible values - DAY, WEEK, MONTH, YEAR. | [optional] 
**PlanNote** | **string** | Note for the plan. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


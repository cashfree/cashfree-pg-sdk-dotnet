# cashfree-dotnet-pg-sdk.Model.CreatePlanRequest
Request parameters to create a new plan.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlanId** | **string** | Unique ID to identify the plan. Only alpha-numerics, dot, hyphen and underscore allowed. | 
**PlanName** | **string** | Name of the plan. | 
**PlanType** | **string** | Type of the plan. Possible values - PERIODIC, ON_DEMAND. | 
**PlanMaxAmount** | **decimal** | Maximum amount for the plan. | 
**PlanCurrency** | **string** | Currency of the plan. For plans in non-INR currency, please refer to [supported currencies](https://www.cashfree.com/docs/payments/international-payments/ipg/currencies-supported#full-currency-list). | [optional] 
**PlanRecurringAmount** | **decimal** | Recurring amount for the plan. Required for PERIODIC plan_type. | [optional] 
**PlanMaxCycles** | **int** | Maximum number of payment cycles for the plan. | [optional] 
**PlanIntervals** | **int** | Number of billing cycles between charges. For instance, if set to 2 and the interval type is &#39;week&#39;, the service will be billed every 2 weeks. Similarly, if set to 3 and the interval type is &#39;month&#39;, the service will be billed every 3 months. Required for PERIODIC plan_type. | [optional] 
**PlanIntervalType** | **string** | Interval type for the plan. Possible values - DAY, WEEK, MONTH, YEAR. | [optional] 
**PlanNote** | **string** | Note for the plan. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


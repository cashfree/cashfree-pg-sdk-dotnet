# cashfree-dotnet-pg-sdk.Model.LinkSubscriptionEntity
Payment link subscription object for recurring payments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlanDetails** | [**LinkPlanEntity**](LinkPlanEntity.md) |  | [optional] 
**AuthorizationAmountRefund** | **bool** | Indicates whether the authorization amount should be refunded to the customer automatically. Merchants can use this field to specify if the authorized funds should be returned to the customer after authorization of the subscription. | [optional] 
**SubscriptionExpiryTime** | **string** | Time at which the subscription will expire. | [optional] 
**SubscriptionFirstChargeTime** | **string** | Time at which the first charge for the subscription will be processed. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


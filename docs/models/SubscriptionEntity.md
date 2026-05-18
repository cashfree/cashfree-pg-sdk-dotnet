# cashfree-dotnet-pg-sdk.Model.SubscriptionEntity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthorisationDetails** | [**AuthorizationDetails**](AuthorizationDetails.md) |  | [optional] 
**CfSubscriptionId** | **string** | Cashfree subscription reference number. | [optional] 
**CustomerDetails** | [**SubscriptionCustomerDetails**](SubscriptionCustomerDetails.md) |  | [optional] 
**PlanDetails** | [**PlanEntity**](PlanEntity.md) |  | [optional] 
**SubscriptionExpiryTime** | **string** | Time at which the subscription will expire. We store timestamps in IST. | [optional] 
**SubscriptionFirstChargeTime** | **string** | Time at which the first charge will be made for the subscription. Applicable only for PERIODIC plans. Cashfree stores timestamps in IST. | [optional] 
**SubscriptionId** | **string** | A unique ID passed by merchant for identifying the subscription. | [optional] 
**SubscriptionMeta** | [**SubscriptionEntitySubscriptionMeta**](SubscriptionEntitySubscriptionMeta.md) |  | [optional] 
**SubscriptionNote** | **string** | Note for the subscription. | [optional] 
**SubscriptionSessionId** | **string** | Subscription Session Id. | [optional] 
**SubscriptionPaymentSplits** | [**List&lt;SubscriptionPaymentSplitItem&gt;**](SubscriptionPaymentSplitItem.md) | Payment splits for the subscription. | [optional] 
**SubscriptionStatus** | **string** | Status of the subscription. For more details, see [Subscription Lifecycle](https://www.cashfree.com/docs/payments/subscription/create#subscription-lifecycle). | [optional] 
**SubscriptionTags** | **Object** | Tags for the subscription. | [optional] 
**NextScheduleDate** | **string** | The date on which the next payment is scheduled to be processed. Cashfree stores timestamps in IST. For ON_DEMAND plans this will be null . | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


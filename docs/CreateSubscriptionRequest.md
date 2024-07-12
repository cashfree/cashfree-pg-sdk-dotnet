# cashfree_pg.Model.CreateSubscriptionRequest
Request body to create a new subscription.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**subscription_id** | **string** | A unique ID for the subscription. It can include alphanumeric characters, underscore, dot, hyphen, and space. Maximum characters allowed is 250. | 
**customer_details** | [**SubscriptionCustomerDetails**](SubscriptionCustomerDetails.md) |  | 
**plan_details** | [**CreateSubscriptionRequestPlanDetails**](CreateSubscriptionRequestPlanDetails.md) |  | 
**authorization_details** | [**CreateSubscriptionRequestAuthorizationDetails**](CreateSubscriptionRequestAuthorizationDetails.md) |  | [optional] 
**subscription_meta** | [**CreateSubscriptionRequestSubscriptionMeta**](CreateSubscriptionRequestSubscriptionMeta.md) |  | [optional] 
**subscription_expiry_time** | **string** | Expiry date for the subscription. | [optional] 
**subscription_first_charge_time** | **string** | Time at which the first charge will be made for the subscription after authorization. Applicable only for PERIODIC plans. | [optional] 
**subscription_note** | **string** | Note for the subscription. | [optional] 
**subscription_tags** | **Object** | Tags for the subscription. | [optional] 
**subscription_payment_splits** | [**List&lt;SubscriptionPaymentSplitItem&gt;**](SubscriptionPaymentSplitItem.md) | Payment splits for the subscription. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


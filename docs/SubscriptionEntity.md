# cashfree_pg.Model.SubscriptionEntity
The response returned for Get, Create or Manage Subscription APIs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**authorisation_details** | [**AuthorizationDetails**](AuthorizationDetails.md) |  | [optional] 
**cf_subscription_id** | **string** | Cashfree subscription reference number | [optional] 
**customer_details** | [**SubscriptionCustomerDetails**](SubscriptionCustomerDetails.md) |  | [optional] 
**plan_details** | [**PlanEntity**](PlanEntity.md) |  | [optional] 
**subscription_expiry_time** | **string** | Time at which the subscription will expire. | [optional] 
**subscription_first_charge_time** | **string** | Time at which the first charge will be made for the subscription. Applicable only for PERIODIC plans. | [optional] 
**subscription_id** | **string** | A unique ID passed by merchant for identifying the subscription. | [optional] 
**subscription_meta** | [**SubscriptionEntitySubscriptionMeta**](SubscriptionEntitySubscriptionMeta.md) |  | [optional] 
**subscription_note** | **string** | Note for the subscription. | [optional] 
**subscription_session_id** | **string** | Subscription Session Id. | [optional] 
**subscription_payment_splits** | [**List&lt;SubscriptionPaymentSplitItem&gt;**](SubscriptionPaymentSplitItem.md) | Payment splits for the subscription. | [optional] 
**subscription_status** | **string** | Status of the subscription. | [optional] 
**subscription_tags** | **Object** | Tags for the subscription. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


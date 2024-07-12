# cashfree_pg.Model.SubscriptionPaymentEntity
The response returned in Get, Create or Manage Subscription Payment APIs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**authorization_details** | [**AuthorizationDetails**](AuthorizationDetails.md) |  | [optional] 
**cf_payment_id** | **string** | Cashfree subscription payment reference number | [optional] 
**cf_subscription_id** | **string** | Cashfree subscription reference number | [optional] 
**cf_txn_id** | **string** | Cashfree subscription payment transaction ID | [optional] 
**cf_order_id** | **string** | Cashfree subscription payment order ID | [optional] 
**failure_details** | [**CreateSubscriptionPaymentAuthResponseFailureDetails**](CreateSubscriptionPaymentAuthResponseFailureDetails.md) |  | [optional] 
**payment_amount** | **decimal** | The charge amount of the payment. | [optional] 
**payment_id** | **string** | A unique ID passed by merchant for identifying the transaction. | [optional] 
**payment_initiated_date** | **string** | The date on which the payment was initiated. | [optional] 
**payment_remarks** | **string** | Payment remarks. | [optional] 
**payment_schedule_date** | **string** | The date on which the payment is scheduled to be processed. | [optional] 
**payment_status** | **string** | Status of the payment. | [optional] 
**payment_type** | **string** | Payment type. Can be AUTH or CHARGE. | [optional] 
**retry_attempts** | **int** | Retry attempts. | [optional] 
**subscription_id** | **string** | A unique ID passed by merchant for identifying the subscription. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


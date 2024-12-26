# cashfree_pg.Model.CreateSubscriptionRequestAuthorizationDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**authorization_amount** | **decimal** | Authorization amount for the auth payment. | [optional] 
**authorization_amount_refund** | **bool** | Indicates whether the authorization amount should be refunded to the customer automatically. Merchants can use this field to specify if the authorized funds should be returned to the customer after authorization of the subscription. | [optional] 
**payment_methods** | **List&lt;string&gt;** | Payment methods for the subscription. enach, pnach, upi, card are possible values. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


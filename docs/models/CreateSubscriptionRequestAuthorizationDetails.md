# cashfree-dotnet-pg-sdk.Model.CreateSubscriptionRequestAuthorizationDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthorizationAmount** | **decimal** | Authorization amount for the auth payment. Please note that authorization_amount will always be 0 for ENACH. | [optional] 
**AuthorizationAmountRefund** | **bool** | Indicates whether the authorization amount should be refunded to the customer automatically. Merchants can use this field to specify if the authorized funds should be returned to the customer after authorization of the subscription. | [optional] 
**PaymentMethods** | **List&lt;string&gt;** | Payment methods for the subscription. enach, pnach, upi, card are possible values. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


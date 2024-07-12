# cashfree_pg.Model.PaymentWebhookDataEntity
data entity in webhook

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**order** | [**PaymentWebhookOrderEntity**](PaymentWebhookOrderEntity.md) |  | [optional] 
**payment** | [**PaymentEntity**](PaymentEntity.md) |  | [optional] 
**customer_details** | [**PaymentWebhookCustomerEntity**](PaymentWebhookCustomerEntity.md) |  | [optional] 
**error_details** | [**PaymentWebhookErrorEntity**](PaymentWebhookErrorEntity.md) |  | [optional] 
**payment_gateway_details** | [**PaymentWebhookGatewayDetailsEntity**](PaymentWebhookGatewayDetailsEntity.md) |  | [optional] 
**payment_offers** | [**List&lt;OfferEntity&gt;**](OfferEntity.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# cashfree_pg.Model.CreateSubscriptionPaymentRequestPaymentMethod
Payment method. Can be one of [\"upi\", \"enach\", \"pnach\", \"card\"]. This field is not required when raising a charge. It is only mandatory when raising an authorisation. In the case of a charge, this field is ignored, and the charge will be created using the same payment method that was used for the original authorisation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**upi** | [**CreateSubscriptionPaymentRequestUpiUpi**](CreateSubscriptionPaymentRequestUpiUpi.md) |  | [optional] 
**enach** | [**CreateSubscriptionPaymentRequestEnachEnach**](CreateSubscriptionPaymentRequestEnachEnach.md) |  | [optional] 
**pnach** | [**CreateSubscriptionPaymentRequestPnachPnach**](CreateSubscriptionPaymentRequestPnachPnach.md) |  | [optional] 
**card** | [**CreateSubscriptionPaymentRequestCardCard**](CreateSubscriptionPaymentRequestCardCard.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


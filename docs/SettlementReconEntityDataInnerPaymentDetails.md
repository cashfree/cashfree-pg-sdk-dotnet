# cashfree_pg.Model.SettlementReconEntityDataInnerPaymentDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**payment_amount** | **decimal** | Payment amount captured. | [optional] 
**payment_currency** | **string** | Payment Currency type - INR. | [optional] 
**bank_reference** | **string** | Unique transaction reference number of the payment. | [optional] 
**payment_time** | **string** | Date and time when the payment was initiated. | [optional] 
**payment_group** | **string** | Payment group/mode of the payment. Example - UPI, CREDIT_CARD. | [optional] 
**payment_service_charge** | **decimal** | Service charge applicable for the payment. | [optional] 
**payment_service_tax** | **decimal** | Service tax applicable on the payment. | [optional] 
**cf_payment_id** | **string** | Cashfree Payments unique ID to identify a payment. | [optional] 
**status** | **string** | Status of the Payment. | [optional] 
**forex_conversion_handling_charge** | **decimal** | Forex Conversion Service Charge. | [optional] 
**forex_conversion_handling_tax** | **decimal** | Forex Conversion Service Tax. | [optional] 
**charges_currency** | **string** | Forex Charges Currency type - INR. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


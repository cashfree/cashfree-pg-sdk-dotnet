# cashfree_pg.Model.OrderSettlementEntityPaymentDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**cf_payment_id** | **string** | Cashfree Payments unique ID to identify the payment. | [optional] 
**payment_time** | **string** | Date and time when the transaction was completed. | [optional] 
**payment_currency** | **string** | Currency of the payment. | [optional] 
**payment_amount** | **decimal** | Net amount of the transaction that was a part of this settlement. | [optional] [default to 0.0M]
**pg_service_charge** | **decimal** | PG service charges that were deducted in this settlement. | [optional] [default to 0.0M]
**pg_service_tax** | **decimal** | PG service taxes that were deducted in this settlement. | [optional] [default to 0.0M]
**split_service_charge** | **decimal** | Split service charges that were deducted in this settlement. | [optional] [default to 0.0M]
**split_service_tax** | **decimal** | Split service taxes that were deducted in this settlement. | [optional] [default to 0.0M]
**surcharge** | **decimal** | Surcharge collected from the customer. | [optional] [default to 0.0M]
**tax_on_surcharge** | **decimal** | Tax on surcharge. Upto 4 decimal points. | [optional] [default to 0.0M]
**charges_currency** | **string** | Currency in which service charges are applied. | [optional] 
**forex_conversion_handling_charge** | **decimal** | Forex conversion handling charge. | [optional] [default to 0.0M]
**forex_conversion_handling_tax** | **decimal** | Forex conversion handling tax. | [optional] [default to 0.0M]
**forex_conversion_rate** | **decimal** | Forex conversion rate applied. | [optional] [default to 0.0M]
**vendor_commission** | **decimal** | Vendor commission/split that was deducted in this settlement. | [optional] [default to 0.0M]
**settlement_amount** | **decimal** | Amount after deducting all charges. | [optional] [default to 0.0M]
**charge_type** | **string** | Indicates how Cashfree&#39;s service charges are applied for this payment. | [optional] 
**charged_to** | **string** | Indicates who bears Cashfree&#39;s service charges. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


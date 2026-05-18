# cashfree-dotnet-pg-sdk.Model.SplitOrderReconSuccessResponseSettlement
Details of the settlement information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | **string** | Type of entity. Example: \&quot;settlement\&quot;. | [optional] 
**CfSettlementId** | **long** | Unique Cashfree settlement ID. | [optional] 
**CfPaymentId** | **long** | Unique Cashfree payment ID associated with the order. | [optional] 
**OrderId** | **string** | Unique identifier for the order. | [optional] 
**OrderCurrency** | **string** | Currency of the order. Example: \&quot;INR\&quot;. | [optional] 
**TransferId** | **string** | Unique transfer ID if available, otherwise null. | [optional] 
**OrderAmount** | **decimal** | Total amount of the order. | [optional] 
**ServiceCharge** | **decimal** | Service charge for the order. | [optional] 
**ServiceTax** | **decimal** | Service tax for the order. | [optional] 
**SettlementAmount** | **decimal** | Amount to be settled after charges and tax. | [optional] 
**SettlementCurrency** | **string** | Currency of the settlement. Example: \&quot;INR\&quot;. | [optional] 
**TransferUtr** | **string** | UTR (Unique Transaction Reference) for the transfer if available, otherwise null. | [optional] 
**TransferTime** | **string** | Time of transfer if available, otherwise null. | [optional] 
**PaymentTime** | **string** | Timestamp when payment was made. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


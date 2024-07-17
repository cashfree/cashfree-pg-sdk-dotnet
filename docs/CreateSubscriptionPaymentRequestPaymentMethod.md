# cashfree_pg.Model.CreateSubscriptionPaymentRequestPaymentMethod
Payment method. Can be one of [\"upi\", \"enach\", \"pnach\", \"card\"]

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**upi_id** | **string** |  | [optional] 
**channel** | **string** | Channel. can be link | [optional] 
**auth_mode** | **string** | Authentication mode. can be debit_card, aadhaar, or net_banking | [optional] 
**account_holder_name** | **string** | Account holder name | [optional] 
**account_number** | **string** | Account number | [optional] 
**account_bank_code** | **string** | Account bank code | [optional] 
**account_type** | **string** | Account type | [optional] 
**account_ifsc** | **string** | Account IFSC | [optional] 
**mandate_creation_date** | **string** | Mandate creation date | [optional] 
**mandate_start_date** | **string** | Mandate start date | [optional] 
**card_number** | **string** | Card number | [optional] 
**card_holder_name** | **string** | Card holder name | [optional] 
**card_expiry_mm** | **string** | Card expiry month | [optional] 
**card_expiry_yy** | **string** | Card expiry year | [optional] 
**card_cvv** | **string** | Card CVV | [optional] 
**card_network** | **string** | Card network | [optional] 
**card_type** | **string** | Card type | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


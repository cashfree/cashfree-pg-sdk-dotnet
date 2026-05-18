# cashfree-dotnet-pg-sdk.Model.AuthorizationDetails
Details of the authorization done for the subscription. Returned in Get subscription and payments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AuthorizationAmount** | **decimal** | Authorization amount for the auth payment. Please note that authorization_amount will always be 0 for ENACH. | [optional] 
**AuthorizationAmountRefund** | **bool** | Indicates whether the authorization amount should be refunded to the customer automatically. Merchants can use this field to specify if the authorized funds should be returned to the customer after authorization of the subscription. | [optional] 
**AuthorizationReference** | **string** | Authorization reference. UMN for UPI, UMRN for EMandate/Physical Mandate and Enrollment ID for cards. | [optional] 
**AuthorizationTime** | **string** | Authorization time. Cashfree stores timestamps in IST. | [optional] 
**AuthorizationStatus** | **string** | Status of the authorization. | [optional] 
**PaymentId** | **string** | A unique ID passed by merchant for identifying the transaction. | [optional] 
**PaymentGroup** | **string** | Payment group used for the authorization. | [optional] 
**PaymentMethod** | [**AuthorizationDetailsPaymentMethod**](AuthorizationDetailsPaymentMethod.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


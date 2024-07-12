# cashfree_pg.Model.AuthorizationDetails
Details of the authorization done for the subscription. Returned in Get subscription and auth payments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**authorization_amount** | **decimal** | Authorization amount for the auth payment. | [optional] 
**authorization_amount_refund** | **bool** | Indicates whether the authorization amount should be refunded to the customer automatically. Merchants can use this field to specify if the authorized funds should be returned to the customer after authorization of the subscription. | [optional] 
**authorization_reference** | **string** | Authorization reference. UMN for UPI, UMRN for EMandate/Physical Mandate and Enrollment ID for cards. | [optional] 
**authorization_time** | **string** | Authorization time. | [optional] 
**authorization_status** | **string** | Status of the authorization. | [optional] 
**payment_id** | **string** | A unique ID passed by merchant for identifying the transaction. | [optional] 
**payment_method** | **string** | Payment method used for the authorization. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


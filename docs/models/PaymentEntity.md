# cashfree-dotnet-pg-sdk.Model.PaymentEntity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CfPaymentId** | **string** | Payment entity full object. | [optional] 
**OrderId** | **string** |  | [optional] 
**Entity** | **string** |  | [optional] 
**ErrorDetails** | [**ErrorDetailsInPaymentsEntity**](ErrorDetailsInPaymentsEntity.md) |  | [optional] 
**IsCaptured** | **bool** |  | [optional] 
**OrderAmount** | **decimal** | Order amount can be different from payment amount if you collect service fee from the customer. | [optional] 
**PaymentGroup** | **string** | Type of payment group. One of [&#39;prepaid_card&#39;, &#39;upi_ppi_offline&#39;, &#39;cash&#39;, &#39;upi_credit_card&#39;, &#39;paypal&#39;, &#39;net_banking&#39;, &#39;cardless_emi&#39;, &#39;credit_card&#39;, &#39;bank_transfer&#39;, &#39;pay_later&#39;, &#39;debit_card_emi&#39;, &#39;debit_card&#39;, &#39;wallet&#39;, &#39;upi_ppi&#39;, &#39;upi&#39;, &#39;credit_card_emi&#39;]. | [optional] 
**PaymentCurrency** | **string** |  | [optional] 
**PaymentAmount** | **decimal** |  | [optional] 
**PaymentTime** | **string** | This is the time when the payment was initiated. | [optional] 
**PaymentCompletionTime** | **string** | This is the time when the payment reaches its terminal state. | [optional] 
**PaymentStatus** | **string** | The transaction status can be one of  [\&quot;SUCCESS\&quot;, \&quot;NOT_ATTEMPTED\&quot;, \&quot;FAILED\&quot;, \&quot;USER_DROPPED\&quot;, \&quot;VOID\&quot;, \&quot;CANCELLED\&quot;, \&quot;PENDING\&quot;]. | [optional] 
**PaymentMessage** | **string** |  | [optional] 
**BankReference** | **string** | Issuing bank’s transaction reference number. | [optional] 
**AuthId** | **string** | Authorisation ID provided by the issuing bank. | [optional] 
**OrderCurrency** | **string** |  | [optional] 
**Authorization** | [**AuthorizationInPaymentsEntity**](AuthorizationInPaymentsEntity.md) |  | [optional] 
**PaymentMethod** | [**PaymentEntityPaymentMethod**](PaymentEntityPaymentMethod.md) |  | [optional] 
**InternationalPayment** | [**InternationalPaymentEntity**](InternationalPaymentEntity.md) |  | [optional] 
**PaymentGatewayDetails** | [**PaymentGatewayDetails**](PaymentGatewayDetails.md) |  | [optional] 
**PaymentSurcharge** | [**PaymentEntityPaymentSurcharge**](PaymentEntityPaymentSurcharge.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


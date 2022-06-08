# cashfreepg.Model.CFPaymentsEntity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CfPaymentId** | **int** |  | [optional] 
**OrderId** | **string** |  | [optional] 
**Entity** | **string** |  | [optional] 
**IsCaptured** | **bool** |  | [optional] 
**OrderAmount** | **decimal** | Order amount can be different from payment amount if you collect service fee from the customer | [optional] 
**PaymentGroup** | **string** | Type of payment group. One of [&#39;upi&#39;, &#39;card&#39;, &#39;app&#39;, &#39;netbanking&#39;, &#39;paylater&#39;, &#39;cardless_emi&#39;] | [optional] 
**PaymentCurrency** | **string** |  | [optional] 
**PaymentAmount** | **decimal** |  | [optional] 
**PaymentTime** | **string** |  | [optional] 
**PaymentStatus** | **string** | The transaction status can be one of  [\&quot;SUCCESS\&quot;, \&quot;NOT_ATTEMPTED\&quot;, \&quot;FAILED\&quot;, \&quot;USER_DROPPED\&quot;, \&quot;VOID\&quot;, \&quot;CANCELLED\&quot;, \&quot;PENDING\&quot;] | [optional] 
**PaymentMessage** | **string** |  | [optional] 
**BankReference** | **string** |  | [optional] 
**AuthId** | **string** |  | [optional] 
**Authorization** | [**CFAuthorizationInPaymentsEntity**](CFAuthorizationInPaymentsEntity.md) |  | [optional] 
**PaymentMethod** | [**CFPaymentsEntityPayment**](CFPaymentsEntityPayment.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


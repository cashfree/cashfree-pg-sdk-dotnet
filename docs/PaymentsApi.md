# cashfree-dotnet-pg-sdk.Api.PaymentsApi

All URIs are relative to *https://sandbox.cashfree.com/pg*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PGAuthorizeOrder**](PaymentsApi.md#pgauthorizeorder) | **POST** /orders/{order_id}/authorization | Preauthorisation |
| [**PGOrderAuthenticatePayment**](PaymentsApi.md#pgorderauthenticatepayment) | **POST** /orders/pay/authenticate/{cf_payment_id} | Submit or Resend OTP |
| [**PGOrderFetchPayment**](PaymentsApi.md#pgorderfetchpayment) | **GET** /orders/{order_id}/payments/{cf_payment_id} | Get Payment by ID |
| [**PGOrderFetchPayments**](PaymentsApi.md#pgorderfetchpayments) | **GET** /orders/{order_id}/payments | Get Payments for an Order |
| [**PGPayOrder**](PaymentsApi.md#pgpayorder) | **POST** /orders/sessions | Order Pay |
| [**PGPayOrderAuthorizeOnly**](PaymentsApi.md#pgpayorderauthorizeonly) | **POST** /orders/sessions/authorize | Order Pay Authorise Only |

<a id="pgauthorizeorder"></a>
# **PGAuthorizeOrder**
> PaymentEntity PGAuthorizeOrder (string xApiVersion, string orderId, AuthorizeOrderRequest authorizeOrderRequest, string? xRequestId = null, Guid? xIdempotencyKey = null)

Preauthorisation

Use this API to capture or void a [pre-authorised](/docs/payments/features/pre-authorisation) payment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree-dotnet-pg-sdk.Client;
using cashfree-dotnet-pg-sdk.Model;

namespace Example
{
    public class PGAuthorizeOrderExample
    {
        public static void Main()
        {
            // Configuration
            Cashfree.XClientId = "<x-client-id>";
            Cashfree.XClientSecret = "<x-client-secret>";
            Cashfree.XEnvironment = Cashfree.SANDBOX;
            
            // Instance of Cashfree
            var cashfree = new Cashfree();


            var xApiVersion = 2026-01-01;  // string | API version to be used. Format is in YYYY-MM-DD. (default to "2026-01-01")
            var orderId = your-order-id;  // string | The ID which uniquely identifies your order.
            var authorizeOrderRequest = new AuthorizeOrderRequest(); // AuthorizeOrderRequest | 
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request ID for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to Cashfree. (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.  (optional) 

            try
            {
                // Preauthorisation
                PaymentEntity result = cashfree.PGAuthorizeOrder(xApiVersion, orderId, authorizeOrderRequest, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.PGAuthorizeOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD. | [default to &quot;2026-01-01&quot;] |
| **orderId** | **string** | The ID which uniquely identifies your order. |  |
| **authorizeOrderRequest** | [**AuthorizeOrderRequest**](AuthorizeOrderRequest.md) |  |  |
| **xRequestId** | **string?** | Request ID for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to Cashfree. | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.  | [optional]  |

### Return type

[**PaymentEntity**](PaymentEntity.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success response for preauthorisation. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **400** | Bad request error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **401** | Authentication Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **404** | Resource Not found. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **409** | Resource already present. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **422** | Idempotency error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **429** | Rate Limit Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **500** | API related Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **502** | Bank related Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pgorderauthenticatepayment"></a>
# **PGOrderAuthenticatePayment**
> OrderAuthenticateEntity PGOrderAuthenticatePayment (string xApiVersion, string cfPaymentId, OrderAuthenticatePaymentRequest orderAuthenticatePaymentRequest, string? xRequestId = null, Guid? xIdempotencyKey = null)

Submit or Resend OTP

Use this API to submit or resend OTP if you use [Native OTP](https://www.cashfree.com/docs/payments/features/native-otp) for authentication of card payments.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree-dotnet-pg-sdk.Client;
using cashfree-dotnet-pg-sdk.Model;

namespace Example
{
    public class PGOrderAuthenticatePaymentExample
    {
        public static void Main()
        {
            // Configuration
            Cashfree.XClientId = "<x-client-id>";
            Cashfree.XClientSecret = "<x-client-secret>";
            Cashfree.XEnvironment = Cashfree.SANDBOX;
            
            // Instance of Cashfree
            var cashfree = new Cashfree();


            var xApiVersion = 2026-01-01;  // string | API version to be used. Format is in YYYY-MM-DD. (default to "2026-01-01")
            var cfPaymentId = 121224562;  // string | The Cashfree payment or transaction ID.
            var orderAuthenticatePaymentRequest = new OrderAuthenticatePaymentRequest(); // OrderAuthenticatePaymentRequest | Request body to submit or resend OTP in Native OTP flow.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request ID for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to Cashfree. (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.  (optional) 

            try
            {
                // Submit or Resend OTP
                OrderAuthenticateEntity result = cashfree.PGOrderAuthenticatePayment(xApiVersion, cfPaymentId, orderAuthenticatePaymentRequest, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.PGOrderAuthenticatePayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD. | [default to &quot;2026-01-01&quot;] |
| **cfPaymentId** | **string** | The Cashfree payment or transaction ID. |  |
| **orderAuthenticatePaymentRequest** | [**OrderAuthenticatePaymentRequest**](OrderAuthenticatePaymentRequest.md) | Request body to submit or resend OTP in Native OTP flow. |  |
| **xRequestId** | **string?** | Request ID for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to Cashfree. | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.  | [optional]  |

### Return type

[**OrderAuthenticateEntity**](OrderAuthenticateEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success response for submitting or resending OTP. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **400** | Bad request error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **401** | Authentication Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **404** | Resource Not found. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **409** | Resource already present. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **422** | Idempotency error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **429** | Rate Limit Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **500** | API related Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **502** | Bank related Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pgorderfetchpayment"></a>
# **PGOrderFetchPayment**
> PaymentEntity PGOrderFetchPayment (string xApiVersion, string orderId, string cfPaymentId, string? xRequestId = null, Guid? xIdempotencyKey = null)

Get Payment by ID

Use this API to view payment details of an order for a payment ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree-dotnet-pg-sdk.Client;
using cashfree-dotnet-pg-sdk.Model;

namespace Example
{
    public class PGOrderFetchPaymentExample
    {
        public static void Main()
        {
            // Configuration
            Cashfree.XClientId = "<x-client-id>";
            Cashfree.XClientSecret = "<x-client-secret>";
            Cashfree.XEnvironment = Cashfree.SANDBOX;
            
            // Instance of Cashfree
            var cashfree = new Cashfree();


            var xApiVersion = 2026-01-01;  // string | API version to be used. Format is in YYYY-MM-DD. (default to "2026-01-01")
            var orderId = your-order-id;  // string | The ID which uniquely identifies your order.
            var cfPaymentId = 121224562;  // string | The Cashfree payment or transaction ID.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request ID for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to Cashfree. (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.  (optional) 

            try
            {
                // Get Payment by ID
                PaymentEntity result = cashfree.PGOrderFetchPayment(xApiVersion, orderId, cfPaymentId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.PGOrderFetchPayment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD. | [default to &quot;2026-01-01&quot;] |
| **orderId** | **string** | The ID which uniquely identifies your order. |  |
| **cfPaymentId** | **string** | The Cashfree payment or transaction ID. |  |
| **xRequestId** | **string?** | Request ID for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to Cashfree. | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.  | [optional]  |

### Return type

[**PaymentEntity**](PaymentEntity.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success response for fetching payment by ID. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **400** | Bad request error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **401** | Authentication Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **404** | Resource Not found. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **409** | Resource already present. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **422** | Idempotency error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **429** | Rate Limit Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **500** | API related Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **502** | Bank related Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pgorderfetchpayments"></a>
# **PGOrderFetchPayments**
> List&lt;PaymentEntity&gt; PGOrderFetchPayments (string xApiVersion, string orderId, string? xRequestId = null, Guid? xIdempotencyKey = null)

Get Payments for an Order

Use this API to view all payment details for an order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree-dotnet-pg-sdk.Client;
using cashfree-dotnet-pg-sdk.Model;

namespace Example
{
    public class PGOrderFetchPaymentsExample
    {
        public static void Main()
        {
            // Configuration
            Cashfree.XClientId = "<x-client-id>";
            Cashfree.XClientSecret = "<x-client-secret>";
            Cashfree.XEnvironment = Cashfree.SANDBOX;
            
            // Instance of Cashfree
            var cashfree = new Cashfree();


            var xApiVersion = 2026-01-01;  // string | API version to be used. Format is in YYYY-MM-DD. (default to "2026-01-01")
            var orderId = your-order-id;  // string | The ID which uniquely identifies your order.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request ID for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to Cashfree. (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.  (optional) 

            try
            {
                // Get Payments for an Order
                List<PaymentEntity> result = cashfree.PGOrderFetchPayments(xApiVersion, orderId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.PGOrderFetchPayments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD. | [default to &quot;2026-01-01&quot;] |
| **orderId** | **string** | The ID which uniquely identifies your order. |  |
| **xRequestId** | **string?** | Request ID for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to Cashfree. | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.  | [optional]  |

### Return type

[**List&lt;PaymentEntity&gt;**](PaymentEntity.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success response for fetching payments for an order. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **400** | Bad request error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **401** | Authentication Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **404** | Resource Not found. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **409** | Resource already present. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **422** | Idempotency error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **429** | Rate Limit Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **500** | API related Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **502** | Bank related Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pgpayorder"></a>
# **PGPayOrder**
> PayOrderEntity PGPayOrder (string xApiVersion, PayOrderRequest payOrderRequest, string? xRequestId = null, Guid? xIdempotencyKey = null, string? xClientDevice = null, string? xClientOs = null, string? xClientRenderingType = null, string? xClientBrowser = null)

Order Pay

Use this API when you have already created the order using [Create Order API](https://www.cashfree.com/docs/api-reference/payments/latest/orders/create) and want Cashfree to process the payment. To use this API S2S flag needs to be enabled from the backend. In case you want to use this API for plain cards payments also, the PCI DSS flag is required, for more information fill out the [Support Form](https://merchant.cashfree.com/merchants/landing?env=prod&raise_issue=1). 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree-dotnet-pg-sdk.Client;
using cashfree-dotnet-pg-sdk.Model;

namespace Example
{
    public class PGPayOrderExample
    {
        public static void Main()
        {
            // Configuration
            Cashfree.XClientId = "<x-client-id>";
            Cashfree.XClientSecret = "<x-client-secret>";
            Cashfree.XEnvironment = Cashfree.SANDBOX;
            
            // Instance of Cashfree
            var cashfree = new Cashfree();


            var xApiVersion = 2026-01-01;  // string | API version to be used. Format is in YYYY-MM-DD. (default to "2026-01-01")
            var payOrderRequest = new PayOrderRequest(); // PayOrderRequest | Request body to create a transaction at Cashfree using `payment_session_id`.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request ID for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to Cashfree. (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.  (optional) 
            var xClientDevice = mobile;  // string? | The type of device on which the payment is initiated. (optional) 
            var xClientOs = android;  // string? | The operating system of the client device used to make the payment. (optional) 
            var xClientRenderingType = mweb;  // string? | Indicates how the payment experience is rendered to the user. - mweb – Payment rendered in a mobile browser (browser on a mobile device) - webview – Payment rendered inside an in-app browser (WebView within a merchant app) - native – Payment rendered natively within the merchant’s mobile app using SDKs. (optional) 
            var xClientBrowser = safari;  // string? | The browser used to initiate the payment. (optional) 

            try
            {
                // Order Pay
                PayOrderEntity result = cashfree.PGPayOrder(xApiVersion, payOrderRequest, xRequestId, xIdempotencyKey, xClientDevice, xClientOs, xClientRenderingType, xClientBrowser);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.PGPayOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD. | [default to &quot;2026-01-01&quot;] |
| **payOrderRequest** | [**PayOrderRequest**](PayOrderRequest.md) | Request body to create a transaction at Cashfree using &#x60;payment_session_id&#x60;. |  |
| **xRequestId** | **string?** | Request ID for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to Cashfree. | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.  | [optional]  |
| **xClientDevice** | **string?** | The type of device on which the payment is initiated. | [optional]  |
| **xClientOs** | **string?** | The operating system of the client device used to make the payment. | [optional]  |
| **xClientRenderingType** | **string?** | Indicates how the payment experience is rendered to the user. - mweb – Payment rendered in a mobile browser (browser on a mobile device) - webview – Payment rendered inside an in-app browser (WebView within a merchant app) - native – Payment rendered natively within the merchant’s mobile app using SDKs. | [optional]  |
| **xClientBrowser** | **string?** | The browser used to initiate the payment. | [optional]  |

### Return type

[**PayOrderEntity**](PayOrderEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success response for order pay. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **400** | Bad request error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **401** | Authentication Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **404** | Resource Not found. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **409** | Resource already present. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **422** | Idempotency error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **429** | Rate Limit Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **500** | API related Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **502** | Bank related Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pgpayorderauthorizeonly"></a>
# **PGPayOrderAuthorizeOnly**
> PaymentEntity PGPayOrderAuthorizeOnly (string xApiVersion, PayOrderAuthorizeOnlyRequest payOrderAuthorizeOnlyRequest, string? xRequestId = null, Guid? xIdempotencyKey = null)

Order Pay Authorise Only

Use this API when an order has already been created and you want Cashfree to process the payment for authorisation only. To use this API, the 'AUTHORIZE_ONLY' flag must be enabled for your account. Submit [Support Form](https://merchant.cashfree.com/auth/login) to enable this feature.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree-dotnet-pg-sdk.Client;
using cashfree-dotnet-pg-sdk.Model;

namespace Example
{
    public class PGPayOrderAuthorizeOnlyExample
    {
        public static void Main()
        {
            // Configuration
            Cashfree.XClientId = "<x-client-id>";
            Cashfree.XClientSecret = "<x-client-secret>";
            Cashfree.XEnvironment = Cashfree.SANDBOX;
            
            // Instance of Cashfree
            var cashfree = new Cashfree();


            var xApiVersion = 2026-01-01;  // string | API version to be used. Format is in YYYY-MM-DD. (default to "2026-01-01")
            var payOrderAuthorizeOnlyRequest = new PayOrderAuthorizeOnlyRequest(); // PayOrderAuthorizeOnlyRequest | Request body to create an authorization only transaction at cashfree using `payment_session_id`.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request ID for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to Cashfree. (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.  (optional) 

            try
            {
                // Order Pay Authorise Only
                PaymentEntity result = cashfree.PGPayOrderAuthorizeOnly(xApiVersion, payOrderAuthorizeOnlyRequest, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.PGPayOrderAuthorizeOnly: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD. | [default to &quot;2026-01-01&quot;] |
| **payOrderAuthorizeOnlyRequest** | [**PayOrderAuthorizeOnlyRequest**](PayOrderAuthorizeOnlyRequest.md) | Request body to create an authorization only transaction at cashfree using &#x60;payment_session_id&#x60;. |  |
| **xRequestId** | **string?** | Request ID for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to Cashfree. | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.  | [optional]  |

### Return type

[**PaymentEntity**](PaymentEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **400** | Bad request error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **401** | Authentication Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **404** | Resource Not found. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **409** | Resource already present. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **422** | Idempotency error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **429** | Rate Limit Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **500** | API related Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **502** | Bank related Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


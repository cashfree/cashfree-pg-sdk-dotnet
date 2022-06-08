# cashfreepg.Api.PaymentsApi

All URIs are relative to *https://sandbox.cashfree.com/pg*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetPaymentbyId**](PaymentsApi.md#getpaymentbyid) | **GET** /orders/{order_id}/payments/{cf_payment_id} | Get Payment by ID
[**GetPaymentsfororder**](PaymentsApi.md#getpaymentsfororder) | **GET** /orders/{order_id}/payments | Get Payments for an Order


<a name="getpaymentbyid"></a>
# **GetPaymentbyId**
> CFPaymentsEntity GetPaymentbyId (string xClientId, string xClientSecret, string orderId, int cfPaymentId, string xApiVersion = null, bool? xIdempotencyReplayed = null, string xIdempotencyKey = null, string xRequestId = null)

Get Payment by ID

Use this API to view payment details of an order for a payment ID.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfreepg.Api;
using cashfreepg.Client;
using cashfreepg.Model;

namespace Example
{
    public class GetPaymentbyIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sandbox.cashfree.com/pg";
            var apiInstance = new PaymentsApi(config);
            var xClientId = "xClientId_example";  // string | 
            var xClientSecret = "xClientSecret_example";  // string | 
            var orderId = "orderId_example";  // string | 
            var cfPaymentId = 56;  // int | 
            var xApiVersion = "\"2022-01-01\"";  // string |  (optional)  (default to "2022-01-01")
            var xIdempotencyReplayed = false;  // bool? |  (optional)  (default to false)
            var xIdempotencyKey = "xIdempotencyKey_example";  // string |  (optional) 
            var xRequestId = "xRequestId_example";  // string |  (optional) 

            try
            {
                // Get Payment by ID
                CFPaymentsEntity result = apiInstance.GetPaymentbyId(xClientId, xClientSecret, orderId, cfPaymentId, xApiVersion, xIdempotencyReplayed, xIdempotencyKey, xRequestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetPaymentbyId: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xClientId** | **string**|  | 
 **xClientSecret** | **string**|  | 
 **orderId** | **string**|  | 
 **cfPaymentId** | **int**|  | 
 **xApiVersion** | **string**|  | [optional] [default to &quot;2022-01-01&quot;]
 **xIdempotencyReplayed** | **bool?**|  | [optional] [default to false]
 **xIdempotencyKey** | **string**|  | [optional] 
 **xRequestId** | **string**|  | [optional] 

### Return type

[**CFPaymentsEntity**](CFPaymentsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  |
| **0** | Any bad or invalid request will lead to following error object |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentsfororder"></a>
# **GetPaymentsfororder**
> List&lt;CFPaymentsEntity&gt; GetPaymentsfororder (string xClientId, string xClientSecret, string orderId, string xApiVersion = null, bool? xIdempotencyReplayed = null, string xIdempotencyKey = null, string xRequestId = null)

Get Payments for an Order

Use this API to view all payment details for an order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfreepg.Api;
using cashfreepg.Client;
using cashfreepg.Model;

namespace Example
{
    public class GetPaymentsfororderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sandbox.cashfree.com/pg";
            var apiInstance = new PaymentsApi(config);
            var xClientId = "xClientId_example";  // string | 
            var xClientSecret = "xClientSecret_example";  // string | 
            var orderId = "orderId_example";  // string | 
            var xApiVersion = "\"2022-01-01\"";  // string |  (optional)  (default to "2022-01-01")
            var xIdempotencyReplayed = false;  // bool? |  (optional)  (default to false)
            var xIdempotencyKey = "xIdempotencyKey_example";  // string |  (optional) 
            var xRequestId = "xRequestId_example";  // string |  (optional) 

            try
            {
                // Get Payments for an Order
                List<CFPaymentsEntity> result = apiInstance.GetPaymentsfororder(xClientId, xClientSecret, orderId, xApiVersion, xIdempotencyReplayed, xIdempotencyKey, xRequestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.GetPaymentsfororder: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xClientId** | **string**|  | 
 **xClientSecret** | **string**|  | 
 **orderId** | **string**|  | 
 **xApiVersion** | **string**|  | [optional] [default to &quot;2022-01-01&quot;]
 **xIdempotencyReplayed** | **bool?**|  | [optional] [default to false]
 **xIdempotencyKey** | **string**|  | [optional] 
 **xRequestId** | **string**|  | [optional] 

### Return type

[**List&lt;CFPaymentsEntity&gt;**](CFPaymentsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  |
| **0** | Any bad or invalid request will lead to following error object |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


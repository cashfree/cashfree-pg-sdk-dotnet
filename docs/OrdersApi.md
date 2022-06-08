# cashfreepg.Api.OrdersApi

All URIs are relative to *https://sandbox.cashfree.com/pg*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateOrder**](OrdersApi.md#createorder) | **POST** /orders | Create Order
[**GetOrder**](OrdersApi.md#getorder) | **GET** /orders/{order_id} | Get Order
[**OrderPay**](OrdersApi.md#orderpay) | **POST** /orders/pay | Order Pay
[**Preauthorization**](OrdersApi.md#preauthorization) | **POST** /orders/{order_id}/authorization | Preauthorization


<a name="createorder"></a>
# **CreateOrder**
> CFOrder CreateOrder (string xClientId, string xClientSecret, string xApiVersion = null, bool? xIdempotencyReplayed = null, string xIdempotencyKey = null, string xRequestId = null, CFOrderRequest cFOrderRequest = null)

Create Order

Use this API to create orders with Cashfree from your backend and get the payment link

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfreepg.Api;
using cashfreepg.Client;
using cashfreepg.Model;

namespace Example
{
    public class CreateOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sandbox.cashfree.com/pg";
            var apiInstance = new OrdersApi(config);
            var xClientId = "xClientId_example";  // string | 
            var xClientSecret = "xClientSecret_example";  // string | 
            var xApiVersion = "\"2022-01-01\"";  // string |  (optional)  (default to "2022-01-01")
            var xIdempotencyReplayed = false;  // bool? |  (optional)  (default to false)
            var xIdempotencyKey = "xIdempotencyKey_example";  // string |  (optional) 
            var xRequestId = "xRequestId_example";  // string |  (optional) 
            var cFOrderRequest = new CFOrderRequest(); // CFOrderRequest |  (optional) 

            try
            {
                // Create Order
                CFOrder result = apiInstance.CreateOrder(xClientId, xClientSecret, xApiVersion, xIdempotencyReplayed, xIdempotencyKey, xRequestId, cFOrderRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.CreateOrder: " + e.Message );
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
 **xApiVersion** | **string**|  | [optional] [default to &quot;2022-01-01&quot;]
 **xIdempotencyReplayed** | **bool?**|  | [optional] [default to false]
 **xIdempotencyKey** | **string**|  | [optional] 
 **xRequestId** | **string**|  | [optional] 
 **cFOrderRequest** | [**CFOrderRequest**](CFOrderRequest.md)|  | [optional] 

### Return type

[**CFOrder**](CFOrder.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  |
| **0** | Any bad or invalid request will lead to following error object |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getorder"></a>
# **GetOrder**
> CFOrder GetOrder (string xClientId, string xClientSecret, string orderId, string xApiVersion = null, bool? xIdempotencyReplayed = null, string xIdempotencyKey = null, string xRequestId = null)

Get Order

Use this API to view all details of an order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfreepg.Api;
using cashfreepg.Client;
using cashfreepg.Model;

namespace Example
{
    public class GetOrderExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sandbox.cashfree.com/pg";
            var apiInstance = new OrdersApi(config);
            var xClientId = "xClientId_example";  // string | 
            var xClientSecret = "xClientSecret_example";  // string | 
            var orderId = "orderId_example";  // string | 
            var xApiVersion = "\"2022-01-01\"";  // string |  (optional)  (default to "2022-01-01")
            var xIdempotencyReplayed = false;  // bool? |  (optional)  (default to false)
            var xIdempotencyKey = "xIdempotencyKey_example";  // string |  (optional) 
            var xRequestId = "xRequestId_example";  // string |  (optional) 

            try
            {
                // Get Order
                CFOrder result = apiInstance.GetOrder(xClientId, xClientSecret, orderId, xApiVersion, xIdempotencyReplayed, xIdempotencyKey, xRequestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.GetOrder: " + e.Message );
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

[**CFOrder**](CFOrder.md)

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

<a name="orderpay"></a>
# **OrderPay**
> CFOrderPayResponse OrderPay (string xApiVersion, string xRequestId = null, CFOrderPayRequest cFOrderPayRequest = null)

Order Pay

Use this API when you have already created the orders and want Cashfree to process the payment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfreepg.Api;
using cashfreepg.Client;
using cashfreepg.Model;

namespace Example
{
    public class OrderPayExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sandbox.cashfree.com/pg";
            var apiInstance = new OrdersApi(config);
            var xApiVersion = "xApiVersion_example";  // string | 
            var xRequestId = "xRequestId_example";  // string |  (optional) 
            var cFOrderPayRequest = new CFOrderPayRequest(); // CFOrderPayRequest |  (optional) 

            try
            {
                // Order Pay
                CFOrderPayResponse result = apiInstance.OrderPay(xApiVersion, xRequestId, cFOrderPayRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.OrderPay: " + e.Message );
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
 **xApiVersion** | **string**|  | 
 **xRequestId** | **string**|  | [optional] 
 **cFOrderPayRequest** | [**CFOrderPayRequest**](CFOrderPayRequest.md)|  | [optional] 

### Return type

[**CFOrderPayResponse**](CFOrderPayResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  |
| **0** | Any bad or invalid request will lead to following error object |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="preauthorization"></a>
# **Preauthorization**
> CFPaymentsEntity Preauthorization (string xClientId, string xClientSecret, string orderId, string xApiVersion = null, bool? xIdempotencyReplayed = null, string xIdempotencyKey = null, string xRequestId = null, CFAuthorizationRequest cFAuthorizationRequest = null)

Preauthorization

Use this API to capture or void a preauthorized payment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfreepg.Api;
using cashfreepg.Client;
using cashfreepg.Model;

namespace Example
{
    public class PreauthorizationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sandbox.cashfree.com/pg";
            var apiInstance = new OrdersApi(config);
            var xClientId = "xClientId_example";  // string | 
            var xClientSecret = "xClientSecret_example";  // string | 
            var orderId = "orderId_example";  // string | 
            var xApiVersion = "\"2022-01-01\"";  // string |  (optional)  (default to "2022-01-01")
            var xIdempotencyReplayed = false;  // bool? |  (optional)  (default to false)
            var xIdempotencyKey = "xIdempotencyKey_example";  // string |  (optional) 
            var xRequestId = "xRequestId_example";  // string |  (optional) 
            var cFAuthorizationRequest = new CFAuthorizationRequest(); // CFAuthorizationRequest |  (optional) 

            try
            {
                // Preauthorization
                CFPaymentsEntity result = apiInstance.Preauthorization(xClientId, xClientSecret, orderId, xApiVersion, xIdempotencyReplayed, xIdempotencyKey, xRequestId, cFAuthorizationRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.Preauthorization: " + e.Message );
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
 **cFAuthorizationRequest** | [**CFAuthorizationRequest**](CFAuthorizationRequest.md)|  | [optional] 

### Return type

[**CFPaymentsEntity**](CFPaymentsEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  |
| **0** | Any bad or invalid request will lead to following error object |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


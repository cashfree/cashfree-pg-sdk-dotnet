# cashfreepg.Api.SettlementsApi

All URIs are relative to *https://sandbox.cashfree.com/pg*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Getsettlements**](SettlementsApi.md#getsettlements) | **GET** /orders/{order_id}/settlements | Get Settlements


<a name="getsettlements"></a>
# **Getsettlements**
> CFSettlementsEntity Getsettlements (string xClientId, string xClientSecret, string orderId, string xApiVersion = null, bool? xIdempotencyReplayed = null, string xIdempotencyKey = null, string xRequestId = null)

Get Settlements

Use this API to view all the settlements of a particular order.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfreepg.Api;
using cashfreepg.Client;
using cashfreepg.Model;

namespace Example
{
    public class GetsettlementsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sandbox.cashfree.com/pg";
            var apiInstance = new SettlementsApi(config);
            var xClientId = "xClientId_example";  // string | 
            var xClientSecret = "xClientSecret_example";  // string | 
            var orderId = "orderId_example";  // string | 
            var xApiVersion = "\"2022-01-01\"";  // string |  (optional)  (default to "2022-01-01")
            var xIdempotencyReplayed = false;  // bool? |  (optional)  (default to false)
            var xIdempotencyKey = "xIdempotencyKey_example";  // string |  (optional) 
            var xRequestId = "xRequestId_example";  // string |  (optional) 

            try
            {
                // Get Settlements
                CFSettlementsEntity result = apiInstance.Getsettlements(xClientId, xClientSecret, orderId, xApiVersion, xIdempotencyReplayed, xIdempotencyKey, xRequestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SettlementsApi.Getsettlements: " + e.Message );
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

[**CFSettlementsEntity**](CFSettlementsEntity.md)

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


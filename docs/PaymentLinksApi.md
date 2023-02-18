# cashfreepg.Api.PaymentLinksApi

All URIs are relative to *https://sandbox.cashfree.com/pg*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CancelPaymentLink**](PaymentLinksApi.md#cancelpaymentlink) | **POST** /links/{link_id}/cancel | Cancel Payment Link
[**CreatePaymentLink**](PaymentLinksApi.md#createpaymentlink) | **POST** /links | Create Payment Link
[**GetPaymentLinkDetails**](PaymentLinksApi.md#getpaymentlinkdetails) | **GET** /links/{link_id} | Fetch Payment Link Details
[**GetPaymentLinkOrders**](PaymentLinksApi.md#getpaymentlinkorders) | **GET** /links/{link_id}/orders | Get Orders for a Payment Link


<a name="cancelpaymentlink"></a>
# **CancelPaymentLink**
> LinkCancelledResponse CancelPaymentLink (string xClientId, string xClientSecret, string linkId, string xApiVersion = null)

Cancel Payment Link

Use this API to cancel a payment link. No further payments can be done against a cancelled link. Only a link in ACTIVE status can be cancelled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfreepg.Api;
using cashfreepg.Client;
using cashfreepg.Model;

namespace Example
{
    public class CancelPaymentLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sandbox.cashfree.com/pg";
            var apiInstance = new PaymentLinksApi(config);
            var xClientId = "xClientId_example";  // string | 
            var xClientSecret = "xClientSecret_example";  // string | 
            var linkId = "linkId_example";  // string | 
            var xApiVersion = "\"2022-01-01\"";  // string |  (optional)  (default to "2022-01-01")

            try
            {
                // Cancel Payment Link
                LinkCancelledResponse result = apiInstance.CancelPaymentLink(xClientId, xClientSecret, linkId, xApiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentLinksApi.CancelPaymentLink: " + e.Message );
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
 **linkId** | **string**|  | 
 **xApiVersion** | **string**|  | [optional] [default to &quot;2022-01-01&quot;]

### Return type

[**LinkCancelledResponse**](LinkCancelledResponse.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Payment Link cancelled |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  |
| **400** | Cannot cancel Payment Link if status is not ACTIVE |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createpaymentlink"></a>
# **CreatePaymentLink**
> CFLink CreatePaymentLink (string xClientId, string xClientSecret, string xApiVersion = null, bool? xIdempotencyReplayed = null, string xIdempotencyKey = null, string xRequestId = null, CFLinkRequest cFLinkRequest = null)

Create Payment Link

Use this API to create a new payment link. The created payment link url will be available in the API response parameter link_url.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfreepg.Api;
using cashfreepg.Client;
using cashfreepg.Model;

namespace Example
{
    public class CreatePaymentLinkExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sandbox.cashfree.com/pg";
            var apiInstance = new PaymentLinksApi(config);
            var xClientId = "xClientId_example";  // string | 
            var xClientSecret = "xClientSecret_example";  // string | 
            var xApiVersion = "\"2022-01-01\"";  // string |  (optional)  (default to "2022-01-01")
            var xIdempotencyReplayed = false;  // bool? |  (optional)  (default to false)
            var xIdempotencyKey = "xIdempotencyKey_example";  // string |  (optional) 
            var xRequestId = "xRequestId_example";  // string |  (optional) 
            var cFLinkRequest = new CFLinkRequest(); // CFLinkRequest |  (optional) 

            try
            {
                // Create Payment Link
                CFLink result = apiInstance.CreatePaymentLink(xClientId, xClientSecret, xApiVersion, xIdempotencyReplayed, xIdempotencyKey, xRequestId, cFLinkRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentLinksApi.CreatePaymentLink: " + e.Message );
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
 **cFLinkRequest** | [**CFLinkRequest**](CFLinkRequest.md)|  | [optional] 

### Return type

[**CFLink**](CFLink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Payment Link created |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentlinkdetails"></a>
# **GetPaymentLinkDetails**
> CFLink GetPaymentLinkDetails (string xClientId, string xClientSecret, string linkId, string xApiVersion = null, bool? xIdempotencyReplayed = null, string xIdempotencyKey = null, string xRequestId = null)

Fetch Payment Link Details

Use this API to view all details and status of a payment link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfreepg.Api;
using cashfreepg.Client;
using cashfreepg.Model;

namespace Example
{
    public class GetPaymentLinkDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sandbox.cashfree.com/pg";
            var apiInstance = new PaymentLinksApi(config);
            var xClientId = "xClientId_example";  // string | 
            var xClientSecret = "xClientSecret_example";  // string | 
            var linkId = "linkId_example";  // string | 
            var xApiVersion = "\"2022-01-01\"";  // string |  (optional)  (default to "2022-01-01")
            var xIdempotencyReplayed = false;  // bool? |  (optional)  (default to false)
            var xIdempotencyKey = "xIdempotencyKey_example";  // string |  (optional) 
            var xRequestId = "xRequestId_example";  // string |  (optional) 

            try
            {
                // Fetch Payment Link Details
                CFLink result = apiInstance.GetPaymentLinkDetails(xClientId, xClientSecret, linkId, xApiVersion, xIdempotencyReplayed, xIdempotencyKey, xRequestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentLinksApi.GetPaymentLinkDetails: " + e.Message );
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
 **linkId** | **string**|  | 
 **xApiVersion** | **string**|  | [optional] [default to &quot;2022-01-01&quot;]
 **xIdempotencyReplayed** | **bool?**|  | [optional] [default to false]
 **xIdempotencyKey** | **string**|  | [optional] 
 **xRequestId** | **string**|  | [optional] 

### Return type

[**CFLink**](CFLink.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpaymentlinkorders"></a>
# **GetPaymentLinkOrders**
> List&lt;CFLinkOrders&gt; GetPaymentLinkOrders (string xClientId, string xClientSecret, string linkId, string xApiVersion = null, bool? xIdempotencyReplayed = null, string xIdempotencyKey = null, string xRequestId = null)

Get Orders for a Payment Link

Use this API to view all order details for a payment link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfreepg.Api;
using cashfreepg.Client;
using cashfreepg.Model;

namespace Example
{
    public class GetPaymentLinkOrdersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sandbox.cashfree.com/pg";
            var apiInstance = new PaymentLinksApi(config);
            var xClientId = "xClientId_example";  // string | 
            var xClientSecret = "xClientSecret_example";  // string | 
            var linkId = "linkId_example";  // string | 
            var xApiVersion = "\"2022-01-01\"";  // string |  (optional)  (default to "2022-01-01")
            var xIdempotencyReplayed = false;  // bool? |  (optional)  (default to false)
            var xIdempotencyKey = "xIdempotencyKey_example";  // string |  (optional) 
            var xRequestId = "xRequestId_example";  // string |  (optional) 

            try
            {
                // Get Orders for a Payment Link
                List<CFLinkOrders> result = apiInstance.GetPaymentLinkOrders(xClientId, xClientSecret, linkId, xApiVersion, xIdempotencyReplayed, xIdempotencyKey, xRequestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentLinksApi.GetPaymentLinkOrders: " + e.Message );
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
 **linkId** | **string**|  | 
 **xApiVersion** | **string**|  | [optional] [default to &quot;2022-01-01&quot;]
 **xIdempotencyReplayed** | **bool?**|  | [optional] [default to false]
 **xIdempotencyKey** | **string**|  | [optional] 
 **xRequestId** | **string**|  | [optional] 

### Return type

[**List&lt;CFLinkOrders&gt;**](CFLinkOrders.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


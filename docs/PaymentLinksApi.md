# cashfree_pg.Api.PaymentLinksApi

All URIs are relative to *https://sandbox.cashfree.com/pg*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PGCancelLink**](PaymentLinksApi.md#pgcancellink) | **POST** /links/{link_id}/cancel | Cancel Payment Link |
| [**PGCreateLink**](PaymentLinksApi.md#pgcreatelink) | **POST** /links | Create Payment Link |
| [**PGFetchLink**](PaymentLinksApi.md#pgfetchlink) | **GET** /links/{link_id} | Fetch Payment Link Details |
| [**PGLinkFetchOrders**](PaymentLinksApi.md#pglinkfetchorders) | **GET** /links/{link_id}/orders | Get Orders for a Payment Link |

<a id="pgcancellink"></a>
# **PGCancelLink**
> LinkEntity PGCancelLink (string xApiVersion, string linkId, string? xRequestId = null, Guid? xIdempotencyKey = null)

Cancel Payment Link

Use this API to cancel a payment link. No further payments can be done against a cancelled link. Only a link in ACTIVE status can be cancelled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGCancelLinkExample
    {
        public static void Main()
        {
            // Configuration
            Cashfree.XClientId = "<x-client-id>";
            Cashfree.XClientSecret = "<x-client-secret>";
            Cashfree.XEnvironment = Cashfree.SANDBOX;
            
            // Instance of Cashfree
            var cashfree = new Cashfree();


            var xApiVersion = 2023-08-01;  // string | API version to be used. Format is in YYYY-MM-DD (default to "2023-08-01")
            var linkId = your-link-id;  // string | The payment link ID for which you want to view the details.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Cancel Payment Link
                LinkEntity result = cashfree.PGCancelLink(xApiVersion, linkId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentLinksApi.PGCancelLink: " + e.Message);
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
| **xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2023-08-01&quot;] |
| **linkId** | **string** | The payment link ID for which you want to view the details. |  |
| **xRequestId** | **string?** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   | [optional]  |

### Return type

[**LinkEntity**](LinkEntity.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **400** | Bad request error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **401** | Authentication Error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **404** | Resource Not found |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **409** | Resource already present |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **422** | Idempotency error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **429** | Rate Limit Error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **500** | API related Error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pgcreatelink"></a>
# **PGCreateLink**
> LinkEntity PGCreateLink (string xApiVersion, CreateLinkRequest createLinkRequest, string? xRequestId = null, Guid? xIdempotencyKey = null)

Create Payment Link

Use this API to create a new payment link. The created payment link url will be available in the API response parameter link_url.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGCreateLinkExample
    {
        public static void Main()
        {
            // Configuration
            Cashfree.XClientId = "<x-client-id>";
            Cashfree.XClientSecret = "<x-client-secret>";
            Cashfree.XEnvironment = Cashfree.SANDBOX;
            
            // Instance of Cashfree
            var cashfree = new Cashfree();


            var xApiVersion = 2023-08-01;  // string | API version to be used. Format is in YYYY-MM-DD (default to "2023-08-01")
            var createLinkRequest = new CreateLinkRequest(); // CreateLinkRequest | Request Body to Create Payment Links
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Create Payment Link
                LinkEntity result = cashfree.PGCreateLink(xApiVersion, createLinkRequest, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentLinksApi.PGCreateLink: " + e.Message);
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
| **xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2023-08-01&quot;] |
| **createLinkRequest** | [**CreateLinkRequest**](CreateLinkRequest.md) | Request Body to Create Payment Links |  |
| **xRequestId** | **string?** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   | [optional]  |

### Return type

[**LinkEntity**](LinkEntity.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **400** | Bad request error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **401** | Authentication Error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **404** | Resource Not found |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **409** | Resource already present |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **422** | Idempotency error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **429** | Rate Limit Error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **500** | API related Error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pgfetchlink"></a>
# **PGFetchLink**
> LinkEntity PGFetchLink (string xApiVersion, string linkId, string? xRequestId = null, Guid? xIdempotencyKey = null)

Fetch Payment Link Details

Use this API to view all details and status of a payment link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGFetchLinkExample
    {
        public static void Main()
        {
            // Configuration
            Cashfree.XClientId = "<x-client-id>";
            Cashfree.XClientSecret = "<x-client-secret>";
            Cashfree.XEnvironment = Cashfree.SANDBOX;
            
            // Instance of Cashfree
            var cashfree = new Cashfree();


            var xApiVersion = 2023-08-01;  // string | API version to be used. Format is in YYYY-MM-DD (default to "2023-08-01")
            var linkId = your-link-id;  // string | The payment link ID for which you want to view the details.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Fetch Payment Link Details
                LinkEntity result = cashfree.PGFetchLink(xApiVersion, linkId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentLinksApi.PGFetchLink: " + e.Message);
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
| **xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2023-08-01&quot;] |
| **linkId** | **string** | The payment link ID for which you want to view the details. |  |
| **xRequestId** | **string?** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   | [optional]  |

### Return type

[**LinkEntity**](LinkEntity.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **400** | Bad request error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **401** | Authentication Error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **404** | Resource Not found |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **409** | Resource already present |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **422** | Idempotency error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **429** | Rate Limit Error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **500** | API related Error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **502** | Bank related Error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pglinkfetchorders"></a>
# **PGLinkFetchOrders**
> List&lt;PaymentLinkOrderEntity&gt; PGLinkFetchOrders (string xApiVersion, string linkId, string? xRequestId = null, Guid? xIdempotencyKey = null)

Get Orders for a Payment Link

Use this API to view all order details for a payment link.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGLinkFetchOrdersExample
    {
        public static void Main()
        {
            // Configuration
            Cashfree.XClientId = "<x-client-id>";
            Cashfree.XClientSecret = "<x-client-secret>";
            Cashfree.XEnvironment = Cashfree.SANDBOX;
            
            // Instance of Cashfree
            var cashfree = new Cashfree();


            var xApiVersion = 2023-08-01;  // string | API version to be used. Format is in YYYY-MM-DD (default to "2023-08-01")
            var linkId = your-link-id;  // string | The payment link ID for which you want to view the details.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Get Orders for a Payment Link
                List<PaymentLinkOrderEntity> result = cashfree.PGLinkFetchOrders(xApiVersion, linkId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentLinksApi.PGLinkFetchOrders: " + e.Message);
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
| **xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2023-08-01&quot;] |
| **linkId** | **string** | The payment link ID for which you want to view the details. |  |
| **xRequestId** | **string?** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   | [optional]  |

### Return type

[**List&lt;PaymentLinkOrderEntity&gt;**](PaymentLinkOrderEntity.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **400** | Bad request error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **401** | Authentication Error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **404** | Resource Not found |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **409** | Resource already present |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **422** | Idempotency error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **429** | Rate Limit Error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **500** | API related Error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


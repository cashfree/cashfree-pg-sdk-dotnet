# cashfree_pg.Api.DefaultApi

All URIs are relative to *https://sandbox.cashfree.com/pg*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TerminalCreateQRCodes**](DefaultApi.md#terminalcreateqrcodes) | **POST** /partners/merchant/qrcodes | Create Pre-Activated Vpas for partner |
| [**TerminalGetQRCodes**](DefaultApi.md#terminalgetqrcodes) | **GET** /partners/merchant/qrcodes | Get Pre-Activated Vpas for partner |

<a id="terminalcreateqrcodes"></a>
# **TerminalCreateQRCodes**
> List&lt;StaticQrResponseEntity&gt; TerminalCreateQRCodes (string xApiVersion, string? xRequestId = null, Guid? xIdempotencyKey = null, CreatePartnerVpaRequest? createPartnerVpaRequest = null)

Create Pre-Activated Vpas for partner

Use this API to create a pre-activated vpa for partner.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class TerminalCreateQRCodesExample
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
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 
            var createPartnerVpaRequest = new CreatePartnerVpaRequest?(); // CreatePartnerVpaRequest? |  (optional) 

            try
            {
                // Create Pre-Activated Vpas for partner
                List<StaticQrResponseEntity> result = cashfree.TerminalCreateQRCodes(xApiVersion, xRequestId, xIdempotencyKey, createPartnerVpaRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.TerminalCreateQRCodes: " + e.Message);
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
| **xRequestId** | **string?** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   | [optional]  |
| **createPartnerVpaRequest** | [**CreatePartnerVpaRequest?**](CreatePartnerVpaRequest?.md) |  | [optional]  |

### Return type

[**List&lt;StaticQrResponseEntity&gt;**](StaticQrResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Invalid Partner API Key |  -  |
| **400** | Bad request error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **404** | Resource Not found |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **409** | Resource already present |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **422** | Idempotency error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **429** | Rate Limit Error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **500** | API related Error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="terminalgetqrcodes"></a>
# **TerminalGetQRCodes**
> List&lt;StaticQrResponseEntity&gt; TerminalGetQRCodes (string xApiVersion, string status, string cfTerminalId, string? xRequestId = null, Guid? xIdempotencyKey = null)

Get Pre-Activated Vpas for partner

Use this API to get a pre-activated vpa for partner.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class TerminalGetQRCodesExample
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
            var status = MAPPED;  // string | Status of pre-created Qr.
            var cfTerminalId = 123344;  // string | Cashfree terminal id for which you want to get pre-generated staticQRs.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Get Pre-Activated Vpas for partner
                List<StaticQrResponseEntity> result = cashfree.TerminalGetQRCodes(xApiVersion, status, cfTerminalId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultApi.TerminalGetQRCodes: " + e.Message);
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
| **status** | **string** | Status of pre-created Qr. |  |
| **cfTerminalId** | **string** | Cashfree terminal id for which you want to get pre-generated staticQRs. |  |
| **xRequestId** | **string?** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   | [optional]  |

### Return type

[**List&lt;StaticQrResponseEntity&gt;**](StaticQrResponseEntity.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | OK |  -  |
| **401** | Invalid Partner API Key |  -  |
| **400** | Bad request error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **404** | Resource Not found |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **409** | Resource already present |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **422** | Idempotency error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **429** | Rate Limit Error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **500** | API related Error |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


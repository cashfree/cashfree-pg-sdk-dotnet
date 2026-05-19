# cashfree-dotnet-pg-sdk.Api.DowntimeApi

All URIs are relative to *https://sandbox.cashfree.com/pg*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**FetchActiveEcosystemDowntimes**](DowntimeApi.md#fetchactiveecosystemdowntimes) | **GET** /incident | Fetch All Downtimes |

<a id="fetchactiveecosystemdowntimes"></a>
# **FetchActiveEcosystemDowntimes**
> FetchActiveEcosystemDowntimes200Response FetchActiveEcosystemDowntimes (string xApiVersion, string? xRequestId = null, Guid? xIdempotencyKey = null, string? incidentId = null, List<string>? incidentStatus = null, List<string>? incidentImpact = null, List<string>? incidentType = null, DateTime? incidentStartTime = null, DateTime? incidentEndTime = null, List<string>? paymentMethod = null)

Fetch All Downtimes

Fetches active downtimes across various payment methods based on filters. Gives all active downtimes when no filters are applied.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree-dotnet-pg-sdk.Client;
using cashfree-dotnet-pg-sdk.Model;

namespace Example
{
    public class FetchActiveEcosystemDowntimesExample
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
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request ID for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to Cashfree. (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.  (optional) 
            var incidentId = your-incident-id;  // string? | Valid incident id for fetching incident details. (optional) 
            var incidentStatus = new List<string>?(); // List<string>? | Filter incidents by status. Possible values: ACTIVE, UPCOMING, RESOLVED. (optional) 
            var incidentImpact = new List<string>?(); // List<string>? | Filter incidents by impact level. Possible values: HIGH, MEDIUM, LOW. (optional) 
            var incidentType = new List<string>?(); // List<string>? | Filter incidents by type. Possible values: SCHEDULED, UNSCHEDULED. (optional) 
            var incidentStartTime = 2024-06-01 14:00:00;  // DateTime? | Filter incidents by start time. Format: YYYY-MM-DD HH:MM:SS. (optional) 
            var incidentEndTime = 2024-06-02 14:00:00;  // DateTime? | Filter incidents by end time. Format: YYYY-MM-DD HH:MM:SS. (optional) 
            var paymentMethod = new List<string>?(); // List<string>? | Filter incidents by payment method. Possible values: UPI, CARD, NET_BANKING, WALLET. (optional) 

            try
            {
                // Fetch All Downtimes
                FetchActiveEcosystemDowntimes200Response result = cashfree.FetchActiveEcosystemDowntimes(xApiVersion, xRequestId, xIdempotencyKey, incidentId, incidentStatus, incidentImpact, incidentType, incidentStartTime, incidentEndTime, paymentMethod);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DowntimeApi.FetchActiveEcosystemDowntimes: " + e.Message);
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
| **xRequestId** | **string?** | Request ID for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to Cashfree. | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.  | [optional]  |
| **incidentId** | **string?** | Valid incident id for fetching incident details. | [optional]  |
| **incidentStatus** | [**List&lt;string&gt;?**](string.md) | Filter incidents by status. Possible values: ACTIVE, UPCOMING, RESOLVED. | [optional]  |
| **incidentImpact** | [**List&lt;string&gt;?**](string.md) | Filter incidents by impact level. Possible values: HIGH, MEDIUM, LOW. | [optional]  |
| **incidentType** | [**List&lt;string&gt;?**](string.md) | Filter incidents by type. Possible values: SCHEDULED, UNSCHEDULED. | [optional]  |
| **incidentStartTime** | **DateTime?** | Filter incidents by start time. Format: YYYY-MM-DD HH:MM:SS. | [optional]  |
| **incidentEndTime** | **DateTime?** | Filter incidents by end time. Format: YYYY-MM-DD HH:MM:SS. | [optional]  |
| **paymentMethod** | [**List&lt;string&gt;?**](string.md) | Filter incidents by payment method. Possible values: UPI, CARD, NET_BANKING, WALLET. | [optional]  |

### Return type

[**FetchActiveEcosystemDowntimes200Response**](FetchActiveEcosystemDowntimes200Response.md)

### Authorization

[XClientSecret](../README.md#XClientSecret), [XClientID](../README.md#XClientID)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success response for Fetch All Downtimes. |  * X-Api-Version -  <br>  |
| **401** | Authentication Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |
| **500** | API related Error. |  * x-api-version -  <br>  * x-ratelimit-limit -  <br>  * x-ratelimit-remaining -  <br>  * x-ratelimit-retry -  <br>  * x-ratelimit-type -  <br>  * x-request-id -  <br>  * x-idempotency-key -  <br>  * x-idempotency-replayed -  <br>  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


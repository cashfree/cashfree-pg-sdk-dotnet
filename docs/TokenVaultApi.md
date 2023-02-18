# cashfreepg.Api.TokenVaultApi

All URIs are relative to *https://sandbox.cashfree.com/pg*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteSpecificSavedInstrument**](TokenVaultApi.md#deletespecificsavedinstrument) | **DELETE** /customers/{customer_id}/instruments/{instrument_id} | Delete Saved Instrument
[**FetchAllSavedInstruments**](TokenVaultApi.md#fetchallsavedinstruments) | **GET** /customers/{customer_id}/instruments | Fetch All Saved Instruments
[**FetchCryptogram**](TokenVaultApi.md#fetchcryptogram) | **GET** /customers/{customer_id}/instruments/{instrument_id}/cryptogram | Fetch cryptogram for saved instrument
[**FetchSpecificSavedInstrument**](TokenVaultApi.md#fetchspecificsavedinstrument) | **GET** /customers/{customer_id}/instruments/{instrument_id} | Fetch Single Saved Instrument


<a name="deletespecificsavedinstrument"></a>
# **DeleteSpecificSavedInstrument**
> CFFetchAllSavedInstruments DeleteSpecificSavedInstrument (string xClientId, string xClientSecret, string customerId, string instrumentId, string xApiVersion = null)

Delete Saved Instrument

To delete a saved instrument for a customer id and instrument id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfreepg.Api;
using cashfreepg.Client;
using cashfreepg.Model;

namespace Example
{
    public class DeleteSpecificSavedInstrumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sandbox.cashfree.com/pg";
            var apiInstance = new TokenVaultApi(config);
            var xClientId = "xClientId_example";  // string | 
            var xClientSecret = "xClientSecret_example";  // string | 
            var customerId = "customerId_example";  // string | 
            var instrumentId = "instrumentId_example";  // string | 
            var xApiVersion = "\"2022-01-01\"";  // string |  (optional)  (default to "2022-01-01")

            try
            {
                // Delete Saved Instrument
                CFFetchAllSavedInstruments result = apiInstance.DeleteSpecificSavedInstrument(xClientId, xClientSecret, customerId, instrumentId, xApiVersion);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenVaultApi.DeleteSpecificSavedInstrument: " + e.Message );
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
 **customerId** | **string**|  | 
 **instrumentId** | **string**|  | 
 **xApiVersion** | **string**|  | [optional] [default to &quot;2022-01-01&quot;]

### Return type

[**CFFetchAllSavedInstruments**](CFFetchAllSavedInstruments.md)

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

<a name="fetchallsavedinstruments"></a>
# **FetchAllSavedInstruments**
> List&lt;CFFetchAllSavedInstruments&gt; FetchAllSavedInstruments (string xClientId, string xClientSecret, string customerId, string instrumentType, string xApiVersion = null, bool? xIdempotencyReplayed = null, string xIdempotencyKey = null, string xRequestId = null)

Fetch All Saved Instruments

To get all saved instruments for a customer id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfreepg.Api;
using cashfreepg.Client;
using cashfreepg.Model;

namespace Example
{
    public class FetchAllSavedInstrumentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sandbox.cashfree.com/pg";
            var apiInstance = new TokenVaultApi(config);
            var xClientId = "xClientId_example";  // string | 
            var xClientSecret = "xClientSecret_example";  // string | 
            var customerId = "customerId_example";  // string | 
            var instrumentType = "card";  // string | 
            var xApiVersion = "\"2022-01-01\"";  // string |  (optional)  (default to "2022-01-01")
            var xIdempotencyReplayed = false;  // bool? |  (optional)  (default to false)
            var xIdempotencyKey = "xIdempotencyKey_example";  // string |  (optional) 
            var xRequestId = "xRequestId_example";  // string |  (optional) 

            try
            {
                // Fetch All Saved Instruments
                List<CFFetchAllSavedInstruments> result = apiInstance.FetchAllSavedInstruments(xClientId, xClientSecret, customerId, instrumentType, xApiVersion, xIdempotencyReplayed, xIdempotencyKey, xRequestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenVaultApi.FetchAllSavedInstruments: " + e.Message );
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
 **customerId** | **string**|  | 
 **instrumentType** | **string**|  | 
 **xApiVersion** | **string**|  | [optional] [default to &quot;2022-01-01&quot;]
 **xIdempotencyReplayed** | **bool?**|  | [optional] [default to false]
 **xIdempotencyKey** | **string**|  | [optional] 
 **xRequestId** | **string**|  | [optional] 

### Return type

[**List&lt;CFFetchAllSavedInstruments&gt;**](CFFetchAllSavedInstruments.md)

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

<a name="fetchcryptogram"></a>
# **FetchCryptogram**
> CFCryptogram FetchCryptogram (string xClientId, string xClientSecret, string customerId, string instrumentId, string xApiVersion = null, bool? xIdempotencyReplayed = null, string xIdempotencyKey = null, string xRequestId = null)

Fetch cryptogram for saved instrument

To get the card network token, token expiry and cryptogram for a saved instrument using instrument id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfreepg.Api;
using cashfreepg.Client;
using cashfreepg.Model;

namespace Example
{
    public class FetchCryptogramExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sandbox.cashfree.com/pg";
            var apiInstance = new TokenVaultApi(config);
            var xClientId = "xClientId_example";  // string | 
            var xClientSecret = "xClientSecret_example";  // string | 
            var customerId = "customerId_example";  // string | 
            var instrumentId = "instrumentId_example";  // string | 
            var xApiVersion = "\"2022-01-01\"";  // string |  (optional)  (default to "2022-01-01")
            var xIdempotencyReplayed = false;  // bool? |  (optional)  (default to false)
            var xIdempotencyKey = "xIdempotencyKey_example";  // string |  (optional) 
            var xRequestId = "xRequestId_example";  // string |  (optional) 

            try
            {
                // Fetch cryptogram for saved instrument
                CFCryptogram result = apiInstance.FetchCryptogram(xClientId, xClientSecret, customerId, instrumentId, xApiVersion, xIdempotencyReplayed, xIdempotencyKey, xRequestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenVaultApi.FetchCryptogram: " + e.Message );
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
 **customerId** | **string**|  | 
 **instrumentId** | **string**|  | 
 **xApiVersion** | **string**|  | [optional] [default to &quot;2022-01-01&quot;]
 **xIdempotencyReplayed** | **bool?**|  | [optional] [default to false]
 **xIdempotencyKey** | **string**|  | [optional] 
 **xRequestId** | **string**|  | [optional] 

### Return type

[**CFCryptogram**](CFCryptogram.md)

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

<a name="fetchspecificsavedinstrument"></a>
# **FetchSpecificSavedInstrument**
> CFFetchAllSavedInstruments FetchSpecificSavedInstrument (string xClientId, string xClientSecret, string customerId, string instrumentId, string xApiVersion = null, bool? xIdempotencyReplayed = null, string xIdempotencyKey = null, string xRequestId = null)

Fetch Single Saved Instrument

To get specific saved instrument for a customer id and instrument id

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfreepg.Api;
using cashfreepg.Client;
using cashfreepg.Model;

namespace Example
{
    public class FetchSpecificSavedInstrumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://sandbox.cashfree.com/pg";
            var apiInstance = new TokenVaultApi(config);
            var xClientId = "xClientId_example";  // string | 
            var xClientSecret = "xClientSecret_example";  // string | 
            var customerId = "customerId_example";  // string | 
            var instrumentId = "instrumentId_example";  // string | 
            var xApiVersion = "\"2022-01-01\"";  // string |  (optional)  (default to "2022-01-01")
            var xIdempotencyReplayed = false;  // bool? |  (optional)  (default to false)
            var xIdempotencyKey = "xIdempotencyKey_example";  // string |  (optional) 
            var xRequestId = "xRequestId_example";  // string |  (optional) 

            try
            {
                // Fetch Single Saved Instrument
                CFFetchAllSavedInstruments result = apiInstance.FetchSpecificSavedInstrument(xClientId, xClientSecret, customerId, instrumentId, xApiVersion, xIdempotencyReplayed, xIdempotencyKey, xRequestId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenVaultApi.FetchSpecificSavedInstrument: " + e.Message );
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
 **customerId** | **string**|  | 
 **instrumentId** | **string**|  | 
 **xApiVersion** | **string**|  | [optional] [default to &quot;2022-01-01&quot;]
 **xIdempotencyReplayed** | **bool?**|  | [optional] [default to false]
 **xIdempotencyKey** | **string**|  | [optional] 
 **xRequestId** | **string**|  | [optional] 

### Return type

[**CFFetchAllSavedInstruments**](CFFetchAllSavedInstruments.md)

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


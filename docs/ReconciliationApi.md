# cashfree_pg.Api.ReconciliationApi

All URIs are relative to *https://sandbox.cashfree.com/pg*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PGESReconVendor**](ReconciliationApi.md#pgesreconvendor) | **POST** /recon/vendor | Vendor Reconciliation API |

<a id="pgesreconvendor"></a>
# **PGESReconVendor**
> VendorRecon200Response PGESReconVendor (string xApiVersion, VendorReconRequest vendorReconRequest, string? xRequestId = null, Guid? xIdempotencyKey = null, string? contentType = null)

Vendor Reconciliation API

This API allows you to fetch vendor reconciliation details by using different filters. Use the appropriate filters based on your requirements. After you receive a VENDOR_SETTLEMENT_SUCCESS webhook confirmation, wait 15 minutes before you call this API endpoint.  - **View Split Order Details Using Settlement ID**: Retrieve details of split orders within a settlement by Settlement ID.  - **Vendor Recon for a Time Period**: Fetch reconciliation details for all vendors within a specific time interval.  - **Vendor Recon Using Vendor ID & Time Interval**: Get reconciliation details for a specific vendor within a given time interval. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGESReconVendorExample
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
            var vendorReconRequest = new VendorReconRequest(); // VendorReconRequest | Vendor Recon Request body.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request ID for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to Cashfree. (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.  (optional) 
            var contentType = application/json;  // string? | application/json. (optional) 

            try
            {
                // Vendor Reconciliation API
                VendorRecon200Response result = cashfree.PGESReconVendor(xApiVersion, vendorReconRequest, xRequestId, xIdempotencyKey, contentType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReconciliationApi.PGESReconVendor: " + e.Message);
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
| **vendorReconRequest** | [**VendorReconRequest**](VendorReconRequest.md) | Vendor Recon Request body. |  |
| **xRequestId** | **string?** | Request ID for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to Cashfree. | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.  | [optional]  |
| **contentType** | **string?** | application/json. | [optional]  |

### Return type

[**VendorRecon200Response**](VendorRecon200Response.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Terminal created. |  -  |
| **400** | Vendor Recon Failure Response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


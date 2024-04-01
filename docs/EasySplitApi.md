# cashfree_pg.Api.EasySplitApi

All URIs are relative to *https://sandbox.cashfree.com/pg*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PGESCreateOnDemandTransfer**](EasySplitApi.md#pgescreateondemandtransfer) | **POST** /easy-split/vendors/{vendor_id}/transfer | Create On Demand Transfer |
| [**PGESCreateVendors**](EasySplitApi.md#pgescreatevendors) | **POST** /easy-split/vendors | Create vendor |
| [**PGESDownloadVendorsDocs**](EasySplitApi.md#pgesdownloadvendorsdocs) | **GET** /easy-split/vendor-docs/{vendor_id}/download/{doc_type} | Download Vendor Documents |
| [**PGESFetchVendors**](EasySplitApi.md#pgesfetchvendors) | **GET** /easy-split/vendors/{vendor_id} | Get Vendor All Details |
| [**PGESGetVendorBalance**](EasySplitApi.md#pgesgetvendorbalance) | **GET** /easy-split/vendors/{vendor_id}/balances | Get On Demand Balance |
| [**PGESGetVendorBalanceTransferCharges**](EasySplitApi.md#pgesgetvendorbalancetransfercharges) | **GET** /easy-split/amount/{amount}/charges | Get Vendor Balance Transfer Charges |
| [**PGESGetVendorsDocs**](EasySplitApi.md#pgesgetvendorsdocs) | **GET** /easy-split/vendor-docs/{vendor_id} | Get Vendor All Documents Status |
| [**PGESOrderRecon**](EasySplitApi.md#pgesorderrecon) | **POST** /split/order/vendor/recon | Get Split and Settlement Details by OrderID v2.0 |
| [**PGESUpdateVendors**](EasySplitApi.md#pgesupdatevendors) | **PATCH** /easy-split/vendors/{vendor_id} | Update vendor Details |
| [**PGESUploadVendorsDocs**](EasySplitApi.md#pgesuploadvendorsdocs) | **POST** /easy-split/vendor-docs/{vendor_id} | Upload Vendor Docs |
| [**PGOrderSplitAfterPayment**](EasySplitApi.md#pgordersplitafterpayment) | **POST** /easy-split/orders/{order_id}/split | Split After Payment |
| [**PGOrderStaticSplit**](EasySplitApi.md#pgorderstaticsplit) | **POST** /easy-split/static-split | Create Static Split Configuration |

<a id="pgescreateondemandtransfer"></a>
# **PGESCreateOnDemandTransfer**
> AdjustVendorBalanceResponse PGESCreateOnDemandTransfer (string xApiVersion, string vendorId, string? xRequestId = null, Guid? xIdempotencyKey = null, AdjustVendorBalanceRequest? adjustVendorBalanceRequest = null)

Create On Demand Transfer

The Create On Demand Transfer API will create a new on-demand request either from to the merchant or from to the vendor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGESCreateOnDemandTransferExample
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
            var vendorId = your-vendor-id;  // string | The id which uniquely identifies your vendor.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 
            var adjustVendorBalanceRequest = new AdjustVendorBalanceRequest?(); // AdjustVendorBalanceRequest? | Adjust Vendor Balance Request Body. (optional) 

            try
            {
                // Create On Demand Transfer
                AdjustVendorBalanceResponse result = cashfree.PGESCreateOnDemandTransfer(xApiVersion, vendorId, xRequestId, xIdempotencyKey, adjustVendorBalanceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EasySplitApi.PGESCreateOnDemandTransfer: " + e.Message);
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
| **vendorId** | **string** | The id which uniquely identifies your vendor. |  |
| **xRequestId** | **string?** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   | [optional]  |
| **adjustVendorBalanceRequest** | [**AdjustVendorBalanceRequest?**](AdjustVendorBalanceRequest?.md) | Adjust Vendor Balance Request Body. | [optional]  |

### Return type

[**AdjustVendorBalanceResponse**](AdjustVendorBalanceResponse.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Adjust Vendor Balance Success Response. |  -  |
| **400** | Adjust Vendor Balance Failure Response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pgescreatevendors"></a>
# **PGESCreateVendors**
> CreateVendorResponse PGESCreateVendors (string xApiVersion, string? xRequestId = null, Guid? xIdempotencyKey = null, CreateVendorRequest? createVendorRequest = null)

Create vendor

Use this API to create a new vendor to your EasySplit account along with the KYC details. Provide KYC details such as account_type, business_type, gst, cin, pan, passport number and so on.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGESCreateVendorsExample
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
            var createVendorRequest = new CreateVendorRequest?(); // CreateVendorRequest? | Create Vendor Request Body. (optional) 

            try
            {
                // Create vendor
                CreateVendorResponse result = cashfree.PGESCreateVendors(xApiVersion, xRequestId, xIdempotencyKey, createVendorRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EasySplitApi.PGESCreateVendors: " + e.Message);
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
| **createVendorRequest** | [**CreateVendorRequest?**](CreateVendorRequest?.md) | Create Vendor Request Body. | [optional]  |

### Return type

[**CreateVendorResponse**](CreateVendorResponse.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Create Vendor Success Response. |  -  |
| **400** | Create Vendor Failure Response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pgesdownloadvendorsdocs"></a>
# **PGESDownloadVendorsDocs**
> VendorDocumentDownloadResponse PGESDownloadVendorsDocs (string xApiVersion, string docType, string vendorId, string? xRequestId = null, Guid? xIdempotencyKey = null)

Download Vendor Documents

Use this API to download the uploaded KYC documents of that particular vendor. Provide the document type. Click the link from the sample request to download the KYC document.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGESDownloadVendorsDocsExample
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
            var docType = "docType_example";  // string | Mention the document type that has to be downloaded. Only an uploaded document can be downloaded.
            var vendorId = your-vendor-id;  // string | The id which uniquely identifies your vendor.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Download Vendor Documents
                VendorDocumentDownloadResponse result = cashfree.PGESDownloadVendorsDocs(xApiVersion, docType, vendorId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EasySplitApi.PGESDownloadVendorsDocs: " + e.Message);
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
| **docType** | **string** | Mention the document type that has to be downloaded. Only an uploaded document can be downloaded. |  |
| **vendorId** | **string** | The id which uniquely identifies your vendor. |  |
| **xRequestId** | **string?** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   | [optional]  |

### Return type

[**VendorDocumentDownloadResponse**](VendorDocumentDownloadResponse.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Download Vendor Docs Success Response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pgesfetchvendors"></a>
# **PGESFetchVendors**
> VendorEntity PGESFetchVendors (string xApiVersion, string vendorId, string? xRequestId = null, Guid? xIdempotencyKey = null)

Get Vendor All Details

Use this API to get the details of a specific vendor associated with your Easy Split account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGESFetchVendorsExample
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
            var vendorId = your-vendor-id;  // string | The id which uniquely identifies your vendor.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Get Vendor All Details
                VendorEntity result = cashfree.PGESFetchVendors(xApiVersion, vendorId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EasySplitApi.PGESFetchVendors: " + e.Message);
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
| **vendorId** | **string** | The id which uniquely identifies your vendor. |  |
| **xRequestId** | **string?** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   | [optional]  |

### Return type

[**VendorEntity**](VendorEntity.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get Vendor Success Response. |  -  |
| **400** | Get Vendor Docs Failure Response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pgesgetvendorbalance"></a>
# **PGESGetVendorBalance**
> VendorBalance PGESGetVendorBalance (string xApiVersion, string vendorId, string? xRequestId = null, Guid? xIdempotencyKey = null)

Get On Demand Balance

This API fetches the available amount with the merchant, vendor, and the unsettled amount for the merchant as well as the vendor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGESGetVendorBalanceExample
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
            var vendorId = your-vendor-id;  // string | The id which uniquely identifies your vendor.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Get On Demand Balance
                VendorBalance result = cashfree.PGESGetVendorBalance(xApiVersion, vendorId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EasySplitApi.PGESGetVendorBalance: " + e.Message);
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
| **vendorId** | **string** | The id which uniquely identifies your vendor. |  |
| **xRequestId** | **string?** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   | [optional]  |

### Return type

[**VendorBalance**](VendorBalance.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get Vendor Balance Success Response. |  -  |
| **400** | Get Vendor Docs Failure Response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pgesgetvendorbalancetransfercharges"></a>
# **PGESGetVendorBalanceTransferCharges**
> VendorBalanceTransferCharges PGESGetVendorBalanceTransferCharges (string xApiVersion, decimal amount, string rateType, string? xRequestId = null, Guid? xIdempotencyKey = null)

Get Vendor Balance Transfer Charges

This API returns the applicable service charge and service tax for a vendor balance transfer, based on the provided amount and rate type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGESGetVendorBalanceTransferChargesExample
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
            var amount = 1000;  // decimal | Specify the amount for which you want to view the service charges and service taxes in the response.
            var rateType = VENDOR_ON_DEMAND;  // string | Mention the type of rate for which you want to check the charges. Possible value: VENDOR_ON_DEMAND
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Get Vendor Balance Transfer Charges
                VendorBalanceTransferCharges result = cashfree.PGESGetVendorBalanceTransferCharges(xApiVersion, amount, rateType, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EasySplitApi.PGESGetVendorBalanceTransferCharges: " + e.Message);
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
| **amount** | **decimal** | Specify the amount for which you want to view the service charges and service taxes in the response. |  |
| **rateType** | **string** | Mention the type of rate for which you want to check the charges. Possible value: VENDOR_ON_DEMAND |  |
| **xRequestId** | **string?** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   | [optional]  |

### Return type

[**VendorBalanceTransferCharges**](VendorBalanceTransferCharges.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get Vendor Balance Transfer Charges Response. |  -  |
| **400** | Get Vendor Balance Transfer Charges Failure Response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pgesgetvendorsdocs"></a>
# **PGESGetVendorsDocs**
> VendorDocumentsResponse PGESGetVendorsDocs (string xApiVersion, string vendorId, string? xRequestId = null, Guid? xIdempotencyKey = null)

Get Vendor All Documents Status

Use this API to fetch the details of all the KYC details of a particular vendor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGESGetVendorsDocsExample
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
            var vendorId = your-vendor-id;  // string | The id which uniquely identifies your vendor.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Get Vendor All Documents Status
                VendorDocumentsResponse result = cashfree.PGESGetVendorsDocs(xApiVersion, vendorId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EasySplitApi.PGESGetVendorsDocs: " + e.Message);
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
| **vendorId** | **string** | The id which uniquely identifies your vendor. |  |
| **xRequestId** | **string?** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   | [optional]  |

### Return type

[**VendorDocumentsResponse**](VendorDocumentsResponse.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Get Vendor Docs Success Response. |  -  |
| **400** | Get Vendor Docs Failure Response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pgesorderrecon"></a>
# **PGESOrderRecon**
> ESOrderReconResponse PGESOrderRecon (string xApiVersion, string? xRequestId = null, Guid? xIdempotencyKey = null, ESOrderReconRequest? eSOrderReconRequest = null)

Get Split and Settlement Details by OrderID v2.0

Use this API to get all the split details, settled and unsettled transactions details of each vendor who were part of a particular order by providing order Id or start date and end date.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGESOrderReconExample
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
            var eSOrderReconRequest = new ESOrderReconRequest?(); // ESOrderReconRequest? | Get Split and Settlement Details by OrderID v2.0 (optional) 

            try
            {
                // Get Split and Settlement Details by OrderID v2.0
                ESOrderReconResponse result = cashfree.PGESOrderRecon(xApiVersion, xRequestId, xIdempotencyKey, eSOrderReconRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EasySplitApi.PGESOrderRecon: " + e.Message);
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
| **eSOrderReconRequest** | [**ESOrderReconRequest?**](ESOrderReconRequest?.md) | Get Split and Settlement Details by OrderID v2.0 | [optional]  |

### Return type

[**ESOrderReconResponse**](ESOrderReconResponse.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | ES Order Recon Success Response. |  -  |
| **400** | ES Order Recon Failure Response. |  -  |
| **404** | ES Order Recon Failure Response. |  -  |
| **409** | ES Order Recon Failure Response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pgesupdatevendors"></a>
# **PGESUpdateVendors**
> UpdateVendorResponse PGESUpdateVendors (string xApiVersion, string vendorId, string? xRequestId = null, Guid? xIdempotencyKey = null, UpdateVendorRequest? updateVendorRequest = null)

Update vendor Details

Use this API to edit the existing vendor details added to your EasySplit account. You can edit vendor details such as name, email, phone number, upi details, and any of the KYC details.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGESUpdateVendorsExample
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
            var vendorId = your-vendor-id;  // string | The id which uniquely identifies your vendor.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 
            var updateVendorRequest = new UpdateVendorRequest?(); // UpdateVendorRequest? | Create Vendor Request Body. (optional) 

            try
            {
                // Update vendor Details
                UpdateVendorResponse result = cashfree.PGESUpdateVendors(xApiVersion, vendorId, xRequestId, xIdempotencyKey, updateVendorRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EasySplitApi.PGESUpdateVendors: " + e.Message);
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
| **vendorId** | **string** | The id which uniquely identifies your vendor. |  |
| **xRequestId** | **string?** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   | [optional]  |
| **updateVendorRequest** | [**UpdateVendorRequest?**](UpdateVendorRequest?.md) | Create Vendor Request Body. | [optional]  |

### Return type

[**UpdateVendorResponse**](UpdateVendorResponse.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update Vendor Success Response. |  -  |
| **400** | Update Vendor Failure Response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pgesuploadvendorsdocs"></a>
# **PGESUploadVendorsDocs**
> UploadVendorDocumentsResponse PGESUploadVendorsDocs (string xApiVersion, string vendorId, string? xRequestId = null, Guid? xIdempotencyKey = null, string? docType = null, string? docValue = null, System.IO.Stream? file = null)

Upload Vendor Docs

Use this API to upload KYC documents of a specific vendor.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGESUploadVendorsDocsExample
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
            var vendorId = your-vendor-id;  // string | The id which uniquely identifies your vendor.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 
            var docType = "docType_example";  // string? | Mention the type of the document you are uploading. Possible values: UIDAI_FRONT, UIDAI_BACK, UIDAI_NUMBER, DL, DL_NUMBER, PASSPORT_FRONT, PASSPORT_BACK, PASSPORT_NUMBER, VOTER_ID, VOTER_ID_NUMBER, PAN, PAN_NUMBER, GST, GSTIN_NUMBER, CIN, CIN_NUMBER, NBFC_CERTIFICATE. If the doc type ends with a number you should add the doc value else upload the doc file. (optional) 
            var docValue = "docValue_example";  // string? | Enter the display name of the uploaded file. (optional) 
            var file = new System.IO.MemoryStream(System.IO.File.ReadAllBytes("/path/to/file.txt"));  // System.IO.Stream? | Select the document that should be uploaded or provide the path of that file. You cannot upload a file that is more than 2MB in size. (optional) 

            try
            {
                // Upload Vendor Docs
                UploadVendorDocumentsResponse result = cashfree.PGESUploadVendorsDocs(xApiVersion, vendorId, xRequestId, xIdempotencyKey, docType, docValue, file);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EasySplitApi.PGESUploadVendorsDocs: " + e.Message);
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
| **vendorId** | **string** | The id which uniquely identifies your vendor. |  |
| **xRequestId** | **string?** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   | [optional]  |
| **docType** | **string?** | Mention the type of the document you are uploading. Possible values: UIDAI_FRONT, UIDAI_BACK, UIDAI_NUMBER, DL, DL_NUMBER, PASSPORT_FRONT, PASSPORT_BACK, PASSPORT_NUMBER, VOTER_ID, VOTER_ID_NUMBER, PAN, PAN_NUMBER, GST, GSTIN_NUMBER, CIN, CIN_NUMBER, NBFC_CERTIFICATE. If the doc type ends with a number you should add the doc value else upload the doc file. | [optional]  |
| **docValue** | **string?** | Enter the display name of the uploaded file. | [optional]  |
| **file** | **System.IO.Stream?****System.IO.Stream?** | Select the document that should be uploaded or provide the path of that file. You cannot upload a file that is more than 2MB in size. | [optional]  |

### Return type

[**UploadVendorDocumentsResponse**](UploadVendorDocumentsResponse.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Upload Vendor Docs Success Response. |  -  |
| **400** | Upload Vendor Docs Failure Response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pgordersplitafterpayment"></a>
# **PGOrderSplitAfterPayment**
> SplitAfterPaymentResponse PGOrderSplitAfterPayment (string xApiVersion, string orderId, string? xRequestId = null, Guid? xIdempotencyKey = null, SplitAfterPaymentRequest? splitAfterPaymentRequest = null)

Split After Payment

Split After Payment API splits the payments to vendors after successful payment from the customers.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGOrderSplitAfterPaymentExample
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
            var orderId = your-order-id;  // string | The id which uniquely identifies your order
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 
            var splitAfterPaymentRequest = new SplitAfterPaymentRequest?(); // SplitAfterPaymentRequest? | Request Body to Create Split for an order. (optional) 

            try
            {
                // Split After Payment
                SplitAfterPaymentResponse result = cashfree.PGOrderSplitAfterPayment(xApiVersion, orderId, xRequestId, xIdempotencyKey, splitAfterPaymentRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EasySplitApi.PGOrderSplitAfterPayment: " + e.Message);
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
| **orderId** | **string** | The id which uniquely identifies your order |  |
| **xRequestId** | **string?** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree | [optional]  |
| **xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   | [optional]  |
| **splitAfterPaymentRequest** | [**SplitAfterPaymentRequest?**](SplitAfterPaymentRequest?.md) | Request Body to Create Split for an order. | [optional]  |

### Return type

[**SplitAfterPaymentResponse**](SplitAfterPaymentResponse.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Split After Payment Success Response. |  -  |
| **400** | Split After Payment Failure Response. |  -  |
| **404** | Split After Payment Failure Response. |  -  |
| **409** | Split After Payment Failure Response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="pgorderstaticsplit"></a>
# **PGOrderStaticSplit**
> StaticSplitResponse PGOrderStaticSplit (string xApiVersion, string? xRequestId = null, Guid? xIdempotencyKey = null, StaticSplitRequest? staticSplitRequest = null)

Create Static Split Configuration

This API will create a static split scheme wherein you can define the split type and the vendor-wise split percentage.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGOrderStaticSplitExample
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
            var staticSplitRequest = new StaticSplitRequest?(); // StaticSplitRequest? | Static Split (optional) 

            try
            {
                // Create Static Split Configuration
                StaticSplitResponse result = cashfree.PGOrderStaticSplit(xApiVersion, xRequestId, xIdempotencyKey, staticSplitRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EasySplitApi.PGOrderStaticSplit: " + e.Message);
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
| **staticSplitRequest** | [**StaticSplitRequest?**](StaticSplitRequest?.md) | Static Split | [optional]  |

### Return type

[**StaticSplitResponse**](StaticSplitResponse.md)

### Authorization

[XPartnerAPIKey](../README.md#XPartnerAPIKey), [XClientSecret](../README.md#XClientSecret), [XPartnerMerchantID](../README.md#XPartnerMerchantID), [XClientID](../README.md#XClientID), [XClientSignatureHeader](../README.md#XClientSignatureHeader)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Static Split Success Response. |  -  |
| **400** | Static Split Failure Response. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


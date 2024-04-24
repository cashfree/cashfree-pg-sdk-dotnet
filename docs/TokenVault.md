# TokenVault

Method | HTTP request | Description
------------- | ------------- | -------------
[**PGCustomerDeleteInstrument**](TokenVault.md#PGCustomerDeleteInstrument) | **Delete** /customers/{customer_id}/instruments/{instrument_id} | Delete Saved Card Instrument
[**PGCustomerFetchInstrument**](TokenVault.md#PGCustomerFetchInstrument) | **Get** /customers/{customer_id}/instruments/{instrument_id} | Fetch Specific Saved Card Instrument
[**PGCustomerFetchInstruments**](TokenVault.md#PGCustomerFetchInstruments) | **Get** /customers/{customer_id}/instruments | Fetch All Saved Card Instrument
[**PGCustomerInstrumentsFetchCryptogram**](TokenVault.md#PGCustomerInstrumentsFetchCryptogram) | **Get** /customers/{customer_id}/instruments/{instrument_id}/cryptogram | Fetch cryptogram for a saved card instrument



## PGCustomerDeleteInstrument

> PGCustomerDeleteInstrument(x_api_version: string, customer_id: string, instrument_id: string, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<InstrumentEntity, any>>

Delete Saved Card Instrument ([Docs](https://docs.cashfree.com/reference/pgcustomerdeleteinstrument))

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGCustomerDeleteInstrumentExample
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
            var customerId = siddhesh_desai;  // string | Your Customer ID that you had sent during create order API `POST/orders`
            var instrumentId = 54deabb4-ba45-4a60-9e6a-9c016fe7ab10;  // string | The instrument_id which needs to be deleted
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Delete Saved Card Instrument
                InstrumentEntity result = cashfree.PGCustomerDeleteInstrument(xApiVersion, customerId, instrumentId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenVaultApi.PGCustomerDeleteInstrument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**customerId** | **string*** | Your Customer ID that you had sent during create order API &#x60;POST/orders&#x60; |
**instrumentId** | **string*** | The instrument_id which needs to be deleted |
**xApiVersion** | **string*** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2022-09-01&quot;]
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |


### Response

```json
{
  "customer_id": "siddhesh_desai",
  "afa_reference": "740324562",
  "instrument_id": "54deabb4-ba45-4a60-9e6a-9c016fe7ab10",
  "instrument_type": "card",
  "instrument_uid": "0d8f70838cc5af8b1cd2bc0fe71278551fd3f1101e40020d89ad22ceba4f933c",
  "instrument_display": "xxxxxxxxxxxx4375",
  "instrument_status": "ACTIVE",
  "created_at": "2021-11-11 16:57:57",
  "instrument_meta": {
    "card_network": "VISA",
    "card_bank_name": "HDFC Bank Limited",
    "card_country": "IN",
    "card_type": "DEBIT_CARD",
    "card_token_details": {
      "par": "somepar",
      "expiry_month": "12",
      "expiry_year": "23"
    }
  }
}
```

## PGCustomerFetchInstrument

> PGCustomerFetchInstrument(x_api_version: string, customer_id: string, instrument_id: string, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<InstrumentEntity, any>>

Fetch Specific Saved Card Instrument ([Docs](https://docs.cashfree.com/reference/pgcustomerfetchinstrument))



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGCustomerFetchInstrumentExample
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
            var customerId = siddhesh_desai;  // string | Your Customer ID that you had sent during create order API `POST/orders`
            var instrumentId = 54deabb4-ba45-4a60-9e6a-9c016fe7ab10;  // string | The instrument_id of the saved instrument which needs to be queried
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Fetch Specific Saved Card Instrument
                InstrumentEntity result = cashfree.PGCustomerFetchInstrument(xApiVersion, customerId, instrumentId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenVaultApi.PGCustomerFetchInstrument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**customerId** | **string** | Your Customer ID that you had sent during create order API &#x60;POST/orders&#x60; |
**instrumentId** | **string** | The instrument_id of the saved instrument which needs to be queried |
**xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2022-09-01&quot;]
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |


### Response
```json
{
  "customer_id": "siddhesh_desai",
  "afa_reference": "740324562",
  "instrument_id": "54deabb4-ba45-4a60-9e6a-9c016fe7ab10",
  "instrument_type": "card",
  "instrument_uid": "0d8f70838cc5af8b1cd2bc0fe71278551fd3f1101e40020d89ad22ceba4f933c",
  "instrument_display": "xxxxxxxxxxxx4375",
  "instrument_status": "ACTIVE",
  "created_at": "2021-11-11 16:57:57",
  "instrument_meta": {
    "card_network": "VISA",
    "card_bank_name": "HDFC Bank Limited",
    "card_country": "IN",
    "card_type": "DEBIT_CARD",
    "card_token_details": {
      "par": "somepar",
      "expiry_month": "12",
      "expiry_year": "23"
    }
  }
}
```

## PGCustomerFetchInstruments

> PGCustomerFetchInstruments(x_api_version: string, customer_id: string, instrument_type: PGCustomerFetchInstrumentsInstrumentTypeEnum, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<InstrumentEntity[], any>>

Fetch All Saved Card Instrument ([Docs](https://docs.cashfree.com/reference/pgcustomerfetchinstruments))

### Example

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGCustomerFetchInstrumentsExample
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
            var customerId = siddhesh_desai;  // string | Your Customer ID that you had sent during create order API `POST/orders`
            var instrumentType = card;  // string | Payment mode or type of saved instrument 
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Fetch All Saved Card Instrument
                List<InstrumentEntity> result = cashfree.PGCustomerFetchInstruments(xApiVersion, customerId, instrumentType, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenVaultApi.PGCustomerFetchInstruments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**customerId** | **string*** | Your Customer ID that you had sent during create order API &#x60;POST/orders&#x60; |
**xApiVersion** | **string*** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2022-09-01&quot;]
**instrumentType** | **string*** | Payment mode or type of saved instrument  |
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |


### Response
```json
[
  {
  "customer_id": "siddhesh_desai",
  "afa_reference": "740324562",
  "instrument_id": "54deabb4-ba45-4a60-9e6a-9c016fe7ab10",
  "instrument_type": "card",
  "instrument_uid": "0d8f70838cc5af8b1cd2bc0fe71278551fd3f1101e40020d89ad22ceba4f933c",
  "instrument_display": "xxxxxxxxxxxx4375",
  "instrument_status": "ACTIVE",
  "created_at": "2021-11-11 16:57:57",
  "instrument_meta": {
    "card_network": "VISA",
    "card_bank_name": "HDFC Bank Limited",
    "card_country": "IN",
    "card_type": "DEBIT_CARD",
    "card_token_details": {
      "par": "somepar",
      "expiry_month": "12",
      "expiry_year": "23"
    }
  }
}
]
```


## PGCustomerInstrumentsFetchCryptogram

> PGCustomerInstrumentsFetchCryptogram(x_api_version: string, customer_id: string, instrument_id: string, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<CryptogramEntity, any>>

Fetch cryptogram for a saved card instrument ([Docs](https://docs.cashfree.com/reference/pgcustomerinstrumentsfetchcryptogram))



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGCustomerInstrumentsFetchCryptogramExample
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
            var customerId = siddhesh_desai;  // string | Your Customer ID that you had sent during create order API `POST/orders`
            var instrumentId = 54deabb4-ba45-4a60-9e6a-9c016fe7ab10;  // string | The instrument_id of the saved card instrument which needs to be queried
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Fetch cryptogram for a saved card instrument
                CryptogramEntity result = cashfree.PGCustomerInstrumentsFetchCryptogram(xApiVersion, customerId, instrumentId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TokenVaultApi.PGCustomerInstrumentsFetchCryptogram: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**customerId** | **string*** | Your Customer ID that you had sent during create order API &#x60;POST/orders&#x60; |
**instrumentId** | **string*** | The instrument_id of the saved card instrument which needs to be queried |
**xApiVersion** | **string*** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2022-09-01&quot;]
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |


### Response

```json
{
  "instrument_id": "54deabb4-ba45-4a60-9e6a-9c016fe7ab10",
  "token_requestor_id": "22457512314",
  "card_number": "4491365621601472",
  "card_expiry_mm": "06",
  "card_expiry_yy": "2025",
  "cryptogram": "AQBBBBBBZatIlaIAmWKSghwBBBB=",
  "card_display": "1234"
}
```

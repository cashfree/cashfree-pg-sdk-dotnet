# Offers

Method | HTTP request | Description
------------- | ------------- | -------------
[**PGCreateOffer**](Offers.md#PGCreateOffer) | **Post** /offers | Create Offer
[**PGFetchOffer**](Offers.md#PGFetchOffer) | **Get** /offers/{offer_id} | Get Offer by ID



## PGCreateOffer

> PGCreateOffer(x_api_version: string, CreateOfferRequest: CreateOfferRequest, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<OfferEntity, any>>

Create Offer ([Docs](https://docs.cashfree.com/reference/pgcreateoffer))


### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGCreateOfferExample
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
            var createOfferRequest = new CreateOfferRequest
            {
             offer_meta = new OfferMeta
            {
                offer_title = "Test Offer",
                offer_description = "Offer Description",
                offer_code = "CFTESTOFFER",
                offer_start_time = DateTime.Parse("2023-03-21T08:09:51Z"),
                offer_end_time = DateTime.Parse("2024-03-21T08:09:51Z")
            },
            offer_tnc = new OfferTnc
            {
                offer_tnc_type = "text",
                offer_tnc_value = "Terms and Condition of the Offer"
            },
            offer_details = new OfferDetails
            {
                offer_type = "DISCOUNT_AND_CASHBACK",
                discount_details = new DiscountDetails
                {
                    discount_type = "flat",
                    discount_value = "10",
                    max_discount_amount = "10"
                },
                cashback_details = new CashbackDetails
                {
                    cashback_type = "percentage",
                    cashback_value = "10",
                    max_cashback_amount = "10"
                }
            },
            offer_validations = new OfferValidations
            {
                payment_method = new PaymentMethod
                {
                    card = new Card
                    {
                        type = new string[] { "cc" },
                        bank_name = "hdfc bank",
                        scheme_name = new string[] { "visa" }
                    }
                },
                min_amount = 15,
                max_allowed = 100
            }
           }; // CreateOfferRequest | Request body to create an offer at Cashfree
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Create Offer
                OfferEntity result = cashfree.PGCreateOffer(xApiVersion, createOfferRequest, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OffersApi.PGCreateOffer: " + e.Message);
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
**xApiVersion** | **string*** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2022-09-01&quot;]
**createOfferRequest** | **CreateOfferRequest*** | Request body to create an offer at Cashfree |
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree | [optional]
**xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   | [optional] 


### Response
```json
{
  "offer_id": "d2b430fb-1afe-455a-af31-66d00377b29a",
  "offer_status": "active",
  "offer_meta": {
    "offer_title": "some title",
    "offer_description": "some offer description",
    "offer_code": "CFTESTOFFER",
    "offer_start_time": "2023-03-21T08:09:51Z",
    "offer_end_time": "2023-03-29T08:09:51Z"
  },
  "offer_tnc": {
    "offer_tnc_type": "text",
    "offer_tnc_value": "TnC for the Offer."
  },
  "offer_details": {
    "offer_type": "DISCOUNT_AND_CASHBACK",
    "discount_details": {
      "discount_type": "flat",
      "discount_value": "10",
      "max_discount_amount": "10"
    },
    "cashback_details": {
      "cashback_type": "percentage",
      "cashback_value": "20",
      "max_cashback_amount": "150"
    }
  },
  "offer_validations": {
    "min_amount": 10,
    "payment_method": {
      "wallet": {
        "issuer": "paytm"
      }
    },
    "max_allowed": 2
  }
}
```


## PGFetchOffer

> PGFetchOffer(x_api_version: string, offer_id: string, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<OfferEntity, any>>

Get Offer by ID ([Docs](https://docs.cashfree.com/reference/pgfetchoffer))



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGFetchOfferExample
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
            var offerId = d2b430fb-1afe-455a-af31-66d00377b29a;  // string | The offer ID for which you want to view the offer details.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Get Offer by ID
                OfferEntity result = cashfree.PGFetchOffer(xApiVersion, offerId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OffersApi.PGFetchOffer: " + e.Message);
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
**offerId** | **string** | The offer ID for which you want to view the offer details. |
**xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2022-09-01&quot;]
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree | [optional] 
**xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   | [optional]  |


### Response
```json
{
  "offer_id": "d2b430fb-1afe-455a-af31-66d00377b29a",
  "offer_status": "active",
  "offer_meta": {
    "offer_title": "some title",
    "offer_description": "some offer description",
    "offer_code": "CFTESTOFFER",
    "offer_start_time": "2023-03-21T08:09:51Z",
    "offer_end_time": "2023-03-29T08:09:51Z"
  },
  "offer_tnc": {
    "offer_tnc_type": "text",
    "offer_tnc_value": "TnC for the Offer."
  },
  "offer_details": {
    "offer_type": "DISCOUNT_AND_CASHBACK",
    "discount_details": {
      "discount_type": "flat",
      "discount_value": "10",
      "max_discount_amount": "10"
    },
    "cashback_details": {
      "cashback_type": "percentage",
      "cashback_value": "20",
      "max_cashback_amount": "150"
    }
  },
  "offer_validations": {
    "min_amount": 10,
    "payment_method": {
      "wallet": {
        "issuer": "paytm"
      }
    },
    "max_allowed": 2
  }
}
```
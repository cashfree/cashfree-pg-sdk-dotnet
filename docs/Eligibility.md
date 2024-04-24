# Eligibility

Method | HTTP request | Description
------------- | ------------- | -------------
[**PGEligibilityFetchCardlessEMI**](Eligibility.md#PGEligibilityFetchCardlessEMI) | **Post** /eligibility/cardlessemi | Get Eligible Cardless EMI
[**PGEligibilityFetchOffers**](Eligibility.md#PGEligibilityFetchOffers) | **Post** /eligibility/offers | Get Eligible Offers
[**PGEligibilityFetchPaylater**](Eligibility.md#PGEligibilityFetchPaylater) | **Post** /eligibility/paylater | Get Eligible Paylater
[**PGEligibilityFetchPaymentMethods**](Eligibility.md#PGEligibilityFetchPaymentMethods) | **Post** /eligibility/payment_methods | Get Eligible Payment Methods



## PGEligibilityFetchCardlessEMI

> PGEligibilityFetchCardlessEMI(x_api_version: string, EligibilityFetchCardlessEMIRequest: EligibilityFetchCardlessEMIRequest, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<EligibilityCardlessEMIEntity[], any>>

Get Eligible Cardless EMI ([Docs](https://docs.cashfree.com/reference/pgeligibilityfetchcardlessemi))

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGEligibilityFetchCardlessEMIExample
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
            var eligibilityFetchCardlessEMIRequest = new EligibilityFetchCardlessEMIRequest{
             queries = {
                        amount = 10000,
                        customer_details= {
                         customer_phone = "7330797796"
                        }
             }  
            }; // EligibilityFetchCardlessEMIRequest | Request Body to get eligible cardless emi options for a customer and order
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Get Eligible Cardless EMI Payment Methods for a customer on an order
                List<EligibilityCardlessEMIEntity> response = cashfree.PGEligibilityFetchCardlessEMI(xApiVersion, eligibilityFetchCardlessEMIRequest, xRequestId, xIdempotencyKey);
                Debug.WriteLine(response);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EligibilityApi.PGEligibilityFetchCardlessEMI: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

###  Parameters
Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**xApiVersion** | **string*** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2022-09-01&quot;]
**eligibilityFetchCardlessEMIRequest** | [**EligibilityFetchCardlessEMIRequest***](Eligibility.md#EligibilityFetchCardlessEMIRequest) | Request Body to get eligible cardless emi options for a customer and order |
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |

### Response

```json
[
  {
    "eligibility": true,
    "entity_type": "cardlessemi",
    "entity_value": "idfc",
    "entity_details": {
      "payment_method": "idfc",
      "emi_plans": [
        {
          "tenure": 1,
          "interest_rate": 10,
          "currency": "INR",
          "emi": 400,
          "total_interest": 10,
          "total_amount": 40
        }
      ]
    }
  }
]
```

## PGEligibilityFetchOffers

> PGEligibilityFetchOffers(x_api_version: string, EligibilityFetchOffersRequest: EligibilityFetchOffersRequest, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<EligibilityOfferEntity[], any>>

Get Eligible Offers ([Docs](https://docs.cashfree.com/reference/pgeligibilityfetchoffers))

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGEligibilityFetchOffersExample
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
            var eligibilityFetchOffersRequest = new EligibilityFetchOffersRequest{
             queries = {
              amount= 1
             }
            }; // EligibilityFetchOffersRequest | Request Body to get eligible offers for a customer and order
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Get Eligible Offers for an Order
                List<EligibilityOfferEntity> response = cashfree.PGEligibilityFetchOffers(xApiVersion, eligibilityFetchOffersRequest, xRequestId, xIdempotencyKey);
                Debug.WriteLine(response);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EligibilityApi.PGEligibilityFetchOffers: " + e.Message);
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
**eligibilityFetchOffersRequest** | [**EligibilityFetchOffersRequest***](EligibilityFetchOffersRequest.md) | Request Body to get eligible offers for a customer and order |
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |

### Response

```json
[
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
]
```


## PGEligibilityFetchPaylater

> PGEligibilityFetchPaylater(x_api_version: string, EligibilityFetchPaylaterRequest: EligibilityFetchPaylaterRequest, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<EligibilityPaylaterEntity[], any>>

Get Eligible Paylater ([Docs](https://docs.cashfree.com/reference/pgeligibilityfetchpaylater))



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGEligibilityFetchPaylaterExample
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
            var eligibilityFetchPaylaterRequest = new EligibilityFetchPaylaterRequest{
             queries = {
                        amount = 10000,
                        customer_details= {
                         customer_phone = "7330797796"
                        }
             } 
            }; // EligibilityFetchPaylaterRequest | Request Body to get eligible paylater options for a customer and order
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Get Eligible Paylater for a customer on an order
                List<EligibilityPaylaterEntity> response = cashfree.PGEligibilityFetchPaylater(xApiVersion, eligibilityFetchPaylaterRequest, xRequestId, xIdempotencyKey);
                Debug.WriteLine(response);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EligibilityApi.PGEligibilityFetchPaylater: " + e.Message);
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
**eligibilityFetchPaylaterRequest** | [**EligibilityFetchPaylaterRequest***](EligibilityFetchPaylaterRequest.md) | Request Body to get eligible paylater options for a customer and order |
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |

### Response

```json
[
  {
    "eligibility": true,
    "entity_type": "paylater",
    "entity_value": "olapostpaid",
    "entity_details": {
      "payment_method": "olapostpaid"
    }
  }
]
```


## PGEligibilityFetchPaymentMethods

> PGEligibilityFetchPaymentMethods(x_api_version: string, EligibilityFetchPaymentMethodsRequest: EligibilityFetchPaymentMethodsRequest, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<EligibilityPaymentMethodsEntity[], any>>

Get Eligible Payment Methods ([Docs](https://docs.cashfree.com/reference/pgeligibilityfetchpaymentmethods))



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGEligibilityFetchPaymentMethodsExample
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
            var eligibilityFetchPaymentMethodsRequest = new EligibilityFetchPaymentMethodsRequest{
             queries = {
              amount= 1000
             }
             };// EligibilityFetchPaymentMethodsRequest | Request Body to get eligible payment methods for an account and order
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Get eligible Payment Methods
                List<EligibilityPaymentMethodsEntity> result = cashfree.PGEligibilityFetchPaymentMethods(xApiVersion, eligibilityFetchPaymentMethodsRequest, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling EligibilityApi.PGEligibilityFetchPaymentMethods: " + e.Message);
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
**eligibilityFetchPaymentMethodsRequest** | [**EligibilityFetchPaymentMethodsRequest***](EligibilityFetchPaymentMethodsRequest.md) | Request Body to get eligible payment methods for an account and order |
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |

### Response
```json
[
  {
    "eligibility": true,
    "entity_type": "payment_methods",
    "entity_value": "netbanking",
    "entity_details": {
      "payment_method_details": [
        {
          "nick": "motak_kahindra_bank",
          "display": "Motak Kahindra Bank",
          "eligibility": true,
          "code": 3032
        },
        {
          "nick": "bank_of_india",
          "display": "Bank Of India",
          "eligibility": true,
          "code": 3031
        }
      ]
    }
  }
]
```

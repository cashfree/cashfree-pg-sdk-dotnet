# Refunds

Method | HTTP request | Description
------------- | ------------- | -------------
[**PGOrderCreateRefund**](Refunds.md#PGOrderCreateRefund) | **Post** /orders/{order_id}/refunds | Create Refund
[**PGOrderFetchRefund**](Refunds.md#PGOrderFetchRefund) | **Get** /orders/{order_id}/refunds/{refund_id} | Get Refund
[**PGOrderFetchRefunds**](Refunds.md#PGOrderFetchRefunds) | **Get** /orders/{order_id}/refunds | Get All Refunds for an Order

## PGOrderCreateRefund

> PGOrderCreateRefund(x_api_version: string, order_id: string, OrderCreateRefundRequest: OrderCreateRefundRequest, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<RefundEntity, any>>

Create Refund ([Docs](https://docs.cashfree.com/reference/pgordercreaterefund))

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGOrderCreateRefundExample
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
            var orderCreateRefundRequest = new OrderCreateRefundRequest{
                  refund_id = "refund_145082ao5HaUJOvfXKfdQwZ3A1jy5Pq8",
                  refund_amount = 1
            }; // OrderCreateRefundRequest | Request Body to Create Refunds
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Create Refund
                RefundEntity result = cashfree.PGOrderCreateRefund(xApiVersion, orderId, orderCreateRefundRequest, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefundsApi.PGOrderCreateRefund: " + e.Message);
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
**orderId** | **string*** | The id which uniquely identifies your order |
 **xApiVersion** | **string*** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2022-09-01&quot;]
 **orderCreateRefundRequest** | [**OrderCreateRefundRequest***](Refunds.md#OrderCreateRefundRequest) | Request Body to Create Refunds |
 **xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |


#### OrderCreateRefundRequest
Name | Type | Description  | Example
------------- | ------------- | ------------- | -------------
**refund_amount** | **double*** | Amount to be refunded. Should be lesser than or equal to the transaction amount. (Decimals allowed) | 1.0
**refund_id** | **string*** | An unique ID to associate the refund with. Provie alphanumeric values | refund_id_1888
**refund_note** | **string** | A refund note for your reference. | Initiating a refund from Node SDK
**refund_speed** | **string** | Speed at which the refund is processed. It's an optional field with default being STANDARD | STANDARD or INSTANT
**refund_splits** | **object[]** | If at all the refund has to be split between multiple vendors

#### RefundSplits
Name | Type | Description  | Example
------------- | ------------- | ------------- | -------------
**vendor_id** | **string** | Vendor id created in Cashfree system | vendor_01
**amount** | **double** | Amount which will be associated with this vendor | 1.0
**percentage** | **double** | Percentage of order amount which shall get added to vendor account | 25

### Response

```json
{
  "cf_payment_id": 2388816360,
  "cf_refund_id": "refund_40564529",
  "created_at": "2024-01-11T16:58:06+05:30",
  "entity": "refund",
  "metadata": null,
  "order_id": "order_145082ao5HaUJOvfXKfdQwZ3A1jy5Pq8",
  "processed_at": null,
  "refund_amount": 1,
  "refund_arn": null,
  "refund_charge": 0,
  "refund_currency": "INR",
  "refund_id": "refund_145082ao5HaUJOvfXKfdQwZ3A1jy5Pq8",
  "refund_mode": null,
  "refund_note": null,
  "refund_speed": {
    "requested": "STANDARD",
    "accepted": "STANDARD",
    "processed": null,
    "message": null
  },
  "refund_splits": [],
  "refund_status": "PENDING",
  "refund_type": "MERCHANT_INITIATED",
  "status_description": "In Progress"
}
```

## PGOrderFetchRefund

> PGOrderFetchRefund(x_api_version: string, order_id: string, refund_id: string, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<RefundEntity, any>>

Get Refund ([Docs](https://docs.cashfree.com/reference/pgorderfetchrefund))

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGOrderFetchRefundExample
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
            var orderId = order_145082ao5HaUJOvfXKfdQwZ3A1jy5Pq8;  // string | The id which uniquely identifies your order
            var refundId = refund_40564529;  // string | Refund Id of the refund you want to fetch.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Get Refund
                RefundEntity result = cashfree.PGOrderFetchRefund(xApiVersion, orderId, refundId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefundsApi.PGOrderFetchRefund: " + e.Message);
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
**orderId** | **string** | The id which uniquely identifies your order |
**refundId** | **string** | Refund Id of the refund you want to fetch. |
**xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2022-09-01&quot;]
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |


### Response
```json
{
  "cf_payment_id": 2388816360,
  "cf_refund_id": "refund_40564529",
  "created_at": "2024-01-11T16:58:06+05:30",
  "entity": "refund",
  "metadata": null,
  "order_id": "order_145082ao5HaUJOvfXKfdQwZ3A1jy5Pq8",
  "processed_at": null,
  "refund_amount": 1,
  "refund_arn": null,
  "refund_charge": 0,
  "refund_currency": "INR",
  "refund_id": "refund_145082ao5HaUJOvfXKfdQwZ3A1jy5Pq8",
  "refund_mode": null,
  "refund_note": null,
  "refund_speed": {
    "requested": "STANDARD",
    "accepted": "STANDARD",
    "processed": null,
    "message": null
  },
  "refund_splits": [],
  "refund_status": "PENDING",
  "refund_type": "MERCHANT_INITIATED",
  "status_description": "In Progress"
}
```

## PGOrderFetchRefunds

> PGOrderFetchRefunds(x_api_version: string, order_id: string, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<RefundEntity[], any>>

Get All Refunds for an Order ([Docs](https://docs.cashfree.com/reference/pgorderfetchrefunds))



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGOrderFetchRefundsExample
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
            var orderId = order_145082ao5HaUJOvfXKfdQwZ3A1jy5Pq8;  // string | The id which uniquely identifies your order
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Get All Refunds for an Order
                List<RefundEntity> result = cashfree.PGOrderFetchRefunds(xApiVersion, orderId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling RefundsApi.PGOrderFetchRefunds: " + e.Message);
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
**orderId** | **string** | The id which uniquely identifies your order |
**xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2022-09-01&quot;]
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |


### Response
```json
[
  {
  "cf_payment_id": 2388816360,
  "cf_refund_id": "refund_40564529",
  "created_at": "2024-01-11T16:58:06+05:30",
  "entity": "refund",
  "metadata": null,
  "order_id": "order_145082ao5HaUJOvfXKfdQwZ3A1jy5Pq8",
  "processed_at": null,
  "refund_amount": 1,
  "refund_arn": null,
  "refund_charge": 0,
  "refund_currency": "INR",
  "refund_id": "refund_145082ao5HaUJOvfXKfdQwZ3A1jy5Pq8",
  "refund_mode": null,
  "refund_note": null,
  "refund_speed": {
    "requested": "STANDARD",
    "accepted": "STANDARD",
    "processed": null,
    "message": null
  },
  "refund_splits": [],
  "refund_status": "PENDING",
  "refund_type": "MERCHANT_INITIATED",
  "status_description": "In Progress"
}
]
```

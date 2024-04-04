# Orders


| Method                                       | HTTP request | Description|
|----------------------------------------------| ------------- | -------------|
 | [**PGCreateOrder**](Orders.md#PGCreateOrder) | **Post** /orders | Create Order|
 | [**PGFetchOrder**](Orders.md#PGFetchOrder)   | **Get** /orders/{order_id} | Get Order|



## PGCreateOrder

> PGCreateOrder(x_api_version: string, CreateOrderRequest: CreateOrderRequest, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<OrderEntity, any>>

Create Order ([Docs](https://docs.cashfree.com/reference/pgcreateorder))

### Example
```csharp
using System;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example 
{
    public class PGCreateOrderExample
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
            var createOrderRequest = new CreateOrderRequest
            {
                order_amount = "1",
                order_currency = "INR",
                customer_details = new CustomerDetails
                {
                    customer_id = "node_sdk_test",
                    customer_email = "example@gmail.com",
                    customer_phone = "9999999999"
                },
                order_meta = new OrderMeta
                {
                    return_url = "https://test.cashfree.com/pgappsdemos/return.php?order_id={order_id}"
                }
            };

            try {
                // Create Order
                OrderEntity result = cashfree.PGCreateOrder(xApiVersion, createOrderRequest, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.PGCreateOrder: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```



### Parameters

Other parameters are passed through a pointer to a apiPGCreateOrderRequest struct via the builder pattern


| Name                   | Type | Description  | Notes|
|------------------------| ------------- | ------------- | -------------|
| **xApiVersion**        | **string** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2022-09-01&quot;]|
| **createOrderRequest** | [**CreateOrderRequest**](Orders.md#CreateOrderRequest) | Request body to create an order at cashfree |
| **xRequestId**         | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |
| **xIdempotencyKey**    | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   |

### CreateOrderRequest
| Name                  | Type | Description  | Example|
|-----------------------| ------------- | ------------- | -------------|
| **order_id**          | **string** (min 3, max 50, alphanumeric with _ and -) | The order ID identifies your order in the system. | order_8123|
| **order_amount**      | **float*** (provide in two decimal places) | The order amount. | 101.12 (INR 101.12 implies rupees 101 and 12 paisa)|
| **order_currency**    | **string*** | The order currency. We use the ISO 4217 currency list. | The order currency - INR.|
| **customer_details**  | **object*** | This is a custom object which contains customer_details. The details of the customer such as: customer ID, name of the customer, email of the customer, phone number of the customer. | See below object.|
| **order_meta**        | **object*** | This is a custom object which contains information about available payment methods for this order, webhook url and notify url. | See below object.|
| **order_expiry_time** | **string** | Time after which the order expires. This is the time after which customers will not be able to make any payment "attempt". Any delayed payment received from the bank side post this time (whose attempt was done within expiry time) will be reversed. | 2023-07-29T00:00:00Z
|  **order_note**       | **string** | Order note for reference purposes. | This order was created with Node SDK.

### CustomerDetails
Name | Type | Description  | Example
------------- | ------------- | ------------- | -------------
**customer_id** | **string***(alphanumeric with - and _ allowed) | This is is the identifier for the customer in your system. | customer1234
**customer_name** | **string**(Special characters are not allowed) | Name of your customer. | Cashfree Payments
**customer_email** | **string** | Email id of the customer | example@cashfree.com
**customer_phone** | **string*** | Phone of the customer. 10 digits phone number. | 8908908901

### OrderMeta
Name | Type | Description  | Example
------------- | ------------- | ------------- | -------------
**return_url** | **string** | This is the URL to which your customers will be redirected to after the payment. When a customer makes a card payment, they are redirected from your website to the bank's OTP page. From there, the customer is redirected back to your return url page. The return_url must contain a placeholder {order_id}. When redirecting the customer back to the return URL from the bank’s OTP page, Cashfree Payments will replace the placeholder with the actual value for that order. | https://merchant.in/pg/process_return?order_id={order_id}
**notify_url** | **string** | The webhook URL is required to get successful or failed webhooks after a payment on an order is completed. Only https URL allowed in production. http is allowed only in sandbox. | https://merchant.in/pg/process_webhook
**payment_methods** | **string** | List of payment modes. Use the following values - cc, dc, ccc, ppc, nb, upi, paypal, emi, app paylater. | "cc,dc,upi,nb"

#### OrderEntity
```json
{
  "cf_order_id": 2149460581,
  "created_at": "2023-08-11T18:02:46+05:30",
  "customer_details": {
    "customer_id": "409128494",
    "customer_name": "Johmn Doe",
    "customer_email": "pmlpayme@ntsas.com",
    "customer_phone": "9876543210"
  },
  "entity": "order",
  "order_amount": 22,
  "order_currency": "INR",
  "order_expiry_time": "2023-09-09T18:02:46+05:30",
  "order_id": "order_3242Tq4Edj9CC5RDcMeobmJOWOBJij",
  "order_meta": {
    "return_url": "https://example.com/return/{order_id}",
    "notify_url": "https://example.com/notify",
    "payment_methods": "cc"
  },
  "order_note": "some order note LIST",
  "order_splits": [],
  "order_status": "ACTIVE",
  "order_tags": {
    "name": "John",
    "age": "19"
  },
  "payment_session_id": "session_a1VXIPJo8kh7IBigVXX8LgTMupQW_cu25FS8KwLwQLOmiHqbBxq5UhEilrhbDSKKHA6UAuOj9506aaHNlFAHEqYrHSEl9AVtYQN9LIIc4vkH"
}
```


## PGFetchOrder

> PGFetchOrder(x_api_version: string, order_id: string, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<OrderEntity, any>>

Get Order ([Docs](https://docs.cashfree.com/reference/pgfetchorder))



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGFetchOrderExample
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

            try
            {
                // Get Order
                OrderEntity result = cashfree.PGFetchOrder(xApiVersion, orderId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling OrdersApi.PGFetchOrder: " + e.Message);
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
**xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2022-09-01&quot;]
**orderId** | **string** | The id which uniquely identifies your order |
**xRequestId** | **string?** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree
**xIdempotencyKey** | **Guid?** | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.
#### OrderEntity
```json
{
  "cf_order_id": 2149460581,
  "created_at": "2023-08-11T18:02:46+05:30",
  "customer_details": {
    "customer_id": "409128494",
    "customer_name": "Johmn Doe",
    "customer_email": "pmlpayme@ntsas.com",
    "customer_phone": "9876543210"
  },
  "entity": "order",
  "order_amount": 22,
  "order_currency": "INR",
  "order_expiry_time": "2023-09-09T18:02:46+05:30",
  "order_id": "order_3242Tq4Edj9CC5RDcMeobmJOWOBJij",
  "order_meta": {
    "return_url": "https://example.com/return/{order_id}",
    "notify_url": "https://example.com/notify",
    "payment_methods": "cc"
  },
  "order_note": "some order note LIST",
  "order_splits": [],
  "order_status": "ACTIVE",
  "order_tags": {
    "name": "John",
    "age": "19"
  },
  "payment_session_id": "session_a1VXIPJo8kh7IBigVXX8LgTMupQW_cu25FS8KwLwQLOmiHqbBxq5UhEilrhbDSKKHA6UAuOj9506aaHNlFAHEqYrHSEl9AVtYQN9LIIc4vkH"
}
```

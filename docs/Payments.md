# Payments

Method | HTTP request | Description
------------- | ------------- | -------------
[**PGOrderFetchPayment**](Payments.md#PGOrderFetchPayment) | **Get** /orders/{order_id}/payments/{cf_payment_id} | Get Payment by ID
[**PGOrderFetchPayments**](Payments.md#PGOrderFetchPayments) | **Get** /orders/{order_id}/payments | Get Payments for an Order
[**PGPayOrder**](Payments.md#PGPayOrder) | **Post** /orders/sessions | Order Pay
[**PGAuthorizeOrder**](Payments.md#PGAuthorizeOrder) | **Post** /orders/{order_id}/authorization | Preauthorization
[**PGOrderAuthenticatePayment**](Payments.md#PGOrderAuthenticatePayment) | **Post** /orders/pay/authenticate/{cf_payment_id} | Submit or Resend OTP


## PGOrderFetchPayment

> PGOrderFetchPayment(x_api_version: string, order_id: string, cf_payment_id: string, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<PaymentEntity, any>>

Get Payment by ID ([Docs](https://docs.cashfree.com/reference/pgorderfetchpayment))



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGOrderFetchPaymentExample
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
            var cfPaymentId = 121224562;  // string | The Cashfree payment or transaction ID.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Get Payment by ID
                PaymentEntity response= cashfree.PGOrderFetchPayment(xApiVersion, orderId, cfPaymentId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(response);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.PGOrderFetchPayment: " + e.Message);
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
**orderId** | **string*** | The id which uniquely identifies your order |
**cfPaymentId** | **string*** | The Cashfree payment or transaction ID. |
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |


### Response
```json
{
  "cf_payment_id": 12376123,
  "order_id": "order_8123",
  "entity": "payment",
  "payment_currency": "INR",
  "error_details": null,
  "order_amount": 10.01,
  "is_captured": true,
  "payment_group": "upi",
  "authorization": {
    "action": "CAPTURE",
    "status": "PENDING",
    "captured_amount": 100,
    "start_time": "2022-02-09T18:04:34+05:30",
    "end_time": "2022-02-19T18:04:34+05:30",
    "approve_by": "2022-02-09T18:04:34+05:30",
    "action_reference": "6595231908096894505959",
    "action_time": "2022-08-03T16:09:51"
  },
  "payment_method": {
    "upi": {
      "channel": "collect",
      "upi_id": "rohit@xcxcx"
    }
  },
  "payment_amount": 10.01,
  "payment_time": "2021-07-23T12:15:06+05:30",
  "payment_completion_time": "2021-07-23T12:18:59+05:30",
  "payment_status": "SUCCESS",
  "payment_message": "Transaction successful",
  "bank_reference": "P78112898712",
  "auth_id": "A898101"
}
```



## PGOrderFetchPayments

> PGOrderFetchPayments(x_api_version: string, order_id: string, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<PaymentEntity[], any>>

Get Payments for an Order ([Docs](https://docs.cashfree.com/reference/pgorderfetchpayments))



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGOrderFetchPaymentsExample
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
                // Get Payments for an Order
                List<PaymentEntity> result = cashfree.PGOrderFetchPayments(xApiVersion, orderId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.PGOrderFetchPayments: " + e.Message);
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
**orderId** | **string*** | The id which uniquely identifies your order |
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |


### Response
```json
[
  {
    "cf_payment_id": 12376123,
    "order_id": "order_8123",
    "entity": "payment",
    "payment_currency": "INR",
    "error_details": null,
    "order_amount": 10.01,
    "is_captured": true,
    "payment_group": "upi",
    "authorization": {
      "action": "CAPTURE",
      "status": "PENDING",
      "captured_amount": 100,
      "start_time": "2022-02-09T18:04:34+05:30",
      "end_time": "2022-02-19T18:04:34+05:30",
      "approve_by": "2022-02-09T18:04:34+05:30",
      "action_reference": "6595231908096894505959",
      "action_time": "2022-08-03T16:09:51"
    },
    "payment_method": {
      "upi": {
        "channel": "collect",
        "upi_id": "rohit@xcxcx"
      }
    },
    "payment_amount": 10.01,
    "payment_time": "2021-07-23T12:15:06+05:30",
    "payment_completion_time": "2021-07-23T12:18:59+05:30",
    "payment_status": "SUCCESS",
    "payment_message": "Transaction successful",
    "bank_reference": "P78112898712",
    "auth_id": "A898101"
  },
  {
    "cf_payment_id": 12376124,
    "order_id": "order_8123",
    "entity": "payment",
    "payment_currency": "INR",
    "error_details": {
      "error_code": "TRANSACTION_DECLINED",
      "error_description": "issuer bank or payment service provider declined the transaction",
      "error_reason": "auth_declined",
      "error_source": "customer"
    },
    "order_amount": 10.01,
    "is_captured": true,
    "payment_group": "credit_card",
    "authorization": null,
    "payment_method": {
      "card": {
        "channel": "link",
        "card_number": "xxxxxx1111"
      }
    },
    "payment_amount": 10.01,
    "payment_time": "2021-07-23T12:15:06+05:30",
    "payment_completion_time": "2021-07-23T12:18:59+05:30",
    "payment_status": "FAILED",
    "payment_message": "Transaction failed",
    "bank_reference": "P78112898712",
    "auth_id": "A898101"
  }
]
```

## PGPayOrder

> PGPayOrder(x_api_version: string, PayOrderRequest: PayOrderRequest, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<PayOrderEntity, any>>

Order Pay ([Docs](https://docs.cashfree.com/reference/pgpayorder))

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGPayOrderExample
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
            var payOrderRequest = new PayOrderRequest{
                payment_session_id = "session_CLLC8TuxmB48U8pYJy4z8Ktk9Eh6IMnJzAScehfhKRarvab9KCl09YNxLsDjfeU104u4bqcKgk3ckbIsGsAWHBjvlv0XhRlJEzx4E5cLUHRC",
                payment_method = new PaymentMethod{
                 card = new Card
                 {
                    channel = "link",
                    card_holder_name = "Test",
                    card_number = "4111111111111111",
                    card_expiry_mm = "12",
                    card_expiry_yy = "30",
                    card_cvv = "123"
                 }
               }
            }; // PayOrderRequest | Request body to create a transaction at cashfree using `payment_session_id`
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Order Pay
                PayOrderEntity result = cashfree.PGPayOrder(xApiVersion, payOrderRequest, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.PGPayOrder: " + e.Message);
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
 **payOrderRequest** | **PayOrderRequest*** | Request body to create a transaction at cashfree using &#x60;payment_session_id&#x60; |
 **xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2022-09-01&quot;]
 **xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |


#### Netbanking
```csharp
var payOrderRequest = new PayOrderRequest
{
  payment_session_id = "session_CLLC8TuxmB48U8pYJy4z8Ktk9Eh6IMnJzAScehfhKRarvab9KCl09YNxLsDjfeU104u4bqcKgk3ckbIsGsAWHBjvlv0XhRlJEzx4E5cLUHRC",
      payment_method = new PaymentMethod
  {
    netbanking = new Netbanking
    {
      channel = "link",
          netbanking_bank_code = 3021
    }
  }
}
```

#### UPI
```csharp
var payOrderRequest = new PayOrderRequest
{
  payment_session_id = "session_CLLC8TuxmB48U8pYJy4z8Ktk9Eh6IMnJzAScehfhKRarvab9KCl09YNxLsDjfeU104u4bqcKgk3ckbIsGsAWHBjvlv0XhRlJEzx4E5cLUHRC",
      payment_method = new PaymentMethod
  {
    upi = new Upi
    {
      channel = "collect",
          upi_id = "testsuccess@gocash"
    }
  }
}
```

#### UPI
```csharp
var payOrderRequest = new PayOrderRequest
{
  payment_session_id = "session_CLLC8TuxmB48U8pYJy4z8Ktk9Eh6IMnJzAScehfhKRarvab9KCl09YNxLsDjfeU104u4bqcKgk3ckbIsGsAWHBjvlv0XhRlJEzx4E5cLUHRC",
      payment_method = new PaymentMethod
  {
    upi = new Upi
    {
      channel = "link"
    }
  }
}
```

#### QR
```csharp
var payOrderRequest = new PayOrderRequest
{
  payment_session_id = "session_CLLC8TuxmB48U8pYJy4z8Ktk9Eh6IMnJzAScehfhKRarvab9KCl09YNxLsDjfeU104u4bqcKgk3ckbIsGsAWHBjvlv0XhRlJEzx4E5cLUHRC",
      payment_method = new PaymentMethod
  {
    upi = new Upi
    {
      channel = "qrcode"
    }
  }
}
```

#### Wallet
```csharp
var payOrderRequest = new PayOrderRequest
{
  payment_session_id = "session_CLLC8TuxmB48U8pYJy4z8Ktk9Eh6IMnJzAScehfhKRarvab9KCl09YNxLsDjfeU104u4bqcKgk3ckbIsGsAWHBjvlv0XhRlJEzx4E5cLUHRC",
      payment_method = new PaymentMethod
  {
    app = new App
    {
      provider = "phonepe",
          channel = "link",
          phone = "8474090589"
    }
  }
}
```

#### Card (with saving it)
```csharp
var payOrderRequest = new PayOrderRequest
{
  payment_session_id = "session_CLLC8TuxmB48U8pYJy4z8Ktk9Eh6IMnJzAScehfhKRarvab9KCl09YNxLsDjfeU104u4bqcKgk3ckbIsGsAWHBjvlv0XhRlJEzx4E5cLUHRC",
      payment_method = new PaymentMethod
  {
    card = new Card
    {
      channel = "link",
          card_holder_name = "Test",
          card_number = "4111111111111111",
          card_expiry_mm = "12",
          card_expiry_yy = "30",
          card_cvv = "123"
    }
  },
  save_instrument = true
}
```

#### Card with saved instrument
```csharp
var payOrderRequest = new PayOrderRequest
{
  PaymentSessionId = "session_CLLC8TuxmB48U8pYJy4z8Ktk9Eh6IMnJzAScehfhKRarvab9KCl09YNxLsDjfeU104u4bqcKgk3ckbIsGsAWHBjvlv0XhRlJEzx4E5cLUHRC",
      PaymentMethod = new PaymentMethod
  {
    Card = new Card
    {
      Channel = "link",
          InstrumentId = "54deabb4-ba45-4a60-9e6a-9c016fe7ab10",
          CardCvv = "900"
    }
  }
}
```

#### Card (with native otp)
```csharp
var payOrderRequest = new PayOrderRequest
{
  PaymentSessionId = "session_CLLC8TuxmB48U8pYJy4z8Ktk9Eh6IMnJzAScehfhKRarvab9KCl09YNxLsDjfeU104u4bqcKgk3ckbIsGsAWHBjvlv0XhRlJEzx4E5cLUHRC",
      PaymentMethod = new PaymentMethod
  {
    Card = new Card
    {
      Channel = "post",
          CardNumber = "4111111111111111",
          CardExpiryMm = "03",
          CardExpiryYy = "25",
          CardCvv = "326"
    }
  }
}
```

#### EMI
```csharp
var payOrderRequest = new PayOrderRequest
{
  PaymentSessionId = "session_CLLC8TuxmB48U8pYJy4z8Ktk9Eh6IMnJzAScehfhKRarvab9KCl09YNxLsDjfeU104u4bqcKgk3ckbIsGsAWHBjvlv0XhRlJEzx4E5cLUHRC",
      PaymentMethod = new PaymentMethod
  {
    Emi = new Emi
    {
      Channel = "link",
          CardNumber = "4748461111111111",
          CardExpiryMm = "12",
          CardExpiryYy = "24",
          CardCvv = "123",
          CardBankName = "ICICI",
          EmiTenure = 3
    }
  }
}
```

### Response
```json
{
  "payment_method": "card",
  "channel": "link",
  "action": "link",
  "cf_payment_id": 91235,
  "payment_amount": 22.42,
  "data": {
    "url": "https://sandbox.cashfree.com/pg/view/gateway/FHsuvhayLM5mmhINoqri7ba296e2ebca8b98e6119f6223021a13",
    "payload": {
      "name": "card"
    },
    "content_type": "application/x-www-form-urlencoded",
    "method": "post"
  }
}
```

## PGAuthorizeOrder

> PGAuthorizeOrder(x_api_version: string, order_id: string, AuthorizeOrderRequest: AuthorizeOrderRequest, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<PaymentEntity, any>>

Preauthorization ([Docs](https://docs.cashfree.com/reference/pgauthorizeorder))

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGAuthorizeOrderExample
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
            var authorizeOrderRequest = new AuthorizeOrderRequest{
                  action = "CAPTURE", // or VOID
                  amount = 1
            }; // AuthorizeOrderRequest | Request to Capture or Void Transactions
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Preauthorization
                PaymentEntity response = cashfree.PGAuthorizeOrder(xApiVersion, orderId, authorizeOrderRequest, xRequestId, xIdempotencyKey);
                Debug.WriteLine(response);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.PGAuthorizeOrder: " + e.Message);
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
 **authorizeOrderRequest** | **AuthorizeOrderRequest*** | Request to Capture or Void Transactions |
 **xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2022-09-01&quot;]
 **xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |


### Response
```json
{
  "cf_payment_id": 12376123,
  "order_id": "order_8123",
  "entity": "payment",
  "payment_currency": "INR",
  "error_details": null,
  "order_amount": 10.01,
  "is_captured": true,
  "payment_group": "upi",
  "authorization": {
    "action": "CAPTURE",
    "status": "PENDING",
    "captured_amount": 100,
    "start_time": "2022-02-09T18:04:34+05:30",
    "end_time": "2022-02-19T18:04:34+05:30",
    "approve_by": "2022-02-09T18:04:34+05:30",
    "action_reference": "6595231908096894505959",
    "action_time": "2022-08-03T16:09:51"
  },
  "payment_method": {
    "upi": {
      "channel": "collect",
      "upi_id": "rohit@xcxcx"
    }
  },
  "payment_amount": 10.01,
  "payment_time": "2021-07-23T12:15:06+05:30",
  "payment_completion_time": "2021-07-23T12:18:59+05:30",
  "payment_status": "SUCCESS",
  "payment_message": "Transaction successful",
  "bank_reference": "P78112898712",
  "auth_id": "A898101"
}
```


## PGOrderAuthenticatePayment

> PGOrderAuthenticatePayment(x_api_version: string, cf_payment_id: string, OrderAuthenticatePaymentRequest: OrderAuthenticatePaymentRequest, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<OrderAuthenticateEntity, any>>

Submit or Resend OTP ([Docs](https://docs.cashfree.com/reference/pgorderauthenticatepayment))

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGOrderAuthenticatePaymentExample
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
            var cfPaymentId = 121224562;  // string | The Cashfree payment or transaction ID.
            var orderAuthenticatePaymentRequest = new OrderAuthenticatePaymentRequest{
                    otp = "111000",
                    action = "SUBMIT_OTP"
            }; // OrderAuthenticatePaymentRequest | Request body to submit/resend headless OTP. To use this API make sure you have headless OTP enabled for your account
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Submit or Resend OTP
                OrderAuthenticateEntity result = cashfree.PGOrderAuthenticatePayment(xApiVersion, cfPaymentId, orderAuthenticatePaymentRequest, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentsApi.PGOrderAuthenticatePayment: " + e.Message);
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
**cfPaymentId** | **string*** | The Cashfree payment or transaction ID. |
**xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2022-09-01&quot;]
**orderAuthenticatePaymentRequest** | **OrderAuthenticatePaymentRequest*** | Request body to submit/resend headless OTP. To use this API make sure you have headless OTP enabled for your account |
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |


### Response
```json
{
  "cf_payment_id": 975654863,
  "authenticate_status": "FAILED",
  "action": "SUBMIT_OTP",
  "payment_message": "otp is invalid"
}
```

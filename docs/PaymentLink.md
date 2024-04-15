# PaymentLinks

Method | HTTP request | Description
------------- | ------------- | -------------
[**PGCancelLink**](PaymentLink.md#PGCancelLink) | **Post** /links/{link_id}/cancel | Cancel Payment Link
[**PGCreateLink**](PaymentLink.md#PGCreateLink) | **Post** /links | Create Payment Link
[**PGFetchLink**](PaymentLink.md#PGFetchLink) | **Get** /links/{link_id} | Fetch Payment Link Details
[**PGLinkFetchOrders**](PaymentLink.md#PGLinkFetchOrders) | **Get** /links/{link_id}/orders | Get Orders for a Payment Link



## PGCancelLink

> PGCancelLink(x_api_version: string, link_id: string, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<LinkEntity, any>>

Cancel Payment Link ([Docs](https://docs.cashfree.com/reference/pgcancellink))

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGCancelLinkExample
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
            var linkId = your-link-id;  // string | The payment link ID for which you want to view the details.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Cancel Payment Link
                LinkEntity result = cashfree.PGCancelLink(xApiVersion, linkId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentLinksApi.PGCancelLink: " + e.Message);
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
**linkId** | **string** | The payment link ID for which you want to view the details. |
**xApiVersion** | **string** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2022-09-01&quot;]
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |


### Response

```json
{
  "cf_link_id": 1996567,
  "link_id": "your_link_id",
  "link_status": "ACTIVE",
  "link_currency": "INR",
  "link_amount": 100,
  "link_amount_paid": 0,
  "link_partial_payments": true,
  "link_minimum_partial_amount": 20,
  "link_purpose": "Payment for PlayStation 11",
  "link_created_at": "2021-09-30T17:05:01+05:30",
  "customer_details": {
    "customer_name": "John Doe",
    "customer_phone": "9999999999",
    "customer_email": "john@example.com"
  },
  "link_meta": {
    "title": "link_meta",
    "description": "Payment link meta information object",
    "type": "object",
    "example": {
      "notify_url": "https://ee08e626ecd88c61c85f5c69c0418cb5.m.pipedream.net",
      "upi_intent": false,
      "return_url": "https://b8af79f41056.eu.ngrok.io"
    },
    "properties": {
      "notify_url": {
        "type": "string",
        "description": "Notification URL for server-server communication. It should be an https URL."
      },
      "upi_intent": {
        "type": "boolean",
        "description": "If \"true\", link will directly open UPI Intent flow on mobile, and normal link flow elsewhere"
      },
      "return_url": {
        "type": "string",
        "description": "The URL to which user will be redirected to after the payment is done on the link. Maximum length: 250."
      },
      "payment_methods": {
        "type": "string",
        "description": "Allowed payment modes for this link. Pass comma-separated values among following options - \"cc\", \"dc\", \"ccc\", \"ppc\", \"nb\", \"upi\", \"paypal\", \"app\". Leave it blank to show all available payment methods"
      }
    },
    "x-readme-ref-name": "LinkMetaEntity"
  },
  "link_url": "https://payments-test.cashfree.com/links/o1tf1nvcvjhg",
  "link_expiry_time": "2021-10-14T15:04:05+05:30",
  "link_notes": {
    "title": "link_notes",
    "type": "object",
    "description": "Key-value pair that can be used to store additional information about the entity. Maximum 5 key-value pairs",
    "example": {
      "key_1": "value_1",
      "key_2": "value_2"
    },
    "additionalProperties": {
      "type": "string"
    },
    "x-readme-ref-name": "LinkNotesEntity"
  },
  "link_auto_reminders": true,
  "link_notify": {
    "title": "link_notify",
    "type": "object",
    "description": "Payment link Notify Object for SMS and Email",
    "example": {
      "send_sms": false,
      "send_email": true
    },
    "properties": {
      "send_sms": {
        "type": "boolean",
        "description": "If \"true\", Cashfree will send sms on customer_phone"
      },
      "send_email": {
        "type": "boolean",
        "description": "If \"true\", Cashfree will send email on customer_email"
      }
    },
    "x-readme-ref-name": "LinkNotifyEntity"
  }
}
```


## PGCreateLink

> PGCreateLink(x_api_version: string, CreateLinkRequest: CreateLinkRequest, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<LinkEntity, any>>

Create Payment Link ([Docs](https://docs.cashfree.com/reference/pgcreatelink))

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGCreateLinkExample
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
            var createLinkRequest = new CreateLinkRequest{
            link_amount = 100,
            link_currency = "INR",
            link_minimum_partial_amount = 20,
            link_id = "my_link_id",
            link_partial_payments = true,
            customer_details = new CustomerDetails
            {
                customer_name = "John Doe",
                customer_phone = "9999999999",
                customer_email = "john@cashfree.com"
            },
            link_expiry_time = "2024-10-14T15:04:05+05:30",
            link_purpose = "Payment for PlayStation 11",
            link_notify = new LinkNotify
            {
                send_sms = false,
                send_email = true
            },
            link_auto_reminders = false,
            link_notes = new LinkNotes
            {
                key_1 = "value_1",
                key_2 = "value_2"
            },
            link_meta = new LinkMeta
            {
                notify_url = "https://ee08e626ecd88c61c85f5c69c0418cb5.m.pipedream.net",
                upi_intent = false,
                return_url = "https://b8af79f41056.eu.ngrok.io"
            }
            }; // CreateLinkRequest | Request Body to Create Payment Links
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Create Payment Link
                LinkEntity result = cashfree.PGCreateLink(xApiVersion, createLinkRequest, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentLinksApi.PGCreateLink: " + e.Message);
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
**createLinkRequest** | **CreateLinkRequest*** | Request Body to Create Payment Links |
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |


### Response

```json
{
  "cf_link_id": 1996567,
  "link_id": "my_link_id",
  "link_status": "ACTIVE",
  "link_currency": "INR",
  "link_amount": 100,
  "link_amount_paid": 0,
  "link_partial_payments": true,
  "link_minimum_partial_amount": 20,
  "link_purpose": "Payment for PlayStation 11",
  "link_created_at": "2021-09-30T17:05:01+05:30",
  "customer_details": {
    "customer_name": "John Doe",
    "customer_phone": "9999999999",
    "customer_email": "john@example.com"
  },
  "link_meta": {
    "title": "link_meta",
    "description": "Payment link meta information object",
    "type": "object",
    "example": {
      "notify_url": "https://ee08e626ecd88c61c85f5c69c0418cb5.m.pipedream.net",
      "upi_intent": false,
      "return_url": "https://b8af79f41056.eu.ngrok.io"
    },
    "properties": {
      "notify_url": {
        "type": "string",
        "description": "Notification URL for server-server communication. It should be an https URL."
      },
      "upi_intent": {
        "type": "boolean",
        "description": "If \"true\", link will directly open UPI Intent flow on mobile, and normal link flow elsewhere"
      },
      "return_url": {
        "type": "string",
        "description": "The URL to which user will be redirected to after the payment is done on the link. Maximum length: 250."
      },
      "payment_methods": {
        "type": "string",
        "description": "Allowed payment modes for this link. Pass comma-separated values among following options - \"cc\", \"dc\", \"ccc\", \"ppc\", \"nb\", \"upi\", \"paypal\", \"app\". Leave it blank to show all available payment methods"
      }
    },
    "x-readme-ref-name": "LinkMetaEntity"
  },
  "link_url": "https://payments-test.cashfree.com/links/o1tf1nvcvjhg",
  "link_expiry_time": "2021-10-14T15:04:05+05:30",
  "link_notes": {
    "title": "link_notes",
    "type": "object",
    "description": "Key-value pair that can be used to store additional information about the entity. Maximum 5 key-value pairs",
    "example": {
      "key_1": "value_1",
      "key_2": "value_2"
    },
    "additionalProperties": {
      "type": "string"
    },
    "x-readme-ref-name": "LinkNotesEntity"
  },
  "link_auto_reminders": true,
  "link_notify": {
    "title": "link_notify",
    "type": "object",
    "description": "Payment link Notify Object for SMS and Email",
    "example": {
      "send_sms": false,
      "send_email": true
    },
    "properties": {
      "send_sms": {
        "type": "boolean",
        "description": "If \"true\", Cashfree will send sms on customer_phone"
      },
      "send_email": {
        "type": "boolean",
        "description": "If \"true\", Cashfree will send email on customer_email"
      }
    },
    "x-readme-ref-name": "LinkNotifyEntity"
  }
}
```


## PGFetchLink

> PGFetchLink(x_api_version: string, link_id: string, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<LinkEntity, any>>

Fetch Payment Link Details ([Docs](https://docs.cashfree.com/reference/pgfetchlink))

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGFetchLinkExample
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
            var linkId = my_link_id_test;  // string | The payment link ID for which you want to view the details.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Fetch Payment Link Details
                LinkEntity result = cashfree.PGFetchLink(xApiVersion, linkId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentLinksApi.PGFetchLink: " + e.Message);
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
**linkId** | **string*** | The payment link ID for which you want to view the details. |
**xApiVersion** | **string*** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2022-09-01&quot;]
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |


### Response
```json
{
  "cf_link_id": 1996567,
  "link_id": "my_link_id_test",
  "link_status": "ACTIVE",
  "link_currency": "INR",
  "link_amount": 100,
  "link_amount_paid": 0,
  "link_partial_payments": true,
  "link_minimum_partial_amount": 20,
  "link_purpose": "Payment for PlayStation 11",
  "link_created_at": "2021-09-30T17:05:01+05:30",
  "customer_details": {
    "customer_name": "John Doe",
    "customer_phone": "9999999999",
    "customer_email": "john@example.com"
  },
  "link_meta": {
    "title": "link_meta",
    "description": "Payment link meta information object",
    "type": "object",
    "example": {
      "notify_url": "https://ee08e626ecd88c61c85f5c69c0418cb5.m.pipedream.net",
      "upi_intent": false,
      "return_url": "https://b8af79f41056.eu.ngrok.io"
    },
    "properties": {
      "notify_url": {
        "type": "string",
        "description": "Notification URL for server-server communication. It should be an https URL."
      },
      "upi_intent": {
        "type": "boolean",
        "description": "If \"true\", link will directly open UPI Intent flow on mobile, and normal link flow elsewhere"
      },
      "return_url": {
        "type": "string",
        "description": "The URL to which user will be redirected to after the payment is done on the link. Maximum length: 250."
      },
      "payment_methods": {
        "type": "string",
        "description": "Allowed payment modes for this link. Pass comma-separated values among following options - \"cc\", \"dc\", \"ccc\", \"ppc\", \"nb\", \"upi\", \"paypal\", \"app\". Leave it blank to show all available payment methods"
      }
    },
    "x-readme-ref-name": "LinkMetaEntity"
  },
  "link_url": "https://payments-test.cashfree.com/links/o1tf1nvcvjhg",
  "link_expiry_time": "2021-10-14T15:04:05+05:30",
  "link_notes": {
    "title": "link_notes",
    "type": "object",
    "description": "Key-value pair that can be used to store additional information about the entity. Maximum 5 key-value pairs",
    "example": {
      "key_1": "value_1",
      "key_2": "value_2"
    },
    "additionalProperties": {
      "type": "string"
    },
    "x-readme-ref-name": "LinkNotesEntity"
  },
  "link_auto_reminders": true,
  "link_notify": {
    "title": "link_notify",
    "type": "object",
    "description": "Payment link Notify Object for SMS and Email",
    "example": {
      "send_sms": false,
      "send_email": true
    },
    "properties": {
      "send_sms": {
        "type": "boolean",
        "description": "If \"true\", Cashfree will send sms on customer_phone"
      },
      "send_email": {
        "type": "boolean",
        "description": "If \"true\", Cashfree will send email on customer_email"
      }
    },
    "x-readme-ref-name": "LinkNotifyEntity"
  }
}
```


## PGLinkFetchOrders

> PGLinkFetchOrders(x_api_version: string, link_id: string, x_request_id?: string, x_idempotency_key?: string, options?: AxiosRequestConfig): Promise<import("axios").AxiosResponse<OrderEntity[], any>>

Get Orders for a Payment Link ([Docs](https://docs.cashfree.com/reference/pglinkfetchorders))



### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using cashfree_pg.Client;
using cashfree_pg.Model;

namespace Example
{
    public class PGLinkFetchOrdersExample
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
            var linkId = your-link-id;  // string | The payment link ID for which you want to view the details.
            var xRequestId = 4dfb9780-46fe-11ee-be56-0242ac120002;  // string? | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree (optional) 
            var xIdempotencyKey = 47bf8872-46fe-11ee-be56-0242ac120002;  // Guid? | An idempotency key is a unique identifier you include with your API call. If the request fails or times out, you can safely retry it using the same key to avoid duplicate actions.   (optional) 

            try
            {
                // Get Orders for a Payment Link
                List<PaymentLinkOrderEntity> result = cashfree.PGLinkFetchOrders(xApiVersion, linkId, xRequestId, xIdempotencyKey);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PaymentLinksApi.PGLinkFetchOrders: " + e.Message);
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
**linkId** | **string*** | The payment link ID for which you want to view the details. |
**xApiVersion** | **string*** | API version to be used. Format is in YYYY-MM-DD | [default to &quot;2022-09-01&quot;]
**xRequestId** | **string** | Request id for the API call. Can be used to resolve tech issues. Communicate this in your tech related queries to cashfree |


### Response
```json
[
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
    "payment_session_id": "session_a1VXIPJo8kh7IBigVXX8LgTMupQW_cu25FS8KwLwQLOmiHqbBxq5UhEilrhbDSKKHA6UAuOj9506aaHNlFAHEqYrHSEl9AVtYQN9LIIc4vkH",
    "payments": {
      "url": "https://sandbox.cashfree.com/pg/orders/order_3242Tq4Edj9CC5RDcMeobmJOWOBJij/payments"
    },
    "refunds": {
      "url": "https://sandbox.cashfree.com/pg/orders/order_3242Tq4Edj9CC5RDcMeobmJOWOBJij/refunds"
    },
    "settlements": {
      "url": "https://sandbox.cashfree.com/pg/orders/order_3242Tq4Edj9CC5RDcMeobmJOWOBJij/settlements"
    },
    "terminal_data": null
  }
]
```

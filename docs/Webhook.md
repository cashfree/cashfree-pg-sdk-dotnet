# Webhook


## PGVerifyWebhookSignature

> PGVerifyWebhookSignature(signature: string, rawBody: string, timestamp: string): PGWebhookEvent

Verify Webhook Signatures ([Docs](https://docs.cashfree.com/reference/pg-webhook)

### Example

```csharp
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;

[ApiController]
    [Route("[controller]")]
public class WebhookController : ControllerBase
{
  [HttpPost]
  public async Task<IActionResult> HandleWebhook()
  {
    try
    {
      string signature = Request.Headers["x-webhook-signature"];
      string timestamp = Request.Headers["x-webhook-timestamp"];
      string requestBody;

      using (StreamReader reader = new StreamReader(Request.Body))
      {
        requestBody = await reader.ReadToEndAsync();
      }

      var response = Cashfree.PGVerifyWebhookSignature(signature, requestBody, timestamp);
      Console.WriteLine(response.Object); // This is where you handle the verified webhook payload
    }
    catch (Exception ex)
    {
      Console.WriteLine(ex.Message);
    }
  }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
**signature** | **string** | The "x-webhook-signature" present in the headers received |
**rawBody** | **string** | The request body received in the request in string format |
**timestamp** | **string** | The "x-webhook-timestamp" present in the headers received |


### Response

```json
{
    "type": "PAYMENT_SUCCESS_WEBHOOK",
    "rawBody":"{\"type\":\"PAYMENT_SUCCESS_WEBHOOK\",\"data\":{}}",
    "object": {
        "type": "PAYMENT_SUCCESS_WEBHOOK",
        "data": {
            
        }
    }
}
```

`Note:` The `object` in the response is returned as a JSON object. But it can be any of the following types:
- [Payment Webhook](https://docs.cashfree.com/docs/payment-webhooks)
- [Refund Webhook](https://docs.cashfree.com/docs/refunds-webhook)
- [Settlement Webhook](https://docs.cashfree.com/docs/settlements-webhook)
- [Instrument Webhook](https://docs.cashfree.com/docs/instrument-webhook)

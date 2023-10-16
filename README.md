# Cashfree Dotnet API Client

  

Use our Dotnet SDK to integrate the Cashfree Payment Gateway into your application.

  

API version: `2022-09-01` \

Package version: `2.1.0`

  

# Installing our Dotnet SDK

  

Run the following command in the root level of your project.

  

`dotnet add package cashfree-pg-sdk-dotnet --version 2.1.0`

  

`Note:` For other installation modes, visit [here.](https://www.nuget.org/packages/cashfree-pg-sdk-dotnet)

  

### Dependencies

  

1. #### JsonSubTypes (>= 1.8.0)

2. #### Newtonsoft.Json (>= 13.0.1)

3. #### Polly (>= 7.2.2)

4. #### RestSharp (>= 106.13.0)

5. #### Sentry (>= 3.31.0)

6. #### System.ComponentModel.Annotations (>= 5.0.0)

  

---

  

# Importing

  

```csharp

using cashfreepg.Model;

using cashfreepg.Interface;

```

  

---

  

# Create a CFConfig

  

The CFConfig consists of properties such as Client-ID, Client-Secret-Key and some more which are mandatory. An instance of CFConfig is required for all the method calls that are exposed by the SDK. The following is the code snippet to create a CFConfig:-

  

```

var cfConfig = new CFConfig(CFEnvironment.PRODUCTION, "2022-09-01", "<app_id>", "<secret_key>");

  

// CFEnvironment is an enum consisting of PRODUCTION and SANDBOX as 2 possible values.

```

  

`Note:` We can also set "timeout" and "proxy" values in `CFConfig`

  

---

  

# Create a CFHeader

  

The CFHeader type consists of properties that are sent in the headers as part of every request and they are optional values. The following code snippet can be used to create a CFHeader instance :-

  

```

var cfHeader = new CFHeader("request_id", "idempotency_key");

```

---

# Create an Order with Cashfree

  

To process any payment on Cashfree PG, the merchant needs to create an order in the cashfree system. An order can be created using the following code snippet:-

  

```

var customerDetails = new CFCustomerDetails(

customerId: "some_random_id",

customerEmail: "sample@gmail.com",

customerPhone: "9999999999"

);

var orderMeta = new CFOrderMeta(

notifyUrl: "https://merchant.in/pg/process_return?cf_id={order_id}",

returnUrl: "https://merchant.in/pg/process_return?cf_id={order_id}"

);

var cFOrderRequest = new CFOrderRequest(

orderAmount: 1.0,

orderCurrency: "INR",

orderNote: "Some information about the order",

orderMeta: orderMeta,

customerDetails: customerDetails

);

try {

// Create Order

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

  

CFConfig cfConfig = getConfig(); // Create CFConfig as mentioned above

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

CFOrderResponse result = apiInstance.orderCreate(cfConfig, cFOrderRequest, cfHeader);

if(result != null) {

Console.WriteLine(result?.cfOrder?.PaymentSessionId);

Console.WriteLine(result?.cfOrder?.OrderToken); // Will be null in 2022-09-01

Console.WriteLine(result?.cfOrder?.OrderId);

Console.WriteLine(result?.cfOrder?.PaymentLink); // Will be null in 2022-09-01

Console.WriteLine(result?.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

`Note:` For more information about order properties, visit [here](https://docs.cashfree.com/docs/create-order#curl-request)

  

---

  

# Pay Order

  

Once you have created the order, you can use the order to initiate payment. Order creation API returns "payment_session_id" which contains information about the order and that has to be used in payment initiation stage. Cashfree provides multiple payment methods to choose to make payments for an order, namely, UPI, Netbanking, Wallet, Card, Card EMI, Cardless EMI and Pay later.

  

### Pay Order with Card

Below is the code to initiate payment with Card

  

```

var payment_session_id = "";

var customerDetails = new CFCustomerDetails(

customerId: "some_random_id",

customerEmail: "sample@gmail.com",

customerPhone: "9999999999"

);

var orderMeta = new CFOrderMeta(

notifyUrl: "https://merchant.in/pg/process_return?cf_id={order_id}",

returnUrl: "https://merchant.in/pg/process_return?cf_id={order_id}"

);

var cFOrderRequest = new CFOrderRequest(

orderAmount: 1.0,

orderCurrency: "INR",

orderNote: "Some information about the order",

orderMeta: orderMeta,

customerDetails: customerDetails

);

try {

// Create Order

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

  

CFConfig cfConfig = getConfig(); // Create CFConfig as mentioned above

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

CFOrderResponse result = apiInstance.orderCreate(cfConfig, cFOrderRequest, cfHeader);

if(result != null) {

  

// Here we will take the payment_session_id, which will be used for order pay

payment_session_id = result?.cfOrder?.PaymentSessionId

  

Console.WriteLine(result?.cfOrder?.PaymentSessionId);

Console.WriteLine(result?.cfOrder?.OrderId);

Console.WriteLine(result?.cfOrder?.PaymentLink);

Console.WriteLine(result?.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

  

// Order Pay will be initiated here once the token is generated

  

try {

CFCard cFCard = new CFCard("link", "4111111111111111", "test", "12", "25", "123");

CFCardPayment cFCardPayment = new CFCardPayment(cFCard);

  

CFPaymentMethod cFPaymentMethod = new CFPaymentMethod(cFCardPayment);

  

CFOrderPaySessionsRequest CFOrderPaySessionsRequest = new CFOrderPaySessionsRequest(payment_session_id, cFPaymentMethod, null);

  

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

  

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

  

CFPayResponse cfPayResponse = apiInstance.orderPay(cfConfig, CFOrderPaySessionsRequest, cfHeader);

if(cfPayResponse != null) {

Console.WriteLine(cfPayResponse.cfOrderPayResponse.Data.Url);

Console.WriteLine(cfPayResponse.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

`Note:` Order has to be created and then the payment_session_id has to be used to make the payments for all the other payment methods as well. This step is covered in the above example and the same step has to be followed for all other payment methods.

  

### Pay Order with Saved Card

  

Below is the code to initiate payment with Saved Card

  

```

try {

CFCard cFCard = new CFCard(channel: "link", cardCvv: "123", instrumentId: instrument_id);

CFCardPayment cFCardPayment = new CFCardPayment(cFCard);

CFPaymentMethod cFPaymentMethod = new CFPaymentMethod(cFCardPayment);

  

CFOrderPaySessionsRequest CFOrderPaySessionsRequest = new CFOrderPaySessionsRequest(payment_session_id, cFPaymentMethod, null);

  

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

  

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

CFPayResponse cfPayResponse = apiInstance.orderPay(cfConfig, CFOrderPaySessionsRequest, cfHeader);

if(cfPayResponse != null) {

Console.WriteLine(cfPayResponse.cfOrderPayResponse.Data.Url);

Console.WriteLine(cfPayResponse.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

### Pay Order with UPI

  

Below is the code to initiate payment with UPI - `Collect`

  

```

try {

CFUPI cfUpi = new CFUPI("collect", "testsuccess@gocash");

CFUPIPayment cFUPIPayment = new CFUPIPayment(cfUpi);

CFPaymentMethod cFPaymentMethod = new CFPaymentMethod(cFUPIPayment);

CFOrderPaySessionsRequest CFOrderPaySessionsRequest = new CFOrderPaySessionsRequest(Product.payment_session_id, cFPaymentMethod, null);

  

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

  

CFPayResponse cfPayResponse = apiInstance.orderPay(cfConfig, CFOrderPaySessionsRequest, null);

if(cfPayResponse != null) {

Console.WriteLine(cfPayResponse.cfOrderPayResponse.Data);

Console.WriteLine(cfPayResponse.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

Below is the code to initiate payment with UPI - `Intent`

  

```

try {

CFUPI cfUpi = new CFUPI("link");

CFUPIPayment cFUPIPayment = new CFUPIPayment(cfUpi);

CFPaymentMethod cFPaymentMethod = new CFPaymentMethod(cFUPIPayment);

CFOrderPaySessionsRequest CFOrderPaySessionsRequest = new CFOrderPaySessionsRequest(Product.payment_session_id, cFPaymentMethod, null);

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

  

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

CFPayResponse cfPayResponse = apiInstance.orderPay(cfConfig, CFOrderPaySessionsRequest, null);

if(cfPayResponse != null) {

Console.WriteLine(cfPayResponse.cfOrderPayResponse.Data);

Console.WriteLine(cfPayResponse.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

Below is the code to initiate payment with UPI - `QRCode`

  

```

try {

CFUPI cfUpi = new CFUPI("qrcode");

CFUPIPayment cFUPIPayment = new CFUPIPayment(cfUpi);

CFPaymentMethod cFPaymentMethod = new CFPaymentMethod(cFUPIPayment);

CFOrderPaySessionsRequest CFOrderPaySessionsRequest = new CFOrderPaySessionsRequest(Product.payment_session_id, cFPaymentMethod, null);

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

  

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

CFPayResponse cfPayResponse = apiInstance.orderPay(cfConfig, CFOrderPaySessionsRequest, null);

if(cfPayResponse != null) {

Console.WriteLine(cfPayResponse.cfOrderPayResponse.Data);

Console.WriteLine(cfPayResponse.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

### Pay Order with Netbanking

  

Below is the code to initiate payment with Netbanking

  

```

try {

CFNetbanking cfnetBanking = new CFNetbanking("link", 3003);

CFNetbankingPayment cFNetbankingPayment = new CFNetbankingPayment(cfnetBanking);

CFPaymentMethod cFPaymentMethod = new CFPaymentMethod(cFNetbankingPayment);

CFOrderPaySessionsRequest CFOrderPaySessionsRequest = new CFOrderPaySessionsRequest(Product.payment_session_id, cFPaymentMethod, null);

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

CFPayResponse cfPayResponse = apiInstance.orderPay(cfConfig, CFOrderPaySessionsRequest, null);

if(cfPayResponse != null) {

Console.WriteLine(cfPayResponse.cfOrderPayResponse.Data.Url);

Console.WriteLine(cfPayResponse.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

`Note:` For all bank codes, visit [here](https://docs.cashfree.com/docs/net-banking)

  

### Pay Order with App (Wallet)

  

Below is the code to initiate payment with App (Wallet)

  

```

try {

CFApp cfApp = new CFApp("phonepe", "8904216227", "link");

CFAppPayment cFAppPayment = new CFAppPayment(cfApp);

CFPaymentMethod cFPaymentMethod = new CFPaymentMethod(cFAppPayment);

CFOrderPaySessionsRequest CFOrderPaySessionsRequest = new CFOrderPaySessionsRequest(Product.payment_session_id, cFPaymentMethod, null);

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

  

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

CFPayResponse cfPayResponse = apiInstance.orderPay(cfConfig, CFOrderPaySessionsRequest, null);

if(cfPayResponse != null) {

Console.WriteLine(cfPayResponse.cfOrderPayResponse.Data.Url);

Console.WriteLine(cfPayResponse.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

`Note:` Below is the list of all values for all the wallet providers supported by Cashfree:- `phonepe` `paytm` `amazon` `airtel` `freecharge` `mobikwik` `jio` `ola`

  

### Pay Order with Paylater

  

Below is the code to initiate payment with Paylater

  

```

try {

CFPaylater cfPaylater = new CFPaylater("link", "lazypay", "9999999999");

CFPaylaterPayment cFPaylaterPayment = new CFPaylaterPayment(cfPaylater);

CFPaymentMethod cFPaymentMethod = new CFPaymentMethod(cFPaylaterPayment);

CFOrderPaySessionsRequest CFOrderPaySessionsRequest = new CFOrderPaySessionsRequest(Product.payment_session_id, cFPaymentMethod, null);

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

  

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

CFPayResponse cfPayResponse = apiInstance.orderPay(cfConfig, CFOrderPaySessionsRequest, null);

if(cfPayResponse != null) {

Console.WriteLine(cfPayResponse.cfOrderPayResponse.Data.Url);

Console.WriteLine(cfPayResponse.cfHeaders);

}

}

catch (ApiException e)

{

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

`Note:` Currently we support `kotak`, `flexipay`, `zestmoney`, `lazypay`, `olapostpaid`

  

### Get Order

  

The details and status of the order can be fetched using this API. Below is the code snippet to retrieve order using `order_id`

  

```

try {

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

CFOrderResponse cfOrderResponse = apiInstance.getOrder(cfConfig, order_id, null);

if(cfOrderResponse != null) {

Console.WriteLine(cfOrderResponse.cfOrder.OrderId);

Console.WriteLine(cfOrderResponse.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

### Get Payments For An Order

  

Once the payment process is initiated, all the payment information for a particular order can be retrieved through this API. Below is the code snippet to retrieve payments for a particular order.

  

```

try {

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

var response = apiInstance.getPaymentsForOrder(cfConfig, order_id, null);

if(response != null) {

Console.WriteLine(response?.cfPaymentsEntities?[0].CfPaymentId);

Console.WriteLine(response?.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

### Get Payment By CFPaymentID

  

Payment information can be retrieved using a unique ID generated by Cashfree (CFPaymentID). We can find get this ID from `GetOrder` API and can be used here to fetch Payment Information. Below is the code snippet to fetch Payment Information.

  

```

try {

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

CFPaymentEntityResponse response = apiInstance.getPaymentsByPaymentID(cfConfig, order_id, cf_payment_id, null);

if(response != null) {

Console.WriteLine(response?.cfPaymentsEntity?.PaymentStatus);

Console.WriteLine(response?.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

### Create Payment Links

  

A Payment link can be created and shared with users through `email` or `sms`. Below is the code snippet to create a payment link.

  

```

try {

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

  

var customerDetails = new CFLinkCustomerDetailsEntity("9999999999", "sample@gmail.com", "Sample Customer");

var linkNotify = new CFLinkNotifyEntity(true, true);

CFLinkRequest cFLinkRequest = new CFLinkRequest("link_id_02", 1, "INR", "TESTING", customerDetails, false, null, null, linkNotify, false, null, null);

var response = apiInstance.createPaymentLink(cfConfig, cFLinkRequest, null);

if(response != null) {

Console.WriteLine(response?.cfLink?.LinkUrl);

Console.WriteLine(response?.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

### Get Payment Links By LinkID

  

A Payment link which was created can be retrieved using this API by specifying the `LinkID`. Below is the code snippet to get the payment link information.

  

```

try {

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

var response = apiInstance.getPaymentLinkDetails(cfConfig, linkID, null);

if(response != null) {

Console.WriteLine(response?.cfLink?.LinkAmount);

Console.WriteLine(response?.cfLink?.LinkId == "link_id_02");

Console.WriteLine(response?.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

### Get Orders By LinkID

  

All the orders created using links can be fetched using linkID by using this API. Below is the code snippet to get all the orders associated with the linkID.

  

```

try {

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

var response = apiInstance.getPaymentLinkOrders(cfConfig, linkID, null);

if(response != null) {

Console.WriteLine(response?.cfLinkOrders.Count);

Console.WriteLine(response?.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

### Initiate Refund

  

Amount associated with a particular orderID where the transaction has gone through can be refunded using this API. Below is the code snippet to initiate the refund.

  

```

try {

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

  

CFRefundRequest cfRefundRequest = new CFRefundRequest(refundAmount, refundId, "Testing from dotnet", null);

  

CFRefundResponse response = apiInstance.createRefund(cfConfig, order_id_for_refund, cfRefundRequest, null);

if(response != null) {

Console.WriteLine(response.cfRefund.RefundAmount);

Console.WriteLine(response.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

### Fetch Refund Information

  

Once the refund is initiated, we can check the status of that refund using this API. Below is the code snippet to check refund information.

  

```

try {

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

  

var response = apiInstance.getRefund(cfConfig, order_id_for_refund, refundId, null);

if(response != null) {

Console.WriteLine(response?.cfRefund?.RefundAmount);

Console.WriteLine(response?.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

### Get Settlements

  

Below is the code snippet to retrieve order settlement information

  

```

try {

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

  

var response = apiInstance.getSettlements(cfConfig, order_id_for_refund, null);

if(response != null) {

Console.WriteLine(response?.cfSettlementsEntity.OrderAmount);

Console.WriteLine(response?.cfHeaders);

}

} catch (ApiException e) {

  

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

### Get Saved Instruments By Customer ID

  

Saved instrument information can be retrieved using this API. Below is the code snippet to retrieve instrument information.

  

```

try {

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

  

var response = apiInstance.getAllSavedInstruments(cfConfig, customerId, "card", null);

if(response != null) {

Console.WriteLine(response?.cfInstruments[0].InstrumentId);

Console.WriteLine(response?.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

### Get Instrument by Instrument ID

  

Saved instrument information can be retrieved using this API by using the instrument ID. Below is the code snippet to retrieve instrument information.

  

```

try {

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

  

var response = apiInstance.getSavedInstrumentById(cfConfig, customerId, instrument_id, null);

if(response != null) {

Console.WriteLine(response?.cfInstrument.InstrumentId);

Console.WriteLine(response?.cfInstrument.InstrumentDisplay);

Console.WriteLine(response?.cfInstrument.InstrumentMeta.CardBankName);

Console.WriteLine(response?.cfInstrument.InstrumentMeta.CardNetwork);

Console.WriteLine(response?.cfInstrument.InstrumentMeta.CardType);

Console.WriteLine(response?.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

  

### Get Instrument Cryptogram by Instrument ID

  

Saved instrument's Cryptogram information can be retrieved using this API by using the instrument ID. Below is the code snippet to retrieve the same.

  

```

try {

CFPaymentGateway apiInstance = CFPaymentGateway.getInstance;

CFConfig cfConfig = getConfig();

CFHeader cfHeader = getHeader(); // Create CFHeader as mentioned above

var response = apiInstance.getCryptogramByInstrumentID(cfConfig, customerId, instrument_id, null);

if(response != null) {

Console.WriteLine(response?.cfCryptogram.InstrumentId);

Console.WriteLine(response?.cfCryptogram.Cryptogram);

Console.WriteLine(response?.cfHeaders);

}

} catch (ApiException e) {

Console.WriteLine("Status Code: "+ e.ErrorCode);

Console.WriteLine(e.StackTrace);

if(e.cFError != null) {

Console.WriteLine(e.cFError.Message);

}

}

```

## Support

  

### Ask a question about Integration

  

You can ask questions, and participate in discussions about Cashfree-related topics ian the Cashfree Discord channel.

  

<a href="https://discord.gg/VsNDrd7ng5"><img src="https://cashfreelogo.cashfree.com/discord_banner_purple.svg" /></a>
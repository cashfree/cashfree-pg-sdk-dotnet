# Cashfree PG .Net SDK
![GitHub](https://img.shields.io/github/license/cashfree/cashfree-pg-sdk-dotnet) ![Discord](https://img.shields.io/discord/931125665669972018?label=discord) ![GitHub last commit (branch)](https://img.shields.io/github/last-commit/cashfree/cashfree-pg-sdk-dotnet/master) ![GitHub release (with filter)](https://img.shields.io/github/v/release/cashfree/cashfree-pg-sdk-dotnet?label=latest) ![GitHub forks](https://img.shields.io/github/forks/cashfree/cashfree-pg-sdk-go)

The Cashfree PG .Net SDK offers a convenient solution to access [Cashfree PG APIs](https://docs.cashfree.com/reference/pg-new-apis-endpoint) from a server-side .Net  applications. 



## Documentation

Cashfree's PG API Documentation - https://docs.cashfree.com/reference/pg-new-apis-endpoint

Learn and understand payment gateway workflows at Cashfree Payments [here](https://docs.cashfree.com/docs/payment-gateway)

Try out our interactive guides at [Cashfree Labs](https://labs.cashfree.com/) !

## Getting Started

### Installation
```bash
dotnet add package cashfree_pg
```
### Configuration

```csharp 
using cashfree_pg.Client;
using cashfree_pg.Model;

Cashfree.XClientId = "<x-client-id>";
Cashfree.XClientSecret = "<x-client-secret>";
Cashfree.XEnvironment = Cashfree.SANDBOX;
var cashfree = new Cashfree();
var xApiVersion = "2022-09-01";
```

Generate your API keys (x-client-id , x-client-secret) from [Cashfree Merchant Dashboard](https://merchant.cashfree.com/merchants/login)

### Basic Usage
Create Order
```csharp
var customerDetails = new CustomerDetails("123", null, "9999999999");
var createOrdersRequest = new CreateOrderRequest(null, 1.0, "INR", customerDetails);
try {
    // Create Order
    var result = cashfree.PGCreateOrder(xApiVersion, createOrdersRequest, null, null, null);
    Console.WriteLine(result);
    Console.WriteLine(result.StatusCode);
    Console.WriteLine((result.Content as OrderEntity));
} catch (ApiException e) {
    Console.WriteLine("Exception when calling PGCreateOrder: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

Get Order
```csharp
try {
    var result = cashfree.PGFetchOrder(xApiVersion, "<order_id>>", null, null);
    Console.WriteLine(result);
    Console.WriteLine(result.StatusCode);
    Console.WriteLine((result.Content as OrderEntity));
} catch (ApiException e) {
    Console.WriteLine("Exception when calling PGFetchOrder: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

## Licence

Apache Licensed. See [LICENSE.md](LICENSE.md) for more details
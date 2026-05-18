# cashfree-dotnet-pg-sdk.Model.TerminalFilters
Use this object to filter terminal transactions based on various criteria.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartDate** | **string** | Start date and time for transaction filtering. Use ISO8601 format  (example: 2021-07-02T10:20:12+05:30 for IST, 2021-07-02T10:20:12Z for UTC). | [optional] 
**EndDate** | **string** | End date and time for transaction filtering. Use ISO8601 format  (example: 2021-07-02T10:20:12+05:30 for IST, 2021-07-02T10:20:12Z for UTC). | [optional] 
**CfTerminalId** | **long** | Unique Cashfree terminal identifier. | [optional] 
**TerminalVpa** | **string** | Virtual payment address (VPA) associated with the terminal. | [optional] 
**TerminalPhoneNo** | **string** | Mobile phone number registered with the terminal. | [optional] 
**PaymentStatus** | **string** | Payment transaction status. Possible values are SUCCESS, FAILED, or PENDING. | [optional] 
**PaymentGroup** | **string** | Payment method group (for example, UPI, CARD, NET_BANKING). | [optional] 
**SortBy** | **string** | Field to sort results by. Currently supports sorting by start_date. | [optional] 
**SortOrder** | **string** | Sort order for the results. Use ASC for ascending or DESC for descending order. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


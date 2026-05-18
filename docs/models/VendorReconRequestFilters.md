# cashfree-dotnet-pg-sdk.Model.VendorReconRequestFilters
Specify the filters for the desired use case.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SettlementId** | **int** | Specify the Settlement ID for which you want to fetch the order details. Relevant for \&quot;View Split Order Details Using Settlement ID\&quot;. | [optional] 
**MerchantVendorId** | **string** | Specify the Vendor ID for which you want to fetch the recon details. Relevant for \&quot;Vendor Recon Using Vendor ID &amp; Time Interval\&quot;. | [optional] 
**StartDate** | **string** | Start date for fetching reconciliation details. Relevant for \&quot;Vendor Recon for a Time Period\&quot; and \&quot;Vendor Recon Using Vendor ID &amp; Time Interval\&quot;. | [optional] 
**EndDate** | **string** | End date for fetching reconciliation details. Relevant for \&quot;Vendor Recon for a Time Period\&quot; and \&quot;Vendor Recon Using Vendor ID &amp; Time Interval\&quot;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


# cashfree-dotnet-pg-sdk.Model.VendorSplit
Use to split order when cashfree's Easy Split is enabled for your account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VendorId** | **string** | Vendor id created in Cashfree system. | [optional] 
**Amount** | **decimal** | Amount which will be associated with this vendor. | [optional] 
**Percentage** | **decimal** | Percentage of order amount which shall get added to vendor account. | [optional] 
**Tags** | **Dictionary&lt;string, Object&gt;** | Custom Tags in the form of {\&quot;key\&quot;:\&quot;value\&quot;} which can be passed for an order. A maximum of 10 tags can be added. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


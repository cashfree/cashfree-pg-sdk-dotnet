# cashfree_pg.Model.VendorSplit
Use to split order when cashfree's Easy Split is enabled for your account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**vendor_id** | **string** | Vendor id created in Cashfree system | [optional] 
**amount** | **decimal?** | Amount which will be associated with this vendor | [optional] 
**percentage** | **decimal?** | Percentage of order amount which shall get added to vendor account | [optional] 
**tags** | **Dictionary&lt;string, Object&gt;** | Custom Tags in thr form of {\&quot;key\&quot;:\&quot;value\&quot;} which can be passed for an order. A maximum of 10 tags can be added | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


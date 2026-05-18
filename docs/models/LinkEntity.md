# cashfree-dotnet-pg-sdk.Model.LinkEntity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CfLinkId** | **string** |  | [optional] 
**LinkId** | **string** |  | [optional] 
**LinkStatus** | **string** |  | [optional] 
**LinkCurrency** | **string** |  | [optional] 
**LinkAmount** | **decimal** |  | [optional] 
**LinkAmountPaid** | **decimal** |  | [optional] 
**LinkPartialPayments** | **bool** |  | [optional] 
**LinkMinimumPartialAmount** | **decimal** |  | [optional] 
**LinkPurpose** | **string** |  | [optional] 
**LinkCreatedAt** | **string** |  | [optional] 
**CustomerDetails** | [**LinkCustomerDetailsEntity**](LinkCustomerDetailsEntity.md) |  | [optional] 
**LinkMeta** | [**LinkMetaResponseEntity**](LinkMetaResponseEntity.md) |  | [optional] 
**LinkUrl** | **string** |  | [optional] 
**LinkExpiryTime** | **string** |  | [optional] 
**LinkNotes** | **Dictionary&lt;string, string&gt;** | Key-value pair that can be used to store additional information about the entity. Maximum 5 key-value pairs. | [optional] 
**LinkAutoReminders** | **bool** |  | [optional] 
**LinkNotify** | [**LinkNotifyEntity**](LinkNotifyEntity.md) |  | [optional] 
**LinkQrcode** | **string** | Base64 encoded string for payment link. You can scan with camera to open a link in the browser to complete the payment. | [optional] 
**OrderSplits** | [**List&lt;VendorSplit&gt;**](VendorSplit.md) |  | [optional] 
**Subscription** | [**LinkSubscriptionEntity**](LinkSubscriptionEntity.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


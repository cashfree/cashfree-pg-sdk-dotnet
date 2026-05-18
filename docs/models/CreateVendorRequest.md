# cashfree-dotnet-pg-sdk.Model.CreateVendorRequest
Create Vendor Request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VendorId** | **string** | Specify the unique Vendor ID to identify the beneficiary. Alphanumeric and underscore (_) allowed. | 
**Status** | **string** | Specify the status of vendor that should be updated. Possible values: ACTIVE,BLOCKED, DELETED. | 
**Name** | **string** | Specify the name of the vendor to be updated. Name should not have any special character except . / - &amp;. | 
**Email** | **string** | Specify the vendor email ID that should be updated. String in email ID format (Ex:johndoe_1@cashfree.com) should contain @ and dot (.). | 
**Phone** | **string** | Specify the beneficiaries phone number to be updated. Phone number registered in India (only digits, 8 - 12 characters after excluding +91). | 
**KycDetails** | [**KycDetails**](KycDetails.md) |  | 
**VerifyAccount** | **bool** | Specify if the vendor bank account details should be verified. Possible values: true or false. | [optional] 
**DashboardAccess** | **bool** | Update if the vendor will have dashboard access or not. Possible values are: true or false. | [optional] 
**ScheduleOption** | **decimal** | Specify the settlement cycle to be updated. View the settlement cycle details from the \&quot;Settlement Cycles Supported\&quot; table. If no schedule option is configured, the settlement cycle ID \&quot;1\&quot; will be in effect. Select \&quot;8\&quot; or \&quot;9\&quot; if you want to schedule instant vendor settlements. | [optional] 
**Bank** | [**BankDetails**](BankDetails.md) |  | [optional] 
**Upi** | [**UpiDetails**](UpiDetails.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


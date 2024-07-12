# cashfree_pg.Model.CreateVendorRequest
Create Vendor Request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**vendor_id** | **string** | Specify the unique Vendor ID to identify the beneficiary. Alphanumeric and underscore (_) allowed. | 
**status** | **string** | Specify the status of vendor that should be updated. Possible values: ACTIVE,BLOCKED, DELETED | 
**name** | **string** | Specify the name of the vendor to be updated. Name should not have any special character except . / - &amp; | 
**email** | **string** | Specify the vendor email ID that should be updated. String in email ID format (Ex:johndoe_1@cashfree.com) should contain @ and dot (.) | 
**phone** | **string** | Specify the beneficiaries phone number to be updated. Phone number registered in India (only digits, 8 - 12 characters after excluding +91). | 
**verify_account** | **bool** | Specify if the vendor bank account details should be verified. Possible values: true or false | [optional] 
**dashboard_access** | **bool** | Update if the vendor will have dashboard access or not. Possible values are: true or false | [optional] 
**schedule_option** | **decimal** | Specify the settlement cycle to be updated. View the settlement cycle details from the \&quot;Settlement Cycles Supported\&quot; table.  If no schedule option is configured, the settlement cycle ID \&quot;1\&quot; will be in effect. Select \&quot;8\&quot; or \&quot;9\&quot; if you want to schedule instant vendor settlements. | [optional] 
**bank** | [**List&lt;BankDetails&gt;**](BankDetails.md) | Specify the vendor bank account details to be updated. | [optional] 
**upi** | [**List&lt;UpiDetails&gt;**](UpiDetails.md) | Updated beneficiary upi vpa. Alphanumeric, dot (.), hyphen (-), at sign (@), and underscore allowed (100 character limit). Note: underscore and dot (.) gets accepted before and after @, but hyphen (-) is only accepted before @ sign. | [optional] 
**kyc_details** | [**List&lt;KycDetails&gt;**](KycDetails.md) | Specify the kyc details that should be updated. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


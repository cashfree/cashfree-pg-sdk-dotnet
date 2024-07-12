# cashfree_pg.Model.CardlessEMI
Request body for cardless emi payment method

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**channel** | **string** | The channel for cardless EMI is always &#x60;link&#x60; | [optional] 
**provider** | **string** | One of [&#x60;flexmoney&#x60;, &#x60;zestmoney&#x60;, &#x60;hdfc&#x60;, &#x60;icici&#x60;, &#x60;cashe&#x60;, &#x60;idfc&#x60;, &#x60;kotak&#x60;, &#x60;snapmint&#x60;, &#x60;bharatx&#x60;] | [optional] 
**phone** | **string** | Customers phone number for this payment instrument. If the customer is not eligible you will receive a 400 error with type as &#39;invalid_request_error&#39; and code as &#39;invalid_request_error&#39; | [optional] 
**emi_tenure** | **int** | EMI tenure for the selected provider. This is mandatory when provider is one of [&#x60;hdfc&#x60;, &#x60;icici&#x60;, &#x60;cashe&#x60;, &#x60;idfc&#x60;, &#x60;kotak&#x60;] | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


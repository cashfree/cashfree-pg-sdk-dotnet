# cashfree_pg.Model.UploadVendorDocsRequest
Update Vendor Request

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**doc_type** | **string** | Mention the type of the document you are uploading. Possible values: UIDAI_FRONT, UIDAI_BACK, UIDAI_NUMBER, DL, DL_NUMBER, PASSPORT_FRONT, PASSPORT_BACK, PASSPORT_NUMBER, VOTER_ID, VOTER_ID_NUMBER, PAN, PAN_NUMBER, GST, GSTIN_NUMBER, CIN, CIN_NUMBER, NBFC_CERTIFICATE. If the doc type ends with a number you should add the doc value else upload the doc file. | [optional] 
**doc_value** | **System.IO.Stream** | Enter the display name of the uploaded file. | [optional] 
**file** | **string** | Select the document that should be uploaded or provide the path of that file. You cannot upload a file that is more than 2MB in size. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# cashfree_pg.Model.TerminateOrderRequest
Request to terminate an active order at Cashfree

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**order_status** | **string** | To terminate an order, pass order_status as \&quot;TERMINATED\&quot;. Please note, order might not be terminated - confirm with the order_status in response. \&quot;TERMINATION_REQUESTED\&quot; states that the request is recieved and we are working on it. If the order terminates successfully, status will change to \&quot;TERMINATED\&quot;. Incase there&#39;s any active transaction which moved to success - order might not get terminated. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


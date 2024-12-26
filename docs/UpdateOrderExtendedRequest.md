# cashfree_pg.Model.UpdateOrderExtendedRequest
Request Body to Update extended data related to order

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**shipment_details** | [**List&lt;ShipmentDetails&gt;**](ShipmentDetails.md) | Shipment details, such as the tracking company, tracking number, and tracking URLs, associated with the shipping of an order. Either &#x60;shipment_details&#x60; or &#x60;order_delivery_status&#x60; is required. | 
**order_delivery_status** | [**OrderDeliveryStatus**](OrderDeliveryStatus.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


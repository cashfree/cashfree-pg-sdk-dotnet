/*
 * Cashfree Payment Gateway APIs
 *
 * Cashfree's Payment Gateway APIs provide developers with a streamlined pathway to integrate advanced payment processing capabilities into their applications, platforms and websites.
 *
 * The version of the OpenAPI document: 2023-08-01
 * Contact: developers@cashfree.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = cashfree_pg.Client.OpenAPIDateConverter;

namespace cashfree_pg.Model
{
    /// <summary>
    /// Request Body to Update extended data related to order
    /// </summary>
    [DataContract(Name = "UpdateOrderExtendedRequest")]
    public class UpdateOrderExtendedRequest : IEquatable<UpdateOrderExtendedRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrderExtendedRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateOrderExtendedRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateOrderExtendedRequest" /> class.
        /// </summary>
        /// <param name="shipmentDetails">Shipment details, such as the tracking company, tracking number, and tracking URLs, associated with the shipping of an order. Either &#x60;shipment_details&#x60; or &#x60;order_delivery_status&#x60; is required. (required).</param>
        /// <param name="orderDeliveryStatus">orderDeliveryStatus.</param>
        public UpdateOrderExtendedRequest(List<ShipmentDetails> shipmentDetails = default(List<ShipmentDetails>), OrderDeliveryStatus? orderDeliveryStatus = default(OrderDeliveryStatus?))
        {
            // to ensure "shipmentDetails" is required (not null)
            if (shipmentDetails == null)
            {
                throw new ArgumentNullException("shipmentDetails is a required property for UpdateOrderExtendedRequest and cannot be null");
            }
            this.shipment_details = shipmentDetails;
            this.order_delivery_status = orderDeliveryStatus;
        }

        /// <summary>
        /// Shipment details, such as the tracking company, tracking number, and tracking URLs, associated with the shipping of an order. Either &#x60;shipment_details&#x60; or &#x60;order_delivery_status&#x60; is required.
        /// </summary>
        /// <value>Shipment details, such as the tracking company, tracking number, and tracking URLs, associated with the shipping of an order. Either &#x60;shipment_details&#x60; or &#x60;order_delivery_status&#x60; is required.</value>
        [DataMember(Name = "shipment_details", IsRequired = true, EmitDefaultValue = true)]
        public List<ShipmentDetails> shipment_details { get; set; }

        /// <summary>
        /// Gets or Sets order_delivery_status
        /// </summary>
        [DataMember(Name = "order_delivery_status", EmitDefaultValue = false)]
        public OrderDeliveryStatus? order_delivery_status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateOrderExtendedRequest {\n");
            sb.Append("  shipment_details: ").Append(shipment_details).Append("\n");
            sb.Append("  order_delivery_status: ").Append(order_delivery_status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateOrderExtendedRequest);
        }

        /// <summary>
        /// Returns true if UpdateOrderExtendedRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateOrderExtendedRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateOrderExtendedRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.shipment_details == input.shipment_details ||
                    this.shipment_details != null &&
                    input.shipment_details != null &&
                    this.shipment_details.SequenceEqual(input.shipment_details)
                ) && 
                (
                    this.order_delivery_status == input.order_delivery_status ||
                    (this.order_delivery_status != null &&
                    this.order_delivery_status.Equals(input.order_delivery_status))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringshipment_details) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringshipment_details);
            if (deserializedJsonString.ContainsKey("shipment_details")) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.shipment_details != null)
                {
                    hashCode = (hashCode * 59) + this.shipment_details.GetHashCode();
                }
                if (this.order_delivery_status != null)
                {
                    hashCode = (hashCode * 59) + this.order_delivery_status.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
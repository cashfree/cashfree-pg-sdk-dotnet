/*
 * New Payment Gateway APIs
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2022-01-01
 * Contact: nextgenapi@cashfree.com
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
using OpenAPIDateConverter = cashfreepg.Client.OpenAPIDateConverter;

namespace cashfreepg.Model
{
    /// <summary>
    /// CFOrderRequest
    /// </summary>
    [DataContract(Name = "CFOrderRequest")]
    public partial class CFOrderRequest : IEquatable<CFOrderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFOrderRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CFOrderRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CFOrderRequest" /> class.
        /// </summary>
        /// <param name="orderId">Order identifier present in your system. Alphanumeric and only - and _ allowed..</param>
        /// <param name="orderAmount">Bill amount for the order. Provide upto two decimals. 10.15 means Rs 10 and 15 paisa (required).</param>
        /// <param name="orderCurrency">Currency for the order. INR if left empty. Contact care@cashfree.com to enable new currencies.  (required).</param>
        /// <param name="customerDetails">customerDetails (required).</param>
        /// <param name="orderMeta">orderMeta.</param>
        /// <param name="orderExpiryTime">Time after which the order expires. Customers will not be able to make the payment beyond the time specified here. We store timestamps in IST, but you can provide them in a valid ISO 8601 time format..</param>
        /// <param name="orderNote">Order note for reference..</param>
        /// <param name="orderTags">Custom Tags which can be passed for an order. A maximum of 6 tags can be added.</param>
        /// <param name="orderSplits">orderSplits.</param>
        public CFOrderRequest(string? orderId = default(string?), double? orderAmount = default(double?), string? orderCurrency = default(string?), CFCustomerDetails? customerDetails = default(CFCustomerDetails?), CFOrderMeta? orderMeta = default(CFOrderMeta?), string? orderExpiryTime = default(string?), string? orderNote = default(string?), Dictionary<string, string>? orderTags = default(Dictionary<string, string>?), List<CFVendorSplit>? orderSplits = default(List<CFVendorSplit>?))
        {
            this.OrderAmount = orderAmount;
            // to ensure "orderCurrency" is required (not null)
            if (orderCurrency == null) {
                throw new ArgumentNullException("orderCurrency is a required property for CFOrderRequest and cannot be null");
            }
            this.OrderCurrency = orderCurrency;
            // to ensure "customerDetails" is required (not null)
            if (customerDetails == null) {
                throw new ArgumentNullException("customerDetails is a required property for CFOrderRequest and cannot be null");
            }
            this.CustomerDetails = customerDetails;
            this.OrderId = orderId;
            this.OrderMeta = orderMeta;
            this.OrderExpiryTime = orderExpiryTime;
            this.OrderNote = orderNote;
            this.OrderTags = orderTags;
            this.OrderSplits = orderSplits;
        }

        /// <summary>
        /// Order identifier present in your system. Alphanumeric and only - and _ allowed.
        /// </summary>
        /// <value>Order identifier present in your system. Alphanumeric and only - and _ allowed.</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string? OrderId { get; set; }

        /// <summary>
        /// Bill amount for the order. Provide upto two decimals. 10.15 means Rs 10 and 15 paisa
        /// </summary>
        /// <value>Bill amount for the order. Provide upto two decimals. 10.15 means Rs 10 and 15 paisa</value>
        [DataMember(Name = "order_amount", IsRequired = true, EmitDefaultValue = false)]
        public double? OrderAmount { get; set; }

        /// <summary>
        /// Currency for the order. INR if left empty. Contact care@cashfree.com to enable new currencies. 
        /// </summary>
        /// <value>Currency for the order. INR if left empty. Contact care@cashfree.com to enable new currencies. </value>
        [DataMember(Name = "order_currency", IsRequired = true, EmitDefaultValue = false)]
        public string? OrderCurrency { get; set; }

        /// <summary>
        /// Gets or Sets CustomerDetails
        /// </summary>
        [DataMember(Name = "customer_details", IsRequired = true, EmitDefaultValue = false)]
        public CFCustomerDetails? CustomerDetails { get; set; }

        /// <summary>
        /// Gets or Sets OrderMeta
        /// </summary>
        [DataMember(Name = "order_meta", EmitDefaultValue = false)]
        public CFOrderMeta? OrderMeta { get; set; }

        /// <summary>
        /// Time after which the order expires. Customers will not be able to make the payment beyond the time specified here. We store timestamps in IST, but you can provide them in a valid ISO 8601 time format.
        /// </summary>
        /// <value>Time after which the order expires. Customers will not be able to make the payment beyond the time specified here. We store timestamps in IST, but you can provide them in a valid ISO 8601 time format.</value>
        [DataMember(Name = "order_expiry_time", EmitDefaultValue = false)]
        public string? OrderExpiryTime { get; set; }

        /// <summary>
        /// Order note for reference.
        /// </summary>
        /// <value>Order note for reference.</value>
        [DataMember(Name = "order_note", EmitDefaultValue = false)]
        public string? OrderNote { get; set; }

        /// <summary>
        /// Custom Tags which can be passed for an order. A maximum of 6 tags can be added
        /// </summary>
        /// <value>Custom Tags which can be passed for an order. A maximum of 6 tags can be added</value>
        [DataMember(Name = "order_tags", EmitDefaultValue = false)]
        public Dictionary<string, string>? OrderTags { get; set; }

        /// <summary>
        /// Gets or Sets OrderSplits
        /// </summary>
        [DataMember(Name = "order_splits", EmitDefaultValue = false)]
        public List<CFVendorSplit>? OrderSplits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CFOrderRequest {\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OrderAmount: ").Append(OrderAmount).Append("\n");
            sb.Append("  OrderCurrency: ").Append(OrderCurrency).Append("\n");
            sb.Append("  CustomerDetails: ").Append(CustomerDetails).Append("\n");
            sb.Append("  OrderMeta: ").Append(OrderMeta).Append("\n");
            sb.Append("  OrderExpiryTime: ").Append(OrderExpiryTime).Append("\n");
            sb.Append("  OrderNote: ").Append(OrderNote).Append("\n");
            sb.Append("  OrderTags: ").Append(OrderTags).Append("\n");
            sb.Append("  OrderSplits: ").Append(OrderSplits).Append("\n");
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
        public override bool Equals(object? input)
        {
            return this.Equals(input as CFOrderRequest);
        }

        /// <summary>
        /// Returns true if CFOrderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CFOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CFOrderRequest? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.OrderAmount == input.OrderAmount ||
                    this.OrderAmount.Equals(input.OrderAmount)
                ) && 
                (
                    this.OrderCurrency == input.OrderCurrency ||
                    (this.OrderCurrency != null &&
                    this.OrderCurrency.Equals(input.OrderCurrency))
                ) && 
                (
                    this.CustomerDetails == input.CustomerDetails ||
                    (this.CustomerDetails != null &&
                    this.CustomerDetails.Equals(input.CustomerDetails))
                ) && 
                (
                    this.OrderMeta == input.OrderMeta ||
                    (this.OrderMeta != null &&
                    this.OrderMeta.Equals(input.OrderMeta))
                ) && 
                (
                    this.OrderExpiryTime == input.OrderExpiryTime ||
                    (this.OrderExpiryTime != null &&
                    this.OrderExpiryTime.Equals(input.OrderExpiryTime))
                ) && 
                (
                    this.OrderNote == input.OrderNote ||
                    (this.OrderNote != null &&
                    this.OrderNote.Equals(input.OrderNote))
                ) && 
                (
                    this.OrderTags == input.OrderTags ||
                    this.OrderTags != null &&
                    input.OrderTags != null &&
                    this.OrderTags.SequenceEqual(input.OrderTags)
                ) && 
                (
                    this.OrderSplits == input.OrderSplits ||
                    this.OrderSplits != null &&
                    input.OrderSplits != null &&
                    this.OrderSplits.SequenceEqual(input.OrderSplits)
                );
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
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OrderAmount.GetHashCode();
                if (this.OrderCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.OrderCurrency.GetHashCode();
                }
                if (this.CustomerDetails != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerDetails.GetHashCode();
                }
                if (this.OrderMeta != null)
                {
                    hashCode = (hashCode * 59) + this.OrderMeta.GetHashCode();
                }
                if (this.OrderExpiryTime != null)
                {
                    hashCode = (hashCode * 59) + this.OrderExpiryTime.GetHashCode();
                }
                if (this.OrderNote != null)
                {
                    hashCode = (hashCode * 59) + this.OrderNote.GetHashCode();
                }
                if (this.OrderTags != null)
                {
                    hashCode = (hashCode * 59) + this.OrderTags.GetHashCode();
                }
                if (this.OrderSplits != null)
                {
                    hashCode = (hashCode * 59) + this.OrderSplits.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // OrderId (string) maxLength
            if (this.OrderId != null && this.OrderId.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OrderId, length must be less than 45.", new [] { "OrderId" });
            }

            // OrderId (string) minLength
            if (this.OrderId != null && this.OrderId.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OrderId, length must be greater than 3.", new [] { "OrderId" });
            }

            // OrderNote (string) maxLength
            if (this.OrderNote != null && this.OrderNote.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OrderNote, length must be less than 200.", new [] { "OrderNote" });
            }

            // OrderNote (string) minLength
            if (this.OrderNote != null && this.OrderNote.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OrderNote, length must be greater than 3.", new [] { "OrderNote" });
            }

            yield break;
        }
    }

}

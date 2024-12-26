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
    /// Request body to create an order at cashfree
    /// </summary>
    [DataContract(Name = "CreateOrderRequest")]
    public class CreateOrderRequest : IEquatable<CreateOrderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateOrderRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateOrderRequest" /> class.
        /// </summary>
        /// <param name="orderId">Order identifier present in your system. Alphanumeric, &#39;_&#39; and &#39;-&#39; only.</param>
        /// <param name="orderAmount">Bill amount for the order. Provide upto two decimals. 10.15 means Rs 10 and 15 paisa (required).</param>
        /// <param name="orderCurrency">Currency for the order. INR if left empty. Contact care@cashfree.com to enable new currencies. (required).</param>
        /// <param name="cartDetails">cartDetails.</param>
        /// <param name="customerDetails">customerDetails (required).</param>
        /// <param name="terminal">terminal.</param>
        /// <param name="orderMeta">orderMeta.</param>
        /// <param name="orderExpiryTime">Time after which the order expires. Customers will not be able to make the payment beyond the time specified here. We store timestamps in IST, but you can provide them in a valid ISO 8601 time format. Example 2021-07-02T10:20:12+05:30 for IST, 2021-07-02T10:20:12Z for UTC.</param>
        /// <param name="orderNote">Order note for reference..</param>
        /// <param name="orderTags">Custom Tags in thr form of {\&quot;key\&quot;:\&quot;value\&quot;} which can be passed for an order. A maximum of 10 tags can be added.</param>
        /// <param name="orderSplits">If you have Easy split enabled in your Cashfree account then you can use this option to split the order amount..</param>
        public CreateOrderRequest(string? orderId = default(string?), double orderAmount = default(double), string orderCurrency = default(string), CartDetails? cartDetails = default(CartDetails?), CustomerDetails customerDetails = default(CustomerDetails), TerminalDetails? terminal = default(TerminalDetails?), OrderMeta? orderMeta = default(OrderMeta?), string? orderExpiryTime = default(string?), string? orderNote = default(string?), Dictionary<string, string>? orderTags = default(Dictionary<string, string>?), List<VendorSplit>? orderSplits = default(List<VendorSplit>?))
        {
            this.order_amount = orderAmount;
            // to ensure "orderCurrency" is required (not null)
            if (orderCurrency == null)
            {
                throw new ArgumentNullException("orderCurrency is a required property for CreateOrderRequest and cannot be null");
            }
            this.order_currency = orderCurrency;
            // to ensure "customerDetails" is required (not null)
            if (customerDetails == null)
            {
                throw new ArgumentNullException("customerDetails is a required property for CreateOrderRequest and cannot be null");
            }
            this.customer_details = customerDetails;
            this.order_id = orderId;
            this.cart_details = cartDetails;
            this.terminal = terminal;
            this.order_meta = orderMeta;
            this.order_expiry_time = orderExpiryTime;
            this.order_note = orderNote;
            this.order_tags = orderTags;
            this.order_splits = orderSplits;
        }

        /// <summary>
        /// Order identifier present in your system. Alphanumeric, &#39;_&#39; and &#39;-&#39; only
        /// </summary>
        /// <value>Order identifier present in your system. Alphanumeric, &#39;_&#39; and &#39;-&#39; only</value>
        /// <example>your-order-id</example>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string? order_id { get; set; }

        /// <summary>
        /// Bill amount for the order. Provide upto two decimals. 10.15 means Rs 10 and 15 paisa
        /// </summary>
        /// <value>Bill amount for the order. Provide upto two decimals. 10.15 means Rs 10 and 15 paisa</value>
        /// <example>10.15</example>
        [DataMember(Name = "order_amount", IsRequired = true, EmitDefaultValue = true)]
        public double order_amount { get; set; }

        /// <summary>
        /// Currency for the order. INR if left empty. Contact care@cashfree.com to enable new currencies.
        /// </summary>
        /// <value>Currency for the order. INR if left empty. Contact care@cashfree.com to enable new currencies.</value>
        /// <example>INR</example>
        [DataMember(Name = "order_currency", IsRequired = true, EmitDefaultValue = true)]
        public string order_currency { get; set; }

        /// <summary>
        /// Gets or Sets cart_details
        /// </summary>
        [DataMember(Name = "cart_details", EmitDefaultValue = false)]
        public CartDetails? cart_details { get; set; }

        /// <summary>
        /// Gets or Sets customer_details
        /// </summary>
        [DataMember(Name = "customer_details", IsRequired = true, EmitDefaultValue = true)]
        public CustomerDetails customer_details { get; set; }

        /// <summary>
        /// Gets or Sets terminal
        /// </summary>
        [DataMember(Name = "terminal", EmitDefaultValue = false)]
        public TerminalDetails? terminal { get; set; }

        /// <summary>
        /// Gets or Sets order_meta
        /// </summary>
        [DataMember(Name = "order_meta", EmitDefaultValue = false)]
        public OrderMeta? order_meta { get; set; }

        /// <summary>
        /// Time after which the order expires. Customers will not be able to make the payment beyond the time specified here. We store timestamps in IST, but you can provide them in a valid ISO 8601 time format. Example 2021-07-02T10:20:12+05:30 for IST, 2021-07-02T10:20:12Z for UTC
        /// </summary>
        /// <value>Time after which the order expires. Customers will not be able to make the payment beyond the time specified here. We store timestamps in IST, but you can provide them in a valid ISO 8601 time format. Example 2021-07-02T10:20:12+05:30 for IST, 2021-07-02T10:20:12Z for UTC</value>
        /// <example>2021-07-02T10:20:12+05:30</example>
        [DataMember(Name = "order_expiry_time", EmitDefaultValue = false)]
        public string? order_expiry_time { get; set; }

        /// <summary>
        /// Order note for reference.
        /// </summary>
        /// <value>Order note for reference.</value>
        /// <example>Test order</example>
        [DataMember(Name = "order_note", EmitDefaultValue = false)]
        public string? order_note { get; set; }

        /// <summary>
        /// Custom Tags in thr form of {\&quot;key\&quot;:\&quot;value\&quot;} which can be passed for an order. A maximum of 10 tags can be added
        /// </summary>
        /// <value>Custom Tags in thr form of {\&quot;key\&quot;:\&quot;value\&quot;} which can be passed for an order. A maximum of 10 tags can be added</value>
        /// <example>{&quot;product&quot;:&quot;Laptop&quot;,&quot;shipping_address&quot;:&quot;123 Main St&quot;}</example>
        [DataMember(Name = "order_tags", EmitDefaultValue = false)]
        public Dictionary<string, string>? order_tags { get; set; }

        /// <summary>
        /// If you have Easy split enabled in your Cashfree account then you can use this option to split the order amount.
        /// </summary>
        /// <value>If you have Easy split enabled in your Cashfree account then you can use this option to split the order amount.</value>
        /// <example>[{&quot;amount&quot;:10,&quot;vendor&quot;:&quot;john&quot;}]</example>
        [DataMember(Name = "order_splits", EmitDefaultValue = false)]
        public List<VendorSplit>? order_splits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateOrderRequest {\n");
            sb.Append("  order_id: ").Append(order_id).Append("\n");
            sb.Append("  order_amount: ").Append(order_amount).Append("\n");
            sb.Append("  order_currency: ").Append(order_currency).Append("\n");
            sb.Append("  cart_details: ").Append(cart_details).Append("\n");
            sb.Append("  customer_details: ").Append(customer_details).Append("\n");
            sb.Append("  terminal: ").Append(terminal).Append("\n");
            sb.Append("  order_meta: ").Append(order_meta).Append("\n");
            sb.Append("  order_expiry_time: ").Append(order_expiry_time).Append("\n");
            sb.Append("  order_note: ").Append(order_note).Append("\n");
            sb.Append("  order_tags: ").Append(order_tags).Append("\n");
            sb.Append("  order_splits: ").Append(order_splits).Append("\n");
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
            return this.Equals(input as CreateOrderRequest);
        }

        /// <summary>
        /// Returns true if CreateOrderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateOrderRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.order_id == input.order_id ||
                    (this.order_id != null &&
                    this.order_id.Equals(input.order_id))
                ) && 
                (
                    this.order_amount == input.order_amount ||
                    this.order_amount.Equals(input.order_amount)
                ) && 
                (
                    this.order_currency == input.order_currency ||
                    (this.order_currency != null &&
                    this.order_currency.Equals(input.order_currency))
                ) && 
                (
                    this.cart_details == input.cart_details ||
                    (this.cart_details != null &&
                    this.cart_details.Equals(input.cart_details))
                ) && 
                (
                    this.customer_details == input.customer_details ||
                    (this.customer_details != null &&
                    this.customer_details.Equals(input.customer_details))
                ) && 
                (
                    this.terminal == input.terminal ||
                    (this.terminal != null &&
                    this.terminal.Equals(input.terminal))
                ) && 
                (
                    this.order_meta == input.order_meta ||
                    (this.order_meta != null &&
                    this.order_meta.Equals(input.order_meta))
                ) && 
                (
                    this.order_expiry_time == input.order_expiry_time ||
                    (this.order_expiry_time != null &&
                    this.order_expiry_time.Equals(input.order_expiry_time))
                ) && 
                (
                    this.order_note == input.order_note ||
                    (this.order_note != null &&
                    this.order_note.Equals(input.order_note))
                ) && 
                (
                    this.order_tags == input.order_tags ||
                    this.order_tags != null &&
                    input.order_tags != null &&
                    this.order_tags.SequenceEqual(input.order_tags)
                ) && 
                (
                    this.order_splits == input.order_splits ||
                    this.order_splits != null &&
                    input.order_splits != null &&
                    this.order_splits.SequenceEqual(input.order_splits)
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringorder_id) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringorder_id);
            if (deserializedJsonString.ContainsKey("order_id")) {
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
                if (this.order_id != null)
                {
                    hashCode = (hashCode * 59) + this.order_id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.order_amount.GetHashCode();
                if (this.order_currency != null)
                {
                    hashCode = (hashCode * 59) + this.order_currency.GetHashCode();
                }
                if (this.cart_details != null)
                {
                    hashCode = (hashCode * 59) + this.cart_details.GetHashCode();
                }
                if (this.customer_details != null)
                {
                    hashCode = (hashCode * 59) + this.customer_details.GetHashCode();
                }
                if (this.terminal != null)
                {
                    hashCode = (hashCode * 59) + this.terminal.GetHashCode();
                }
                if (this.order_meta != null)
                {
                    hashCode = (hashCode * 59) + this.order_meta.GetHashCode();
                }
                if (this.order_expiry_time != null)
                {
                    hashCode = (hashCode * 59) + this.order_expiry_time.GetHashCode();
                }
                if (this.order_note != null)
                {
                    hashCode = (hashCode * 59) + this.order_note.GetHashCode();
                }
                if (this.order_tags != null)
                {
                    hashCode = (hashCode * 59) + this.order_tags.GetHashCode();
                }
                if (this.order_splits != null)
                {
                    hashCode = (hashCode * 59) + this.order_splits.GetHashCode();
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
            // order_id (string) maxLength
            if (this.order_id != null && this.order_id.Length > 45)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for order_id, length must be less than 45.", new [] { "order_id" });
            }

            // order_id (string) minLength
            if (this.order_id != null && this.order_id.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for order_id, length must be greater than 3.", new [] { "order_id" });
            }

            // order_amount (double) minimum
            if (this.order_amount < (double)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for order_amount, must be a value greater than or equal to 1.", new [] { "order_amount" });
            }

            // order_note (string) maxLength
            if (this.order_note != null && this.order_note.Length > 200)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for order_note, length must be less than 200.", new [] { "order_note" });
            }

            // order_note (string) minLength
            if (this.order_note != null && this.order_note.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for order_note, length must be greater than 3.", new [] { "order_note" });
            }

            yield break;
        }
    }

}

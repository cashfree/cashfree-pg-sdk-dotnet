/*
 * Cashfree Payment Gateway APIs
 *
 * Cashfree's Payment Gateway APIs provide developers with a streamlined pathway to integrate advanced payment processing capabilities into their applications, platforms and websites.
 *
 * The version of the OpenAPI document: 2022-09-01
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
    /// The complete order entity
    /// </summary>
    [DataContract(Name = "OrderEntity")]
    public class OrderEntity : IEquatable<OrderEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderEntity" /> class.
        /// </summary>
        /// <param name="cfOrderId">unique id generated by cashfree for your order.</param>
        /// <param name="orderId">order_id sent during the api request.</param>
        /// <param name="entity">Type of the entity..</param>
        /// <param name="orderCurrency">Currency of the order. Example INR.</param>
        /// <param name="orderAmount">orderAmount.</param>
        /// <param name="orderStatus">Possible values are  - &#x60;ACTIVE&#x60;: Order does not have a sucessful transaction yet - &#x60;PAID&#x60;: Order is PAID with one successful transaction - &#x60;EXPIRED&#x60;: Order was not PAID and not it has expired. No transaction can be initiated for an EXPIRED order. .</param>
        /// <param name="paymentSessionId">paymentSessionId.</param>
        /// <param name="orderExpiryTime">orderExpiryTime.</param>
        /// <param name="orderNote">Additional note for order.</param>
        /// <param name="createdAt">When the order was created at cashfree&#39;s server.</param>
        /// <param name="orderSplits">orderSplits.</param>
        /// <param name="customerDetails">customerDetails.</param>
        /// <param name="orderMeta">orderMeta.</param>
        /// <param name="payments">payments.</param>
        /// <param name="settlements">settlements.</param>
        /// <param name="refunds">refunds.</param>
        /// <param name="orderTags">Custom Tags in thr form of {\&quot;key\&quot;:\&quot;value\&quot;} which can be passed for an order. A maximum of 10 tags can be added.</param>
        public OrderEntity(long cfOrderId = default(long), string orderId = default(string), string entity = default(string), string orderCurrency = default(string), decimal orderAmount = default(decimal), string orderStatus = default(string), string paymentSessionId = default(string), DateTime orderExpiryTime = default(DateTime), string orderNote = default(string), DateTime createdAt = default(DateTime), List<VendorSplit> orderSplits = default(List<VendorSplit>), CustomerDetails customerDetails = default(CustomerDetails), OrderMeta orderMeta = default(OrderMeta), PaymentURLObject payments = default(PaymentURLObject), SettlementURLObject settlements = default(SettlementURLObject), RefundURLObject refunds = default(RefundURLObject), Dictionary<string, string> orderTags = default(Dictionary<string, string>))
        {
            this.cf_order_id = cfOrderId;
            this.order_id = orderId;
            this.entity = entity;
            this.order_currency = orderCurrency;
            this.order_amount = orderAmount;
            this.order_status = orderStatus;
            this.payment_session_id = paymentSessionId;
            this.order_expiry_time = orderExpiryTime;
            this.order_note = orderNote;
            this.created_at = createdAt;
            this.order_splits = orderSplits;
            this.customer_details = customerDetails;
            this.order_meta = orderMeta;
            this.payments = payments;
            this.settlements = settlements;
            this.refunds = refunds;
            this.order_tags = orderTags;
        }

        /// <summary>
        /// unique id generated by cashfree for your order
        /// </summary>
        /// <value>unique id generated by cashfree for your order</value>
        [DataMember(Name = "cf_order_id", EmitDefaultValue = false)]
        public long cf_order_id { get; set; }

        /// <summary>
        /// order_id sent during the api request
        /// </summary>
        /// <value>order_id sent during the api request</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string order_id { get; set; }

        /// <summary>
        /// Type of the entity.
        /// </summary>
        /// <value>Type of the entity.</value>
        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public string entity { get; set; }

        /// <summary>
        /// Currency of the order. Example INR
        /// </summary>
        /// <value>Currency of the order. Example INR</value>
        [DataMember(Name = "order_currency", EmitDefaultValue = false)]
        public string order_currency { get; set; }

        /// <summary>
        /// Gets or Sets order_amount
        /// </summary>
        [DataMember(Name = "order_amount", EmitDefaultValue = false)]
        public decimal order_amount { get; set; }

        /// <summary>
        /// Possible values are  - &#x60;ACTIVE&#x60;: Order does not have a sucessful transaction yet - &#x60;PAID&#x60;: Order is PAID with one successful transaction - &#x60;EXPIRED&#x60;: Order was not PAID and not it has expired. No transaction can be initiated for an EXPIRED order. 
        /// </summary>
        /// <value>Possible values are  - &#x60;ACTIVE&#x60;: Order does not have a sucessful transaction yet - &#x60;PAID&#x60;: Order is PAID with one successful transaction - &#x60;EXPIRED&#x60;: Order was not PAID and not it has expired. No transaction can be initiated for an EXPIRED order. </value>
        [DataMember(Name = "order_status", EmitDefaultValue = false)]
        public string order_status { get; set; }

        /// <summary>
        /// Gets or Sets payment_session_id
        /// </summary>
        [DataMember(Name = "payment_session_id", EmitDefaultValue = false)]
        public string payment_session_id { get; set; }

        /// <summary>
        /// Gets or Sets order_expiry_time
        /// </summary>
        [DataMember(Name = "order_expiry_time", EmitDefaultValue = false)]
        public DateTime order_expiry_time { get; set; }

        /// <summary>
        /// Additional note for order
        /// </summary>
        /// <value>Additional note for order</value>
        [DataMember(Name = "order_note", EmitDefaultValue = true)]
        public string order_note { get; set; }

        /// <summary>
        /// When the order was created at cashfree&#39;s server
        /// </summary>
        /// <value>When the order was created at cashfree&#39;s server</value>
        /// <example>2022-08-16T14:45:38+05:30</example>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime created_at { get; set; }

        /// <summary>
        /// Gets or Sets order_splits
        /// </summary>
        [DataMember(Name = "order_splits", EmitDefaultValue = false)]
        public List<VendorSplit> order_splits { get; set; }

        /// <summary>
        /// Gets or Sets customer_details
        /// </summary>
        [DataMember(Name = "customer_details", EmitDefaultValue = false)]
        public CustomerDetails customer_details { get; set; }

        /// <summary>
        /// Gets or Sets order_meta
        /// </summary>
        [DataMember(Name = "order_meta", EmitDefaultValue = false)]
        public OrderMeta order_meta { get; set; }

        /// <summary>
        /// Gets or Sets payments
        /// </summary>
        [DataMember(Name = "payments", EmitDefaultValue = false)]
        public PaymentURLObject payments { get; set; }

        /// <summary>
        /// Gets or Sets settlements
        /// </summary>
        [DataMember(Name = "settlements", EmitDefaultValue = false)]
        public SettlementURLObject settlements { get; set; }

        /// <summary>
        /// Gets or Sets refunds
        /// </summary>
        [DataMember(Name = "refunds", EmitDefaultValue = false)]
        public RefundURLObject refunds { get; set; }

        /// <summary>
        /// Custom Tags in thr form of {\&quot;key\&quot;:\&quot;value\&quot;} which can be passed for an order. A maximum of 10 tags can be added
        /// </summary>
        /// <value>Custom Tags in thr form of {\&quot;key\&quot;:\&quot;value\&quot;} which can be passed for an order. A maximum of 10 tags can be added</value>
        /// <example>{&quot;product&quot;:&quot;Laptop&quot;,&quot;shipping_address&quot;:&quot;123 Main St&quot;}</example>
        [DataMember(Name = "order_tags", EmitDefaultValue = true)]
        public Dictionary<string, string> order_tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderEntity {\n");
            sb.Append("  cf_order_id: ").Append(cf_order_id).Append("\n");
            sb.Append("  order_id: ").Append(order_id).Append("\n");
            sb.Append("  entity: ").Append(entity).Append("\n");
            sb.Append("  order_currency: ").Append(order_currency).Append("\n");
            sb.Append("  order_amount: ").Append(order_amount).Append("\n");
            sb.Append("  order_status: ").Append(order_status).Append("\n");
            sb.Append("  payment_session_id: ").Append(payment_session_id).Append("\n");
            sb.Append("  order_expiry_time: ").Append(order_expiry_time).Append("\n");
            sb.Append("  order_note: ").Append(order_note).Append("\n");
            sb.Append("  created_at: ").Append(created_at).Append("\n");
            sb.Append("  order_splits: ").Append(order_splits).Append("\n");
            sb.Append("  customer_details: ").Append(customer_details).Append("\n");
            sb.Append("  order_meta: ").Append(order_meta).Append("\n");
            sb.Append("  payments: ").Append(payments).Append("\n");
            sb.Append("  settlements: ").Append(settlements).Append("\n");
            sb.Append("  refunds: ").Append(refunds).Append("\n");
            sb.Append("  order_tags: ").Append(order_tags).Append("\n");
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
            return this.Equals(input as OrderEntity);
        }

        /// <summary>
        /// Returns true if OrderEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cf_order_id == input.cf_order_id ||
                    this.cf_order_id.Equals(input.cf_order_id)
                ) && 
                (
                    this.order_id == input.order_id ||
                    (this.order_id != null &&
                    this.order_id.Equals(input.order_id))
                ) && 
                (
                    this.entity == input.entity ||
                    (this.entity != null &&
                    this.entity.Equals(input.entity))
                ) && 
                (
                    this.order_currency == input.order_currency ||
                    (this.order_currency != null &&
                    this.order_currency.Equals(input.order_currency))
                ) && 
                (
                    this.order_amount == input.order_amount ||
                    this.order_amount.Equals(input.order_amount)
                ) && 
                (
                    this.order_status == input.order_status ||
                    (this.order_status != null &&
                    this.order_status.Equals(input.order_status))
                ) && 
                (
                    this.payment_session_id == input.payment_session_id ||
                    (this.payment_session_id != null &&
                    this.payment_session_id.Equals(input.payment_session_id))
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
                    this.created_at == input.created_at ||
                    (this.created_at != null &&
                    this.created_at.Equals(input.created_at))
                ) && 
                (
                    this.order_splits == input.order_splits ||
                    this.order_splits != null &&
                    input.order_splits != null &&
                    this.order_splits.SequenceEqual(input.order_splits)
                ) && 
                (
                    this.customer_details == input.customer_details ||
                    (this.customer_details != null &&
                    this.customer_details.Equals(input.customer_details))
                ) && 
                (
                    this.order_meta == input.order_meta ||
                    (this.order_meta != null &&
                    this.order_meta.Equals(input.order_meta))
                ) && 
                (
                    this.payments == input.payments ||
                    (this.payments != null &&
                    this.payments.Equals(input.payments))
                ) && 
                (
                    this.settlements == input.settlements ||
                    (this.settlements != null &&
                    this.settlements.Equals(input.settlements))
                ) && 
                (
                    this.refunds == input.refunds ||
                    (this.refunds != null &&
                    this.refunds.Equals(input.refunds))
                ) && 
                (
                    this.order_tags == input.order_tags ||
                    this.order_tags != null &&
                    input.order_tags != null &&
                    this.order_tags.SequenceEqual(input.order_tags)
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
                hashCode = (hashCode * 59) + this.cf_order_id.GetHashCode();
                if (this.order_id != null)
                {
                    hashCode = (hashCode * 59) + this.order_id.GetHashCode();
                }
                if (this.entity != null)
                {
                    hashCode = (hashCode * 59) + this.entity.GetHashCode();
                }
                if (this.order_currency != null)
                {
                    hashCode = (hashCode * 59) + this.order_currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.order_amount.GetHashCode();
                if (this.order_status != null)
                {
                    hashCode = (hashCode * 59) + this.order_status.GetHashCode();
                }
                if (this.payment_session_id != null)
                {
                    hashCode = (hashCode * 59) + this.payment_session_id.GetHashCode();
                }
                if (this.order_expiry_time != null)
                {
                    hashCode = (hashCode * 59) + this.order_expiry_time.GetHashCode();
                }
                if (this.order_note != null)
                {
                    hashCode = (hashCode * 59) + this.order_note.GetHashCode();
                }
                if (this.created_at != null)
                {
                    hashCode = (hashCode * 59) + this.created_at.GetHashCode();
                }
                if (this.order_splits != null)
                {
                    hashCode = (hashCode * 59) + this.order_splits.GetHashCode();
                }
                if (this.customer_details != null)
                {
                    hashCode = (hashCode * 59) + this.customer_details.GetHashCode();
                }
                if (this.order_meta != null)
                {
                    hashCode = (hashCode * 59) + this.order_meta.GetHashCode();
                }
                if (this.payments != null)
                {
                    hashCode = (hashCode * 59) + this.payments.GetHashCode();
                }
                if (this.settlements != null)
                {
                    hashCode = (hashCode * 59) + this.settlements.GetHashCode();
                }
                if (this.refunds != null)
                {
                    hashCode = (hashCode * 59) + this.refunds.GetHashCode();
                }
                if (this.order_tags != null)
                {
                    hashCode = (hashCode * 59) + this.order_tags.GetHashCode();
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
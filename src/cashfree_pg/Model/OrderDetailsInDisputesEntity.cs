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
    /// OrderDetailsInDisputesEntity
    /// </summary>
    [DataContract(Name = "OrderDetailsInDisputesEntity")]
    public class OrderDetailsInDisputesEntity : IEquatable<OrderDetailsInDisputesEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDetailsInDisputesEntity" /> class.
        /// </summary>
        /// <param name="orderId">orderId.</param>
        /// <param name="orderCurrency">orderCurrency.</param>
        /// <param name="orderAmount">orderAmount.</param>
        /// <param name="cfPaymentId">cfPaymentId.</param>
        /// <param name="paymentCurrency">paymentCurrency.</param>
        /// <param name="paymentAmount">paymentAmount.</param>
        public OrderDetailsInDisputesEntity(string? orderId = default(string?), string? orderCurrency = default(string?), decimal? orderAmount = default(decimal?), string? cfPaymentId = default(string?), string? paymentCurrency = default(string?), decimal? paymentAmount = default(decimal?))
        {
            this.order_id = orderId;
            this.order_currency = orderCurrency;
            this.order_amount = orderAmount;
            this.cf_payment_id = cfPaymentId;
            this.payment_currency = paymentCurrency;
            this.payment_amount = paymentAmount;
        }

        /// <summary>
        /// Gets or Sets order_id
        /// </summary>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string? order_id { get; set; }

        /// <summary>
        /// Gets or Sets order_currency
        /// </summary>
        [DataMember(Name = "order_currency", EmitDefaultValue = false)]
        public string? order_currency { get; set; }

        /// <summary>
        /// Gets or Sets order_amount
        /// </summary>
        [DataMember(Name = "order_amount", EmitDefaultValue = false)]
        public decimal? order_amount { get; set; }

        /// <summary>
        /// Gets or Sets cf_payment_id
        /// </summary>
        [DataMember(Name = "cf_payment_id", EmitDefaultValue = false)]
        public string? cf_payment_id { get; set; }

        /// <summary>
        /// Gets or Sets payment_currency
        /// </summary>
        [DataMember(Name = "payment_currency", EmitDefaultValue = false)]
        public string? payment_currency { get; set; }

        /// <summary>
        /// Gets or Sets payment_amount
        /// </summary>
        [DataMember(Name = "payment_amount", EmitDefaultValue = false)]
        public decimal? payment_amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDetailsInDisputesEntity {\n");
            sb.Append("  order_id: ").Append(order_id).Append("\n");
            sb.Append("  order_currency: ").Append(order_currency).Append("\n");
            sb.Append("  order_amount: ").Append(order_amount).Append("\n");
            sb.Append("  cf_payment_id: ").Append(cf_payment_id).Append("\n");
            sb.Append("  payment_currency: ").Append(payment_currency).Append("\n");
            sb.Append("  payment_amount: ").Append(payment_amount).Append("\n");
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
            return this.Equals(input as OrderDetailsInDisputesEntity);
        }

        /// <summary>
        /// Returns true if OrderDetailsInDisputesEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderDetailsInDisputesEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderDetailsInDisputesEntity input)
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
                    this.order_currency == input.order_currency ||
                    (this.order_currency != null &&
                    this.order_currency.Equals(input.order_currency))
                ) && 
                (
                    this.order_amount == input.order_amount ||
                    this.order_amount.Equals(input.order_amount)
                ) && 
                (
                    this.cf_payment_id == input.cf_payment_id ||
                    (this.cf_payment_id != null &&
                    this.cf_payment_id.Equals(input.cf_payment_id))
                ) && 
                (
                    this.payment_currency == input.payment_currency ||
                    (this.payment_currency != null &&
                    this.payment_currency.Equals(input.payment_currency))
                ) && 
                (
                    this.payment_amount == input.payment_amount ||
                    this.payment_amount.Equals(input.payment_amount)
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
                if (this.order_currency != null)
                {
                    hashCode = (hashCode * 59) + this.order_currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.order_amount.GetHashCode();
                if (this.cf_payment_id != null)
                {
                    hashCode = (hashCode * 59) + this.cf_payment_id.GetHashCode();
                }
                if (this.payment_currency != null)
                {
                    hashCode = (hashCode * 59) + this.payment_currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.payment_amount.GetHashCode();
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
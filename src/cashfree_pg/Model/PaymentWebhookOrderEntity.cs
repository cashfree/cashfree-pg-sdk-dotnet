/*
 * Cashfree Payment Gateway APIs
 *
 * Cashfree's Payment Gateway APIs provide developers with a streamlined pathway to integrate advanced payment processing capabilities into their applications, platforms and websites.
 *
 * The version of the OpenAPI document: 2025-01-01
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
    /// order entity in webhook
    /// </summary>
    [DataContract(Name = "PaymentWebhookOrderEntity")]
    public class PaymentWebhookOrderEntity : IEquatable<PaymentWebhookOrderEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentWebhookOrderEntity" /> class.
        /// </summary>
        /// <param name="orderId">orderId.</param>
        /// <param name="orderAmount">orderAmount.</param>
        /// <param name="orderCurrency">orderCurrency.</param>
        /// <param name="orderTags">Custom Tags in thr form of {\&quot;key\&quot;:\&quot;value\&quot;} which can be passed for an order. A maximum of 10 tags can be added.</param>
        public PaymentWebhookOrderEntity(string? orderId = default(string?), double? orderAmount = default(double?), string? orderCurrency = default(string?), Dictionary<string, string>? orderTags = default(Dictionary<string, string>?))
        {
            this.order_id = orderId;
            this.order_amount = orderAmount;
            this.order_currency = orderCurrency;
            this.order_tags = orderTags;
        }

        /// <summary>
        /// Gets or Sets order_id
        /// </summary>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string? order_id { get; set; }

        /// <summary>
        /// Gets or Sets order_amount
        /// </summary>
        [DataMember(Name = "order_amount", EmitDefaultValue = false)]
        public double? order_amount { get; set; }

        /// <summary>
        /// Gets or Sets order_currency
        /// </summary>
        [DataMember(Name = "order_currency", EmitDefaultValue = false)]
        public string? order_currency { get; set; }

        /// <summary>
        /// Custom Tags in thr form of {\&quot;key\&quot;:\&quot;value\&quot;} which can be passed for an order. A maximum of 10 tags can be added
        /// </summary>
        /// <value>Custom Tags in thr form of {\&quot;key\&quot;:\&quot;value\&quot;} which can be passed for an order. A maximum of 10 tags can be added</value>
        [DataMember(Name = "order_tags", EmitDefaultValue = false)]
        public Dictionary<string, string>? order_tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentWebhookOrderEntity {\n");
            sb.Append("  order_id: ").Append(order_id).Append("\n");
            sb.Append("  order_amount: ").Append(order_amount).Append("\n");
            sb.Append("  order_currency: ").Append(order_currency).Append("\n");
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
            return this.Equals(input as PaymentWebhookOrderEntity);
        }

        /// <summary>
        /// Returns true if PaymentWebhookOrderEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentWebhookOrderEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentWebhookOrderEntity input)
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
                    this.order_tags == input.order_tags ||
                    this.order_tags != null &&
                    input.order_tags != null &&
                    this.order_tags.SequenceEqual(input.order_tags)
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

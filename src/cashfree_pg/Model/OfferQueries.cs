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
    /// Offer Query Object
    /// </summary>
    [DataContract(Name = "OfferQueries")]
    public class OfferQueries : IEquatable<OfferQueries>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferQueries" /> class.
        /// </summary>
        /// <param name="orderId">OrderId of the order. Either of &#x60;order_id&#x60; or &#x60;order_amount&#x60; is mandatory..</param>
        /// <param name="amount">Amount of the order. OrderId of the order. Either of &#x60;order_id&#x60; or &#x60;order_amount&#x60; is mandatory..</param>
        public OfferQueries(string? orderId = default(string?), decimal? amount = default(decimal?))
        {
            this.order_id = orderId;
            this.amount = amount;
        }

        /// <summary>
        /// OrderId of the order. Either of &#x60;order_id&#x60; or &#x60;order_amount&#x60; is mandatory.
        /// </summary>
        /// <value>OrderId of the order. Either of &#x60;order_id&#x60; or &#x60;order_amount&#x60; is mandatory.</value>
        /// <example>order_413462PK1RI1IwYB1X69LgzUQWiSxYDF</example>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string? order_id { get; set; }

        /// <summary>
        /// Amount of the order. OrderId of the order. Either of &#x60;order_id&#x60; or &#x60;order_amount&#x60; is mandatory.
        /// </summary>
        /// <value>Amount of the order. OrderId of the order. Either of &#x60;order_id&#x60; or &#x60;order_amount&#x60; is mandatory.</value>
        /// <example>100</example>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal? amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OfferQueries {\n");
            sb.Append("  order_id: ").Append(order_id).Append("\n");
            sb.Append("  amount: ").Append(amount).Append("\n");
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
            return this.Equals(input as OfferQueries);
        }

        /// <summary>
        /// Returns true if OfferQueries instances are equal
        /// </summary>
        /// <param name="input">Instance of OfferQueries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferQueries input)
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
                    this.amount == input.amount ||
                    this.amount.Equals(input.amount)
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
                hashCode = (hashCode * 59) + this.amount.GetHashCode();
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
            if (this.order_id != null && this.order_id.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for order_id, length must be less than 50.", new [] { "order_id" });
            }

            // order_id (string) minLength
            if (this.order_id != null && this.order_id.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for order_id, length must be greater than 3.", new [] { "order_id" });
            }

            // amount (decimal) minimum
            if (this.amount < (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for amount, must be a value greater than or equal to 1.", new [] { "amount" });
            }

            yield break;
        }
    }

}

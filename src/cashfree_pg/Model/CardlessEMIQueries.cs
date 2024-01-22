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
    /// cardless EMI query object
    /// </summary>
    [DataContract(Name = "CardlessEMIQueries")]
    public class CardlessEMIQueries : IEquatable<CardlessEMIQueries>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardlessEMIQueries" /> class.
        /// </summary>
        /// <param name="orderId">OrderId of the order. Either of &#x60;order_id&#x60; or &#x60;amount&#x60; is mandatory..</param>
        /// <param name="amount">Amount of the order. OrderId of the order. Either of &#x60;order_id&#x60; or &#x60;amount&#x60; is mandatory..</param>
        /// <param name="customerDetails">customerDetails.</param>
        public CardlessEMIQueries(string orderId = default(string), decimal amount = default(decimal), CustomerDetailsCardlessEMI customerDetails = default(CustomerDetailsCardlessEMI))
        {
            this.order_id = orderId;
            this.amount = amount;
            this.customer_details = customerDetails;
        }

        /// <summary>
        /// OrderId of the order. Either of &#x60;order_id&#x60; or &#x60;amount&#x60; is mandatory.
        /// </summary>
        /// <value>OrderId of the order. Either of &#x60;order_id&#x60; or &#x60;amount&#x60; is mandatory.</value>
        /// <example>orderYB1X69LgzUQWiSxYDF</example>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string order_id { get; set; }

        /// <summary>
        /// Amount of the order. OrderId of the order. Either of &#x60;order_id&#x60; or &#x60;amount&#x60; is mandatory.
        /// </summary>
        /// <value>Amount of the order. OrderId of the order. Either of &#x60;order_id&#x60; or &#x60;amount&#x60; is mandatory.</value>
        /// <example>100</example>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal amount { get; set; }

        /// <summary>
        /// Gets or Sets customer_details
        /// </summary>
        [DataMember(Name = "customer_details", EmitDefaultValue = false)]
        public CustomerDetailsCardlessEMI customer_details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardlessEMIQueries {\n");
            sb.Append("  order_id: ").Append(order_id).Append("\n");
            sb.Append("  amount: ").Append(amount).Append("\n");
            sb.Append("  customer_details: ").Append(customer_details).Append("\n");
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
            return this.Equals(input as CardlessEMIQueries);
        }

        /// <summary>
        /// Returns true if CardlessEMIQueries instances are equal
        /// </summary>
        /// <param name="input">Instance of CardlessEMIQueries to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardlessEMIQueries input)
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
                ) && 
                (
                    this.customer_details == input.customer_details ||
                    (this.customer_details != null &&
                    this.customer_details.Equals(input.customer_details))
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
                if (this.order_id != null)
                {
                    hashCode = (hashCode * 59) + this.order_id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.amount.GetHashCode();
                if (this.customer_details != null)
                {
                    hashCode = (hashCode * 59) + this.customer_details.GetHashCode();
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

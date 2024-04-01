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
    /// Offer validation object
    /// </summary>
    [DataContract(Name = "OfferValidations")]
    public class OfferValidations : IEquatable<OfferValidations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferValidations" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OfferValidations() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferValidations" /> class.
        /// </summary>
        /// <param name="minAmount">Minimum Amount for Offer to be Applicable.</param>
        /// <param name="maxAllowed">Maximum Amount for Offer to be Applicable (required).</param>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        public OfferValidations(decimal? minAmount = default(decimal?), decimal maxAllowed = default(decimal), OfferValidationsPaymentMethod paymentMethod = default(OfferValidationsPaymentMethod))
        {
            this.max_allowed = maxAllowed;
            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null)
            {
                throw new ArgumentNullException("paymentMethod is a required property for OfferValidations and cannot be null");
            }
            this.payment_method = paymentMethod;
            this.min_amount = minAmount;
        }

        /// <summary>
        /// Minimum Amount for Offer to be Applicable
        /// </summary>
        /// <value>Minimum Amount for Offer to be Applicable</value>
        /// <example>1</example>
        [DataMember(Name = "min_amount", EmitDefaultValue = false)]
        public decimal? min_amount { get; set; }

        /// <summary>
        /// Maximum Amount for Offer to be Applicable
        /// </summary>
        /// <value>Maximum Amount for Offer to be Applicable</value>
        /// <example>1</example>
        [DataMember(Name = "max_allowed", IsRequired = true, EmitDefaultValue = true)]
        public decimal max_allowed { get; set; }

        /// <summary>
        /// Gets or Sets payment_method
        /// </summary>
        [DataMember(Name = "payment_method", IsRequired = true, EmitDefaultValue = true)]
        public OfferValidationsPaymentMethod payment_method { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OfferValidations {\n");
            sb.Append("  min_amount: ").Append(min_amount).Append("\n");
            sb.Append("  max_allowed: ").Append(max_allowed).Append("\n");
            sb.Append("  payment_method: ").Append(payment_method).Append("\n");
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
            return this.Equals(input as OfferValidations);
        }

        /// <summary>
        /// Returns true if OfferValidations instances are equal
        /// </summary>
        /// <param name="input">Instance of OfferValidations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferValidations input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.min_amount == input.min_amount ||
                    this.min_amount.Equals(input.min_amount)
                ) && 
                (
                    this.max_allowed == input.max_allowed ||
                    this.max_allowed.Equals(input.max_allowed)
                ) && 
                (
                    this.payment_method == input.payment_method ||
                    (this.payment_method != null &&
                    this.payment_method.Equals(input.payment_method))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringmin_amount) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringmin_amount);
            if (deserializedJsonString.ContainsKey("min_amount")) {
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
                hashCode = (hashCode * 59) + this.min_amount.GetHashCode();
                hashCode = (hashCode * 59) + this.max_allowed.GetHashCode();
                if (this.payment_method != null)
                {
                    hashCode = (hashCode * 59) + this.payment_method.GetHashCode();
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
            // min_amount (decimal) minimum
            if (this.min_amount < (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for min_amount, must be a value greater than or equal to 1.", new [] { "min_amount" });
            }

            // max_allowed (decimal) minimum
            if (this.max_allowed < (decimal)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for max_allowed, must be a value greater than or equal to 1.", new [] { "max_allowed" });
            }

            yield break;
        }
    }

}

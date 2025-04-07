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
    /// Eligibile payment method object
    /// </summary>
    [DataContract(Name = "EligibilityMethodItem")]
    public class EligibilityMethodItem : IEquatable<EligibilityMethodItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EligibilityMethodItem" /> class.
        /// </summary>
        /// <param name="eligibility">Indicates whether the payment method is eligible..</param>
        /// <param name="entityType">Type of entity (e.g., \&quot;payment_methods\&quot;)..</param>
        /// <param name="entityValue">Payment method (e.g., enach, pnach, upi, card)..</param>
        /// <param name="entityDetails">entityDetails.</param>
        public EligibilityMethodItem(bool? eligibility = default(bool?), string? entityType = default(string?), string? entityValue = default(string?), EligibilityMethodItemEntityDetails? entityDetails = default(EligibilityMethodItemEntityDetails?))
        {
            this.eligibility = eligibility;
            this.entity_type = entityType;
            this.entity_value = entityValue;
            this.entity_details = entityDetails;
        }

        /// <summary>
        /// Indicates whether the payment method is eligible.
        /// </summary>
        /// <value>Indicates whether the payment method is eligible.</value>
        [DataMember(Name = "eligibility", EmitDefaultValue = true)]
        public bool? eligibility { get; set; }

        /// <summary>
        /// Type of entity (e.g., \&quot;payment_methods\&quot;).
        /// </summary>
        /// <value>Type of entity (e.g., \&quot;payment_methods\&quot;).</value>
        [DataMember(Name = "entity_type", EmitDefaultValue = false)]
        public string? entity_type { get; set; }

        /// <summary>
        /// Payment method (e.g., enach, pnach, upi, card).
        /// </summary>
        /// <value>Payment method (e.g., enach, pnach, upi, card).</value>
        [DataMember(Name = "entity_value", EmitDefaultValue = false)]
        public string? entity_value { get; set; }

        /// <summary>
        /// Gets or Sets entity_details
        /// </summary>
        [DataMember(Name = "entity_details", EmitDefaultValue = false)]
        public EligibilityMethodItemEntityDetails? entity_details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EligibilityMethodItem {\n");
            sb.Append("  eligibility: ").Append(eligibility).Append("\n");
            sb.Append("  entity_type: ").Append(entity_type).Append("\n");
            sb.Append("  entity_value: ").Append(entity_value).Append("\n");
            sb.Append("  entity_details: ").Append(entity_details).Append("\n");
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
            return this.Equals(input as EligibilityMethodItem);
        }

        /// <summary>
        /// Returns true if EligibilityMethodItem instances are equal
        /// </summary>
        /// <param name="input">Instance of EligibilityMethodItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EligibilityMethodItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.eligibility == input.eligibility ||
                    this.eligibility.Equals(input.eligibility)
                ) && 
                (
                    this.entity_type == input.entity_type ||
                    (this.entity_type != null &&
                    this.entity_type.Equals(input.entity_type))
                ) && 
                (
                    this.entity_value == input.entity_value ||
                    (this.entity_value != null &&
                    this.entity_value.Equals(input.entity_value))
                ) && 
                (
                    this.entity_details == input.entity_details ||
                    (this.entity_details != null &&
                    this.entity_details.Equals(input.entity_details))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringeligibility) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringeligibility);
            if (deserializedJsonString.ContainsKey("eligibility")) {
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
                hashCode = (hashCode * 59) + this.eligibility.GetHashCode();
                if (this.entity_type != null)
                {
                    hashCode = (hashCode * 59) + this.entity_type.GetHashCode();
                }
                if (this.entity_value != null)
                {
                    hashCode = (hashCode * 59) + this.entity_value.GetHashCode();
                }
                if (this.entity_details != null)
                {
                    hashCode = (hashCode * 59) + this.entity_details.GetHashCode();
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

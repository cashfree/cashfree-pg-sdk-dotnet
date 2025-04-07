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
    /// OfferNBNetbanking
    /// </summary>
    [DataContract(Name = "OfferNB_netbanking")]
    public class OfferNBNetbanking : IEquatable<OfferNBNetbanking>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferNBNetbanking" /> class.
        /// </summary>
        /// <param name="bankName">bankName.</param>
        public OfferNBNetbanking(string? bankName = default(string?))
        {
            this.bank_name = bankName;
        }

        /// <summary>
        /// Gets or Sets bank_name
        /// </summary>
        /// <example>all</example>
        [DataMember(Name = "bank_name", EmitDefaultValue = false)]
        public string? bank_name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OfferNBNetbanking {\n");
            sb.Append("  bank_name: ").Append(bank_name).Append("\n");
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
            return this.Equals(input as OfferNBNetbanking);
        }

        /// <summary>
        /// Returns true if OfferNBNetbanking instances are equal
        /// </summary>
        /// <param name="input">Instance of OfferNBNetbanking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferNBNetbanking input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.bank_name == input.bank_name ||
                    (this.bank_name != null &&
                    this.bank_name.Equals(input.bank_name))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringbank_name) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringbank_name);
            if (deserializedJsonString.ContainsKey("bank_name")) {
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
                if (this.bank_name != null)
                {
                    hashCode = (hashCode * 59) + this.bank_name.GetHashCode();
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

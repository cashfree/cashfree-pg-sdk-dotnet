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
    /// CardOffer
    /// </summary>
    [DataContract(Name = "Card_Offer")]
    public class CardOffer : IEquatable<CardOffer>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardOffer" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardOffer() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardOffer" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="bankName">Bank Name of Card. (required).</param>
        /// <param name="schemeName">schemeName (required).</param>
        public CardOffer(List<string> type = default(List<string>), string bankName = default(string), List<string> schemeName = default(List<string>))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for CardOffer and cannot be null");
            }
            this.type = type;
            // to ensure "bankName" is required (not null)
            if (bankName == null)
            {
                throw new ArgumentNullException("bankName is a required property for CardOffer and cannot be null");
            }
            this.bank_name = bankName;
            // to ensure "schemeName" is required (not null)
            if (schemeName == null)
            {
                throw new ArgumentNullException("schemeName is a required property for CardOffer and cannot be null");
            }
            this.scheme_name = schemeName;
        }

        /// <summary>
        /// Gets or Sets type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public List<string> type { get; set; }

        /// <summary>
        /// Bank Name of Card.
        /// </summary>
        /// <value>Bank Name of Card.</value>
        /// <example>hdfc bank</example>
        [DataMember(Name = "bank_name", IsRequired = true, EmitDefaultValue = true)]
        public string bank_name { get; set; }

        /// <summary>
        /// Gets or Sets scheme_name
        /// </summary>
        [DataMember(Name = "scheme_name", IsRequired = true, EmitDefaultValue = true)]
        public List<string> scheme_name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardOffer {\n");
            sb.Append("  type: ").Append(type).Append("\n");
            sb.Append("  bank_name: ").Append(bank_name).Append("\n");
            sb.Append("  scheme_name: ").Append(scheme_name).Append("\n");
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
            return this.Equals(input as CardOffer);
        }

        /// <summary>
        /// Returns true if CardOffer instances are equal
        /// </summary>
        /// <param name="input">Instance of CardOffer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardOffer input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.type == input.type ||
                    this.type != null &&
                    input.type != null &&
                    this.type.SequenceEqual(input.type)
                ) && 
                (
                    this.bank_name == input.bank_name ||
                    (this.bank_name != null &&
                    this.bank_name.Equals(input.bank_name))
                ) && 
                (
                    this.scheme_name == input.scheme_name ||
                    this.scheme_name != null &&
                    input.scheme_name != null &&
                    this.scheme_name.SequenceEqual(input.scheme_name)
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringtype) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringtype);
            if (deserializedJsonString.ContainsKey("type")) {
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
                if (this.type != null)
                {
                    hashCode = (hashCode * 59) + this.type.GetHashCode();
                }
                if (this.bank_name != null)
                {
                    hashCode = (hashCode * 59) + this.bank_name.GetHashCode();
                }
                if (this.scheme_name != null)
                {
                    hashCode = (hashCode * 59) + this.scheme_name.GetHashCode();
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
            // bank_name (string) maxLength
            if (this.bank_name != null && this.bank_name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for bank_name, length must be less than 100.", new [] { "bank_name" });
            }

            // bank_name (string) minLength
            if (this.bank_name != null && this.bank_name.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for bank_name, length must be greater than 3.", new [] { "bank_name" });
            }

            yield break;
        }
    }

}

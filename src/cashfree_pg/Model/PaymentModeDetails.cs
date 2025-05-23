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
    /// payment mode eligiblity object
    /// </summary>
    [DataContract(Name = "PaymentModeDetails")]
    public class PaymentModeDetails : IEquatable<PaymentModeDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentModeDetails" /> class.
        /// </summary>
        /// <param name="nick">nick.</param>
        /// <param name="display">display.</param>
        /// <param name="eligibility">eligibility.</param>
        /// <param name="code">code.</param>
        public PaymentModeDetails(string? nick = default(string?), string? display = default(string?), bool? eligibility = default(bool?), decimal? code = default(decimal?))
        {
            this.nick = nick;
            this.display = display;
            this.eligibility = eligibility;
            this.code = code;
        }

        /// <summary>
        /// Gets or Sets nick
        /// </summary>
        /// <example>motak_kahindra_bank</example>
        [DataMember(Name = "nick", EmitDefaultValue = false)]
        public string? nick { get; set; }

        /// <summary>
        /// Gets or Sets display
        /// </summary>
        /// <example>Motak Mahindra Bank</example>
        [DataMember(Name = "display", EmitDefaultValue = false)]
        public string? display { get; set; }

        /// <summary>
        /// Gets or Sets eligibility
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "eligibility", EmitDefaultValue = true)]
        public bool? eligibility { get; set; }

        /// <summary>
        /// Gets or Sets code
        /// </summary>
        /// <example>3001</example>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public decimal? code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentModeDetails {\n");
            sb.Append("  nick: ").Append(nick).Append("\n");
            sb.Append("  display: ").Append(display).Append("\n");
            sb.Append("  eligibility: ").Append(eligibility).Append("\n");
            sb.Append("  code: ").Append(code).Append("\n");
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
            return this.Equals(input as PaymentModeDetails);
        }

        /// <summary>
        /// Returns true if PaymentModeDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentModeDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentModeDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.nick == input.nick ||
                    (this.nick != null &&
                    this.nick.Equals(input.nick))
                ) && 
                (
                    this.display == input.display ||
                    (this.display != null &&
                    this.display.Equals(input.display))
                ) && 
                (
                    this.eligibility == input.eligibility ||
                    this.eligibility.Equals(input.eligibility)
                ) && 
                (
                    this.code == input.code ||
                    this.code.Equals(input.code)
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringnick) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringnick);
            if (deserializedJsonString.ContainsKey("nick")) {
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
                if (this.nick != null)
                {
                    hashCode = (hashCode * 59) + this.nick.GetHashCode();
                }
                if (this.display != null)
                {
                    hashCode = (hashCode * 59) + this.display.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.eligibility.GetHashCode();
                hashCode = (hashCode * 59) + this.code.GetHashCode();
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

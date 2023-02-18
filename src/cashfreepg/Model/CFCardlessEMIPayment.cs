/*
 * New Payment Gateway APIs
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2022-01-01
 * Contact: nextgenapi@cashfree.com
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
using OpenAPIDateConverter = cashfreepg.Client.OpenAPIDateConverter;

namespace cashfreepg.Model
{
    /// <summary>
    /// CFCardlessEMIPayment
    /// </summary>
    [DataContract(Name = "CFCardlessEMIPayment")]
    public partial class CFCardlessEMIPayment : IEquatable<CFCardlessEMIPayment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFCardlessEMIPayment" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CFCardlessEMIPayment() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CFCardlessEMIPayment" /> class.
        /// </summary>
        /// <param name="cardlessEmi">cardlessEmi (required).</param>
        public CFCardlessEMIPayment(CFCardlessEMI? cardlessEmi = default(CFCardlessEMI?))
        {
            // to ensure "cardlessEmi" is required (not null)
            if (cardlessEmi == null) {
                throw new ArgumentNullException("cardlessEmi is a required property for CFCardlessEMIPayment and cannot be null");
            }
            this.CardlessEmi = cardlessEmi;
        }

        /// <summary>
        /// Gets or Sets CardlessEmi
        /// </summary>
        [DataMember(Name = "cardless_emi", IsRequired = true, EmitDefaultValue = false)]
        public CFCardlessEMI? CardlessEmi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CFCardlessEMIPayment {\n");
            sb.Append("  CardlessEmi: ").Append(CardlessEmi).Append("\n");
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
        public override bool Equals(object? input)
        {
            return this.Equals(input as CFCardlessEMIPayment);
        }

        /// <summary>
        /// Returns true if CFCardlessEMIPayment instances are equal
        /// </summary>
        /// <param name="input">Instance of CFCardlessEMIPayment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CFCardlessEMIPayment? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CardlessEmi == input.CardlessEmi ||
                    (this.CardlessEmi != null &&
                    this.CardlessEmi.Equals(input.CardlessEmi))
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
                if (this.CardlessEmi != null)
                {
                    hashCode = (hashCode * 59) + this.CardlessEmi.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

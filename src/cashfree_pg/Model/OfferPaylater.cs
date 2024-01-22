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
    /// Offer object for paylater
    /// </summary>
    [DataContract(Name = "OfferPaylater")]
    public class OfferPaylater : IEquatable<OfferPaylater>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferPaylater" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OfferPaylater() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferPaylater" /> class.
        /// </summary>
        /// <param name="paylater">paylater (required).</param>
        public OfferPaylater(PaylaterOffer paylater = default(PaylaterOffer))
        {
            // to ensure "paylater" is required (not null)
            if (paylater == null)
            {
                throw new ArgumentNullException("paylater is a required property for OfferPaylater and cannot be null");
            }
            this.paylater = paylater;
        }

        /// <summary>
        /// Gets or Sets paylater
        /// </summary>
        [DataMember(Name = "paylater", IsRequired = true, EmitDefaultValue = true)]
        public PaylaterOffer paylater { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OfferPaylater {\n");
            sb.Append("  paylater: ").Append(paylater).Append("\n");
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
            return this.Equals(input as OfferPaylater);
        }

        /// <summary>
        /// Returns true if OfferPaylater instances are equal
        /// </summary>
        /// <param name="input">Instance of OfferPaylater to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferPaylater input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.paylater == input.paylater ||
                    (this.paylater != null &&
                    this.paylater.Equals(input.paylater))
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
                if (this.paylater != null)
                {
                    hashCode = (hashCode * 59) + this.paylater.GetHashCode();
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

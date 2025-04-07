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
    /// Filter for offers
    /// </summary>
    [DataContract(Name = "OfferFilters")]
    public class OfferFilters : IEquatable<OfferFilters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferFilters" /> class.
        /// </summary>
        /// <param name="offerType">Array of offer_type to be filtered..</param>
        public OfferFilters(List<OfferType>? offerType = default(List<OfferType>?))
        {
            this.offer_type = offerType;
        }

        /// <summary>
        /// Array of offer_type to be filtered.
        /// </summary>
        /// <value>Array of offer_type to be filtered.</value>
        [DataMember(Name = "offer_type", EmitDefaultValue = false)]
        public List<OfferType>? offer_type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OfferFilters {\n");
            sb.Append("  offer_type: ").Append(offer_type).Append("\n");
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
            return this.Equals(input as OfferFilters);
        }

        /// <summary>
        /// Returns true if OfferFilters instances are equal
        /// </summary>
        /// <param name="input">Instance of OfferFilters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferFilters input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.offer_type == input.offer_type ||
                    this.offer_type != null &&
                    input.offer_type != null &&
                    this.offer_type.SequenceEqual(input.offer_type)
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringoffer_type) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringoffer_type);
            if (deserializedJsonString.ContainsKey("offer_type")) {
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
                if (this.offer_type != null)
                {
                    hashCode = (hashCode * 59) + this.offer_type.GetHashCode();
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

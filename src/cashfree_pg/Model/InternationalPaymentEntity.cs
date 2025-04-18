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
    /// International payment details
    /// </summary>
    [DataContract(Name = "InternationalPaymentEntity")]
    public class InternationalPaymentEntity : IEquatable<InternationalPaymentEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InternationalPaymentEntity" /> class.
        /// </summary>
        /// <param name="international">international.</param>
        public InternationalPaymentEntity(bool? international = default(bool?))
        {
            this.international = international;
        }

        /// <summary>
        /// Gets or Sets international
        /// </summary>
        [DataMember(Name = "international", EmitDefaultValue = true)]
        public bool? international { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InternationalPaymentEntity {\n");
            sb.Append("  international: ").Append(international).Append("\n");
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
            return this.Equals(input as InternationalPaymentEntity);
        }

        /// <summary>
        /// Returns true if InternationalPaymentEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of InternationalPaymentEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InternationalPaymentEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.international == input.international ||
                    this.international.Equals(input.international)
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringinternational) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringinternational);
            if (deserializedJsonString.ContainsKey("international")) {
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
                hashCode = (hashCode * 59) + this.international.GetHashCode();
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

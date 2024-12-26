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
    /// EvidencesToContestDispute
    /// </summary>
    [DataContract(Name = "EvidencesToContestDispute")]
    public class EvidencesToContestDispute : IEquatable<EvidencesToContestDispute>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvidencesToContestDispute" /> class.
        /// </summary>
        /// <param name="documentType">documentType.</param>
        /// <param name="documentDescription">documentDescription.</param>
        public EvidencesToContestDispute(string? documentType = default(string?), string? documentDescription = default(string?))
        {
            this.document_type = documentType;
            this.document_description = documentDescription;
        }

        /// <summary>
        /// Gets or Sets document_type
        /// </summary>
        [DataMember(Name = "document_type", EmitDefaultValue = false)]
        public string? document_type { get; set; }

        /// <summary>
        /// Gets or Sets document_description
        /// </summary>
        [DataMember(Name = "document_description", EmitDefaultValue = false)]
        public string? document_description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EvidencesToContestDispute {\n");
            sb.Append("  document_type: ").Append(document_type).Append("\n");
            sb.Append("  document_description: ").Append(document_description).Append("\n");
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
            return this.Equals(input as EvidencesToContestDispute);
        }

        /// <summary>
        /// Returns true if EvidencesToContestDispute instances are equal
        /// </summary>
        /// <param name="input">Instance of EvidencesToContestDispute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvidencesToContestDispute input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.document_type == input.document_type ||
                    (this.document_type != null &&
                    this.document_type.Equals(input.document_type))
                ) && 
                (
                    this.document_description == input.document_description ||
                    (this.document_description != null &&
                    this.document_description.Equals(input.document_description))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringdocument_type) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringdocument_type);
            if (deserializedJsonString.ContainsKey("document_type")) {
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
                if (this.document_type != null)
                {
                    hashCode = (hashCode * 59) + this.document_type.GetHashCode();
                }
                if (this.document_description != null)
                {
                    hashCode = (hashCode * 59) + this.document_description.GetHashCode();
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
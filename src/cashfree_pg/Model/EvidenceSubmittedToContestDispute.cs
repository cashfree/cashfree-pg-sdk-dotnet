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
    /// EvidenceSubmittedToContestDispute
    /// </summary>
    [DataContract(Name = "EvidenceSubmittedToContestDispute")]
    public class EvidenceSubmittedToContestDispute : IEquatable<EvidenceSubmittedToContestDispute>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EvidenceSubmittedToContestDispute" /> class.
        /// </summary>
        /// <param name="documentId">documentId.</param>
        /// <param name="documentName">documentName.</param>
        /// <param name="documentType">documentType.</param>
        /// <param name="downloadUrl">downloadUrl.</param>
        public EvidenceSubmittedToContestDispute(int? documentId = default(int?), string? documentName = default(string?), string? documentType = default(string?), string? downloadUrl = default(string?))
        {
            this.documentId = documentId;
            this.documentName = documentName;
            this.documentType = documentType;
            this.downloadUrl = downloadUrl;
        }

        /// <summary>
        /// Gets or Sets documentId
        /// </summary>
        [DataMember(Name = "documentId", EmitDefaultValue = false)]
        public int? documentId { get; set; }

        /// <summary>
        /// Gets or Sets documentName
        /// </summary>
        [DataMember(Name = "documentName", EmitDefaultValue = false)]
        public string? documentName { get; set; }

        /// <summary>
        /// Gets or Sets documentType
        /// </summary>
        [DataMember(Name = "documentType", EmitDefaultValue = false)]
        public string? documentType { get; set; }

        /// <summary>
        /// Gets or Sets downloadUrl
        /// </summary>
        [DataMember(Name = "downloadUrl", EmitDefaultValue = false)]
        public string? downloadUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EvidenceSubmittedToContestDispute {\n");
            sb.Append("  documentId: ").Append(documentId).Append("\n");
            sb.Append("  documentName: ").Append(documentName).Append("\n");
            sb.Append("  documentType: ").Append(documentType).Append("\n");
            sb.Append("  downloadUrl: ").Append(downloadUrl).Append("\n");
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
            return this.Equals(input as EvidenceSubmittedToContestDispute);
        }

        /// <summary>
        /// Returns true if EvidenceSubmittedToContestDispute instances are equal
        /// </summary>
        /// <param name="input">Instance of EvidenceSubmittedToContestDispute to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EvidenceSubmittedToContestDispute input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.documentId == input.documentId ||
                    this.documentId.Equals(input.documentId)
                ) && 
                (
                    this.documentName == input.documentName ||
                    (this.documentName != null &&
                    this.documentName.Equals(input.documentName))
                ) && 
                (
                    this.documentType == input.documentType ||
                    (this.documentType != null &&
                    this.documentType.Equals(input.documentType))
                ) && 
                (
                    this.downloadUrl == input.downloadUrl ||
                    (this.downloadUrl != null &&
                    this.downloadUrl.Equals(input.downloadUrl))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringdocumentId) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringdocumentId);
            if (deserializedJsonString.ContainsKey("documentId")) {
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
                hashCode = (hashCode * 59) + this.documentId.GetHashCode();
                if (this.documentName != null)
                {
                    hashCode = (hashCode * 59) + this.documentName.GetHashCode();
                }
                if (this.documentType != null)
                {
                    hashCode = (hashCode * 59) + this.documentType.GetHashCode();
                }
                if (this.downloadUrl != null)
                {
                    hashCode = (hashCode * 59) + this.downloadUrl.GetHashCode();
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
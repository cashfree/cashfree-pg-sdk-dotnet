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
    /// Upload the terminal documents.
    /// </summary>
    [DataContract(Name = "UploadTerminalDocsEntity")]
    public class UploadTerminalDocsEntity : IEquatable<UploadTerminalDocsEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadTerminalDocsEntity" /> class.
        /// </summary>
        /// <param name="cfTerminalId">cfTerminalId.</param>
        /// <param name="docType">docType.</param>
        /// <param name="docValue">docValue.</param>
        /// <param name="status">status.</param>
        public UploadTerminalDocsEntity(int cfTerminalId = default(int), string docType = default(string), string docValue = default(string), string status = default(string))
        {
            this.cf_terminal_id = cfTerminalId;
            this.doc_type = docType;
            this.doc_value = docValue;
            this.status = status;
        }

        /// <summary>
        /// Gets or Sets cf_terminal_id
        /// </summary>
        [DataMember(Name = "cf_terminal_id", EmitDefaultValue = false)]
        public int cf_terminal_id { get; set; }

        /// <summary>
        /// Gets or Sets doc_type
        /// </summary>
        [DataMember(Name = "doc_type", EmitDefaultValue = false)]
        public string doc_type { get; set; }

        /// <summary>
        /// Gets or Sets doc_value
        /// </summary>
        [DataMember(Name = "doc_value", EmitDefaultValue = false)]
        public string doc_value { get; set; }

        /// <summary>
        /// Gets or Sets status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UploadTerminalDocsEntity {\n");
            sb.Append("  cf_terminal_id: ").Append(cf_terminal_id).Append("\n");
            sb.Append("  doc_type: ").Append(doc_type).Append("\n");
            sb.Append("  doc_value: ").Append(doc_value).Append("\n");
            sb.Append("  status: ").Append(status).Append("\n");
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
            return this.Equals(input as UploadTerminalDocsEntity);
        }

        /// <summary>
        /// Returns true if UploadTerminalDocsEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of UploadTerminalDocsEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UploadTerminalDocsEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cf_terminal_id == input.cf_terminal_id ||
                    this.cf_terminal_id.Equals(input.cf_terminal_id)
                ) && 
                (
                    this.doc_type == input.doc_type ||
                    (this.doc_type != null &&
                    this.doc_type.Equals(input.doc_type))
                ) && 
                (
                    this.doc_value == input.doc_value ||
                    (this.doc_value != null &&
                    this.doc_value.Equals(input.doc_value))
                ) && 
                (
                    this.status == input.status ||
                    (this.status != null &&
                    this.status.Equals(input.status))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringcf_terminal_id) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringcf_terminal_id);
            if (deserializedJsonString.ContainsKey("cf_terminal_id")) {
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
                hashCode = (hashCode * 59) + this.cf_terminal_id.GetHashCode();
                if (this.doc_type != null)
                {
                    hashCode = (hashCode * 59) + this.doc_type.GetHashCode();
                }
                if (this.doc_value != null)
                {
                    hashCode = (hashCode * 59) + this.doc_value.GetHashCode();
                }
                if (this.status != null)
                {
                    hashCode = (hashCode * 59) + this.status.GetHashCode();
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

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
    /// error details present in the webhook
    /// </summary>
    [DataContract(Name = "PaymentWebhookErrorEntity")]
    public class PaymentWebhookErrorEntity : IEquatable<PaymentWebhookErrorEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentWebhookErrorEntity" /> class.
        /// </summary>
        /// <param name="errorCode">errorCode.</param>
        /// <param name="errorDescription">errorDescription.</param>
        /// <param name="errorReason">errorReason.</param>
        /// <param name="errorSource">errorSource.</param>
        /// <param name="errorCodeRaw">errorCodeRaw.</param>
        /// <param name="errorDescriptionRaw">errorDescriptionRaw.</param>
        public PaymentWebhookErrorEntity(string errorCode = default(string), string errorDescription = default(string), string errorReason = default(string), string errorSource = default(string), string errorCodeRaw = default(string), string errorDescriptionRaw = default(string))
        {
            this.error_code = errorCode;
            this.error_description = errorDescription;
            this.error_reason = errorReason;
            this.error_source = errorSource;
            this.error_code_raw = errorCodeRaw;
            this.error_description_raw = errorDescriptionRaw;
        }

        /// <summary>
        /// Gets or Sets error_code
        /// </summary>
        [DataMember(Name = "error_code", EmitDefaultValue = false)]
        public string error_code { get; set; }

        /// <summary>
        /// Gets or Sets error_description
        /// </summary>
        [DataMember(Name = "error_description", EmitDefaultValue = false)]
        public string error_description { get; set; }

        /// <summary>
        /// Gets or Sets error_reason
        /// </summary>
        [DataMember(Name = "error_reason", EmitDefaultValue = false)]
        public string error_reason { get; set; }

        /// <summary>
        /// Gets or Sets error_source
        /// </summary>
        [DataMember(Name = "error_source", EmitDefaultValue = false)]
        public string error_source { get; set; }

        /// <summary>
        /// Gets or Sets error_code_raw
        /// </summary>
        [DataMember(Name = "error_code_raw", EmitDefaultValue = false)]
        public string error_code_raw { get; set; }

        /// <summary>
        /// Gets or Sets error_description_raw
        /// </summary>
        [DataMember(Name = "error_description_raw", EmitDefaultValue = false)]
        public string error_description_raw { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentWebhookErrorEntity {\n");
            sb.Append("  error_code: ").Append(error_code).Append("\n");
            sb.Append("  error_description: ").Append(error_description).Append("\n");
            sb.Append("  error_reason: ").Append(error_reason).Append("\n");
            sb.Append("  error_source: ").Append(error_source).Append("\n");
            sb.Append("  error_code_raw: ").Append(error_code_raw).Append("\n");
            sb.Append("  error_description_raw: ").Append(error_description_raw).Append("\n");
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
            return this.Equals(input as PaymentWebhookErrorEntity);
        }

        /// <summary>
        /// Returns true if PaymentWebhookErrorEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentWebhookErrorEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentWebhookErrorEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.error_code == input.error_code ||
                    (this.error_code != null &&
                    this.error_code.Equals(input.error_code))
                ) && 
                (
                    this.error_description == input.error_description ||
                    (this.error_description != null &&
                    this.error_description.Equals(input.error_description))
                ) && 
                (
                    this.error_reason == input.error_reason ||
                    (this.error_reason != null &&
                    this.error_reason.Equals(input.error_reason))
                ) && 
                (
                    this.error_source == input.error_source ||
                    (this.error_source != null &&
                    this.error_source.Equals(input.error_source))
                ) && 
                (
                    this.error_code_raw == input.error_code_raw ||
                    (this.error_code_raw != null &&
                    this.error_code_raw.Equals(input.error_code_raw))
                ) && 
                (
                    this.error_description_raw == input.error_description_raw ||
                    (this.error_description_raw != null &&
                    this.error_description_raw.Equals(input.error_description_raw))
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
                if (this.error_code != null)
                {
                    hashCode = (hashCode * 59) + this.error_code.GetHashCode();
                }
                if (this.error_description != null)
                {
                    hashCode = (hashCode * 59) + this.error_description.GetHashCode();
                }
                if (this.error_reason != null)
                {
                    hashCode = (hashCode * 59) + this.error_reason.GetHashCode();
                }
                if (this.error_source != null)
                {
                    hashCode = (hashCode * 59) + this.error_source.GetHashCode();
                }
                if (this.error_code_raw != null)
                {
                    hashCode = (hashCode * 59) + this.error_code_raw.GetHashCode();
                }
                if (this.error_description_raw != null)
                {
                    hashCode = (hashCode * 59) + this.error_description_raw.GetHashCode();
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

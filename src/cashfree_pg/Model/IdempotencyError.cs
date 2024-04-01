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
    /// Error when idempotency fails. Different request body with the same idempotent key
    /// </summary>
    [DataContract(Name = "IdempotencyError")]
    public class IdempotencyError : IEquatable<IdempotencyError>, IValidatableObject
    {
        /// <summary>
        /// idempotency_error
        /// </summary>
        /// <value>idempotency_error</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum IdempotencyError for value: idempotency_error
            /// </summary>
            [EnumMember(Value = "idempotency_error")]
            IdempotencyError = 1
        }


        /// <summary>
        /// idempotency_error
        /// </summary>
        /// <value>idempotency_error</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="IdempotencyError" /> class.
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="code">code.</param>
        /// <param name="type">idempotency_error.</param>
        public IdempotencyError(string? message = default(string?), string? code = default(string?), TypeEnum? type = default(TypeEnum??))
        {
            this.message = message;
            this.code = code;
            this.type = type;
        }

        /// <summary>
        /// Gets or Sets message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string? message { get; set; }

        /// <summary>
        /// Gets or Sets code
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string? code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class IdempotencyError {\n");
            sb.Append("  message: ").Append(message).Append("\n");
            sb.Append("  code: ").Append(code).Append("\n");
            sb.Append("  type: ").Append(type).Append("\n");
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
            return this.Equals(input as IdempotencyError);
        }

        /// <summary>
        /// Returns true if IdempotencyError instances are equal
        /// </summary>
        /// <param name="input">Instance of IdempotencyError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdempotencyError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.message == input.message ||
                    (this.message != null &&
                    this.message.Equals(input.message))
                ) && 
                (
                    this.code == input.code ||
                    (this.code != null &&
                    this.code.Equals(input.code))
                ) && 
                (
                    this.type == input.type ||
                    this.type.Equals(input.type)
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringmessage) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringmessage);
            if (deserializedJsonString.ContainsKey("message")) {
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
                if (this.message != null)
                {
                    hashCode = (hashCode * 59) + this.message.GetHashCode();
                }
                if (this.code != null)
                {
                    hashCode = (hashCode * 59) + this.code.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.type.GetHashCode();
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

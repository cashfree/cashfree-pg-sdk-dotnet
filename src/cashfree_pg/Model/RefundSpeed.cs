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
    /// How fast refund has to be proecessed
    /// </summary>
    [DataContract(Name = "RefundSpeed")]
    public class RefundSpeed : IEquatable<RefundSpeed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundSpeed" /> class.
        /// </summary>
        /// <param name="requested">Requested speed of refund..</param>
        /// <param name="accepted">Accepted speed of refund..</param>
        /// <param name="processed">Processed speed of refund..</param>
        /// <param name="message">Error message, if any for refund_speed request.</param>
        public RefundSpeed(string? requested = default(string?), string? accepted = default(string?), string? processed = default(string?), string? message = default(string?))
        {
            this.requested = requested;
            this.accepted = accepted;
            this.processed = processed;
            this.message = message;
        }

        /// <summary>
        /// Requested speed of refund.
        /// </summary>
        /// <value>Requested speed of refund.</value>
        [DataMember(Name = "requested", EmitDefaultValue = false)]
        public string? requested { get; set; }

        /// <summary>
        /// Accepted speed of refund.
        /// </summary>
        /// <value>Accepted speed of refund.</value>
        [DataMember(Name = "accepted", EmitDefaultValue = false)]
        public string? accepted { get; set; }

        /// <summary>
        /// Processed speed of refund.
        /// </summary>
        /// <value>Processed speed of refund.</value>
        [DataMember(Name = "processed", EmitDefaultValue = false)]
        public string? processed { get; set; }

        /// <summary>
        /// Error message, if any for refund_speed request
        /// </summary>
        /// <value>Error message, if any for refund_speed request</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string? message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RefundSpeed {\n");
            sb.Append("  requested: ").Append(requested).Append("\n");
            sb.Append("  accepted: ").Append(accepted).Append("\n");
            sb.Append("  processed: ").Append(processed).Append("\n");
            sb.Append("  message: ").Append(message).Append("\n");
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
            return this.Equals(input as RefundSpeed);
        }

        /// <summary>
        /// Returns true if RefundSpeed instances are equal
        /// </summary>
        /// <param name="input">Instance of RefundSpeed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundSpeed input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.requested == input.requested ||
                    (this.requested != null &&
                    this.requested.Equals(input.requested))
                ) && 
                (
                    this.accepted == input.accepted ||
                    (this.accepted != null &&
                    this.accepted.Equals(input.accepted))
                ) && 
                (
                    this.processed == input.processed ||
                    (this.processed != null &&
                    this.processed.Equals(input.processed))
                ) && 
                (
                    this.message == input.message ||
                    (this.message != null &&
                    this.message.Equals(input.message))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringrequested) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringrequested);
            if (deserializedJsonString.ContainsKey("requested")) {
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
                if (this.requested != null)
                {
                    hashCode = (hashCode * 59) + this.requested.GetHashCode();
                }
                if (this.accepted != null)
                {
                    hashCode = (hashCode * 59) + this.accepted.GetHashCode();
                }
                if (this.processed != null)
                {
                    hashCode = (hashCode * 59) + this.processed.GetHashCode();
                }
                if (this.message != null)
                {
                    hashCode = (hashCode * 59) + this.message.GetHashCode();
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

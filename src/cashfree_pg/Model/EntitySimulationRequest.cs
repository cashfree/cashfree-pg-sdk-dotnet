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
    /// Entity Simulation it contains payment_status and payment_error_code
    /// </summary>
    [DataContract(Name = "EntitySimulationRequest")]
    public class EntitySimulationRequest : IEquatable<EntitySimulationRequest>, IValidatableObject
    {
        /// <summary>
        /// Payment Status
        /// </summary>
        /// <value>Payment Status</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentStatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 1,

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 2,

            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 3,

            /// <summary>
            /// Enum USERDROPPED for value: USER_DROPPED
            /// </summary>
            [EnumMember(Value = "USER_DROPPED")]
            USERDROPPED = 4
        }


        /// <summary>
        /// Payment Status
        /// </summary>
        /// <value>Payment Status</value>
        [DataMember(Name = "payment_status", IsRequired = true, EmitDefaultValue = true)]
        public PaymentStatusEnum payment_status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitySimulationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EntitySimulationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EntitySimulationRequest" /> class.
        /// </summary>
        /// <param name="paymentStatus">Payment Status (required).</param>
        /// <param name="paymentErrorCode">Payment Error Code.</param>
        public EntitySimulationRequest(PaymentStatusEnum paymentStatus = default(PaymentStatusEnum), string? paymentErrorCode = default(string?))
        {
            this.payment_status = paymentStatus;
            this.payment_error_code = paymentErrorCode;
        }

        /// <summary>
        /// Payment Error Code
        /// </summary>
        /// <value>Payment Error Code</value>
        [DataMember(Name = "payment_error_code", EmitDefaultValue = false)]
        public string? payment_error_code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EntitySimulationRequest {\n");
            sb.Append("  payment_status: ").Append(payment_status).Append("\n");
            sb.Append("  payment_error_code: ").Append(payment_error_code).Append("\n");
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
            return this.Equals(input as EntitySimulationRequest);
        }

        /// <summary>
        /// Returns true if EntitySimulationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EntitySimulationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EntitySimulationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.payment_status == input.payment_status ||
                    this.payment_status.Equals(input.payment_status)
                ) && 
                (
                    this.payment_error_code == input.payment_error_code ||
                    (this.payment_error_code != null &&
                    this.payment_error_code.Equals(input.payment_error_code))
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
                hashCode = (hashCode * 59) + this.payment_status.GetHashCode();
                if (this.payment_error_code != null)
                {
                    hashCode = (hashCode * 59) + this.payment_error_code.GetHashCode();
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

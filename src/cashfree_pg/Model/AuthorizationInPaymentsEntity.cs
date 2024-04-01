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
    /// If preauth enabled for account you will get this body
    /// </summary>
    [DataContract(Name = "AuthorizationInPaymentsEntity")]
    public class AuthorizationInPaymentsEntity : IEquatable<AuthorizationInPaymentsEntity>, IValidatableObject
    {
        /// <summary>
        /// One of CAPTURE or VOID
        /// </summary>
        /// <value>One of CAPTURE or VOID</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum CAPTURE for value: CAPTURE
            /// </summary>
            [EnumMember(Value = "CAPTURE")]
            CAPTURE = 1,

            /// <summary>
            /// Enum VOID for value: VOID
            /// </summary>
            [EnumMember(Value = "VOID")]
            VOID = 2
        }


        /// <summary>
        /// One of CAPTURE or VOID
        /// </summary>
        /// <value>One of CAPTURE or VOID</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public ActionEnum? action { get; set; }
        /// <summary>
        /// One of SUCCESS or PENDING
        /// </summary>
        /// <value>One of SUCCESS or PENDING</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 1,

            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 2
        }


        /// <summary>
        /// One of SUCCESS or PENDING
        /// </summary>
        /// <value>One of SUCCESS or PENDING</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationInPaymentsEntity" /> class.
        /// </summary>
        /// <param name="action">One of CAPTURE or VOID.</param>
        /// <param name="status">One of SUCCESS or PENDING.</param>
        /// <param name="capturedAmount">The captured amount for this authorization request.</param>
        /// <param name="startTime">Start time of this authorization hold (only for UPI).</param>
        /// <param name="endTime">End time of this authorization hold (only for UPI).</param>
        /// <param name="approveBy">Approve by time as passed in the authorization request (only for UPI).</param>
        /// <param name="actionReference">CAPTURE or VOID reference number based on action .</param>
        /// <param name="actionTime">Time of action (CAPTURE or VOID).</param>
        public AuthorizationInPaymentsEntity(ActionEnum?? action = default(ActionEnum??), StatusEnum?? status = default(StatusEnum??), decimal? capturedAmount = default(decimal?), string? startTime = default(string?), string? endTime = default(string?), string? approveBy = default(string?), string? actionReference = default(string?), string? actionTime = default(string?))
        {
            this.action = action;
            this.status = status;
            this.captured_amount = capturedAmount;
            this.start_time = startTime;
            this.end_time = endTime;
            this.approve_by = approveBy;
            this.action_reference = actionReference;
            this.action_time = actionTime;
        }

        /// <summary>
        /// The captured amount for this authorization request
        /// </summary>
        /// <value>The captured amount for this authorization request</value>
        [DataMember(Name = "captured_amount", EmitDefaultValue = false)]
        public decimal? captured_amount { get; set; }

        /// <summary>
        /// Start time of this authorization hold (only for UPI)
        /// </summary>
        /// <value>Start time of this authorization hold (only for UPI)</value>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string? start_time { get; set; }

        /// <summary>
        /// End time of this authorization hold (only for UPI)
        /// </summary>
        /// <value>End time of this authorization hold (only for UPI)</value>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public string? end_time { get; set; }

        /// <summary>
        /// Approve by time as passed in the authorization request (only for UPI)
        /// </summary>
        /// <value>Approve by time as passed in the authorization request (only for UPI)</value>
        [DataMember(Name = "approve_by", EmitDefaultValue = false)]
        public string? approve_by { get; set; }

        /// <summary>
        /// CAPTURE or VOID reference number based on action 
        /// </summary>
        /// <value>CAPTURE or VOID reference number based on action </value>
        [DataMember(Name = "action_reference", EmitDefaultValue = false)]
        public string? action_reference { get; set; }

        /// <summary>
        /// Time of action (CAPTURE or VOID)
        /// </summary>
        /// <value>Time of action (CAPTURE or VOID)</value>
        [DataMember(Name = "action_time", EmitDefaultValue = false)]
        public string? action_time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthorizationInPaymentsEntity {\n");
            sb.Append("  action: ").Append(action).Append("\n");
            sb.Append("  status: ").Append(status).Append("\n");
            sb.Append("  captured_amount: ").Append(captured_amount).Append("\n");
            sb.Append("  start_time: ").Append(start_time).Append("\n");
            sb.Append("  end_time: ").Append(end_time).Append("\n");
            sb.Append("  approve_by: ").Append(approve_by).Append("\n");
            sb.Append("  action_reference: ").Append(action_reference).Append("\n");
            sb.Append("  action_time: ").Append(action_time).Append("\n");
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
            return this.Equals(input as AuthorizationInPaymentsEntity);
        }

        /// <summary>
        /// Returns true if AuthorizationInPaymentsEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthorizationInPaymentsEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthorizationInPaymentsEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.action == input.action ||
                    this.action.Equals(input.action)
                ) && 
                (
                    this.status == input.status ||
                    this.status.Equals(input.status)
                ) && 
                (
                    this.captured_amount == input.captured_amount ||
                    this.captured_amount.Equals(input.captured_amount)
                ) && 
                (
                    this.start_time == input.start_time ||
                    (this.start_time != null &&
                    this.start_time.Equals(input.start_time))
                ) && 
                (
                    this.end_time == input.end_time ||
                    (this.end_time != null &&
                    this.end_time.Equals(input.end_time))
                ) && 
                (
                    this.approve_by == input.approve_by ||
                    (this.approve_by != null &&
                    this.approve_by.Equals(input.approve_by))
                ) && 
                (
                    this.action_reference == input.action_reference ||
                    (this.action_reference != null &&
                    this.action_reference.Equals(input.action_reference))
                ) && 
                (
                    this.action_time == input.action_time ||
                    (this.action_time != null &&
                    this.action_time.Equals(input.action_time))
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
                hashCode = (hashCode * 59) + this.action.GetHashCode();
                hashCode = (hashCode * 59) + this.status.GetHashCode();
                hashCode = (hashCode * 59) + this.captured_amount.GetHashCode();
                if (this.start_time != null)
                {
                    hashCode = (hashCode * 59) + this.start_time.GetHashCode();
                }
                if (this.end_time != null)
                {
                    hashCode = (hashCode * 59) + this.end_time.GetHashCode();
                }
                if (this.approve_by != null)
                {
                    hashCode = (hashCode * 59) + this.approve_by.GetHashCode();
                }
                if (this.action_reference != null)
                {
                    hashCode = (hashCode * 59) + this.action_reference.GetHashCode();
                }
                if (this.action_time != null)
                {
                    hashCode = (hashCode * 59) + this.action_time.GetHashCode();
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

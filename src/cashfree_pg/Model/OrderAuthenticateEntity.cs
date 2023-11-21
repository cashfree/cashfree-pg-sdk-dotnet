/*
 * Cashfree Payment Gateway APIs
 *
 * Cashfree's Payment Gateway APIs provide developers with a streamlined pathway to integrate advanced payment processing capabilities into their applications, platforms and websites.
 *
 * The version of the OpenAPI document: 2022-09-01
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
    /// This is the response shared when merchant inovkes the OTP submit or resend API
    /// </summary>
    [DataContract(Name = "OrderAuthenticateEntity")]
    public class OrderAuthenticateEntity : IEquatable<OrderAuthenticateEntity>, IValidatableObject
    {
        /// <summary>
        /// The action that was invoked for this request.
        /// </summary>
        /// <value>The action that was invoked for this request.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum SUBMITOTP for value: SUBMIT_OTP
            /// </summary>
            [EnumMember(Value = "SUBMIT_OTP")]
            SUBMITOTP = 1,

            /// <summary>
            /// Enum RESENDOTP for value: RESEND_OTP
            /// </summary>
            [EnumMember(Value = "RESEND_OTP")]
            RESENDOTP = 2
        }


        /// <summary>
        /// The action that was invoked for this request.
        /// </summary>
        /// <value>The action that was invoked for this request.</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public ActionEnum? action { get; set; }
        /// <summary>
        /// Status of the is action. Will be either failed or successful. If the action is successful, you should still call the authorization status to verify the final payment status.
        /// </summary>
        /// <value>Status of the is action. Will be either failed or successful. If the action is successful, you should still call the authorization status to verify the final payment status.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthenticateStatusEnum
        {
            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 1,

            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 2
        }


        /// <summary>
        /// Status of the is action. Will be either failed or successful. If the action is successful, you should still call the authorization status to verify the final payment status.
        /// </summary>
        /// <value>Status of the is action. Will be either failed or successful. If the action is successful, you should still call the authorization status to verify the final payment status.</value>
        [DataMember(Name = "authenticate_status", EmitDefaultValue = false)]
        public AuthenticateStatusEnum? authenticate_status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderAuthenticateEntity" /> class.
        /// </summary>
        /// <param name="cfPaymentId">The payment id for which this request was sent.</param>
        /// <param name="action">The action that was invoked for this request..</param>
        /// <param name="authenticateStatus">Status of the is action. Will be either failed or successful. If the action is successful, you should still call the authorization status to verify the final payment status..</param>
        /// <param name="paymentMessage">Human readable message which describes the status in more detail.</param>
        public OrderAuthenticateEntity(decimal cfPaymentId = default(decimal), ActionEnum? action = default(ActionEnum?), AuthenticateStatusEnum? authenticateStatus = default(AuthenticateStatusEnum?), string paymentMessage = default(string))
        {
            this.cf_payment_id = cfPaymentId;
            this.action = action;
            this.authenticate_status = authenticateStatus;
            this.payment_message = paymentMessage;
        }

        /// <summary>
        /// The payment id for which this request was sent
        /// </summary>
        /// <value>The payment id for which this request was sent</value>
        [DataMember(Name = "cf_payment_id", EmitDefaultValue = false)]
        public decimal cf_payment_id { get; set; }

        /// <summary>
        /// Human readable message which describes the status in more detail
        /// </summary>
        /// <value>Human readable message which describes the status in more detail</value>
        [DataMember(Name = "payment_message", EmitDefaultValue = false)]
        public string payment_message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderAuthenticateEntity {\n");
            sb.Append("  cf_payment_id: ").Append(cf_payment_id).Append("\n");
            sb.Append("  action: ").Append(action).Append("\n");
            sb.Append("  authenticate_status: ").Append(authenticate_status).Append("\n");
            sb.Append("  payment_message: ").Append(payment_message).Append("\n");
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
            return this.Equals(input as OrderAuthenticateEntity);
        }

        /// <summary>
        /// Returns true if OrderAuthenticateEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderAuthenticateEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderAuthenticateEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cf_payment_id == input.cf_payment_id ||
                    this.cf_payment_id.Equals(input.cf_payment_id)
                ) && 
                (
                    this.action == input.action ||
                    this.action.Equals(input.action)
                ) && 
                (
                    this.authenticate_status == input.authenticate_status ||
                    this.authenticate_status.Equals(input.authenticate_status)
                ) && 
                (
                    this.payment_message == input.payment_message ||
                    (this.payment_message != null &&
                    this.payment_message.Equals(input.payment_message))
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
                hashCode = (hashCode * 59) + this.cf_payment_id.GetHashCode();
                hashCode = (hashCode * 59) + this.action.GetHashCode();
                hashCode = (hashCode * 59) + this.authenticate_status.GetHashCode();
                if (this.payment_message != null)
                {
                    hashCode = (hashCode * 59) + this.payment_message.GetHashCode();
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
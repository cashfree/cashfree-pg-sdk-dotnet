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
    /// payment entity full object
    /// </summary>
    [DataContract(Name = "PaymentEntity")]
    public class PaymentEntity : IEquatable<PaymentEntity>, IValidatableObject
    {
        /// <summary>
        /// The transaction status can be one of  [\&quot;SUCCESS\&quot;, \&quot;NOT_ATTEMPTED\&quot;, \&quot;FAILED\&quot;, \&quot;USER_DROPPED\&quot;, \&quot;VOID\&quot;, \&quot;CANCELLED\&quot;, \&quot;PENDING\&quot;]
        /// </summary>
        /// <value>The transaction status can be one of  [\&quot;SUCCESS\&quot;, \&quot;NOT_ATTEMPTED\&quot;, \&quot;FAILED\&quot;, \&quot;USER_DROPPED\&quot;, \&quot;VOID\&quot;, \&quot;CANCELLED\&quot;, \&quot;PENDING\&quot;]</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentStatusEnum
        {
            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 1,

            /// <summary>
            /// Enum NOTATTEMPTED for value: NOT_ATTEMPTED
            /// </summary>
            [EnumMember(Value = "NOT_ATTEMPTED")]
            NOTATTEMPTED = 2,

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 3,

            /// <summary>
            /// Enum USERDROPPED for value: USER_DROPPED
            /// </summary>
            [EnumMember(Value = "USER_DROPPED")]
            USERDROPPED = 4,

            /// <summary>
            /// Enum VOID for value: VOID
            /// </summary>
            [EnumMember(Value = "VOID")]
            VOID = 5,

            /// <summary>
            /// Enum CANCELLED for value: CANCELLED
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            CANCELLED = 6,

            /// <summary>
            /// Enum PENDING for value: PENDING
            /// </summary>
            [EnumMember(Value = "PENDING")]
            PENDING = 7
        }


        /// <summary>
        /// The transaction status can be one of  [\&quot;SUCCESS\&quot;, \&quot;NOT_ATTEMPTED\&quot;, \&quot;FAILED\&quot;, \&quot;USER_DROPPED\&quot;, \&quot;VOID\&quot;, \&quot;CANCELLED\&quot;, \&quot;PENDING\&quot;]
        /// </summary>
        /// <value>The transaction status can be one of  [\&quot;SUCCESS\&quot;, \&quot;NOT_ATTEMPTED\&quot;, \&quot;FAILED\&quot;, \&quot;USER_DROPPED\&quot;, \&quot;VOID\&quot;, \&quot;CANCELLED\&quot;, \&quot;PENDING\&quot;]</value>
        [DataMember(Name = "payment_status", EmitDefaultValue = false)]
        public PaymentStatusEnum? payment_status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentEntity" /> class.
        /// </summary>
        /// <param name="cfPaymentId">cfPaymentId.</param>
        /// <param name="orderId">orderId.</param>
        /// <param name="entity">entity.</param>
        /// <param name="errorDetails">errorDetails.</param>
        /// <param name="isCaptured">isCaptured.</param>
        /// <param name="orderAmount">Order amount can be different from payment amount if you collect service fee from the customer.</param>
        /// <param name="paymentGroup">Type of payment group. One of [&#39;upi&#39;, &#39;card&#39;, &#39;app&#39;, &#39;netbanking&#39;, &#39;paylater&#39;, &#39;cardless_emi&#39;].</param>
        /// <param name="paymentCurrency">paymentCurrency.</param>
        /// <param name="paymentAmount">paymentAmount.</param>
        /// <param name="paymentTime">This is the time when the payment was initiated.</param>
        /// <param name="paymentCompletionTime">This is the time when the payment reaches its terminal state.</param>
        /// <param name="paymentStatus">The transaction status can be one of  [\&quot;SUCCESS\&quot;, \&quot;NOT_ATTEMPTED\&quot;, \&quot;FAILED\&quot;, \&quot;USER_DROPPED\&quot;, \&quot;VOID\&quot;, \&quot;CANCELLED\&quot;, \&quot;PENDING\&quot;].</param>
        /// <param name="paymentMessage">paymentMessage.</param>
        /// <param name="bankReference">bankReference.</param>
        /// <param name="authId">authId.</param>
        /// <param name="authorization">authorization.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        public PaymentEntity(long cfPaymentId = default(long), string orderId = default(string), string entity = default(string), ErrorDetailsInPaymentsEntity errorDetails = default(ErrorDetailsInPaymentsEntity), bool isCaptured = default(bool), decimal orderAmount = default(decimal), string paymentGroup = default(string), string paymentCurrency = default(string), decimal paymentAmount = default(decimal), string paymentTime = default(string), string paymentCompletionTime = default(string), PaymentStatusEnum? paymentStatus = default(PaymentStatusEnum?), string paymentMessage = default(string), string bankReference = default(string), string authId = default(string), AuthorizationInPaymentsEntity authorization = default(AuthorizationInPaymentsEntity), PaymentMethodInPaymentsEntity paymentMethod = default(PaymentMethodInPaymentsEntity))
        {
            this.cf_payment_id = cfPaymentId;
            this.order_id = orderId;
            this.entity = entity;
            this.error_details = errorDetails;
            this.is_captured = isCaptured;
            this.order_amount = orderAmount;
            this.payment_group = paymentGroup;
            this.payment_currency = paymentCurrency;
            this.payment_amount = paymentAmount;
            this.payment_time = paymentTime;
            this.payment_completion_time = paymentCompletionTime;
            this.payment_status = paymentStatus;
            this.payment_message = paymentMessage;
            this.bank_reference = bankReference;
            this.auth_id = authId;
            this.authorization = authorization;
            this.payment_method = paymentMethod;
        }

        /// <summary>
        /// Gets or Sets cf_payment_id
        /// </summary>
        [DataMember(Name = "cf_payment_id", EmitDefaultValue = false)]
        public long cf_payment_id { get; set; }

        /// <summary>
        /// Gets or Sets order_id
        /// </summary>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string order_id { get; set; }

        /// <summary>
        /// Gets or Sets entity
        /// </summary>
        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public string entity { get; set; }

        /// <summary>
        /// Gets or Sets error_details
        /// </summary>
        [DataMember(Name = "error_details", EmitDefaultValue = false)]
        public ErrorDetailsInPaymentsEntity error_details { get; set; }

        /// <summary>
        /// Gets or Sets is_captured
        /// </summary>
        [DataMember(Name = "is_captured", EmitDefaultValue = true)]
        public bool is_captured { get; set; }

        /// <summary>
        /// Order amount can be different from payment amount if you collect service fee from the customer
        /// </summary>
        /// <value>Order amount can be different from payment amount if you collect service fee from the customer</value>
        [DataMember(Name = "order_amount", EmitDefaultValue = false)]
        public decimal order_amount { get; set; }

        /// <summary>
        /// Type of payment group. One of [&#39;upi&#39;, &#39;card&#39;, &#39;app&#39;, &#39;netbanking&#39;, &#39;paylater&#39;, &#39;cardless_emi&#39;]
        /// </summary>
        /// <value>Type of payment group. One of [&#39;upi&#39;, &#39;card&#39;, &#39;app&#39;, &#39;netbanking&#39;, &#39;paylater&#39;, &#39;cardless_emi&#39;]</value>
        [DataMember(Name = "payment_group", EmitDefaultValue = false)]
        public string payment_group { get; set; }

        /// <summary>
        /// Gets or Sets payment_currency
        /// </summary>
        [DataMember(Name = "payment_currency", EmitDefaultValue = false)]
        public string payment_currency { get; set; }

        /// <summary>
        /// Gets or Sets payment_amount
        /// </summary>
        [DataMember(Name = "payment_amount", EmitDefaultValue = false)]
        public decimal payment_amount { get; set; }

        /// <summary>
        /// This is the time when the payment was initiated
        /// </summary>
        /// <value>This is the time when the payment was initiated</value>
        [DataMember(Name = "payment_time", EmitDefaultValue = false)]
        public string payment_time { get; set; }

        /// <summary>
        /// This is the time when the payment reaches its terminal state
        /// </summary>
        /// <value>This is the time when the payment reaches its terminal state</value>
        [DataMember(Name = "payment_completion_time", EmitDefaultValue = false)]
        public string payment_completion_time { get; set; }

        /// <summary>
        /// Gets or Sets payment_message
        /// </summary>
        [DataMember(Name = "payment_message", EmitDefaultValue = false)]
        public string payment_message { get; set; }

        /// <summary>
        /// Gets or Sets bank_reference
        /// </summary>
        [DataMember(Name = "bank_reference", EmitDefaultValue = false)]
        public string bank_reference { get; set; }

        /// <summary>
        /// Gets or Sets auth_id
        /// </summary>
        [DataMember(Name = "auth_id", EmitDefaultValue = false)]
        public string auth_id { get; set; }

        /// <summary>
        /// Gets or Sets authorization
        /// </summary>
        [DataMember(Name = "authorization", EmitDefaultValue = true)]
        public AuthorizationInPaymentsEntity authorization { get; set; }

        /// <summary>
        /// Gets or Sets payment_method
        /// </summary>
        [DataMember(Name = "payment_method", EmitDefaultValue = false)]
        public PaymentMethodInPaymentsEntity payment_method { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentEntity {\n");
            sb.Append("  cf_payment_id: ").Append(cf_payment_id).Append("\n");
            sb.Append("  order_id: ").Append(order_id).Append("\n");
            sb.Append("  entity: ").Append(entity).Append("\n");
            sb.Append("  error_details: ").Append(error_details).Append("\n");
            sb.Append("  is_captured: ").Append(is_captured).Append("\n");
            sb.Append("  order_amount: ").Append(order_amount).Append("\n");
            sb.Append("  payment_group: ").Append(payment_group).Append("\n");
            sb.Append("  payment_currency: ").Append(payment_currency).Append("\n");
            sb.Append("  payment_amount: ").Append(payment_amount).Append("\n");
            sb.Append("  payment_time: ").Append(payment_time).Append("\n");
            sb.Append("  payment_completion_time: ").Append(payment_completion_time).Append("\n");
            sb.Append("  payment_status: ").Append(payment_status).Append("\n");
            sb.Append("  payment_message: ").Append(payment_message).Append("\n");
            sb.Append("  bank_reference: ").Append(bank_reference).Append("\n");
            sb.Append("  auth_id: ").Append(auth_id).Append("\n");
            sb.Append("  authorization: ").Append(authorization).Append("\n");
            sb.Append("  payment_method: ").Append(payment_method).Append("\n");
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
            return this.Equals(input as PaymentEntity);
        }

        /// <summary>
        /// Returns true if PaymentEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentEntity input)
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
                    this.order_id == input.order_id ||
                    (this.order_id != null &&
                    this.order_id.Equals(input.order_id))
                ) && 
                (
                    this.entity == input.entity ||
                    (this.entity != null &&
                    this.entity.Equals(input.entity))
                ) && 
                (
                    this.error_details == input.error_details ||
                    (this.error_details != null &&
                    this.error_details.Equals(input.error_details))
                ) && 
                (
                    this.is_captured == input.is_captured ||
                    this.is_captured.Equals(input.is_captured)
                ) && 
                (
                    this.order_amount == input.order_amount ||
                    this.order_amount.Equals(input.order_amount)
                ) && 
                (
                    this.payment_group == input.payment_group ||
                    (this.payment_group != null &&
                    this.payment_group.Equals(input.payment_group))
                ) && 
                (
                    this.payment_currency == input.payment_currency ||
                    (this.payment_currency != null &&
                    this.payment_currency.Equals(input.payment_currency))
                ) && 
                (
                    this.payment_amount == input.payment_amount ||
                    this.payment_amount.Equals(input.payment_amount)
                ) && 
                (
                    this.payment_time == input.payment_time ||
                    (this.payment_time != null &&
                    this.payment_time.Equals(input.payment_time))
                ) && 
                (
                    this.payment_completion_time == input.payment_completion_time ||
                    (this.payment_completion_time != null &&
                    this.payment_completion_time.Equals(input.payment_completion_time))
                ) && 
                (
                    this.payment_status == input.payment_status ||
                    this.payment_status.Equals(input.payment_status)
                ) && 
                (
                    this.payment_message == input.payment_message ||
                    (this.payment_message != null &&
                    this.payment_message.Equals(input.payment_message))
                ) && 
                (
                    this.bank_reference == input.bank_reference ||
                    (this.bank_reference != null &&
                    this.bank_reference.Equals(input.bank_reference))
                ) && 
                (
                    this.auth_id == input.auth_id ||
                    (this.auth_id != null &&
                    this.auth_id.Equals(input.auth_id))
                ) && 
                (
                    this.authorization == input.authorization ||
                    (this.authorization != null &&
                    this.authorization.Equals(input.authorization))
                ) && 
                (
                    this.payment_method == input.payment_method ||
                    (this.payment_method != null &&
                    this.payment_method.Equals(input.payment_method))
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
                if (this.order_id != null)
                {
                    hashCode = (hashCode * 59) + this.order_id.GetHashCode();
                }
                if (this.entity != null)
                {
                    hashCode = (hashCode * 59) + this.entity.GetHashCode();
                }
                if (this.error_details != null)
                {
                    hashCode = (hashCode * 59) + this.error_details.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.is_captured.GetHashCode();
                hashCode = (hashCode * 59) + this.order_amount.GetHashCode();
                if (this.payment_group != null)
                {
                    hashCode = (hashCode * 59) + this.payment_group.GetHashCode();
                }
                if (this.payment_currency != null)
                {
                    hashCode = (hashCode * 59) + this.payment_currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.payment_amount.GetHashCode();
                if (this.payment_time != null)
                {
                    hashCode = (hashCode * 59) + this.payment_time.GetHashCode();
                }
                if (this.payment_completion_time != null)
                {
                    hashCode = (hashCode * 59) + this.payment_completion_time.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.payment_status.GetHashCode();
                if (this.payment_message != null)
                {
                    hashCode = (hashCode * 59) + this.payment_message.GetHashCode();
                }
                if (this.bank_reference != null)
                {
                    hashCode = (hashCode * 59) + this.bank_reference.GetHashCode();
                }
                if (this.auth_id != null)
                {
                    hashCode = (hashCode * 59) + this.auth_id.GetHashCode();
                }
                if (this.authorization != null)
                {
                    hashCode = (hashCode * 59) + this.authorization.GetHashCode();
                }
                if (this.payment_method != null)
                {
                    hashCode = (hashCode * 59) + this.payment_method.GetHashCode();
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

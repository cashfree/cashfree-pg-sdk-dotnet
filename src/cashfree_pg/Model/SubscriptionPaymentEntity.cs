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
    /// The response returned in Get, Create or Manage Subscription Payment APIs.
    /// </summary>
    [DataContract(Name = "SubscriptionPaymentEntity")]
    public class SubscriptionPaymentEntity : IEquatable<SubscriptionPaymentEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPaymentEntity" /> class.
        /// </summary>
        /// <param name="authorizationDetails">authorizationDetails.</param>
        /// <param name="cfPaymentId">Cashfree subscription payment reference number.</param>
        /// <param name="cfSubscriptionId">Cashfree subscription reference number.</param>
        /// <param name="cfTxnId">Cashfree subscription payment transaction ID.</param>
        /// <param name="cfOrderId">Cashfree subscription payment order ID.</param>
        /// <param name="failureDetails">failureDetails.</param>
        /// <param name="paymentAmount">The charge amount of the payment..</param>
        /// <param name="paymentId">A unique ID passed by merchant for identifying the transaction..</param>
        /// <param name="paymentInitiatedDate">The date on which the payment was initiated..</param>
        /// <param name="paymentRemarks">Payment remarks..</param>
        /// <param name="paymentScheduleDate">The date on which the payment is scheduled to be processed..</param>
        /// <param name="paymentStatus">Status of the payment..</param>
        /// <param name="paymentType">Payment type. Can be AUTH or CHARGE..</param>
        /// <param name="retryAttempts">Retry attempts..</param>
        /// <param name="subscriptionId">A unique ID passed by merchant for identifying the subscription..</param>
        public SubscriptionPaymentEntity(AuthorizationDetails? authorizationDetails = default(AuthorizationDetails?), string? cfPaymentId = default(string?), string? cfSubscriptionId = default(string?), string? cfTxnId = default(string?), string? cfOrderId = default(string?), SubscriptionPaymentEntityFailureDetails? failureDetails = default(SubscriptionPaymentEntityFailureDetails?), decimal? paymentAmount = default(decimal?), string? paymentId = default(string?), string? paymentInitiatedDate = default(string?), string? paymentRemarks = default(string?), string? paymentScheduleDate = default(string?), string? paymentStatus = default(string?), string? paymentType = default(string?), int? retryAttempts = default(int?), string? subscriptionId = default(string?))
        {
            this.authorization_details = authorizationDetails;
            this.cf_payment_id = cfPaymentId;
            this.cf_subscription_id = cfSubscriptionId;
            this.cf_txn_id = cfTxnId;
            this.cf_order_id = cfOrderId;
            this.failure_details = failureDetails;
            this.payment_amount = paymentAmount;
            this.payment_id = paymentId;
            this.payment_initiated_date = paymentInitiatedDate;
            this.payment_remarks = paymentRemarks;
            this.payment_schedule_date = paymentScheduleDate;
            this.payment_status = paymentStatus;
            this.payment_type = paymentType;
            this.retry_attempts = retryAttempts;
            this.subscription_id = subscriptionId;
        }

        /// <summary>
        /// Gets or Sets authorization_details
        /// </summary>
        [DataMember(Name = "authorization_details", EmitDefaultValue = false)]
        public AuthorizationDetails? authorization_details { get; set; }

        /// <summary>
        /// Cashfree subscription payment reference number
        /// </summary>
        /// <value>Cashfree subscription payment reference number</value>
        [DataMember(Name = "cf_payment_id", EmitDefaultValue = false)]
        public string? cf_payment_id { get; set; }

        /// <summary>
        /// Cashfree subscription reference number
        /// </summary>
        /// <value>Cashfree subscription reference number</value>
        [DataMember(Name = "cf_subscription_id", EmitDefaultValue = false)]
        public string? cf_subscription_id { get; set; }

        /// <summary>
        /// Cashfree subscription payment transaction ID
        /// </summary>
        /// <value>Cashfree subscription payment transaction ID</value>
        [DataMember(Name = "cf_txn_id", EmitDefaultValue = false)]
        public string? cf_txn_id { get; set; }

        /// <summary>
        /// Cashfree subscription payment order ID
        /// </summary>
        /// <value>Cashfree subscription payment order ID</value>
        [DataMember(Name = "cf_order_id", EmitDefaultValue = false)]
        public string? cf_order_id { get; set; }

        /// <summary>
        /// Gets or Sets failure_details
        /// </summary>
        [DataMember(Name = "failure_details", EmitDefaultValue = false)]
        public SubscriptionPaymentEntityFailureDetails? failure_details { get; set; }

        /// <summary>
        /// The charge amount of the payment.
        /// </summary>
        /// <value>The charge amount of the payment.</value>
        [DataMember(Name = "payment_amount", EmitDefaultValue = false)]
        public decimal? payment_amount { get; set; }

        /// <summary>
        /// A unique ID passed by merchant for identifying the transaction.
        /// </summary>
        /// <value>A unique ID passed by merchant for identifying the transaction.</value>
        [DataMember(Name = "payment_id", EmitDefaultValue = false)]
        public string? payment_id { get; set; }

        /// <summary>
        /// The date on which the payment was initiated.
        /// </summary>
        /// <value>The date on which the payment was initiated.</value>
        [DataMember(Name = "payment_initiated_date", EmitDefaultValue = false)]
        public string? payment_initiated_date { get; set; }

        /// <summary>
        /// Payment remarks.
        /// </summary>
        /// <value>Payment remarks.</value>
        [DataMember(Name = "payment_remarks", EmitDefaultValue = false)]
        public string? payment_remarks { get; set; }

        /// <summary>
        /// The date on which the payment is scheduled to be processed.
        /// </summary>
        /// <value>The date on which the payment is scheduled to be processed.</value>
        [DataMember(Name = "payment_schedule_date", EmitDefaultValue = false)]
        public string? payment_schedule_date { get; set; }

        /// <summary>
        /// Status of the payment.
        /// </summary>
        /// <value>Status of the payment.</value>
        [DataMember(Name = "payment_status", EmitDefaultValue = false)]
        public string? payment_status { get; set; }

        /// <summary>
        /// Payment type. Can be AUTH or CHARGE.
        /// </summary>
        /// <value>Payment type. Can be AUTH or CHARGE.</value>
        [DataMember(Name = "payment_type", EmitDefaultValue = false)]
        public string? payment_type { get; set; }

        /// <summary>
        /// Retry attempts.
        /// </summary>
        /// <value>Retry attempts.</value>
        [DataMember(Name = "retry_attempts", EmitDefaultValue = false)]
        public int? retry_attempts { get; set; }

        /// <summary>
        /// A unique ID passed by merchant for identifying the subscription.
        /// </summary>
        /// <value>A unique ID passed by merchant for identifying the subscription.</value>
        [DataMember(Name = "subscription_id", EmitDefaultValue = false)]
        public string? subscription_id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionPaymentEntity {\n");
            sb.Append("  authorization_details: ").Append(authorization_details).Append("\n");
            sb.Append("  cf_payment_id: ").Append(cf_payment_id).Append("\n");
            sb.Append("  cf_subscription_id: ").Append(cf_subscription_id).Append("\n");
            sb.Append("  cf_txn_id: ").Append(cf_txn_id).Append("\n");
            sb.Append("  cf_order_id: ").Append(cf_order_id).Append("\n");
            sb.Append("  failure_details: ").Append(failure_details).Append("\n");
            sb.Append("  payment_amount: ").Append(payment_amount).Append("\n");
            sb.Append("  payment_id: ").Append(payment_id).Append("\n");
            sb.Append("  payment_initiated_date: ").Append(payment_initiated_date).Append("\n");
            sb.Append("  payment_remarks: ").Append(payment_remarks).Append("\n");
            sb.Append("  payment_schedule_date: ").Append(payment_schedule_date).Append("\n");
            sb.Append("  payment_status: ").Append(payment_status).Append("\n");
            sb.Append("  payment_type: ").Append(payment_type).Append("\n");
            sb.Append("  retry_attempts: ").Append(retry_attempts).Append("\n");
            sb.Append("  subscription_id: ").Append(subscription_id).Append("\n");
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
            return this.Equals(input as SubscriptionPaymentEntity);
        }

        /// <summary>
        /// Returns true if SubscriptionPaymentEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionPaymentEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPaymentEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.authorization_details == input.authorization_details ||
                    (this.authorization_details != null &&
                    this.authorization_details.Equals(input.authorization_details))
                ) && 
                (
                    this.cf_payment_id == input.cf_payment_id ||
                    (this.cf_payment_id != null &&
                    this.cf_payment_id.Equals(input.cf_payment_id))
                ) && 
                (
                    this.cf_subscription_id == input.cf_subscription_id ||
                    (this.cf_subscription_id != null &&
                    this.cf_subscription_id.Equals(input.cf_subscription_id))
                ) && 
                (
                    this.cf_txn_id == input.cf_txn_id ||
                    (this.cf_txn_id != null &&
                    this.cf_txn_id.Equals(input.cf_txn_id))
                ) && 
                (
                    this.cf_order_id == input.cf_order_id ||
                    (this.cf_order_id != null &&
                    this.cf_order_id.Equals(input.cf_order_id))
                ) && 
                (
                    this.failure_details == input.failure_details ||
                    (this.failure_details != null &&
                    this.failure_details.Equals(input.failure_details))
                ) && 
                (
                    this.payment_amount == input.payment_amount ||
                    this.payment_amount.Equals(input.payment_amount)
                ) && 
                (
                    this.payment_id == input.payment_id ||
                    (this.payment_id != null &&
                    this.payment_id.Equals(input.payment_id))
                ) && 
                (
                    this.payment_initiated_date == input.payment_initiated_date ||
                    (this.payment_initiated_date != null &&
                    this.payment_initiated_date.Equals(input.payment_initiated_date))
                ) && 
                (
                    this.payment_remarks == input.payment_remarks ||
                    (this.payment_remarks != null &&
                    this.payment_remarks.Equals(input.payment_remarks))
                ) && 
                (
                    this.payment_schedule_date == input.payment_schedule_date ||
                    (this.payment_schedule_date != null &&
                    this.payment_schedule_date.Equals(input.payment_schedule_date))
                ) && 
                (
                    this.payment_status == input.payment_status ||
                    (this.payment_status != null &&
                    this.payment_status.Equals(input.payment_status))
                ) && 
                (
                    this.payment_type == input.payment_type ||
                    (this.payment_type != null &&
                    this.payment_type.Equals(input.payment_type))
                ) && 
                (
                    this.retry_attempts == input.retry_attempts ||
                    this.retry_attempts.Equals(input.retry_attempts)
                ) && 
                (
                    this.subscription_id == input.subscription_id ||
                    (this.subscription_id != null &&
                    this.subscription_id.Equals(input.subscription_id))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringauthorization_details) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringauthorization_details);
            if (deserializedJsonString.ContainsKey("authorization_details")) {
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
                if (this.authorization_details != null)
                {
                    hashCode = (hashCode * 59) + this.authorization_details.GetHashCode();
                }
                if (this.cf_payment_id != null)
                {
                    hashCode = (hashCode * 59) + this.cf_payment_id.GetHashCode();
                }
                if (this.cf_subscription_id != null)
                {
                    hashCode = (hashCode * 59) + this.cf_subscription_id.GetHashCode();
                }
                if (this.cf_txn_id != null)
                {
                    hashCode = (hashCode * 59) + this.cf_txn_id.GetHashCode();
                }
                if (this.cf_order_id != null)
                {
                    hashCode = (hashCode * 59) + this.cf_order_id.GetHashCode();
                }
                if (this.failure_details != null)
                {
                    hashCode = (hashCode * 59) + this.failure_details.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.payment_amount.GetHashCode();
                if (this.payment_id != null)
                {
                    hashCode = (hashCode * 59) + this.payment_id.GetHashCode();
                }
                if (this.payment_initiated_date != null)
                {
                    hashCode = (hashCode * 59) + this.payment_initiated_date.GetHashCode();
                }
                if (this.payment_remarks != null)
                {
                    hashCode = (hashCode * 59) + this.payment_remarks.GetHashCode();
                }
                if (this.payment_schedule_date != null)
                {
                    hashCode = (hashCode * 59) + this.payment_schedule_date.GetHashCode();
                }
                if (this.payment_status != null)
                {
                    hashCode = (hashCode * 59) + this.payment_status.GetHashCode();
                }
                if (this.payment_type != null)
                {
                    hashCode = (hashCode * 59) + this.payment_type.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.retry_attempts.GetHashCode();
                if (this.subscription_id != null)
                {
                    hashCode = (hashCode * 59) + this.subscription_id.GetHashCode();
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

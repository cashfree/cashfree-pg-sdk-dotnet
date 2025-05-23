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
    /// The refund entity
    /// </summary>
    [DataContract(Name = "RefundEntity")]
    public class RefundEntity : IEquatable<RefundEntity>, IValidatableObject
    {
        /// <summary>
        /// Type of object
        /// </summary>
        /// <value>Type of object</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EntityEnum
        {
            /// <summary>
            /// Enum Refund for value: refund
            /// </summary>
            [EnumMember(Value = "refund")]
            Refund = 1
        }


        /// <summary>
        /// Type of object
        /// </summary>
        /// <value>Type of object</value>
        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public EntityEnum? entity { get; set; }
        /// <summary>
        /// This can be one of [\&quot;SUCCESS\&quot;, \&quot;PENDING\&quot;, \&quot;CANCELLED\&quot;, \&quot;ONHOLD\&quot;, \&quot;FAILED\&quot;]
        /// </summary>
        /// <value>This can be one of [\&quot;SUCCESS\&quot;, \&quot;PENDING\&quot;, \&quot;CANCELLED\&quot;, \&quot;ONHOLD\&quot;, \&quot;FAILED\&quot;]</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RefundStatusEnum
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
            PENDING = 2,

            /// <summary>
            /// Enum CANCELLED for value: CANCELLED
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            CANCELLED = 3,

            /// <summary>
            /// Enum ONHOLD for value: ONHOLD
            /// </summary>
            [EnumMember(Value = "ONHOLD")]
            ONHOLD = 4
        }


        /// <summary>
        /// This can be one of [\&quot;SUCCESS\&quot;, \&quot;PENDING\&quot;, \&quot;CANCELLED\&quot;, \&quot;ONHOLD\&quot;, \&quot;FAILED\&quot;]
        /// </summary>
        /// <value>This can be one of [\&quot;SUCCESS\&quot;, \&quot;PENDING\&quot;, \&quot;CANCELLED\&quot;, \&quot;ONHOLD\&quot;, \&quot;FAILED\&quot;]</value>
        [DataMember(Name = "refund_status", EmitDefaultValue = false)]
        public RefundStatusEnum? refund_status { get; set; }
        /// <summary>
        /// This can be one of [\&quot;PAYMENT_AUTO_REFUND\&quot;, \&quot;MERCHANT_INITIATED\&quot;, \&quot;UNRECONCILED_AUTO_REFUND\&quot;]
        /// </summary>
        /// <value>This can be one of [\&quot;PAYMENT_AUTO_REFUND\&quot;, \&quot;MERCHANT_INITIATED\&quot;, \&quot;UNRECONCILED_AUTO_REFUND\&quot;]</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RefundTypeEnum
        {
            /// <summary>
            /// Enum PAYMENTAUTOREFUND for value: PAYMENT_AUTO_REFUND
            /// </summary>
            [EnumMember(Value = "PAYMENT_AUTO_REFUND")]
            PAYMENTAUTOREFUND = 1,

            /// <summary>
            /// Enum MERCHANTINITIATED for value: MERCHANT_INITIATED
            /// </summary>
            [EnumMember(Value = "MERCHANT_INITIATED")]
            MERCHANTINITIATED = 2,

            /// <summary>
            /// Enum UNRECONCILEDAUTOREFUND for value: UNRECONCILED_AUTO_REFUND
            /// </summary>
            [EnumMember(Value = "UNRECONCILED_AUTO_REFUND")]
            UNRECONCILEDAUTOREFUND = 3
        }


        /// <summary>
        /// This can be one of [\&quot;PAYMENT_AUTO_REFUND\&quot;, \&quot;MERCHANT_INITIATED\&quot;, \&quot;UNRECONCILED_AUTO_REFUND\&quot;]
        /// </summary>
        /// <value>This can be one of [\&quot;PAYMENT_AUTO_REFUND\&quot;, \&quot;MERCHANT_INITIATED\&quot;, \&quot;UNRECONCILED_AUTO_REFUND\&quot;]</value>
        [DataMember(Name = "refund_type", EmitDefaultValue = false)]
        public RefundTypeEnum? refund_type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundEntity" /> class.
        /// </summary>
        /// <param name="cfPaymentId">Cashfree Payments ID of the payment for which refund is initiated.</param>
        /// <param name="cfRefundId">Cashfree Payments ID for a refund.</param>
        /// <param name="orderId">Merchant’s order Id of the order for which refund is initiated.</param>
        /// <param name="refundId">Merchant’s refund ID of the refund.</param>
        /// <param name="entity">Type of object.</param>
        /// <param name="refundAmount">Amount that is refunded.</param>
        /// <param name="refundCurrency">Currency of the refund amount.</param>
        /// <param name="refundNote">Note added by merchant for the refund.</param>
        /// <param name="refundStatus">This can be one of [\&quot;SUCCESS\&quot;, \&quot;PENDING\&quot;, \&quot;CANCELLED\&quot;, \&quot;ONHOLD\&quot;, \&quot;FAILED\&quot;].</param>
        /// <param name="refundArn">The bank reference number for refund.</param>
        /// <param name="refundCharge">Charges in INR for processing refund.</param>
        /// <param name="statusDescription">Description of refund status.</param>
        /// <param name="metadata">Key-value pair that can be used to store additional information about the entity. Maximum 5 key-value pairs.</param>
        /// <param name="refundSplits">refundSplits.</param>
        /// <param name="refundType">This can be one of [\&quot;PAYMENT_AUTO_REFUND\&quot;, \&quot;MERCHANT_INITIATED\&quot;, \&quot;UNRECONCILED_AUTO_REFUND\&quot;].</param>
        /// <param name="refundMode">Method or speed of processing refund.</param>
        /// <param name="createdAt">Time of refund creation.</param>
        /// <param name="processedAt">Time when refund was processed successfully.</param>
        /// <param name="refundSpeed">refundSpeed.</param>
        /// <param name="forexConversionHandlingCharge">Cashfree forex conversion charges for refund processing.</param>
        /// <param name="forexConversionHandlingTax">Cashfree forex conversion tax for refund processing.</param>
        /// <param name="forexConversionRate">Cashfree forex conversion rate for refund processing.</param>
        /// <param name="chargesCurrency">Cashfree refund charges currency for a refund.</param>
        public RefundEntity(string? cfPaymentId = default(string?), string? cfRefundId = default(string?), string? orderId = default(string?), string? refundId = default(string?), EntityEnum? entity = default(EntityEnum?), decimal? refundAmount = default(decimal?), string? refundCurrency = default(string?), string? refundNote = default(string?), RefundStatusEnum? refundStatus = default(RefundStatusEnum?), string? refundArn = default(string?), decimal? refundCharge = default(decimal?), string? statusDescription = default(string?), Object? metadata = default(Object?), List<VendorSplit>? refundSplits = default(List<VendorSplit>?), RefundTypeEnum? refundType = default(RefundTypeEnum?), string? refundMode = default(string?), string? createdAt = default(string?), string? processedAt = default(string?), RefundSpeed? refundSpeed = default(RefundSpeed?), decimal? forexConversionHandlingCharge = default(decimal?), decimal? forexConversionHandlingTax = default(decimal?), decimal? forexConversionRate = default(decimal?), string? chargesCurrency = default(string?))
        {
            this.cf_payment_id = cfPaymentId;
            this.cf_refund_id = cfRefundId;
            this.order_id = orderId;
            this.refund_id = refundId;
            this.entity = entity;
            this.refund_amount = refundAmount;
            this.refund_currency = refundCurrency;
            this.refund_note = refundNote;
            this.refund_status = refundStatus;
            this.refund_arn = refundArn;
            this.refund_charge = refundCharge;
            this.status_description = statusDescription;
            this.metadata = metadata;
            this.refund_splits = refundSplits;
            this.refund_type = refundType;
            this.refund_mode = refundMode;
            this.created_at = createdAt;
            this.processed_at = processedAt;
            this.refund_speed = refundSpeed;
            this.forex_conversion_handling_charge = forexConversionHandlingCharge;
            this.forex_conversion_handling_tax = forexConversionHandlingTax;
            this.forex_conversion_rate = forexConversionRate;
            this.charges_currency = chargesCurrency;
        }

        /// <summary>
        /// Cashfree Payments ID of the payment for which refund is initiated
        /// </summary>
        /// <value>Cashfree Payments ID of the payment for which refund is initiated</value>
        [DataMember(Name = "cf_payment_id", EmitDefaultValue = false)]
        public string? cf_payment_id { get; set; }

        /// <summary>
        /// Cashfree Payments ID for a refund
        /// </summary>
        /// <value>Cashfree Payments ID for a refund</value>
        [DataMember(Name = "cf_refund_id", EmitDefaultValue = false)]
        public string? cf_refund_id { get; set; }

        /// <summary>
        /// Merchant’s order Id of the order for which refund is initiated
        /// </summary>
        /// <value>Merchant’s order Id of the order for which refund is initiated</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string? order_id { get; set; }

        /// <summary>
        /// Merchant’s refund ID of the refund
        /// </summary>
        /// <value>Merchant’s refund ID of the refund</value>
        [DataMember(Name = "refund_id", EmitDefaultValue = false)]
        public string? refund_id { get; set; }

        /// <summary>
        /// Amount that is refunded
        /// </summary>
        /// <value>Amount that is refunded</value>
        [DataMember(Name = "refund_amount", EmitDefaultValue = false)]
        public decimal? refund_amount { get; set; }

        /// <summary>
        /// Currency of the refund amount
        /// </summary>
        /// <value>Currency of the refund amount</value>
        [DataMember(Name = "refund_currency", EmitDefaultValue = false)]
        public string? refund_currency { get; set; }

        /// <summary>
        /// Note added by merchant for the refund
        /// </summary>
        /// <value>Note added by merchant for the refund</value>
        [DataMember(Name = "refund_note", EmitDefaultValue = false)]
        public string? refund_note { get; set; }

        /// <summary>
        /// The bank reference number for refund
        /// </summary>
        /// <value>The bank reference number for refund</value>
        [DataMember(Name = "refund_arn", EmitDefaultValue = false)]
        public string? refund_arn { get; set; }

        /// <summary>
        /// Charges in INR for processing refund
        /// </summary>
        /// <value>Charges in INR for processing refund</value>
        [DataMember(Name = "refund_charge", EmitDefaultValue = false)]
        public decimal? refund_charge { get; set; }

        /// <summary>
        /// Description of refund status
        /// </summary>
        /// <value>Description of refund status</value>
        [DataMember(Name = "status_description", EmitDefaultValue = false)]
        public string? status_description { get; set; }

        /// <summary>
        /// Key-value pair that can be used to store additional information about the entity. Maximum 5 key-value pairs
        /// </summary>
        /// <value>Key-value pair that can be used to store additional information about the entity. Maximum 5 key-value pairs</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public Object? metadata { get; set; }

        /// <summary>
        /// Gets or Sets refund_splits
        /// </summary>
        [DataMember(Name = "refund_splits", EmitDefaultValue = false)]
        public List<VendorSplit>? refund_splits { get; set; }

        /// <summary>
        /// Method or speed of processing refund
        /// </summary>
        /// <value>Method or speed of processing refund</value>
        [DataMember(Name = "refund_mode", EmitDefaultValue = false)]
        public string? refund_mode { get; set; }

        /// <summary>
        /// Time of refund creation
        /// </summary>
        /// <value>Time of refund creation</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string? created_at { get; set; }

        /// <summary>
        /// Time when refund was processed successfully
        /// </summary>
        /// <value>Time when refund was processed successfully</value>
        [DataMember(Name = "processed_at", EmitDefaultValue = false)]
        public string? processed_at { get; set; }

        /// <summary>
        /// Gets or Sets refund_speed
        /// </summary>
        [DataMember(Name = "refund_speed", EmitDefaultValue = false)]
        public RefundSpeed? refund_speed { get; set; }

        /// <summary>
        /// Cashfree forex conversion charges for refund processing
        /// </summary>
        /// <value>Cashfree forex conversion charges for refund processing</value>
        [DataMember(Name = "forex_conversion_handling_charge", EmitDefaultValue = false)]
        public decimal? forex_conversion_handling_charge { get; set; }

        /// <summary>
        /// Cashfree forex conversion tax for refund processing
        /// </summary>
        /// <value>Cashfree forex conversion tax for refund processing</value>
        [DataMember(Name = "forex_conversion_handling_tax", EmitDefaultValue = false)]
        public decimal? forex_conversion_handling_tax { get; set; }

        /// <summary>
        /// Cashfree forex conversion rate for refund processing
        /// </summary>
        /// <value>Cashfree forex conversion rate for refund processing</value>
        [DataMember(Name = "forex_conversion_rate", EmitDefaultValue = false)]
        public decimal? forex_conversion_rate { get; set; }

        /// <summary>
        /// Cashfree refund charges currency for a refund
        /// </summary>
        /// <value>Cashfree refund charges currency for a refund</value>
        [DataMember(Name = "charges_currency", EmitDefaultValue = false)]
        public string? charges_currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RefundEntity {\n");
            sb.Append("  cf_payment_id: ").Append(cf_payment_id).Append("\n");
            sb.Append("  cf_refund_id: ").Append(cf_refund_id).Append("\n");
            sb.Append("  order_id: ").Append(order_id).Append("\n");
            sb.Append("  refund_id: ").Append(refund_id).Append("\n");
            sb.Append("  entity: ").Append(entity).Append("\n");
            sb.Append("  refund_amount: ").Append(refund_amount).Append("\n");
            sb.Append("  refund_currency: ").Append(refund_currency).Append("\n");
            sb.Append("  refund_note: ").Append(refund_note).Append("\n");
            sb.Append("  refund_status: ").Append(refund_status).Append("\n");
            sb.Append("  refund_arn: ").Append(refund_arn).Append("\n");
            sb.Append("  refund_charge: ").Append(refund_charge).Append("\n");
            sb.Append("  status_description: ").Append(status_description).Append("\n");
            sb.Append("  metadata: ").Append(metadata).Append("\n");
            sb.Append("  refund_splits: ").Append(refund_splits).Append("\n");
            sb.Append("  refund_type: ").Append(refund_type).Append("\n");
            sb.Append("  refund_mode: ").Append(refund_mode).Append("\n");
            sb.Append("  created_at: ").Append(created_at).Append("\n");
            sb.Append("  processed_at: ").Append(processed_at).Append("\n");
            sb.Append("  refund_speed: ").Append(refund_speed).Append("\n");
            sb.Append("  forex_conversion_handling_charge: ").Append(forex_conversion_handling_charge).Append("\n");
            sb.Append("  forex_conversion_handling_tax: ").Append(forex_conversion_handling_tax).Append("\n");
            sb.Append("  forex_conversion_rate: ").Append(forex_conversion_rate).Append("\n");
            sb.Append("  charges_currency: ").Append(charges_currency).Append("\n");
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
            return this.Equals(input as RefundEntity);
        }

        /// <summary>
        /// Returns true if RefundEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of RefundEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cf_payment_id == input.cf_payment_id ||
                    (this.cf_payment_id != null &&
                    this.cf_payment_id.Equals(input.cf_payment_id))
                ) && 
                (
                    this.cf_refund_id == input.cf_refund_id ||
                    (this.cf_refund_id != null &&
                    this.cf_refund_id.Equals(input.cf_refund_id))
                ) && 
                (
                    this.order_id == input.order_id ||
                    (this.order_id != null &&
                    this.order_id.Equals(input.order_id))
                ) && 
                (
                    this.refund_id == input.refund_id ||
                    (this.refund_id != null &&
                    this.refund_id.Equals(input.refund_id))
                ) && 
                (
                    this.entity == input.entity ||
                    this.entity.Equals(input.entity)
                ) && 
                (
                    this.refund_amount == input.refund_amount ||
                    this.refund_amount.Equals(input.refund_amount)
                ) && 
                (
                    this.refund_currency == input.refund_currency ||
                    (this.refund_currency != null &&
                    this.refund_currency.Equals(input.refund_currency))
                ) && 
                (
                    this.refund_note == input.refund_note ||
                    (this.refund_note != null &&
                    this.refund_note.Equals(input.refund_note))
                ) && 
                (
                    this.refund_status == input.refund_status ||
                    this.refund_status.Equals(input.refund_status)
                ) && 
                (
                    this.refund_arn == input.refund_arn ||
                    (this.refund_arn != null &&
                    this.refund_arn.Equals(input.refund_arn))
                ) && 
                (
                    this.refund_charge == input.refund_charge ||
                    this.refund_charge.Equals(input.refund_charge)
                ) && 
                (
                    this.status_description == input.status_description ||
                    (this.status_description != null &&
                    this.status_description.Equals(input.status_description))
                ) && 
                (
                    this.metadata == input.metadata ||
                    (this.metadata != null &&
                    this.metadata.Equals(input.metadata))
                ) && 
                (
                    this.refund_splits == input.refund_splits ||
                    this.refund_splits != null &&
                    input.refund_splits != null &&
                    this.refund_splits.SequenceEqual(input.refund_splits)
                ) && 
                (
                    this.refund_type == input.refund_type ||
                    this.refund_type.Equals(input.refund_type)
                ) && 
                (
                    this.refund_mode == input.refund_mode ||
                    (this.refund_mode != null &&
                    this.refund_mode.Equals(input.refund_mode))
                ) && 
                (
                    this.created_at == input.created_at ||
                    (this.created_at != null &&
                    this.created_at.Equals(input.created_at))
                ) && 
                (
                    this.processed_at == input.processed_at ||
                    (this.processed_at != null &&
                    this.processed_at.Equals(input.processed_at))
                ) && 
                (
                    this.refund_speed == input.refund_speed ||
                    (this.refund_speed != null &&
                    this.refund_speed.Equals(input.refund_speed))
                ) && 
                (
                    this.forex_conversion_handling_charge == input.forex_conversion_handling_charge ||
                    this.forex_conversion_handling_charge.Equals(input.forex_conversion_handling_charge)
                ) && 
                (
                    this.forex_conversion_handling_tax == input.forex_conversion_handling_tax ||
                    this.forex_conversion_handling_tax.Equals(input.forex_conversion_handling_tax)
                ) && 
                (
                    this.forex_conversion_rate == input.forex_conversion_rate ||
                    this.forex_conversion_rate.Equals(input.forex_conversion_rate)
                ) && 
                (
                    this.charges_currency == input.charges_currency ||
                    (this.charges_currency != null &&
                    this.charges_currency.Equals(input.charges_currency))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringcf_payment_id) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringcf_payment_id);
            if (deserializedJsonString.ContainsKey("cf_payment_id")) {
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
                if (this.cf_payment_id != null)
                {
                    hashCode = (hashCode * 59) + this.cf_payment_id.GetHashCode();
                }
                if (this.cf_refund_id != null)
                {
                    hashCode = (hashCode * 59) + this.cf_refund_id.GetHashCode();
                }
                if (this.order_id != null)
                {
                    hashCode = (hashCode * 59) + this.order_id.GetHashCode();
                }
                if (this.refund_id != null)
                {
                    hashCode = (hashCode * 59) + this.refund_id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.entity.GetHashCode();
                hashCode = (hashCode * 59) + this.refund_amount.GetHashCode();
                if (this.refund_currency != null)
                {
                    hashCode = (hashCode * 59) + this.refund_currency.GetHashCode();
                }
                if (this.refund_note != null)
                {
                    hashCode = (hashCode * 59) + this.refund_note.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.refund_status.GetHashCode();
                if (this.refund_arn != null)
                {
                    hashCode = (hashCode * 59) + this.refund_arn.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.refund_charge.GetHashCode();
                if (this.status_description != null)
                {
                    hashCode = (hashCode * 59) + this.status_description.GetHashCode();
                }
                if (this.metadata != null)
                {
                    hashCode = (hashCode * 59) + this.metadata.GetHashCode();
                }
                if (this.refund_splits != null)
                {
                    hashCode = (hashCode * 59) + this.refund_splits.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.refund_type.GetHashCode();
                if (this.refund_mode != null)
                {
                    hashCode = (hashCode * 59) + this.refund_mode.GetHashCode();
                }
                if (this.created_at != null)
                {
                    hashCode = (hashCode * 59) + this.created_at.GetHashCode();
                }
                if (this.processed_at != null)
                {
                    hashCode = (hashCode * 59) + this.processed_at.GetHashCode();
                }
                if (this.refund_speed != null)
                {
                    hashCode = (hashCode * 59) + this.refund_speed.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.forex_conversion_handling_charge.GetHashCode();
                hashCode = (hashCode * 59) + this.forex_conversion_handling_tax.GetHashCode();
                hashCode = (hashCode * 59) + this.forex_conversion_rate.GetHashCode();
                if (this.charges_currency != null)
                {
                    hashCode = (hashCode * 59) + this.charges_currency.GetHashCode();
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

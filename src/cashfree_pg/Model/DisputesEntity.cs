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
    /// DisputesEntity
    /// </summary>
    [DataContract(Name = "DisputesEntity")]
    public class DisputesEntity : IEquatable<DisputesEntity>, IValidatableObject
    {
        /// <summary>
        /// Defines dispute_type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisputeTypeEnum
        {
            /// <summary>
            /// Enum DISPUTE for value: DISPUTE
            /// </summary>
            [EnumMember(Value = "DISPUTE")]
            DISPUTE = 1,

            /// <summary>
            /// Enum CHARGEBACK for value: CHARGEBACK
            /// </summary>
            [EnumMember(Value = "CHARGEBACK")]
            CHARGEBACK = 2,

            /// <summary>
            /// Enum RETRIEVAL for value: RETRIEVAL
            /// </summary>
            [EnumMember(Value = "RETRIEVAL")]
            RETRIEVAL = 3,

            /// <summary>
            /// Enum PREARBITRATION for value: PRE_ARBITRATION
            /// </summary>
            [EnumMember(Value = "PRE_ARBITRATION")]
            PREARBITRATION = 4,

            /// <summary>
            /// Enum ARBITRATION for value: ARBITRATION
            /// </summary>
            [EnumMember(Value = "ARBITRATION")]
            ARBITRATION = 5
        }


        /// <summary>
        /// Gets or Sets dispute_type
        /// </summary>
        [DataMember(Name = "dispute_type", EmitDefaultValue = false)]
        public DisputeTypeEnum? dispute_type { get; set; }
        /// <summary>
        /// Defines dispute_status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DisputeStatusEnum
        {
            /// <summary>
            /// Enum DISPUTECREATED for value: DISPUTE_CREATED
            /// </summary>
            [EnumMember(Value = "DISPUTE_CREATED")]
            DISPUTECREATED = 1,

            /// <summary>
            /// Enum DISPUTEDOCSRECEIVED for value: DISPUTE_DOCS_RECEIVED
            /// </summary>
            [EnumMember(Value = "DISPUTE_DOCS_RECEIVED")]
            DISPUTEDOCSRECEIVED = 2,

            /// <summary>
            /// Enum DISPUTEUNDERREVIEW for value: DISPUTE_UNDER_REVIEW
            /// </summary>
            [EnumMember(Value = "DISPUTE_UNDER_REVIEW")]
            DISPUTEUNDERREVIEW = 3,

            /// <summary>
            /// Enum DISPUTEMERCHANTWON for value: DISPUTE_MERCHANT_WON
            /// </summary>
            [EnumMember(Value = "DISPUTE_MERCHANT_WON")]
            DISPUTEMERCHANTWON = 4,

            /// <summary>
            /// Enum DISPUTEMERCHANTLOST for value: DISPUTE_MERCHANT_LOST
            /// </summary>
            [EnumMember(Value = "DISPUTE_MERCHANT_LOST")]
            DISPUTEMERCHANTLOST = 5,

            /// <summary>
            /// Enum DISPUTEMERCHANTACCEPTED for value: DISPUTE_MERCHANT_ACCEPTED
            /// </summary>
            [EnumMember(Value = "DISPUTE_MERCHANT_ACCEPTED")]
            DISPUTEMERCHANTACCEPTED = 6,

            /// <summary>
            /// Enum DISPUTEINSUFFICIENTEVIDENCE for value: DISPUTE_INSUFFICIENT_EVIDENCE
            /// </summary>
            [EnumMember(Value = "DISPUTE_INSUFFICIENT_EVIDENCE")]
            DISPUTEINSUFFICIENTEVIDENCE = 7,

            /// <summary>
            /// Enum CHARGEBACKCREATED for value: CHARGEBACK_CREATED
            /// </summary>
            [EnumMember(Value = "CHARGEBACK_CREATED")]
            CHARGEBACKCREATED = 8,

            /// <summary>
            /// Enum CHARGEBACKDOCSRECEIVED for value: CHARGEBACK_DOCS_RECEIVED
            /// </summary>
            [EnumMember(Value = "CHARGEBACK_DOCS_RECEIVED")]
            CHARGEBACKDOCSRECEIVED = 9,

            /// <summary>
            /// Enum CHARGEBACKUNDERREVIEW for value: CHARGEBACK_UNDER_REVIEW
            /// </summary>
            [EnumMember(Value = "CHARGEBACK_UNDER_REVIEW")]
            CHARGEBACKUNDERREVIEW = 10,

            /// <summary>
            /// Enum CHARGEBACKMERCHANTWON for value: CHARGEBACK_MERCHANT_WON
            /// </summary>
            [EnumMember(Value = "CHARGEBACK_MERCHANT_WON")]
            CHARGEBACKMERCHANTWON = 11,

            /// <summary>
            /// Enum CHARGEBACKMERCHANTLOST for value: CHARGEBACK_MERCHANT_LOST
            /// </summary>
            [EnumMember(Value = "CHARGEBACK_MERCHANT_LOST")]
            CHARGEBACKMERCHANTLOST = 12,

            /// <summary>
            /// Enum CHARGEBACKMERCHANTACCEPTED for value: CHARGEBACK_MERCHANT_ACCEPTED
            /// </summary>
            [EnumMember(Value = "CHARGEBACK_MERCHANT_ACCEPTED")]
            CHARGEBACKMERCHANTACCEPTED = 13,

            /// <summary>
            /// Enum CHARGEBACKINSUFFICIENTEVIDENCE for value: CHARGEBACK_INSUFFICIENT_EVIDENCE
            /// </summary>
            [EnumMember(Value = "CHARGEBACK_INSUFFICIENT_EVIDENCE")]
            CHARGEBACKINSUFFICIENTEVIDENCE = 14,

            /// <summary>
            /// Enum RETRIEVALCREATED for value: RETRIEVAL_CREATED
            /// </summary>
            [EnumMember(Value = "RETRIEVAL_CREATED")]
            RETRIEVALCREATED = 15,

            /// <summary>
            /// Enum RETRIEVALDOCSRECEIVED for value: RETRIEVAL_DOCS_RECEIVED
            /// </summary>
            [EnumMember(Value = "RETRIEVAL_DOCS_RECEIVED")]
            RETRIEVALDOCSRECEIVED = 16,

            /// <summary>
            /// Enum RETRIEVALUNDERREVIEW for value: RETRIEVAL_UNDER_REVIEW
            /// </summary>
            [EnumMember(Value = "RETRIEVAL_UNDER_REVIEW")]
            RETRIEVALUNDERREVIEW = 17,

            /// <summary>
            /// Enum RETRIEVALMERCHANTWON for value: RETRIEVAL_MERCHANT_WON
            /// </summary>
            [EnumMember(Value = "RETRIEVAL_MERCHANT_WON")]
            RETRIEVALMERCHANTWON = 18,

            /// <summary>
            /// Enum RETRIEVALMERCHANTLOST for value: RETRIEVAL_MERCHANT_LOST
            /// </summary>
            [EnumMember(Value = "RETRIEVAL_MERCHANT_LOST")]
            RETRIEVALMERCHANTLOST = 19,

            /// <summary>
            /// Enum RETRIEVALMERCHANTACCEPTED for value: RETRIEVAL_MERCHANT_ACCEPTED
            /// </summary>
            [EnumMember(Value = "RETRIEVAL_MERCHANT_ACCEPTED")]
            RETRIEVALMERCHANTACCEPTED = 20,

            /// <summary>
            /// Enum RETRIEVALINSUFFICIENTEVIDENCE for value: RETRIEVAL_INSUFFICIENT_EVIDENCE
            /// </summary>
            [EnumMember(Value = "RETRIEVAL_INSUFFICIENT_EVIDENCE")]
            RETRIEVALINSUFFICIENTEVIDENCE = 21,

            /// <summary>
            /// Enum PREARBITRATIONCREATED for value: PRE_ARBITRATION_CREATED
            /// </summary>
            [EnumMember(Value = "PRE_ARBITRATION_CREATED")]
            PREARBITRATIONCREATED = 22,

            /// <summary>
            /// Enum PREARBITRATIONDOCSRECEIVED for value: PRE_ARBITRATION_DOCS_RECEIVED
            /// </summary>
            [EnumMember(Value = "PRE_ARBITRATION_DOCS_RECEIVED")]
            PREARBITRATIONDOCSRECEIVED = 23,

            /// <summary>
            /// Enum PREARBITRATIONUNDERREVIEW for value: PRE_ARBITRATION_UNDER_REVIEW
            /// </summary>
            [EnumMember(Value = "PRE_ARBITRATION_UNDER_REVIEW")]
            PREARBITRATIONUNDERREVIEW = 24,

            /// <summary>
            /// Enum PREARBITRATIONMERCHANTWON for value: PRE_ARBITRATION_MERCHANT_WON
            /// </summary>
            [EnumMember(Value = "PRE_ARBITRATION_MERCHANT_WON")]
            PREARBITRATIONMERCHANTWON = 25,

            /// <summary>
            /// Enum PREARBITRATIONMERCHANTLOST for value: PRE_ARBITRATION_MERCHANT_LOST
            /// </summary>
            [EnumMember(Value = "PRE_ARBITRATION_MERCHANT_LOST")]
            PREARBITRATIONMERCHANTLOST = 26,

            /// <summary>
            /// Enum PREARBITRATIONMERCHANTACCEPTED for value: PRE_ARBITRATION_MERCHANT_ACCEPTED
            /// </summary>
            [EnumMember(Value = "PRE_ARBITRATION_MERCHANT_ACCEPTED")]
            PREARBITRATIONMERCHANTACCEPTED = 27,

            /// <summary>
            /// Enum PREARBITRATIONINSUFFICIENTEVIDENCE for value: PRE_ARBITRATION_INSUFFICIENT_EVIDENCE
            /// </summary>
            [EnumMember(Value = "PRE_ARBITRATION_INSUFFICIENT_EVIDENCE")]
            PREARBITRATIONINSUFFICIENTEVIDENCE = 28,

            /// <summary>
            /// Enum ARBITRATIONCREATED for value: ARBITRATION_CREATED
            /// </summary>
            [EnumMember(Value = "ARBITRATION_CREATED")]
            ARBITRATIONCREATED = 29,

            /// <summary>
            /// Enum ARBITRATIONDOCSRECEIVED for value: ARBITRATION_DOCS_RECEIVED
            /// </summary>
            [EnumMember(Value = "ARBITRATION_DOCS_RECEIVED")]
            ARBITRATIONDOCSRECEIVED = 30,

            /// <summary>
            /// Enum ARBITRATIONUNDERREVIEW for value: ARBITRATION_UNDER_REVIEW
            /// </summary>
            [EnumMember(Value = "ARBITRATION_UNDER_REVIEW")]
            ARBITRATIONUNDERREVIEW = 31,

            /// <summary>
            /// Enum ARBITRATIONMERCHANTWON for value: ARBITRATION_MERCHANT_WON
            /// </summary>
            [EnumMember(Value = "ARBITRATION_MERCHANT_WON")]
            ARBITRATIONMERCHANTWON = 32,

            /// <summary>
            /// Enum ARBITRATIONMERCHANTLOST for value: ARBITRATION_MERCHANT_LOST
            /// </summary>
            [EnumMember(Value = "ARBITRATION_MERCHANT_LOST")]
            ARBITRATIONMERCHANTLOST = 33,

            /// <summary>
            /// Enum ARBITRATIONMERCHANTACCEPTED for value: ARBITRATION_MERCHANT_ACCEPTED
            /// </summary>
            [EnumMember(Value = "ARBITRATION_MERCHANT_ACCEPTED")]
            ARBITRATIONMERCHANTACCEPTED = 34,

            /// <summary>
            /// Enum ARBITRATIONINSUFFICIENTEVIDENCE for value: ARBITRATION_INSUFFICIENT_EVIDENCE
            /// </summary>
            [EnumMember(Value = "ARBITRATION_INSUFFICIENT_EVIDENCE")]
            ARBITRATIONINSUFFICIENTEVIDENCE = 35
        }


        /// <summary>
        /// Gets or Sets dispute_status
        /// </summary>
        [DataMember(Name = "dispute_status", EmitDefaultValue = false)]
        public DisputeStatusEnum? dispute_status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DisputesEntity" /> class.
        /// </summary>
        /// <param name="disputeId">disputeId.</param>
        /// <param name="disputeType">disputeType.</param>
        /// <param name="reasonCode">reasonCode.</param>
        /// <param name="reasonDescription">reasonDescription.</param>
        /// <param name="disputeAmount">Dispute amount may differ from transaction amount for partial cases..</param>
        /// <param name="disputeAmountCurrency">Dispute amount currency for a dispute.</param>
        /// <param name="createdAt">This is the time when the dispute was created..</param>
        /// <param name="respondBy">This is the time by which evidence should be submitted to contest the dispute..</param>
        /// <param name="updatedAt">This is the time when the dispute case was updated..</param>
        /// <param name="resolvedAt">This is the time when the dispute case was closed..</param>
        /// <param name="disputeStatus">disputeStatus.</param>
        /// <param name="cfDisputeRemarks">cfDisputeRemarks.</param>
        /// <param name="preferredEvidence">preferredEvidence.</param>
        /// <param name="disputeEvidence">disputeEvidence.</param>
        /// <param name="orderDetails">orderDetails.</param>
        /// <param name="customerDetails">customerDetails.</param>
        public DisputesEntity(int? disputeId = default(int?), DisputeTypeEnum? disputeType = default(DisputeTypeEnum?), string? reasonCode = default(string?), string? reasonDescription = default(string?), decimal? disputeAmount = default(decimal?), string? disputeAmountCurrency = default(string?), string? createdAt = default(string?), string? respondBy = default(string?), string? updatedAt = default(string?), string? resolvedAt = default(string?), DisputeStatusEnum? disputeStatus = default(DisputeStatusEnum?), string? cfDisputeRemarks = default(string?), List<EvidencesToContestDispute>? preferredEvidence = default(List<EvidencesToContestDispute>?), List<Evidence>? disputeEvidence = default(List<Evidence>?), OrderDetailsInDisputesEntity? orderDetails = default(OrderDetailsInDisputesEntity?), CustomerDetailsInDisputesEntity? customerDetails = default(CustomerDetailsInDisputesEntity?))
        {
            this.dispute_id = disputeId;
            this.dispute_type = disputeType;
            this.reason_code = reasonCode;
            this.reason_description = reasonDescription;
            this.dispute_amount = disputeAmount;
            this.dispute_amount_currency = disputeAmountCurrency;
            this.created_at = createdAt;
            this.respond_by = respondBy;
            this.updated_at = updatedAt;
            this.resolved_at = resolvedAt;
            this.dispute_status = disputeStatus;
            this.cf_dispute_remarks = cfDisputeRemarks;
            this.preferred_evidence = preferredEvidence;
            this.dispute_evidence = disputeEvidence;
            this.order_details = orderDetails;
            this.customer_details = customerDetails;
        }

        /// <summary>
        /// Gets or Sets dispute_id
        /// </summary>
        [DataMember(Name = "dispute_id", EmitDefaultValue = false)]
        public int? dispute_id { get; set; }

        /// <summary>
        /// Gets or Sets reason_code
        /// </summary>
        [DataMember(Name = "reason_code", EmitDefaultValue = false)]
        public string? reason_code { get; set; }

        /// <summary>
        /// Gets or Sets reason_description
        /// </summary>
        [DataMember(Name = "reason_description", EmitDefaultValue = false)]
        public string? reason_description { get; set; }

        /// <summary>
        /// Dispute amount may differ from transaction amount for partial cases.
        /// </summary>
        /// <value>Dispute amount may differ from transaction amount for partial cases.</value>
        [DataMember(Name = "dispute_amount", EmitDefaultValue = false)]
        public decimal? dispute_amount { get; set; }

        /// <summary>
        /// Dispute amount currency for a dispute
        /// </summary>
        /// <value>Dispute amount currency for a dispute</value>
        [DataMember(Name = "dispute_amount_currency", EmitDefaultValue = false)]
        public string? dispute_amount_currency { get; set; }

        /// <summary>
        /// This is the time when the dispute was created.
        /// </summary>
        /// <value>This is the time when the dispute was created.</value>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public string? created_at { get; set; }

        /// <summary>
        /// This is the time by which evidence should be submitted to contest the dispute.
        /// </summary>
        /// <value>This is the time by which evidence should be submitted to contest the dispute.</value>
        [DataMember(Name = "respond_by", EmitDefaultValue = false)]
        public string? respond_by { get; set; }

        /// <summary>
        /// This is the time when the dispute case was updated.
        /// </summary>
        /// <value>This is the time when the dispute case was updated.</value>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public string? updated_at { get; set; }

        /// <summary>
        /// This is the time when the dispute case was closed.
        /// </summary>
        /// <value>This is the time when the dispute case was closed.</value>
        [DataMember(Name = "resolved_at", EmitDefaultValue = false)]
        public string? resolved_at { get; set; }

        /// <summary>
        /// Gets or Sets cf_dispute_remarks
        /// </summary>
        [DataMember(Name = "cf_dispute_remarks", EmitDefaultValue = false)]
        public string? cf_dispute_remarks { get; set; }

        /// <summary>
        /// Gets or Sets preferred_evidence
        /// </summary>
        /// <example>{&quot;preferred_evidence&quot;:[{&quot;document_type&quot;:&quot;Delivery/Service Proof&quot;,&quot;document_description&quot;:&quot;Proof that the cardholder/customer received the goods or services.&quot;},{&quot;document_type&quot;:&quot;Statement of Service&quot;,&quot;document_description&quot;:&quot;Account Statement of wallet where funds were loaded by customer.&quot;}]}</example>
        [DataMember(Name = "preferred_evidence", EmitDefaultValue = false)]
        public List<EvidencesToContestDispute>? preferred_evidence { get; set; }

        /// <summary>
        /// Gets or Sets dispute_evidence
        /// </summary>
        /// <example>[{&quot;document_id&quot;:18150,&quot;document_name&quot;:&quot;disputeSampleFile.pdf&quot;,&quot;document_type&quot;:&quot;DeliveryProof&quot;}]</example>
        [DataMember(Name = "dispute_evidence", EmitDefaultValue = false)]
        public List<Evidence>? dispute_evidence { get; set; }

        /// <summary>
        /// Gets or Sets order_details
        /// </summary>
        [DataMember(Name = "order_details", EmitDefaultValue = false)]
        public OrderDetailsInDisputesEntity? order_details { get; set; }

        /// <summary>
        /// Gets or Sets customer_details
        /// </summary>
        [DataMember(Name = "customer_details", EmitDefaultValue = false)]
        public CustomerDetailsInDisputesEntity? customer_details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DisputesEntity {\n");
            sb.Append("  dispute_id: ").Append(dispute_id).Append("\n");
            sb.Append("  dispute_type: ").Append(dispute_type).Append("\n");
            sb.Append("  reason_code: ").Append(reason_code).Append("\n");
            sb.Append("  reason_description: ").Append(reason_description).Append("\n");
            sb.Append("  dispute_amount: ").Append(dispute_amount).Append("\n");
            sb.Append("  dispute_amount_currency: ").Append(dispute_amount_currency).Append("\n");
            sb.Append("  created_at: ").Append(created_at).Append("\n");
            sb.Append("  respond_by: ").Append(respond_by).Append("\n");
            sb.Append("  updated_at: ").Append(updated_at).Append("\n");
            sb.Append("  resolved_at: ").Append(resolved_at).Append("\n");
            sb.Append("  dispute_status: ").Append(dispute_status).Append("\n");
            sb.Append("  cf_dispute_remarks: ").Append(cf_dispute_remarks).Append("\n");
            sb.Append("  preferred_evidence: ").Append(preferred_evidence).Append("\n");
            sb.Append("  dispute_evidence: ").Append(dispute_evidence).Append("\n");
            sb.Append("  order_details: ").Append(order_details).Append("\n");
            sb.Append("  customer_details: ").Append(customer_details).Append("\n");
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
            return this.Equals(input as DisputesEntity);
        }

        /// <summary>
        /// Returns true if DisputesEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of DisputesEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DisputesEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.dispute_id == input.dispute_id ||
                    this.dispute_id.Equals(input.dispute_id)
                ) && 
                (
                    this.dispute_type == input.dispute_type ||
                    this.dispute_type.Equals(input.dispute_type)
                ) && 
                (
                    this.reason_code == input.reason_code ||
                    (this.reason_code != null &&
                    this.reason_code.Equals(input.reason_code))
                ) && 
                (
                    this.reason_description == input.reason_description ||
                    (this.reason_description != null &&
                    this.reason_description.Equals(input.reason_description))
                ) && 
                (
                    this.dispute_amount == input.dispute_amount ||
                    this.dispute_amount.Equals(input.dispute_amount)
                ) && 
                (
                    this.dispute_amount_currency == input.dispute_amount_currency ||
                    (this.dispute_amount_currency != null &&
                    this.dispute_amount_currency.Equals(input.dispute_amount_currency))
                ) && 
                (
                    this.created_at == input.created_at ||
                    (this.created_at != null &&
                    this.created_at.Equals(input.created_at))
                ) && 
                (
                    this.respond_by == input.respond_by ||
                    (this.respond_by != null &&
                    this.respond_by.Equals(input.respond_by))
                ) && 
                (
                    this.updated_at == input.updated_at ||
                    (this.updated_at != null &&
                    this.updated_at.Equals(input.updated_at))
                ) && 
                (
                    this.resolved_at == input.resolved_at ||
                    (this.resolved_at != null &&
                    this.resolved_at.Equals(input.resolved_at))
                ) && 
                (
                    this.dispute_status == input.dispute_status ||
                    this.dispute_status.Equals(input.dispute_status)
                ) && 
                (
                    this.cf_dispute_remarks == input.cf_dispute_remarks ||
                    (this.cf_dispute_remarks != null &&
                    this.cf_dispute_remarks.Equals(input.cf_dispute_remarks))
                ) && 
                (
                    this.preferred_evidence == input.preferred_evidence ||
                    this.preferred_evidence != null &&
                    input.preferred_evidence != null &&
                    this.preferred_evidence.SequenceEqual(input.preferred_evidence)
                ) && 
                (
                    this.dispute_evidence == input.dispute_evidence ||
                    this.dispute_evidence != null &&
                    input.dispute_evidence != null &&
                    this.dispute_evidence.SequenceEqual(input.dispute_evidence)
                ) && 
                (
                    this.order_details == input.order_details ||
                    (this.order_details != null &&
                    this.order_details.Equals(input.order_details))
                ) && 
                (
                    this.customer_details == input.customer_details ||
                    (this.customer_details != null &&
                    this.customer_details.Equals(input.customer_details))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringdispute_id) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringdispute_id);
            if (deserializedJsonString.ContainsKey("dispute_id")) {
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
                hashCode = (hashCode * 59) + this.dispute_id.GetHashCode();
                hashCode = (hashCode * 59) + this.dispute_type.GetHashCode();
                if (this.reason_code != null)
                {
                    hashCode = (hashCode * 59) + this.reason_code.GetHashCode();
                }
                if (this.reason_description != null)
                {
                    hashCode = (hashCode * 59) + this.reason_description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.dispute_amount.GetHashCode();
                if (this.dispute_amount_currency != null)
                {
                    hashCode = (hashCode * 59) + this.dispute_amount_currency.GetHashCode();
                }
                if (this.created_at != null)
                {
                    hashCode = (hashCode * 59) + this.created_at.GetHashCode();
                }
                if (this.respond_by != null)
                {
                    hashCode = (hashCode * 59) + this.respond_by.GetHashCode();
                }
                if (this.updated_at != null)
                {
                    hashCode = (hashCode * 59) + this.updated_at.GetHashCode();
                }
                if (this.resolved_at != null)
                {
                    hashCode = (hashCode * 59) + this.resolved_at.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.dispute_status.GetHashCode();
                if (this.cf_dispute_remarks != null)
                {
                    hashCode = (hashCode * 59) + this.cf_dispute_remarks.GetHashCode();
                }
                if (this.preferred_evidence != null)
                {
                    hashCode = (hashCode * 59) + this.preferred_evidence.GetHashCode();
                }
                if (this.dispute_evidence != null)
                {
                    hashCode = (hashCode * 59) + this.dispute_evidence.GetHashCode();
                }
                if (this.order_details != null)
                {
                    hashCode = (hashCode * 59) + this.order_details.GetHashCode();
                }
                if (this.customer_details != null)
                {
                    hashCode = (hashCode * 59) + this.customer_details.GetHashCode();
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

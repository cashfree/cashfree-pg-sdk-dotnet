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
    /// SettlementReconEntityDataInnerSettlementDetails
    /// </summary>
    [DataContract(Name = "SettlementReconEntity_data_inner_settlement_details")]
    public class SettlementReconEntityDataInnerSettlementDetails : IEquatable<SettlementReconEntityDataInnerSettlementDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettlementReconEntityDataInnerSettlementDetails" /> class.
        /// </summary>
        /// <param name="cfSettlementId">Unique ID to identify the settlement..</param>
        /// <param name="settlementDate">Date and time when the settlement was processed..</param>
        /// <param name="utr">Unique transaction reference number of the settlement..</param>
        /// <param name="splitServiceCharge">Service charge that is applicable for splitting the payment..</param>
        /// <param name="splitServiceTax">Service tax applicable for splitting the amount to vendors..</param>
        /// <param name="vendorCommission">Vendor commission applicable for this transaction..</param>
        /// <param name="paymentFrom">Date and time from settlement computed..</param>
        /// <param name="paymentTill">Date and time till settlement computed..</param>
        /// <param name="reason">If any reason for settlement failure..</param>
        /// <param name="remarks">Remarks related for settlement..</param>
        /// <param name="serviceCharge">Service charge for the transactions..</param>
        /// <param name="serviceTax">Service tax for the transactions..</param>
        /// <param name="settlementCharge">Settlement Service Charge..</param>
        /// <param name="settlementInitiatedOn">Date and time when Settlement initiated..</param>
        /// <param name="settlementTax">Settlement Service Tax..</param>
        /// <param name="settlementType">Type of Settlement, Example - Normal Settlement..</param>
        public SettlementReconEntityDataInnerSettlementDetails(string? cfSettlementId = default(string?), string? settlementDate = default(string?), string? utr = default(string?), decimal? splitServiceCharge = default(decimal?), decimal? splitServiceTax = default(decimal?), decimal? vendorCommission = default(decimal?), string? paymentFrom = default(string?), string? paymentTill = default(string?), string? reason = default(string?), string? remarks = default(string?), decimal? serviceCharge = default(decimal?), decimal? serviceTax = default(decimal?), decimal? settlementCharge = default(decimal?), string? settlementInitiatedOn = default(string?), decimal? settlementTax = default(decimal?), string? settlementType = default(string?))
        {
            this.cf_settlement_id = cfSettlementId;
            this.settlement_date = settlementDate;
            this.utr = utr;
            this.split_service_charge = splitServiceCharge;
            this.split_service_tax = splitServiceTax;
            this.vendor_commission = vendorCommission;
            this.payment_from = paymentFrom;
            this.payment_till = paymentTill;
            this.reason = reason;
            this.remarks = remarks;
            this.service_charge = serviceCharge;
            this.service_tax = serviceTax;
            this.settlement_charge = settlementCharge;
            this.settlement_initiated_on = settlementInitiatedOn;
            this.settlement_tax = settlementTax;
            this.settlement_type = settlementType;
        }

        /// <summary>
        /// Unique ID to identify the settlement.
        /// </summary>
        /// <value>Unique ID to identify the settlement.</value>
        [DataMember(Name = "cf_settlement_id", EmitDefaultValue = false)]
        public string? cf_settlement_id { get; set; }

        /// <summary>
        /// Date and time when the settlement was processed.
        /// </summary>
        /// <value>Date and time when the settlement was processed.</value>
        [DataMember(Name = "settlement_date", EmitDefaultValue = false)]
        public string? settlement_date { get; set; }

        /// <summary>
        /// Unique transaction reference number of the settlement.
        /// </summary>
        /// <value>Unique transaction reference number of the settlement.</value>
        [DataMember(Name = "utr", EmitDefaultValue = false)]
        public string? utr { get; set; }

        /// <summary>
        /// Service charge that is applicable for splitting the payment.
        /// </summary>
        /// <value>Service charge that is applicable for splitting the payment.</value>
        [DataMember(Name = "split_service_charge", EmitDefaultValue = false)]
        public decimal? split_service_charge { get; set; }

        /// <summary>
        /// Service tax applicable for splitting the amount to vendors.
        /// </summary>
        /// <value>Service tax applicable for splitting the amount to vendors.</value>
        [DataMember(Name = "split_service_tax", EmitDefaultValue = false)]
        public decimal? split_service_tax { get; set; }

        /// <summary>
        /// Vendor commission applicable for this transaction.
        /// </summary>
        /// <value>Vendor commission applicable for this transaction.</value>
        [DataMember(Name = "vendor_commission", EmitDefaultValue = false)]
        public decimal? vendor_commission { get; set; }

        /// <summary>
        /// Date and time from settlement computed.
        /// </summary>
        /// <value>Date and time from settlement computed.</value>
        [DataMember(Name = "payment_from", EmitDefaultValue = false)]
        public string? payment_from { get; set; }

        /// <summary>
        /// Date and time till settlement computed.
        /// </summary>
        /// <value>Date and time till settlement computed.</value>
        [DataMember(Name = "payment_till", EmitDefaultValue = false)]
        public string? payment_till { get; set; }

        /// <summary>
        /// If any reason for settlement failure.
        /// </summary>
        /// <value>If any reason for settlement failure.</value>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string? reason { get; set; }

        /// <summary>
        /// Remarks related for settlement.
        /// </summary>
        /// <value>Remarks related for settlement.</value>
        [DataMember(Name = "remarks", EmitDefaultValue = false)]
        public string? remarks { get; set; }

        /// <summary>
        /// Service charge for the transactions.
        /// </summary>
        /// <value>Service charge for the transactions.</value>
        [DataMember(Name = "service_charge", EmitDefaultValue = false)]
        public decimal? service_charge { get; set; }

        /// <summary>
        /// Service tax for the transactions.
        /// </summary>
        /// <value>Service tax for the transactions.</value>
        [DataMember(Name = "service_tax", EmitDefaultValue = false)]
        public decimal? service_tax { get; set; }

        /// <summary>
        /// Settlement Service Charge.
        /// </summary>
        /// <value>Settlement Service Charge.</value>
        [DataMember(Name = "settlement_charge", EmitDefaultValue = false)]
        public decimal? settlement_charge { get; set; }

        /// <summary>
        /// Date and time when Settlement initiated.
        /// </summary>
        /// <value>Date and time when Settlement initiated.</value>
        [DataMember(Name = "settlement_initiated_on", EmitDefaultValue = false)]
        public string? settlement_initiated_on { get; set; }

        /// <summary>
        /// Settlement Service Tax.
        /// </summary>
        /// <value>Settlement Service Tax.</value>
        [DataMember(Name = "settlement_tax", EmitDefaultValue = false)]
        public decimal? settlement_tax { get; set; }

        /// <summary>
        /// Type of Settlement, Example - Normal Settlement.
        /// </summary>
        /// <value>Type of Settlement, Example - Normal Settlement.</value>
        [DataMember(Name = "settlement_type", EmitDefaultValue = false)]
        public string? settlement_type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SettlementReconEntityDataInnerSettlementDetails {\n");
            sb.Append("  cf_settlement_id: ").Append(cf_settlement_id).Append("\n");
            sb.Append("  settlement_date: ").Append(settlement_date).Append("\n");
            sb.Append("  utr: ").Append(utr).Append("\n");
            sb.Append("  split_service_charge: ").Append(split_service_charge).Append("\n");
            sb.Append("  split_service_tax: ").Append(split_service_tax).Append("\n");
            sb.Append("  vendor_commission: ").Append(vendor_commission).Append("\n");
            sb.Append("  payment_from: ").Append(payment_from).Append("\n");
            sb.Append("  payment_till: ").Append(payment_till).Append("\n");
            sb.Append("  reason: ").Append(reason).Append("\n");
            sb.Append("  remarks: ").Append(remarks).Append("\n");
            sb.Append("  service_charge: ").Append(service_charge).Append("\n");
            sb.Append("  service_tax: ").Append(service_tax).Append("\n");
            sb.Append("  settlement_charge: ").Append(settlement_charge).Append("\n");
            sb.Append("  settlement_initiated_on: ").Append(settlement_initiated_on).Append("\n");
            sb.Append("  settlement_tax: ").Append(settlement_tax).Append("\n");
            sb.Append("  settlement_type: ").Append(settlement_type).Append("\n");
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
            return this.Equals(input as SettlementReconEntityDataInnerSettlementDetails);
        }

        /// <summary>
        /// Returns true if SettlementReconEntityDataInnerSettlementDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of SettlementReconEntityDataInnerSettlementDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettlementReconEntityDataInnerSettlementDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cf_settlement_id == input.cf_settlement_id ||
                    (this.cf_settlement_id != null &&
                    this.cf_settlement_id.Equals(input.cf_settlement_id))
                ) && 
                (
                    this.settlement_date == input.settlement_date ||
                    (this.settlement_date != null &&
                    this.settlement_date.Equals(input.settlement_date))
                ) && 
                (
                    this.utr == input.utr ||
                    (this.utr != null &&
                    this.utr.Equals(input.utr))
                ) && 
                (
                    this.split_service_charge == input.split_service_charge ||
                    this.split_service_charge.Equals(input.split_service_charge)
                ) && 
                (
                    this.split_service_tax == input.split_service_tax ||
                    this.split_service_tax.Equals(input.split_service_tax)
                ) && 
                (
                    this.vendor_commission == input.vendor_commission ||
                    this.vendor_commission.Equals(input.vendor_commission)
                ) && 
                (
                    this.payment_from == input.payment_from ||
                    (this.payment_from != null &&
                    this.payment_from.Equals(input.payment_from))
                ) && 
                (
                    this.payment_till == input.payment_till ||
                    (this.payment_till != null &&
                    this.payment_till.Equals(input.payment_till))
                ) && 
                (
                    this.reason == input.reason ||
                    (this.reason != null &&
                    this.reason.Equals(input.reason))
                ) && 
                (
                    this.remarks == input.remarks ||
                    (this.remarks != null &&
                    this.remarks.Equals(input.remarks))
                ) && 
                (
                    this.service_charge == input.service_charge ||
                    this.service_charge.Equals(input.service_charge)
                ) && 
                (
                    this.service_tax == input.service_tax ||
                    this.service_tax.Equals(input.service_tax)
                ) && 
                (
                    this.settlement_charge == input.settlement_charge ||
                    this.settlement_charge.Equals(input.settlement_charge)
                ) && 
                (
                    this.settlement_initiated_on == input.settlement_initiated_on ||
                    (this.settlement_initiated_on != null &&
                    this.settlement_initiated_on.Equals(input.settlement_initiated_on))
                ) && 
                (
                    this.settlement_tax == input.settlement_tax ||
                    this.settlement_tax.Equals(input.settlement_tax)
                ) && 
                (
                    this.settlement_type == input.settlement_type ||
                    (this.settlement_type != null &&
                    this.settlement_type.Equals(input.settlement_type))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringcf_settlement_id) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringcf_settlement_id);
            if (deserializedJsonString.ContainsKey("cf_settlement_id")) {
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
                if (this.cf_settlement_id != null)
                {
                    hashCode = (hashCode * 59) + this.cf_settlement_id.GetHashCode();
                }
                if (this.settlement_date != null)
                {
                    hashCode = (hashCode * 59) + this.settlement_date.GetHashCode();
                }
                if (this.utr != null)
                {
                    hashCode = (hashCode * 59) + this.utr.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.split_service_charge.GetHashCode();
                hashCode = (hashCode * 59) + this.split_service_tax.GetHashCode();
                hashCode = (hashCode * 59) + this.vendor_commission.GetHashCode();
                if (this.payment_from != null)
                {
                    hashCode = (hashCode * 59) + this.payment_from.GetHashCode();
                }
                if (this.payment_till != null)
                {
                    hashCode = (hashCode * 59) + this.payment_till.GetHashCode();
                }
                if (this.reason != null)
                {
                    hashCode = (hashCode * 59) + this.reason.GetHashCode();
                }
                if (this.remarks != null)
                {
                    hashCode = (hashCode * 59) + this.remarks.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.service_charge.GetHashCode();
                hashCode = (hashCode * 59) + this.service_tax.GetHashCode();
                hashCode = (hashCode * 59) + this.settlement_charge.GetHashCode();
                if (this.settlement_initiated_on != null)
                {
                    hashCode = (hashCode * 59) + this.settlement_initiated_on.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.settlement_tax.GetHashCode();
                if (this.settlement_type != null)
                {
                    hashCode = (hashCode * 59) + this.settlement_type.GetHashCode();
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

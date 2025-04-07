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
    /// Update Vendor Response
    /// </summary>
    [DataContract(Name = "UpdateVendorResponse")]
    public class UpdateVendorResponse : IEquatable<UpdateVendorResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVendorResponse" /> class.
        /// </summary>
        /// <param name="email">email.</param>
        /// <param name="status">status.</param>
        /// <param name="bank">bank.</param>
        /// <param name="upi">upi.</param>
        /// <param name="addedOn">addedOn.</param>
        /// <param name="updatedOn">updatedOn.</param>
        /// <param name="vendorType">vendorType.</param>
        /// <param name="accountType">accountType.</param>
        /// <param name="businessType">businessType.</param>
        /// <param name="phone">phone.</param>
        /// <param name="name">name.</param>
        /// <param name="vendorId">vendorId.</param>
        /// <param name="scheduleOption">scheduleOption.</param>
        /// <param name="kycDetails">kycDetails.</param>
        /// <param name="dashboardAccess">dashboardAccess.</param>
        /// <param name="bankDetails">bankDetails.</param>
        /// <param name="relatedDocs">relatedDocs.</param>
        public UpdateVendorResponse(string? email = default(string?), string? status = default(string?), List<BankDetails>? bank = default(List<BankDetails>?), string? upi = default(string?), string? addedOn = default(string?), string? updatedOn = default(string?), string? vendorType = default(string?), string? accountType = default(string?), string? businessType = default(string?), decimal? phone = default(decimal?), string? name = default(string?), string? vendorId = default(string?), List<ScheduleOption>? scheduleOption = default(List<ScheduleOption>?), List<KycDetails>? kycDetails = default(List<KycDetails>?), bool? dashboardAccess = default(bool?), string? bankDetails = default(string?), List<VendorEntityRelatedDocsInner>? relatedDocs = default(List<VendorEntityRelatedDocsInner>?))
        {
            this.email = email;
            this.status = status;
            this.bank = bank;
            this.upi = upi;
            this.added_on = addedOn;
            this.updated_on = updatedOn;
            this.vendor_type = vendorType;
            this.account_type = accountType;
            this.business_type = businessType;
            this.phone = phone;
            this.name = name;
            this.vendor_id = vendorId;
            this.schedule_option = scheduleOption;
            this.kyc_details = kycDetails;
            this.dashboard_access = dashboardAccess;
            this.bank_details = bankDetails;
            this.related_docs = relatedDocs;
        }

        /// <summary>
        /// Gets or Sets email
        /// </summary>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string? email { get; set; }

        /// <summary>
        /// Gets or Sets status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string? status { get; set; }

        /// <summary>
        /// Gets or Sets bank
        /// </summary>
        [DataMember(Name = "bank", EmitDefaultValue = false)]
        public List<BankDetails>? bank { get; set; }

        /// <summary>
        /// Gets or Sets upi
        /// </summary>
        [DataMember(Name = "upi", EmitDefaultValue = false)]
        public string? upi { get; set; }

        /// <summary>
        /// Gets or Sets added_on
        /// </summary>
        [DataMember(Name = "added_on", EmitDefaultValue = false)]
        public string? added_on { get; set; }

        /// <summary>
        /// Gets or Sets updated_on
        /// </summary>
        [DataMember(Name = "updated_on", EmitDefaultValue = false)]
        public string? updated_on { get; set; }

        /// <summary>
        /// Gets or Sets vendor_type
        /// </summary>
        [DataMember(Name = "vendor_type", EmitDefaultValue = false)]
        public string? vendor_type { get; set; }

        /// <summary>
        /// Gets or Sets account_type
        /// </summary>
        [DataMember(Name = "account_type", EmitDefaultValue = false)]
        public string? account_type { get; set; }

        /// <summary>
        /// Gets or Sets business_type
        /// </summary>
        [DataMember(Name = "business_type", EmitDefaultValue = false)]
        public string? business_type { get; set; }

        /// <summary>
        /// Gets or Sets phone
        /// </summary>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public decimal? phone { get; set; }

        /// <summary>
        /// Gets or Sets name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string? name { get; set; }

        /// <summary>
        /// Gets or Sets vendor_id
        /// </summary>
        [DataMember(Name = "vendor_id", EmitDefaultValue = false)]
        public string? vendor_id { get; set; }

        /// <summary>
        /// Gets or Sets schedule_option
        /// </summary>
        [DataMember(Name = "schedule_option", EmitDefaultValue = false)]
        public List<ScheduleOption>? schedule_option { get; set; }

        /// <summary>
        /// Gets or Sets kyc_details
        /// </summary>
        [DataMember(Name = "kyc_details", EmitDefaultValue = false)]
        public List<KycDetails>? kyc_details { get; set; }

        /// <summary>
        /// Gets or Sets dashboard_access
        /// </summary>
        [DataMember(Name = "dashboard_access", EmitDefaultValue = true)]
        public bool? dashboard_access { get; set; }

        /// <summary>
        /// Gets or Sets bank_details
        /// </summary>
        [DataMember(Name = "bank_details", EmitDefaultValue = false)]
        public string? bank_details { get; set; }

        /// <summary>
        /// Gets or Sets related_docs
        /// </summary>
        [DataMember(Name = "related_docs", EmitDefaultValue = false)]
        public List<VendorEntityRelatedDocsInner>? related_docs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateVendorResponse {\n");
            sb.Append("  email: ").Append(email).Append("\n");
            sb.Append("  status: ").Append(status).Append("\n");
            sb.Append("  bank: ").Append(bank).Append("\n");
            sb.Append("  upi: ").Append(upi).Append("\n");
            sb.Append("  added_on: ").Append(added_on).Append("\n");
            sb.Append("  updated_on: ").Append(updated_on).Append("\n");
            sb.Append("  vendor_type: ").Append(vendor_type).Append("\n");
            sb.Append("  account_type: ").Append(account_type).Append("\n");
            sb.Append("  business_type: ").Append(business_type).Append("\n");
            sb.Append("  phone: ").Append(phone).Append("\n");
            sb.Append("  name: ").Append(name).Append("\n");
            sb.Append("  vendor_id: ").Append(vendor_id).Append("\n");
            sb.Append("  schedule_option: ").Append(schedule_option).Append("\n");
            sb.Append("  kyc_details: ").Append(kyc_details).Append("\n");
            sb.Append("  dashboard_access: ").Append(dashboard_access).Append("\n");
            sb.Append("  bank_details: ").Append(bank_details).Append("\n");
            sb.Append("  related_docs: ").Append(related_docs).Append("\n");
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
            return this.Equals(input as UpdateVendorResponse);
        }

        /// <summary>
        /// Returns true if UpdateVendorResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateVendorResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateVendorResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.email == input.email ||
                    (this.email != null &&
                    this.email.Equals(input.email))
                ) && 
                (
                    this.status == input.status ||
                    (this.status != null &&
                    this.status.Equals(input.status))
                ) && 
                (
                    this.bank == input.bank ||
                    this.bank != null &&
                    input.bank != null &&
                    this.bank.SequenceEqual(input.bank)
                ) && 
                (
                    this.upi == input.upi ||
                    (this.upi != null &&
                    this.upi.Equals(input.upi))
                ) && 
                (
                    this.added_on == input.added_on ||
                    (this.added_on != null &&
                    this.added_on.Equals(input.added_on))
                ) && 
                (
                    this.updated_on == input.updated_on ||
                    (this.updated_on != null &&
                    this.updated_on.Equals(input.updated_on))
                ) && 
                (
                    this.vendor_type == input.vendor_type ||
                    (this.vendor_type != null &&
                    this.vendor_type.Equals(input.vendor_type))
                ) && 
                (
                    this.account_type == input.account_type ||
                    (this.account_type != null &&
                    this.account_type.Equals(input.account_type))
                ) && 
                (
                    this.business_type == input.business_type ||
                    (this.business_type != null &&
                    this.business_type.Equals(input.business_type))
                ) && 
                (
                    this.phone == input.phone ||
                    this.phone.Equals(input.phone)
                ) && 
                (
                    this.name == input.name ||
                    (this.name != null &&
                    this.name.Equals(input.name))
                ) && 
                (
                    this.vendor_id == input.vendor_id ||
                    (this.vendor_id != null &&
                    this.vendor_id.Equals(input.vendor_id))
                ) && 
                (
                    this.schedule_option == input.schedule_option ||
                    this.schedule_option != null &&
                    input.schedule_option != null &&
                    this.schedule_option.SequenceEqual(input.schedule_option)
                ) && 
                (
                    this.kyc_details == input.kyc_details ||
                    this.kyc_details != null &&
                    input.kyc_details != null &&
                    this.kyc_details.SequenceEqual(input.kyc_details)
                ) && 
                (
                    this.dashboard_access == input.dashboard_access ||
                    this.dashboard_access.Equals(input.dashboard_access)
                ) && 
                (
                    this.bank_details == input.bank_details ||
                    (this.bank_details != null &&
                    this.bank_details.Equals(input.bank_details))
                ) && 
                (
                    this.related_docs == input.related_docs ||
                    this.related_docs != null &&
                    input.related_docs != null &&
                    this.related_docs.SequenceEqual(input.related_docs)
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringemail) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringemail);
            if (deserializedJsonString.ContainsKey("email")) {
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
                if (this.email != null)
                {
                    hashCode = (hashCode * 59) + this.email.GetHashCode();
                }
                if (this.status != null)
                {
                    hashCode = (hashCode * 59) + this.status.GetHashCode();
                }
                if (this.bank != null)
                {
                    hashCode = (hashCode * 59) + this.bank.GetHashCode();
                }
                if (this.upi != null)
                {
                    hashCode = (hashCode * 59) + this.upi.GetHashCode();
                }
                if (this.added_on != null)
                {
                    hashCode = (hashCode * 59) + this.added_on.GetHashCode();
                }
                if (this.updated_on != null)
                {
                    hashCode = (hashCode * 59) + this.updated_on.GetHashCode();
                }
                if (this.vendor_type != null)
                {
                    hashCode = (hashCode * 59) + this.vendor_type.GetHashCode();
                }
                if (this.account_type != null)
                {
                    hashCode = (hashCode * 59) + this.account_type.GetHashCode();
                }
                if (this.business_type != null)
                {
                    hashCode = (hashCode * 59) + this.business_type.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.phone.GetHashCode();
                if (this.name != null)
                {
                    hashCode = (hashCode * 59) + this.name.GetHashCode();
                }
                if (this.vendor_id != null)
                {
                    hashCode = (hashCode * 59) + this.vendor_id.GetHashCode();
                }
                if (this.schedule_option != null)
                {
                    hashCode = (hashCode * 59) + this.schedule_option.GetHashCode();
                }
                if (this.kyc_details != null)
                {
                    hashCode = (hashCode * 59) + this.kyc_details.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.dashboard_access.GetHashCode();
                if (this.bank_details != null)
                {
                    hashCode = (hashCode * 59) + this.bank_details.GetHashCode();
                }
                if (this.related_docs != null)
                {
                    hashCode = (hashCode * 59) + this.related_docs.GetHashCode();
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

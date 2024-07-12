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
    /// Update Vendor Request
    /// </summary>
    [DataContract(Name = "UpdateVendorRequest")]
    public class UpdateVendorRequest : IEquatable<UpdateVendorRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVendorRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateVendorRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVendorRequest" /> class.
        /// </summary>
        /// <param name="status">Specify the status of vendor that should be updated. Possible values: ACTIVE,BLOCKED, DELETED (required).</param>
        /// <param name="name">Specify the name of the vendor to be updated. Name should not have any special character except . / - &amp; (required).</param>
        /// <param name="email">Specify the vendor email ID that should be updated. String in email ID format (Ex:johndoe_1@cashfree.com) should contain @ and dot (.) (required).</param>
        /// <param name="phone">Specify the beneficiaries phone number to be updated. Phone number registered in India (only digits, 8 - 12 characters after excluding +91). (required).</param>
        /// <param name="verifyAccount">Specify if the vendor bank account details should be verified. Possible values: true or false.</param>
        /// <param name="dashboardAccess">Update if the vendor will have dashboard access or not. Possible values are: true or false.</param>
        /// <param name="scheduleOption">Specify the settlement cycle to be updated. View the settlement cycle details from the \&quot;Settlement Cycles Supported\&quot; table.  If no schedule option is configured, the settlement cycle ID \&quot;1\&quot; will be in effect. Select \&quot;8\&quot; or \&quot;9\&quot; if you want to schedule instant vendor settlements. (required).</param>
        /// <param name="bank">Specify the vendor bank account details to be updated..</param>
        /// <param name="upi">Updated beneficiary upi vpa. Alphanumeric, dot (.), hyphen (-), at sign (@), and underscore allowed (100 character limit). Note: underscore and dot (.) gets accepted before and after @, but hyphen (-) is only accepted before @ sign..</param>
        /// <param name="kycDetails">Specify the kyc details that should be updated. (required).</param>
        public UpdateVendorRequest(string status = default(string), string name = default(string), string email = default(string), string phone = default(string), bool? verifyAccount = default(bool?), bool? dashboardAccess = default(bool?), decimal scheduleOption = default(decimal), List<BankDetails>? bank = default(List<BankDetails>?), List<UpiDetails>? upi = default(List<UpiDetails>?), List<KycDetails> kycDetails = default(List<KycDetails>))
        {
            // to ensure "status" is required (not null)
            if (status == null)
            {
                throw new ArgumentNullException("status is a required property for UpdateVendorRequest and cannot be null");
            }
            this.status = status;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for UpdateVendorRequest and cannot be null");
            }
            this.name = name;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for UpdateVendorRequest and cannot be null");
            }
            this.email = email;
            // to ensure "phone" is required (not null)
            if (phone == null)
            {
                throw new ArgumentNullException("phone is a required property for UpdateVendorRequest and cannot be null");
            }
            this.phone = phone;
            this.schedule_option = scheduleOption;
            // to ensure "kycDetails" is required (not null)
            if (kycDetails == null)
            {
                throw new ArgumentNullException("kycDetails is a required property for UpdateVendorRequest and cannot be null");
            }
            this.kyc_details = kycDetails;
            this.verify_account = verifyAccount;
            this.dashboard_access = dashboardAccess;
            this.bank = bank;
            this.upi = upi;
        }

        /// <summary>
        /// Specify the status of vendor that should be updated. Possible values: ACTIVE,BLOCKED, DELETED
        /// </summary>
        /// <value>Specify the status of vendor that should be updated. Possible values: ACTIVE,BLOCKED, DELETED</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public string status { get; set; }

        /// <summary>
        /// Specify the name of the vendor to be updated. Name should not have any special character except . / - &amp;
        /// </summary>
        /// <value>Specify the name of the vendor to be updated. Name should not have any special character except . / - &amp;</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string name { get; set; }

        /// <summary>
        /// Specify the vendor email ID that should be updated. String in email ID format (Ex:johndoe_1@cashfree.com) should contain @ and dot (.)
        /// </summary>
        /// <value>Specify the vendor email ID that should be updated. String in email ID format (Ex:johndoe_1@cashfree.com) should contain @ and dot (.)</value>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string email { get; set; }

        /// <summary>
        /// Specify the beneficiaries phone number to be updated. Phone number registered in India (only digits, 8 - 12 characters after excluding +91).
        /// </summary>
        /// <value>Specify the beneficiaries phone number to be updated. Phone number registered in India (only digits, 8 - 12 characters after excluding +91).</value>
        [DataMember(Name = "phone", IsRequired = true, EmitDefaultValue = true)]
        public string phone { get; set; }

        /// <summary>
        /// Specify if the vendor bank account details should be verified. Possible values: true or false
        /// </summary>
        /// <value>Specify if the vendor bank account details should be verified. Possible values: true or false</value>
        [DataMember(Name = "verify_account", EmitDefaultValue = true)]
        public bool? verify_account { get; set; }

        /// <summary>
        /// Update if the vendor will have dashboard access or not. Possible values are: true or false
        /// </summary>
        /// <value>Update if the vendor will have dashboard access or not. Possible values are: true or false</value>
        [DataMember(Name = "dashboard_access", EmitDefaultValue = true)]
        public bool? dashboard_access { get; set; }

        /// <summary>
        /// Specify the settlement cycle to be updated. View the settlement cycle details from the \&quot;Settlement Cycles Supported\&quot; table.  If no schedule option is configured, the settlement cycle ID \&quot;1\&quot; will be in effect. Select \&quot;8\&quot; or \&quot;9\&quot; if you want to schedule instant vendor settlements.
        /// </summary>
        /// <value>Specify the settlement cycle to be updated. View the settlement cycle details from the \&quot;Settlement Cycles Supported\&quot; table.  If no schedule option is configured, the settlement cycle ID \&quot;1\&quot; will be in effect. Select \&quot;8\&quot; or \&quot;9\&quot; if you want to schedule instant vendor settlements.</value>
        [DataMember(Name = "schedule_option", IsRequired = true, EmitDefaultValue = true)]
        public decimal schedule_option { get; set; }

        /// <summary>
        /// Specify the vendor bank account details to be updated.
        /// </summary>
        /// <value>Specify the vendor bank account details to be updated.</value>
        [DataMember(Name = "bank", EmitDefaultValue = false)]
        public List<BankDetails>? bank { get; set; }

        /// <summary>
        /// Updated beneficiary upi vpa. Alphanumeric, dot (.), hyphen (-), at sign (@), and underscore allowed (100 character limit). Note: underscore and dot (.) gets accepted before and after @, but hyphen (-) is only accepted before @ sign.
        /// </summary>
        /// <value>Updated beneficiary upi vpa. Alphanumeric, dot (.), hyphen (-), at sign (@), and underscore allowed (100 character limit). Note: underscore and dot (.) gets accepted before and after @, but hyphen (-) is only accepted before @ sign.</value>
        [DataMember(Name = "upi", EmitDefaultValue = false)]
        public List<UpiDetails>? upi { get; set; }

        /// <summary>
        /// Specify the kyc details that should be updated.
        /// </summary>
        /// <value>Specify the kyc details that should be updated.</value>
        [DataMember(Name = "kyc_details", IsRequired = true, EmitDefaultValue = true)]
        public List<KycDetails> kyc_details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateVendorRequest {\n");
            sb.Append("  status: ").Append(status).Append("\n");
            sb.Append("  name: ").Append(name).Append("\n");
            sb.Append("  email: ").Append(email).Append("\n");
            sb.Append("  phone: ").Append(phone).Append("\n");
            sb.Append("  verify_account: ").Append(verify_account).Append("\n");
            sb.Append("  dashboard_access: ").Append(dashboard_access).Append("\n");
            sb.Append("  schedule_option: ").Append(schedule_option).Append("\n");
            sb.Append("  bank: ").Append(bank).Append("\n");
            sb.Append("  upi: ").Append(upi).Append("\n");
            sb.Append("  kyc_details: ").Append(kyc_details).Append("\n");
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
            return this.Equals(input as UpdateVendorRequest);
        }

        /// <summary>
        /// Returns true if UpdateVendorRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateVendorRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateVendorRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.status == input.status ||
                    (this.status != null &&
                    this.status.Equals(input.status))
                ) && 
                (
                    this.name == input.name ||
                    (this.name != null &&
                    this.name.Equals(input.name))
                ) && 
                (
                    this.email == input.email ||
                    (this.email != null &&
                    this.email.Equals(input.email))
                ) && 
                (
                    this.phone == input.phone ||
                    (this.phone != null &&
                    this.phone.Equals(input.phone))
                ) && 
                (
                    this.verify_account == input.verify_account ||
                    this.verify_account.Equals(input.verify_account)
                ) && 
                (
                    this.dashboard_access == input.dashboard_access ||
                    this.dashboard_access.Equals(input.dashboard_access)
                ) && 
                (
                    this.schedule_option == input.schedule_option ||
                    this.schedule_option.Equals(input.schedule_option)
                ) && 
                (
                    this.bank == input.bank ||
                    this.bank != null &&
                    input.bank != null &&
                    this.bank.SequenceEqual(input.bank)
                ) && 
                (
                    this.upi == input.upi ||
                    this.upi != null &&
                    input.upi != null &&
                    this.upi.SequenceEqual(input.upi)
                ) && 
                (
                    this.kyc_details == input.kyc_details ||
                    this.kyc_details != null &&
                    input.kyc_details != null &&
                    this.kyc_details.SequenceEqual(input.kyc_details)
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringstatus) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringstatus);
            if (deserializedJsonString.ContainsKey("status")) {
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
                if (this.status != null)
                {
                    hashCode = (hashCode * 59) + this.status.GetHashCode();
                }
                if (this.name != null)
                {
                    hashCode = (hashCode * 59) + this.name.GetHashCode();
                }
                if (this.email != null)
                {
                    hashCode = (hashCode * 59) + this.email.GetHashCode();
                }
                if (this.phone != null)
                {
                    hashCode = (hashCode * 59) + this.phone.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.verify_account.GetHashCode();
                hashCode = (hashCode * 59) + this.dashboard_access.GetHashCode();
                hashCode = (hashCode * 59) + this.schedule_option.GetHashCode();
                if (this.bank != null)
                {
                    hashCode = (hashCode * 59) + this.bank.GetHashCode();
                }
                if (this.upi != null)
                {
                    hashCode = (hashCode * 59) + this.upi.GetHashCode();
                }
                if (this.kyc_details != null)
                {
                    hashCode = (hashCode * 59) + this.kyc_details.GetHashCode();
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

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
    /// payment method pnach.
    /// </summary>
    [DataContract(Name = "CreateSubscriptionPaymentRequestPnach")]
    public class CreateSubscriptionPaymentRequestPnach : IEquatable<CreateSubscriptionPaymentRequestPnach>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionPaymentRequestPnach" /> class.
        /// </summary>
        /// <param name="accountBankCode">Account bank code.</param>
        /// <param name="accountHolderName">Account holder name.</param>
        /// <param name="accountIfsc">Account IFSC.</param>
        /// <param name="accountNumber">Account number.</param>
        /// <param name="accountType">Account type.</param>
        /// <param name="channel">Channel. can be post.</param>
        /// <param name="mandateCreationDate">Mandate creation date.</param>
        /// <param name="mandateStartDate">Mandate start date.</param>
        public CreateSubscriptionPaymentRequestPnach(string? accountBankCode = default(string?), string? accountHolderName = default(string?), string? accountIfsc = default(string?), string? accountNumber = default(string?), string? accountType = default(string?), string? channel = default(string?), string? mandateCreationDate = default(string?), string? mandateStartDate = default(string?))
        {
            this.account_bank_code = accountBankCode;
            this.account_holder_name = accountHolderName;
            this.account_ifsc = accountIfsc;
            this.account_number = accountNumber;
            this.account_type = accountType;
            this.channel = channel;
            this.mandate_creation_date = mandateCreationDate;
            this.mandate_start_date = mandateStartDate;
        }

        /// <summary>
        /// Account bank code
        /// </summary>
        /// <value>Account bank code</value>
        [DataMember(Name = "account_bank_code", EmitDefaultValue = false)]
        public string? account_bank_code { get; set; }

        /// <summary>
        /// Account holder name
        /// </summary>
        /// <value>Account holder name</value>
        [DataMember(Name = "account_holder_name", EmitDefaultValue = false)]
        public string? account_holder_name { get; set; }

        /// <summary>
        /// Account IFSC
        /// </summary>
        /// <value>Account IFSC</value>
        [DataMember(Name = "account_ifsc", EmitDefaultValue = false)]
        public string? account_ifsc { get; set; }

        /// <summary>
        /// Account number
        /// </summary>
        /// <value>Account number</value>
        [DataMember(Name = "account_number", EmitDefaultValue = false)]
        public string? account_number { get; set; }

        /// <summary>
        /// Account type
        /// </summary>
        /// <value>Account type</value>
        [DataMember(Name = "account_type", EmitDefaultValue = false)]
        public string? account_type { get; set; }

        /// <summary>
        /// Channel. can be post
        /// </summary>
        /// <value>Channel. can be post</value>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public string? channel { get; set; }

        /// <summary>
        /// Mandate creation date
        /// </summary>
        /// <value>Mandate creation date</value>
        [DataMember(Name = "mandate_creation_date", EmitDefaultValue = false)]
        public string? mandate_creation_date { get; set; }

        /// <summary>
        /// Mandate start date
        /// </summary>
        /// <value>Mandate start date</value>
        [DataMember(Name = "mandate_start_date", EmitDefaultValue = false)]
        public string? mandate_start_date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSubscriptionPaymentRequestPnach {\n");
            sb.Append("  account_bank_code: ").Append(account_bank_code).Append("\n");
            sb.Append("  account_holder_name: ").Append(account_holder_name).Append("\n");
            sb.Append("  account_ifsc: ").Append(account_ifsc).Append("\n");
            sb.Append("  account_number: ").Append(account_number).Append("\n");
            sb.Append("  account_type: ").Append(account_type).Append("\n");
            sb.Append("  channel: ").Append(channel).Append("\n");
            sb.Append("  mandate_creation_date: ").Append(mandate_creation_date).Append("\n");
            sb.Append("  mandate_start_date: ").Append(mandate_start_date).Append("\n");
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
            return this.Equals(input as CreateSubscriptionPaymentRequestPnach);
        }

        /// <summary>
        /// Returns true if CreateSubscriptionPaymentRequestPnach instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSubscriptionPaymentRequestPnach to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSubscriptionPaymentRequestPnach input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.account_bank_code == input.account_bank_code ||
                    (this.account_bank_code != null &&
                    this.account_bank_code.Equals(input.account_bank_code))
                ) && 
                (
                    this.account_holder_name == input.account_holder_name ||
                    (this.account_holder_name != null &&
                    this.account_holder_name.Equals(input.account_holder_name))
                ) && 
                (
                    this.account_ifsc == input.account_ifsc ||
                    (this.account_ifsc != null &&
                    this.account_ifsc.Equals(input.account_ifsc))
                ) && 
                (
                    this.account_number == input.account_number ||
                    (this.account_number != null &&
                    this.account_number.Equals(input.account_number))
                ) && 
                (
                    this.account_type == input.account_type ||
                    (this.account_type != null &&
                    this.account_type.Equals(input.account_type))
                ) && 
                (
                    this.channel == input.channel ||
                    (this.channel != null &&
                    this.channel.Equals(input.channel))
                ) && 
                (
                    this.mandate_creation_date == input.mandate_creation_date ||
                    (this.mandate_creation_date != null &&
                    this.mandate_creation_date.Equals(input.mandate_creation_date))
                ) && 
                (
                    this.mandate_start_date == input.mandate_start_date ||
                    (this.mandate_start_date != null &&
                    this.mandate_start_date.Equals(input.mandate_start_date))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringaccount_bank_code) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringaccount_bank_code);
            if (deserializedJsonString.ContainsKey("account_bank_code")) {
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
                if (this.account_bank_code != null)
                {
                    hashCode = (hashCode * 59) + this.account_bank_code.GetHashCode();
                }
                if (this.account_holder_name != null)
                {
                    hashCode = (hashCode * 59) + this.account_holder_name.GetHashCode();
                }
                if (this.account_ifsc != null)
                {
                    hashCode = (hashCode * 59) + this.account_ifsc.GetHashCode();
                }
                if (this.account_number != null)
                {
                    hashCode = (hashCode * 59) + this.account_number.GetHashCode();
                }
                if (this.account_type != null)
                {
                    hashCode = (hashCode * 59) + this.account_type.GetHashCode();
                }
                if (this.channel != null)
                {
                    hashCode = (hashCode * 59) + this.channel.GetHashCode();
                }
                if (this.mandate_creation_date != null)
                {
                    hashCode = (hashCode * 59) + this.mandate_creation_date.GetHashCode();
                }
                if (this.mandate_start_date != null)
                {
                    hashCode = (hashCode * 59) + this.mandate_start_date.GetHashCode();
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

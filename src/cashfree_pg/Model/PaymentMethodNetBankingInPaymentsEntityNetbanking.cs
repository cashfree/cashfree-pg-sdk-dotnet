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
    /// PaymentMethodNetBankingInPaymentsEntityNetbanking
    /// </summary>
    [DataContract(Name = "PaymentMethodNetBankingInPaymentsEntity_netbanking")]
    public class PaymentMethodNetBankingInPaymentsEntityNetbanking : IEquatable<PaymentMethodNetBankingInPaymentsEntityNetbanking>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodNetBankingInPaymentsEntityNetbanking" /> class.
        /// </summary>
        /// <param name="channel">channel.</param>
        /// <param name="netbankingBankCode">netbankingBankCode.</param>
        /// <param name="netbankingBankName">netbankingBankName.</param>
        /// <param name="netbankingIfsc">netbankingIfsc.</param>
        /// <param name="netbankingAccountNumber">netbankingAccountNumber.</param>
        public PaymentMethodNetBankingInPaymentsEntityNetbanking(string? channel = default(string?), int? netbankingBankCode = default(int?), string? netbankingBankName = default(string?), string? netbankingIfsc = default(string?), string? netbankingAccountNumber = default(string?))
        {
            this.channel = channel;
            this.netbanking_bank_code = netbankingBankCode;
            this.netbanking_bank_name = netbankingBankName;
            this.netbanking_ifsc = netbankingIfsc;
            this.netbanking_account_number = netbankingAccountNumber;
        }

        /// <summary>
        /// Gets or Sets channel
        /// </summary>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public string? channel { get; set; }

        /// <summary>
        /// Gets or Sets netbanking_bank_code
        /// </summary>
        [DataMember(Name = "netbanking_bank_code", EmitDefaultValue = false)]
        public int? netbanking_bank_code { get; set; }

        /// <summary>
        /// Gets or Sets netbanking_bank_name
        /// </summary>
        [DataMember(Name = "netbanking_bank_name", EmitDefaultValue = false)]
        public string? netbanking_bank_name { get; set; }

        /// <summary>
        /// Gets or Sets netbanking_ifsc
        /// </summary>
        [DataMember(Name = "netbanking_ifsc", EmitDefaultValue = false)]
        public string? netbanking_ifsc { get; set; }

        /// <summary>
        /// Gets or Sets netbanking_account_number
        /// </summary>
        [DataMember(Name = "netbanking_account_number", EmitDefaultValue = false)]
        public string? netbanking_account_number { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodNetBankingInPaymentsEntityNetbanking {\n");
            sb.Append("  channel: ").Append(channel).Append("\n");
            sb.Append("  netbanking_bank_code: ").Append(netbanking_bank_code).Append("\n");
            sb.Append("  netbanking_bank_name: ").Append(netbanking_bank_name).Append("\n");
            sb.Append("  netbanking_ifsc: ").Append(netbanking_ifsc).Append("\n");
            sb.Append("  netbanking_account_number: ").Append(netbanking_account_number).Append("\n");
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
            return this.Equals(input as PaymentMethodNetBankingInPaymentsEntityNetbanking);
        }

        /// <summary>
        /// Returns true if PaymentMethodNetBankingInPaymentsEntityNetbanking instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodNetBankingInPaymentsEntityNetbanking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodNetBankingInPaymentsEntityNetbanking input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.channel == input.channel ||
                    (this.channel != null &&
                    this.channel.Equals(input.channel))
                ) && 
                (
                    this.netbanking_bank_code == input.netbanking_bank_code ||
                    this.netbanking_bank_code.Equals(input.netbanking_bank_code)
                ) && 
                (
                    this.netbanking_bank_name == input.netbanking_bank_name ||
                    (this.netbanking_bank_name != null &&
                    this.netbanking_bank_name.Equals(input.netbanking_bank_name))
                ) && 
                (
                    this.netbanking_ifsc == input.netbanking_ifsc ||
                    (this.netbanking_ifsc != null &&
                    this.netbanking_ifsc.Equals(input.netbanking_ifsc))
                ) && 
                (
                    this.netbanking_account_number == input.netbanking_account_number ||
                    (this.netbanking_account_number != null &&
                    this.netbanking_account_number.Equals(input.netbanking_account_number))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringchannel) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringchannel);
            if (deserializedJsonString.ContainsKey("channel")) {
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
                if (this.channel != null)
                {
                    hashCode = (hashCode * 59) + this.channel.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.netbanking_bank_code.GetHashCode();
                if (this.netbanking_bank_name != null)
                {
                    hashCode = (hashCode * 59) + this.netbanking_bank_name.GetHashCode();
                }
                if (this.netbanking_ifsc != null)
                {
                    hashCode = (hashCode * 59) + this.netbanking_ifsc.GetHashCode();
                }
                if (this.netbanking_account_number != null)
                {
                    hashCode = (hashCode * 59) + this.netbanking_account_number.GetHashCode();
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

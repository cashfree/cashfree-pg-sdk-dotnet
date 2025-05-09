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
    /// PaymentMethodUPIInPaymentsEntityUpi
    /// </summary>
    [DataContract(Name = "PaymentMethodUPIInPaymentsEntity_upi")]
    public class PaymentMethodUPIInPaymentsEntityUpi : IEquatable<PaymentMethodUPIInPaymentsEntityUpi>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodUPIInPaymentsEntityUpi" /> class.
        /// </summary>
        /// <param name="channel">channel.</param>
        /// <param name="upiId">upiId.</param>
        /// <param name="upiPayerIfsc">upiPayerIfsc.</param>
        /// <param name="upiPayerAccountNumber">upiPayerAccountNumber.</param>
        public PaymentMethodUPIInPaymentsEntityUpi(string? channel = default(string?), string? upiId = default(string?), string? upiPayerIfsc = default(string?), string? upiPayerAccountNumber = default(string?))
        {
            this.channel = channel;
            this.upi_id = upiId;
            this.upi_payer_ifsc = upiPayerIfsc;
            this.upi_payer_account_number = upiPayerAccountNumber;
        }

        /// <summary>
        /// Gets or Sets channel
        /// </summary>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public string? channel { get; set; }

        /// <summary>
        /// Gets or Sets upi_id
        /// </summary>
        [DataMember(Name = "upi_id", EmitDefaultValue = false)]
        public string? upi_id { get; set; }

        /// <summary>
        /// Gets or Sets upi_payer_ifsc
        /// </summary>
        [DataMember(Name = "upi_payer_ifsc", EmitDefaultValue = false)]
        public string? upi_payer_ifsc { get; set; }

        /// <summary>
        /// Gets or Sets upi_payer_account_number
        /// </summary>
        [DataMember(Name = "upi_payer_account_number", EmitDefaultValue = false)]
        public string? upi_payer_account_number { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodUPIInPaymentsEntityUpi {\n");
            sb.Append("  channel: ").Append(channel).Append("\n");
            sb.Append("  upi_id: ").Append(upi_id).Append("\n");
            sb.Append("  upi_payer_ifsc: ").Append(upi_payer_ifsc).Append("\n");
            sb.Append("  upi_payer_account_number: ").Append(upi_payer_account_number).Append("\n");
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
            return this.Equals(input as PaymentMethodUPIInPaymentsEntityUpi);
        }

        /// <summary>
        /// Returns true if PaymentMethodUPIInPaymentsEntityUpi instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodUPIInPaymentsEntityUpi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodUPIInPaymentsEntityUpi input)
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
                    this.upi_id == input.upi_id ||
                    (this.upi_id != null &&
                    this.upi_id.Equals(input.upi_id))
                ) && 
                (
                    this.upi_payer_ifsc == input.upi_payer_ifsc ||
                    (this.upi_payer_ifsc != null &&
                    this.upi_payer_ifsc.Equals(input.upi_payer_ifsc))
                ) && 
                (
                    this.upi_payer_account_number == input.upi_payer_account_number ||
                    (this.upi_payer_account_number != null &&
                    this.upi_payer_account_number.Equals(input.upi_payer_account_number))
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
                if (this.upi_id != null)
                {
                    hashCode = (hashCode * 59) + this.upi_id.GetHashCode();
                }
                if (this.upi_payer_ifsc != null)
                {
                    hashCode = (hashCode * 59) + this.upi_payer_ifsc.GetHashCode();
                }
                if (this.upi_payer_account_number != null)
                {
                    hashCode = (hashCode * 59) + this.upi_payer_account_number.GetHashCode();
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

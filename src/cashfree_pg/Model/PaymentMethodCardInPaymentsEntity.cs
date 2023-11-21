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
    /// payment method card object in payment entity
    /// </summary>
    [DataContract(Name = "PaymentMethodCardInPaymentsEntity")]
    public class PaymentMethodCardInPaymentsEntity : IEquatable<PaymentMethodCardInPaymentsEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCardInPaymentsEntity" /> class.
        /// </summary>
        /// <param name="channel">channel.</param>
        /// <param name="cardNumber">cardNumber.</param>
        /// <param name="cardNetwork">cardNetwork.</param>
        /// <param name="cardType">cardType.</param>
        /// <param name="cardCountry">cardCountry.</param>
        /// <param name="cardBankName">cardBankName.</param>
        /// <param name="cardNetworkReferenceId">cardNetworkReferenceId.</param>
        public PaymentMethodCardInPaymentsEntity(string channel = default(string), string cardNumber = default(string), string cardNetwork = default(string), string cardType = default(string), string cardCountry = default(string), string cardBankName = default(string), string cardNetworkReferenceId = default(string))
        {
            this.channel = channel;
            this.card_number = cardNumber;
            this.card_network = cardNetwork;
            this.card_type = cardType;
            this.card_country = cardCountry;
            this.card_bank_name = cardBankName;
            this.card_network_reference_id = cardNetworkReferenceId;
        }

        /// <summary>
        /// Gets or Sets channel
        /// </summary>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public string channel { get; set; }

        /// <summary>
        /// Gets or Sets card_number
        /// </summary>
        [DataMember(Name = "card_number", EmitDefaultValue = false)]
        public string card_number { get; set; }

        /// <summary>
        /// Gets or Sets card_network
        /// </summary>
        [DataMember(Name = "card_network", EmitDefaultValue = false)]
        public string card_network { get; set; }

        /// <summary>
        /// Gets or Sets card_type
        /// </summary>
        [DataMember(Name = "card_type", EmitDefaultValue = false)]
        public string card_type { get; set; }

        /// <summary>
        /// Gets or Sets card_country
        /// </summary>
        [DataMember(Name = "card_country", EmitDefaultValue = false)]
        public string card_country { get; set; }

        /// <summary>
        /// Gets or Sets card_bank_name
        /// </summary>
        [DataMember(Name = "card_bank_name", EmitDefaultValue = false)]
        public string card_bank_name { get; set; }

        /// <summary>
        /// Gets or Sets card_network_reference_id
        /// </summary>
        [DataMember(Name = "card_network_reference_id", EmitDefaultValue = false)]
        public string card_network_reference_id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodCardInPaymentsEntity {\n");
            sb.Append("  channel: ").Append(channel).Append("\n");
            sb.Append("  card_number: ").Append(card_number).Append("\n");
            sb.Append("  card_network: ").Append(card_network).Append("\n");
            sb.Append("  card_type: ").Append(card_type).Append("\n");
            sb.Append("  card_country: ").Append(card_country).Append("\n");
            sb.Append("  card_bank_name: ").Append(card_bank_name).Append("\n");
            sb.Append("  card_network_reference_id: ").Append(card_network_reference_id).Append("\n");
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
            return this.Equals(input as PaymentMethodCardInPaymentsEntity);
        }

        /// <summary>
        /// Returns true if PaymentMethodCardInPaymentsEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodCardInPaymentsEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodCardInPaymentsEntity input)
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
                    this.card_number == input.card_number ||
                    (this.card_number != null &&
                    this.card_number.Equals(input.card_number))
                ) && 
                (
                    this.card_network == input.card_network ||
                    (this.card_network != null &&
                    this.card_network.Equals(input.card_network))
                ) && 
                (
                    this.card_type == input.card_type ||
                    (this.card_type != null &&
                    this.card_type.Equals(input.card_type))
                ) && 
                (
                    this.card_country == input.card_country ||
                    (this.card_country != null &&
                    this.card_country.Equals(input.card_country))
                ) && 
                (
                    this.card_bank_name == input.card_bank_name ||
                    (this.card_bank_name != null &&
                    this.card_bank_name.Equals(input.card_bank_name))
                ) && 
                (
                    this.card_network_reference_id == input.card_network_reference_id ||
                    (this.card_network_reference_id != null &&
                    this.card_network_reference_id.Equals(input.card_network_reference_id))
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
                if (this.channel != null)
                {
                    hashCode = (hashCode * 59) + this.channel.GetHashCode();
                }
                if (this.card_number != null)
                {
                    hashCode = (hashCode * 59) + this.card_number.GetHashCode();
                }
                if (this.card_network != null)
                {
                    hashCode = (hashCode * 59) + this.card_network.GetHashCode();
                }
                if (this.card_type != null)
                {
                    hashCode = (hashCode * 59) + this.card_type.GetHashCode();
                }
                if (this.card_country != null)
                {
                    hashCode = (hashCode * 59) + this.card_country.GetHashCode();
                }
                if (this.card_bank_name != null)
                {
                    hashCode = (hashCode * 59) + this.card_bank_name.GetHashCode();
                }
                if (this.card_network_reference_id != null)
                {
                    hashCode = (hashCode * 59) + this.card_network_reference_id.GetHashCode();
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

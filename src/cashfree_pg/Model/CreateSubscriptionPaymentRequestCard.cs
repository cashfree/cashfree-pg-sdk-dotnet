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
    /// payment method card.
    /// </summary>
    [DataContract(Name = "CreateSubscriptionPaymentRequestCard")]
    public class CreateSubscriptionPaymentRequestCard : IEquatable<CreateSubscriptionPaymentRequestCard>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionPaymentRequestCard" /> class.
        /// </summary>
        /// <param name="channel">Channel. can be link.</param>
        /// <param name="cardNumber">Card number.</param>
        /// <param name="cardHolderName">Card holder name.</param>
        /// <param name="cardExpiryMm">Card expiry month.</param>
        /// <param name="cardExpiryYy">Card expiry year.</param>
        /// <param name="cardCvv">Card CVV.</param>
        /// <param name="cardNetwork">Card network.</param>
        /// <param name="cardType">Card type.</param>
        public CreateSubscriptionPaymentRequestCard(string? channel = default(string?), string? cardNumber = default(string?), string? cardHolderName = default(string?), string? cardExpiryMm = default(string?), string? cardExpiryYy = default(string?), string? cardCvv = default(string?), string? cardNetwork = default(string?), string? cardType = default(string?))
        {
            this.channel = channel;
            this.card_number = cardNumber;
            this.card_holder_name = cardHolderName;
            this.card_expiry_mm = cardExpiryMm;
            this.card_expiry_yy = cardExpiryYy;
            this.card_cvv = cardCvv;
            this.card_network = cardNetwork;
            this.card_type = cardType;
        }

        /// <summary>
        /// Channel. can be link
        /// </summary>
        /// <value>Channel. can be link</value>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public string? channel { get; set; }

        /// <summary>
        /// Card number
        /// </summary>
        /// <value>Card number</value>
        [DataMember(Name = "card_number", EmitDefaultValue = false)]
        public string? card_number { get; set; }

        /// <summary>
        /// Card holder name
        /// </summary>
        /// <value>Card holder name</value>
        [DataMember(Name = "card_holder_name", EmitDefaultValue = false)]
        public string? card_holder_name { get; set; }

        /// <summary>
        /// Card expiry month
        /// </summary>
        /// <value>Card expiry month</value>
        [DataMember(Name = "card_expiry_mm", EmitDefaultValue = false)]
        public string? card_expiry_mm { get; set; }

        /// <summary>
        /// Card expiry year
        /// </summary>
        /// <value>Card expiry year</value>
        [DataMember(Name = "card_expiry_yy", EmitDefaultValue = false)]
        public string? card_expiry_yy { get; set; }

        /// <summary>
        /// Card CVV
        /// </summary>
        /// <value>Card CVV</value>
        [DataMember(Name = "card_cvv", EmitDefaultValue = false)]
        public string? card_cvv { get; set; }

        /// <summary>
        /// Card network
        /// </summary>
        /// <value>Card network</value>
        [DataMember(Name = "card_network", EmitDefaultValue = false)]
        public string? card_network { get; set; }

        /// <summary>
        /// Card type
        /// </summary>
        /// <value>Card type</value>
        [DataMember(Name = "card_type", EmitDefaultValue = false)]
        public string? card_type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSubscriptionPaymentRequestCard {\n");
            sb.Append("  channel: ").Append(channel).Append("\n");
            sb.Append("  card_number: ").Append(card_number).Append("\n");
            sb.Append("  card_holder_name: ").Append(card_holder_name).Append("\n");
            sb.Append("  card_expiry_mm: ").Append(card_expiry_mm).Append("\n");
            sb.Append("  card_expiry_yy: ").Append(card_expiry_yy).Append("\n");
            sb.Append("  card_cvv: ").Append(card_cvv).Append("\n");
            sb.Append("  card_network: ").Append(card_network).Append("\n");
            sb.Append("  card_type: ").Append(card_type).Append("\n");
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
            return this.Equals(input as CreateSubscriptionPaymentRequestCard);
        }

        /// <summary>
        /// Returns true if CreateSubscriptionPaymentRequestCard instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSubscriptionPaymentRequestCard to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSubscriptionPaymentRequestCard input)
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
                    this.card_holder_name == input.card_holder_name ||
                    (this.card_holder_name != null &&
                    this.card_holder_name.Equals(input.card_holder_name))
                ) && 
                (
                    this.card_expiry_mm == input.card_expiry_mm ||
                    (this.card_expiry_mm != null &&
                    this.card_expiry_mm.Equals(input.card_expiry_mm))
                ) && 
                (
                    this.card_expiry_yy == input.card_expiry_yy ||
                    (this.card_expiry_yy != null &&
                    this.card_expiry_yy.Equals(input.card_expiry_yy))
                ) && 
                (
                    this.card_cvv == input.card_cvv ||
                    (this.card_cvv != null &&
                    this.card_cvv.Equals(input.card_cvv))
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
                if (this.card_number != null)
                {
                    hashCode = (hashCode * 59) + this.card_number.GetHashCode();
                }
                if (this.card_holder_name != null)
                {
                    hashCode = (hashCode * 59) + this.card_holder_name.GetHashCode();
                }
                if (this.card_expiry_mm != null)
                {
                    hashCode = (hashCode * 59) + this.card_expiry_mm.GetHashCode();
                }
                if (this.card_expiry_yy != null)
                {
                    hashCode = (hashCode * 59) + this.card_expiry_yy.GetHashCode();
                }
                if (this.card_cvv != null)
                {
                    hashCode = (hashCode * 59) + this.card_cvv.GetHashCode();
                }
                if (this.card_network != null)
                {
                    hashCode = (hashCode * 59) + this.card_network.GetHashCode();
                }
                if (this.card_type != null)
                {
                    hashCode = (hashCode * 59) + this.card_type.GetHashCode();
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

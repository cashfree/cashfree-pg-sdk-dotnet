/*
 * New Payment Gateway APIs
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2022-01-01
 * Contact: nextgenapi@cashfree.com
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
using OpenAPIDateConverter = cashfreepg.Client.OpenAPIDateConverter;

namespace cashfreepg.Model
{
    /// <summary>
    /// CFCardEMI
    /// </summary>
    [DataContract(Name = "CFCardEMI")]
    public partial class CFCardEMI : IEquatable<CFCardEMI>, IValidatableObject
    {
        /// <summary>
        /// The channel for card payments will always be \&quot;link\&quot;
        /// </summary>
        /// <value>The channel for card payments will always be \&quot;link\&quot;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChannelEnum
        {
            /// <summary>
            /// Enum Link for value: link
            /// </summary>
            [EnumMember(Value = "link")]
            Link = 1

        }


        /// <summary>
        /// The channel for card payments will always be \&quot;link\&quot;
        /// </summary>
        /// <value>The channel for card payments will always be \&quot;link\&quot;</value>
        [DataMember(Name = "channel", IsRequired = true, EmitDefaultValue = false)]
        public string Channel { get; set; }
        /// <summary>
        /// Card bank name, required for EMI payments. This is the bank user has selected for EMI. One of [\&quot;Kotak\&quot;, \&quot;ICICI\&quot;, \&quot;RBL\&quot;, \&quot;BOB\&quot;, \&quot;Standard Chartered\&quot;, \&quot;HDFC\&quot;]
        /// </summary>
        /// <value>Card bank name, required for EMI payments. This is the bank user has selected for EMI. One of [\&quot;Kotak\&quot;, \&quot;ICICI\&quot;, \&quot;RBL\&quot;, \&quot;BOB\&quot;, \&quot;Standard Chartered\&quot;, \&quot;HDFC\&quot;]</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CardBankNameEnum
        {
            /// <summary>
            /// Enum Kotak for value: Kotak
            /// </summary>
            [EnumMember(Value = "Kotak")]
            Kotak = 1,

            /// <summary>
            /// Enum ICICI for value: ICICI
            /// </summary>
            [EnumMember(Value = "ICICI")]
            ICICI = 2,

            /// <summary>
            /// Enum RBL for value: RBL
            /// </summary>
            [EnumMember(Value = "RBL")]
            RBL = 3,

            /// <summary>
            /// Enum BOB for value: BOB
            /// </summary>
            [EnumMember(Value = "BOB")]
            BOB = 4,

            /// <summary>
            /// Enum StandardChartered for value: Standard Chartered
            /// </summary>
            [EnumMember(Value = "Standard Chartered")]
            StandardChartered = 5,

            /// <summary>
            /// Enum HDFC for value: HDFC
            /// </summary>
            [EnumMember(Value = "HDFC")]
            HDFC = 6

        }


        /// <summary>
        /// Card bank name, required for EMI payments. This is the bank user has selected for EMI. One of [\&quot;Kotak\&quot;, \&quot;ICICI\&quot;, \&quot;RBL\&quot;, \&quot;BOB\&quot;, \&quot;Standard Chartered\&quot;, \&quot;HDFC\&quot;]
        /// </summary>
        /// <value>Card bank name, required for EMI payments. This is the bank user has selected for EMI. One of [\&quot;Kotak\&quot;, \&quot;ICICI\&quot;, \&quot;RBL\&quot;, \&quot;BOB\&quot;, \&quot;Standard Chartered\&quot;, \&quot;HDFC\&quot;]</value>
        [DataMember(Name = "card_bank_name", IsRequired = true, EmitDefaultValue = false)]
        public string? CardBankName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CFCardEMI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CFCardEMI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CFCardEMI" /> class.
        /// </summary>
        /// <param name="channel">The channel for card payments will always be \&quot;link\&quot; (required) (default to ChannelEnum.Link).</param>
        /// <param name="cardNumber">Customer card number. (required).</param>
        /// <param name="cardHolderName">Customer name mentioned on the card..</param>
        /// <param name="cardExpiryMm">Card expiry month. (required).</param>
        /// <param name="cardExpiryYy">Card expiry year. (required).</param>
        /// <param name="cardCvv">CVV mentioned on the card. (required).</param>
        /// <param name="cardAlias">Card alias as returned by Cashfree Vault API.</param>
        /// <param name="cardBankName">Card bank name, required for EMI payments. This is the bank user has selected for EMI. One of [\&quot;Kotak\&quot;, \&quot;ICICI\&quot;, \&quot;RBL\&quot;, \&quot;BOB\&quot;, \&quot;Standard Chartered\&quot;, \&quot;HDFC\&quot;] (required).</param>
        /// <param name="emiTenure">EMI tenure selected by the user (required).</param>
        public CFCardEMI(string channel = "link", string? cardNumber = default(string?), string? cardHolderName = default(string?), string? cardExpiryMm = default(string?), string? cardExpiryYy = default(string?), string? cardCvv = default(string?), string? cardAlias = default(string?), string? cardBankName = default(string?), int? emiTenure = default(int?))
        {
            this.Channel = channel;
            // to ensure "cardNumber" is required (not null)
            if (cardNumber == null) {
                throw new ArgumentNullException("cardNumber is a required property for CFCardEMI and cannot be null");
            }
            this.CardNumber = cardNumber;
            // to ensure "cardExpiryMm" is required (not null)
            if (cardExpiryMm == null) {
                throw new ArgumentNullException("cardExpiryMm is a required property for CFCardEMI and cannot be null");
            }
            this.CardExpiryMm = cardExpiryMm;
            // to ensure "cardExpiryYy" is required (not null)
            if (cardExpiryYy == null) {
                throw new ArgumentNullException("cardExpiryYy is a required property for CFCardEMI and cannot be null");
            }
            this.CardExpiryYy = cardExpiryYy;
            // to ensure "cardCvv" is required (not null)
            if (cardCvv == null) {
                throw new ArgumentNullException("cardCvv is a required property for CFCardEMI and cannot be null");
            }
            this.CardCvv = cardCvv;
            if (cardBankName == null) {
                throw new ArgumentNullException("CardBankName is a required property for CFCardEMI and cannot be null");
            }
            this.CardBankName = cardBankName;
            if (emiTenure == null) {
                throw new ArgumentNullException("EmiTenure is a required property for CFCardEMI and cannot be null");
            }
            this.EmiTenure = emiTenure;
            this.CardHolderName = cardHolderName;
            this.CardAlias = cardAlias;
        }

        /// <summary>
        /// Customer card number.
        /// </summary>
        /// <value>Customer card number.</value>
        [DataMember(Name = "card_number", IsRequired = true, EmitDefaultValue = false)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// Customer name mentioned on the card.
        /// </summary>
        /// <value>Customer name mentioned on the card.</value>
        [DataMember(Name = "card_holder_name", EmitDefaultValue = false)]
        public string? CardHolderName { get; set; }

        /// <summary>
        /// Card expiry month.
        /// </summary>
        /// <value>Card expiry month.</value>
        [DataMember(Name = "card_expiry_mm", IsRequired = true, EmitDefaultValue = false)]
        public string? CardExpiryMm { get; set; }

        /// <summary>
        /// Card expiry year.
        /// </summary>
        /// <value>Card expiry year.</value>
        [DataMember(Name = "card_expiry_yy", IsRequired = true, EmitDefaultValue = false)]
        public string? CardExpiryYy { get; set; }

        /// <summary>
        /// CVV mentioned on the card.
        /// </summary>
        /// <value>CVV mentioned on the card.</value>
        [DataMember(Name = "card_cvv", IsRequired = true, EmitDefaultValue = false)]
        public string? CardCvv { get; set; }

        /// <summary>
        /// Card alias as returned by Cashfree Vault API
        /// </summary>
        /// <value>Card alias as returned by Cashfree Vault API</value>
        [DataMember(Name = "card_alias", EmitDefaultValue = false)]
        public string? CardAlias { get; set; }

        /// <summary>
        /// EMI tenure selected by the user
        /// </summary>
        /// <value>EMI tenure selected by the user</value>
        [DataMember(Name = "emi_tenure", IsRequired = true, EmitDefaultValue = false)]
        public int? EmiTenure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CFCardEMI {\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  CardHolderName: ").Append(CardHolderName).Append("\n");
            sb.Append("  CardExpiryMm: ").Append(CardExpiryMm).Append("\n");
            sb.Append("  CardExpiryYy: ").Append(CardExpiryYy).Append("\n");
            sb.Append("  CardCvv: ").Append(CardCvv).Append("\n");
            sb.Append("  CardAlias: ").Append(CardAlias).Append("\n");
            sb.Append("  CardBankName: ").Append(CardBankName).Append("\n");
            sb.Append("  EmiTenure: ").Append(EmiTenure).Append("\n");
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
        public override bool Equals(object? input)
        {
            return this.Equals(input as CFCardEMI);
        }

        /// <summary>
        /// Returns true if CFCardEMI instances are equal
        /// </summary>
        /// <param name="input">Instance of CFCardEMI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CFCardEMI? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Channel == input.Channel ||
                    this.Channel.Equals(input.Channel)
                ) && 
                (
                    this.CardNumber == input.CardNumber ||
                    (this.CardNumber != null &&
                    this.CardNumber.Equals(input.CardNumber))
                ) && 
                (
                    this.CardHolderName == input.CardHolderName ||
                    (this.CardHolderName != null &&
                    this.CardHolderName.Equals(input.CardHolderName))
                ) && 
                (
                    this.CardExpiryMm == input.CardExpiryMm ||
                    (this.CardExpiryMm != null &&
                    this.CardExpiryMm.Equals(input.CardExpiryMm))
                ) && 
                (
                    this.CardExpiryYy == input.CardExpiryYy ||
                    (this.CardExpiryYy != null &&
                    this.CardExpiryYy.Equals(input.CardExpiryYy))
                ) && 
                (
                    this.CardCvv == input.CardCvv ||
                    (this.CardCvv != null &&
                    this.CardCvv.Equals(input.CardCvv))
                ) && 
                (
                    this.CardAlias == input.CardAlias ||
                    (this.CardAlias != null &&
                    this.CardAlias.Equals(input.CardAlias))
                ) && 
                (
                    this.CardBankName == input.CardBankName ||
                    this.CardBankName.Equals(input.CardBankName)
                ) && 
                (
                    this.EmiTenure == input.EmiTenure ||
                    this.EmiTenure.Equals(input.EmiTenure)
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
                hashCode = (hashCode * 59) + this.Channel.GetHashCode();
                if (this.CardNumber != null)
                {
                    hashCode = (hashCode * 59) + this.CardNumber.GetHashCode();
                }
                if (this.CardHolderName != null)
                {
                    hashCode = (hashCode * 59) + this.CardHolderName.GetHashCode();
                }
                if (this.CardExpiryMm != null)
                {
                    hashCode = (hashCode * 59) + this.CardExpiryMm.GetHashCode();
                }
                if (this.CardExpiryYy != null)
                {
                    hashCode = (hashCode * 59) + this.CardExpiryYy.GetHashCode();
                }
                if (this.CardCvv != null)
                {
                    hashCode = (hashCode * 59) + this.CardCvv.GetHashCode();
                }
                if (this.CardAlias != null)
                {
                    hashCode = (hashCode * 59) + this.CardAlias.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CardBankName.GetHashCode();
                hashCode = (hashCode * 59) + this.EmiTenure.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

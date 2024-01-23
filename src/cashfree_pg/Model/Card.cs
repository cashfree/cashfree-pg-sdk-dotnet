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
    /// Card Payment method
    /// </summary>
    [DataContract(Name = "Card")]
    public class Card : IEquatable<Card>, IValidatableObject
    {
        /// <summary>
        /// The channel for card payments can be \&quot;link\&quot; or \&quot;post\&quot;. Post is used for seamless OTP payments where merchant captures OTP on their own page.
        /// </summary>
        /// <value>The channel for card payments can be \&quot;link\&quot; or \&quot;post\&quot;. Post is used for seamless OTP payments where merchant captures OTP on their own page.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChannelEnum
        {
            /// <summary>
            /// Enum Link for value: link
            /// </summary>
            [EnumMember(Value = "link")]
            Link = 1,

            /// <summary>
            /// Enum Post for value: post
            /// </summary>
            [EnumMember(Value = "post")]
            Post = 2
        }


        /// <summary>
        /// The channel for card payments can be \&quot;link\&quot; or \&quot;post\&quot;. Post is used for seamless OTP payments where merchant captures OTP on their own page.
        /// </summary>
        /// <value>The channel for card payments can be \&quot;link\&quot; or \&quot;post\&quot;. Post is used for seamless OTP payments where merchant captures OTP on their own page.</value>
        [DataMember(Name = "channel", IsRequired = true, EmitDefaultValue = true)]
        public ChannelEnum channel { get; set; }
        /// <summary>
        /// Defines token_type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TokenTypeEnum
        {
            /// <summary>
            /// Enum ISSUERTOKEN for value: ISSUER_TOKEN
            /// </summary>
            [EnumMember(Value = "ISSUER_TOKEN")]
            ISSUERTOKEN = 1,

            /// <summary>
            /// Enum NETWORKGCTOKEN for value: NETWORK_GC_TOKEN
            /// </summary>
            [EnumMember(Value = "NETWORK_GC_TOKEN")]
            NETWORKGCTOKEN = 2,

            /// <summary>
            /// Enum ISSUERGCTOKEN for value: ISSUER_GC_TOKEN
            /// </summary>
            [EnumMember(Value = "ISSUER_GC_TOKEN")]
            ISSUERGCTOKEN = 3
        }


        /// <summary>
        /// Gets or Sets token_type
        /// </summary>
        [DataMember(Name = "token_type", EmitDefaultValue = false)]
        public TokenTypeEnum? token_type { get; set; }
        /// <summary>
        /// One of [\&quot;Kotak\&quot;, \&quot;ICICI\&quot;, \&quot;RBL\&quot;, \&quot;BOB\&quot;, \&quot;Standard Chartered\&quot;]. Card bank name, required for EMI payments. This is the bank user has selected for EMI
        /// </summary>
        /// <value>One of [\&quot;Kotak\&quot;, \&quot;ICICI\&quot;, \&quot;RBL\&quot;, \&quot;BOB\&quot;, \&quot;Standard Chartered\&quot;]. Card bank name, required for EMI payments. This is the bank user has selected for EMI</value>
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
            StandardChartered = 5
        }


        /// <summary>
        /// One of [\&quot;Kotak\&quot;, \&quot;ICICI\&quot;, \&quot;RBL\&quot;, \&quot;BOB\&quot;, \&quot;Standard Chartered\&quot;]. Card bank name, required for EMI payments. This is the bank user has selected for EMI
        /// </summary>
        /// <value>One of [\&quot;Kotak\&quot;, \&quot;ICICI\&quot;, \&quot;RBL\&quot;, \&quot;BOB\&quot;, \&quot;Standard Chartered\&quot;]. Card bank name, required for EMI payments. This is the bank user has selected for EMI</value>
        [DataMember(Name = "card_bank_name", EmitDefaultValue = false)]
        public CardBankNameEnum? card_bank_name { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Card" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Card() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Card" /> class.
        /// </summary>
        /// <param name="channel">The channel for card payments can be \&quot;link\&quot; or \&quot;post\&quot;. Post is used for seamless OTP payments where merchant captures OTP on their own page. (required).</param>
        /// <param name="cardNumber">Customer card number for plain card transactions. Token pan number for tokenized card transactions..</param>
        /// <param name="cardHolderName">Customer name mentioned on the card..</param>
        /// <param name="cardExpiryMm">Card expiry month for plain card transactions. Token expiry month for tokenized card transactions..</param>
        /// <param name="cardExpiryYy">Card expiry year for plain card transactions. Token expiry year for tokenized card transactions..</param>
        /// <param name="cardCvv">CVV mentioned on the card..</param>
        /// <param name="instrumentId">instrument id of saved card. Required only to make payment using saved instrument..</param>
        /// <param name="cryptogram">cryptogram received from card network. Required only for tokenized card transactions..</param>
        /// <param name="tokenRequestorId">TRID issued by card networks. Required only for tokenized card transactions..</param>
        /// <param name="tokenType">tokenType.</param>
        /// <param name="cardDisplay">last 4 digits of original card number. Required only for tokenized card transactions..</param>
        /// <param name="cardAlias">Card alias as returned by Cashfree Vault API..</param>
        /// <param name="cardBankName">One of [\&quot;Kotak\&quot;, \&quot;ICICI\&quot;, \&quot;RBL\&quot;, \&quot;BOB\&quot;, \&quot;Standard Chartered\&quot;]. Card bank name, required for EMI payments. This is the bank user has selected for EMI.</param>
        /// <param name="emiTenure">EMI tenure selected by the user.</param>
        public Card(ChannelEnum channel = default(ChannelEnum), string cardNumber = default(string), string cardHolderName = default(string), string cardExpiryMm = default(string), string cardExpiryYy = default(string), string cardCvv = default(string), string instrumentId = default(string), string cryptogram = default(string), string tokenRequestorId = default(string), TokenTypeEnum? tokenType = default(TokenTypeEnum?), string cardDisplay = default(string), string cardAlias = default(string), CardBankNameEnum? cardBankName = default(CardBankNameEnum?), int emiTenure = default(int))
        {
            this.channel = channel;
            this.card_number = cardNumber;
            this.card_holder_name = cardHolderName;
            this.card_expiry_mm = cardExpiryMm;
            this.card_expiry_yy = cardExpiryYy;
            this.card_cvv = cardCvv;
            this.instrument_id = instrumentId;
            this.cryptogram = cryptogram;
            this.token_requestor_id = tokenRequestorId;
            this.token_type = tokenType;
            this.card_display = cardDisplay;
            this.card_alias = cardAlias;
            this.card_bank_name = cardBankName;
            this.emi_tenure = emiTenure;
        }

        /// <summary>
        /// Customer card number for plain card transactions. Token pan number for tokenized card transactions.
        /// </summary>
        /// <value>Customer card number for plain card transactions. Token pan number for tokenized card transactions.</value>
        [DataMember(Name = "card_number", EmitDefaultValue = false)]
        public string card_number { get; set; }

        /// <summary>
        /// Customer name mentioned on the card.
        /// </summary>
        /// <value>Customer name mentioned on the card.</value>
        [DataMember(Name = "card_holder_name", EmitDefaultValue = false)]
        public string card_holder_name { get; set; }

        /// <summary>
        /// Card expiry month for plain card transactions. Token expiry month for tokenized card transactions.
        /// </summary>
        /// <value>Card expiry month for plain card transactions. Token expiry month for tokenized card transactions.</value>
        [DataMember(Name = "card_expiry_mm", EmitDefaultValue = false)]
        public string card_expiry_mm { get; set; }

        /// <summary>
        /// Card expiry year for plain card transactions. Token expiry year for tokenized card transactions.
        /// </summary>
        /// <value>Card expiry year for plain card transactions. Token expiry year for tokenized card transactions.</value>
        [DataMember(Name = "card_expiry_yy", EmitDefaultValue = false)]
        public string card_expiry_yy { get; set; }

        /// <summary>
        /// CVV mentioned on the card.
        /// </summary>
        /// <value>CVV mentioned on the card.</value>
        [DataMember(Name = "card_cvv", EmitDefaultValue = false)]
        public string card_cvv { get; set; }

        /// <summary>
        /// instrument id of saved card. Required only to make payment using saved instrument.
        /// </summary>
        /// <value>instrument id of saved card. Required only to make payment using saved instrument.</value>
        [DataMember(Name = "instrument_id", EmitDefaultValue = false)]
        public string instrument_id { get; set; }

        /// <summary>
        /// cryptogram received from card network. Required only for tokenized card transactions.
        /// </summary>
        /// <value>cryptogram received from card network. Required only for tokenized card transactions.</value>
        [DataMember(Name = "cryptogram", EmitDefaultValue = false)]
        public string cryptogram { get; set; }

        /// <summary>
        /// TRID issued by card networks. Required only for tokenized card transactions.
        /// </summary>
        /// <value>TRID issued by card networks. Required only for tokenized card transactions.</value>
        [DataMember(Name = "token_requestor_id", EmitDefaultValue = false)]
        public string token_requestor_id { get; set; }

        /// <summary>
        /// last 4 digits of original card number. Required only for tokenized card transactions.
        /// </summary>
        /// <value>last 4 digits of original card number. Required only for tokenized card transactions.</value>
        [DataMember(Name = "card_display", EmitDefaultValue = false)]
        public string card_display { get; set; }

        /// <summary>
        /// Card alias as returned by Cashfree Vault API.
        /// </summary>
        /// <value>Card alias as returned by Cashfree Vault API.</value>
        [DataMember(Name = "card_alias", EmitDefaultValue = false)]
        public string card_alias { get; set; }

        /// <summary>
        /// EMI tenure selected by the user
        /// </summary>
        /// <value>EMI tenure selected by the user</value>
        [DataMember(Name = "emi_tenure", EmitDefaultValue = false)]
        public int emi_tenure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Card {\n");
            sb.Append("  channel: ").Append(channel).Append("\n");
            sb.Append("  card_number: ").Append(card_number).Append("\n");
            sb.Append("  card_holder_name: ").Append(card_holder_name).Append("\n");
            sb.Append("  card_expiry_mm: ").Append(card_expiry_mm).Append("\n");
            sb.Append("  card_expiry_yy: ").Append(card_expiry_yy).Append("\n");
            sb.Append("  card_cvv: ").Append(card_cvv).Append("\n");
            sb.Append("  instrument_id: ").Append(instrument_id).Append("\n");
            sb.Append("  cryptogram: ").Append(cryptogram).Append("\n");
            sb.Append("  token_requestor_id: ").Append(token_requestor_id).Append("\n");
            sb.Append("  token_type: ").Append(token_type).Append("\n");
            sb.Append("  card_display: ").Append(card_display).Append("\n");
            sb.Append("  card_alias: ").Append(card_alias).Append("\n");
            sb.Append("  card_bank_name: ").Append(card_bank_name).Append("\n");
            sb.Append("  emi_tenure: ").Append(emi_tenure).Append("\n");
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
            return this.Equals(input as Card);
        }

        /// <summary>
        /// Returns true if Card instances are equal
        /// </summary>
        /// <param name="input">Instance of Card to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Card input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.channel == input.channel ||
                    this.channel.Equals(input.channel)
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
                    this.instrument_id == input.instrument_id ||
                    (this.instrument_id != null &&
                    this.instrument_id.Equals(input.instrument_id))
                ) && 
                (
                    this.cryptogram == input.cryptogram ||
                    (this.cryptogram != null &&
                    this.cryptogram.Equals(input.cryptogram))
                ) && 
                (
                    this.token_requestor_id == input.token_requestor_id ||
                    (this.token_requestor_id != null &&
                    this.token_requestor_id.Equals(input.token_requestor_id))
                ) && 
                (
                    this.token_type == input.token_type ||
                    this.token_type.Equals(input.token_type)
                ) && 
                (
                    this.card_display == input.card_display ||
                    (this.card_display != null &&
                    this.card_display.Equals(input.card_display))
                ) && 
                (
                    this.card_alias == input.card_alias ||
                    (this.card_alias != null &&
                    this.card_alias.Equals(input.card_alias))
                ) && 
                (
                    this.card_bank_name == input.card_bank_name ||
                    this.card_bank_name.Equals(input.card_bank_name)
                ) && 
                (
                    this.emi_tenure == input.emi_tenure ||
                    this.emi_tenure.Equals(input.emi_tenure)
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
                hashCode = (hashCode * 59) + this.channel.GetHashCode();
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
                if (this.instrument_id != null)
                {
                    hashCode = (hashCode * 59) + this.instrument_id.GetHashCode();
                }
                if (this.cryptogram != null)
                {
                    hashCode = (hashCode * 59) + this.cryptogram.GetHashCode();
                }
                if (this.token_requestor_id != null)
                {
                    hashCode = (hashCode * 59) + this.token_requestor_id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.token_type.GetHashCode();
                if (this.card_display != null)
                {
                    hashCode = (hashCode * 59) + this.card_display.GetHashCode();
                }
                if (this.card_alias != null)
                {
                    hashCode = (hashCode * 59) + this.card_alias.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.card_bank_name.GetHashCode();
                hashCode = (hashCode * 59) + this.emi_tenure.GetHashCode();
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

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
    /// CFCryptogram
    /// </summary>
    [DataContract(Name = "CFCryptogram")]
    public partial class CFCryptogram : IEquatable<CFCryptogram>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFCryptogram" /> class.
        /// </summary>
        /// <param name="instrumentId">instrument_id of saved instrument.</param>
        /// <param name="tokenRequestorId">TRID issued by card networks.</param>
        /// <param name="cardNumber">token pan number.</param>
        /// <param name="cardExpiryMm">token pan expiry month.</param>
        /// <param name="cardExpiryYy">token pan expiry year.</param>
        /// <param name="cryptogram">cryptogram.</param>
        /// <param name="cardDisplay">last 4 digits of original card number.</param>
        public CFCryptogram(string? instrumentId = default(string?), string? tokenRequestorId = default(string?), string? cardNumber = default(string?), string? cardExpiryMm = default(string?), string? cardExpiryYy = default(string?), string? cryptogram = default(string?), string? cardDisplay = default(string?))
        {
            this.InstrumentId = instrumentId;
            this.TokenRequestorId = tokenRequestorId;
            this.CardNumber = cardNumber;
            this.CardExpiryMm = cardExpiryMm;
            this.CardExpiryYy = cardExpiryYy;
            this.Cryptogram = cryptogram;
            this.CardDisplay = cardDisplay;
        }

        /// <summary>
        /// instrument_id of saved instrument
        /// </summary>
        /// <value>instrument_id of saved instrument</value>
        [DataMember(Name = "instrument_id", EmitDefaultValue = false)]
        public string? InstrumentId { get; set; }

        /// <summary>
        /// TRID issued by card networks
        /// </summary>
        /// <value>TRID issued by card networks</value>
        [DataMember(Name = "token_requestor_id", EmitDefaultValue = false)]
        public string? TokenRequestorId { get; set; }

        /// <summary>
        /// token pan number
        /// </summary>
        /// <value>token pan number</value>
        [DataMember(Name = "card_number", EmitDefaultValue = false)]
        public string? CardNumber { get; set; }

        /// <summary>
        /// token pan expiry month
        /// </summary>
        /// <value>token pan expiry month</value>
        [DataMember(Name = "card_expiry_mm", EmitDefaultValue = false)]
        public string? CardExpiryMm { get; set; }

        /// <summary>
        /// token pan expiry year
        /// </summary>
        /// <value>token pan expiry year</value>
        [DataMember(Name = "card_expiry_yy", EmitDefaultValue = false)]
        public string? CardExpiryYy { get; set; }

        /// <summary>
        /// cryptogram
        /// </summary>
        /// <value>cryptogram</value>
        [DataMember(Name = "cryptogram", EmitDefaultValue = false)]
        public string? Cryptogram { get; set; }

        /// <summary>
        /// last 4 digits of original card number
        /// </summary>
        /// <value>last 4 digits of original card number</value>
        [DataMember(Name = "card_display", EmitDefaultValue = false)]
        public string? CardDisplay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CFCryptogram {\n");
            sb.Append("  InstrumentId: ").Append(InstrumentId).Append("\n");
            sb.Append("  TokenRequestorId: ").Append(TokenRequestorId).Append("\n");
            sb.Append("  CardNumber: ").Append(CardNumber).Append("\n");
            sb.Append("  CardExpiryMm: ").Append(CardExpiryMm).Append("\n");
            sb.Append("  CardExpiryYy: ").Append(CardExpiryYy).Append("\n");
            sb.Append("  Cryptogram: ").Append(Cryptogram).Append("\n");
            sb.Append("  CardDisplay: ").Append(CardDisplay).Append("\n");
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
            return this.Equals(input as CFCryptogram);
        }

        /// <summary>
        /// Returns true if CFCryptogram instances are equal
        /// </summary>
        /// <param name="input">Instance of CFCryptogram to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CFCryptogram? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.InstrumentId == input.InstrumentId ||
                    (this.InstrumentId != null &&
                    this.InstrumentId.Equals(input.InstrumentId))
                ) && 
                (
                    this.TokenRequestorId == input.TokenRequestorId ||
                    (this.TokenRequestorId != null &&
                    this.TokenRequestorId.Equals(input.TokenRequestorId))
                ) && 
                (
                    this.CardNumber == input.CardNumber ||
                    (this.CardNumber != null &&
                    this.CardNumber.Equals(input.CardNumber))
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
                    this.Cryptogram == input.Cryptogram ||
                    (this.Cryptogram != null &&
                    this.Cryptogram.Equals(input.Cryptogram))
                ) && 
                (
                    this.CardDisplay == input.CardDisplay ||
                    (this.CardDisplay != null &&
                    this.CardDisplay.Equals(input.CardDisplay))
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
                if (this.InstrumentId != null)
                {
                    hashCode = (hashCode * 59) + this.InstrumentId.GetHashCode();
                }
                if (this.TokenRequestorId != null)
                {
                    hashCode = (hashCode * 59) + this.TokenRequestorId.GetHashCode();
                }
                if (this.CardNumber != null)
                {
                    hashCode = (hashCode * 59) + this.CardNumber.GetHashCode();
                }
                if (this.CardExpiryMm != null)
                {
                    hashCode = (hashCode * 59) + this.CardExpiryMm.GetHashCode();
                }
                if (this.CardExpiryYy != null)
                {
                    hashCode = (hashCode * 59) + this.CardExpiryYy.GetHashCode();
                }
                if (this.Cryptogram != null)
                {
                    hashCode = (hashCode * 59) + this.Cryptogram.GetHashCode();
                }
                if (this.CardDisplay != null)
                {
                    hashCode = (hashCode * 59) + this.CardDisplay.GetHashCode();
                }
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

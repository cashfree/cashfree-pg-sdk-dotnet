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
    /// CFSavedInstrumentMeta
    /// </summary>
    [DataContract(Name = "CFSavedInstrumentMeta")]
    public partial class CFSavedInstrumentMeta : IEquatable<CFSavedInstrumentMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CFSavedInstrumentMeta" /> class.
        /// </summary>
        /// <param name="cardNetwork">card scheme/network of the saved card.</param>
        /// <param name="cardBankName">Issuing bank name of saved card.</param>
        /// <param name="cardCountry">Issuing country of saved card.</param>
        /// <param name="cardType">Type of saved card.</param>
        /// <param name="cardTokenDetails">cardTokenDetails.</param>
        public CFSavedInstrumentMeta(string? cardNetwork = default(string?), string? cardBankName = default(string?), string? cardCountry = default(string?), string? cardType = default(string?), Object? cardTokenDetails = default(Object?))
        {
            this.CardNetwork = cardNetwork;
            this.CardBankName = cardBankName;
            this.CardCountry = cardCountry;
            this.CardType = cardType;
            this.CardTokenDetails = cardTokenDetails;
        }

        /// <summary>
        /// card scheme/network of the saved card
        /// </summary>
        /// <value>card scheme/network of the saved card</value>
        [DataMember(Name = "card_network", EmitDefaultValue = false)]
        public string? CardNetwork { get; set; }

        /// <summary>
        /// Issuing bank name of saved card
        /// </summary>
        /// <value>Issuing bank name of saved card</value>
        [DataMember(Name = "card_bank_name", EmitDefaultValue = false)]
        public string? CardBankName { get; set; }

        /// <summary>
        /// Issuing country of saved card
        /// </summary>
        /// <value>Issuing country of saved card</value>
        [DataMember(Name = "card_country", EmitDefaultValue = false)]
        public string? CardCountry { get; set; }

        /// <summary>
        /// Type of saved card
        /// </summary>
        /// <value>Type of saved card</value>
        [DataMember(Name = "card_type", EmitDefaultValue = false)]
        public string? CardType { get; set; }

        /// <summary>
        /// Gets or Sets CardTokenDetails
        /// </summary>
        [DataMember(Name = "card_token_details", EmitDefaultValue = false)]
        public Object? CardTokenDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CFSavedInstrumentMeta {\n");
            sb.Append("  CardNetwork: ").Append(CardNetwork).Append("\n");
            sb.Append("  CardBankName: ").Append(CardBankName).Append("\n");
            sb.Append("  CardCountry: ").Append(CardCountry).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  CardTokenDetails: ").Append(CardTokenDetails).Append("\n");
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
            return this.Equals(input as CFSavedInstrumentMeta);
        }

        /// <summary>
        /// Returns true if CFSavedInstrumentMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of CFSavedInstrumentMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CFSavedInstrumentMeta? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CardNetwork == input.CardNetwork ||
                    (this.CardNetwork != null &&
                    this.CardNetwork.Equals(input.CardNetwork))
                ) && 
                (
                    this.CardBankName == input.CardBankName ||
                    (this.CardBankName != null &&
                    this.CardBankName.Equals(input.CardBankName))
                ) && 
                (
                    this.CardCountry == input.CardCountry ||
                    (this.CardCountry != null &&
                    this.CardCountry.Equals(input.CardCountry))
                ) && 
                (
                    this.CardType == input.CardType ||
                    (this.CardType != null &&
                    this.CardType.Equals(input.CardType))
                ) && 
                (
                    this.CardTokenDetails == input.CardTokenDetails ||
                    (this.CardTokenDetails != null &&
                    this.CardTokenDetails.Equals(input.CardTokenDetails))
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
                if (this.CardNetwork != null)
                {
                    hashCode = (hashCode * 59) + this.CardNetwork.GetHashCode();
                }
                if (this.CardBankName != null)
                {
                    hashCode = (hashCode * 59) + this.CardBankName.GetHashCode();
                }
                if (this.CardCountry != null)
                {
                    hashCode = (hashCode * 59) + this.CardCountry.GetHashCode();
                }
                if (this.CardType != null)
                {
                    hashCode = (hashCode * 59) + this.CardType.GetHashCode();
                }
                if (this.CardTokenDetails != null)
                {
                    hashCode = (hashCode * 59) + this.CardTokenDetails.GetHashCode();
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

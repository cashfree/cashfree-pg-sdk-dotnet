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
    /// This object takes details of all the filtering that has to be done for this order. Filters on card bins, card schemes, card issuing bank and card suffixes
    /// </summary>
    [DataContract(Name = "OrderMeta_payment_methods_filters_filters")]
    public class OrderMetaPaymentMethodsFiltersFilters : IEquatable<OrderMetaPaymentMethodsFiltersFilters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderMetaPaymentMethodsFiltersFilters" /> class.
        /// </summary>
        /// <param name="cardBins">cardBins.</param>
        /// <param name="cardSchemes">cardSchemes.</param>
        /// <param name="cardSuffix">cardSuffix.</param>
        /// <param name="cardIssuingBank">cardIssuingBank.</param>
        public OrderMetaPaymentMethodsFiltersFilters(OrderMetaPaymentMethodsFiltersFiltersCardBins? cardBins = default(OrderMetaPaymentMethodsFiltersFiltersCardBins?), OrderMetaPaymentMethodsFiltersFiltersCardSchemes? cardSchemes = default(OrderMetaPaymentMethodsFiltersFiltersCardSchemes?), OrderMetaPaymentMethodsFiltersFiltersCardSuffix? cardSuffix = default(OrderMetaPaymentMethodsFiltersFiltersCardSuffix?), OrderMetaPaymentMethodsFiltersFiltersCardIssuingBank? cardIssuingBank = default(OrderMetaPaymentMethodsFiltersFiltersCardIssuingBank?))
        {
            this.card_bins = cardBins;
            this.card_schemes = cardSchemes;
            this.card_suffix = cardSuffix;
            this.card_issuing_bank = cardIssuingBank;
        }

        /// <summary>
        /// Gets or Sets card_bins
        /// </summary>
        [DataMember(Name = "card_bins", EmitDefaultValue = false)]
        public OrderMetaPaymentMethodsFiltersFiltersCardBins? card_bins { get; set; }

        /// <summary>
        /// Gets or Sets card_schemes
        /// </summary>
        [DataMember(Name = "card_schemes", EmitDefaultValue = false)]
        public OrderMetaPaymentMethodsFiltersFiltersCardSchemes? card_schemes { get; set; }

        /// <summary>
        /// Gets or Sets card_suffix
        /// </summary>
        [DataMember(Name = "card_suffix", EmitDefaultValue = false)]
        public OrderMetaPaymentMethodsFiltersFiltersCardSuffix? card_suffix { get; set; }

        /// <summary>
        /// Gets or Sets card_issuing_bank
        /// </summary>
        [DataMember(Name = "card_issuing_bank", EmitDefaultValue = false)]
        public OrderMetaPaymentMethodsFiltersFiltersCardIssuingBank? card_issuing_bank { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderMetaPaymentMethodsFiltersFilters {\n");
            sb.Append("  card_bins: ").Append(card_bins).Append("\n");
            sb.Append("  card_schemes: ").Append(card_schemes).Append("\n");
            sb.Append("  card_suffix: ").Append(card_suffix).Append("\n");
            sb.Append("  card_issuing_bank: ").Append(card_issuing_bank).Append("\n");
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
            return this.Equals(input as OrderMetaPaymentMethodsFiltersFilters);
        }

        /// <summary>
        /// Returns true if OrderMetaPaymentMethodsFiltersFilters instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderMetaPaymentMethodsFiltersFilters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderMetaPaymentMethodsFiltersFilters input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.card_bins == input.card_bins ||
                    (this.card_bins != null &&
                    this.card_bins.Equals(input.card_bins))
                ) && 
                (
                    this.card_schemes == input.card_schemes ||
                    (this.card_schemes != null &&
                    this.card_schemes.Equals(input.card_schemes))
                ) && 
                (
                    this.card_suffix == input.card_suffix ||
                    (this.card_suffix != null &&
                    this.card_suffix.Equals(input.card_suffix))
                ) && 
                (
                    this.card_issuing_bank == input.card_issuing_bank ||
                    (this.card_issuing_bank != null &&
                    this.card_issuing_bank.Equals(input.card_issuing_bank))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringcard_bins) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringcard_bins);
            if (deserializedJsonString.ContainsKey("card_bins")) {
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
                if (this.card_bins != null)
                {
                    hashCode = (hashCode * 59) + this.card_bins.GetHashCode();
                }
                if (this.card_schemes != null)
                {
                    hashCode = (hashCode * 59) + this.card_schemes.GetHashCode();
                }
                if (this.card_suffix != null)
                {
                    hashCode = (hashCode * 59) + this.card_suffix.GetHashCode();
                }
                if (this.card_issuing_bank != null)
                {
                    hashCode = (hashCode * 59) + this.card_issuing_bank.GetHashCode();
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

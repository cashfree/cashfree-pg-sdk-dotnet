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
    /// Offer details and type
    /// </summary>
    [DataContract(Name = "OfferDetails")]
    public class OfferDetails : IEquatable<OfferDetails>, IValidatableObject
    {
        /// <summary>
        /// Offer Type for the Offer.
        /// </summary>
        /// <value>Offer Type for the Offer.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OfferTypeEnum
        {
            /// <summary>
            /// Enum DISCOUNT for value: DISCOUNT
            /// </summary>
            [EnumMember(Value = "DISCOUNT")]
            DISCOUNT = 1,

            /// <summary>
            /// Enum CASHBACK for value: CASHBACK
            /// </summary>
            [EnumMember(Value = "CASHBACK")]
            CASHBACK = 2,

            /// <summary>
            /// Enum DISCOUNTANDCASHBACK for value: DISCOUNT_AND_CASHBACK
            /// </summary>
            [EnumMember(Value = "DISCOUNT_AND_CASHBACK")]
            DISCOUNTANDCASHBACK = 3,

            /// <summary>
            /// Enum NOCOSTEMI for value: NO_COST_EMI
            /// </summary>
            [EnumMember(Value = "NO_COST_EMI")]
            NOCOSTEMI = 4
        }


        /// <summary>
        /// Offer Type for the Offer.
        /// </summary>
        /// <value>Offer Type for the Offer.</value>
        /// <example>DISCOUNT_AND_CASHBACK</example>
        [DataMember(Name = "offer_type", IsRequired = true, EmitDefaultValue = true)]
        public OfferTypeEnum offer_type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OfferDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferDetails" /> class.
        /// </summary>
        /// <param name="offerType">Offer Type for the Offer. (required).</param>
        /// <param name="discountDetails">discountDetails.</param>
        /// <param name="cashbackDetails">cashbackDetails.</param>
        public OfferDetails(OfferTypeEnum offerType = default(OfferTypeEnum), DiscountDetails? discountDetails = default(DiscountDetails?), CashbackDetails? cashbackDetails = default(CashbackDetails?))
        {
            this.offer_type = offerType;
            this.discount_details = discountDetails;
            this.cashback_details = cashbackDetails;
        }

        /// <summary>
        /// Gets or Sets discount_details
        /// </summary>
        [DataMember(Name = "discount_details", EmitDefaultValue = false)]
        public DiscountDetails? discount_details { get; set; }

        /// <summary>
        /// Gets or Sets cashback_details
        /// </summary>
        [DataMember(Name = "cashback_details", EmitDefaultValue = false)]
        public CashbackDetails? cashback_details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OfferDetails {\n");
            sb.Append("  offer_type: ").Append(offer_type).Append("\n");
            sb.Append("  discount_details: ").Append(discount_details).Append("\n");
            sb.Append("  cashback_details: ").Append(cashback_details).Append("\n");
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
            return this.Equals(input as OfferDetails);
        }

        /// <summary>
        /// Returns true if OfferDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of OfferDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.offer_type == input.offer_type ||
                    this.offer_type.Equals(input.offer_type)
                ) && 
                (
                    this.discount_details == input.discount_details ||
                    (this.discount_details != null &&
                    this.discount_details.Equals(input.discount_details))
                ) && 
                (
                    this.cashback_details == input.cashback_details ||
                    (this.cashback_details != null &&
                    this.cashback_details.Equals(input.cashback_details))
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
                hashCode = (hashCode * 59) + this.offer_type.GetHashCode();
                if (this.discount_details != null)
                {
                    hashCode = (hashCode * 59) + this.discount_details.GetHashCode();
                }
                if (this.cashback_details != null)
                {
                    hashCode = (hashCode * 59) + this.cashback_details.GetHashCode();
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

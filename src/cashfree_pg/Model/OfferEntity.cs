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
    /// Offer entity object
    /// </summary>
    [DataContract(Name = "OfferEntity")]
    public class OfferEntity : IEquatable<OfferEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferEntity" /> class.
        /// </summary>
        /// <param name="offerId">offerId.</param>
        /// <param name="offerStatus">offerStatus.</param>
        /// <param name="orderAmount">orderAmount.</param>
        /// <param name="payableAmount">payableAmount.</param>
        /// <param name="offerMeta">offerMeta.</param>
        /// <param name="offerTnc">offerTnc.</param>
        /// <param name="offerDetails">offerDetails.</param>
        /// <param name="offerValidations">offerValidations.</param>
        public OfferEntity(string? offerId = default(string?), string? offerStatus = default(string?), decimal? orderAmount = default(decimal?), decimal? payableAmount = default(decimal?), OfferMetaResponse? offerMeta = default(OfferMetaResponse?), OfferTncResponse? offerTnc = default(OfferTncResponse?), OfferDetailsResponse? offerDetails = default(OfferDetailsResponse?), OfferValidationsResponse? offerValidations = default(OfferValidationsResponse?))
        {
            this.offer_id = offerId;
            this.offer_status = offerStatus;
            this.order_amount = orderAmount;
            this.payable_amount = payableAmount;
            this.offer_meta = offerMeta;
            this.offer_tnc = offerTnc;
            this.offer_details = offerDetails;
            this.offer_validations = offerValidations;
        }

        /// <summary>
        /// Gets or Sets offer_id
        /// </summary>
        /// <example>d2b430fb-1afe-455a-af31-66d00377b29a</example>
        [DataMember(Name = "offer_id", EmitDefaultValue = false)]
        public string? offer_id { get; set; }

        /// <summary>
        /// Gets or Sets offer_status
        /// </summary>
        /// <example>active</example>
        [DataMember(Name = "offer_status", EmitDefaultValue = false)]
        public string? offer_status { get; set; }

        /// <summary>
        /// Gets or Sets order_amount
        /// </summary>
        [DataMember(Name = "order_amount", EmitDefaultValue = false)]
        public decimal? order_amount { get; set; }

        /// <summary>
        /// Gets or Sets payable_amount
        /// </summary>
        [DataMember(Name = "payable_amount", EmitDefaultValue = false)]
        public decimal? payable_amount { get; set; }

        /// <summary>
        /// Gets or Sets offer_meta
        /// </summary>
        [DataMember(Name = "offer_meta", EmitDefaultValue = false)]
        public OfferMetaResponse? offer_meta { get; set; }

        /// <summary>
        /// Gets or Sets offer_tnc
        /// </summary>
        [DataMember(Name = "offer_tnc", EmitDefaultValue = false)]
        public OfferTncResponse? offer_tnc { get; set; }

        /// <summary>
        /// Gets or Sets offer_details
        /// </summary>
        [DataMember(Name = "offer_details", EmitDefaultValue = false)]
        public OfferDetailsResponse? offer_details { get; set; }

        /// <summary>
        /// Gets or Sets offer_validations
        /// </summary>
        [DataMember(Name = "offer_validations", EmitDefaultValue = false)]
        public OfferValidationsResponse? offer_validations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OfferEntity {\n");
            sb.Append("  offer_id: ").Append(offer_id).Append("\n");
            sb.Append("  offer_status: ").Append(offer_status).Append("\n");
            sb.Append("  order_amount: ").Append(order_amount).Append("\n");
            sb.Append("  payable_amount: ").Append(payable_amount).Append("\n");
            sb.Append("  offer_meta: ").Append(offer_meta).Append("\n");
            sb.Append("  offer_tnc: ").Append(offer_tnc).Append("\n");
            sb.Append("  offer_details: ").Append(offer_details).Append("\n");
            sb.Append("  offer_validations: ").Append(offer_validations).Append("\n");
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
            return this.Equals(input as OfferEntity);
        }

        /// <summary>
        /// Returns true if OfferEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of OfferEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.offer_id == input.offer_id ||
                    (this.offer_id != null &&
                    this.offer_id.Equals(input.offer_id))
                ) && 
                (
                    this.offer_status == input.offer_status ||
                    (this.offer_status != null &&
                    this.offer_status.Equals(input.offer_status))
                ) && 
                (
                    this.order_amount == input.order_amount ||
                    this.order_amount.Equals(input.order_amount)
                ) && 
                (
                    this.payable_amount == input.payable_amount ||
                    this.payable_amount.Equals(input.payable_amount)
                ) && 
                (
                    this.offer_meta == input.offer_meta ||
                    (this.offer_meta != null &&
                    this.offer_meta.Equals(input.offer_meta))
                ) && 
                (
                    this.offer_tnc == input.offer_tnc ||
                    (this.offer_tnc != null &&
                    this.offer_tnc.Equals(input.offer_tnc))
                ) && 
                (
                    this.offer_details == input.offer_details ||
                    (this.offer_details != null &&
                    this.offer_details.Equals(input.offer_details))
                ) && 
                (
                    this.offer_validations == input.offer_validations ||
                    (this.offer_validations != null &&
                    this.offer_validations.Equals(input.offer_validations))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringoffer_id) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringoffer_id);
            if (deserializedJsonString.ContainsKey("offer_id")) {
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
                if (this.offer_id != null)
                {
                    hashCode = (hashCode * 59) + this.offer_id.GetHashCode();
                }
                if (this.offer_status != null)
                {
                    hashCode = (hashCode * 59) + this.offer_status.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.order_amount.GetHashCode();
                hashCode = (hashCode * 59) + this.payable_amount.GetHashCode();
                if (this.offer_meta != null)
                {
                    hashCode = (hashCode * 59) + this.offer_meta.GetHashCode();
                }
                if (this.offer_tnc != null)
                {
                    hashCode = (hashCode * 59) + this.offer_tnc.GetHashCode();
                }
                if (this.offer_details != null)
                {
                    hashCode = (hashCode * 59) + this.offer_details.GetHashCode();
                }
                if (this.offer_validations != null)
                {
                    hashCode = (hashCode * 59) + this.offer_validations.GetHashCode();
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

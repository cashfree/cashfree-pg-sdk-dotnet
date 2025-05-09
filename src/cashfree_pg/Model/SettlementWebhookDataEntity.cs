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
    /// data entity in webhook
    /// </summary>
    [DataContract(Name = "SettlementWebhookDataEntity")]
    public class SettlementWebhookDataEntity : IEquatable<SettlementWebhookDataEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettlementWebhookDataEntity" /> class.
        /// </summary>
        /// <param name="settlement">settlement.</param>
        public SettlementWebhookDataEntity(SettlementEntity? settlement = default(SettlementEntity?))
        {
            this.settlement = settlement;
        }

        /// <summary>
        /// Gets or Sets settlement
        /// </summary>
        [DataMember(Name = "settlement", EmitDefaultValue = false)]
        public SettlementEntity? settlement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SettlementWebhookDataEntity {\n");
            sb.Append("  settlement: ").Append(settlement).Append("\n");
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
            return this.Equals(input as SettlementWebhookDataEntity);
        }

        /// <summary>
        /// Returns true if SettlementWebhookDataEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of SettlementWebhookDataEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettlementWebhookDataEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.settlement == input.settlement ||
                    (this.settlement != null &&
                    this.settlement.Equals(input.settlement))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringsettlement) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringsettlement);
            if (deserializedJsonString.ContainsKey("settlement")) {
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
                if (this.settlement != null)
                {
                    hashCode = (hashCode * 59) + this.settlement.GetHashCode();
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

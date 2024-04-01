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
    /// Specify either the Settlement ID, Settlement UTR, or start date and end date to fetch the settlement details.
    /// </summary>
    [DataContract(Name = "FetchSettlementsRequest_filters")]
    public class FetchSettlementsRequestFilters : IEquatable<FetchSettlementsRequestFilters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FetchSettlementsRequestFilters" /> class.
        /// </summary>
        /// <param name="cfSettlementIds">List of settlement IDs for which you want the settlement reconciliation details..</param>
        /// <param name="settlementUtrs">List of settlement UTRs for which you want the settlement reconciliation details..</param>
        /// <param name="startDate">Specify the start date from when you want the settlement reconciliation details..</param>
        /// <param name="endDate">Specify the end date till when you want the settlement reconciliation details..</param>
        public FetchSettlementsRequestFilters(List<string>? cfSettlementIds = default(List<string>?), List<string>? settlementUtrs = default(List<string>?), string? startDate = default(string?), string? endDate = default(string?))
        {
            this.cf_settlement_ids = cfSettlementIds;
            this.settlement_utrs = settlementUtrs;
            this.start_date = startDate;
            this.end_date = endDate;
        }

        /// <summary>
        /// List of settlement IDs for which you want the settlement reconciliation details.
        /// </summary>
        /// <value>List of settlement IDs for which you want the settlement reconciliation details.</value>
        [DataMember(Name = "cf_settlement_ids", EmitDefaultValue = false)]
        public List<string>? cf_settlement_ids { get; set; }

        /// <summary>
        /// List of settlement UTRs for which you want the settlement reconciliation details.
        /// </summary>
        /// <value>List of settlement UTRs for which you want the settlement reconciliation details.</value>
        [DataMember(Name = "settlement_utrs", EmitDefaultValue = false)]
        public List<string>? settlement_utrs { get; set; }

        /// <summary>
        /// Specify the start date from when you want the settlement reconciliation details.
        /// </summary>
        /// <value>Specify the start date from when you want the settlement reconciliation details.</value>
        [DataMember(Name = "start_date", EmitDefaultValue = false)]
        public string? start_date { get; set; }

        /// <summary>
        /// Specify the end date till when you want the settlement reconciliation details.
        /// </summary>
        /// <value>Specify the end date till when you want the settlement reconciliation details.</value>
        [DataMember(Name = "end_date", EmitDefaultValue = false)]
        public string? end_date { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FetchSettlementsRequestFilters {\n");
            sb.Append("  cf_settlement_ids: ").Append(cf_settlement_ids).Append("\n");
            sb.Append("  settlement_utrs: ").Append(settlement_utrs).Append("\n");
            sb.Append("  start_date: ").Append(start_date).Append("\n");
            sb.Append("  end_date: ").Append(end_date).Append("\n");
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
            return this.Equals(input as FetchSettlementsRequestFilters);
        }

        /// <summary>
        /// Returns true if FetchSettlementsRequestFilters instances are equal
        /// </summary>
        /// <param name="input">Instance of FetchSettlementsRequestFilters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FetchSettlementsRequestFilters input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cf_settlement_ids == input.cf_settlement_ids ||
                    this.cf_settlement_ids != null &&
                    input.cf_settlement_ids != null &&
                    this.cf_settlement_ids.SequenceEqual(input.cf_settlement_ids)
                ) && 
                (
                    this.settlement_utrs == input.settlement_utrs ||
                    this.settlement_utrs != null &&
                    input.settlement_utrs != null &&
                    this.settlement_utrs.SequenceEqual(input.settlement_utrs)
                ) && 
                (
                    this.start_date == input.start_date ||
                    (this.start_date != null &&
                    this.start_date.Equals(input.start_date))
                ) && 
                (
                    this.end_date == input.end_date ||
                    (this.end_date != null &&
                    this.end_date.Equals(input.end_date))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringcf_settlement_ids) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringcf_settlement_ids);
            if (deserializedJsonString.ContainsKey("cf_settlement_ids")) {
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
                if (this.cf_settlement_ids != null)
                {
                    hashCode = (hashCode * 59) + this.cf_settlement_ids.GetHashCode();
                }
                if (this.settlement_utrs != null)
                {
                    hashCode = (hashCode * 59) + this.settlement_utrs.GetHashCode();
                }
                if (this.start_date != null)
                {
                    hashCode = (hashCode * 59) + this.start_date.GetHashCode();
                }
                if (this.end_date != null)
                {
                    hashCode = (hashCode * 59) + this.end_date.GetHashCode();
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

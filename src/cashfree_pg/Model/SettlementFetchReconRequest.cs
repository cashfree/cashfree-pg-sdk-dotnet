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
    /// Recon Request Object
    /// </summary>
    [DataContract(Name = "SettlementFetchReconRequest")]
    public class SettlementFetchReconRequest : IEquatable<SettlementFetchReconRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SettlementFetchReconRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SettlementFetchReconRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SettlementFetchReconRequest" /> class.
        /// </summary>
        /// <param name="pagination">pagination (required).</param>
        /// <param name="filters">filters (required).</param>
        public SettlementFetchReconRequest(FetchSettlementsRequestPagination pagination = default(FetchSettlementsRequestPagination), FetchSettlementsRequestFilters filters = default(FetchSettlementsRequestFilters))
        {
            // to ensure "pagination" is required (not null)
            if (pagination == null)
            {
                throw new ArgumentNullException("pagination is a required property for SettlementFetchReconRequest and cannot be null");
            }
            this.pagination = pagination;
            // to ensure "filters" is required (not null)
            if (filters == null)
            {
                throw new ArgumentNullException("filters is a required property for SettlementFetchReconRequest and cannot be null");
            }
            this.filters = filters;
        }

        /// <summary>
        /// Gets or Sets pagination
        /// </summary>
        [DataMember(Name = "pagination", IsRequired = true, EmitDefaultValue = true)]
        public FetchSettlementsRequestPagination pagination { get; set; }

        /// <summary>
        /// Gets or Sets filters
        /// </summary>
        [DataMember(Name = "filters", IsRequired = true, EmitDefaultValue = true)]
        public FetchSettlementsRequestFilters filters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SettlementFetchReconRequest {\n");
            sb.Append("  pagination: ").Append(pagination).Append("\n");
            sb.Append("  filters: ").Append(filters).Append("\n");
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
            return this.Equals(input as SettlementFetchReconRequest);
        }

        /// <summary>
        /// Returns true if SettlementFetchReconRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of SettlementFetchReconRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SettlementFetchReconRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.pagination == input.pagination ||
                    (this.pagination != null &&
                    this.pagination.Equals(input.pagination))
                ) && 
                (
                    this.filters == input.filters ||
                    (this.filters != null &&
                    this.filters.Equals(input.filters))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringpagination) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringpagination);
            if (deserializedJsonString.ContainsKey("pagination")) {
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
                if (this.pagination != null)
                {
                    hashCode = (hashCode * 59) + this.pagination.GetHashCode();
                }
                if (this.filters != null)
                {
                    hashCode = (hashCode * 59) + this.filters.GetHashCode();
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

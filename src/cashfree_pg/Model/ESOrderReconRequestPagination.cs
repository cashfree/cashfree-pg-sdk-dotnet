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
    /// Set limit based on your requirement. Pagination limit will fetch a set of orders, next set of orders can be generated using the cursor shared in previous response of the same API.
    /// </summary>
    [DataContract(Name = "ESOrderReconRequest_pagination")]
    public class ESOrderReconRequestPagination : IEquatable<ESOrderReconRequestPagination>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ESOrderReconRequestPagination" /> class.
        /// </summary>
        /// <param name="cursor">cursor.</param>
        /// <param name="limit">Set the minimum/maximum limit for number of filtered data. Min value - 10, Max value - 100..</param>
        public ESOrderReconRequestPagination(string cursor = default(string), int limit = default(int))
        {
            this.cursor = cursor;
            this.limit = limit;
        }

        /// <summary>
        /// Gets or Sets cursor
        /// </summary>
        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        public string cursor { get; set; }

        /// <summary>
        /// Set the minimum/maximum limit for number of filtered data. Min value - 10, Max value - 100.
        /// </summary>
        /// <value>Set the minimum/maximum limit for number of filtered data. Min value - 10, Max value - 100.</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ESOrderReconRequestPagination {\n");
            sb.Append("  cursor: ").Append(cursor).Append("\n");
            sb.Append("  limit: ").Append(limit).Append("\n");
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
            return this.Equals(input as ESOrderReconRequestPagination);
        }

        /// <summary>
        /// Returns true if ESOrderReconRequestPagination instances are equal
        /// </summary>
        /// <param name="input">Instance of ESOrderReconRequestPagination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ESOrderReconRequestPagination input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cursor == input.cursor ||
                    (this.cursor != null &&
                    this.cursor.Equals(input.cursor))
                ) && 
                (
                    this.limit == input.limit ||
                    this.limit.Equals(input.limit)
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringcursor) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringcursor);
            if (deserializedJsonString.ContainsKey("cursor")) {
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
                if (this.cursor != null)
                {
                    hashCode = (hashCode * 59) + this.cursor.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.limit.GetHashCode();
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

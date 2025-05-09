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
    /// To fetch the next set of settlements, pass the cursor received in the response to the next API call.   To receive the data for the first time, pass the cursor as null.   Limit would be number of settlements that you want to receive.
    /// </summary>
    [DataContract(Name = "FetchSettlementsRequest_pagination")]
    public class FetchSettlementsRequestPagination : IEquatable<FetchSettlementsRequestPagination>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FetchSettlementsRequestPagination" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FetchSettlementsRequestPagination() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FetchSettlementsRequestPagination" /> class.
        /// </summary>
        /// <param name="limit">The number of settlements you want to fetch. Maximum limit is 1000, default value is 10. (required).</param>
        /// <param name="cursor">Specifies from where the next set of settlement details should be fetched..</param>
        public FetchSettlementsRequestPagination(int limit = default(int), string? cursor = default(string?))
        {
            this.limit = limit;
            this.cursor = cursor;
        }

        /// <summary>
        /// The number of settlements you want to fetch. Maximum limit is 1000, default value is 10.
        /// </summary>
        /// <value>The number of settlements you want to fetch. Maximum limit is 1000, default value is 10.</value>
        [DataMember(Name = "limit", IsRequired = true, EmitDefaultValue = true)]
        public int limit { get; set; }

        /// <summary>
        /// Specifies from where the next set of settlement details should be fetched.
        /// </summary>
        /// <value>Specifies from where the next set of settlement details should be fetched.</value>
        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        public string? cursor { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FetchSettlementsRequestPagination {\n");
            sb.Append("  limit: ").Append(limit).Append("\n");
            sb.Append("  cursor: ").Append(cursor).Append("\n");
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
            return this.Equals(input as FetchSettlementsRequestPagination);
        }

        /// <summary>
        /// Returns true if FetchSettlementsRequestPagination instances are equal
        /// </summary>
        /// <param name="input">Instance of FetchSettlementsRequestPagination to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FetchSettlementsRequestPagination input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.limit == input.limit ||
                    this.limit.Equals(input.limit)
                ) && 
                (
                    this.cursor == input.cursor ||
                    (this.cursor != null &&
                    this.cursor.Equals(input.cursor))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringlimit) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringlimit);
            if (deserializedJsonString.ContainsKey("limit")) {
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
                hashCode = (hashCode * 59) + this.limit.GetHashCode();
                if (this.cursor != null)
                {
                    hashCode = (hashCode * 59) + this.cursor.GetHashCode();
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

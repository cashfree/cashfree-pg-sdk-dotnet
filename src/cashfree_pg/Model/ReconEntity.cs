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
    /// Settlement detailed recon response
    /// </summary>
    [DataContract(Name = "ReconEntity")]
    public class ReconEntity : IEquatable<ReconEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReconEntity" /> class.
        /// </summary>
        /// <param name="cursor">Specifies from where the next set of settlement details should be fetched..</param>
        /// <param name="limit">Number of settlements you want to fetch in the next iteration..</param>
        /// <param name="data">data.</param>
        public ReconEntity(string? cursor = default(string?), int? limit = default(int?), List<ReconEntityDataInner>? data = default(List<ReconEntityDataInner>?))
        {
            this.cursor = cursor;
            this.limit = limit;
            this.data = data;
        }

        /// <summary>
        /// Specifies from where the next set of settlement details should be fetched.
        /// </summary>
        /// <value>Specifies from where the next set of settlement details should be fetched.</value>
        [DataMember(Name = "cursor", EmitDefaultValue = false)]
        public string? cursor { get; set; }

        /// <summary>
        /// Number of settlements you want to fetch in the next iteration.
        /// </summary>
        /// <value>Number of settlements you want to fetch in the next iteration.</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int? limit { get; set; }

        /// <summary>
        /// Gets or Sets data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<ReconEntityDataInner>? data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReconEntity {\n");
            sb.Append("  cursor: ").Append(cursor).Append("\n");
            sb.Append("  limit: ").Append(limit).Append("\n");
            sb.Append("  data: ").Append(data).Append("\n");
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
            return this.Equals(input as ReconEntity);
        }

        /// <summary>
        /// Returns true if ReconEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of ReconEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReconEntity input)
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
                ) && 
                (
                    this.data == input.data ||
                    this.data != null &&
                    input.data != null &&
                    this.data.SequenceEqual(input.data)
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
                if (this.data != null)
                {
                    hashCode = (hashCode * 59) + this.data.GetHashCode();
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

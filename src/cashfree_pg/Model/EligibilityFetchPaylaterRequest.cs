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
    /// Request to get eligible paylater payment methods
    /// </summary>
    [DataContract(Name = "EligibilityFetchPaylaterRequest")]
    public class EligibilityFetchPaylaterRequest : IEquatable<EligibilityFetchPaylaterRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EligibilityFetchPaylaterRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EligibilityFetchPaylaterRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EligibilityFetchPaylaterRequest" /> class.
        /// </summary>
        /// <param name="queries">queries (required).</param>
        public EligibilityFetchPaylaterRequest(CardlessEMIQueries queries = default(CardlessEMIQueries))
        {
            // to ensure "queries" is required (not null)
            if (queries == null)
            {
                throw new ArgumentNullException("queries is a required property for EligibilityFetchPaylaterRequest and cannot be null");
            }
            this.queries = queries;
        }

        /// <summary>
        /// Gets or Sets queries
        /// </summary>
        [DataMember(Name = "queries", IsRequired = true, EmitDefaultValue = true)]
        public CardlessEMIQueries queries { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EligibilityFetchPaylaterRequest {\n");
            sb.Append("  queries: ").Append(queries).Append("\n");
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
            return this.Equals(input as EligibilityFetchPaylaterRequest);
        }

        /// <summary>
        /// Returns true if EligibilityFetchPaylaterRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EligibilityFetchPaylaterRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EligibilityFetchPaylaterRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.queries == input.queries ||
                    (this.queries != null &&
                    this.queries.Equals(input.queries))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringqueries) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringqueries);
            if (deserializedJsonString.ContainsKey("queries")) {
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
                if (this.queries != null)
                {
                    hashCode = (hashCode * 59) + this.queries.GetHashCode();
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

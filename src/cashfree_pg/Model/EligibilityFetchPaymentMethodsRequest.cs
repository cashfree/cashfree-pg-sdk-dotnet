/*
 * Cashfree Payment Gateway APIs
 *
 * Cashfree's Payment Gateway APIs provide developers with a streamlined pathway to integrate advanced payment processing capabilities into their applications, platforms and websites.
 *
 * The version of the OpenAPI document: 2022-09-01
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
    /// eligibilty request to find eligible payment method
    /// </summary>
    [DataContract(Name = "EligibilityFetchPaymentMethodsRequest")]
    public class EligibilityFetchPaymentMethodsRequest : IEquatable<EligibilityFetchPaymentMethodsRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EligibilityFetchPaymentMethodsRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EligibilityFetchPaymentMethodsRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EligibilityFetchPaymentMethodsRequest" /> class.
        /// </summary>
        /// <param name="queries">queries (required).</param>
        /// <param name="filters">filters.</param>
        public EligibilityFetchPaymentMethodsRequest(PaymentMethodsQueries queries = default(PaymentMethodsQueries), PaymentMethodsFilters filters = default(PaymentMethodsFilters))
        {
            // to ensure "queries" is required (not null)
            if (queries == null)
            {
                throw new ArgumentNullException("queries is a required property for EligibilityFetchPaymentMethodsRequest and cannot be null");
            }
            this.queries = queries;
            this.filters = filters;
        }

        /// <summary>
        /// Gets or Sets queries
        /// </summary>
        [DataMember(Name = "queries", IsRequired = true, EmitDefaultValue = true)]
        public PaymentMethodsQueries queries { get; set; }

        /// <summary>
        /// Gets or Sets filters
        /// </summary>
        [DataMember(Name = "filters", EmitDefaultValue = false)]
        public PaymentMethodsFilters filters { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EligibilityFetchPaymentMethodsRequest {\n");
            sb.Append("  queries: ").Append(queries).Append("\n");
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
            return this.Equals(input as EligibilityFetchPaymentMethodsRequest);
        }

        /// <summary>
        /// Returns true if EligibilityFetchPaymentMethodsRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of EligibilityFetchPaymentMethodsRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EligibilityFetchPaymentMethodsRequest input)
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
                ) && 
                (
                    this.filters == input.filters ||
                    (this.filters != null &&
                    this.filters.Equals(input.filters))
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
                if (this.queries != null)
                {
                    hashCode = (hashCode * 59) + this.queries.GetHashCode();
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
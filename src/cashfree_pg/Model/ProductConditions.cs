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
    /// ProductConditions
    /// </summary>
    [DataContract(Name = "ProductConditions")]
    public class ProductConditions : IEquatable<ProductConditions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductConditions" /> class.
        /// </summary>
        /// <param name="action">The Action key in the conditions array specifies whether a condition should \&quot;ALLOW\&quot; or \&quot;DENY\&quot; the specified rule or feature.</param>
        /// <param name="key">Specify what you&#39;re trying to configure, such as \&quot;features\&quot;.</param>
        /// <param name="values">Define the values you need to set within the conditions in this array, such as \&quot;checkoutCollectAddress\&quot;, \&quot;checkoutAuthenticate\&quot;.</param>
        public ProductConditions(string? action = default(string?), string? key = default(string?), List<string>? values = default(List<string>?))
        {
            this.action = action;
            this.key = key;
            this.values = values;
        }

        /// <summary>
        /// The Action key in the conditions array specifies whether a condition should \&quot;ALLOW\&quot; or \&quot;DENY\&quot; the specified rule or feature
        /// </summary>
        /// <value>The Action key in the conditions array specifies whether a condition should \&quot;ALLOW\&quot; or \&quot;DENY\&quot; the specified rule or feature</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string? action { get; set; }

        /// <summary>
        /// Specify what you&#39;re trying to configure, such as \&quot;features\&quot;
        /// </summary>
        /// <value>Specify what you&#39;re trying to configure, such as \&quot;features\&quot;</value>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string? key { get; set; }

        /// <summary>
        /// Define the values you need to set within the conditions in this array, such as \&quot;checkoutCollectAddress\&quot;, \&quot;checkoutAuthenticate\&quot;
        /// </summary>
        /// <value>Define the values you need to set within the conditions in this array, such as \&quot;checkoutCollectAddress\&quot;, \&quot;checkoutAuthenticate\&quot;</value>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public List<string>? values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProductConditions {\n");
            sb.Append("  action: ").Append(action).Append("\n");
            sb.Append("  key: ").Append(key).Append("\n");
            sb.Append("  values: ").Append(values).Append("\n");
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
            return this.Equals(input as ProductConditions);
        }

        /// <summary>
        /// Returns true if ProductConditions instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductConditions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.action == input.action ||
                    (this.action != null &&
                    this.action.Equals(input.action))
                ) && 
                (
                    this.key == input.key ||
                    (this.key != null &&
                    this.key.Equals(input.key))
                ) && 
                (
                    this.values == input.values ||
                    this.values != null &&
                    input.values != null &&
                    this.values.SequenceEqual(input.values)
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringaction) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringaction);
            if (deserializedJsonString.ContainsKey("action")) {
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
                if (this.action != null)
                {
                    hashCode = (hashCode * 59) + this.action.GetHashCode();
                }
                if (this.key != null)
                {
                    hashCode = (hashCode * 59) + this.key.GetHashCode();
                }
                if (this.values != null)
                {
                    hashCode = (hashCode * 59) + this.values.GetHashCode();
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
            // key (string) maxLength
            if (this.key != null && this.key.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for key, length must be less than 50.", new [] { "key" });
            }

            yield break;
        }
    }

}

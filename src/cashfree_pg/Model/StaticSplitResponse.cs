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
    /// Static Split Response
    /// </summary>
    [DataContract(Name = "StaticSplitResponse")]
    public class StaticSplitResponse : IEquatable<StaticSplitResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StaticSplitResponse" /> class.
        /// </summary>
        /// <param name="active">active.</param>
        /// <param name="terminalId">terminalId.</param>
        /// <param name="terminalReferenceId">terminalReferenceId.</param>
        /// <param name="productType">productType.</param>
        /// <param name="scheme">scheme.</param>
        /// <param name="addedOn">addedOn.</param>
        public StaticSplitResponse(bool active = default(bool), string terminalId = default(string), decimal terminalReferenceId = default(decimal), string productType = default(string), List<StaticSplitResponseSchemeInner> scheme = default(List<StaticSplitResponseSchemeInner>), string addedOn = default(string))
        {
            this.active = active;
            this.terminal_id = terminalId;
            this.terminal_reference_id = terminalReferenceId;
            this.product_type = productType;
            this.scheme = scheme;
            this.added_on = addedOn;
        }

        /// <summary>
        /// Gets or Sets active
        /// </summary>
        [DataMember(Name = "active", EmitDefaultValue = true)]
        public bool active { get; set; }

        /// <summary>
        /// Gets or Sets terminal_id
        /// </summary>
        [DataMember(Name = "terminal_id", EmitDefaultValue = false)]
        public string terminal_id { get; set; }

        /// <summary>
        /// Gets or Sets terminal_reference_id
        /// </summary>
        [DataMember(Name = "terminal_reference_id", EmitDefaultValue = false)]
        public decimal terminal_reference_id { get; set; }

        /// <summary>
        /// Gets or Sets product_type
        /// </summary>
        [DataMember(Name = "product_type", EmitDefaultValue = false)]
        public string product_type { get; set; }

        /// <summary>
        /// Gets or Sets scheme
        /// </summary>
        [DataMember(Name = "scheme", EmitDefaultValue = false)]
        public List<StaticSplitResponseSchemeInner> scheme { get; set; }

        /// <summary>
        /// Gets or Sets added_on
        /// </summary>
        [DataMember(Name = "added_on", EmitDefaultValue = false)]
        public string added_on { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StaticSplitResponse {\n");
            sb.Append("  active: ").Append(active).Append("\n");
            sb.Append("  terminal_id: ").Append(terminal_id).Append("\n");
            sb.Append("  terminal_reference_id: ").Append(terminal_reference_id).Append("\n");
            sb.Append("  product_type: ").Append(product_type).Append("\n");
            sb.Append("  scheme: ").Append(scheme).Append("\n");
            sb.Append("  added_on: ").Append(added_on).Append("\n");
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
            return this.Equals(input as StaticSplitResponse);
        }

        /// <summary>
        /// Returns true if StaticSplitResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of StaticSplitResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StaticSplitResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.active == input.active ||
                    this.active.Equals(input.active)
                ) && 
                (
                    this.terminal_id == input.terminal_id ||
                    (this.terminal_id != null &&
                    this.terminal_id.Equals(input.terminal_id))
                ) && 
                (
                    this.terminal_reference_id == input.terminal_reference_id ||
                    this.terminal_reference_id.Equals(input.terminal_reference_id)
                ) && 
                (
                    this.product_type == input.product_type ||
                    (this.product_type != null &&
                    this.product_type.Equals(input.product_type))
                ) && 
                (
                    this.scheme == input.scheme ||
                    this.scheme != null &&
                    input.scheme != null &&
                    this.scheme.SequenceEqual(input.scheme)
                ) && 
                (
                    this.added_on == input.added_on ||
                    (this.added_on != null &&
                    this.added_on.Equals(input.added_on))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringactive) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringactive);
            if (deserializedJsonString.ContainsKey("active")) {
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
                hashCode = (hashCode * 59) + this.active.GetHashCode();
                if (this.terminal_id != null)
                {
                    hashCode = (hashCode * 59) + this.terminal_id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.terminal_reference_id.GetHashCode();
                if (this.product_type != null)
                {
                    hashCode = (hashCode * 59) + this.product_type.GetHashCode();
                }
                if (this.scheme != null)
                {
                    hashCode = (hashCode * 59) + this.scheme.GetHashCode();
                }
                if (this.added_on != null)
                {
                    hashCode = (hashCode * 59) + this.added_on.GetHashCode();
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

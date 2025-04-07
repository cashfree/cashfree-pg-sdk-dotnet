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
    /// SplitAfterPaymentRequestSplitInner
    /// </summary>
    [DataContract(Name = "SplitAfterPaymentRequest_split_inner")]
    public class SplitAfterPaymentRequestSplitInner : IEquatable<SplitAfterPaymentRequestSplitInner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SplitAfterPaymentRequestSplitInner" /> class.
        /// </summary>
        /// <param name="vendorId">Specify the merchant vendor ID to split the payment..</param>
        /// <param name="amount">Specify the amount to be split to the vendor..</param>
        /// <param name="percentage">Specify the percentage of amount to be split..</param>
        /// <param name="tags">Custom Tags in thr form of {\&quot;key\&quot;:\&quot;value\&quot;} which can be passed for an order. A maximum of 10 tags can be added.</param>
        public SplitAfterPaymentRequestSplitInner(string? vendorId = default(string?), decimal? amount = default(decimal?), decimal? percentage = default(decimal?), Dictionary<string, string>? tags = default(Dictionary<string, string>?))
        {
            this.vendor_id = vendorId;
            this.amount = amount;
            this.percentage = percentage;
            this.tags = tags;
        }

        /// <summary>
        /// Specify the merchant vendor ID to split the payment.
        /// </summary>
        /// <value>Specify the merchant vendor ID to split the payment.</value>
        [DataMember(Name = "vendor_id", EmitDefaultValue = false)]
        public string? vendor_id { get; set; }

        /// <summary>
        /// Specify the amount to be split to the vendor.
        /// </summary>
        /// <value>Specify the amount to be split to the vendor.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal? amount { get; set; }

        /// <summary>
        /// Specify the percentage of amount to be split.
        /// </summary>
        /// <value>Specify the percentage of amount to be split.</value>
        [DataMember(Name = "percentage", EmitDefaultValue = false)]
        public decimal? percentage { get; set; }

        /// <summary>
        /// Custom Tags in thr form of {\&quot;key\&quot;:\&quot;value\&quot;} which can be passed for an order. A maximum of 10 tags can be added
        /// </summary>
        /// <value>Custom Tags in thr form of {\&quot;key\&quot;:\&quot;value\&quot;} which can be passed for an order. A maximum of 10 tags can be added</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public Dictionary<string, string>? tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SplitAfterPaymentRequestSplitInner {\n");
            sb.Append("  vendor_id: ").Append(vendor_id).Append("\n");
            sb.Append("  amount: ").Append(amount).Append("\n");
            sb.Append("  percentage: ").Append(percentage).Append("\n");
            sb.Append("  tags: ").Append(tags).Append("\n");
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
            return this.Equals(input as SplitAfterPaymentRequestSplitInner);
        }

        /// <summary>
        /// Returns true if SplitAfterPaymentRequestSplitInner instances are equal
        /// </summary>
        /// <param name="input">Instance of SplitAfterPaymentRequestSplitInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SplitAfterPaymentRequestSplitInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vendor_id == input.vendor_id ||
                    (this.vendor_id != null &&
                    this.vendor_id.Equals(input.vendor_id))
                ) && 
                (
                    this.amount == input.amount ||
                    this.amount.Equals(input.amount)
                ) && 
                (
                    this.percentage == input.percentage ||
                    this.percentage.Equals(input.percentage)
                ) && 
                (
                    this.tags == input.tags ||
                    this.tags != null &&
                    input.tags != null &&
                    this.tags.SequenceEqual(input.tags)
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringvendor_id) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringvendor_id);
            if (deserializedJsonString.ContainsKey("vendor_id")) {
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
                if (this.vendor_id != null)
                {
                    hashCode = (hashCode * 59) + this.vendor_id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.amount.GetHashCode();
                hashCode = (hashCode * 59) + this.percentage.GetHashCode();
                if (this.tags != null)
                {
                    hashCode = (hashCode * 59) + this.tags.GetHashCode();
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

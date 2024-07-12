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
    /// Subscription Payment Split Item
    /// </summary>
    [DataContract(Name = "SubscriptionPaymentSplitItem")]
    public class SubscriptionPaymentSplitItem : IEquatable<SubscriptionPaymentSplitItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionPaymentSplitItem" /> class.
        /// </summary>
        /// <param name="vendorId">Vendor ID.</param>
        /// <param name="percentage">Percentage of the payment to be split to vendor.</param>
        public SubscriptionPaymentSplitItem(string? vendorId = default(string?), decimal? percentage = default(decimal?))
        {
            this.vendor_id = vendorId;
            this.percentage = percentage;
        }

        /// <summary>
        /// Vendor ID
        /// </summary>
        /// <value>Vendor ID</value>
        [DataMember(Name = "vendor_id", EmitDefaultValue = false)]
        public string? vendor_id { get; set; }

        /// <summary>
        /// Percentage of the payment to be split to vendor
        /// </summary>
        /// <value>Percentage of the payment to be split to vendor</value>
        [DataMember(Name = "percentage", EmitDefaultValue = false)]
        public decimal? percentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionPaymentSplitItem {\n");
            sb.Append("  vendor_id: ").Append(vendor_id).Append("\n");
            sb.Append("  percentage: ").Append(percentage).Append("\n");
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
            return this.Equals(input as SubscriptionPaymentSplitItem);
        }

        /// <summary>
        /// Returns true if SubscriptionPaymentSplitItem instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionPaymentSplitItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionPaymentSplitItem input)
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
                    this.percentage == input.percentage ||
                    this.percentage.Equals(input.percentage)
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
                hashCode = (hashCode * 59) + this.percentage.GetHashCode();
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

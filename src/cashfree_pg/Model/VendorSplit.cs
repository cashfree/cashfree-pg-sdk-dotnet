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
    /// Use to split order when cashfree&#39;s Easy Split is enabled for your account.
    /// </summary>
    [DataContract(Name = "VendorSplit")]
    public class VendorSplit : IEquatable<VendorSplit>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorSplit" /> class.
        /// </summary>
        /// <param name="vendorId">Vendor id created in Cashfree system.</param>
        /// <param name="amount">Amount which will be associated with this vendor.</param>
        /// <param name="percentage">Percentage of order amount which shall get added to vendor account.</param>
        public VendorSplit(string vendorId = default(string), decimal amount = default(decimal), decimal percentage = default(decimal))
        {
            this.vendor_id = vendorId;
            this.amount = amount;
            this.percentage = percentage;
        }

        /// <summary>
        /// Vendor id created in Cashfree system
        /// </summary>
        /// <value>Vendor id created in Cashfree system</value>
        [DataMember(Name = "vendor_id", EmitDefaultValue = false)]
        public string vendor_id { get; set; }

        /// <summary>
        /// Amount which will be associated with this vendor
        /// </summary>
        /// <value>Amount which will be associated with this vendor</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal amount { get; set; }

        /// <summary>
        /// Percentage of order amount which shall get added to vendor account
        /// </summary>
        /// <value>Percentage of order amount which shall get added to vendor account</value>
        [DataMember(Name = "percentage", EmitDefaultValue = false)]
        public decimal percentage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VendorSplit {\n");
            sb.Append("  vendor_id: ").Append(vendor_id).Append("\n");
            sb.Append("  amount: ").Append(amount).Append("\n");
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
            return this.Equals(input as VendorSplit);
        }

        /// <summary>
        /// Returns true if VendorSplit instances are equal
        /// </summary>
        /// <param name="input">Instance of VendorSplit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VendorSplit input)
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
                if (this.vendor_id != null)
                {
                    hashCode = (hashCode * 59) + this.vendor_id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.amount.GetHashCode();
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

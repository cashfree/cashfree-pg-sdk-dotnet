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
    /// detils of the discount object of offer
    /// </summary>
    [DataContract(Name = "DiscountDetails")]
    public class DiscountDetails : IEquatable<DiscountDetails>, IValidatableObject
    {
        /// <summary>
        /// Type of discount
        /// </summary>
        /// <value>Type of discount</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DiscountTypeEnum
        {
            /// <summary>
            /// Enum Flat for value: flat
            /// </summary>
            [EnumMember(Value = "flat")]
            Flat = 1,

            /// <summary>
            /// Enum Percentage for value: percentage
            /// </summary>
            [EnumMember(Value = "percentage")]
            Percentage = 2
        }


        /// <summary>
        /// Type of discount
        /// </summary>
        /// <value>Type of discount</value>
        [DataMember(Name = "discount_type", IsRequired = true, EmitDefaultValue = true)]
        public DiscountTypeEnum discount_type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DiscountDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountDetails" /> class.
        /// </summary>
        /// <param name="discountType">Type of discount (required).</param>
        /// <param name="discountValue">Value of Discount. (required).</param>
        /// <param name="maxDiscountAmount">Maximum Value of Discount allowed. (required).</param>
        public DiscountDetails(DiscountTypeEnum discountType = default(DiscountTypeEnum), string discountValue = default(string), string maxDiscountAmount = default(string))
        {
            this.discount_type = discountType;
            // to ensure "discountValue" is required (not null)
            if (discountValue == null)
            {
                throw new ArgumentNullException("discountValue is a required property for DiscountDetails and cannot be null");
            }
            this.discount_value = discountValue;
            // to ensure "maxDiscountAmount" is required (not null)
            if (maxDiscountAmount == null)
            {
                throw new ArgumentNullException("maxDiscountAmount is a required property for DiscountDetails and cannot be null");
            }
            this.max_discount_amount = maxDiscountAmount;
        }

        /// <summary>
        /// Value of Discount.
        /// </summary>
        /// <value>Value of Discount.</value>
        [DataMember(Name = "discount_value", IsRequired = true, EmitDefaultValue = true)]
        public string discount_value { get; set; }

        /// <summary>
        /// Maximum Value of Discount allowed.
        /// </summary>
        /// <value>Maximum Value of Discount allowed.</value>
        [DataMember(Name = "max_discount_amount", IsRequired = true, EmitDefaultValue = true)]
        public string max_discount_amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiscountDetails {\n");
            sb.Append("  discount_type: ").Append(discount_type).Append("\n");
            sb.Append("  discount_value: ").Append(discount_value).Append("\n");
            sb.Append("  max_discount_amount: ").Append(max_discount_amount).Append("\n");
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
            return this.Equals(input as DiscountDetails);
        }

        /// <summary>
        /// Returns true if DiscountDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of DiscountDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscountDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.discount_type == input.discount_type ||
                    this.discount_type.Equals(input.discount_type)
                ) && 
                (
                    this.discount_value == input.discount_value ||
                    (this.discount_value != null &&
                    this.discount_value.Equals(input.discount_value))
                ) && 
                (
                    this.max_discount_amount == input.max_discount_amount ||
                    (this.max_discount_amount != null &&
                    this.max_discount_amount.Equals(input.max_discount_amount))
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
                hashCode = (hashCode * 59) + this.discount_type.GetHashCode();
                if (this.discount_value != null)
                {
                    hashCode = (hashCode * 59) + this.discount_value.GetHashCode();
                }
                if (this.max_discount_amount != null)
                {
                    hashCode = (hashCode * 59) + this.max_discount_amount.GetHashCode();
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
            // discount_value (string) maxLength
            if (this.discount_value != null && this.discount_value.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for discount_value, length must be less than 100.", new [] { "discount_value" });
            }

            // discount_value (string) minLength
            if (this.discount_value != null && this.discount_value.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for discount_value, length must be greater than 1.", new [] { "discount_value" });
            }

            // max_discount_amount (string) maxLength
            if (this.max_discount_amount != null && this.max_discount_amount.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for max_discount_amount, length must be less than 100.", new [] { "max_discount_amount" });
            }

            // max_discount_amount (string) minLength
            if (this.max_discount_amount != null && this.max_discount_amount.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for max_discount_amount, length must be greater than 1.", new [] { "max_discount_amount" });
            }

            yield break;
        }
    }

}

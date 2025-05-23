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
    /// Cashback detail boject
    /// </summary>
    [DataContract(Name = "CashbackDetails")]
    public class CashbackDetails : IEquatable<CashbackDetails>, IValidatableObject
    {
        /// <summary>
        /// Type of discount
        /// </summary>
        /// <value>Type of discount</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CashbackTypeEnum
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
        [DataMember(Name = "cashback_type", IsRequired = true, EmitDefaultValue = true)]
        public CashbackTypeEnum cashback_type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CashbackDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CashbackDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CashbackDetails" /> class.
        /// </summary>
        /// <param name="cashbackType">Type of discount (required).</param>
        /// <param name="cashbackValue">Value of Discount. (required).</param>
        /// <param name="maxCashbackAmount">Maximum Value of Cashback allowed. (required).</param>
        public CashbackDetails(CashbackTypeEnum cashbackType = default(CashbackTypeEnum), decimal cashbackValue = default(decimal), decimal maxCashbackAmount = default(decimal))
        {
            this.cashback_type = cashbackType;
            this.cashback_value = cashbackValue;
            this.max_cashback_amount = maxCashbackAmount;
        }

        /// <summary>
        /// Value of Discount.
        /// </summary>
        /// <value>Value of Discount.</value>
        [DataMember(Name = "cashback_value", IsRequired = true, EmitDefaultValue = true)]
        public decimal cashback_value { get; set; }

        /// <summary>
        /// Maximum Value of Cashback allowed.
        /// </summary>
        /// <value>Maximum Value of Cashback allowed.</value>
        [DataMember(Name = "max_cashback_amount", IsRequired = true, EmitDefaultValue = true)]
        public decimal max_cashback_amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CashbackDetails {\n");
            sb.Append("  cashback_type: ").Append(cashback_type).Append("\n");
            sb.Append("  cashback_value: ").Append(cashback_value).Append("\n");
            sb.Append("  max_cashback_amount: ").Append(max_cashback_amount).Append("\n");
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
            return this.Equals(input as CashbackDetails);
        }

        /// <summary>
        /// Returns true if CashbackDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CashbackDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CashbackDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cashback_type == input.cashback_type ||
                    this.cashback_type.Equals(input.cashback_type)
                ) && 
                (
                    this.cashback_value == input.cashback_value ||
                    this.cashback_value.Equals(input.cashback_value)
                ) && 
                (
                    this.max_cashback_amount == input.max_cashback_amount ||
                    this.max_cashback_amount.Equals(input.max_cashback_amount)
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
                hashCode = (hashCode * 59) + this.cashback_type.GetHashCode();
                hashCode = (hashCode * 59) + this.cashback_value.GetHashCode();
                hashCode = (hashCode * 59) + this.max_cashback_amount.GetHashCode();
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

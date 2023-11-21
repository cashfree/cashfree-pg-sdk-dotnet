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
    /// Single EMI object
    /// </summary>
    [DataContract(Name = "EMIPlansArray")]
    public class EMIPlansArray : IEquatable<EMIPlansArray>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EMIPlansArray" /> class.
        /// </summary>
        /// <param name="tenure">tenure.</param>
        /// <param name="interestRate">interestRate.</param>
        /// <param name="currency">currency.</param>
        /// <param name="emi">emi.</param>
        /// <param name="totalInterest">totalInterest.</param>
        /// <param name="totalAmount">totalAmount.</param>
        public EMIPlansArray(int tenure = default(int), decimal interestRate = default(decimal), string currency = default(string), int emi = default(int), int totalInterest = default(int), int totalAmount = default(int))
        {
            this.tenure = tenure;
            this.interest_rate = interestRate;
            this.currency = currency;
            this.emi = emi;
            this.total_interest = totalInterest;
            this.total_amount = totalAmount;
        }

        /// <summary>
        /// Gets or Sets tenure
        /// </summary>
        /// <example>3</example>
        [DataMember(Name = "tenure", EmitDefaultValue = false)]
        public int tenure { get; set; }

        /// <summary>
        /// Gets or Sets interest_rate
        /// </summary>
        /// <example>24</example>
        [DataMember(Name = "interest_rate", EmitDefaultValue = false)]
        public decimal interest_rate { get; set; }

        /// <summary>
        /// Gets or Sets currency
        /// </summary>
        /// <example>INR</example>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public string currency { get; set; }

        /// <summary>
        /// Gets or Sets emi
        /// </summary>
        /// <example>3468</example>
        [DataMember(Name = "emi", EmitDefaultValue = false)]
        public int emi { get; set; }

        /// <summary>
        /// Gets or Sets total_interest
        /// </summary>
        /// <example>404</example>
        [DataMember(Name = "total_interest", EmitDefaultValue = false)]
        public int total_interest { get; set; }

        /// <summary>
        /// Gets or Sets total_amount
        /// </summary>
        /// <example>10404</example>
        [DataMember(Name = "total_amount", EmitDefaultValue = false)]
        public int total_amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EMIPlansArray {\n");
            sb.Append("  tenure: ").Append(tenure).Append("\n");
            sb.Append("  interest_rate: ").Append(interest_rate).Append("\n");
            sb.Append("  currency: ").Append(currency).Append("\n");
            sb.Append("  emi: ").Append(emi).Append("\n");
            sb.Append("  total_interest: ").Append(total_interest).Append("\n");
            sb.Append("  total_amount: ").Append(total_amount).Append("\n");
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
            return this.Equals(input as EMIPlansArray);
        }

        /// <summary>
        /// Returns true if EMIPlansArray instances are equal
        /// </summary>
        /// <param name="input">Instance of EMIPlansArray to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EMIPlansArray input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.tenure == input.tenure ||
                    this.tenure.Equals(input.tenure)
                ) && 
                (
                    this.interest_rate == input.interest_rate ||
                    this.interest_rate.Equals(input.interest_rate)
                ) && 
                (
                    this.currency == input.currency ||
                    (this.currency != null &&
                    this.currency.Equals(input.currency))
                ) && 
                (
                    this.emi == input.emi ||
                    this.emi.Equals(input.emi)
                ) && 
                (
                    this.total_interest == input.total_interest ||
                    this.total_interest.Equals(input.total_interest)
                ) && 
                (
                    this.total_amount == input.total_amount ||
                    this.total_amount.Equals(input.total_amount)
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
                hashCode = (hashCode * 59) + this.tenure.GetHashCode();
                hashCode = (hashCode * 59) + this.interest_rate.GetHashCode();
                if (this.currency != null)
                {
                    hashCode = (hashCode * 59) + this.currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.emi.GetHashCode();
                hashCode = (hashCode * 59) + this.total_interest.GetHashCode();
                hashCode = (hashCode * 59) + this.total_amount.GetHashCode();
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
            // currency (string) maxLength
            if (this.currency != null && this.currency.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for currency, length must be less than 50.", new [] { "currency" });
            }

            // currency (string) minLength
            if (this.currency != null && this.currency.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for currency, length must be greater than 3.", new [] { "currency" });
            }

            yield break;
        }
    }

}
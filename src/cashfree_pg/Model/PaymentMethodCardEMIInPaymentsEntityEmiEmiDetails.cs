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
    /// PaymentMethodCardEMIInPaymentsEntityEmiEmiDetails
    /// </summary>
    [DataContract(Name = "PaymentMethodCardEMIInPaymentsEntity_emi_emi_details")]
    public class PaymentMethodCardEMIInPaymentsEntityEmiEmiDetails : IEquatable<PaymentMethodCardEMIInPaymentsEntityEmiEmiDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCardEMIInPaymentsEntityEmiEmiDetails" /> class.
        /// </summary>
        /// <param name="emiAmount">emiAmount.</param>
        /// <param name="emiTenure">emiTenure.</param>
        /// <param name="emiInterest">emiInterest.</param>
        public PaymentMethodCardEMIInPaymentsEntityEmiEmiDetails(decimal? emiAmount = default(decimal?), decimal? emiTenure = default(decimal?), decimal? emiInterest = default(decimal?))
        {
            this.emi_amount = emiAmount;
            this.emi_tenure = emiTenure;
            this.emi_interest = emiInterest;
        }

        /// <summary>
        /// Gets or Sets emi_amount
        /// </summary>
        [DataMember(Name = "emi_amount", EmitDefaultValue = false)]
        public decimal? emi_amount { get; set; }

        /// <summary>
        /// Gets or Sets emi_tenure
        /// </summary>
        [DataMember(Name = "emi_tenure", EmitDefaultValue = false)]
        public decimal? emi_tenure { get; set; }

        /// <summary>
        /// Gets or Sets emi_interest
        /// </summary>
        [DataMember(Name = "emi_interest", EmitDefaultValue = false)]
        public decimal? emi_interest { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodCardEMIInPaymentsEntityEmiEmiDetails {\n");
            sb.Append("  emi_amount: ").Append(emi_amount).Append("\n");
            sb.Append("  emi_tenure: ").Append(emi_tenure).Append("\n");
            sb.Append("  emi_interest: ").Append(emi_interest).Append("\n");
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
            return this.Equals(input as PaymentMethodCardEMIInPaymentsEntityEmiEmiDetails);
        }

        /// <summary>
        /// Returns true if PaymentMethodCardEMIInPaymentsEntityEmiEmiDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodCardEMIInPaymentsEntityEmiEmiDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodCardEMIInPaymentsEntityEmiEmiDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.emi_amount == input.emi_amount ||
                    this.emi_amount.Equals(input.emi_amount)
                ) && 
                (
                    this.emi_tenure == input.emi_tenure ||
                    this.emi_tenure.Equals(input.emi_tenure)
                ) && 
                (
                    this.emi_interest == input.emi_interest ||
                    this.emi_interest.Equals(input.emi_interest)
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringemi_amount) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringemi_amount);
            if (deserializedJsonString.ContainsKey("emi_amount")) {
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
                hashCode = (hashCode * 59) + this.emi_amount.GetHashCode();
                hashCode = (hashCode * 59) + this.emi_tenure.GetHashCode();
                hashCode = (hashCode * 59) + this.emi_interest.GetHashCode();
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

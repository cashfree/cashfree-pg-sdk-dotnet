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
    /// ChargesDetails
    /// </summary>
    [DataContract(Name = "ChargesDetails")]
    public class ChargesDetails : IEquatable<ChargesDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChargesDetails" /> class.
        /// </summary>
        /// <param name="serviceCharges">serviceCharges.</param>
        /// <param name="serviceTax">serviceTax.</param>
        /// <param name="amount">amount.</param>
        /// <param name="billedTo">billedTo.</param>
        /// <param name="isPostpaid">isPostpaid.</param>
        public ChargesDetails(decimal serviceCharges = default(decimal), decimal serviceTax = default(decimal), decimal amount = default(decimal), string billedTo = default(string), bool isPostpaid = default(bool))
        {
            this.service_charges = serviceCharges;
            this.service_tax = serviceTax;
            this.amount = amount;
            this.billed_to = billedTo;
            this.is_postpaid = isPostpaid;
        }

        /// <summary>
        /// Gets or Sets service_charges
        /// </summary>
        [DataMember(Name = "service_charges", EmitDefaultValue = false)]
        public decimal service_charges { get; set; }

        /// <summary>
        /// Gets or Sets service_tax
        /// </summary>
        [DataMember(Name = "service_tax", EmitDefaultValue = false)]
        public decimal service_tax { get; set; }

        /// <summary>
        /// Gets or Sets amount
        /// </summary>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public decimal amount { get; set; }

        /// <summary>
        /// Gets or Sets billed_to
        /// </summary>
        [DataMember(Name = "billed_to", EmitDefaultValue = false)]
        public string billed_to { get; set; }

        /// <summary>
        /// Gets or Sets is_postpaid
        /// </summary>
        [DataMember(Name = "is_postpaid", EmitDefaultValue = true)]
        public bool is_postpaid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ChargesDetails {\n");
            sb.Append("  service_charges: ").Append(service_charges).Append("\n");
            sb.Append("  service_tax: ").Append(service_tax).Append("\n");
            sb.Append("  amount: ").Append(amount).Append("\n");
            sb.Append("  billed_to: ").Append(billed_to).Append("\n");
            sb.Append("  is_postpaid: ").Append(is_postpaid).Append("\n");
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
            return this.Equals(input as ChargesDetails);
        }

        /// <summary>
        /// Returns true if ChargesDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ChargesDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ChargesDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.service_charges == input.service_charges ||
                    this.service_charges.Equals(input.service_charges)
                ) && 
                (
                    this.service_tax == input.service_tax ||
                    this.service_tax.Equals(input.service_tax)
                ) && 
                (
                    this.amount == input.amount ||
                    this.amount.Equals(input.amount)
                ) && 
                (
                    this.billed_to == input.billed_to ||
                    (this.billed_to != null &&
                    this.billed_to.Equals(input.billed_to))
                ) && 
                (
                    this.is_postpaid == input.is_postpaid ||
                    this.is_postpaid.Equals(input.is_postpaid)
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringservice_charges) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringservice_charges);
            if (deserializedJsonString.ContainsKey("service_charges")) {
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
                hashCode = (hashCode * 59) + this.service_charges.GetHashCode();
                hashCode = (hashCode * 59) + this.service_tax.GetHashCode();
                hashCode = (hashCode * 59) + this.amount.GetHashCode();
                if (this.billed_to != null)
                {
                    hashCode = (hashCode * 59) + this.billed_to.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.is_postpaid.GetHashCode();
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
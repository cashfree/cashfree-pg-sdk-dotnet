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
    /// BankDetails
    /// </summary>
    [DataContract(Name = "BankDetails")]
    public class BankDetails : IEquatable<BankDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BankDetails" /> class.
        /// </summary>
        /// <param name="accountNumber">accountNumber.</param>
        /// <param name="accountHolder">accountHolder.</param>
        /// <param name="ifsc">ifsc.</param>
        public BankDetails(string? accountNumber = default(string?), string? accountHolder = default(string?), string? ifsc = default(string?))
        {
            this.account_number = accountNumber;
            this.account_holder = accountHolder;
            this.ifsc = ifsc;
        }

        /// <summary>
        /// Gets or Sets account_number
        /// </summary>
        [DataMember(Name = "account_number", EmitDefaultValue = false)]
        public string? account_number { get; set; }

        /// <summary>
        /// Gets or Sets account_holder
        /// </summary>
        [DataMember(Name = "account_holder", EmitDefaultValue = false)]
        public string? account_holder { get; set; }

        /// <summary>
        /// Gets or Sets ifsc
        /// </summary>
        [DataMember(Name = "ifsc", EmitDefaultValue = false)]
        public string? ifsc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BankDetails {\n");
            sb.Append("  account_number: ").Append(account_number).Append("\n");
            sb.Append("  account_holder: ").Append(account_holder).Append("\n");
            sb.Append("  ifsc: ").Append(ifsc).Append("\n");
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
            return this.Equals(input as BankDetails);
        }

        /// <summary>
        /// Returns true if BankDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of BankDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BankDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.account_number == input.account_number ||
                    (this.account_number != null &&
                    this.account_number.Equals(input.account_number))
                ) && 
                (
                    this.account_holder == input.account_holder ||
                    (this.account_holder != null &&
                    this.account_holder.Equals(input.account_holder))
                ) && 
                (
                    this.ifsc == input.ifsc ||
                    (this.ifsc != null &&
                    this.ifsc.Equals(input.ifsc))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringaccount_number) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringaccount_number);
            if (deserializedJsonString.ContainsKey("account_number")) {
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
                if (this.account_number != null)
                {
                    hashCode = (hashCode * 59) + this.account_number.GetHashCode();
                }
                if (this.account_holder != null)
                {
                    hashCode = (hashCode * 59) + this.account_holder.GetHashCode();
                }
                if (this.ifsc != null)
                {
                    hashCode = (hashCode * 59) + this.ifsc.GetHashCode();
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

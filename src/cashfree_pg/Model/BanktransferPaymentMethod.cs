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
    /// banktransfer payment method
    /// </summary>
    [DataContract(Name = "BanktransferPaymentMethod")]
    public class BanktransferPaymentMethod : IEquatable<BanktransferPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BanktransferPaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BanktransferPaymentMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BanktransferPaymentMethod" /> class.
        /// </summary>
        /// <param name="banktransfer">banktransfer (required).</param>
        public BanktransferPaymentMethod(Banktransfer banktransfer = default(Banktransfer))
        {
            // to ensure "banktransfer" is required (not null)
            if (banktransfer == null)
            {
                throw new ArgumentNullException("banktransfer is a required property for BanktransferPaymentMethod and cannot be null");
            }
            this.banktransfer = banktransfer;
        }

        /// <summary>
        /// Gets or Sets banktransfer
        /// </summary>
        [DataMember(Name = "banktransfer", IsRequired = true, EmitDefaultValue = true)]
        public Banktransfer banktransfer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BanktransferPaymentMethod {\n");
            sb.Append("  banktransfer: ").Append(banktransfer).Append("\n");
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
            return this.Equals(input as BanktransferPaymentMethod);
        }

        /// <summary>
        /// Returns true if BanktransferPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of BanktransferPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BanktransferPaymentMethod input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.banktransfer == input.banktransfer ||
                    (this.banktransfer != null &&
                    this.banktransfer.Equals(input.banktransfer))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringbanktransfer) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringbanktransfer);
            if (deserializedJsonString.ContainsKey("banktransfer")) {
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
                if (this.banktransfer != null)
                {
                    hashCode = (hashCode * 59) + this.banktransfer.GetHashCode();
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

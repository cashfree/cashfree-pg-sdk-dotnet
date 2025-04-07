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
    /// Payment method for netbanking object
    /// </summary>
    [DataContract(Name = "NetBankingPaymentMethod")]
    public class NetBankingPaymentMethod : IEquatable<NetBankingPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NetBankingPaymentMethod" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NetBankingPaymentMethod() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NetBankingPaymentMethod" /> class.
        /// </summary>
        /// <param name="netbanking">netbanking (required).</param>
        public NetBankingPaymentMethod(Netbanking netbanking = default(Netbanking))
        {
            // to ensure "netbanking" is required (not null)
            if (netbanking == null)
            {
                throw new ArgumentNullException("netbanking is a required property for NetBankingPaymentMethod and cannot be null");
            }
            this.netbanking = netbanking;
        }

        /// <summary>
        /// Gets or Sets netbanking
        /// </summary>
        [DataMember(Name = "netbanking", IsRequired = true, EmitDefaultValue = true)]
        public Netbanking netbanking { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class NetBankingPaymentMethod {\n");
            sb.Append("  netbanking: ").Append(netbanking).Append("\n");
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
            return this.Equals(input as NetBankingPaymentMethod);
        }

        /// <summary>
        /// Returns true if NetBankingPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of NetBankingPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NetBankingPaymentMethod input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.netbanking == input.netbanking ||
                    (this.netbanking != null &&
                    this.netbanking.Equals(input.netbanking))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringnetbanking) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringnetbanking);
            if (deserializedJsonString.ContainsKey("netbanking")) {
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
                if (this.netbanking != null)
                {
                    hashCode = (hashCode * 59) + this.netbanking.GetHashCode();
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

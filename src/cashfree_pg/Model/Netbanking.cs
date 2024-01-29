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
    /// Netbanking payment method request body
    /// </summary>
    [DataContract(Name = "Netbanking")]
    public class Netbanking : IEquatable<Netbanking>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Netbanking" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Netbanking() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Netbanking" /> class.
        /// </summary>
        /// <param name="channel">The channel for netbanking will always be &#x60;link&#x60; (required).</param>
        /// <param name="netbankingBankCode">Bank code.</param>
        /// <param name="netbankingBankName">String code for bank.</param>
        public Netbanking(string channel = default(string), int netbankingBankCode = default(int), string netbankingBankName = default(string))
        {
            // to ensure "channel" is required (not null)
            if (channel == null)
            {
                throw new ArgumentNullException("channel is a required property for Netbanking and cannot be null");
            }
            this.channel = channel;
            this.netbanking_bank_code = netbankingBankCode;
            this.netbanking_bank_name = netbankingBankName;
        }

        /// <summary>
        /// The channel for netbanking will always be &#x60;link&#x60;
        /// </summary>
        /// <value>The channel for netbanking will always be &#x60;link&#x60;</value>
        [DataMember(Name = "channel", IsRequired = true, EmitDefaultValue = true)]
        public string channel { get; set; }

        /// <summary>
        /// Bank code
        /// </summary>
        /// <value>Bank code</value>
        [DataMember(Name = "netbanking_bank_code", EmitDefaultValue = false)]
        public int netbanking_bank_code { get; set; }

        /// <summary>
        /// String code for bank
        /// </summary>
        /// <value>String code for bank</value>
        [DataMember(Name = "netbanking_bank_name", EmitDefaultValue = false)]
        public string netbanking_bank_name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Netbanking {\n");
            sb.Append("  channel: ").Append(channel).Append("\n");
            sb.Append("  netbanking_bank_code: ").Append(netbanking_bank_code).Append("\n");
            sb.Append("  netbanking_bank_name: ").Append(netbanking_bank_name).Append("\n");
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
            return this.Equals(input as Netbanking);
        }

        /// <summary>
        /// Returns true if Netbanking instances are equal
        /// </summary>
        /// <param name="input">Instance of Netbanking to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Netbanking input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.channel == input.channel ||
                    (this.channel != null &&
                    this.channel.Equals(input.channel))
                ) && 
                (
                    this.netbanking_bank_code == input.netbanking_bank_code ||
                    this.netbanking_bank_code.Equals(input.netbanking_bank_code)
                ) && 
                (
                    this.netbanking_bank_name == input.netbanking_bank_name ||
                    (this.netbanking_bank_name != null &&
                    this.netbanking_bank_name.Equals(input.netbanking_bank_name))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringchannel) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringchannel);
            if (deserializedJsonString.ContainsKey("channel")) {
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
                if (this.channel != null)
                {
                    hashCode = (hashCode * 59) + this.channel.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.netbanking_bank_code.GetHashCode();
                if (this.netbanking_bank_name != null)
                {
                    hashCode = (hashCode * 59) + this.netbanking_bank_name.GetHashCode();
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
            if (this.netbanking_bank_name != null) {
                // netbanking_bank_name (string) pattern
                Regex regexnetbanking_bank_name = new Regex(@"^[A-Z]{5}$", RegexOptions.CultureInvariant);
                if (!regexnetbanking_bank_name.Match(this.netbanking_bank_name).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for netbanking_bank_name, must match a pattern of " + regexnetbanking_bank_name, new [] { "netbanking_bank_name" });
                }
            }

            yield break;
        }
    }

}

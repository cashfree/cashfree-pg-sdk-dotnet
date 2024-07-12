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
    /// Request body for cardless emi payment method
    /// </summary>
    [DataContract(Name = "CardlessEMI")]
    public class CardlessEMI : IEquatable<CardlessEMI>, IValidatableObject
    {
        /// <summary>
        /// One of [&#x60;flexmoney&#x60;, &#x60;zestmoney&#x60;, &#x60;hdfc&#x60;, &#x60;icici&#x60;, &#x60;cashe&#x60;, &#x60;idfc&#x60;, &#x60;kotak&#x60;, &#x60;snapmint&#x60;, &#x60;bharatx&#x60;]
        /// </summary>
        /// <value>One of [&#x60;flexmoney&#x60;, &#x60;zestmoney&#x60;, &#x60;hdfc&#x60;, &#x60;icici&#x60;, &#x60;cashe&#x60;, &#x60;idfc&#x60;, &#x60;kotak&#x60;, &#x60;snapmint&#x60;, &#x60;bharatx&#x60;]</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProviderEnum
        {
            /// <summary>
            /// Enum Flexmoney for value: flexmoney
            /// </summary>
            [EnumMember(Value = "flexmoney")]
            Flexmoney = 1,

            /// <summary>
            /// Enum Zestmoney for value: zestmoney
            /// </summary>
            [EnumMember(Value = "zestmoney")]
            Zestmoney = 2,

            /// <summary>
            /// Enum Hdfc for value: hdfc
            /// </summary>
            [EnumMember(Value = "hdfc")]
            Hdfc = 3,

            /// <summary>
            /// Enum Icici for value: icici
            /// </summary>
            [EnumMember(Value = "icici")]
            Icici = 4,

            /// <summary>
            /// Enum Cashe for value: cashe
            /// </summary>
            [EnumMember(Value = "cashe")]
            Cashe = 5,

            /// <summary>
            /// Enum Idfc for value: idfc
            /// </summary>
            [EnumMember(Value = "idfc")]
            Idfc = 6,

            /// <summary>
            /// Enum Kotak for value: kotak
            /// </summary>
            [EnumMember(Value = "kotak")]
            Kotak = 7,

            /// <summary>
            /// Enum Snapmint for value: snapmint
            /// </summary>
            [EnumMember(Value = "snapmint")]
            Snapmint = 8,

            /// <summary>
            /// Enum Bharatx for value: bharatx
            /// </summary>
            [EnumMember(Value = "bharatx")]
            Bharatx = 9
        }


        /// <summary>
        /// One of [&#x60;flexmoney&#x60;, &#x60;zestmoney&#x60;, &#x60;hdfc&#x60;, &#x60;icici&#x60;, &#x60;cashe&#x60;, &#x60;idfc&#x60;, &#x60;kotak&#x60;, &#x60;snapmint&#x60;, &#x60;bharatx&#x60;]
        /// </summary>
        /// <value>One of [&#x60;flexmoney&#x60;, &#x60;zestmoney&#x60;, &#x60;hdfc&#x60;, &#x60;icici&#x60;, &#x60;cashe&#x60;, &#x60;idfc&#x60;, &#x60;kotak&#x60;, &#x60;snapmint&#x60;, &#x60;bharatx&#x60;]</value>
        [DataMember(Name = "provider", EmitDefaultValue = false)]
        public ProviderEnum? provider { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardlessEMI" /> class.
        /// </summary>
        /// <param name="channel">The channel for cardless EMI is always &#x60;link&#x60;.</param>
        /// <param name="provider">One of [&#x60;flexmoney&#x60;, &#x60;zestmoney&#x60;, &#x60;hdfc&#x60;, &#x60;icici&#x60;, &#x60;cashe&#x60;, &#x60;idfc&#x60;, &#x60;kotak&#x60;, &#x60;snapmint&#x60;, &#x60;bharatx&#x60;].</param>
        /// <param name="phone">Customers phone number for this payment instrument. If the customer is not eligible you will receive a 400 error with type as &#39;invalid_request_error&#39; and code as &#39;invalid_request_error&#39;.</param>
        /// <param name="emiTenure">EMI tenure for the selected provider. This is mandatory when provider is one of [&#x60;hdfc&#x60;, &#x60;icici&#x60;, &#x60;cashe&#x60;, &#x60;idfc&#x60;, &#x60;kotak&#x60;].</param>
        public CardlessEMI(string? channel = default(string?), ProviderEnum? provider = default(ProviderEnum?), string? phone = default(string?), int? emiTenure = default(int?))
        {
            this.channel = channel;
            this.provider = provider;
            this.phone = phone;
            this.emi_tenure = emiTenure;
        }

        /// <summary>
        /// The channel for cardless EMI is always &#x60;link&#x60;
        /// </summary>
        /// <value>The channel for cardless EMI is always &#x60;link&#x60;</value>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public string? channel { get; set; }

        /// <summary>
        /// Customers phone number for this payment instrument. If the customer is not eligible you will receive a 400 error with type as &#39;invalid_request_error&#39; and code as &#39;invalid_request_error&#39;
        /// </summary>
        /// <value>Customers phone number for this payment instrument. If the customer is not eligible you will receive a 400 error with type as &#39;invalid_request_error&#39; and code as &#39;invalid_request_error&#39;</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string? phone { get; set; }

        /// <summary>
        /// EMI tenure for the selected provider. This is mandatory when provider is one of [&#x60;hdfc&#x60;, &#x60;icici&#x60;, &#x60;cashe&#x60;, &#x60;idfc&#x60;, &#x60;kotak&#x60;]
        /// </summary>
        /// <value>EMI tenure for the selected provider. This is mandatory when provider is one of [&#x60;hdfc&#x60;, &#x60;icici&#x60;, &#x60;cashe&#x60;, &#x60;idfc&#x60;, &#x60;kotak&#x60;]</value>
        [DataMember(Name = "emi_tenure", EmitDefaultValue = false)]
        public int? emi_tenure { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardlessEMI {\n");
            sb.Append("  channel: ").Append(channel).Append("\n");
            sb.Append("  provider: ").Append(provider).Append("\n");
            sb.Append("  phone: ").Append(phone).Append("\n");
            sb.Append("  emi_tenure: ").Append(emi_tenure).Append("\n");
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
            return this.Equals(input as CardlessEMI);
        }

        /// <summary>
        /// Returns true if CardlessEMI instances are equal
        /// </summary>
        /// <param name="input">Instance of CardlessEMI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardlessEMI input)
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
                    this.provider == input.provider ||
                    this.provider.Equals(input.provider)
                ) && 
                (
                    this.phone == input.phone ||
                    (this.phone != null &&
                    this.phone.Equals(input.phone))
                ) && 
                (
                    this.emi_tenure == input.emi_tenure ||
                    this.emi_tenure.Equals(input.emi_tenure)
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
                hashCode = (hashCode * 59) + this.provider.GetHashCode();
                if (this.phone != null)
                {
                    hashCode = (hashCode * 59) + this.phone.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.emi_tenure.GetHashCode();
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

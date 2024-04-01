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
    /// Paylater payment method
    /// </summary>
    [DataContract(Name = "Paylater")]
    public class Paylater : IEquatable<Paylater>, IValidatableObject
    {
        /// <summary>
        /// One of [\&quot;kotak\&quot;, \&quot;flexipay\&quot;, \&quot;zestmoney\&quot;, \&quot;lazypay\&quot;, \&quot;olapostpaid\&quot;,\&quot;simpl\&quot;, \&quot;freechargepaylater\&quot;]. Please note that Flexipay is offered by HDFC bank
        /// </summary>
        /// <value>One of [\&quot;kotak\&quot;, \&quot;flexipay\&quot;, \&quot;zestmoney\&quot;, \&quot;lazypay\&quot;, \&quot;olapostpaid\&quot;,\&quot;simpl\&quot;, \&quot;freechargepaylater\&quot;]. Please note that Flexipay is offered by HDFC bank</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProviderEnum
        {
            /// <summary>
            /// Enum Kotak for value: kotak
            /// </summary>
            [EnumMember(Value = "kotak")]
            Kotak = 1,

            /// <summary>
            /// Enum Flexipay for value: flexipay
            /// </summary>
            [EnumMember(Value = "flexipay")]
            Flexipay = 2,

            /// <summary>
            /// Enum Zestmoney for value: zestmoney
            /// </summary>
            [EnumMember(Value = "zestmoney")]
            Zestmoney = 3,

            /// <summary>
            /// Enum Lazypay for value: lazypay
            /// </summary>
            [EnumMember(Value = "lazypay")]
            Lazypay = 4,

            /// <summary>
            /// Enum Olapostpaid for value: olapostpaid
            /// </summary>
            [EnumMember(Value = "olapostpaid")]
            Olapostpaid = 5,

            /// <summary>
            /// Enum Simpl for value: simpl
            /// </summary>
            [EnumMember(Value = "simpl")]
            Simpl = 6,

            /// <summary>
            /// Enum Freechargepaylater for value: freechargepaylater
            /// </summary>
            [EnumMember(Value = "freechargepaylater")]
            Freechargepaylater = 7
        }


        /// <summary>
        /// One of [\&quot;kotak\&quot;, \&quot;flexipay\&quot;, \&quot;zestmoney\&quot;, \&quot;lazypay\&quot;, \&quot;olapostpaid\&quot;,\&quot;simpl\&quot;, \&quot;freechargepaylater\&quot;]. Please note that Flexipay is offered by HDFC bank
        /// </summary>
        /// <value>One of [\&quot;kotak\&quot;, \&quot;flexipay\&quot;, \&quot;zestmoney\&quot;, \&quot;lazypay\&quot;, \&quot;olapostpaid\&quot;,\&quot;simpl\&quot;, \&quot;freechargepaylater\&quot;]. Please note that Flexipay is offered by HDFC bank</value>
        [DataMember(Name = "provider", EmitDefaultValue = false)]
        public ProviderEnum? provider { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Paylater" /> class.
        /// </summary>
        /// <param name="channel">The channel for cardless EMI is always &#x60;link&#x60;.</param>
        /// <param name="provider">One of [\&quot;kotak\&quot;, \&quot;flexipay\&quot;, \&quot;zestmoney\&quot;, \&quot;lazypay\&quot;, \&quot;olapostpaid\&quot;,\&quot;simpl\&quot;, \&quot;freechargepaylater\&quot;]. Please note that Flexipay is offered by HDFC bank.</param>
        /// <param name="phone">Customers phone number for this payment instrument. If the customer is not eligible you will receive a 400 error with type as &#39;invalid_request_error&#39; and code as &#39;invalid_request_error&#39;.</param>
        public Paylater(string? channel = default(string?), ProviderEnum? provider = default(ProviderEnum?), string? phone = default(string?))
        {
            this.channel = channel;
            this.provider = provider;
            this.phone = phone;
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Paylater {\n");
            sb.Append("  channel: ").Append(channel).Append("\n");
            sb.Append("  provider: ").Append(provider).Append("\n");
            sb.Append("  phone: ").Append(phone).Append("\n");
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
            return this.Equals(input as Paylater);
        }

        /// <summary>
        /// Returns true if Paylater instances are equal
        /// </summary>
        /// <param name="input">Instance of Paylater to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Paylater input)
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

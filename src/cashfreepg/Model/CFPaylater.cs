/*
 * New Payment Gateway APIs
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 2022-01-01
 * Contact: nextgenapi@cashfree.com
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
using OpenAPIDateConverter = cashfreepg.Client.OpenAPIDateConverter;

namespace cashfreepg.Model
{
    /// <summary>
    /// CFPaylater
    /// </summary>
    [DataContract(Name = "CFPaylater")]
    public partial class CFPaylater : IEquatable<CFPaylater>, IValidatableObject
    {
        /// <summary>
        /// One of [\&quot;kotak\&quot;, \&quot;flexipay\&quot;, \&quot;zestmoney\&quot;, \&quot;lazypay\&quot;, \&quot;olapostpaid\&quot;]. Please note that Flexipay is offered by HDFC bank
        /// </summary>
        /// <value>One of [\&quot;kotak\&quot;, \&quot;flexipay\&quot;, \&quot;zestmoney\&quot;, \&quot;lazypay\&quot;, \&quot;olapostpaid\&quot;]. Please note that Flexipay is offered by HDFC bank</value>
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
            Olapostpaid = 5

        }


        /// <summary>
        /// One of [\&quot;kotak\&quot;, \&quot;flexipay\&quot;, \&quot;zestmoney\&quot;, \&quot;lazypay\&quot;, \&quot;olapostpaid\&quot;]. Please note that Flexipay is offered by HDFC bank
        /// </summary>
        /// <value>One of [\&quot;kotak\&quot;, \&quot;flexipay\&quot;, \&quot;zestmoney\&quot;, \&quot;lazypay\&quot;, \&quot;olapostpaid\&quot;]. Please note that Flexipay is offered by HDFC bank</value>
        [DataMember(Name = "provider", IsRequired = true, EmitDefaultValue = false)]
        public string? Provider { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CFPaylater" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CFPaylater() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CFPaylater" /> class.
        /// </summary>
        /// <param name="channel">The channel for cardless EMI is always &#x60;link&#x60; (required).</param>
        /// <param name="provider">One of [\&quot;kotak\&quot;, \&quot;flexipay\&quot;, \&quot;zestmoney\&quot;, \&quot;lazypay\&quot;, \&quot;olapostpaid\&quot;]. Please note that Flexipay is offered by HDFC bank (required).</param>
        /// <param name="phone">Customers phone number for this payment instrument. If the customer is not eligible you will receive a 400 error with type as &#39;invalid_request_error&#39; and code as &#39;invalid_request_error&#39; (required).</param>
        public CFPaylater(string channel = "link", string? provider = default(string?), string? phone = default(string?))
        {
            // to ensure "channel" is required (not null)
            if (provider == null) {
                throw new ArgumentNullException("provider is a required property for CFPaylater and cannot be null");
            }
            this.Channel = channel;
            this.Provider = provider;
            // to ensure "phone" is required (not null)
            if (phone == null) {
                throw new ArgumentNullException("phone is a required property for CFPaylater and cannot be null");
            }
            this.Phone = phone;
        }

        /// <summary>
        /// The channel for cardless EMI is always &#x60;link&#x60;
        /// </summary>
        /// <value>The channel for cardless EMI is always &#x60;link&#x60;</value>
        [DataMember(Name = "channel", IsRequired = true, EmitDefaultValue = false)]
        public string Channel { get; set; }

        /// <summary>
        /// Customers phone number for this payment instrument. If the customer is not eligible you will receive a 400 error with type as &#39;invalid_request_error&#39; and code as &#39;invalid_request_error&#39;
        /// </summary>
        /// <value>Customers phone number for this payment instrument. If the customer is not eligible you will receive a 400 error with type as &#39;invalid_request_error&#39; and code as &#39;invalid_request_error&#39;</value>
        [DataMember(Name = "phone", IsRequired = true, EmitDefaultValue = false)]
        public string? Phone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CFPaylater {\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
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
        public override bool Equals(object? input)
        {
            return this.Equals(input as CFPaylater);
        }

        /// <summary>
        /// Returns true if CFPaylater instances are equal
        /// </summary>
        /// <param name="input">Instance of CFPaylater to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CFPaylater? input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.Provider == input.Provider ||
                    this.Provider.Equals(input.Provider)
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
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
                if (this.Channel != null)
                {
                    hashCode = (hashCode * 59) + this.Channel.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Provider.GetHashCode();
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

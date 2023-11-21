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
    /// App payment method
    /// </summary>
    [DataContract(Name = "App")]
    public class App : IEquatable<App>, IValidatableObject
    {
        /// <summary>
        /// Specify the provider through which the payment must be processed.
        /// </summary>
        /// <value>Specify the provider through which the payment must be processed.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProviderEnum
        {
            /// <summary>
            /// Enum Gpay for value: gpay
            /// </summary>
            [EnumMember(Value = "gpay")]
            Gpay = 1,

            /// <summary>
            /// Enum Phonepe for value: phonepe
            /// </summary>
            [EnumMember(Value = "phonepe")]
            Phonepe = 2,

            /// <summary>
            /// Enum Ola for value: ola
            /// </summary>
            [EnumMember(Value = "ola")]
            Ola = 3,

            /// <summary>
            /// Enum Paytm for value: paytm
            /// </summary>
            [EnumMember(Value = "paytm")]
            Paytm = 4,

            /// <summary>
            /// Enum Amazon for value: amazon
            /// </summary>
            [EnumMember(Value = "amazon")]
            Amazon = 5,

            /// <summary>
            /// Enum Airtel for value: airtel
            /// </summary>
            [EnumMember(Value = "airtel")]
            Airtel = 6,

            /// <summary>
            /// Enum Freecharge for value: freecharge
            /// </summary>
            [EnumMember(Value = "freecharge")]
            Freecharge = 7,

            /// <summary>
            /// Enum Mobikwik for value: mobikwik
            /// </summary>
            [EnumMember(Value = "mobikwik")]
            Mobikwik = 8,

            /// <summary>
            /// Enum Jio for value: jio
            /// </summary>
            [EnumMember(Value = "jio")]
            Jio = 9
        }


        /// <summary>
        /// Specify the provider through which the payment must be processed.
        /// </summary>
        /// <value>Specify the provider through which the payment must be processed.</value>
        [DataMember(Name = "provider", IsRequired = true, EmitDefaultValue = true)]
        public ProviderEnum provider { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="App" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected App() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="App" /> class.
        /// </summary>
        /// <param name="channel">Specify the channel through which the payment must be processed. (required).</param>
        /// <param name="provider">Specify the provider through which the payment must be processed. (required).</param>
        /// <param name="phone">Customer phone number associated with a wallet for payment. (required).</param>
        public App(string channel = default(string), ProviderEnum provider = default(ProviderEnum), string phone = default(string))
        {
            // to ensure "channel" is required (not null)
            if (channel == null)
            {
                throw new ArgumentNullException("channel is a required property for App and cannot be null");
            }
            this.channel = channel;
            this.provider = provider;
            // to ensure "phone" is required (not null)
            if (phone == null)
            {
                throw new ArgumentNullException("phone is a required property for App and cannot be null");
            }
            this.phone = phone;
        }

        /// <summary>
        /// Specify the channel through which the payment must be processed.
        /// </summary>
        /// <value>Specify the channel through which the payment must be processed.</value>
        [DataMember(Name = "channel", IsRequired = true, EmitDefaultValue = true)]
        public string channel { get; set; }

        /// <summary>
        /// Customer phone number associated with a wallet for payment.
        /// </summary>
        /// <value>Customer phone number associated with a wallet for payment.</value>
        [DataMember(Name = "phone", IsRequired = true, EmitDefaultValue = true)]
        public string phone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class App {\n");
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
            return this.Equals(input as App);
        }

        /// <summary>
        /// Returns true if App instances are equal
        /// </summary>
        /// <param name="input">Instance of App to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(App input)
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
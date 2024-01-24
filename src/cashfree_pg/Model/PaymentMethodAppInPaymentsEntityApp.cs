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
    /// PaymentMethodAppInPaymentsEntityApp
    /// </summary>
    [DataContract(Name = "PaymentMethodAppInPaymentsEntity_app")]
    public class PaymentMethodAppInPaymentsEntityApp : IEquatable<PaymentMethodAppInPaymentsEntityApp>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodAppInPaymentsEntityApp" /> class.
        /// </summary>
        /// <param name="channel">channel.</param>
        /// <param name="provider">provider.</param>
        /// <param name="phone">phone.</param>
        public PaymentMethodAppInPaymentsEntityApp(string channel = default(string), string provider = default(string), string phone = default(string))
        {
            this.channel = channel;
            this.provider = provider;
            this.phone = phone;
        }

        /// <summary>
        /// Gets or Sets channel
        /// </summary>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public string channel { get; set; }

        /// <summary>
        /// Gets or Sets provider
        /// </summary>
        [DataMember(Name = "provider", EmitDefaultValue = false)]
        public string provider { get; set; }

        /// <summary>
        /// Gets or Sets phone
        /// </summary>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string phone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodAppInPaymentsEntityApp {\n");
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
            return this.Equals(input as PaymentMethodAppInPaymentsEntityApp);
        }

        /// <summary>
        /// Returns true if PaymentMethodAppInPaymentsEntityApp instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodAppInPaymentsEntityApp to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodAppInPaymentsEntityApp input)
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
                    (this.provider != null &&
                    this.provider.Equals(input.provider))
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
                if (this.provider != null)
                {
                    hashCode = (hashCode * 59) + this.provider.GetHashCode();
                }
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

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
    /// payment webhook object
    /// </summary>
    [DataContract(Name = "PaymentWebhook")]
    public class PaymentWebhook : IEquatable<PaymentWebhook>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentWebhook" /> class.
        /// </summary>
        /// <param name="data">data.</param>
        /// <param name="eventTime">eventTime.</param>
        /// <param name="type">type.</param>
        public PaymentWebhook(PaymentWebhookDataEntity? data = default(PaymentWebhookDataEntity?), string? eventTime = default(string?), string? type = default(string?))
        {
            this.data = data;
            this.event_time = eventTime;
            this.type = type;
        }

        /// <summary>
        /// Gets or Sets data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public PaymentWebhookDataEntity? data { get; set; }

        /// <summary>
        /// Gets or Sets event_time
        /// </summary>
        /// <example>2021-10-07T19:42:44+05:30</example>
        [DataMember(Name = "event_time", EmitDefaultValue = false)]
        public string? event_time { get; set; }

        /// <summary>
        /// Gets or Sets type
        /// </summary>
        /// <example>PAYMENT_SUCCESS_WEBHOOK</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string? type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentWebhook {\n");
            sb.Append("  data: ").Append(data).Append("\n");
            sb.Append("  event_time: ").Append(event_time).Append("\n");
            sb.Append("  type: ").Append(type).Append("\n");
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
            return this.Equals(input as PaymentWebhook);
        }

        /// <summary>
        /// Returns true if PaymentWebhook instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentWebhook to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentWebhook input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.data == input.data ||
                    (this.data != null &&
                    this.data.Equals(input.data))
                ) && 
                (
                    this.event_time == input.event_time ||
                    (this.event_time != null &&
                    this.event_time.Equals(input.event_time))
                ) && 
                (
                    this.type == input.type ||
                    (this.type != null &&
                    this.type.Equals(input.type))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringdata) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringdata);
            if (deserializedJsonString.ContainsKey("data")) {
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
                if (this.data != null)
                {
                    hashCode = (hashCode * 59) + this.data.GetHashCode();
                }
                if (this.event_time != null)
                {
                    hashCode = (hashCode * 59) + this.event_time.GetHashCode();
                }
                if (this.type != null)
                {
                    hashCode = (hashCode * 59) + this.type.GetHashCode();
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

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
    /// CreateSubscriptionRequestSubscriptionMeta
    /// </summary>
    [DataContract(Name = "CreateSubscriptionRequest_subscription_meta")]
    public class CreateSubscriptionRequestSubscriptionMeta : IEquatable<CreateSubscriptionRequestSubscriptionMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequestSubscriptionMeta" /> class.
        /// </summary>
        /// <param name="returnUrl">The url to redirect after checkout..</param>
        /// <param name="notificationChannel">Notification channel for the subscription. SMS, EMAIL are possible values..</param>
        public CreateSubscriptionRequestSubscriptionMeta(string? returnUrl = default(string?), List<string>? notificationChannel = default(List<string>?))
        {
            this.return_url = returnUrl;
            this.notification_channel = notificationChannel;
        }

        /// <summary>
        /// The url to redirect after checkout.
        /// </summary>
        /// <value>The url to redirect after checkout.</value>
        [DataMember(Name = "return_url", EmitDefaultValue = false)]
        public string? return_url { get; set; }

        /// <summary>
        /// Notification channel for the subscription. SMS, EMAIL are possible values.
        /// </summary>
        /// <value>Notification channel for the subscription. SMS, EMAIL are possible values.</value>
        [DataMember(Name = "notification_channel", EmitDefaultValue = false)]
        public List<string>? notification_channel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSubscriptionRequestSubscriptionMeta {\n");
            sb.Append("  return_url: ").Append(return_url).Append("\n");
            sb.Append("  notification_channel: ").Append(notification_channel).Append("\n");
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
            return this.Equals(input as CreateSubscriptionRequestSubscriptionMeta);
        }

        /// <summary>
        /// Returns true if CreateSubscriptionRequestSubscriptionMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSubscriptionRequestSubscriptionMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSubscriptionRequestSubscriptionMeta input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.return_url == input.return_url ||
                    (this.return_url != null &&
                    this.return_url.Equals(input.return_url))
                ) && 
                (
                    this.notification_channel == input.notification_channel ||
                    this.notification_channel != null &&
                    input.notification_channel != null &&
                    this.notification_channel.SequenceEqual(input.notification_channel)
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringreturn_url) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringreturn_url);
            if (deserializedJsonString.ContainsKey("return_url")) {
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
                if (this.return_url != null)
                {
                    hashCode = (hashCode * 59) + this.return_url.GetHashCode();
                }
                if (this.notification_channel != null)
                {
                    hashCode = (hashCode * 59) + this.notification_channel.GetHashCode();
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

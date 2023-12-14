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
    /// Payment link meta information object
    /// </summary>
    [DataContract(Name = "LinkMetaEntity")]
    public class LinkMetaEntity : IEquatable<LinkMetaEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkMetaEntity" /> class.
        /// </summary>
        /// <param name="notifyUrl">Notification URL for server-server communication. It should be an https URL..</param>
        /// <param name="upiIntent">If \&quot;true\&quot;, link will directly open UPI Intent flow on mobile, and normal link flow elsewhere.</param>
        /// <param name="returnUrl">The URL to which user will be redirected to after the payment is done on the link. Maximum length: 250..</param>
        /// <param name="paymentMethods">Allowed payment modes for this link. Pass comma-separated values among following options - \&quot;cc\&quot;, \&quot;dc\&quot;, \&quot;ccc\&quot;, \&quot;ppc\&quot;, \&quot;nb\&quot;, \&quot;upi\&quot;, \&quot;paypal\&quot;, \&quot;app\&quot;. Leave it blank to show all available payment methods.</param>
        public LinkMetaEntity(string notifyUrl = default(string), string upiIntent = default(string), string returnUrl = default(string), string paymentMethods = default(string))
        {
            this.notify_url = notifyUrl;
            this.upi_intent = upiIntent;
            this.return_url = returnUrl;
            this.payment_methods = paymentMethods;
        }

        /// <summary>
        /// Notification URL for server-server communication. It should be an https URL.
        /// </summary>
        /// <value>Notification URL for server-server communication. It should be an https URL.</value>
        [DataMember(Name = "notify_url", EmitDefaultValue = false)]
        public string notify_url { get; set; }

        /// <summary>
        /// If \&quot;true\&quot;, link will directly open UPI Intent flow on mobile, and normal link flow elsewhere
        /// </summary>
        /// <value>If \&quot;true\&quot;, link will directly open UPI Intent flow on mobile, and normal link flow elsewhere</value>
        [DataMember(Name = "upi_intent", EmitDefaultValue = false)]
        public string upi_intent { get; set; }

        /// <summary>
        /// The URL to which user will be redirected to after the payment is done on the link. Maximum length: 250.
        /// </summary>
        /// <value>The URL to which user will be redirected to after the payment is done on the link. Maximum length: 250.</value>
        [DataMember(Name = "return_url", EmitDefaultValue = false)]
        public string return_url { get; set; }

        /// <summary>
        /// Allowed payment modes for this link. Pass comma-separated values among following options - \&quot;cc\&quot;, \&quot;dc\&quot;, \&quot;ccc\&quot;, \&quot;ppc\&quot;, \&quot;nb\&quot;, \&quot;upi\&quot;, \&quot;paypal\&quot;, \&quot;app\&quot;. Leave it blank to show all available payment methods
        /// </summary>
        /// <value>Allowed payment modes for this link. Pass comma-separated values among following options - \&quot;cc\&quot;, \&quot;dc\&quot;, \&quot;ccc\&quot;, \&quot;ppc\&quot;, \&quot;nb\&quot;, \&quot;upi\&quot;, \&quot;paypal\&quot;, \&quot;app\&quot;. Leave it blank to show all available payment methods</value>
        [DataMember(Name = "payment_methods", EmitDefaultValue = false)]
        public string payment_methods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LinkMetaEntity {\n");
            sb.Append("  notify_url: ").Append(notify_url).Append("\n");
            sb.Append("  upi_intent: ").Append(upi_intent).Append("\n");
            sb.Append("  return_url: ").Append(return_url).Append("\n");
            sb.Append("  payment_methods: ").Append(payment_methods).Append("\n");
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
            return this.Equals(input as LinkMetaEntity);
        }

        /// <summary>
        /// Returns true if LinkMetaEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkMetaEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkMetaEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.notify_url == input.notify_url ||
                    (this.notify_url != null &&
                    this.notify_url.Equals(input.notify_url))
                ) && 
                (
                    this.upi_intent == input.upi_intent ||
                    (this.upi_intent != null &&
                    this.upi_intent.Equals(input.upi_intent))
                ) && 
                (
                    this.return_url == input.return_url ||
                    (this.return_url != null &&
                    this.return_url.Equals(input.return_url))
                ) && 
                (
                    this.payment_methods == input.payment_methods ||
                    (this.payment_methods != null &&
                    this.payment_methods.Equals(input.payment_methods))
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
                if (this.notify_url != null)
                {
                    hashCode = (hashCode * 59) + this.notify_url.GetHashCode();
                }
                if (this.upi_intent != null)
                {
                    hashCode = (hashCode * 59) + this.upi_intent.GetHashCode();
                }
                if (this.return_url != null)
                {
                    hashCode = (hashCode * 59) + this.return_url.GetHashCode();
                }
                if (this.payment_methods != null)
                {
                    hashCode = (hashCode * 59) + this.payment_methods.GetHashCode();
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

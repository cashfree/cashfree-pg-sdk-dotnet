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
    /// Optional meta details to control how the customer pays and how payment journey completes
    /// </summary>
    [DataContract(Name = "OrderMeta")]
    public class OrderMeta : IEquatable<OrderMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderMeta" /> class.
        /// </summary>
        /// <param name="returnUrl">The URL to which user will be redirected to after the payment on bank OTP page. Maximum length: 250. The return_url must contain placeholder {order_id}. When redirecting the customer back to the return url from the bank’s OTP page, Cashfree will replace this placeholder with the actual value for that order..</param>
        /// <param name="notifyUrl">Notification URL for server-server communication. Useful when user&#39;s connection drops while re-directing. NotifyUrl should be an https URL. Maximum length: 250..</param>
        /// <param name="paymentMethods">Allowed payment modes for this order. Pass comma-separated values among following options - \&quot;cc\&quot;, \&quot;dc\&quot;, \&quot;ccc\&quot;, \&quot;ppc\&quot;,\&quot;nb\&quot;,\&quot;upi\&quot;,\&quot;paypal\&quot;,\&quot;app\&quot;,\&quot;paylater\&quot;,\&quot;cardlessemi\&quot;,\&quot;dcemi\&quot;,\&quot;ccemi\&quot;,\&quot;banktransfer\&quot;. Leave it blank to show all available payment methods.</param>
        public OrderMeta(string returnUrl = default(string), string notifyUrl = default(string), Object paymentMethods = default(Object))
        {
            this.return_url = returnUrl;
            this.notify_url = notifyUrl;
            this.payment_methods = paymentMethods;
        }

        /// <summary>
        /// The URL to which user will be redirected to after the payment on bank OTP page. Maximum length: 250. The return_url must contain placeholder {order_id}. When redirecting the customer back to the return url from the bank’s OTP page, Cashfree will replace this placeholder with the actual value for that order.
        /// </summary>
        /// <value>The URL to which user will be redirected to after the payment on bank OTP page. Maximum length: 250. The return_url must contain placeholder {order_id}. When redirecting the customer back to the return url from the bank’s OTP page, Cashfree will replace this placeholder with the actual value for that order.</value>
        /// <example>https://example.com/return?order_id&#x3D;{order_id}</example>
        [DataMember(Name = "return_url", EmitDefaultValue = false)]
        public string return_url { get; set; }

        /// <summary>
        /// Notification URL for server-server communication. Useful when user&#39;s connection drops while re-directing. NotifyUrl should be an https URL. Maximum length: 250.
        /// </summary>
        /// <value>Notification URL for server-server communication. Useful when user&#39;s connection drops while re-directing. NotifyUrl should be an https URL. Maximum length: 250.</value>
        /// <example>https://example.com/cf_notify</example>
        [DataMember(Name = "notify_url", EmitDefaultValue = false)]
        public string notify_url { get; set; }

        /// <summary>
        /// Allowed payment modes for this order. Pass comma-separated values among following options - \&quot;cc\&quot;, \&quot;dc\&quot;, \&quot;ccc\&quot;, \&quot;ppc\&quot;,\&quot;nb\&quot;,\&quot;upi\&quot;,\&quot;paypal\&quot;,\&quot;app\&quot;,\&quot;paylater\&quot;,\&quot;cardlessemi\&quot;,\&quot;dcemi\&quot;,\&quot;ccemi\&quot;,\&quot;banktransfer\&quot;. Leave it blank to show all available payment methods
        /// </summary>
        /// <value>Allowed payment modes for this order. Pass comma-separated values among following options - \&quot;cc\&quot;, \&quot;dc\&quot;, \&quot;ccc\&quot;, \&quot;ppc\&quot;,\&quot;nb\&quot;,\&quot;upi\&quot;,\&quot;paypal\&quot;,\&quot;app\&quot;,\&quot;paylater\&quot;,\&quot;cardlessemi\&quot;,\&quot;dcemi\&quot;,\&quot;ccemi\&quot;,\&quot;banktransfer\&quot;. Leave it blank to show all available payment methods</value>
        /// <example>cc,dc,upi</example>
        [DataMember(Name = "payment_methods", EmitDefaultValue = true)]
        public Object payment_methods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderMeta {\n");
            sb.Append("  return_url: ").Append(return_url).Append("\n");
            sb.Append("  notify_url: ").Append(notify_url).Append("\n");
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
            return this.Equals(input as OrderMeta);
        }

        /// <summary>
        /// Returns true if OrderMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderMeta input)
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
                    this.notify_url == input.notify_url ||
                    (this.notify_url != null &&
                    this.notify_url.Equals(input.notify_url))
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
                if (this.return_url != null)
                {
                    hashCode = (hashCode * 59) + this.return_url.GetHashCode();
                }
                if (this.notify_url != null)
                {
                    hashCode = (hashCode * 59) + this.notify_url.GetHashCode();
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

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
    /// UPI collect payment method object
    /// </summary>
    [DataContract(Name = "Upi")]
    public class Upi : IEquatable<Upi>, IValidatableObject
    {
        /// <summary>
        /// Specify the channel through which the payment must be processed. Can be one of [\&quot;link\&quot;, \&quot;collect\&quot;, \&quot;qrcode\&quot;]
        /// </summary>
        /// <value>Specify the channel through which the payment must be processed. Can be one of [\&quot;link\&quot;, \&quot;collect\&quot;, \&quot;qrcode\&quot;]</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ChannelEnum
        {
            /// <summary>
            /// Enum Link for value: link
            /// </summary>
            [EnumMember(Value = "link")]
            Link = 1,

            /// <summary>
            /// Enum Collect for value: collect
            /// </summary>
            [EnumMember(Value = "collect")]
            Collect = 2,

            /// <summary>
            /// Enum Qrcode for value: qrcode
            /// </summary>
            [EnumMember(Value = "qrcode")]
            Qrcode = 3
        }


        /// <summary>
        /// Specify the channel through which the payment must be processed. Can be one of [\&quot;link\&quot;, \&quot;collect\&quot;, \&quot;qrcode\&quot;]
        /// </summary>
        /// <value>Specify the channel through which the payment must be processed. Can be one of [\&quot;link\&quot;, \&quot;collect\&quot;, \&quot;qrcode\&quot;]</value>
        [DataMember(Name = "channel", IsRequired = true, EmitDefaultValue = true)]
        public ChannelEnum channel { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Upi" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Upi() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Upi" /> class.
        /// </summary>
        /// <param name="channel">Specify the channel through which the payment must be processed. Can be one of [\&quot;link\&quot;, \&quot;collect\&quot;, \&quot;qrcode\&quot;] (required).</param>
        /// <param name="upiId">Customer UPI VPA to process payment.  ### Important This is a required parameter for channel &#x3D; &#x60;collect&#x60; .</param>
        /// <param name="upiRedirectUrl">use this if you want cashfree to show a loader. Sample response below. It is only supported for collect &#x60;action:collect&#x60; will be returned with &#x60;data.url&#x60; having the link for redirection .</param>
        /// <param name="upiExpiryMinutes">The UPI request will be valid for this expiry minutes. This parameter is only applicable for a UPI collect payment. The default value is 5 minutes. You should keep the minimum as 5 minutes, and maximum as 15 minutes.</param>
        /// <param name="authorizeOnly">For one time mandate on UPI. Set this as authorize_only &#x3D; true. Please note that you can only use the \&quot;collect\&quot; channel if you are sending a one time mandate request.</param>
        /// <param name="authorization">authorization.</param>
        public Upi(ChannelEnum channel = default(ChannelEnum), string? upiId = default(string?), bool? upiRedirectUrl = default(bool?), decimal? upiExpiryMinutes = default(decimal?), bool? authorizeOnly = default(bool?), UPIAuthorizeDetails? authorization = default(UPIAuthorizeDetails?))
        {
            this.channel = channel;
            this.upi_id = upiId;
            this.upi_redirect_url = upiRedirectUrl;
            this.upi_expiry_minutes = upiExpiryMinutes;
            this.authorize_only = authorizeOnly;
            this.authorization = authorization;
        }

        /// <summary>
        /// Customer UPI VPA to process payment.  ### Important This is a required parameter for channel &#x3D; &#x60;collect&#x60; 
        /// </summary>
        /// <value>Customer UPI VPA to process payment.  ### Important This is a required parameter for channel &#x3D; &#x60;collect&#x60; </value>
        [DataMember(Name = "upi_id", EmitDefaultValue = false)]
        public string? upi_id { get; set; }

        /// <summary>
        /// use this if you want cashfree to show a loader. Sample response below. It is only supported for collect &#x60;action:collect&#x60; will be returned with &#x60;data.url&#x60; having the link for redirection 
        /// </summary>
        /// <value>use this if you want cashfree to show a loader. Sample response below. It is only supported for collect &#x60;action:collect&#x60; will be returned with &#x60;data.url&#x60; having the link for redirection </value>
        [DataMember(Name = "upi_redirect_url", EmitDefaultValue = true)]
        public bool? upi_redirect_url { get; set; }

        /// <summary>
        /// The UPI request will be valid for this expiry minutes. This parameter is only applicable for a UPI collect payment. The default value is 5 minutes. You should keep the minimum as 5 minutes, and maximum as 15 minutes
        /// </summary>
        /// <value>The UPI request will be valid for this expiry minutes. This parameter is only applicable for a UPI collect payment. The default value is 5 minutes. You should keep the minimum as 5 minutes, and maximum as 15 minutes</value>
        [DataMember(Name = "upi_expiry_minutes", EmitDefaultValue = false)]
        public decimal? upi_expiry_minutes { get; set; }

        /// <summary>
        /// For one time mandate on UPI. Set this as authorize_only &#x3D; true. Please note that you can only use the \&quot;collect\&quot; channel if you are sending a one time mandate request
        /// </summary>
        /// <value>For one time mandate on UPI. Set this as authorize_only &#x3D; true. Please note that you can only use the \&quot;collect\&quot; channel if you are sending a one time mandate request</value>
        [DataMember(Name = "authorize_only", EmitDefaultValue = true)]
        public bool? authorize_only { get; set; }

        /// <summary>
        /// Gets or Sets authorization
        /// </summary>
        [DataMember(Name = "authorization", EmitDefaultValue = false)]
        public UPIAuthorizeDetails? authorization { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Upi {\n");
            sb.Append("  channel: ").Append(channel).Append("\n");
            sb.Append("  upi_id: ").Append(upi_id).Append("\n");
            sb.Append("  upi_redirect_url: ").Append(upi_redirect_url).Append("\n");
            sb.Append("  upi_expiry_minutes: ").Append(upi_expiry_minutes).Append("\n");
            sb.Append("  authorize_only: ").Append(authorize_only).Append("\n");
            sb.Append("  authorization: ").Append(authorization).Append("\n");
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
            return this.Equals(input as Upi);
        }

        /// <summary>
        /// Returns true if Upi instances are equal
        /// </summary>
        /// <param name="input">Instance of Upi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Upi input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.channel == input.channel ||
                    this.channel.Equals(input.channel)
                ) && 
                (
                    this.upi_id == input.upi_id ||
                    (this.upi_id != null &&
                    this.upi_id.Equals(input.upi_id))
                ) && 
                (
                    this.upi_redirect_url == input.upi_redirect_url ||
                    this.upi_redirect_url.Equals(input.upi_redirect_url)
                ) && 
                (
                    this.upi_expiry_minutes == input.upi_expiry_minutes ||
                    this.upi_expiry_minutes.Equals(input.upi_expiry_minutes)
                ) && 
                (
                    this.authorize_only == input.authorize_only ||
                    this.authorize_only.Equals(input.authorize_only)
                ) && 
                (
                    this.authorization == input.authorization ||
                    (this.authorization != null &&
                    this.authorization.Equals(input.authorization))
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
                hashCode = (hashCode * 59) + this.channel.GetHashCode();
                if (this.upi_id != null)
                {
                    hashCode = (hashCode * 59) + this.upi_id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.upi_redirect_url.GetHashCode();
                hashCode = (hashCode * 59) + this.upi_expiry_minutes.GetHashCode();
                hashCode = (hashCode * 59) + this.authorize_only.GetHashCode();
                if (this.authorization != null)
                {
                    hashCode = (hashCode * 59) + this.authorization.GetHashCode();
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

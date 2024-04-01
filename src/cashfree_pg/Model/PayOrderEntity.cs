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
    /// Order Pay response once you create a transaction for that order
    /// </summary>
    [DataContract(Name = "PayOrderEntity")]
    public class PayOrderEntity : IEquatable<PayOrderEntity>, IValidatableObject
    {
        /// <summary>
        /// One of [\&quot;upi\&quot;, \&quot;netbanking\&quot;, \&quot;card\&quot;, \&quot;app\&quot;, \&quot;cardless_emi\&quot;, \&quot;paylater\&quot;, \&quot;banktransfer\&quot;] 
        /// </summary>
        /// <value>One of [\&quot;upi\&quot;, \&quot;netbanking\&quot;, \&quot;card\&quot;, \&quot;app\&quot;, \&quot;cardless_emi\&quot;, \&quot;paylater\&quot;, \&quot;banktransfer\&quot;] </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentMethodEnum
        {
            /// <summary>
            /// Enum Netbanking for value: netbanking
            /// </summary>
            [EnumMember(Value = "netbanking")]
            Netbanking = 1,

            /// <summary>
            /// Enum Card for value: card
            /// </summary>
            [EnumMember(Value = "card")]
            Card = 2,

            /// <summary>
            /// Enum Upi for value: upi
            /// </summary>
            [EnumMember(Value = "upi")]
            Upi = 3,

            /// <summary>
            /// Enum App for value: app
            /// </summary>
            [EnumMember(Value = "app")]
            App = 4,

            /// <summary>
            /// Enum CardlessEmi for value: cardless_emi
            /// </summary>
            [EnumMember(Value = "cardless_emi")]
            CardlessEmi = 5,

            /// <summary>
            /// Enum Paylater for value: paylater
            /// </summary>
            [EnumMember(Value = "paylater")]
            Paylater = 6,

            /// <summary>
            /// Enum Banktransfer for value: banktransfer
            /// </summary>
            [EnumMember(Value = "banktransfer")]
            Banktransfer = 7
        }


        /// <summary>
        /// One of [\&quot;upi\&quot;, \&quot;netbanking\&quot;, \&quot;card\&quot;, \&quot;app\&quot;, \&quot;cardless_emi\&quot;, \&quot;paylater\&quot;, \&quot;banktransfer\&quot;] 
        /// </summary>
        /// <value>One of [\&quot;upi\&quot;, \&quot;netbanking\&quot;, \&quot;card\&quot;, \&quot;app\&quot;, \&quot;cardless_emi\&quot;, \&quot;paylater\&quot;, \&quot;banktransfer\&quot;] </value>
        [DataMember(Name = "payment_method", EmitDefaultValue = false)]
        public PaymentMethodEnum? payment_method { get; set; }
        /// <summary>
        /// One of [\&quot;link\&quot;, \&quot;collect\&quot;, \&quot;qrcode\&quot;]. In an older version we used to support different channels like &#39;gpay&#39;, &#39;phonepe&#39; etc. However, we now support only the following channels - link, collect and qrcode. To process payments using gpay, you will have to provide channel as &#39;link&#39; and provider as &#39;gpay&#39;
        /// </summary>
        /// <value>One of [\&quot;link\&quot;, \&quot;collect\&quot;, \&quot;qrcode\&quot;]. In an older version we used to support different channels like &#39;gpay&#39;, &#39;phonepe&#39; etc. However, we now support only the following channels - link, collect and qrcode. To process payments using gpay, you will have to provide channel as &#39;link&#39; and provider as &#39;gpay&#39;</value>
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
            Qrcode = 3,

            /// <summary>
            /// Enum Post for value: post
            /// </summary>
            [EnumMember(Value = "post")]
            Post = 4
        }


        /// <summary>
        /// One of [\&quot;link\&quot;, \&quot;collect\&quot;, \&quot;qrcode\&quot;]. In an older version we used to support different channels like &#39;gpay&#39;, &#39;phonepe&#39; etc. However, we now support only the following channels - link, collect and qrcode. To process payments using gpay, you will have to provide channel as &#39;link&#39; and provider as &#39;gpay&#39;
        /// </summary>
        /// <value>One of [\&quot;link\&quot;, \&quot;collect\&quot;, \&quot;qrcode\&quot;]. In an older version we used to support different channels like &#39;gpay&#39;, &#39;phonepe&#39; etc. However, we now support only the following channels - link, collect and qrcode. To process payments using gpay, you will have to provide channel as &#39;link&#39; and provider as &#39;gpay&#39;</value>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public ChannelEnum? channel { get; set; }
        /// <summary>
        /// One of [\&quot;link\&quot;, \&quot;custom\&quot;, \&quot;form\&quot;]
        /// </summary>
        /// <value>One of [\&quot;link\&quot;, \&quot;custom\&quot;, \&quot;form\&quot;]</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum Link for value: link
            /// </summary>
            [EnumMember(Value = "link")]
            Link = 1,

            /// <summary>
            /// Enum Custom for value: custom
            /// </summary>
            [EnumMember(Value = "custom")]
            Custom = 2,

            /// <summary>
            /// Enum Form for value: form
            /// </summary>
            [EnumMember(Value = "form")]
            Form = 3,

            /// <summary>
            /// Enum Post for value: post
            /// </summary>
            [EnumMember(Value = "post")]
            Post = 4
        }


        /// <summary>
        /// One of [\&quot;link\&quot;, \&quot;custom\&quot;, \&quot;form\&quot;]
        /// </summary>
        /// <value>One of [\&quot;link\&quot;, \&quot;custom\&quot;, \&quot;form\&quot;]</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public ActionEnum? action { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayOrderEntity" /> class.
        /// </summary>
        /// <param name="paymentAmount">total amount payable.</param>
        /// <param name="cfPaymentId">Payment identifier created by Cashfree.</param>
        /// <param name="paymentMethod">One of [\&quot;upi\&quot;, \&quot;netbanking\&quot;, \&quot;card\&quot;, \&quot;app\&quot;, \&quot;cardless_emi\&quot;, \&quot;paylater\&quot;, \&quot;banktransfer\&quot;] .</param>
        /// <param name="channel">One of [\&quot;link\&quot;, \&quot;collect\&quot;, \&quot;qrcode\&quot;]. In an older version we used to support different channels like &#39;gpay&#39;, &#39;phonepe&#39; etc. However, we now support only the following channels - link, collect and qrcode. To process payments using gpay, you will have to provide channel as &#39;link&#39; and provider as &#39;gpay&#39;.</param>
        /// <param name="action">One of [\&quot;link\&quot;, \&quot;custom\&quot;, \&quot;form\&quot;].</param>
        /// <param name="data">data.</param>
        public PayOrderEntity(decimal? paymentAmount = default(decimal?), string? cfPaymentId = default(string?), PaymentMethodEnum? paymentMethod = default(PaymentMethodEnum??), ChannelEnum? channel = default(ChannelEnum??), ActionEnum? action = default(ActionEnum??), OrderPayData? data = default(OrderPayData?))
        {
            this.payment_amount = paymentAmount;
            this.cf_payment_id = cfPaymentId;
            this.payment_method = paymentMethod;
            this.channel = channel;
            this.action = action;
            this.data = data;
        }

        /// <summary>
        /// total amount payable
        /// </summary>
        /// <value>total amount payable</value>
        [DataMember(Name = "payment_amount", EmitDefaultValue = false)]
        public decimal? payment_amount { get; set; }

        /// <summary>
        /// Payment identifier created by Cashfree
        /// </summary>
        /// <value>Payment identifier created by Cashfree</value>
        [DataMember(Name = "cf_payment_id", EmitDefaultValue = false)]
        public string? cf_payment_id { get; set; }

        /// <summary>
        /// Gets or Sets data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public OrderPayData? data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PayOrderEntity {\n");
            sb.Append("  payment_amount: ").Append(payment_amount).Append("\n");
            sb.Append("  cf_payment_id: ").Append(cf_payment_id).Append("\n");
            sb.Append("  payment_method: ").Append(payment_method).Append("\n");
            sb.Append("  channel: ").Append(channel).Append("\n");
            sb.Append("  action: ").Append(action).Append("\n");
            sb.Append("  data: ").Append(data).Append("\n");
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
            return this.Equals(input as PayOrderEntity);
        }

        /// <summary>
        /// Returns true if PayOrderEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of PayOrderEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayOrderEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.payment_amount == input.payment_amount ||
                    this.payment_amount.Equals(input.payment_amount)
                ) && 
                (
                    this.cf_payment_id == input.cf_payment_id ||
                    (this.cf_payment_id != null &&
                    this.cf_payment_id.Equals(input.cf_payment_id))
                ) && 
                (
                    this.payment_method == input.payment_method ||
                    this.payment_method.Equals(input.payment_method)
                ) && 
                (
                    this.channel == input.channel ||
                    this.channel.Equals(input.channel)
                ) && 
                (
                    this.action == input.action ||
                    this.action.Equals(input.action)
                ) && 
                (
                    this.data == input.data ||
                    (this.data != null &&
                    this.data.Equals(input.data))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringpayment_amount) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringpayment_amount);
            if (deserializedJsonString.ContainsKey("payment_amount")) {
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
                hashCode = (hashCode * 59) + this.payment_amount.GetHashCode();
                if (this.cf_payment_id != null)
                {
                    hashCode = (hashCode * 59) + this.cf_payment_id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.payment_method.GetHashCode();
                hashCode = (hashCode * 59) + this.channel.GetHashCode();
                hashCode = (hashCode * 59) + this.action.GetHashCode();
                if (this.data != null)
                {
                    hashCode = (hashCode * 59) + this.data.GetHashCode();
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

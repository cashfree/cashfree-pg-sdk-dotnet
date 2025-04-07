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
    /// Complete object for the pay api that uses payment method objects
    /// </summary>
    [DataContract(Name = "PayOrderRequest")]
    public class PayOrderRequest : IEquatable<PayOrderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayOrderRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PayOrderRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PayOrderRequest" /> class.
        /// </summary>
        /// <param name="paymentSessionId">paymentSessionId (required).</param>
        /// <param name="paymentMethod">paymentMethod (required).</param>
        /// <param name="saveInstrument">saveInstrument.</param>
        /// <param name="offerId">This is required if any offers needs to be applied to the order..</param>
        public PayOrderRequest(string paymentSessionId = default(string), PayOrderRequestPaymentMethod paymentMethod = default(PayOrderRequestPaymentMethod), bool? saveInstrument = default(bool?), string? offerId = default(string?))
        {
            // to ensure "paymentSessionId" is required (not null)
            if (paymentSessionId == null)
            {
                throw new ArgumentNullException("paymentSessionId is a required property for PayOrderRequest and cannot be null");
            }
            this.payment_session_id = paymentSessionId;
            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null)
            {
                throw new ArgumentNullException("paymentMethod is a required property for PayOrderRequest and cannot be null");
            }
            this.payment_method = paymentMethod;
            this.save_instrument = saveInstrument;
            this.offer_id = offerId;
        }

        /// <summary>
        /// Gets or Sets payment_session_id
        /// </summary>
        /// <example>session__CvcEmNKDkmERQrxnx39ibhJ3Ii034pjc8ZVxf3qcgEXCWlgDDlHRgz2XYZCqpajDQSXMMtCusPgOIxYP2LZx0-05p39gC2Vgmq1RAj--gcn</example>
        [DataMember(Name = "payment_session_id", IsRequired = true, EmitDefaultValue = true)]
        public string payment_session_id { get; set; }

        /// <summary>
        /// Gets or Sets payment_method
        /// </summary>
        [DataMember(Name = "payment_method", IsRequired = true, EmitDefaultValue = true)]
        public PayOrderRequestPaymentMethod payment_method { get; set; }

        /// <summary>
        /// Gets or Sets save_instrument
        /// </summary>
        [DataMember(Name = "save_instrument", EmitDefaultValue = true)]
        public bool? save_instrument { get; set; }

        /// <summary>
        /// This is required if any offers needs to be applied to the order.
        /// </summary>
        /// <value>This is required if any offers needs to be applied to the order.</value>
        /// <example>faa6cc05-d1e2-401c-b0cf-0c9db3ff0f0b</example>
        [DataMember(Name = "offer_id", EmitDefaultValue = false)]
        public string? offer_id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PayOrderRequest {\n");
            sb.Append("  payment_session_id: ").Append(payment_session_id).Append("\n");
            sb.Append("  payment_method: ").Append(payment_method).Append("\n");
            sb.Append("  save_instrument: ").Append(save_instrument).Append("\n");
            sb.Append("  offer_id: ").Append(offer_id).Append("\n");
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
            return this.Equals(input as PayOrderRequest);
        }

        /// <summary>
        /// Returns true if PayOrderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PayOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayOrderRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.payment_session_id == input.payment_session_id ||
                    (this.payment_session_id != null &&
                    this.payment_session_id.Equals(input.payment_session_id))
                ) && 
                (
                    this.payment_method == input.payment_method ||
                    (this.payment_method != null &&
                    this.payment_method.Equals(input.payment_method))
                ) && 
                (
                    this.save_instrument == input.save_instrument ||
                    this.save_instrument.Equals(input.save_instrument)
                ) && 
                (
                    this.offer_id == input.offer_id ||
                    (this.offer_id != null &&
                    this.offer_id.Equals(input.offer_id))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringpayment_session_id) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringpayment_session_id);
            if (deserializedJsonString.ContainsKey("payment_session_id")) {
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
                if (this.payment_session_id != null)
                {
                    hashCode = (hashCode * 59) + this.payment_session_id.GetHashCode();
                }
                if (this.payment_method != null)
                {
                    hashCode = (hashCode * 59) + this.payment_method.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.save_instrument.GetHashCode();
                if (this.offer_id != null)
                {
                    hashCode = (hashCode * 59) + this.offer_id.GetHashCode();
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

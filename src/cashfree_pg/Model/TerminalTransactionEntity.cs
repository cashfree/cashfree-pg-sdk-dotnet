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
    /// Create terminal response object
    /// </summary>
    [DataContract(Name = "TerminalTransactionEntity")]
    public class TerminalTransactionEntity : IEquatable<TerminalTransactionEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalTransactionEntity" /> class.
        /// </summary>
        /// <param name="cfPaymentId">cfPaymentId.</param>
        /// <param name="paymentAmount">paymentAmount.</param>
        /// <param name="paymentMethod">paymentMethod.</param>
        /// <param name="paymentUrl">paymentUrl.</param>
        /// <param name="qrcode">qrcode.</param>
        /// <param name="timeout">timeout.</param>
        public TerminalTransactionEntity(string cfPaymentId = default(string), int paymentAmount = default(int), string paymentMethod = default(string), string paymentUrl = default(string), string qrcode = default(string), string timeout = default(string))
        {
            this.cf_payment_id = cfPaymentId;
            this.payment_amount = paymentAmount;
            this.payment_method = paymentMethod;
            this.payment_url = paymentUrl;
            this.qrcode = qrcode;
            this.timeout = timeout;
        }

        /// <summary>
        /// Gets or Sets cf_payment_id
        /// </summary>
        [DataMember(Name = "cf_payment_id", EmitDefaultValue = false)]
        public string cf_payment_id { get; set; }

        /// <summary>
        /// Gets or Sets payment_amount
        /// </summary>
        [DataMember(Name = "payment_amount", EmitDefaultValue = false)]
        public int payment_amount { get; set; }

        /// <summary>
        /// Gets or Sets payment_method
        /// </summary>
        [DataMember(Name = "payment_method", EmitDefaultValue = false)]
        public string payment_method { get; set; }

        /// <summary>
        /// Gets or Sets payment_url
        /// </summary>
        [DataMember(Name = "payment_url", EmitDefaultValue = false)]
        public string payment_url { get; set; }

        /// <summary>
        /// Gets or Sets qrcode
        /// </summary>
        [DataMember(Name = "qrcode", EmitDefaultValue = false)]
        public string qrcode { get; set; }

        /// <summary>
        /// Gets or Sets timeout
        /// </summary>
        [DataMember(Name = "timeout", EmitDefaultValue = false)]
        public string timeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TerminalTransactionEntity {\n");
            sb.Append("  cf_payment_id: ").Append(cf_payment_id).Append("\n");
            sb.Append("  payment_amount: ").Append(payment_amount).Append("\n");
            sb.Append("  payment_method: ").Append(payment_method).Append("\n");
            sb.Append("  payment_url: ").Append(payment_url).Append("\n");
            sb.Append("  qrcode: ").Append(qrcode).Append("\n");
            sb.Append("  timeout: ").Append(timeout).Append("\n");
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
            return this.Equals(input as TerminalTransactionEntity);
        }

        /// <summary>
        /// Returns true if TerminalTransactionEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of TerminalTransactionEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerminalTransactionEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cf_payment_id == input.cf_payment_id ||
                    (this.cf_payment_id != null &&
                    this.cf_payment_id.Equals(input.cf_payment_id))
                ) && 
                (
                    this.payment_amount == input.payment_amount ||
                    this.payment_amount.Equals(input.payment_amount)
                ) && 
                (
                    this.payment_method == input.payment_method ||
                    (this.payment_method != null &&
                    this.payment_method.Equals(input.payment_method))
                ) && 
                (
                    this.payment_url == input.payment_url ||
                    (this.payment_url != null &&
                    this.payment_url.Equals(input.payment_url))
                ) && 
                (
                    this.qrcode == input.qrcode ||
                    (this.qrcode != null &&
                    this.qrcode.Equals(input.qrcode))
                ) && 
                (
                    this.timeout == input.timeout ||
                    (this.timeout != null &&
                    this.timeout.Equals(input.timeout))
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
                if (this.cf_payment_id != null)
                {
                    hashCode = (hashCode * 59) + this.cf_payment_id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.payment_amount.GetHashCode();
                if (this.payment_method != null)
                {
                    hashCode = (hashCode * 59) + this.payment_method.GetHashCode();
                }
                if (this.payment_url != null)
                {
                    hashCode = (hashCode * 59) + this.payment_url.GetHashCode();
                }
                if (this.qrcode != null)
                {
                    hashCode = (hashCode * 59) + this.qrcode.GetHashCode();
                }
                if (this.timeout != null)
                {
                    hashCode = (hashCode * 59) + this.timeout.GetHashCode();
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

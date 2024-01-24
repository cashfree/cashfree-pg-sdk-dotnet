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
    /// Request body to create a terminal transaction
    /// </summary>
    [DataContract(Name = "CreateTerminalTransactionRequest")]
    public class CreateTerminalTransactionRequest : IEquatable<CreateTerminalTransactionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTerminalTransactionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTerminalTransactionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTerminalTransactionRequest" /> class.
        /// </summary>
        /// <param name="cfOrderId">cashfree order ID that was returned while creating an order. (required).</param>
        /// <param name="cfTerminalId">cashfree terminal id. this is a required parameter when you do not provide the terminal phone number..</param>
        /// <param name="paymentMethod">mention the payment method used for the transaction. possible values - QR_CODE, LINK. (required).</param>
        /// <param name="terminalPhoneNo">agent mobile number assigned to the terminal. this is a required parameter when you do not provide the cf_terminal_id..</param>
        public CreateTerminalTransactionRequest(long cfOrderId = default(long), long cfTerminalId = default(long), string paymentMethod = default(string), string terminalPhoneNo = default(string))
        {
            this.cf_order_id = cfOrderId;
            // to ensure "paymentMethod" is required (not null)
            if (paymentMethod == null)
            {
                throw new ArgumentNullException("paymentMethod is a required property for CreateTerminalTransactionRequest and cannot be null");
            }
            this.payment_method = paymentMethod;
            this.cf_terminal_id = cfTerminalId;
            this.terminal_phone_no = terminalPhoneNo;
        }

        /// <summary>
        /// cashfree order ID that was returned while creating an order.
        /// </summary>
        /// <value>cashfree order ID that was returned while creating an order.</value>
        [DataMember(Name = "cf_order_id", IsRequired = true, EmitDefaultValue = true)]
        public long cf_order_id { get; set; }

        /// <summary>
        /// cashfree terminal id. this is a required parameter when you do not provide the terminal phone number.
        /// </summary>
        /// <value>cashfree terminal id. this is a required parameter when you do not provide the terminal phone number.</value>
        [DataMember(Name = "cf_terminal_id", EmitDefaultValue = false)]
        public long cf_terminal_id { get; set; }

        /// <summary>
        /// mention the payment method used for the transaction. possible values - QR_CODE, LINK.
        /// </summary>
        /// <value>mention the payment method used for the transaction. possible values - QR_CODE, LINK.</value>
        [DataMember(Name = "payment_method", IsRequired = true, EmitDefaultValue = true)]
        public string payment_method { get; set; }

        /// <summary>
        /// agent mobile number assigned to the terminal. this is a required parameter when you do not provide the cf_terminal_id.
        /// </summary>
        /// <value>agent mobile number assigned to the terminal. this is a required parameter when you do not provide the cf_terminal_id.</value>
        [DataMember(Name = "terminal_phone_no", EmitDefaultValue = false)]
        public string terminal_phone_no { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateTerminalTransactionRequest {\n");
            sb.Append("  cf_order_id: ").Append(cf_order_id).Append("\n");
            sb.Append("  cf_terminal_id: ").Append(cf_terminal_id).Append("\n");
            sb.Append("  payment_method: ").Append(payment_method).Append("\n");
            sb.Append("  terminal_phone_no: ").Append(terminal_phone_no).Append("\n");
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
            return this.Equals(input as CreateTerminalTransactionRequest);
        }

        /// <summary>
        /// Returns true if CreateTerminalTransactionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTerminalTransactionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTerminalTransactionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cf_order_id == input.cf_order_id ||
                    this.cf_order_id.Equals(input.cf_order_id)
                ) && 
                (
                    this.cf_terminal_id == input.cf_terminal_id ||
                    this.cf_terminal_id.Equals(input.cf_terminal_id)
                ) && 
                (
                    this.payment_method == input.payment_method ||
                    (this.payment_method != null &&
                    this.payment_method.Equals(input.payment_method))
                ) && 
                (
                    this.terminal_phone_no == input.terminal_phone_no ||
                    (this.terminal_phone_no != null &&
                    this.terminal_phone_no.Equals(input.terminal_phone_no))
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
                hashCode = (hashCode * 59) + this.cf_order_id.GetHashCode();
                hashCode = (hashCode * 59) + this.cf_terminal_id.GetHashCode();
                if (this.payment_method != null)
                {
                    hashCode = (hashCode * 59) + this.payment_method.GetHashCode();
                }
                if (this.terminal_phone_no != null)
                {
                    hashCode = (hashCode * 59) + this.terminal_phone_no.GetHashCode();
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
            // payment_method (string) maxLength
            if (this.payment_method != null && this.payment_method.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for payment_method, length must be less than 100.", new [] { "payment_method" });
            }

            // payment_method (string) minLength
            if (this.payment_method != null && this.payment_method.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for payment_method, length must be greater than 3.", new [] { "payment_method" });
            }

            // terminal_phone_no (string) maxLength
            if (this.terminal_phone_no != null && this.terminal_phone_no.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for terminal_phone_no, length must be less than 10.", new [] { "terminal_phone_no" });
            }

            // terminal_phone_no (string) minLength
            if (this.terminal_phone_no != null && this.terminal_phone_no.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for terminal_phone_no, length must be greater than 10.", new [] { "terminal_phone_no" });
            }

            yield break;
        }
    }

}

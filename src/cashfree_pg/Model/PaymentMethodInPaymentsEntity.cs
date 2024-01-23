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
    /// payment methods all
    /// </summary>
    [DataContract(Name = "PaymentMethodInPaymentsEntity")]
    public class PaymentMethodInPaymentsEntity : IEquatable<PaymentMethodInPaymentsEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodInPaymentsEntity" /> class.
        /// </summary>
        /// <param name="paymentMethod">paymentMethod.</param>
        public PaymentMethodInPaymentsEntity(PaymentMethodInPaymentsEntityPaymentMethod paymentMethod = default(PaymentMethodInPaymentsEntityPaymentMethod))
        {
            this.payment_method = paymentMethod;
        }

        /// <summary>
        /// Gets or Sets payment_method
        /// </summary>
        [DataMember(Name = "payment_method", EmitDefaultValue = false)]
        public PaymentMethodInPaymentsEntityPaymentMethod payment_method { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodInPaymentsEntity {\n");
            sb.Append("  payment_method: ").Append(payment_method).Append("\n");
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
            return this.Equals(input as PaymentMethodInPaymentsEntity);
        }

        /// <summary>
        /// Returns true if PaymentMethodInPaymentsEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodInPaymentsEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodInPaymentsEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.payment_method == input.payment_method ||
                    (this.payment_method != null &&
                    this.payment_method.Equals(input.payment_method))
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
                if (this.payment_method != null)
                {
                    hashCode = (hashCode * 59) + this.payment_method.GetHashCode();
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

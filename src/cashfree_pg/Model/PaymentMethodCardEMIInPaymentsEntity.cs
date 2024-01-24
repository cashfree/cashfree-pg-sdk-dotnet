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
    /// payment method card emi object in payment entity
    /// </summary>
    [DataContract(Name = "PaymentMethodCardEMIInPaymentsEntity")]
    public class PaymentMethodCardEMIInPaymentsEntity : IEquatable<PaymentMethodCardEMIInPaymentsEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodCardEMIInPaymentsEntity" /> class.
        /// </summary>
        /// <param name="emi">emi.</param>
        public PaymentMethodCardEMIInPaymentsEntity(PaymentMethodCardEMIInPaymentsEntityEmi emi = default(PaymentMethodCardEMIInPaymentsEntityEmi))
        {
            this.emi = emi;
        }

        /// <summary>
        /// Gets or Sets emi
        /// </summary>
        [DataMember(Name = "emi", EmitDefaultValue = false)]
        public PaymentMethodCardEMIInPaymentsEntityEmi emi { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodCardEMIInPaymentsEntity {\n");
            sb.Append("  emi: ").Append(emi).Append("\n");
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
            return this.Equals(input as PaymentMethodCardEMIInPaymentsEntity);
        }

        /// <summary>
        /// Returns true if PaymentMethodCardEMIInPaymentsEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodCardEMIInPaymentsEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodCardEMIInPaymentsEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.emi == input.emi ||
                    (this.emi != null &&
                    this.emi.Equals(input.emi))
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
                if (this.emi != null)
                {
                    hashCode = (hashCode * 59) + this.emi.GetHashCode();
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
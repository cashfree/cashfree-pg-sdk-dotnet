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
    /// paylater payment method object for pay api
    /// </summary>
    [DataContract(Name = "PaymentMethodPaylaterInPaymentsEntity")]
    public class PaymentMethodPaylaterInPaymentsEntity : IEquatable<PaymentMethodPaylaterInPaymentsEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodPaylaterInPaymentsEntity" /> class.
        /// </summary>
        /// <param name="paylater">paylater.</param>
        public PaymentMethodPaylaterInPaymentsEntity(PaymentMethodAppInPaymentsEntityApp? paylater = default(PaymentMethodAppInPaymentsEntityApp?))
        {
            this.paylater = paylater;
        }

        /// <summary>
        /// Gets or Sets paylater
        /// </summary>
        [DataMember(Name = "paylater", EmitDefaultValue = false)]
        public PaymentMethodAppInPaymentsEntityApp? paylater { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodPaylaterInPaymentsEntity {\n");
            sb.Append("  paylater: ").Append(paylater).Append("\n");
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
            return this.Equals(input as PaymentMethodPaylaterInPaymentsEntity);
        }

        /// <summary>
        /// Returns true if PaymentMethodPaylaterInPaymentsEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodPaylaterInPaymentsEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodPaylaterInPaymentsEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.paylater == input.paylater ||
                    (this.paylater != null &&
                    this.paylater.Equals(input.paylater))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringpaylater) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringpaylater);
            if (deserializedJsonString.ContainsKey("paylater")) {
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
                if (this.paylater != null)
                {
                    hashCode = (hashCode * 59) + this.paylater.GetHashCode();
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

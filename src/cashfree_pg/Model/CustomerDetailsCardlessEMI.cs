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
    /// Details of the customer for whom eligibility is being checked.
    /// </summary>
    [DataContract(Name = "CustomerDetailsCardlessEMI")]
    public class CustomerDetailsCardlessEMI : IEquatable<CustomerDetailsCardlessEMI>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerDetailsCardlessEMI" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerDetailsCardlessEMI() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerDetailsCardlessEMI" /> class.
        /// </summary>
        /// <param name="customerPhone">Phone Number of the customer (required).</param>
        public CustomerDetailsCardlessEMI(string customerPhone = default(string))
        {
            // to ensure "customerPhone" is required (not null)
            if (customerPhone == null)
            {
                throw new ArgumentNullException("customerPhone is a required property for CustomerDetailsCardlessEMI and cannot be null");
            }
            this.customer_phone = customerPhone;
        }

        /// <summary>
        /// Phone Number of the customer
        /// </summary>
        /// <value>Phone Number of the customer</value>
        /// <example>9898989898</example>
        [DataMember(Name = "customer_phone", IsRequired = true, EmitDefaultValue = true)]
        public string customer_phone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerDetailsCardlessEMI {\n");
            sb.Append("  customer_phone: ").Append(customer_phone).Append("\n");
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
            return this.Equals(input as CustomerDetailsCardlessEMI);
        }

        /// <summary>
        /// Returns true if CustomerDetailsCardlessEMI instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerDetailsCardlessEMI to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerDetailsCardlessEMI input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.customer_phone == input.customer_phone ||
                    (this.customer_phone != null &&
                    this.customer_phone.Equals(input.customer_phone))
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
                if (this.customer_phone != null)
                {
                    hashCode = (hashCode * 59) + this.customer_phone.GetHashCode();
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
            // customer_phone (string) maxLength
            if (this.customer_phone != null && this.customer_phone.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for customer_phone, length must be less than 50.", new [] { "customer_phone" });
            }

            // customer_phone (string) minLength
            if (this.customer_phone != null && this.customer_phone.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for customer_phone, length must be greater than 3.", new [] { "customer_phone" });
            }

            yield break;
        }
    }

}
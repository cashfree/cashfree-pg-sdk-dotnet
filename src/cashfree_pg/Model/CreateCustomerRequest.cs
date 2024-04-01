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
    /// Request body to create a customer at cashfree
    /// </summary>
    [DataContract(Name = "CreateCustomerRequest")]
    public class CreateCustomerRequest : IEquatable<CreateCustomerRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomerRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateCustomerRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCustomerRequest" /> class.
        /// </summary>
        /// <param name="customerPhone">Customer Phone Number (required).</param>
        /// <param name="customerEmail">Customer Email.</param>
        /// <param name="customerName">Customer Name.</param>
        public CreateCustomerRequest(string customerPhone = default(string), string? customerEmail = default(string?), string? customerName = default(string?))
        {
            // to ensure "customerPhone" is required (not null)
            if (customerPhone == null)
            {
                throw new ArgumentNullException("customerPhone is a required property for CreateCustomerRequest and cannot be null");
            }
            this.customer_phone = customerPhone;
            this.customer_email = customerEmail;
            this.customer_name = customerName;
        }

        /// <summary>
        /// Customer Phone Number
        /// </summary>
        /// <value>Customer Phone Number</value>
        /// <example>9999999999</example>
        [DataMember(Name = "customer_phone", IsRequired = true, EmitDefaultValue = true)]
        public string customer_phone { get; set; }

        /// <summary>
        /// Customer Email
        /// </summary>
        /// <value>Customer Email</value>
        /// <example>example@test.com</example>
        [DataMember(Name = "customer_email", EmitDefaultValue = false)]
        public string? customer_email { get; set; }

        /// <summary>
        /// Customer Name
        /// </summary>
        /// <value>Customer Name</value>
        /// <example>YourCustomer</example>
        [DataMember(Name = "customer_name", EmitDefaultValue = false)]
        public string? customer_name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateCustomerRequest {\n");
            sb.Append("  customer_phone: ").Append(customer_phone).Append("\n");
            sb.Append("  customer_email: ").Append(customer_email).Append("\n");
            sb.Append("  customer_name: ").Append(customer_name).Append("\n");
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
            return this.Equals(input as CreateCustomerRequest);
        }

        /// <summary>
        /// Returns true if CreateCustomerRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateCustomerRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateCustomerRequest input)
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
                ) && 
                (
                    this.customer_email == input.customer_email ||
                    (this.customer_email != null &&
                    this.customer_email.Equals(input.customer_email))
                ) && 
                (
                    this.customer_name == input.customer_name ||
                    (this.customer_name != null &&
                    this.customer_name.Equals(input.customer_name))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringcustomer_phone) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringcustomer_phone);
            if (deserializedJsonString.ContainsKey("customer_phone")) {
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
                if (this.customer_phone != null)
                {
                    hashCode = (hashCode * 59) + this.customer_phone.GetHashCode();
                }
                if (this.customer_email != null)
                {
                    hashCode = (hashCode * 59) + this.customer_email.GetHashCode();
                }
                if (this.customer_name != null)
                {
                    hashCode = (hashCode * 59) + this.customer_name.GetHashCode();
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
            if (this.customer_phone != null && this.customer_phone.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for customer_phone, length must be less than 10.", new [] { "customer_phone" });
            }

            // customer_phone (string) minLength
            if (this.customer_phone != null && this.customer_phone.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for customer_phone, length must be greater than 10.", new [] { "customer_phone" });
            }

            yield break;
        }
    }

}

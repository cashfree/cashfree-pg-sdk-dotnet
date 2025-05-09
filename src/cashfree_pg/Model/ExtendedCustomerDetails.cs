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
    /// Recent Customer details associated with the order.
    /// </summary>
    [DataContract(Name = "ExtendedCustomerDetails")]
    public class ExtendedCustomerDetails : IEquatable<ExtendedCustomerDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExtendedCustomerDetails" /> class.
        /// </summary>
        /// <param name="customerId">A unique identifier for the customer. Use alphanumeric values only..</param>
        /// <param name="customerEmail">Customer email address..</param>
        /// <param name="customerPhone">Customer phone number..</param>
        /// <param name="customerName">Name of the customer..</param>
        /// <param name="customerUid">Customer identifier at Cashfree. You will get this when you create/get customer.</param>
        public ExtendedCustomerDetails(string? customerId = default(string?), string? customerEmail = default(string?), string? customerPhone = default(string?), string? customerName = default(string?), string? customerUid = default(string?))
        {
            this.customer_id = customerId;
            this.customer_email = customerEmail;
            this.customer_phone = customerPhone;
            this.customer_name = customerName;
            this.customer_uid = customerUid;
        }

        /// <summary>
        /// A unique identifier for the customer. Use alphanumeric values only.
        /// </summary>
        /// <value>A unique identifier for the customer. Use alphanumeric values only.</value>
        [DataMember(Name = "customer_id", EmitDefaultValue = false)]
        public string? customer_id { get; set; }

        /// <summary>
        /// Customer email address.
        /// </summary>
        /// <value>Customer email address.</value>
        [DataMember(Name = "customer_email", EmitDefaultValue = false)]
        public string? customer_email { get; set; }

        /// <summary>
        /// Customer phone number.
        /// </summary>
        /// <value>Customer phone number.</value>
        [DataMember(Name = "customer_phone", EmitDefaultValue = false)]
        public string? customer_phone { get; set; }

        /// <summary>
        /// Name of the customer.
        /// </summary>
        /// <value>Name of the customer.</value>
        [DataMember(Name = "customer_name", EmitDefaultValue = false)]
        public string? customer_name { get; set; }

        /// <summary>
        /// Customer identifier at Cashfree. You will get this when you create/get customer
        /// </summary>
        /// <value>Customer identifier at Cashfree. You will get this when you create/get customer</value>
        [DataMember(Name = "customer_uid", EmitDefaultValue = false)]
        public string? customer_uid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExtendedCustomerDetails {\n");
            sb.Append("  customer_id: ").Append(customer_id).Append("\n");
            sb.Append("  customer_email: ").Append(customer_email).Append("\n");
            sb.Append("  customer_phone: ").Append(customer_phone).Append("\n");
            sb.Append("  customer_name: ").Append(customer_name).Append("\n");
            sb.Append("  customer_uid: ").Append(customer_uid).Append("\n");
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
            return this.Equals(input as ExtendedCustomerDetails);
        }

        /// <summary>
        /// Returns true if ExtendedCustomerDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ExtendedCustomerDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExtendedCustomerDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.customer_id == input.customer_id ||
                    (this.customer_id != null &&
                    this.customer_id.Equals(input.customer_id))
                ) && 
                (
                    this.customer_email == input.customer_email ||
                    (this.customer_email != null &&
                    this.customer_email.Equals(input.customer_email))
                ) && 
                (
                    this.customer_phone == input.customer_phone ||
                    (this.customer_phone != null &&
                    this.customer_phone.Equals(input.customer_phone))
                ) && 
                (
                    this.customer_name == input.customer_name ||
                    (this.customer_name != null &&
                    this.customer_name.Equals(input.customer_name))
                ) && 
                (
                    this.customer_uid == input.customer_uid ||
                    (this.customer_uid != null &&
                    this.customer_uid.Equals(input.customer_uid))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringcustomer_id) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringcustomer_id);
            if (deserializedJsonString.ContainsKey("customer_id")) {
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
                if (this.customer_id != null)
                {
                    hashCode = (hashCode * 59) + this.customer_id.GetHashCode();
                }
                if (this.customer_email != null)
                {
                    hashCode = (hashCode * 59) + this.customer_email.GetHashCode();
                }
                if (this.customer_phone != null)
                {
                    hashCode = (hashCode * 59) + this.customer_phone.GetHashCode();
                }
                if (this.customer_name != null)
                {
                    hashCode = (hashCode * 59) + this.customer_name.GetHashCode();
                }
                if (this.customer_uid != null)
                {
                    hashCode = (hashCode * 59) + this.customer_uid.GetHashCode();
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
            // customer_id (string) maxLength
            if (this.customer_id != null && this.customer_id.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for customer_id, length must be less than 50.", new [] { "customer_id" });
            }

            // customer_id (string) minLength
            if (this.customer_id != null && this.customer_id.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for customer_id, length must be greater than 3.", new [] { "customer_id" });
            }

            // customer_email (string) maxLength
            if (this.customer_email != null && this.customer_email.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for customer_email, length must be less than 100.", new [] { "customer_email" });
            }

            // customer_email (string) minLength
            if (this.customer_email != null && this.customer_email.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for customer_email, length must be greater than 3.", new [] { "customer_email" });
            }

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

            // customer_name (string) maxLength
            if (this.customer_name != null && this.customer_name.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for customer_name, length must be less than 100.", new [] { "customer_name" });
            }

            // customer_name (string) minLength
            if (this.customer_name != null && this.customer_name.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for customer_name, length must be greater than 3.", new [] { "customer_name" });
            }

            yield break;
        }
    }

}

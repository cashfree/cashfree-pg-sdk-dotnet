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
    /// The customer details that are necessary. Note that you can pass dummy details if your use case does not require the customer details.
    /// </summary>
    [DataContract(Name = "CustomerDetails")]
    public class CustomerDetails : IEquatable<CustomerDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CustomerDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerDetails" /> class.
        /// </summary>
        /// <param name="customerId">A unique identifier for the customer. Use alphanumeric values only. (required).</param>
        /// <param name="customerEmail">Customer email address..</param>
        /// <param name="customerPhone">Customer phone number. (required).</param>
        /// <param name="customerName">Name of the customer..</param>
        /// <param name="customerBankAccountNumber">Customer bank account. Required if you want to do a bank account check (TPV).</param>
        /// <param name="customerBankIfsc">Customer bank IFSC. Required if you want to do a bank account check (TPV).</param>
        /// <param name="customerBankCode">Customer bank code. Required for net banking payments, if you want to do a bank account check (TPV).</param>
        public CustomerDetails(string customerId = default(string), string customerEmail = default(string), string customerPhone = default(string), string customerName = default(string), string customerBankAccountNumber = default(string), string customerBankIfsc = default(string), decimal customerBankCode = default(decimal))
        {
            // to ensure "customerId" is required (not null)
            if (customerId == null)
            {
                throw new ArgumentNullException("customerId is a required property for CustomerDetails and cannot be null");
            }
            this.customer_id = customerId;
            // to ensure "customerPhone" is required (not null)
            if (customerPhone == null)
            {
                throw new ArgumentNullException("customerPhone is a required property for CustomerDetails and cannot be null");
            }
            this.customer_phone = customerPhone;
            this.customer_email = customerEmail;
            this.customer_name = customerName;
            this.customer_bank_account_number = customerBankAccountNumber;
            this.customer_bank_ifsc = customerBankIfsc;
            this.customer_bank_code = customerBankCode;
        }

        /// <summary>
        /// A unique identifier for the customer. Use alphanumeric values only.
        /// </summary>
        /// <value>A unique identifier for the customer. Use alphanumeric values only.</value>
        [DataMember(Name = "customer_id", IsRequired = true, EmitDefaultValue = true)]
        public string customer_id { get; set; }

        /// <summary>
        /// Customer email address.
        /// </summary>
        /// <value>Customer email address.</value>
        [DataMember(Name = "customer_email", EmitDefaultValue = false)]
        public string customer_email { get; set; }

        /// <summary>
        /// Customer phone number.
        /// </summary>
        /// <value>Customer phone number.</value>
        [DataMember(Name = "customer_phone", IsRequired = true, EmitDefaultValue = true)]
        public string customer_phone { get; set; }

        /// <summary>
        /// Name of the customer.
        /// </summary>
        /// <value>Name of the customer.</value>
        [DataMember(Name = "customer_name", EmitDefaultValue = false)]
        public string customer_name { get; set; }

        /// <summary>
        /// Customer bank account. Required if you want to do a bank account check (TPV)
        /// </summary>
        /// <value>Customer bank account. Required if you want to do a bank account check (TPV)</value>
        [DataMember(Name = "customer_bank_account_number", EmitDefaultValue = false)]
        public string customer_bank_account_number { get; set; }

        /// <summary>
        /// Customer bank IFSC. Required if you want to do a bank account check (TPV)
        /// </summary>
        /// <value>Customer bank IFSC. Required if you want to do a bank account check (TPV)</value>
        [DataMember(Name = "customer_bank_ifsc", EmitDefaultValue = false)]
        public string customer_bank_ifsc { get; set; }

        /// <summary>
        /// Customer bank code. Required for net banking payments, if you want to do a bank account check (TPV)
        /// </summary>
        /// <value>Customer bank code. Required for net banking payments, if you want to do a bank account check (TPV)</value>
        [DataMember(Name = "customer_bank_code", EmitDefaultValue = false)]
        public decimal customer_bank_code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomerDetails {\n");
            sb.Append("  customer_id: ").Append(customer_id).Append("\n");
            sb.Append("  customer_email: ").Append(customer_email).Append("\n");
            sb.Append("  customer_phone: ").Append(customer_phone).Append("\n");
            sb.Append("  customer_name: ").Append(customer_name).Append("\n");
            sb.Append("  customer_bank_account_number: ").Append(customer_bank_account_number).Append("\n");
            sb.Append("  customer_bank_ifsc: ").Append(customer_bank_ifsc).Append("\n");
            sb.Append("  customer_bank_code: ").Append(customer_bank_code).Append("\n");
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
            return this.Equals(input as CustomerDetails);
        }

        /// <summary>
        /// Returns true if CustomerDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CustomerDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CustomerDetails input)
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
                    this.customer_bank_account_number == input.customer_bank_account_number ||
                    (this.customer_bank_account_number != null &&
                    this.customer_bank_account_number.Equals(input.customer_bank_account_number))
                ) && 
                (
                    this.customer_bank_ifsc == input.customer_bank_ifsc ||
                    (this.customer_bank_ifsc != null &&
                    this.customer_bank_ifsc.Equals(input.customer_bank_ifsc))
                ) && 
                (
                    this.customer_bank_code == input.customer_bank_code ||
                    this.customer_bank_code.Equals(input.customer_bank_code)
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
                if (this.customer_bank_account_number != null)
                {
                    hashCode = (hashCode * 59) + this.customer_bank_account_number.GetHashCode();
                }
                if (this.customer_bank_ifsc != null)
                {
                    hashCode = (hashCode * 59) + this.customer_bank_ifsc.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.customer_bank_code.GetHashCode();
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

            // customer_bank_account_number (string) maxLength
            if (this.customer_bank_account_number != null && this.customer_bank_account_number.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for customer_bank_account_number, length must be less than 20.", new [] { "customer_bank_account_number" });
            }

            // customer_bank_account_number (string) minLength
            if (this.customer_bank_account_number != null && this.customer_bank_account_number.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for customer_bank_account_number, length must be greater than 3.", new [] { "customer_bank_account_number" });
            }

            yield break;
        }
    }

}

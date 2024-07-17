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
    /// Subscription customer details.
    /// </summary>
    [DataContract(Name = "SubscriptionCustomerDetails")]
    public class SubscriptionCustomerDetails : IEquatable<SubscriptionCustomerDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCustomerDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubscriptionCustomerDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionCustomerDetails" /> class.
        /// </summary>
        /// <param name="customerName">Name of the customer..</param>
        /// <param name="customerEmail">Email of the customer. (required).</param>
        /// <param name="customerPhone">Phone number of the customer. (required).</param>
        /// <param name="customerBankHolderName">Bank holder name of the customer..</param>
        /// <param name="customerBankAccountNumber">Bank account number of the customer..</param>
        /// <param name="customerBankIfsc">IFSC code of the customer..</param>
        /// <param name="customerBankCode">Bank code of the customer..</param>
        /// <param name="customerBankAccountType">Bank account type of the customer..</param>
        public SubscriptionCustomerDetails(string? customerName = default(string?), string customerEmail = default(string), string customerPhone = default(string), string? customerBankHolderName = default(string?), string? customerBankAccountNumber = default(string?), string? customerBankIfsc = default(string?), string? customerBankCode = default(string?), string? customerBankAccountType = default(string?))
        {
            // to ensure "customerEmail" is required (not null)
            if (customerEmail == null)
            {
                throw new ArgumentNullException("customerEmail is a required property for SubscriptionCustomerDetails and cannot be null");
            }
            this.customer_email = customerEmail;
            // to ensure "customerPhone" is required (not null)
            if (customerPhone == null)
            {
                throw new ArgumentNullException("customerPhone is a required property for SubscriptionCustomerDetails and cannot be null");
            }
            this.customer_phone = customerPhone;
            this.customer_name = customerName;
            this.customer_bank_holder_name = customerBankHolderName;
            this.customer_bank_account_number = customerBankAccountNumber;
            this.customer_bank_ifsc = customerBankIfsc;
            this.customer_bank_code = customerBankCode;
            this.customer_bank_account_type = customerBankAccountType;
        }

        /// <summary>
        /// Name of the customer.
        /// </summary>
        /// <value>Name of the customer.</value>
        [DataMember(Name = "customer_name", EmitDefaultValue = false)]
        public string? customer_name { get; set; }

        /// <summary>
        /// Email of the customer.
        /// </summary>
        /// <value>Email of the customer.</value>
        [DataMember(Name = "customer_email", IsRequired = true, EmitDefaultValue = true)]
        public string customer_email { get; set; }

        /// <summary>
        /// Phone number of the customer.
        /// </summary>
        /// <value>Phone number of the customer.</value>
        [DataMember(Name = "customer_phone", IsRequired = true, EmitDefaultValue = true)]
        public string customer_phone { get; set; }

        /// <summary>
        /// Bank holder name of the customer.
        /// </summary>
        /// <value>Bank holder name of the customer.</value>
        [DataMember(Name = "customer_bank_holder_name", EmitDefaultValue = false)]
        public string? customer_bank_holder_name { get; set; }

        /// <summary>
        /// Bank account number of the customer.
        /// </summary>
        /// <value>Bank account number of the customer.</value>
        [DataMember(Name = "customer_bank_account_number", EmitDefaultValue = false)]
        public string? customer_bank_account_number { get; set; }

        /// <summary>
        /// IFSC code of the customer.
        /// </summary>
        /// <value>IFSC code of the customer.</value>
        [DataMember(Name = "customer_bank_ifsc", EmitDefaultValue = false)]
        public string? customer_bank_ifsc { get; set; }

        /// <summary>
        /// Bank code of the customer.
        /// </summary>
        /// <value>Bank code of the customer.</value>
        [DataMember(Name = "customer_bank_code", EmitDefaultValue = false)]
        public string? customer_bank_code { get; set; }

        /// <summary>
        /// Bank account type of the customer.
        /// </summary>
        /// <value>Bank account type of the customer.</value>
        [DataMember(Name = "customer_bank_account_type", EmitDefaultValue = false)]
        public string? customer_bank_account_type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionCustomerDetails {\n");
            sb.Append("  customer_name: ").Append(customer_name).Append("\n");
            sb.Append("  customer_email: ").Append(customer_email).Append("\n");
            sb.Append("  customer_phone: ").Append(customer_phone).Append("\n");
            sb.Append("  customer_bank_holder_name: ").Append(customer_bank_holder_name).Append("\n");
            sb.Append("  customer_bank_account_number: ").Append(customer_bank_account_number).Append("\n");
            sb.Append("  customer_bank_ifsc: ").Append(customer_bank_ifsc).Append("\n");
            sb.Append("  customer_bank_code: ").Append(customer_bank_code).Append("\n");
            sb.Append("  customer_bank_account_type: ").Append(customer_bank_account_type).Append("\n");
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
            return this.Equals(input as SubscriptionCustomerDetails);
        }

        /// <summary>
        /// Returns true if SubscriptionCustomerDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionCustomerDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionCustomerDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.customer_name == input.customer_name ||
                    (this.customer_name != null &&
                    this.customer_name.Equals(input.customer_name))
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
                    this.customer_bank_holder_name == input.customer_bank_holder_name ||
                    (this.customer_bank_holder_name != null &&
                    this.customer_bank_holder_name.Equals(input.customer_bank_holder_name))
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
                    (this.customer_bank_code != null &&
                    this.customer_bank_code.Equals(input.customer_bank_code))
                ) && 
                (
                    this.customer_bank_account_type == input.customer_bank_account_type ||
                    (this.customer_bank_account_type != null &&
                    this.customer_bank_account_type.Equals(input.customer_bank_account_type))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringcustomer_name) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringcustomer_name);
            if (deserializedJsonString.ContainsKey("customer_name")) {
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
                if (this.customer_name != null)
                {
                    hashCode = (hashCode * 59) + this.customer_name.GetHashCode();
                }
                if (this.customer_email != null)
                {
                    hashCode = (hashCode * 59) + this.customer_email.GetHashCode();
                }
                if (this.customer_phone != null)
                {
                    hashCode = (hashCode * 59) + this.customer_phone.GetHashCode();
                }
                if (this.customer_bank_holder_name != null)
                {
                    hashCode = (hashCode * 59) + this.customer_bank_holder_name.GetHashCode();
                }
                if (this.customer_bank_account_number != null)
                {
                    hashCode = (hashCode * 59) + this.customer_bank_account_number.GetHashCode();
                }
                if (this.customer_bank_ifsc != null)
                {
                    hashCode = (hashCode * 59) + this.customer_bank_ifsc.GetHashCode();
                }
                if (this.customer_bank_code != null)
                {
                    hashCode = (hashCode * 59) + this.customer_bank_code.GetHashCode();
                }
                if (this.customer_bank_account_type != null)
                {
                    hashCode = (hashCode * 59) + this.customer_bank_account_type.GetHashCode();
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

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
    /// Payment link customer entity
    /// </summary>
    [DataContract(Name = "LinkCustomerDetailsEntity")]
    public class LinkCustomerDetailsEntity : IEquatable<LinkCustomerDetailsEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkCustomerDetailsEntity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LinkCustomerDetailsEntity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkCustomerDetailsEntity" /> class.
        /// </summary>
        /// <param name="customerPhone">Customer phone number (required).</param>
        /// <param name="customerEmail">Customer email address.</param>
        /// <param name="customerName">Customer name.</param>
        public LinkCustomerDetailsEntity(string customerPhone = default(string), string? customerEmail = default(string?), string? customerName = default(string?))
        {
            // to ensure "customerPhone" is required (not null)
            if (customerPhone == null)
            {
                throw new ArgumentNullException("customerPhone is a required property for LinkCustomerDetailsEntity and cannot be null");
            }
            this.customer_phone = customerPhone;
            this.customer_email = customerEmail;
            this.customer_name = customerName;
        }

        /// <summary>
        /// Customer phone number
        /// </summary>
        /// <value>Customer phone number</value>
        [DataMember(Name = "customer_phone", IsRequired = true, EmitDefaultValue = true)]
        public string customer_phone { get; set; }

        /// <summary>
        /// Customer email address
        /// </summary>
        /// <value>Customer email address</value>
        [DataMember(Name = "customer_email", EmitDefaultValue = false)]
        public string? customer_email { get; set; }

        /// <summary>
        /// Customer name
        /// </summary>
        /// <value>Customer name</value>
        [DataMember(Name = "customer_name", EmitDefaultValue = false)]
        public string? customer_name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LinkCustomerDetailsEntity {\n");
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
            return this.Equals(input as LinkCustomerDetailsEntity);
        }

        /// <summary>
        /// Returns true if LinkCustomerDetailsEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkCustomerDetailsEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkCustomerDetailsEntity input)
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
            yield break;
        }
    }

}

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
    /// Filter for specific Payment Methods
    /// </summary>
    [DataContract(Name = "PaymentMethodsFilters")]
    public class PaymentMethodsFilters : IEquatable<PaymentMethodsFilters>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentMethodsFilters" /> class.
        /// </summary>
        /// <param name="paymentMethods">Array of payment methods to be filtered. This is optional, by default all payment methods will be returned. Possible values in [ &#39;debit_card&#39;, &#39;credit_card&#39;, &#39;prepaid_card&#39;, &#39;corporate_credit_card&#39;, &#39;upi&#39;, &#39;wallet&#39;, &#39;netbanking&#39;, &#39;banktransfer&#39;, &#39;paylater&#39;, &#39;paypal&#39;, &#39;debit_card_emi&#39;, &#39;credit_card_emi&#39;, &#39;upi_credit_card&#39;, &#39;upi_ppi&#39;, &#39;cardless_emi&#39;, &#39;account_based_payment&#39; ] .</param>
        public PaymentMethodsFilters(List<string> paymentMethods = default(List<string>))
        {
            this.payment_methods = paymentMethods;
        }

        /// <summary>
        /// Array of payment methods to be filtered. This is optional, by default all payment methods will be returned. Possible values in [ &#39;debit_card&#39;, &#39;credit_card&#39;, &#39;prepaid_card&#39;, &#39;corporate_credit_card&#39;, &#39;upi&#39;, &#39;wallet&#39;, &#39;netbanking&#39;, &#39;banktransfer&#39;, &#39;paylater&#39;, &#39;paypal&#39;, &#39;debit_card_emi&#39;, &#39;credit_card_emi&#39;, &#39;upi_credit_card&#39;, &#39;upi_ppi&#39;, &#39;cardless_emi&#39;, &#39;account_based_payment&#39; ] 
        /// </summary>
        /// <value>Array of payment methods to be filtered. This is optional, by default all payment methods will be returned. Possible values in [ &#39;debit_card&#39;, &#39;credit_card&#39;, &#39;prepaid_card&#39;, &#39;corporate_credit_card&#39;, &#39;upi&#39;, &#39;wallet&#39;, &#39;netbanking&#39;, &#39;banktransfer&#39;, &#39;paylater&#39;, &#39;paypal&#39;, &#39;debit_card_emi&#39;, &#39;credit_card_emi&#39;, &#39;upi_credit_card&#39;, &#39;upi_ppi&#39;, &#39;cardless_emi&#39;, &#39;account_based_payment&#39; ] </value>
        [DataMember(Name = "payment_methods", EmitDefaultValue = false)]
        public List<string> payment_methods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentMethodsFilters {\n");
            sb.Append("  payment_methods: ").Append(payment_methods).Append("\n");
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
            return this.Equals(input as PaymentMethodsFilters);
        }

        /// <summary>
        /// Returns true if PaymentMethodsFilters instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentMethodsFilters to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentMethodsFilters input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.payment_methods == input.payment_methods ||
                    this.payment_methods != null &&
                    input.payment_methods != null &&
                    this.payment_methods.SequenceEqual(input.payment_methods)
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringpayment_methods) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringpayment_methods);
            if (deserializedJsonString.ContainsKey("payment_methods")) {
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
                if (this.payment_methods != null)
                {
                    hashCode = (hashCode * 59) + this.payment_methods.GetHashCode();
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

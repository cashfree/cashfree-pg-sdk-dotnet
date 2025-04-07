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
    /// Allowed card issuing bank for the order
    /// </summary>
    [DataContract(Name = "OrderMeta_payment_methods_filters_filters_card_issuing_bank")]
    public class OrderMetaPaymentMethodsFiltersFiltersCardIssuingBank : IEquatable<OrderMetaPaymentMethodsFiltersFiltersCardIssuingBank>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderMetaPaymentMethodsFiltersFiltersCardIssuingBank" /> class.
        /// </summary>
        /// <param name="action">It accepts value of \&quot;ALLOW\&quot; and allows only those issuing bank present in it&#39;s neighbouring parameter \&quot;values\&quot;.</param>
        /// <param name="values">List of card issuing bank to be allowed for the order.</param>
        public OrderMetaPaymentMethodsFiltersFiltersCardIssuingBank(string? action = default(string?), List<string>? values = default(List<string>?))
        {
            this.action = action;
            this.values = values;
        }

        /// <summary>
        /// It accepts value of \&quot;ALLOW\&quot; and allows only those issuing bank present in it&#39;s neighbouring parameter \&quot;values\&quot;
        /// </summary>
        /// <value>It accepts value of \&quot;ALLOW\&quot; and allows only those issuing bank present in it&#39;s neighbouring parameter \&quot;values\&quot;</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string? action { get; set; }

        /// <summary>
        /// List of card issuing bank to be allowed for the order
        /// </summary>
        /// <value>List of card issuing bank to be allowed for the order</value>
        [DataMember(Name = "values", EmitDefaultValue = false)]
        public List<string>? values { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderMetaPaymentMethodsFiltersFiltersCardIssuingBank {\n");
            sb.Append("  action: ").Append(action).Append("\n");
            sb.Append("  values: ").Append(values).Append("\n");
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
            return this.Equals(input as OrderMetaPaymentMethodsFiltersFiltersCardIssuingBank);
        }

        /// <summary>
        /// Returns true if OrderMetaPaymentMethodsFiltersFiltersCardIssuingBank instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderMetaPaymentMethodsFiltersFiltersCardIssuingBank to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderMetaPaymentMethodsFiltersFiltersCardIssuingBank input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.action == input.action ||
                    (this.action != null &&
                    this.action.Equals(input.action))
                ) && 
                (
                    this.values == input.values ||
                    this.values != null &&
                    input.values != null &&
                    this.values.SequenceEqual(input.values)
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringaction) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringaction);
            if (deserializedJsonString.ContainsKey("action")) {
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
                if (this.action != null)
                {
                    hashCode = (hashCode * 59) + this.action.GetHashCode();
                }
                if (this.values != null)
                {
                    hashCode = (hashCode * 59) + this.values.GetHashCode();
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

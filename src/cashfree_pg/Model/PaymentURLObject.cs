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
    /// URL for payment retrieval for an order
    /// </summary>
    [DataContract(Name = "PaymentURLObject")]
    public class PaymentURLObject : IEquatable<PaymentURLObject>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentURLObject" /> class.
        /// </summary>
        /// <param name="url">url.</param>
        public PaymentURLObject(string url = default(string))
        {
            this.url = url;
        }

        /// <summary>
        /// Gets or Sets url
        /// </summary>
        /// <example>https://sandbox.cashfree.com/pg/orders/order_271vovQ3PTZAx3fDI0xtZbC4jkPET/payments</example>
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentURLObject {\n");
            sb.Append("  url: ").Append(url).Append("\n");
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
            return this.Equals(input as PaymentURLObject);
        }

        /// <summary>
        /// Returns true if PaymentURLObject instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentURLObject to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentURLObject input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.url == input.url ||
                    (this.url != null &&
                    this.url.Equals(input.url))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringurl) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringurl);
            if (deserializedJsonString.ContainsKey("url")) {
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
                if (this.url != null)
                {
                    hashCode = (hashCode * 59) + this.url.GetHashCode();
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

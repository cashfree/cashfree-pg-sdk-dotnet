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
    /// Offer object for wallet payment method
    /// </summary>
    [DataContract(Name = "OfferWallet")]
    public class OfferWallet : IEquatable<OfferWallet>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferWallet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OfferWallet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferWallet" /> class.
        /// </summary>
        /// <param name="app">app (required).</param>
        public OfferWallet(WalletOffer app = default(WalletOffer))
        {
            // to ensure "app" is required (not null)
            if (app == null)
            {
                throw new ArgumentNullException("app is a required property for OfferWallet and cannot be null");
            }
            this.app = app;
        }

        /// <summary>
        /// Gets or Sets app
        /// </summary>
        [DataMember(Name = "app", IsRequired = true, EmitDefaultValue = true)]
        public WalletOffer app { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OfferWallet {\n");
            sb.Append("  app: ").Append(app).Append("\n");
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
            return this.Equals(input as OfferWallet);
        }

        /// <summary>
        /// Returns true if OfferWallet instances are equal
        /// </summary>
        /// <param name="input">Instance of OfferWallet to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferWallet input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.app == input.app ||
                    (this.app != null &&
                    this.app.Equals(input.app))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringapp) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringapp);
            if (deserializedJsonString.ContainsKey("app")) {
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
                if (this.app != null)
                {
                    hashCode = (hashCode * 59) + this.app.GetHashCode();
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

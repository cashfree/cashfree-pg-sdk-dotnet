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
    /// Request body to update soundbox vpa
    /// </summary>
    [DataContract(Name = "UpdateSoundboxVpaRequest")]
    public class UpdateSoundboxVpaRequest : IEquatable<UpdateSoundboxVpaRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSoundboxVpaRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateSoundboxVpaRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateSoundboxVpaRequest" /> class.
        /// </summary>
        /// <param name="vpa">Terminal Vpa,for which we need to update details. (required).</param>
        /// <param name="cfTerminalId">cashfree terminal id. (required).</param>
        /// <param name="merchantName">Merchant Name that need to updated on soundbox.</param>
        /// <param name="language">language of soundbox,currently English, Hindi, Tamil.</param>
        public UpdateSoundboxVpaRequest(string vpa = default(string), string cfTerminalId = default(string), string? merchantName = default(string?), string? language = default(string?))
        {
            // to ensure "vpa" is required (not null)
            if (vpa == null)
            {
                throw new ArgumentNullException("vpa is a required property for UpdateSoundboxVpaRequest and cannot be null");
            }
            this.vpa = vpa;
            // to ensure "cfTerminalId" is required (not null)
            if (cfTerminalId == null)
            {
                throw new ArgumentNullException("cfTerminalId is a required property for UpdateSoundboxVpaRequest and cannot be null");
            }
            this.cf_terminal_id = cfTerminalId;
            this.merchant_name = merchantName;
            this.language = language;
        }

        /// <summary>
        /// Terminal Vpa,for which we need to update details.
        /// </summary>
        /// <value>Terminal Vpa,for which we need to update details.</value>
        [DataMember(Name = "vpa", IsRequired = true, EmitDefaultValue = true)]
        public string vpa { get; set; }

        /// <summary>
        /// cashfree terminal id.
        /// </summary>
        /// <value>cashfree terminal id.</value>
        [DataMember(Name = "cf_terminal_id", IsRequired = true, EmitDefaultValue = true)]
        public string cf_terminal_id { get; set; }

        /// <summary>
        /// Merchant Name that need to updated on soundbox
        /// </summary>
        /// <value>Merchant Name that need to updated on soundbox</value>
        [DataMember(Name = "merchant_name", EmitDefaultValue = false)]
        public string? merchant_name { get; set; }

        /// <summary>
        /// language of soundbox,currently English, Hindi, Tamil
        /// </summary>
        /// <value>language of soundbox,currently English, Hindi, Tamil</value>
        [DataMember(Name = "language", EmitDefaultValue = false)]
        public string? language { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateSoundboxVpaRequest {\n");
            sb.Append("  vpa: ").Append(vpa).Append("\n");
            sb.Append("  cf_terminal_id: ").Append(cf_terminal_id).Append("\n");
            sb.Append("  merchant_name: ").Append(merchant_name).Append("\n");
            sb.Append("  language: ").Append(language).Append("\n");
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
            return this.Equals(input as UpdateSoundboxVpaRequest);
        }

        /// <summary>
        /// Returns true if UpdateSoundboxVpaRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateSoundboxVpaRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateSoundboxVpaRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vpa == input.vpa ||
                    (this.vpa != null &&
                    this.vpa.Equals(input.vpa))
                ) && 
                (
                    this.cf_terminal_id == input.cf_terminal_id ||
                    (this.cf_terminal_id != null &&
                    this.cf_terminal_id.Equals(input.cf_terminal_id))
                ) && 
                (
                    this.merchant_name == input.merchant_name ||
                    (this.merchant_name != null &&
                    this.merchant_name.Equals(input.merchant_name))
                ) && 
                (
                    this.language == input.language ||
                    (this.language != null &&
                    this.language.Equals(input.language))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringvpa) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringvpa);
            if (deserializedJsonString.ContainsKey("vpa")) {
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
                if (this.vpa != null)
                {
                    hashCode = (hashCode * 59) + this.vpa.GetHashCode();
                }
                if (this.cf_terminal_id != null)
                {
                    hashCode = (hashCode * 59) + this.cf_terminal_id.GetHashCode();
                }
                if (this.merchant_name != null)
                {
                    hashCode = (hashCode * 59) + this.merchant_name.GetHashCode();
                }
                if (this.language != null)
                {
                    hashCode = (hashCode * 59) + this.language.GetHashCode();
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

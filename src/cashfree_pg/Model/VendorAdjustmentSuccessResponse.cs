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
    /// Vendor Adjustment Success Response
    /// </summary>
    [DataContract(Name = "VendorAdjustmentSuccessResponse")]
    public class VendorAdjustmentSuccessResponse : IEquatable<VendorAdjustmentSuccessResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorAdjustmentSuccessResponse" /> class.
        /// </summary>
        /// <param name="message">message.</param>
        /// <param name="status">status.</param>
        public VendorAdjustmentSuccessResponse(string? message = default(string?), string? status = default(string?))
        {
            this.message = message;
            this.status = status;
        }

        /// <summary>
        /// Gets or Sets message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string? message { get; set; }

        /// <summary>
        /// Gets or Sets status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string? status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VendorAdjustmentSuccessResponse {\n");
            sb.Append("  message: ").Append(message).Append("\n");
            sb.Append("  status: ").Append(status).Append("\n");
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
            return this.Equals(input as VendorAdjustmentSuccessResponse);
        }

        /// <summary>
        /// Returns true if VendorAdjustmentSuccessResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of VendorAdjustmentSuccessResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VendorAdjustmentSuccessResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.message == input.message ||
                    (this.message != null &&
                    this.message.Equals(input.message))
                ) && 
                (
                    this.status == input.status ||
                    (this.status != null &&
                    this.status.Equals(input.status))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringmessage) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringmessage);
            if (deserializedJsonString.ContainsKey("message")) {
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
                if (this.message != null)
                {
                    hashCode = (hashCode * 59) + this.message.GetHashCode();
                }
                if (this.status != null)
                {
                    hashCode = (hashCode * 59) + this.status.GetHashCode();
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

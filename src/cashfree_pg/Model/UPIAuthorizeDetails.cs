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
    /// object when you are using preauth in UPI in order pay
    /// </summary>
    [DataContract(Name = "UPIAuthorizeDetails")]
    public class UPIAuthorizeDetails : IEquatable<UPIAuthorizeDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UPIAuthorizeDetails" /> class.
        /// </summary>
        /// <param name="approveBy">Time by which this authorization should be approved by the customer..</param>
        /// <param name="startTime">This is the time when the UPI one time mandate will start.</param>
        /// <param name="endTime">This is the time when the UPI mandate will be over. If the mandate has not been executed by this time, the funds will be returned back to the customer after this time..</param>
        public UPIAuthorizeDetails(string approveBy = default(string), string startTime = default(string), string endTime = default(string))
        {
            this.approve_by = approveBy;
            this.start_time = startTime;
            this.end_time = endTime;
        }

        /// <summary>
        /// Time by which this authorization should be approved by the customer.
        /// </summary>
        /// <value>Time by which this authorization should be approved by the customer.</value>
        [DataMember(Name = "approve_by", EmitDefaultValue = false)]
        public string approve_by { get; set; }

        /// <summary>
        /// This is the time when the UPI one time mandate will start
        /// </summary>
        /// <value>This is the time when the UPI one time mandate will start</value>
        [DataMember(Name = "start_time", EmitDefaultValue = false)]
        public string start_time { get; set; }

        /// <summary>
        /// This is the time when the UPI mandate will be over. If the mandate has not been executed by this time, the funds will be returned back to the customer after this time.
        /// </summary>
        /// <value>This is the time when the UPI mandate will be over. If the mandate has not been executed by this time, the funds will be returned back to the customer after this time.</value>
        [DataMember(Name = "end_time", EmitDefaultValue = false)]
        public string end_time { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UPIAuthorizeDetails {\n");
            sb.Append("  approve_by: ").Append(approve_by).Append("\n");
            sb.Append("  start_time: ").Append(start_time).Append("\n");
            sb.Append("  end_time: ").Append(end_time).Append("\n");
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
            return this.Equals(input as UPIAuthorizeDetails);
        }

        /// <summary>
        /// Returns true if UPIAuthorizeDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of UPIAuthorizeDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UPIAuthorizeDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.approve_by == input.approve_by ||
                    (this.approve_by != null &&
                    this.approve_by.Equals(input.approve_by))
                ) && 
                (
                    this.start_time == input.start_time ||
                    (this.start_time != null &&
                    this.start_time.Equals(input.start_time))
                ) && 
                (
                    this.end_time == input.end_time ||
                    (this.end_time != null &&
                    this.end_time.Equals(input.end_time))
                );
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
                if (this.approve_by != null)
                {
                    hashCode = (hashCode * 59) + this.approve_by.GetHashCode();
                }
                if (this.start_time != null)
                {
                    hashCode = (hashCode * 59) + this.start_time.GetHashCode();
                }
                if (this.end_time != null)
                {
                    hashCode = (hashCode * 59) + this.end_time.GetHashCode();
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
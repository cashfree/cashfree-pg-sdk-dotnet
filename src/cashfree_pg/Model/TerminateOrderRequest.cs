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
    /// Request to terminate an active order at Cashfree
    /// </summary>
    [DataContract(Name = "TerminateOrderRequest")]
    public class TerminateOrderRequest : IEquatable<TerminateOrderRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminateOrderRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TerminateOrderRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminateOrderRequest" /> class.
        /// </summary>
        /// <param name="orderStatus">To terminate an order, pass order_status as \&quot;TERMINATE\&quot;. Please note, order might not be terminated - confirm with the order_status in response. \&quot;TERMINATION_REQUESTED\&quot; states that the request is recieved and we are working on it. If the order terminates successfully, status will change to \&quot;TERMINATED\&quot;. Incase there&#39;s any active transaction which moved to success - order might not get terminated. (required).</param>
        public TerminateOrderRequest(string orderStatus = default(string))
        {
            // to ensure "orderStatus" is required (not null)
            if (orderStatus == null)
            {
                throw new ArgumentNullException("orderStatus is a required property for TerminateOrderRequest and cannot be null");
            }
            this.order_status = orderStatus;
        }

        /// <summary>
        /// To terminate an order, pass order_status as \&quot;TERMINATE\&quot;. Please note, order might not be terminated - confirm with the order_status in response. \&quot;TERMINATION_REQUESTED\&quot; states that the request is recieved and we are working on it. If the order terminates successfully, status will change to \&quot;TERMINATED\&quot;. Incase there&#39;s any active transaction which moved to success - order might not get terminated.
        /// </summary>
        /// <value>To terminate an order, pass order_status as \&quot;TERMINATE\&quot;. Please note, order might not be terminated - confirm with the order_status in response. \&quot;TERMINATION_REQUESTED\&quot; states that the request is recieved and we are working on it. If the order terminates successfully, status will change to \&quot;TERMINATED\&quot;. Incase there&#39;s any active transaction which moved to success - order might not get terminated.</value>
        [DataMember(Name = "order_status", IsRequired = true, EmitDefaultValue = true)]
        public string order_status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TerminateOrderRequest {\n");
            sb.Append("  order_status: ").Append(order_status).Append("\n");
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
            return this.Equals(input as TerminateOrderRequest);
        }

        /// <summary>
        /// Returns true if TerminateOrderRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of TerminateOrderRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerminateOrderRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.order_status == input.order_status ||
                    (this.order_status != null &&
                    this.order_status.Equals(input.order_status))
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
                if (this.order_status != null)
                {
                    hashCode = (hashCode * 59) + this.order_status.GetHashCode();
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
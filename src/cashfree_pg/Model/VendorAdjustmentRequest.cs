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
    /// Vendor Adjustment Request Body
    /// </summary>
    [DataContract(Name = "VendorAdjustmentRequest")]
    public class VendorAdjustmentRequest : IEquatable<VendorAdjustmentRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorAdjustmentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VendorAdjustmentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorAdjustmentRequest" /> class.
        /// </summary>
        /// <param name="vendorId">The unique identifier of the vendor to whom the adjustment is applied (required).</param>
        /// <param name="adjustmentId">The unique identifier for the adjustment transaction. (required).</param>
        /// <param name="amount">The adjustment amount to be applied. (required).</param>
        /// <param name="type">The type of adjustment. Possible values: CREDIT, DEBIT. (required).</param>
        /// <param name="remarks">Remarks for the adjustment transaction, if any..</param>
        public VendorAdjustmentRequest(string vendorId = default(string), long adjustmentId = default(long), decimal amount = default(decimal), string type = default(string), string? remarks = default(string?))
        {
            // to ensure "vendorId" is required (not null)
            if (vendorId == null)
            {
                throw new ArgumentNullException("vendorId is a required property for VendorAdjustmentRequest and cannot be null");
            }
            this.vendor_id = vendorId;
            this.adjustment_id = adjustmentId;
            this.amount = amount;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for VendorAdjustmentRequest and cannot be null");
            }
            this.type = type;
            this.remarks = remarks;
        }

        /// <summary>
        /// The unique identifier of the vendor to whom the adjustment is applied
        /// </summary>
        /// <value>The unique identifier of the vendor to whom the adjustment is applied</value>
        [DataMember(Name = "vendor_id", IsRequired = true, EmitDefaultValue = true)]
        public string vendor_id { get; set; }

        /// <summary>
        /// The unique identifier for the adjustment transaction.
        /// </summary>
        /// <value>The unique identifier for the adjustment transaction.</value>
        [DataMember(Name = "adjustment_id", IsRequired = true, EmitDefaultValue = true)]
        public long adjustment_id { get; set; }

        /// <summary>
        /// The adjustment amount to be applied.
        /// </summary>
        /// <value>The adjustment amount to be applied.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public decimal amount { get; set; }

        /// <summary>
        /// The type of adjustment. Possible values: CREDIT, DEBIT.
        /// </summary>
        /// <value>The type of adjustment. Possible values: CREDIT, DEBIT.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string type { get; set; }

        /// <summary>
        /// Remarks for the adjustment transaction, if any.
        /// </summary>
        /// <value>Remarks for the adjustment transaction, if any.</value>
        [DataMember(Name = "remarks", EmitDefaultValue = false)]
        public string? remarks { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VendorAdjustmentRequest {\n");
            sb.Append("  vendor_id: ").Append(vendor_id).Append("\n");
            sb.Append("  adjustment_id: ").Append(adjustment_id).Append("\n");
            sb.Append("  amount: ").Append(amount).Append("\n");
            sb.Append("  type: ").Append(type).Append("\n");
            sb.Append("  remarks: ").Append(remarks).Append("\n");
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
            return this.Equals(input as VendorAdjustmentRequest);
        }

        /// <summary>
        /// Returns true if VendorAdjustmentRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of VendorAdjustmentRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VendorAdjustmentRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.vendor_id == input.vendor_id ||
                    (this.vendor_id != null &&
                    this.vendor_id.Equals(input.vendor_id))
                ) && 
                (
                    this.adjustment_id == input.adjustment_id ||
                    this.adjustment_id.Equals(input.adjustment_id)
                ) && 
                (
                    this.amount == input.amount ||
                    this.amount.Equals(input.amount)
                ) && 
                (
                    this.type == input.type ||
                    (this.type != null &&
                    this.type.Equals(input.type))
                ) && 
                (
                    this.remarks == input.remarks ||
                    (this.remarks != null &&
                    this.remarks.Equals(input.remarks))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringvendor_id) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringvendor_id);
            if (deserializedJsonString.ContainsKey("vendor_id")) {
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
                if (this.vendor_id != null)
                {
                    hashCode = (hashCode * 59) + this.vendor_id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.adjustment_id.GetHashCode();
                hashCode = (hashCode * 59) + this.amount.GetHashCode();
                if (this.type != null)
                {
                    hashCode = (hashCode * 59) + this.type.GetHashCode();
                }
                if (this.remarks != null)
                {
                    hashCode = (hashCode * 59) + this.remarks.GetHashCode();
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

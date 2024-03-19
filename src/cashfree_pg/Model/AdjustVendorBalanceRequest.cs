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
    /// Adjust Vendor Balance Request
    /// </summary>
    [DataContract(Name = "AdjustVendorBalanceRequest")]
    public class AdjustVendorBalanceRequest : IEquatable<AdjustVendorBalanceRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdjustVendorBalanceRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdjustVendorBalanceRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdjustVendorBalanceRequest" /> class.
        /// </summary>
        /// <param name="transferFrom">Mention to whom you want to transfer the on demand balance. Possible values - MERCHANT, VENDOR. (required).</param>
        /// <param name="transferType">Mention the type of transfer. Possible values: ON_DEMAND. (required).</param>
        /// <param name="transferAmount">Mention the on demand transfer amount. (required).</param>
        /// <param name="remark">Mention remarks if any for the on demand transfer..</param>
        /// <param name="tags">Provide additional data fields using tags..</param>
        public AdjustVendorBalanceRequest(string transferFrom = default(string), string transferType = default(string), decimal transferAmount = default(decimal), string remark = default(string), Object tags = default(Object))
        {
            // to ensure "transferFrom" is required (not null)
            if (transferFrom == null)
            {
                throw new ArgumentNullException("transferFrom is a required property for AdjustVendorBalanceRequest and cannot be null");
            }
            this.transfer_from = transferFrom;
            // to ensure "transferType" is required (not null)
            if (transferType == null)
            {
                throw new ArgumentNullException("transferType is a required property for AdjustVendorBalanceRequest and cannot be null");
            }
            this.transfer_type = transferType;
            this.transfer_amount = transferAmount;
            this.remark = remark;
            this.tags = tags;
        }

        /// <summary>
        /// Mention to whom you want to transfer the on demand balance. Possible values - MERCHANT, VENDOR.
        /// </summary>
        /// <value>Mention to whom you want to transfer the on demand balance. Possible values - MERCHANT, VENDOR.</value>
        [DataMember(Name = "transfer_from", IsRequired = true, EmitDefaultValue = true)]
        public string transfer_from { get; set; }

        /// <summary>
        /// Mention the type of transfer. Possible values: ON_DEMAND.
        /// </summary>
        /// <value>Mention the type of transfer. Possible values: ON_DEMAND.</value>
        [DataMember(Name = "transfer_type", IsRequired = true, EmitDefaultValue = true)]
        public string transfer_type { get; set; }

        /// <summary>
        /// Mention the on demand transfer amount.
        /// </summary>
        /// <value>Mention the on demand transfer amount.</value>
        [DataMember(Name = "transfer_amount", IsRequired = true, EmitDefaultValue = true)]
        public decimal transfer_amount { get; set; }

        /// <summary>
        /// Mention remarks if any for the on demand transfer.
        /// </summary>
        /// <value>Mention remarks if any for the on demand transfer.</value>
        [DataMember(Name = "remark", EmitDefaultValue = false)]
        public string remark { get; set; }

        /// <summary>
        /// Provide additional data fields using tags.
        /// </summary>
        /// <value>Provide additional data fields using tags.</value>
        [DataMember(Name = "tags", EmitDefaultValue = false)]
        public Object tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdjustVendorBalanceRequest {\n");
            sb.Append("  transfer_from: ").Append(transfer_from).Append("\n");
            sb.Append("  transfer_type: ").Append(transfer_type).Append("\n");
            sb.Append("  transfer_amount: ").Append(transfer_amount).Append("\n");
            sb.Append("  remark: ").Append(remark).Append("\n");
            sb.Append("  tags: ").Append(tags).Append("\n");
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
            return this.Equals(input as AdjustVendorBalanceRequest);
        }

        /// <summary>
        /// Returns true if AdjustVendorBalanceRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AdjustVendorBalanceRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AdjustVendorBalanceRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.transfer_from == input.transfer_from ||
                    (this.transfer_from != null &&
                    this.transfer_from.Equals(input.transfer_from))
                ) && 
                (
                    this.transfer_type == input.transfer_type ||
                    (this.transfer_type != null &&
                    this.transfer_type.Equals(input.transfer_type))
                ) && 
                (
                    this.transfer_amount == input.transfer_amount ||
                    this.transfer_amount.Equals(input.transfer_amount)
                ) && 
                (
                    this.remark == input.remark ||
                    (this.remark != null &&
                    this.remark.Equals(input.remark))
                ) && 
                (
                    this.tags == input.tags ||
                    (this.tags != null &&
                    this.tags.Equals(input.tags))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringtransfer_from) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringtransfer_from);
            if (deserializedJsonString.ContainsKey("transfer_from")) {
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
                if (this.transfer_from != null)
                {
                    hashCode = (hashCode * 59) + this.transfer_from.GetHashCode();
                }
                if (this.transfer_type != null)
                {
                    hashCode = (hashCode * 59) + this.transfer_type.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.transfer_amount.GetHashCode();
                if (this.remark != null)
                {
                    hashCode = (hashCode * 59) + this.remark.GetHashCode();
                }
                if (this.tags != null)
                {
                    hashCode = (hashCode * 59) + this.tags.GetHashCode();
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

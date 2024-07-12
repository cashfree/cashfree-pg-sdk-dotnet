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
    /// EligibilityMethodItemEntityDetails
    /// </summary>
    [DataContract(Name = "EligibilityMethodItem_entity_details")]
    public class EligibilityMethodItemEntityDetails : IEquatable<EligibilityMethodItemEntityDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EligibilityMethodItemEntityDetails" /> class.
        /// </summary>
        /// <param name="accountTypes">List of account types associated with the payment method. (e.g. SAVINGS or CURRENT).</param>
        /// <param name="frequentBankDetails">List of the most frequently used banks..</param>
        /// <param name="allBankDetails">Details about all banks associated with the payment method..</param>
        /// <param name="availableHandles">List of supported VPA handles..</param>
        /// <param name="allowedCardTypes">List of allowed card types. (e.g. DEBIT_CARD, CREDIT_CARD).</param>
        public EligibilityMethodItemEntityDetails(List<string>? accountTypes = default(List<string>?), List<SubscriptionBankDetails>? frequentBankDetails = default(List<SubscriptionBankDetails>?), List<SubscriptionBankDetails>? allBankDetails = default(List<SubscriptionBankDetails>?), List<EligibilityMethodItemEntityDetailsAvailableHandlesInner>? availableHandles = default(List<EligibilityMethodItemEntityDetailsAvailableHandlesInner>?), List<string>? allowedCardTypes = default(List<string>?))
        {
            this.account_types = accountTypes;
            this.frequent_bank_details = frequentBankDetails;
            this.all_bank_details = allBankDetails;
            this.available_handles = availableHandles;
            this.allowed_card_types = allowedCardTypes;
        }

        /// <summary>
        /// List of account types associated with the payment method. (e.g. SAVINGS or CURRENT)
        /// </summary>
        /// <value>List of account types associated with the payment method. (e.g. SAVINGS or CURRENT)</value>
        [DataMember(Name = "account_types", EmitDefaultValue = false)]
        public List<string>? account_types { get; set; }

        /// <summary>
        /// List of the most frequently used banks.
        /// </summary>
        /// <value>List of the most frequently used banks.</value>
        [DataMember(Name = "frequent_bank_details", EmitDefaultValue = false)]
        public List<SubscriptionBankDetails>? frequent_bank_details { get; set; }

        /// <summary>
        /// Details about all banks associated with the payment method.
        /// </summary>
        /// <value>Details about all banks associated with the payment method.</value>
        [DataMember(Name = "all_bank_details", EmitDefaultValue = false)]
        public List<SubscriptionBankDetails>? all_bank_details { get; set; }

        /// <summary>
        /// List of supported VPA handles.
        /// </summary>
        /// <value>List of supported VPA handles.</value>
        [DataMember(Name = "available_handles", EmitDefaultValue = false)]
        public List<EligibilityMethodItemEntityDetailsAvailableHandlesInner>? available_handles { get; set; }

        /// <summary>
        /// List of allowed card types. (e.g. DEBIT_CARD, CREDIT_CARD)
        /// </summary>
        /// <value>List of allowed card types. (e.g. DEBIT_CARD, CREDIT_CARD)</value>
        [DataMember(Name = "allowed_card_types", EmitDefaultValue = false)]
        public List<string>? allowed_card_types { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EligibilityMethodItemEntityDetails {\n");
            sb.Append("  account_types: ").Append(account_types).Append("\n");
            sb.Append("  frequent_bank_details: ").Append(frequent_bank_details).Append("\n");
            sb.Append("  all_bank_details: ").Append(all_bank_details).Append("\n");
            sb.Append("  available_handles: ").Append(available_handles).Append("\n");
            sb.Append("  allowed_card_types: ").Append(allowed_card_types).Append("\n");
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
            return this.Equals(input as EligibilityMethodItemEntityDetails);
        }

        /// <summary>
        /// Returns true if EligibilityMethodItemEntityDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of EligibilityMethodItemEntityDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EligibilityMethodItemEntityDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.account_types == input.account_types ||
                    this.account_types != null &&
                    input.account_types != null &&
                    this.account_types.SequenceEqual(input.account_types)
                ) && 
                (
                    this.frequent_bank_details == input.frequent_bank_details ||
                    this.frequent_bank_details != null &&
                    input.frequent_bank_details != null &&
                    this.frequent_bank_details.SequenceEqual(input.frequent_bank_details)
                ) && 
                (
                    this.all_bank_details == input.all_bank_details ||
                    this.all_bank_details != null &&
                    input.all_bank_details != null &&
                    this.all_bank_details.SequenceEqual(input.all_bank_details)
                ) && 
                (
                    this.available_handles == input.available_handles ||
                    this.available_handles != null &&
                    input.available_handles != null &&
                    this.available_handles.SequenceEqual(input.available_handles)
                ) && 
                (
                    this.allowed_card_types == input.allowed_card_types ||
                    this.allowed_card_types != null &&
                    input.allowed_card_types != null &&
                    this.allowed_card_types.SequenceEqual(input.allowed_card_types)
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringaccount_types) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringaccount_types);
            if (deserializedJsonString.ContainsKey("account_types")) {
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
                if (this.account_types != null)
                {
                    hashCode = (hashCode * 59) + this.account_types.GetHashCode();
                }
                if (this.frequent_bank_details != null)
                {
                    hashCode = (hashCode * 59) + this.frequent_bank_details.GetHashCode();
                }
                if (this.all_bank_details != null)
                {
                    hashCode = (hashCode * 59) + this.all_bank_details.GetHashCode();
                }
                if (this.available_handles != null)
                {
                    hashCode = (hashCode * 59) + this.available_handles.GetHashCode();
                }
                if (this.allowed_card_types != null)
                {
                    hashCode = (hashCode * 59) + this.allowed_card_types.GetHashCode();
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

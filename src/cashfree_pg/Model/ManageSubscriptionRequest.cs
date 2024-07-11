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
    /// Request body to manage a subscription.
    /// </summary>
    [DataContract(Name = "ManageSubscriptionRequest")]
    public class ManageSubscriptionRequest : IEquatable<ManageSubscriptionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManageSubscriptionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ManageSubscriptionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ManageSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="subscriptionId">The unique ID which was used to create subscription. (required).</param>
        /// <param name="action">Action to be performed on the subscription. Possible values - CANCEL, PAUSE, ACTIVATE, CHANGE_PLAN. (required).</param>
        /// <param name="actionDetails">actionDetails.</param>
        public ManageSubscriptionRequest(string subscriptionId = default(string), string action = default(string), ManageSubscriptionRequestActionDetails? actionDetails = default(ManageSubscriptionRequestActionDetails?))
        {
            // to ensure "subscriptionId" is required (not null)
            if (subscriptionId == null)
            {
                throw new ArgumentNullException("subscriptionId is a required property for ManageSubscriptionRequest and cannot be null");
            }
            this.subscription_id = subscriptionId;
            // to ensure "action" is required (not null)
            if (action == null)
            {
                throw new ArgumentNullException("action is a required property for ManageSubscriptionRequest and cannot be null");
            }
            this.action = action;
            this.action_details = actionDetails;
        }

        /// <summary>
        /// The unique ID which was used to create subscription.
        /// </summary>
        /// <value>The unique ID which was used to create subscription.</value>
        [DataMember(Name = "subscription_id", IsRequired = true, EmitDefaultValue = true)]
        public string subscription_id { get; set; }

        /// <summary>
        /// Action to be performed on the subscription. Possible values - CANCEL, PAUSE, ACTIVATE, CHANGE_PLAN.
        /// </summary>
        /// <value>Action to be performed on the subscription. Possible values - CANCEL, PAUSE, ACTIVATE, CHANGE_PLAN.</value>
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = true)]
        public string action { get; set; }

        /// <summary>
        /// Gets or Sets action_details
        /// </summary>
        [DataMember(Name = "action_details", EmitDefaultValue = false)]
        public ManageSubscriptionRequestActionDetails? action_details { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ManageSubscriptionRequest {\n");
            sb.Append("  subscription_id: ").Append(subscription_id).Append("\n");
            sb.Append("  action: ").Append(action).Append("\n");
            sb.Append("  action_details: ").Append(action_details).Append("\n");
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
            return this.Equals(input as ManageSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if ManageSubscriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ManageSubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ManageSubscriptionRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.subscription_id == input.subscription_id ||
                    (this.subscription_id != null &&
                    this.subscription_id.Equals(input.subscription_id))
                ) && 
                (
                    this.action == input.action ||
                    (this.action != null &&
                    this.action.Equals(input.action))
                ) && 
                (
                    this.action_details == input.action_details ||
                    (this.action_details != null &&
                    this.action_details.Equals(input.action_details))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringsubscription_id) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringsubscription_id);
            if (deserializedJsonString.ContainsKey("subscription_id")) {
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
                if (this.subscription_id != null)
                {
                    hashCode = (hashCode * 59) + this.subscription_id.GetHashCode();
                }
                if (this.action != null)
                {
                    hashCode = (hashCode * 59) + this.action.GetHashCode();
                }
                if (this.action_details != null)
                {
                    hashCode = (hashCode * 59) + this.action_details.GetHashCode();
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

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
    /// Request body to create a new subscription.
    /// </summary>
    [DataContract(Name = "CreateSubscriptionRequest")]
    public class CreateSubscriptionRequest : IEquatable<CreateSubscriptionRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateSubscriptionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequest" /> class.
        /// </summary>
        /// <param name="subscriptionId">A unique ID for the subscription. It can include alphanumeric characters, underscore, dot, hyphen, and space. Maximum characters allowed is 250. (required).</param>
        /// <param name="customerDetails">customerDetails (required).</param>
        /// <param name="planDetails">planDetails (required).</param>
        /// <param name="authorizationDetails">authorizationDetails.</param>
        /// <param name="subscriptionMeta">subscriptionMeta.</param>
        /// <param name="subscriptionExpiryTime">Expiry date for the subscription..</param>
        /// <param name="subscriptionFirstChargeTime">Time at which the first charge will be made for the subscription after authorization. Applicable only for PERIODIC plans..</param>
        /// <param name="subscriptionNote">Note for the subscription..</param>
        /// <param name="subscriptionTags">Tags for the subscription..</param>
        /// <param name="subscriptionPaymentSplits">Payment splits for the subscription..</param>
        public CreateSubscriptionRequest(string subscriptionId = default(string), SubscriptionCustomerDetails customerDetails = default(SubscriptionCustomerDetails), CreateSubscriptionRequestPlanDetails planDetails = default(CreateSubscriptionRequestPlanDetails), CreateSubscriptionRequestAuthorizationDetails? authorizationDetails = default(CreateSubscriptionRequestAuthorizationDetails?), CreateSubscriptionRequestSubscriptionMeta? subscriptionMeta = default(CreateSubscriptionRequestSubscriptionMeta?), string? subscriptionExpiryTime = default(string?), string? subscriptionFirstChargeTime = default(string?), string? subscriptionNote = default(string?), Object? subscriptionTags = default(Object?), List<SubscriptionPaymentSplitItem>? subscriptionPaymentSplits = default(List<SubscriptionPaymentSplitItem>?))
        {
            // to ensure "subscriptionId" is required (not null)
            if (subscriptionId == null)
            {
                throw new ArgumentNullException("subscriptionId is a required property for CreateSubscriptionRequest and cannot be null");
            }
            this.subscription_id = subscriptionId;
            // to ensure "customerDetails" is required (not null)
            if (customerDetails == null)
            {
                throw new ArgumentNullException("customerDetails is a required property for CreateSubscriptionRequest and cannot be null");
            }
            this.customer_details = customerDetails;
            // to ensure "planDetails" is required (not null)
            if (planDetails == null)
            {
                throw new ArgumentNullException("planDetails is a required property for CreateSubscriptionRequest and cannot be null");
            }
            this.plan_details = planDetails;
            this.authorization_details = authorizationDetails;
            this.subscription_meta = subscriptionMeta;
            this.subscription_expiry_time = subscriptionExpiryTime;
            this.subscription_first_charge_time = subscriptionFirstChargeTime;
            this.subscription_note = subscriptionNote;
            this.subscription_tags = subscriptionTags;
            this.subscription_payment_splits = subscriptionPaymentSplits;
        }

        /// <summary>
        /// A unique ID for the subscription. It can include alphanumeric characters, underscore, dot, hyphen, and space. Maximum characters allowed is 250.
        /// </summary>
        /// <value>A unique ID for the subscription. It can include alphanumeric characters, underscore, dot, hyphen, and space. Maximum characters allowed is 250.</value>
        [DataMember(Name = "subscription_id", IsRequired = true, EmitDefaultValue = true)]
        public string subscription_id { get; set; }

        /// <summary>
        /// Gets or Sets customer_details
        /// </summary>
        [DataMember(Name = "customer_details", IsRequired = true, EmitDefaultValue = true)]
        public SubscriptionCustomerDetails customer_details { get; set; }

        /// <summary>
        /// Gets or Sets plan_details
        /// </summary>
        [DataMember(Name = "plan_details", IsRequired = true, EmitDefaultValue = true)]
        public CreateSubscriptionRequestPlanDetails plan_details { get; set; }

        /// <summary>
        /// Gets or Sets authorization_details
        /// </summary>
        [DataMember(Name = "authorization_details", EmitDefaultValue = false)]
        public CreateSubscriptionRequestAuthorizationDetails? authorization_details { get; set; }

        /// <summary>
        /// Gets or Sets subscription_meta
        /// </summary>
        [DataMember(Name = "subscription_meta", EmitDefaultValue = false)]
        public CreateSubscriptionRequestSubscriptionMeta? subscription_meta { get; set; }

        /// <summary>
        /// Expiry date for the subscription.
        /// </summary>
        /// <value>Expiry date for the subscription.</value>
        [DataMember(Name = "subscription_expiry_time", EmitDefaultValue = false)]
        public string? subscription_expiry_time { get; set; }

        /// <summary>
        /// Time at which the first charge will be made for the subscription after authorization. Applicable only for PERIODIC plans.
        /// </summary>
        /// <value>Time at which the first charge will be made for the subscription after authorization. Applicable only for PERIODIC plans.</value>
        [DataMember(Name = "subscription_first_charge_time", EmitDefaultValue = false)]
        public string? subscription_first_charge_time { get; set; }

        /// <summary>
        /// Note for the subscription.
        /// </summary>
        /// <value>Note for the subscription.</value>
        [DataMember(Name = "subscription_note", EmitDefaultValue = false)]
        public string? subscription_note { get; set; }

        /// <summary>
        /// Tags for the subscription.
        /// </summary>
        /// <value>Tags for the subscription.</value>
        [DataMember(Name = "subscription_tags", EmitDefaultValue = false)]
        public Object? subscription_tags { get; set; }

        /// <summary>
        /// Payment splits for the subscription.
        /// </summary>
        /// <value>Payment splits for the subscription.</value>
        [DataMember(Name = "subscription_payment_splits", EmitDefaultValue = false)]
        public List<SubscriptionPaymentSplitItem>? subscription_payment_splits { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSubscriptionRequest {\n");
            sb.Append("  subscription_id: ").Append(subscription_id).Append("\n");
            sb.Append("  customer_details: ").Append(customer_details).Append("\n");
            sb.Append("  plan_details: ").Append(plan_details).Append("\n");
            sb.Append("  authorization_details: ").Append(authorization_details).Append("\n");
            sb.Append("  subscription_meta: ").Append(subscription_meta).Append("\n");
            sb.Append("  subscription_expiry_time: ").Append(subscription_expiry_time).Append("\n");
            sb.Append("  subscription_first_charge_time: ").Append(subscription_first_charge_time).Append("\n");
            sb.Append("  subscription_note: ").Append(subscription_note).Append("\n");
            sb.Append("  subscription_tags: ").Append(subscription_tags).Append("\n");
            sb.Append("  subscription_payment_splits: ").Append(subscription_payment_splits).Append("\n");
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
            return this.Equals(input as CreateSubscriptionRequest);
        }

        /// <summary>
        /// Returns true if CreateSubscriptionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSubscriptionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSubscriptionRequest input)
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
                    this.customer_details == input.customer_details ||
                    (this.customer_details != null &&
                    this.customer_details.Equals(input.customer_details))
                ) && 
                (
                    this.plan_details == input.plan_details ||
                    (this.plan_details != null &&
                    this.plan_details.Equals(input.plan_details))
                ) && 
                (
                    this.authorization_details == input.authorization_details ||
                    (this.authorization_details != null &&
                    this.authorization_details.Equals(input.authorization_details))
                ) && 
                (
                    this.subscription_meta == input.subscription_meta ||
                    (this.subscription_meta != null &&
                    this.subscription_meta.Equals(input.subscription_meta))
                ) && 
                (
                    this.subscription_expiry_time == input.subscription_expiry_time ||
                    (this.subscription_expiry_time != null &&
                    this.subscription_expiry_time.Equals(input.subscription_expiry_time))
                ) && 
                (
                    this.subscription_first_charge_time == input.subscription_first_charge_time ||
                    (this.subscription_first_charge_time != null &&
                    this.subscription_first_charge_time.Equals(input.subscription_first_charge_time))
                ) && 
                (
                    this.subscription_note == input.subscription_note ||
                    (this.subscription_note != null &&
                    this.subscription_note.Equals(input.subscription_note))
                ) && 
                (
                    this.subscription_tags == input.subscription_tags ||
                    (this.subscription_tags != null &&
                    this.subscription_tags.Equals(input.subscription_tags))
                ) && 
                (
                    this.subscription_payment_splits == input.subscription_payment_splits ||
                    this.subscription_payment_splits != null &&
                    input.subscription_payment_splits != null &&
                    this.subscription_payment_splits.SequenceEqual(input.subscription_payment_splits)
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
                if (this.customer_details != null)
                {
                    hashCode = (hashCode * 59) + this.customer_details.GetHashCode();
                }
                if (this.plan_details != null)
                {
                    hashCode = (hashCode * 59) + this.plan_details.GetHashCode();
                }
                if (this.authorization_details != null)
                {
                    hashCode = (hashCode * 59) + this.authorization_details.GetHashCode();
                }
                if (this.subscription_meta != null)
                {
                    hashCode = (hashCode * 59) + this.subscription_meta.GetHashCode();
                }
                if (this.subscription_expiry_time != null)
                {
                    hashCode = (hashCode * 59) + this.subscription_expiry_time.GetHashCode();
                }
                if (this.subscription_first_charge_time != null)
                {
                    hashCode = (hashCode * 59) + this.subscription_first_charge_time.GetHashCode();
                }
                if (this.subscription_note != null)
                {
                    hashCode = (hashCode * 59) + this.subscription_note.GetHashCode();
                }
                if (this.subscription_tags != null)
                {
                    hashCode = (hashCode * 59) + this.subscription_tags.GetHashCode();
                }
                if (this.subscription_payment_splits != null)
                {
                    hashCode = (hashCode * 59) + this.subscription_payment_splits.GetHashCode();
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
            // subscription_id (string) maxLength
            if (this.subscription_id != null && this.subscription_id.Length > 250)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for subscription_id, length must be less than 250.", new [] { "subscription_id" });
            }

            // subscription_id (string) minLength
            if (this.subscription_id != null && this.subscription_id.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for subscription_id, length must be greater than 1.", new [] { "subscription_id" });
            }

            yield break;
        }
    }

}

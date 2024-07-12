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
    /// The response returned for Get, Create or Manage Subscription APIs.
    /// </summary>
    [DataContract(Name = "SubscriptionEntity")]
    public class SubscriptionEntity : IEquatable<SubscriptionEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionEntity" /> class.
        /// </summary>
        /// <param name="authorisationDetails">authorisationDetails.</param>
        /// <param name="cfSubscriptionId">Cashfree subscription reference number.</param>
        /// <param name="customerDetails">customerDetails.</param>
        /// <param name="planDetails">planDetails.</param>
        /// <param name="subscriptionExpiryTime">Time at which the subscription will expire..</param>
        /// <param name="subscriptionFirstChargeTime">Time at which the first charge will be made for the subscription. Applicable only for PERIODIC plans..</param>
        /// <param name="subscriptionId">A unique ID passed by merchant for identifying the subscription..</param>
        /// <param name="subscriptionMeta">subscriptionMeta.</param>
        /// <param name="subscriptionNote">Note for the subscription..</param>
        /// <param name="subscriptionPaymentSplits">Payment splits for the subscription..</param>
        /// <param name="subscriptionStatus">Status of the subscription..</param>
        /// <param name="subscriptionTags">Tags for the subscription..</param>
        public SubscriptionEntity(AuthorizationDetails? authorisationDetails = default(AuthorizationDetails?), string? cfSubscriptionId = default(string?), SubscriptionCustomerDetails? customerDetails = default(SubscriptionCustomerDetails?), PlanEntity? planDetails = default(PlanEntity?), string? subscriptionExpiryTime = default(string?), string? subscriptionFirstChargeTime = default(string?), string? subscriptionId = default(string?), SubscriptionEntitySubscriptionMeta? subscriptionMeta = default(SubscriptionEntitySubscriptionMeta?), string? subscriptionNote = default(string?), List<SubscriptionPaymentSplitItem>? subscriptionPaymentSplits = default(List<SubscriptionPaymentSplitItem>?), string? subscriptionStatus = default(string?), Object? subscriptionTags = default(Object?))
        {
            this.authorisation_details = authorisationDetails;
            this.cf_subscription_id = cfSubscriptionId;
            this.customer_details = customerDetails;
            this.plan_details = planDetails;
            this.subscription_expiry_time = subscriptionExpiryTime;
            this.subscription_first_charge_time = subscriptionFirstChargeTime;
            this.subscription_id = subscriptionId;
            this.subscription_meta = subscriptionMeta;
            this.subscription_note = subscriptionNote;
            this.subscription_payment_splits = subscriptionPaymentSplits;
            this.subscription_status = subscriptionStatus;
            this.subscription_tags = subscriptionTags;
        }

        /// <summary>
        /// Gets or Sets authorisation_details
        /// </summary>
        [DataMember(Name = "authorisation_details", EmitDefaultValue = false)]
        public AuthorizationDetails? authorisation_details { get; set; }

        /// <summary>
        /// Cashfree subscription reference number
        /// </summary>
        /// <value>Cashfree subscription reference number</value>
        [DataMember(Name = "cf_subscription_id", EmitDefaultValue = false)]
        public string? cf_subscription_id { get; set; }

        /// <summary>
        /// Gets or Sets customer_details
        /// </summary>
        [DataMember(Name = "customer_details", EmitDefaultValue = false)]
        public SubscriptionCustomerDetails? customer_details { get; set; }

        /// <summary>
        /// Gets or Sets plan_details
        /// </summary>
        [DataMember(Name = "plan_details", EmitDefaultValue = false)]
        public PlanEntity? plan_details { get; set; }

        /// <summary>
        /// Time at which the subscription will expire.
        /// </summary>
        /// <value>Time at which the subscription will expire.</value>
        [DataMember(Name = "subscription_expiry_time", EmitDefaultValue = false)]
        public string? subscription_expiry_time { get; set; }

        /// <summary>
        /// Time at which the first charge will be made for the subscription. Applicable only for PERIODIC plans.
        /// </summary>
        /// <value>Time at which the first charge will be made for the subscription. Applicable only for PERIODIC plans.</value>
        [DataMember(Name = "subscription_first_charge_time", EmitDefaultValue = false)]
        public string? subscription_first_charge_time { get; set; }

        /// <summary>
        /// A unique ID passed by merchant for identifying the subscription.
        /// </summary>
        /// <value>A unique ID passed by merchant for identifying the subscription.</value>
        [DataMember(Name = "subscription_id", EmitDefaultValue = false)]
        public string? subscription_id { get; set; }

        /// <summary>
        /// Gets or Sets subscription_meta
        /// </summary>
        [DataMember(Name = "subscription_meta", EmitDefaultValue = false)]
        public SubscriptionEntitySubscriptionMeta? subscription_meta { get; set; }

        /// <summary>
        /// Note for the subscription.
        /// </summary>
        /// <value>Note for the subscription.</value>
        [DataMember(Name = "subscription_note", EmitDefaultValue = false)]
        public string? subscription_note { get; set; }

        /// <summary>
        /// Payment splits for the subscription.
        /// </summary>
        /// <value>Payment splits for the subscription.</value>
        [DataMember(Name = "subscription_payment_splits", EmitDefaultValue = false)]
        public List<SubscriptionPaymentSplitItem>? subscription_payment_splits { get; set; }

        /// <summary>
        /// Status of the subscription.
        /// </summary>
        /// <value>Status of the subscription.</value>
        [DataMember(Name = "subscription_status", EmitDefaultValue = false)]
        public string? subscription_status { get; set; }

        /// <summary>
        /// Tags for the subscription.
        /// </summary>
        /// <value>Tags for the subscription.</value>
        [DataMember(Name = "subscription_tags", EmitDefaultValue = false)]
        public Object? subscription_tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SubscriptionEntity {\n");
            sb.Append("  authorisation_details: ").Append(authorisation_details).Append("\n");
            sb.Append("  cf_subscription_id: ").Append(cf_subscription_id).Append("\n");
            sb.Append("  customer_details: ").Append(customer_details).Append("\n");
            sb.Append("  plan_details: ").Append(plan_details).Append("\n");
            sb.Append("  subscription_expiry_time: ").Append(subscription_expiry_time).Append("\n");
            sb.Append("  subscription_first_charge_time: ").Append(subscription_first_charge_time).Append("\n");
            sb.Append("  subscription_id: ").Append(subscription_id).Append("\n");
            sb.Append("  subscription_meta: ").Append(subscription_meta).Append("\n");
            sb.Append("  subscription_note: ").Append(subscription_note).Append("\n");
            sb.Append("  subscription_payment_splits: ").Append(subscription_payment_splits).Append("\n");
            sb.Append("  subscription_status: ").Append(subscription_status).Append("\n");
            sb.Append("  subscription_tags: ").Append(subscription_tags).Append("\n");
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
            return this.Equals(input as SubscriptionEntity);
        }

        /// <summary>
        /// Returns true if SubscriptionEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of SubscriptionEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubscriptionEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.authorisation_details == input.authorisation_details ||
                    (this.authorisation_details != null &&
                    this.authorisation_details.Equals(input.authorisation_details))
                ) && 
                (
                    this.cf_subscription_id == input.cf_subscription_id ||
                    (this.cf_subscription_id != null &&
                    this.cf_subscription_id.Equals(input.cf_subscription_id))
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
                    this.subscription_id == input.subscription_id ||
                    (this.subscription_id != null &&
                    this.subscription_id.Equals(input.subscription_id))
                ) && 
                (
                    this.subscription_meta == input.subscription_meta ||
                    (this.subscription_meta != null &&
                    this.subscription_meta.Equals(input.subscription_meta))
                ) && 
                (
                    this.subscription_note == input.subscription_note ||
                    (this.subscription_note != null &&
                    this.subscription_note.Equals(input.subscription_note))
                ) && 
                (
                    this.subscription_payment_splits == input.subscription_payment_splits ||
                    this.subscription_payment_splits != null &&
                    input.subscription_payment_splits != null &&
                    this.subscription_payment_splits.SequenceEqual(input.subscription_payment_splits)
                ) && 
                (
                    this.subscription_status == input.subscription_status ||
                    (this.subscription_status != null &&
                    this.subscription_status.Equals(input.subscription_status))
                ) && 
                (
                    this.subscription_tags == input.subscription_tags ||
                    (this.subscription_tags != null &&
                    this.subscription_tags.Equals(input.subscription_tags))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringauthorisation_details) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringauthorisation_details);
            if (deserializedJsonString.ContainsKey("authorisation_details")) {
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
                if (this.authorisation_details != null)
                {
                    hashCode = (hashCode * 59) + this.authorisation_details.GetHashCode();
                }
                if (this.cf_subscription_id != null)
                {
                    hashCode = (hashCode * 59) + this.cf_subscription_id.GetHashCode();
                }
                if (this.customer_details != null)
                {
                    hashCode = (hashCode * 59) + this.customer_details.GetHashCode();
                }
                if (this.plan_details != null)
                {
                    hashCode = (hashCode * 59) + this.plan_details.GetHashCode();
                }
                if (this.subscription_expiry_time != null)
                {
                    hashCode = (hashCode * 59) + this.subscription_expiry_time.GetHashCode();
                }
                if (this.subscription_first_charge_time != null)
                {
                    hashCode = (hashCode * 59) + this.subscription_first_charge_time.GetHashCode();
                }
                if (this.subscription_id != null)
                {
                    hashCode = (hashCode * 59) + this.subscription_id.GetHashCode();
                }
                if (this.subscription_meta != null)
                {
                    hashCode = (hashCode * 59) + this.subscription_meta.GetHashCode();
                }
                if (this.subscription_note != null)
                {
                    hashCode = (hashCode * 59) + this.subscription_note.GetHashCode();
                }
                if (this.subscription_payment_splits != null)
                {
                    hashCode = (hashCode * 59) + this.subscription_payment_splits.GetHashCode();
                }
                if (this.subscription_status != null)
                {
                    hashCode = (hashCode * 59) + this.subscription_status.GetHashCode();
                }
                if (this.subscription_tags != null)
                {
                    hashCode = (hashCode * 59) + this.subscription_tags.GetHashCode();
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
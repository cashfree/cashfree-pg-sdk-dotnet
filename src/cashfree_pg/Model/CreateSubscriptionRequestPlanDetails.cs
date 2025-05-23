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
    /// CreateSubscriptionRequestPlanDetails
    /// </summary>
    [DataContract(Name = "CreateSubscriptionRequest_plan_details")]
    public class CreateSubscriptionRequestPlanDetails : IEquatable<CreateSubscriptionRequestPlanDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequestPlanDetails" /> class.
        /// </summary>
        /// <param name="planId">The unique identifier used to create plan. You only need to pass this field if you had already created plan. Otherwise use the other fields here to define the plan..</param>
        /// <param name="planName">Specify plan name for easy reference..</param>
        /// <param name="planType">Possible values ON_DEMAND or PERIODIC. PERIODIC - Payments are triggered automatically at fixed intervals defined by the merchant. ON_DEMAND - Merchant needs to trigger/charge the customer explicitly with the required amount..</param>
        /// <param name="planCurrency">INR by default..</param>
        /// <param name="planAmount">The amount to be charged for PERIODIC plan. This is a conditional parameter, only required for PERIODIC plans..</param>
        /// <param name="planMaxAmount">This is the maximum amount that can be charged on a subscription..</param>
        /// <param name="planMaxCycles">Maximum number of debits set for the plan. The subscription will automatically change to COMPLETED status once this limit is reached..</param>
        /// <param name="planIntervals">Number of intervals of intervalType between every subscription payment. For example, to charge a customer bi-weekly use intervalType as “week” and intervals as 2. Required for PERIODIC plan. The default value is 1..</param>
        /// <param name="planIntervalType">The type of interval for a PERIODIC plan like DAY, WEEK, MONTH, or YEAR. This is a conditional parameter only applicable for PERIODIC plans..</param>
        /// <param name="planNote">Note for the plan..</param>
        public CreateSubscriptionRequestPlanDetails(string? planId = default(string?), string? planName = default(string?), string? planType = default(string?), string? planCurrency = default(string?), decimal? planAmount = default(decimal?), decimal? planMaxAmount = default(decimal?), int? planMaxCycles = default(int?), int? planIntervals = default(int?), string? planIntervalType = default(string?), string? planNote = default(string?))
        {
            this.plan_id = planId;
            this.plan_name = planName;
            this.plan_type = planType;
            this.plan_currency = planCurrency;
            this.plan_amount = planAmount;
            this.plan_max_amount = planMaxAmount;
            this.plan_max_cycles = planMaxCycles;
            this.plan_intervals = planIntervals;
            this.plan_interval_type = planIntervalType;
            this.plan_note = planNote;
        }

        /// <summary>
        /// The unique identifier used to create plan. You only need to pass this field if you had already created plan. Otherwise use the other fields here to define the plan.
        /// </summary>
        /// <value>The unique identifier used to create plan. You only need to pass this field if you had already created plan. Otherwise use the other fields here to define the plan.</value>
        [DataMember(Name = "plan_id", EmitDefaultValue = false)]
        public string? plan_id { get; set; }

        /// <summary>
        /// Specify plan name for easy reference.
        /// </summary>
        /// <value>Specify plan name for easy reference.</value>
        [DataMember(Name = "plan_name", EmitDefaultValue = false)]
        public string? plan_name { get; set; }

        /// <summary>
        /// Possible values ON_DEMAND or PERIODIC. PERIODIC - Payments are triggered automatically at fixed intervals defined by the merchant. ON_DEMAND - Merchant needs to trigger/charge the customer explicitly with the required amount.
        /// </summary>
        /// <value>Possible values ON_DEMAND or PERIODIC. PERIODIC - Payments are triggered automatically at fixed intervals defined by the merchant. ON_DEMAND - Merchant needs to trigger/charge the customer explicitly with the required amount.</value>
        [DataMember(Name = "plan_type", EmitDefaultValue = false)]
        public string? plan_type { get; set; }

        /// <summary>
        /// INR by default.
        /// </summary>
        /// <value>INR by default.</value>
        [DataMember(Name = "plan_currency", EmitDefaultValue = false)]
        public string? plan_currency { get; set; }

        /// <summary>
        /// The amount to be charged for PERIODIC plan. This is a conditional parameter, only required for PERIODIC plans.
        /// </summary>
        /// <value>The amount to be charged for PERIODIC plan. This is a conditional parameter, only required for PERIODIC plans.</value>
        [DataMember(Name = "plan_amount", EmitDefaultValue = false)]
        public decimal? plan_amount { get; set; }

        /// <summary>
        /// This is the maximum amount that can be charged on a subscription.
        /// </summary>
        /// <value>This is the maximum amount that can be charged on a subscription.</value>
        [DataMember(Name = "plan_max_amount", EmitDefaultValue = false)]
        public decimal? plan_max_amount { get; set; }

        /// <summary>
        /// Maximum number of debits set for the plan. The subscription will automatically change to COMPLETED status once this limit is reached.
        /// </summary>
        /// <value>Maximum number of debits set for the plan. The subscription will automatically change to COMPLETED status once this limit is reached.</value>
        [DataMember(Name = "plan_max_cycles", EmitDefaultValue = false)]
        public int? plan_max_cycles { get; set; }

        /// <summary>
        /// Number of intervals of intervalType between every subscription payment. For example, to charge a customer bi-weekly use intervalType as “week” and intervals as 2. Required for PERIODIC plan. The default value is 1.
        /// </summary>
        /// <value>Number of intervals of intervalType between every subscription payment. For example, to charge a customer bi-weekly use intervalType as “week” and intervals as 2. Required for PERIODIC plan. The default value is 1.</value>
        [DataMember(Name = "plan_intervals", EmitDefaultValue = false)]
        public int? plan_intervals { get; set; }

        /// <summary>
        /// The type of interval for a PERIODIC plan like DAY, WEEK, MONTH, or YEAR. This is a conditional parameter only applicable for PERIODIC plans.
        /// </summary>
        /// <value>The type of interval for a PERIODIC plan like DAY, WEEK, MONTH, or YEAR. This is a conditional parameter only applicable for PERIODIC plans.</value>
        [DataMember(Name = "plan_interval_type", EmitDefaultValue = false)]
        public string? plan_interval_type { get; set; }

        /// <summary>
        /// Note for the plan.
        /// </summary>
        /// <value>Note for the plan.</value>
        [DataMember(Name = "plan_note", EmitDefaultValue = false)]
        public string? plan_note { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSubscriptionRequestPlanDetails {\n");
            sb.Append("  plan_id: ").Append(plan_id).Append("\n");
            sb.Append("  plan_name: ").Append(plan_name).Append("\n");
            sb.Append("  plan_type: ").Append(plan_type).Append("\n");
            sb.Append("  plan_currency: ").Append(plan_currency).Append("\n");
            sb.Append("  plan_amount: ").Append(plan_amount).Append("\n");
            sb.Append("  plan_max_amount: ").Append(plan_max_amount).Append("\n");
            sb.Append("  plan_max_cycles: ").Append(plan_max_cycles).Append("\n");
            sb.Append("  plan_intervals: ").Append(plan_intervals).Append("\n");
            sb.Append("  plan_interval_type: ").Append(plan_interval_type).Append("\n");
            sb.Append("  plan_note: ").Append(plan_note).Append("\n");
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
            return this.Equals(input as CreateSubscriptionRequestPlanDetails);
        }

        /// <summary>
        /// Returns true if CreateSubscriptionRequestPlanDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSubscriptionRequestPlanDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSubscriptionRequestPlanDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.plan_id == input.plan_id ||
                    (this.plan_id != null &&
                    this.plan_id.Equals(input.plan_id))
                ) && 
                (
                    this.plan_name == input.plan_name ||
                    (this.plan_name != null &&
                    this.plan_name.Equals(input.plan_name))
                ) && 
                (
                    this.plan_type == input.plan_type ||
                    (this.plan_type != null &&
                    this.plan_type.Equals(input.plan_type))
                ) && 
                (
                    this.plan_currency == input.plan_currency ||
                    (this.plan_currency != null &&
                    this.plan_currency.Equals(input.plan_currency))
                ) && 
                (
                    this.plan_amount == input.plan_amount ||
                    this.plan_amount.Equals(input.plan_amount)
                ) && 
                (
                    this.plan_max_amount == input.plan_max_amount ||
                    this.plan_max_amount.Equals(input.plan_max_amount)
                ) && 
                (
                    this.plan_max_cycles == input.plan_max_cycles ||
                    this.plan_max_cycles.Equals(input.plan_max_cycles)
                ) && 
                (
                    this.plan_intervals == input.plan_intervals ||
                    this.plan_intervals.Equals(input.plan_intervals)
                ) && 
                (
                    this.plan_interval_type == input.plan_interval_type ||
                    (this.plan_interval_type != null &&
                    this.plan_interval_type.Equals(input.plan_interval_type))
                ) && 
                (
                    this.plan_note == input.plan_note ||
                    (this.plan_note != null &&
                    this.plan_note.Equals(input.plan_note))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringplan_id) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringplan_id);
            if (deserializedJsonString.ContainsKey("plan_id")) {
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
                if (this.plan_id != null)
                {
                    hashCode = (hashCode * 59) + this.plan_id.GetHashCode();
                }
                if (this.plan_name != null)
                {
                    hashCode = (hashCode * 59) + this.plan_name.GetHashCode();
                }
                if (this.plan_type != null)
                {
                    hashCode = (hashCode * 59) + this.plan_type.GetHashCode();
                }
                if (this.plan_currency != null)
                {
                    hashCode = (hashCode * 59) + this.plan_currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.plan_amount.GetHashCode();
                hashCode = (hashCode * 59) + this.plan_max_amount.GetHashCode();
                hashCode = (hashCode * 59) + this.plan_max_cycles.GetHashCode();
                hashCode = (hashCode * 59) + this.plan_intervals.GetHashCode();
                if (this.plan_interval_type != null)
                {
                    hashCode = (hashCode * 59) + this.plan_interval_type.GetHashCode();
                }
                if (this.plan_note != null)
                {
                    hashCode = (hashCode * 59) + this.plan_note.GetHashCode();
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
            // plan_name (string) maxLength
            if (this.plan_name != null && this.plan_name.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for plan_name, length must be less than 40.", new [] { "plan_name" });
            }

            yield break;
        }
    }

}

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
    /// Payment link success creation response object
    /// </summary>
    [DataContract(Name = "LinkEntity")]
    public class LinkEntity : IEquatable<LinkEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LinkEntity" /> class.
        /// </summary>
        /// <param name="cfLinkId">cfLinkId.</param>
        /// <param name="linkId">linkId.</param>
        /// <param name="linkStatus">linkStatus.</param>
        /// <param name="linkCurrency">linkCurrency.</param>
        /// <param name="linkAmount">linkAmount.</param>
        /// <param name="linkAmountPaid">linkAmountPaid.</param>
        /// <param name="linkPartialPayments">linkPartialPayments.</param>
        /// <param name="linkMinimumPartialAmount">linkMinimumPartialAmount.</param>
        /// <param name="linkPurpose">linkPurpose.</param>
        /// <param name="linkCreatedAt">linkCreatedAt.</param>
        /// <param name="customerDetails">customerDetails.</param>
        /// <param name="linkMeta">linkMeta.</param>
        /// <param name="linkUrl">linkUrl.</param>
        /// <param name="linkExpiryTime">linkExpiryTime.</param>
        /// <param name="linkNotes">Key-value pair that can be used to store additional information about the entity. Maximum 5 key-value pairs.</param>
        /// <param name="linkAutoReminders">linkAutoReminders.</param>
        /// <param name="linkNotify">linkNotify.</param>
        public LinkEntity(int cfLinkId = default(int), string linkId = default(string), string linkStatus = default(string), string linkCurrency = default(string), decimal linkAmount = default(decimal), decimal linkAmountPaid = default(decimal), bool linkPartialPayments = default(bool), decimal linkMinimumPartialAmount = default(decimal), string linkPurpose = default(string), string linkCreatedAt = default(string), LinkCustomerDetailsEntity customerDetails = default(LinkCustomerDetailsEntity), LinkMetaEntity linkMeta = default(LinkMetaEntity), string linkUrl = default(string), string linkExpiryTime = default(string), Dictionary<string, string> linkNotes = default(Dictionary<string, string>), bool linkAutoReminders = default(bool), LinkNotifyEntity linkNotify = default(LinkNotifyEntity))
        {
            this.cf_link_id = cfLinkId;
            this.link_id = linkId;
            this.link_status = linkStatus;
            this.link_currency = linkCurrency;
            this.link_amount = linkAmount;
            this.link_amount_paid = linkAmountPaid;
            this.link_partial_payments = linkPartialPayments;
            this.link_minimum_partial_amount = linkMinimumPartialAmount;
            this.link_purpose = linkPurpose;
            this.link_created_at = linkCreatedAt;
            this.customer_details = customerDetails;
            this.link_meta = linkMeta;
            this.link_url = linkUrl;
            this.link_expiry_time = linkExpiryTime;
            this.link_notes = linkNotes;
            this.link_auto_reminders = linkAutoReminders;
            this.link_notify = linkNotify;
        }

        /// <summary>
        /// Gets or Sets cf_link_id
        /// </summary>
        [DataMember(Name = "cf_link_id", EmitDefaultValue = false)]
        public int cf_link_id { get; set; }

        /// <summary>
        /// Gets or Sets link_id
        /// </summary>
        [DataMember(Name = "link_id", EmitDefaultValue = false)]
        public string link_id { get; set; }

        /// <summary>
        /// Gets or Sets link_status
        /// </summary>
        [DataMember(Name = "link_status", EmitDefaultValue = false)]
        public string link_status { get; set; }

        /// <summary>
        /// Gets or Sets link_currency
        /// </summary>
        [DataMember(Name = "link_currency", EmitDefaultValue = false)]
        public string link_currency { get; set; }

        /// <summary>
        /// Gets or Sets link_amount
        /// </summary>
        [DataMember(Name = "link_amount", EmitDefaultValue = false)]
        public decimal link_amount { get; set; }

        /// <summary>
        /// Gets or Sets link_amount_paid
        /// </summary>
        [DataMember(Name = "link_amount_paid", EmitDefaultValue = false)]
        public decimal link_amount_paid { get; set; }

        /// <summary>
        /// Gets or Sets link_partial_payments
        /// </summary>
        [DataMember(Name = "link_partial_payments", EmitDefaultValue = true)]
        public bool link_partial_payments { get; set; }

        /// <summary>
        /// Gets or Sets link_minimum_partial_amount
        /// </summary>
        [DataMember(Name = "link_minimum_partial_amount", EmitDefaultValue = false)]
        public decimal link_minimum_partial_amount { get; set; }

        /// <summary>
        /// Gets or Sets link_purpose
        /// </summary>
        [DataMember(Name = "link_purpose", EmitDefaultValue = false)]
        public string link_purpose { get; set; }

        /// <summary>
        /// Gets or Sets link_created_at
        /// </summary>
        [DataMember(Name = "link_created_at", EmitDefaultValue = false)]
        public string link_created_at { get; set; }

        /// <summary>
        /// Gets or Sets customer_details
        /// </summary>
        [DataMember(Name = "customer_details", EmitDefaultValue = false)]
        public LinkCustomerDetailsEntity customer_details { get; set; }

        /// <summary>
        /// Gets or Sets link_meta
        /// </summary>
        [DataMember(Name = "link_meta", EmitDefaultValue = false)]
        public LinkMetaEntity link_meta { get; set; }

        /// <summary>
        /// Gets or Sets link_url
        /// </summary>
        [DataMember(Name = "link_url", EmitDefaultValue = false)]
        public string link_url { get; set; }

        /// <summary>
        /// Gets or Sets link_expiry_time
        /// </summary>
        [DataMember(Name = "link_expiry_time", EmitDefaultValue = false)]
        public string link_expiry_time { get; set; }

        /// <summary>
        /// Key-value pair that can be used to store additional information about the entity. Maximum 5 key-value pairs
        /// </summary>
        /// <value>Key-value pair that can be used to store additional information about the entity. Maximum 5 key-value pairs</value>
        /// <example>{&quot;key_1&quot;:&quot;value_1&quot;,&quot;key_2&quot;:&quot;value_2&quot;}</example>
        [DataMember(Name = "link_notes", EmitDefaultValue = false)]
        public Dictionary<string, string> link_notes { get; set; }

        /// <summary>
        /// Gets or Sets link_auto_reminders
        /// </summary>
        [DataMember(Name = "link_auto_reminders", EmitDefaultValue = true)]
        public bool link_auto_reminders { get; set; }

        /// <summary>
        /// Gets or Sets link_notify
        /// </summary>
        [DataMember(Name = "link_notify", EmitDefaultValue = false)]
        public LinkNotifyEntity link_notify { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LinkEntity {\n");
            sb.Append("  cf_link_id: ").Append(cf_link_id).Append("\n");
            sb.Append("  link_id: ").Append(link_id).Append("\n");
            sb.Append("  link_status: ").Append(link_status).Append("\n");
            sb.Append("  link_currency: ").Append(link_currency).Append("\n");
            sb.Append("  link_amount: ").Append(link_amount).Append("\n");
            sb.Append("  link_amount_paid: ").Append(link_amount_paid).Append("\n");
            sb.Append("  link_partial_payments: ").Append(link_partial_payments).Append("\n");
            sb.Append("  link_minimum_partial_amount: ").Append(link_minimum_partial_amount).Append("\n");
            sb.Append("  link_purpose: ").Append(link_purpose).Append("\n");
            sb.Append("  link_created_at: ").Append(link_created_at).Append("\n");
            sb.Append("  customer_details: ").Append(customer_details).Append("\n");
            sb.Append("  link_meta: ").Append(link_meta).Append("\n");
            sb.Append("  link_url: ").Append(link_url).Append("\n");
            sb.Append("  link_expiry_time: ").Append(link_expiry_time).Append("\n");
            sb.Append("  link_notes: ").Append(link_notes).Append("\n");
            sb.Append("  link_auto_reminders: ").Append(link_auto_reminders).Append("\n");
            sb.Append("  link_notify: ").Append(link_notify).Append("\n");
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
            return this.Equals(input as LinkEntity);
        }

        /// <summary>
        /// Returns true if LinkEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of LinkEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LinkEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.cf_link_id == input.cf_link_id ||
                    this.cf_link_id.Equals(input.cf_link_id)
                ) && 
                (
                    this.link_id == input.link_id ||
                    (this.link_id != null &&
                    this.link_id.Equals(input.link_id))
                ) && 
                (
                    this.link_status == input.link_status ||
                    (this.link_status != null &&
                    this.link_status.Equals(input.link_status))
                ) && 
                (
                    this.link_currency == input.link_currency ||
                    (this.link_currency != null &&
                    this.link_currency.Equals(input.link_currency))
                ) && 
                (
                    this.link_amount == input.link_amount ||
                    this.link_amount.Equals(input.link_amount)
                ) && 
                (
                    this.link_amount_paid == input.link_amount_paid ||
                    this.link_amount_paid.Equals(input.link_amount_paid)
                ) && 
                (
                    this.link_partial_payments == input.link_partial_payments ||
                    this.link_partial_payments.Equals(input.link_partial_payments)
                ) && 
                (
                    this.link_minimum_partial_amount == input.link_minimum_partial_amount ||
                    this.link_minimum_partial_amount.Equals(input.link_minimum_partial_amount)
                ) && 
                (
                    this.link_purpose == input.link_purpose ||
                    (this.link_purpose != null &&
                    this.link_purpose.Equals(input.link_purpose))
                ) && 
                (
                    this.link_created_at == input.link_created_at ||
                    (this.link_created_at != null &&
                    this.link_created_at.Equals(input.link_created_at))
                ) && 
                (
                    this.customer_details == input.customer_details ||
                    (this.customer_details != null &&
                    this.customer_details.Equals(input.customer_details))
                ) && 
                (
                    this.link_meta == input.link_meta ||
                    (this.link_meta != null &&
                    this.link_meta.Equals(input.link_meta))
                ) && 
                (
                    this.link_url == input.link_url ||
                    (this.link_url != null &&
                    this.link_url.Equals(input.link_url))
                ) && 
                (
                    this.link_expiry_time == input.link_expiry_time ||
                    (this.link_expiry_time != null &&
                    this.link_expiry_time.Equals(input.link_expiry_time))
                ) && 
                (
                    this.link_notes == input.link_notes ||
                    this.link_notes != null &&
                    input.link_notes != null &&
                    this.link_notes.SequenceEqual(input.link_notes)
                ) && 
                (
                    this.link_auto_reminders == input.link_auto_reminders ||
                    this.link_auto_reminders.Equals(input.link_auto_reminders)
                ) && 
                (
                    this.link_notify == input.link_notify ||
                    (this.link_notify != null &&
                    this.link_notify.Equals(input.link_notify))
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
                hashCode = (hashCode * 59) + this.cf_link_id.GetHashCode();
                if (this.link_id != null)
                {
                    hashCode = (hashCode * 59) + this.link_id.GetHashCode();
                }
                if (this.link_status != null)
                {
                    hashCode = (hashCode * 59) + this.link_status.GetHashCode();
                }
                if (this.link_currency != null)
                {
                    hashCode = (hashCode * 59) + this.link_currency.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.link_amount.GetHashCode();
                hashCode = (hashCode * 59) + this.link_amount_paid.GetHashCode();
                hashCode = (hashCode * 59) + this.link_partial_payments.GetHashCode();
                hashCode = (hashCode * 59) + this.link_minimum_partial_amount.GetHashCode();
                if (this.link_purpose != null)
                {
                    hashCode = (hashCode * 59) + this.link_purpose.GetHashCode();
                }
                if (this.link_created_at != null)
                {
                    hashCode = (hashCode * 59) + this.link_created_at.GetHashCode();
                }
                if (this.customer_details != null)
                {
                    hashCode = (hashCode * 59) + this.customer_details.GetHashCode();
                }
                if (this.link_meta != null)
                {
                    hashCode = (hashCode * 59) + this.link_meta.GetHashCode();
                }
                if (this.link_url != null)
                {
                    hashCode = (hashCode * 59) + this.link_url.GetHashCode();
                }
                if (this.link_expiry_time != null)
                {
                    hashCode = (hashCode * 59) + this.link_expiry_time.GetHashCode();
                }
                if (this.link_notes != null)
                {
                    hashCode = (hashCode * 59) + this.link_notes.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.link_auto_reminders.GetHashCode();
                if (this.link_notify != null)
                {
                    hashCode = (hashCode * 59) + this.link_notify.GetHashCode();
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
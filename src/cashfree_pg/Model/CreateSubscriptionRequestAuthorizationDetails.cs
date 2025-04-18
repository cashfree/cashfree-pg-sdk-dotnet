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
    /// CreateSubscriptionRequestAuthorizationDetails
    /// </summary>
    [DataContract(Name = "CreateSubscriptionRequest_authorization_details")]
    public class CreateSubscriptionRequestAuthorizationDetails : IEquatable<CreateSubscriptionRequestAuthorizationDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateSubscriptionRequestAuthorizationDetails" /> class.
        /// </summary>
        /// <param name="authorizationAmount">Authorization amount for the auth payment..</param>
        /// <param name="authorizationAmountRefund">Indicates whether the authorization amount should be refunded to the customer automatically. Merchants can use this field to specify if the authorized funds should be returned to the customer after authorization of the subscription..</param>
        /// <param name="paymentMethods">Payment methods for the subscription. enach, pnach, upi, card are possible values..</param>
        public CreateSubscriptionRequestAuthorizationDetails(decimal? authorizationAmount = default(decimal?), bool? authorizationAmountRefund = default(bool?), List<string>? paymentMethods = default(List<string>?))
        {
            this.authorization_amount = authorizationAmount;
            this.authorization_amount_refund = authorizationAmountRefund;
            this.payment_methods = paymentMethods;
        }

        /// <summary>
        /// Authorization amount for the auth payment.
        /// </summary>
        /// <value>Authorization amount for the auth payment.</value>
        [DataMember(Name = "authorization_amount", EmitDefaultValue = false)]
        public decimal? authorization_amount { get; set; }

        /// <summary>
        /// Indicates whether the authorization amount should be refunded to the customer automatically. Merchants can use this field to specify if the authorized funds should be returned to the customer after authorization of the subscription.
        /// </summary>
        /// <value>Indicates whether the authorization amount should be refunded to the customer automatically. Merchants can use this field to specify if the authorized funds should be returned to the customer after authorization of the subscription.</value>
        [DataMember(Name = "authorization_amount_refund", EmitDefaultValue = true)]
        public bool? authorization_amount_refund { get; set; }

        /// <summary>
        /// Payment methods for the subscription. enach, pnach, upi, card are possible values.
        /// </summary>
        /// <value>Payment methods for the subscription. enach, pnach, upi, card are possible values.</value>
        [DataMember(Name = "payment_methods", EmitDefaultValue = false)]
        public List<string>? payment_methods { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateSubscriptionRequestAuthorizationDetails {\n");
            sb.Append("  authorization_amount: ").Append(authorization_amount).Append("\n");
            sb.Append("  authorization_amount_refund: ").Append(authorization_amount_refund).Append("\n");
            sb.Append("  payment_methods: ").Append(payment_methods).Append("\n");
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
            return this.Equals(input as CreateSubscriptionRequestAuthorizationDetails);
        }

        /// <summary>
        /// Returns true if CreateSubscriptionRequestAuthorizationDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateSubscriptionRequestAuthorizationDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateSubscriptionRequestAuthorizationDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.authorization_amount == input.authorization_amount ||
                    this.authorization_amount.Equals(input.authorization_amount)
                ) && 
                (
                    this.authorization_amount_refund == input.authorization_amount_refund ||
                    this.authorization_amount_refund.Equals(input.authorization_amount_refund)
                ) && 
                (
                    this.payment_methods == input.payment_methods ||
                    this.payment_methods != null &&
                    input.payment_methods != null &&
                    this.payment_methods.SequenceEqual(input.payment_methods)
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringauthorization_amount) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringauthorization_amount);
            if (deserializedJsonString.ContainsKey("authorization_amount")) {
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
                hashCode = (hashCode * 59) + this.authorization_amount.GetHashCode();
                hashCode = (hashCode * 59) + this.authorization_amount_refund.GetHashCode();
                if (this.payment_methods != null)
                {
                    hashCode = (hashCode * 59) + this.payment_methods.GetHashCode();
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

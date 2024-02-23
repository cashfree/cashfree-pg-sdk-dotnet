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
    /// Terminal metadata.
    /// </summary>
    [DataContract(Name = "UpdateTerminalRequest_terminal_meta")]
    public class UpdateTerminalRequestTerminalMeta : IEquatable<UpdateTerminalRequestTerminalMeta>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTerminalRequestTerminalMeta" /> class.
        /// </summary>
        /// <param name="terminalOperator">Name of the operator for the storefront..</param>
        public UpdateTerminalRequestTerminalMeta(string terminalOperator = default(string))
        {
            this.terminal_operator = terminalOperator;
        }

        /// <summary>
        /// Name of the operator for the storefront.
        /// </summary>
        /// <value>Name of the operator for the storefront.</value>
        [DataMember(Name = "terminal_operator", EmitDefaultValue = false)]
        public string terminal_operator { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UpdateTerminalRequestTerminalMeta {\n");
            sb.Append("  terminal_operator: ").Append(terminal_operator).Append("\n");
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
            return this.Equals(input as UpdateTerminalRequestTerminalMeta);
        }

        /// <summary>
        /// Returns true if UpdateTerminalRequestTerminalMeta instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateTerminalRequestTerminalMeta to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateTerminalRequestTerminalMeta input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.terminal_operator == input.terminal_operator ||
                    (this.terminal_operator != null &&
                    this.terminal_operator.Equals(input.terminal_operator))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringterminal_operator) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringterminal_operator);
            if (deserializedJsonString.ContainsKey("terminal_operator")) {
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
                if (this.terminal_operator != null)
                {
                    hashCode = (hashCode * 59) + this.terminal_operator.GetHashCode();
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
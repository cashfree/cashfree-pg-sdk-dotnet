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
    /// Use this if you are creating an order for cashfree&#39;s softPOS
    /// </summary>
    [DataContract(Name = "TerminalDetails")]
    public class TerminalDetails : IEquatable<TerminalDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TerminalDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TerminalDetails" /> class.
        /// </summary>
        /// <param name="addedOn">date time at which terminal is added.</param>
        /// <param name="cfTerminalId">cashfree terminal id.</param>
        /// <param name="lastUpdatedOn">last instant when this terminal was updated.</param>
        /// <param name="terminalAddress">location of terminal.</param>
        /// <param name="terminalId">terminal id for merchant reference (required).</param>
        /// <param name="terminalName">name of terminal/agent/storefront.</param>
        /// <param name="terminalNote">note given by merchant while creating the terminal.</param>
        /// <param name="terminalPhoneNo">mobile num of the terminal/agent/storefront (required).</param>
        /// <param name="terminalStatus">status of terminal active/inactive.</param>
        /// <param name="terminalType">To identify the type of terminal product in use, in this case it is SPOS. (required).</param>
        public TerminalDetails(string addedOn = default(string), int cfTerminalId = default(int), string lastUpdatedOn = default(string), string terminalAddress = default(string), string terminalId = default(string), string terminalName = default(string), string terminalNote = default(string), string terminalPhoneNo = default(string), string terminalStatus = default(string), string terminalType = default(string))
        {
            // to ensure "terminalId" is required (not null)
            if (terminalId == null)
            {
                throw new ArgumentNullException("terminalId is a required property for TerminalDetails and cannot be null");
            }
            this.terminal_id = terminalId;
            // to ensure "terminalPhoneNo" is required (not null)
            if (terminalPhoneNo == null)
            {
                throw new ArgumentNullException("terminalPhoneNo is a required property for TerminalDetails and cannot be null");
            }
            this.terminal_phone_no = terminalPhoneNo;
            // to ensure "terminalType" is required (not null)
            if (terminalType == null)
            {
                throw new ArgumentNullException("terminalType is a required property for TerminalDetails and cannot be null");
            }
            this.terminal_type = terminalType;
            this.added_on = addedOn;
            this.cf_terminal_id = cfTerminalId;
            this.last_updated_on = lastUpdatedOn;
            this.terminal_address = terminalAddress;
            this.terminal_name = terminalName;
            this.terminal_note = terminalNote;
            this.terminal_status = terminalStatus;
        }

        /// <summary>
        /// date time at which terminal is added
        /// </summary>
        /// <value>date time at which terminal is added</value>
        [DataMember(Name = "added_on", EmitDefaultValue = false)]
        public string added_on { get; set; }

        /// <summary>
        /// cashfree terminal id
        /// </summary>
        /// <value>cashfree terminal id</value>
        [DataMember(Name = "cf_terminal_id", EmitDefaultValue = false)]
        public int cf_terminal_id { get; set; }

        /// <summary>
        /// last instant when this terminal was updated
        /// </summary>
        /// <value>last instant when this terminal was updated</value>
        [DataMember(Name = "last_updated_on", EmitDefaultValue = false)]
        public string last_updated_on { get; set; }

        /// <summary>
        /// location of terminal
        /// </summary>
        /// <value>location of terminal</value>
        [DataMember(Name = "terminal_address", EmitDefaultValue = false)]
        public string terminal_address { get; set; }

        /// <summary>
        /// terminal id for merchant reference
        /// </summary>
        /// <value>terminal id for merchant reference</value>
        [DataMember(Name = "terminal_id", IsRequired = true, EmitDefaultValue = true)]
        public string terminal_id { get; set; }

        /// <summary>
        /// name of terminal/agent/storefront
        /// </summary>
        /// <value>name of terminal/agent/storefront</value>
        [DataMember(Name = "terminal_name", EmitDefaultValue = false)]
        public string terminal_name { get; set; }

        /// <summary>
        /// note given by merchant while creating the terminal
        /// </summary>
        /// <value>note given by merchant while creating the terminal</value>
        [DataMember(Name = "terminal_note", EmitDefaultValue = false)]
        public string terminal_note { get; set; }

        /// <summary>
        /// mobile num of the terminal/agent/storefront
        /// </summary>
        /// <value>mobile num of the terminal/agent/storefront</value>
        [DataMember(Name = "terminal_phone_no", IsRequired = true, EmitDefaultValue = true)]
        public string terminal_phone_no { get; set; }

        /// <summary>
        /// status of terminal active/inactive
        /// </summary>
        /// <value>status of terminal active/inactive</value>
        [DataMember(Name = "terminal_status", EmitDefaultValue = false)]
        public string terminal_status { get; set; }

        /// <summary>
        /// To identify the type of terminal product in use, in this case it is SPOS.
        /// </summary>
        /// <value>To identify the type of terminal product in use, in this case it is SPOS.</value>
        [DataMember(Name = "terminal_type", IsRequired = true, EmitDefaultValue = true)]
        public string terminal_type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TerminalDetails {\n");
            sb.Append("  added_on: ").Append(added_on).Append("\n");
            sb.Append("  cf_terminal_id: ").Append(cf_terminal_id).Append("\n");
            sb.Append("  last_updated_on: ").Append(last_updated_on).Append("\n");
            sb.Append("  terminal_address: ").Append(terminal_address).Append("\n");
            sb.Append("  terminal_id: ").Append(terminal_id).Append("\n");
            sb.Append("  terminal_name: ").Append(terminal_name).Append("\n");
            sb.Append("  terminal_note: ").Append(terminal_note).Append("\n");
            sb.Append("  terminal_phone_no: ").Append(terminal_phone_no).Append("\n");
            sb.Append("  terminal_status: ").Append(terminal_status).Append("\n");
            sb.Append("  terminal_type: ").Append(terminal_type).Append("\n");
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
            return this.Equals(input as TerminalDetails);
        }

        /// <summary>
        /// Returns true if TerminalDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of TerminalDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TerminalDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.added_on == input.added_on ||
                    (this.added_on != null &&
                    this.added_on.Equals(input.added_on))
                ) && 
                (
                    this.cf_terminal_id == input.cf_terminal_id ||
                    this.cf_terminal_id.Equals(input.cf_terminal_id)
                ) && 
                (
                    this.last_updated_on == input.last_updated_on ||
                    (this.last_updated_on != null &&
                    this.last_updated_on.Equals(input.last_updated_on))
                ) && 
                (
                    this.terminal_address == input.terminal_address ||
                    (this.terminal_address != null &&
                    this.terminal_address.Equals(input.terminal_address))
                ) && 
                (
                    this.terminal_id == input.terminal_id ||
                    (this.terminal_id != null &&
                    this.terminal_id.Equals(input.terminal_id))
                ) && 
                (
                    this.terminal_name == input.terminal_name ||
                    (this.terminal_name != null &&
                    this.terminal_name.Equals(input.terminal_name))
                ) && 
                (
                    this.terminal_note == input.terminal_note ||
                    (this.terminal_note != null &&
                    this.terminal_note.Equals(input.terminal_note))
                ) && 
                (
                    this.terminal_phone_no == input.terminal_phone_no ||
                    (this.terminal_phone_no != null &&
                    this.terminal_phone_no.Equals(input.terminal_phone_no))
                ) && 
                (
                    this.terminal_status == input.terminal_status ||
                    (this.terminal_status != null &&
                    this.terminal_status.Equals(input.terminal_status))
                ) && 
                (
                    this.terminal_type == input.terminal_type ||
                    (this.terminal_type != null &&
                    this.terminal_type.Equals(input.terminal_type))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringadded_on) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringadded_on);
            if (deserializedJsonString.ContainsKey("added_on")) {
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
                if (this.added_on != null)
                {
                    hashCode = (hashCode * 59) + this.added_on.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.cf_terminal_id.GetHashCode();
                if (this.last_updated_on != null)
                {
                    hashCode = (hashCode * 59) + this.last_updated_on.GetHashCode();
                }
                if (this.terminal_address != null)
                {
                    hashCode = (hashCode * 59) + this.terminal_address.GetHashCode();
                }
                if (this.terminal_id != null)
                {
                    hashCode = (hashCode * 59) + this.terminal_id.GetHashCode();
                }
                if (this.terminal_name != null)
                {
                    hashCode = (hashCode * 59) + this.terminal_name.GetHashCode();
                }
                if (this.terminal_note != null)
                {
                    hashCode = (hashCode * 59) + this.terminal_note.GetHashCode();
                }
                if (this.terminal_phone_no != null)
                {
                    hashCode = (hashCode * 59) + this.terminal_phone_no.GetHashCode();
                }
                if (this.terminal_status != null)
                {
                    hashCode = (hashCode * 59) + this.terminal_status.GetHashCode();
                }
                if (this.terminal_type != null)
                {
                    hashCode = (hashCode * 59) + this.terminal_type.GetHashCode();
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
            // terminal_id (string) maxLength
            if (this.terminal_id != null && this.terminal_id.Length > 100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for terminal_id, length must be less than 100.", new [] { "terminal_id" });
            }

            // terminal_id (string) minLength
            if (this.terminal_id != null && this.terminal_id.Length < 3)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for terminal_id, length must be greater than 3.", new [] { "terminal_id" });
            }

            // terminal_type (string) maxLength
            if (this.terminal_type != null && this.terminal_type.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for terminal_type, length must be less than 10.", new [] { "terminal_type" });
            }

            // terminal_type (string) minLength
            if (this.terminal_type != null && this.terminal_type.Length < 4)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for terminal_type, length must be greater than 4.", new [] { "terminal_type" });
            }

            yield break;
        }
    }

}

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
    /// Simulation response object
    /// </summary>
    [DataContract(Name = "SimulationResponse")]
    public class SimulationResponse : IEquatable<SimulationResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimulationResponse" /> class.
        /// </summary>
        /// <param name="simulationId">simulationId.</param>
        /// <param name="entity">entity.</param>
        /// <param name="entityId">entityId.</param>
        /// <param name="entitySimulation">entitySimulation.</param>
        public SimulationResponse(string? simulationId = default(string?), string? entity = default(string?), string? entityId = default(string?), EntitySimulationResponse? entitySimulation = default(EntitySimulationResponse?))
        {
            this.simulation_id = simulationId;
            this.entity = entity;
            this.entity_id = entityId;
            this.entity_simulation = entitySimulation;
        }

        /// <summary>
        /// Gets or Sets simulation_id
        /// </summary>
        [DataMember(Name = "simulation_id", EmitDefaultValue = false)]
        public string? simulation_id { get; set; }

        /// <summary>
        /// Gets or Sets entity
        /// </summary>
        [DataMember(Name = "entity", EmitDefaultValue = false)]
        public string? entity { get; set; }

        /// <summary>
        /// Gets or Sets entity_id
        /// </summary>
        [DataMember(Name = "entity_id", EmitDefaultValue = false)]
        public string? entity_id { get; set; }

        /// <summary>
        /// Gets or Sets entity_simulation
        /// </summary>
        [DataMember(Name = "entity_simulation", EmitDefaultValue = false)]
        public EntitySimulationResponse? entity_simulation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SimulationResponse {\n");
            sb.Append("  simulation_id: ").Append(simulation_id).Append("\n");
            sb.Append("  entity: ").Append(entity).Append("\n");
            sb.Append("  entity_id: ").Append(entity_id).Append("\n");
            sb.Append("  entity_simulation: ").Append(entity_simulation).Append("\n");
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
            return this.Equals(input as SimulationResponse);
        }

        /// <summary>
        /// Returns true if SimulationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of SimulationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimulationResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.simulation_id == input.simulation_id ||
                    (this.simulation_id != null &&
                    this.simulation_id.Equals(input.simulation_id))
                ) && 
                (
                    this.entity == input.entity ||
                    (this.entity != null &&
                    this.entity.Equals(input.entity))
                ) && 
                (
                    this.entity_id == input.entity_id ||
                    (this.entity_id != null &&
                    this.entity_id.Equals(input.entity_id))
                ) && 
                (
                    this.entity_simulation == input.entity_simulation ||
                    (this.entity_simulation != null &&
                    this.entity_simulation.Equals(input.entity_simulation))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringsimulation_id) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringsimulation_id);
            if (deserializedJsonString.ContainsKey("simulation_id")) {
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
                if (this.simulation_id != null)
                {
                    hashCode = (hashCode * 59) + this.simulation_id.GetHashCode();
                }
                if (this.entity != null)
                {
                    hashCode = (hashCode * 59) + this.entity.GetHashCode();
                }
                if (this.entity_id != null)
                {
                    hashCode = (hashCode * 59) + this.entity_id.GetHashCode();
                }
                if (this.entity_simulation != null)
                {
                    hashCode = (hashCode * 59) + this.entity_simulation.GetHashCode();
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

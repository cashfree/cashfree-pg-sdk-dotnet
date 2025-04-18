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
using System.Reflection;

namespace cashfree_pg.Model
{
    /// <summary>
    /// PaymentEntityPaymentMethod
    /// </summary>
    [JsonConverter(typeof(PaymentEntityPaymentMethodJsonConverter))]
    [DataContract(Name = "PaymentEntity_payment_method")]
    public class PaymentEntityPaymentMethod : AbstractOpenAPISchema, IEquatable<PaymentEntityPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentEntityPaymentMethod" /> class
        /// with the <see cref="PaymentMethodCardInPaymentsEntity" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaymentMethodCardInPaymentsEntity.</param>
        public PaymentEntityPaymentMethod(PaymentMethodCardInPaymentsEntity actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentEntityPaymentMethod" /> class
        /// with the <see cref="PaymentMethodNetBankingInPaymentsEntity" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaymentMethodNetBankingInPaymentsEntity.</param>
        public PaymentEntityPaymentMethod(PaymentMethodNetBankingInPaymentsEntity actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentEntityPaymentMethod" /> class
        /// with the <see cref="PaymentMethodUPIInPaymentsEntity" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaymentMethodUPIInPaymentsEntity.</param>
        public PaymentEntityPaymentMethod(PaymentMethodUPIInPaymentsEntity actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentEntityPaymentMethod" /> class
        /// with the <see cref="PaymentMethodAppInPaymentsEntity" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaymentMethodAppInPaymentsEntity.</param>
        public PaymentEntityPaymentMethod(PaymentMethodAppInPaymentsEntity actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentEntityPaymentMethod" /> class
        /// with the <see cref="PaymentMethodCardlessEMIInPaymentsEntity" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaymentMethodCardlessEMIInPaymentsEntity.</param>
        public PaymentEntityPaymentMethod(PaymentMethodCardlessEMIInPaymentsEntity actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentEntityPaymentMethod" /> class
        /// with the <see cref="PaymentMethodPaylaterInPaymentsEntity" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaymentMethodPaylaterInPaymentsEntity.</param>
        public PaymentEntityPaymentMethod(PaymentMethodPaylaterInPaymentsEntity actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentEntityPaymentMethod" /> class
        /// with the <see cref="PaymentMethodCardEMIInPaymentsEntity" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaymentMethodCardEMIInPaymentsEntity.</param>
        public PaymentEntityPaymentMethod(PaymentMethodCardEMIInPaymentsEntity actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentEntityPaymentMethod" /> class
        /// with the <see cref="PaymentMethodBankTransferInPaymentsEntity" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaymentMethodBankTransferInPaymentsEntity.</param>
        public PaymentEntityPaymentMethod(PaymentMethodBankTransferInPaymentsEntity actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(PaymentMethodAppInPaymentsEntity))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PaymentMethodBankTransferInPaymentsEntity))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PaymentMethodCardEMIInPaymentsEntity))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PaymentMethodCardInPaymentsEntity))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PaymentMethodCardlessEMIInPaymentsEntity))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PaymentMethodNetBankingInPaymentsEntity))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PaymentMethodPaylaterInPaymentsEntity))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PaymentMethodUPIInPaymentsEntity))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: PaymentMethodAppInPaymentsEntity, PaymentMethodBankTransferInPaymentsEntity, PaymentMethodCardEMIInPaymentsEntity, PaymentMethodCardInPaymentsEntity, PaymentMethodCardlessEMIInPaymentsEntity, PaymentMethodNetBankingInPaymentsEntity, PaymentMethodPaylaterInPaymentsEntity, PaymentMethodUPIInPaymentsEntity");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `PaymentMethodCardInPaymentsEntity`. If the actual instance is not `PaymentMethodCardInPaymentsEntity`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentMethodCardInPaymentsEntity</returns>
        public PaymentMethodCardInPaymentsEntity GetPaymentMethodCardInPaymentsEntity()
        {
            return (PaymentMethodCardInPaymentsEntity)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PaymentMethodNetBankingInPaymentsEntity`. If the actual instance is not `PaymentMethodNetBankingInPaymentsEntity`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentMethodNetBankingInPaymentsEntity</returns>
        public PaymentMethodNetBankingInPaymentsEntity GetPaymentMethodNetBankingInPaymentsEntity()
        {
            return (PaymentMethodNetBankingInPaymentsEntity)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PaymentMethodUPIInPaymentsEntity`. If the actual instance is not `PaymentMethodUPIInPaymentsEntity`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentMethodUPIInPaymentsEntity</returns>
        public PaymentMethodUPIInPaymentsEntity GetPaymentMethodUPIInPaymentsEntity()
        {
            return (PaymentMethodUPIInPaymentsEntity)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PaymentMethodAppInPaymentsEntity`. If the actual instance is not `PaymentMethodAppInPaymentsEntity`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentMethodAppInPaymentsEntity</returns>
        public PaymentMethodAppInPaymentsEntity GetPaymentMethodAppInPaymentsEntity()
        {
            return (PaymentMethodAppInPaymentsEntity)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PaymentMethodCardlessEMIInPaymentsEntity`. If the actual instance is not `PaymentMethodCardlessEMIInPaymentsEntity`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentMethodCardlessEMIInPaymentsEntity</returns>
        public PaymentMethodCardlessEMIInPaymentsEntity GetPaymentMethodCardlessEMIInPaymentsEntity()
        {
            return (PaymentMethodCardlessEMIInPaymentsEntity)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PaymentMethodPaylaterInPaymentsEntity`. If the actual instance is not `PaymentMethodPaylaterInPaymentsEntity`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentMethodPaylaterInPaymentsEntity</returns>
        public PaymentMethodPaylaterInPaymentsEntity GetPaymentMethodPaylaterInPaymentsEntity()
        {
            return (PaymentMethodPaylaterInPaymentsEntity)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PaymentMethodCardEMIInPaymentsEntity`. If the actual instance is not `PaymentMethodCardEMIInPaymentsEntity`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentMethodCardEMIInPaymentsEntity</returns>
        public PaymentMethodCardEMIInPaymentsEntity GetPaymentMethodCardEMIInPaymentsEntity()
        {
            return (PaymentMethodCardEMIInPaymentsEntity)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PaymentMethodBankTransferInPaymentsEntity`. If the actual instance is not `PaymentMethodBankTransferInPaymentsEntity`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaymentMethodBankTransferInPaymentsEntity</returns>
        public PaymentMethodBankTransferInPaymentsEntity GetPaymentMethodBankTransferInPaymentsEntity()
        {
            return (PaymentMethodBankTransferInPaymentsEntity)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentEntityPaymentMethod {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, PaymentEntityPaymentMethod.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of PaymentEntityPaymentMethod
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of PaymentEntityPaymentMethod</returns>
        public static PaymentEntityPaymentMethod FromJson(string jsonString)
        {
            PaymentEntityPaymentMethod newPaymentEntityPaymentMethod = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newPaymentEntityPaymentMethod;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PaymentMethodAppInPaymentsEntity).GetProperty("AdditionalProperties") == null)
                {
                    if(PaymentMethodAppInPaymentsEntity.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<PaymentMethodAppInPaymentsEntity>(jsonString, PaymentEntityPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPaymentEntityPaymentMethod = new PaymentEntityPaymentMethod(data);
                        return newPaymentEntityPaymentMethod;
                    }
                }
                else
                {
                    if(PaymentMethodAppInPaymentsEntity.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<PaymentMethodAppInPaymentsEntity>(jsonString, PaymentEntityPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPaymentEntityPaymentMethod = new PaymentEntityPaymentMethod(data);
                        return newPaymentEntityPaymentMethod;
                    }
                }
                matchedTypes.Add("PaymentMethodAppInPaymentsEntity");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PaymentMethodAppInPaymentsEntity: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PaymentMethodBankTransferInPaymentsEntity).GetProperty("AdditionalProperties") == null)
                {
                    if(PaymentMethodBankTransferInPaymentsEntity.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<PaymentMethodBankTransferInPaymentsEntity>(jsonString, PaymentEntityPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPaymentEntityPaymentMethod = new PaymentEntityPaymentMethod(data);
                        return newPaymentEntityPaymentMethod;
                    }
                }
                else
                {
                    if(PaymentMethodBankTransferInPaymentsEntity.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<PaymentMethodBankTransferInPaymentsEntity>(jsonString, PaymentEntityPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPaymentEntityPaymentMethod = new PaymentEntityPaymentMethod(data);
                        return newPaymentEntityPaymentMethod;
                    }
                }
                matchedTypes.Add("PaymentMethodBankTransferInPaymentsEntity");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PaymentMethodBankTransferInPaymentsEntity: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PaymentMethodCardEMIInPaymentsEntity).GetProperty("AdditionalProperties") == null)
                {
                    if(PaymentMethodCardEMIInPaymentsEntity.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<PaymentMethodCardEMIInPaymentsEntity>(jsonString, PaymentEntityPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPaymentEntityPaymentMethod = new PaymentEntityPaymentMethod(data);
                        return newPaymentEntityPaymentMethod;
                    }
                }
                else
                {
                    if(PaymentMethodCardEMIInPaymentsEntity.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<PaymentMethodCardEMIInPaymentsEntity>(jsonString, PaymentEntityPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPaymentEntityPaymentMethod = new PaymentEntityPaymentMethod(data);
                        return newPaymentEntityPaymentMethod;
                    }
                }
                matchedTypes.Add("PaymentMethodCardEMIInPaymentsEntity");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PaymentMethodCardEMIInPaymentsEntity: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PaymentMethodCardInPaymentsEntity).GetProperty("AdditionalProperties") == null)
                {
                    if(PaymentMethodCardInPaymentsEntity.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<PaymentMethodCardInPaymentsEntity>(jsonString, PaymentEntityPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPaymentEntityPaymentMethod = new PaymentEntityPaymentMethod(data);
                        return newPaymentEntityPaymentMethod;
                    }
                }
                else
                {
                    if(PaymentMethodCardInPaymentsEntity.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<PaymentMethodCardInPaymentsEntity>(jsonString, PaymentEntityPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPaymentEntityPaymentMethod = new PaymentEntityPaymentMethod(data);
                        return newPaymentEntityPaymentMethod;
                    }
                }
                matchedTypes.Add("PaymentMethodCardInPaymentsEntity");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PaymentMethodCardInPaymentsEntity: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PaymentMethodCardlessEMIInPaymentsEntity).GetProperty("AdditionalProperties") == null)
                {
                    if(PaymentMethodCardlessEMIInPaymentsEntity.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<PaymentMethodCardlessEMIInPaymentsEntity>(jsonString, PaymentEntityPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPaymentEntityPaymentMethod = new PaymentEntityPaymentMethod(data);
                        return newPaymentEntityPaymentMethod;
                    }
                }
                else
                {
                    if(PaymentMethodCardlessEMIInPaymentsEntity.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<PaymentMethodCardlessEMIInPaymentsEntity>(jsonString, PaymentEntityPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPaymentEntityPaymentMethod = new PaymentEntityPaymentMethod(data);
                        return newPaymentEntityPaymentMethod;
                    }
                }
                matchedTypes.Add("PaymentMethodCardlessEMIInPaymentsEntity");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PaymentMethodCardlessEMIInPaymentsEntity: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PaymentMethodNetBankingInPaymentsEntity).GetProperty("AdditionalProperties") == null)
                {
                    if(PaymentMethodNetBankingInPaymentsEntity.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<PaymentMethodNetBankingInPaymentsEntity>(jsonString, PaymentEntityPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPaymentEntityPaymentMethod = new PaymentEntityPaymentMethod(data);
                        return newPaymentEntityPaymentMethod;
                    }
                }
                else
                {
                    if(PaymentMethodNetBankingInPaymentsEntity.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<PaymentMethodNetBankingInPaymentsEntity>(jsonString, PaymentEntityPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPaymentEntityPaymentMethod = new PaymentEntityPaymentMethod(data);
                        return newPaymentEntityPaymentMethod;
                    }
                }
                matchedTypes.Add("PaymentMethodNetBankingInPaymentsEntity");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PaymentMethodNetBankingInPaymentsEntity: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PaymentMethodPaylaterInPaymentsEntity).GetProperty("AdditionalProperties") == null)
                {
                    if(PaymentMethodPaylaterInPaymentsEntity.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<PaymentMethodPaylaterInPaymentsEntity>(jsonString, PaymentEntityPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPaymentEntityPaymentMethod = new PaymentEntityPaymentMethod(data);
                        return newPaymentEntityPaymentMethod;
                    }
                }
                else
                {
                    if(PaymentMethodPaylaterInPaymentsEntity.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<PaymentMethodPaylaterInPaymentsEntity>(jsonString, PaymentEntityPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPaymentEntityPaymentMethod = new PaymentEntityPaymentMethod(data);
                        return newPaymentEntityPaymentMethod;
                    }
                }
                matchedTypes.Add("PaymentMethodPaylaterInPaymentsEntity");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PaymentMethodPaylaterInPaymentsEntity: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PaymentMethodUPIInPaymentsEntity).GetProperty("AdditionalProperties") == null)
                {
                    if(PaymentMethodUPIInPaymentsEntity.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<PaymentMethodUPIInPaymentsEntity>(jsonString, PaymentEntityPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPaymentEntityPaymentMethod = new PaymentEntityPaymentMethod(data);
                        return newPaymentEntityPaymentMethod;
                    }
                }
                else
                {
                    if(PaymentMethodUPIInPaymentsEntity.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<PaymentMethodUPIInPaymentsEntity>(jsonString, PaymentEntityPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPaymentEntityPaymentMethod = new PaymentEntityPaymentMethod(data);
                        return newPaymentEntityPaymentMethod;
                    }
                }
                matchedTypes.Add("PaymentMethodUPIInPaymentsEntity");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PaymentMethodUPIInPaymentsEntity: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newPaymentEntityPaymentMethod;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PaymentEntityPaymentMethod);
        }

        /// <summary>
        /// Returns true if PaymentEntityPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentEntityPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentEntityPaymentMethod input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
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

    /// <summary>
    /// Custom JSON converter for PaymentEntityPaymentMethod
    /// </summary>
    public class PaymentEntityPaymentMethodJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(PaymentEntityPaymentMethod).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return PaymentEntityPaymentMethod.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}

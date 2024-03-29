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
using System.Reflection;

namespace cashfree_pg.Model
{
    /// <summary>
    /// OfferValidationsPaymentMethod
    /// </summary>
    [JsonConverter(typeof(OfferValidationsPaymentMethodJsonConverter))]
    [DataContract(Name = "OfferValidations_payment_method")]
    public class OfferValidationsPaymentMethod : AbstractOpenAPISchema, IEquatable<OfferValidationsPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OfferValidationsPaymentMethod" /> class
        /// with the <see cref="OfferAll" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of OfferAll.</param>
        public OfferValidationsPaymentMethod(OfferAll actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OfferValidationsPaymentMethod" /> class
        /// with the <see cref="OfferCard" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of OfferCard.</param>
        public OfferValidationsPaymentMethod(OfferCard actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OfferValidationsPaymentMethod" /> class
        /// with the <see cref="OfferNB" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of OfferNB.</param>
        public OfferValidationsPaymentMethod(OfferNB actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OfferValidationsPaymentMethod" /> class
        /// with the <see cref="OfferWallet" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of OfferWallet.</param>
        public OfferValidationsPaymentMethod(OfferWallet actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OfferValidationsPaymentMethod" /> class
        /// with the <see cref="OfferUPI" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of OfferUPI.</param>
        public OfferValidationsPaymentMethod(OfferUPI actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OfferValidationsPaymentMethod" /> class
        /// with the <see cref="OfferPaylater" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of OfferPaylater.</param>
        public OfferValidationsPaymentMethod(OfferPaylater actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OfferValidationsPaymentMethod" /> class
        /// with the <see cref="OfferEMI" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of OfferEMI.</param>
        public OfferValidationsPaymentMethod(OfferEMI actualInstance)
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
                if (value.GetType() == typeof(OfferAll))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(OfferCard))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(OfferEMI))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(OfferNB))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(OfferPaylater))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(OfferUPI))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(OfferWallet))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: OfferAll, OfferCard, OfferEMI, OfferNB, OfferPaylater, OfferUPI, OfferWallet");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `OfferAll`. If the actual instance is not `OfferAll`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of OfferAll</returns>
        public OfferAll GetOfferAll()
        {
            return (OfferAll)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `OfferCard`. If the actual instance is not `OfferCard`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of OfferCard</returns>
        public OfferCard GetOfferCard()
        {
            return (OfferCard)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `OfferNB`. If the actual instance is not `OfferNB`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of OfferNB</returns>
        public OfferNB GetOfferNB()
        {
            return (OfferNB)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `OfferWallet`. If the actual instance is not `OfferWallet`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of OfferWallet</returns>
        public OfferWallet GetOfferWallet()
        {
            return (OfferWallet)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `OfferUPI`. If the actual instance is not `OfferUPI`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of OfferUPI</returns>
        public OfferUPI GetOfferUPI()
        {
            return (OfferUPI)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `OfferPaylater`. If the actual instance is not `OfferPaylater`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of OfferPaylater</returns>
        public OfferPaylater GetOfferPaylater()
        {
            return (OfferPaylater)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `OfferEMI`. If the actual instance is not `OfferEMI`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of OfferEMI</returns>
        public OfferEMI GetOfferEMI()
        {
            return (OfferEMI)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OfferValidationsPaymentMethod {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, OfferValidationsPaymentMethod.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of OfferValidationsPaymentMethod
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of OfferValidationsPaymentMethod</returns>
        public static OfferValidationsPaymentMethod FromJson(string jsonString)
        {
            OfferValidationsPaymentMethod newOfferValidationsPaymentMethod = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newOfferValidationsPaymentMethod;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(OfferAll).GetProperty("AdditionalProperties") == null)
                {
                    if(OfferAll.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<OfferAll>(jsonString, OfferValidationsPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newOfferValidationsPaymentMethod = new OfferValidationsPaymentMethod(data);
                        return newOfferValidationsPaymentMethod;
                    }
                }
                else
                {
                    if(OfferAll.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<OfferAll>(jsonString, OfferValidationsPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newOfferValidationsPaymentMethod = new OfferValidationsPaymentMethod(data);
                        return newOfferValidationsPaymentMethod;
                    }
                }
                matchedTypes.Add("OfferAll");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into OfferAll: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(OfferCard).GetProperty("AdditionalProperties") == null)
                {
                    if(OfferCard.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<OfferCard>(jsonString, OfferValidationsPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newOfferValidationsPaymentMethod = new OfferValidationsPaymentMethod(data);
                        return newOfferValidationsPaymentMethod;
                    }
                }
                else
                {
                    if(OfferCard.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<OfferCard>(jsonString, OfferValidationsPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newOfferValidationsPaymentMethod = new OfferValidationsPaymentMethod(data);
                        return newOfferValidationsPaymentMethod;
                    }
                }
                matchedTypes.Add("OfferCard");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into OfferCard: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(OfferEMI).GetProperty("AdditionalProperties") == null)
                {
                    if(OfferEMI.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<OfferEMI>(jsonString, OfferValidationsPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newOfferValidationsPaymentMethod = new OfferValidationsPaymentMethod(data);
                        return newOfferValidationsPaymentMethod;
                    }
                }
                else
                {
                    if(OfferEMI.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<OfferEMI>(jsonString, OfferValidationsPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newOfferValidationsPaymentMethod = new OfferValidationsPaymentMethod(data);
                        return newOfferValidationsPaymentMethod;
                    }
                }
                matchedTypes.Add("OfferEMI");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into OfferEMI: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(OfferNB).GetProperty("AdditionalProperties") == null)
                {
                    if(OfferNB.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<OfferNB>(jsonString, OfferValidationsPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newOfferValidationsPaymentMethod = new OfferValidationsPaymentMethod(data);
                        return newOfferValidationsPaymentMethod;
                    }
                }
                else
                {
                    if(OfferNB.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<OfferNB>(jsonString, OfferValidationsPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newOfferValidationsPaymentMethod = new OfferValidationsPaymentMethod(data);
                        return newOfferValidationsPaymentMethod;
                    }
                }
                matchedTypes.Add("OfferNB");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into OfferNB: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(OfferPaylater).GetProperty("AdditionalProperties") == null)
                {
                    if(OfferPaylater.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<OfferPaylater>(jsonString, OfferValidationsPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newOfferValidationsPaymentMethod = new OfferValidationsPaymentMethod(data);
                        return newOfferValidationsPaymentMethod;
                    }
                }
                else
                {
                    if(OfferPaylater.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<OfferPaylater>(jsonString, OfferValidationsPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newOfferValidationsPaymentMethod = new OfferValidationsPaymentMethod(data);
                        return newOfferValidationsPaymentMethod;
                    }
                }
                matchedTypes.Add("OfferPaylater");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into OfferPaylater: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(OfferUPI).GetProperty("AdditionalProperties") == null)
                {
                    if(OfferUPI.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<OfferUPI>(jsonString, OfferValidationsPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newOfferValidationsPaymentMethod = new OfferValidationsPaymentMethod(data);
                        return newOfferValidationsPaymentMethod;
                    }
                }
                else
                {
                    if(OfferUPI.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<OfferUPI>(jsonString, OfferValidationsPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newOfferValidationsPaymentMethod = new OfferValidationsPaymentMethod(data);
                        return newOfferValidationsPaymentMethod;
                    }
                }
                matchedTypes.Add("OfferUPI");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into OfferUPI: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(OfferWallet).GetProperty("AdditionalProperties") == null)
                {
                    if(OfferWallet.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<OfferWallet>(jsonString, OfferValidationsPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newOfferValidationsPaymentMethod = new OfferValidationsPaymentMethod(data);
                        return newOfferValidationsPaymentMethod;
                    }
                }
                else
                {
                    if(OfferWallet.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<OfferWallet>(jsonString, OfferValidationsPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newOfferValidationsPaymentMethod = new OfferValidationsPaymentMethod(data);
                        return newOfferValidationsPaymentMethod;
                    }
                }
                matchedTypes.Add("OfferWallet");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into OfferWallet: {1}", jsonString, exception.ToString()));
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
            return newOfferValidationsPaymentMethod;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as OfferValidationsPaymentMethod);
        }

        /// <summary>
        /// Returns true if OfferValidationsPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of OfferValidationsPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OfferValidationsPaymentMethod input)
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
    /// Custom JSON converter for OfferValidationsPaymentMethod
    /// </summary>
    public class OfferValidationsPaymentMethodJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(OfferValidationsPaymentMethod).GetMethod("ToJson").Invoke(value, null)));
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
                return OfferValidationsPaymentMethod.FromJson(JObject.Load(reader).ToString(Formatting.None));
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

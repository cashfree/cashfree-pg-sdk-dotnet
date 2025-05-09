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
    /// PayOrderRequestPaymentMethod
    /// </summary>
    [JsonConverter(typeof(PayOrderRequestPaymentMethodJsonConverter))]
    [DataContract(Name = "PayOrderRequest_payment_method")]
    public class PayOrderRequestPaymentMethod : AbstractOpenAPISchema, IEquatable<PayOrderRequestPaymentMethod>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PayOrderRequestPaymentMethod" /> class
        /// with the <see cref="CardPaymentMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CardPaymentMethod.</param>
        public PayOrderRequestPaymentMethod(CardPaymentMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayOrderRequestPaymentMethod" /> class
        /// with the <see cref="UPIPaymentMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of UPIPaymentMethod.</param>
        public PayOrderRequestPaymentMethod(UPIPaymentMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayOrderRequestPaymentMethod" /> class
        /// with the <see cref="NetBankingPaymentMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of NetBankingPaymentMethod.</param>
        public PayOrderRequestPaymentMethod(NetBankingPaymentMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayOrderRequestPaymentMethod" /> class
        /// with the <see cref="AppPaymentMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of AppPaymentMethod.</param>
        public PayOrderRequestPaymentMethod(AppPaymentMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayOrderRequestPaymentMethod" /> class
        /// with the <see cref="CardEMIPaymentMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CardEMIPaymentMethod.</param>
        public PayOrderRequestPaymentMethod(CardEMIPaymentMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayOrderRequestPaymentMethod" /> class
        /// with the <see cref="CardlessEMIPaymentMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of CardlessEMIPaymentMethod.</param>
        public PayOrderRequestPaymentMethod(CardlessEMIPaymentMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayOrderRequestPaymentMethod" /> class
        /// with the <see cref="PaylaterPaymentMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of PaylaterPaymentMethod.</param>
        public PayOrderRequestPaymentMethod(PaylaterPaymentMethod actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PayOrderRequestPaymentMethod" /> class
        /// with the <see cref="BanktransferPaymentMethod" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of BanktransferPaymentMethod.</param>
        public PayOrderRequestPaymentMethod(BanktransferPaymentMethod actualInstance)
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
                if (value.GetType() == typeof(AppPaymentMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(BanktransferPaymentMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CardEMIPaymentMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CardPaymentMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(CardlessEMIPaymentMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(NetBankingPaymentMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(PaylaterPaymentMethod))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(UPIPaymentMethod))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: AppPaymentMethod, BanktransferPaymentMethod, CardEMIPaymentMethod, CardPaymentMethod, CardlessEMIPaymentMethod, NetBankingPaymentMethod, PaylaterPaymentMethod, UPIPaymentMethod");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `CardPaymentMethod`. If the actual instance is not `CardPaymentMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CardPaymentMethod</returns>
        public CardPaymentMethod GetCardPaymentMethod()
        {
            return (CardPaymentMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `UPIPaymentMethod`. If the actual instance is not `UPIPaymentMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of UPIPaymentMethod</returns>
        public UPIPaymentMethod GetUPIPaymentMethod()
        {
            return (UPIPaymentMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `NetBankingPaymentMethod`. If the actual instance is not `NetBankingPaymentMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of NetBankingPaymentMethod</returns>
        public NetBankingPaymentMethod GetNetBankingPaymentMethod()
        {
            return (NetBankingPaymentMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `AppPaymentMethod`. If the actual instance is not `AppPaymentMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of AppPaymentMethod</returns>
        public AppPaymentMethod GetAppPaymentMethod()
        {
            return (AppPaymentMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CardEMIPaymentMethod`. If the actual instance is not `CardEMIPaymentMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CardEMIPaymentMethod</returns>
        public CardEMIPaymentMethod GetCardEMIPaymentMethod()
        {
            return (CardEMIPaymentMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `CardlessEMIPaymentMethod`. If the actual instance is not `CardlessEMIPaymentMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of CardlessEMIPaymentMethod</returns>
        public CardlessEMIPaymentMethod GetCardlessEMIPaymentMethod()
        {
            return (CardlessEMIPaymentMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `PaylaterPaymentMethod`. If the actual instance is not `PaylaterPaymentMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of PaylaterPaymentMethod</returns>
        public PaylaterPaymentMethod GetPaylaterPaymentMethod()
        {
            return (PaylaterPaymentMethod)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `BanktransferPaymentMethod`. If the actual instance is not `BanktransferPaymentMethod`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of BanktransferPaymentMethod</returns>
        public BanktransferPaymentMethod GetBanktransferPaymentMethod()
        {
            return (BanktransferPaymentMethod)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PayOrderRequestPaymentMethod {\n");
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
            return JsonConvert.SerializeObject(this.ActualInstance, PayOrderRequestPaymentMethod.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of PayOrderRequestPaymentMethod
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of PayOrderRequestPaymentMethod</returns>
        public static PayOrderRequestPaymentMethod FromJson(string jsonString)
        {
            PayOrderRequestPaymentMethod newPayOrderRequestPaymentMethod = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newPayOrderRequestPaymentMethod;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(AppPaymentMethod).GetProperty("AdditionalProperties") == null)
                {
                    if(AppPaymentMethod.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<AppPaymentMethod>(jsonString, PayOrderRequestPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPayOrderRequestPaymentMethod = new PayOrderRequestPaymentMethod(data);
                        return newPayOrderRequestPaymentMethod;
                    }
                }
                else
                {
                    if(AppPaymentMethod.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<AppPaymentMethod>(jsonString, PayOrderRequestPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPayOrderRequestPaymentMethod = new PayOrderRequestPaymentMethod(data);
                        return newPayOrderRequestPaymentMethod;
                    }
                }
                matchedTypes.Add("AppPaymentMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into AppPaymentMethod: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(BanktransferPaymentMethod).GetProperty("AdditionalProperties") == null)
                {
                    if(BanktransferPaymentMethod.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<BanktransferPaymentMethod>(jsonString, PayOrderRequestPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPayOrderRequestPaymentMethod = new PayOrderRequestPaymentMethod(data);
                        return newPayOrderRequestPaymentMethod;
                    }
                }
                else
                {
                    if(BanktransferPaymentMethod.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<BanktransferPaymentMethod>(jsonString, PayOrderRequestPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPayOrderRequestPaymentMethod = new PayOrderRequestPaymentMethod(data);
                        return newPayOrderRequestPaymentMethod;
                    }
                }
                matchedTypes.Add("BanktransferPaymentMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into BanktransferPaymentMethod: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CardEMIPaymentMethod).GetProperty("AdditionalProperties") == null)
                {
                    if(CardEMIPaymentMethod.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<CardEMIPaymentMethod>(jsonString, PayOrderRequestPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPayOrderRequestPaymentMethod = new PayOrderRequestPaymentMethod(data);
                        return newPayOrderRequestPaymentMethod;
                    }
                }
                else
                {
                    if(CardEMIPaymentMethod.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<CardEMIPaymentMethod>(jsonString, PayOrderRequestPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPayOrderRequestPaymentMethod = new PayOrderRequestPaymentMethod(data);
                        return newPayOrderRequestPaymentMethod;
                    }
                }
                matchedTypes.Add("CardEMIPaymentMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CardEMIPaymentMethod: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CardPaymentMethod).GetProperty("AdditionalProperties") == null)
                {
                    if(CardPaymentMethod.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<CardPaymentMethod>(jsonString, PayOrderRequestPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPayOrderRequestPaymentMethod = new PayOrderRequestPaymentMethod(data);
                        return newPayOrderRequestPaymentMethod;
                    }
                }
                else
                {
                    if(CardPaymentMethod.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<CardPaymentMethod>(jsonString, PayOrderRequestPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPayOrderRequestPaymentMethod = new PayOrderRequestPaymentMethod(data);
                        return newPayOrderRequestPaymentMethod;
                    }
                }
                matchedTypes.Add("CardPaymentMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CardPaymentMethod: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(CardlessEMIPaymentMethod).GetProperty("AdditionalProperties") == null)
                {
                    if(CardlessEMIPaymentMethod.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<CardlessEMIPaymentMethod>(jsonString, PayOrderRequestPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPayOrderRequestPaymentMethod = new PayOrderRequestPaymentMethod(data);
                        return newPayOrderRequestPaymentMethod;
                    }
                }
                else
                {
                    if(CardlessEMIPaymentMethod.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<CardlessEMIPaymentMethod>(jsonString, PayOrderRequestPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPayOrderRequestPaymentMethod = new PayOrderRequestPaymentMethod(data);
                        return newPayOrderRequestPaymentMethod;
                    }
                }
                matchedTypes.Add("CardlessEMIPaymentMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into CardlessEMIPaymentMethod: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(NetBankingPaymentMethod).GetProperty("AdditionalProperties") == null)
                {
                    if(NetBankingPaymentMethod.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<NetBankingPaymentMethod>(jsonString, PayOrderRequestPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPayOrderRequestPaymentMethod = new PayOrderRequestPaymentMethod(data);
                        return newPayOrderRequestPaymentMethod;
                    }
                }
                else
                {
                    if(NetBankingPaymentMethod.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<NetBankingPaymentMethod>(jsonString, PayOrderRequestPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPayOrderRequestPaymentMethod = new PayOrderRequestPaymentMethod(data);
                        return newPayOrderRequestPaymentMethod;
                    }
                }
                matchedTypes.Add("NetBankingPaymentMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into NetBankingPaymentMethod: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(PaylaterPaymentMethod).GetProperty("AdditionalProperties") == null)
                {
                    if(PaylaterPaymentMethod.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<PaylaterPaymentMethod>(jsonString, PayOrderRequestPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPayOrderRequestPaymentMethod = new PayOrderRequestPaymentMethod(data);
                        return newPayOrderRequestPaymentMethod;
                    }
                }
                else
                {
                    if(PaylaterPaymentMethod.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<PaylaterPaymentMethod>(jsonString, PayOrderRequestPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPayOrderRequestPaymentMethod = new PayOrderRequestPaymentMethod(data);
                        return newPayOrderRequestPaymentMethod;
                    }
                }
                matchedTypes.Add("PaylaterPaymentMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into PaylaterPaymentMethod: {1}", jsonString, exception.ToString()));
            }
            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(UPIPaymentMethod).GetProperty("AdditionalProperties") == null)
                {
                    if(UPIPaymentMethod.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<UPIPaymentMethod>(jsonString, PayOrderRequestPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPayOrderRequestPaymentMethod = new PayOrderRequestPaymentMethod(data);
                        return newPayOrderRequestPaymentMethod;
                    }
                }
                else
                {
                    if(UPIPaymentMethod.checkPresenceOfKey(jsonString)) {
                        dynamic data = JsonConvert.DeserializeObject<UPIPaymentMethod>(jsonString, PayOrderRequestPaymentMethod.AdditionalPropertiesSerializerSettings);
                        newPayOrderRequestPaymentMethod = new PayOrderRequestPaymentMethod(data);
                        return newPayOrderRequestPaymentMethod;
                    }
                }
                matchedTypes.Add("UPIPaymentMethod");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into UPIPaymentMethod: {1}", jsonString, exception.ToString()));
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
            return newPayOrderRequestPaymentMethod;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as PayOrderRequestPaymentMethod);
        }

        /// <summary>
        /// Returns true if PayOrderRequestPaymentMethod instances are equal
        /// </summary>
        /// <param name="input">Instance of PayOrderRequestPaymentMethod to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PayOrderRequestPaymentMethod input)
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
    /// Custom JSON converter for PayOrderRequestPaymentMethod
    /// </summary>
    public class PayOrderRequestPaymentMethodJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(PayOrderRequestPaymentMethod).GetMethod("ToJson").Invoke(value, null)));
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
                return PayOrderRequestPaymentMethod.FromJson(JObject.Load(reader).ToString(Formatting.None));
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

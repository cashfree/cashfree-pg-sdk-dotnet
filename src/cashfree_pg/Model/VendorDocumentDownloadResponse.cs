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
    /// Download Vendor Document
    /// </summary>
    [DataContract(Name = "VendorDocumentDownloadResponse")]
    public class VendorDocumentDownloadResponse : IEquatable<VendorDocumentDownloadResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorDocumentDownloadResponse" /> class.
        /// </summary>
        /// <param name="downloadUrl">downloadUrl.</param>
        public VendorDocumentDownloadResponse(string downloadUrl = default(string))
        {
            this.download_url = downloadUrl;
        }

        /// <summary>
        /// Gets or Sets download_url
        /// </summary>
        [DataMember(Name = "download_url", EmitDefaultValue = false)]
        public string download_url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VendorDocumentDownloadResponse {\n");
            sb.Append("  download_url: ").Append(download_url).Append("\n");
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
            return this.Equals(input as VendorDocumentDownloadResponse);
        }

        /// <summary>
        /// Returns true if VendorDocumentDownloadResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of VendorDocumentDownloadResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VendorDocumentDownloadResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.download_url == input.download_url ||
                    (this.download_url != null &&
                    this.download_url.Equals(input.download_url))
                );
        }

        public static Boolean checkPresenceOfKey(string jsonStringdownload_url) {
            dynamic deserializedJsonString = JsonConvert.DeserializeObject<dynamic>(jsonStringdownload_url);
            if (deserializedJsonString.ContainsKey("download_url")) {
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
                if (this.download_url != null)
                {
                    hashCode = (hashCode * 59) + this.download_url.GetHashCode();
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

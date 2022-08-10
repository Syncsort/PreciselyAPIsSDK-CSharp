/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 12.0.0
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = com.precisely.apis.Client.OpenAPIDateConverter;

namespace com.precisely.apis.Model
{
    /// <summary>
    /// AddressesPreferences
    /// </summary>
    [DataContract]
    public partial class AddressesPreferences :  IEquatable<AddressesPreferences>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressesPreferences" /> class.
        /// </summary>
        /// <param name="maxCandidates">maxCandidates.</param>
        /// <param name="page">page.</param>
        public AddressesPreferences(string maxCandidates = default(string), string page = default(string))
        {
            this.MaxCandidates = maxCandidates;
            this.Page = page;
        }

        /// <summary>
        /// Gets or Sets MaxCandidates
        /// </summary>
        [DataMember(Name="maxCandidates", EmitDefaultValue=false)]
        public string MaxCandidates { get; set; }

        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public string Page { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressesPreferences {\n");
            sb.Append("  MaxCandidates: ").Append(MaxCandidates).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
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
            return this.Equals(input as AddressesPreferences);
        }

        /// <summary>
        /// Returns true if AddressesPreferences instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressesPreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressesPreferences input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.MaxCandidates == input.MaxCandidates ||
                    (this.MaxCandidates != null &&
                    this.MaxCandidates.Equals(input.MaxCandidates))
                ) && 
                (
                    this.Page == input.Page ||
                    (this.Page != null &&
                    this.Page.Equals(input.Page))
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
                if (this.MaxCandidates != null)
                    hashCode = hashCode * 59 + this.MaxCandidates.GetHashCode();
                if (this.Page != null)
                    hashCode = hashCode * 59 + this.Page.GetHashCode();
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

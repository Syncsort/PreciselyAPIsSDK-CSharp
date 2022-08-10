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
    /// POIBoundaryPreferences
    /// </summary>
    [DataContract]
    public partial class POIBoundaryPreferences :  IEquatable<POIBoundaryPreferences>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="POIBoundaryPreferences" /> class.
        /// </summary>
        /// <param name="categoryCode">categoryCode.</param>
        /// <param name="sicCode">sicCode.</param>
        /// <param name="naicsCode">naicsCode.</param>
        public POIBoundaryPreferences(string categoryCode = default(string), string sicCode = default(string), string naicsCode = default(string))
        {
            this.CategoryCode = categoryCode;
            this.SicCode = sicCode;
            this.NaicsCode = naicsCode;
        }

        /// <summary>
        /// Gets or Sets CategoryCode
        /// </summary>
        [DataMember(Name="categoryCode", EmitDefaultValue=false)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// Gets or Sets SicCode
        /// </summary>
        [DataMember(Name="sicCode", EmitDefaultValue=false)]
        public string SicCode { get; set; }

        /// <summary>
        /// Gets or Sets NaicsCode
        /// </summary>
        [DataMember(Name="naicsCode", EmitDefaultValue=false)]
        public string NaicsCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class POIBoundaryPreferences {\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  SicCode: ").Append(SicCode).Append("\n");
            sb.Append("  NaicsCode: ").Append(NaicsCode).Append("\n");
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
            return this.Equals(input as POIBoundaryPreferences);
        }

        /// <summary>
        /// Returns true if POIBoundaryPreferences instances are equal
        /// </summary>
        /// <param name="input">Instance of POIBoundaryPreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(POIBoundaryPreferences input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CategoryCode == input.CategoryCode ||
                    (this.CategoryCode != null &&
                    this.CategoryCode.Equals(input.CategoryCode))
                ) && 
                (
                    this.SicCode == input.SicCode ||
                    (this.SicCode != null &&
                    this.SicCode.Equals(input.SicCode))
                ) && 
                (
                    this.NaicsCode == input.NaicsCode ||
                    (this.NaicsCode != null &&
                    this.NaicsCode.Equals(input.NaicsCode))
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
                if (this.CategoryCode != null)
                    hashCode = hashCode * 59 + this.CategoryCode.GetHashCode();
                if (this.SicCode != null)
                    hashCode = hashCode * 59 + this.SicCode.GetHashCode();
                if (this.NaicsCode != null)
                    hashCode = hashCode * 59 + this.NaicsCode.GetHashCode();
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

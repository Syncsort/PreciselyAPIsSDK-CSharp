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
    /// BuildgFeaturesSqft
    /// </summary>
    [DataContract]
    public partial class BuildgFeaturesSqft :  IEquatable<BuildgFeaturesSqft>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildgFeaturesSqft" /> class.
        /// </summary>
        /// <param name="featureAreaSqFt">featureAreaSqFt.</param>
        /// <param name="areaIndicator">areaIndicator.</param>
        /// <param name="description">description.</param>
        public BuildgFeaturesSqft(string featureAreaSqFt = default(string), string areaIndicator = default(string), string description = default(string))
        {
            this.FeatureAreaSqFt = featureAreaSqFt;
            this.AreaIndicator = areaIndicator;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets FeatureAreaSqFt
        /// </summary>
        [DataMember(Name="featureAreaSqFt", EmitDefaultValue=false)]
        public string FeatureAreaSqFt { get; set; }

        /// <summary>
        /// Gets or Sets AreaIndicator
        /// </summary>
        [DataMember(Name="areaIndicator", EmitDefaultValue=false)]
        public string AreaIndicator { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BuildgFeaturesSqft {\n");
            sb.Append("  FeatureAreaSqFt: ").Append(FeatureAreaSqFt).Append("\n");
            sb.Append("  AreaIndicator: ").Append(AreaIndicator).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
            return this.Equals(input as BuildgFeaturesSqft);
        }

        /// <summary>
        /// Returns true if BuildgFeaturesSqft instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildgFeaturesSqft to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildgFeaturesSqft input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FeatureAreaSqFt == input.FeatureAreaSqFt ||
                    (this.FeatureAreaSqFt != null &&
                    this.FeatureAreaSqFt.Equals(input.FeatureAreaSqFt))
                ) && 
                (
                    this.AreaIndicator == input.AreaIndicator ||
                    (this.AreaIndicator != null &&
                    this.AreaIndicator.Equals(input.AreaIndicator))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.FeatureAreaSqFt != null)
                    hashCode = hashCode * 59 + this.FeatureAreaSqFt.GetHashCode();
                if (this.AreaIndicator != null)
                    hashCode = hashCode * 59 + this.AreaIndicator.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
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

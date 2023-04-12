/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 15.0.0
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
    /// BuildgImproveArea
    /// </summary>
    [DataContract]
    public partial class BuildgImproveArea :  IEquatable<BuildgImproveArea>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuildgImproveArea" /> class.
        /// </summary>
        /// <param name="improveArea">improveArea.</param>
        /// <param name="areaIndicator">areaIndicator.</param>
        /// <param name="description">description.</param>
        public BuildgImproveArea(string improveArea = default(string), string areaIndicator = default(string), string description = default(string))
        {
            this.ImproveArea = improveArea;
            this.AreaIndicator = areaIndicator;
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets ImproveArea
        /// </summary>
        [DataMember(Name="improveArea", EmitDefaultValue=false)]
        public string ImproveArea { get; set; }

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
            sb.Append("class BuildgImproveArea {\n");
            sb.Append("  ImproveArea: ").Append(ImproveArea).Append("\n");
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
            return this.Equals(input as BuildgImproveArea);
        }

        /// <summary>
        /// Returns true if BuildgImproveArea instances are equal
        /// </summary>
        /// <param name="input">Instance of BuildgImproveArea to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuildgImproveArea input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ImproveArea == input.ImproveArea ||
                    (this.ImproveArea != null &&
                    this.ImproveArea.Equals(input.ImproveArea))
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
                if (this.ImproveArea != null)
                    hashCode = hashCode * 59 + this.ImproveArea.GetHashCode();
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

/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 12.0.1
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
    /// DemographicsAdvancedRequest
    /// </summary>
    [DataContract]
    public partial class DemographicsAdvancedRequest :  IEquatable<DemographicsAdvancedRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DemographicsAdvancedRequest" /> class.
        /// </summary>
        /// <param name="preferences">preferences.</param>
        /// <param name="geometry">geometry.</param>
        /// <param name="geometryAsText">geometryAsText.</param>
        public DemographicsAdvancedRequest(DemographicsAdvancedPreferences preferences = default(DemographicsAdvancedPreferences), DemographicsGeometry geometry = default(DemographicsGeometry), string geometryAsText = default(string))
        {
            this.Preferences = preferences;
            this.Geometry = geometry;
            this.GeometryAsText = geometryAsText;
        }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name="preferences", EmitDefaultValue=false)]
        public DemographicsAdvancedPreferences Preferences { get; set; }

        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public DemographicsGeometry Geometry { get; set; }

        /// <summary>
        /// Gets or Sets GeometryAsText
        /// </summary>
        [DataMember(Name="geometryAsText", EmitDefaultValue=false)]
        public string GeometryAsText { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DemographicsAdvancedRequest {\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  GeometryAsText: ").Append(GeometryAsText).Append("\n");
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
            return this.Equals(input as DemographicsAdvancedRequest);
        }

        /// <summary>
        /// Returns true if DemographicsAdvancedRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of DemographicsAdvancedRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DemographicsAdvancedRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Preferences == input.Preferences ||
                    (this.Preferences != null &&
                    this.Preferences.Equals(input.Preferences))
                ) && 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
                ) && 
                (
                    this.GeometryAsText == input.GeometryAsText ||
                    (this.GeometryAsText != null &&
                    this.GeometryAsText.Equals(input.GeometryAsText))
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
                if (this.Preferences != null)
                    hashCode = hashCode * 59 + this.Preferences.GetHashCode();
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.GeometryAsText != null)
                    hashCode = hashCode * 59 + this.GeometryAsText.GetHashCode();
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

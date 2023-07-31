/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 16.0.1
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
    /// RouteResponse
    /// </summary>
    [DataContract]
    public partial class RouteResponse :  IEquatable<RouteResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteResponse" /> class.
        /// </summary>
        /// <param name="directionsStyle">directionsStyle.</param>
        /// <param name="distance">distance.</param>
        /// <param name="distanceUnit">distanceUnit.</param>
        /// <param name="language">language.</param>
        /// <param name="timeUnit">timeUnit.</param>
        /// <param name="time">time.</param>
        /// <param name="geometry">geometry.</param>
        /// <param name="routeDirections">routeDirections.</param>
        /// <param name="intermediatePoints">intermediatePoints.</param>
        public RouteResponse(string directionsStyle = default(string), decimal distance = default(decimal), string distanceUnit = default(string), string language = default(string), string timeUnit = default(string), decimal time = default(decimal), RouteGeometry geometry = default(RouteGeometry), List<RouteDirection> routeDirections = default(List<RouteDirection>), IntermediatePoints intermediatePoints = default(IntermediatePoints))
        {
            this.DirectionsStyle = directionsStyle;
            this.Distance = distance;
            this.DistanceUnit = distanceUnit;
            this.Language = language;
            this.TimeUnit = timeUnit;
            this.Time = time;
            this.Geometry = geometry;
            this.RouteDirections = routeDirections;
            this.IntermediatePoints = intermediatePoints;
        }

        /// <summary>
        /// Gets or Sets DirectionsStyle
        /// </summary>
        [DataMember(Name="directionsStyle", EmitDefaultValue=false)]
        public string DirectionsStyle { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public decimal Distance { get; set; }

        /// <summary>
        /// Gets or Sets DistanceUnit
        /// </summary>
        [DataMember(Name="distanceUnit", EmitDefaultValue=false)]
        public string DistanceUnit { get; set; }

        /// <summary>
        /// Gets or Sets Language
        /// </summary>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Gets or Sets TimeUnit
        /// </summary>
        [DataMember(Name="timeUnit", EmitDefaultValue=false)]
        public string TimeUnit { get; set; }

        /// <summary>
        /// Gets or Sets Time
        /// </summary>
        [DataMember(Name="time", EmitDefaultValue=false)]
        public decimal Time { get; set; }

        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public RouteGeometry Geometry { get; set; }

        /// <summary>
        /// Gets or Sets RouteDirections
        /// </summary>
        [DataMember(Name="routeDirections", EmitDefaultValue=false)]
        public List<RouteDirection> RouteDirections { get; set; }

        /// <summary>
        /// Gets or Sets IntermediatePoints
        /// </summary>
        [DataMember(Name="intermediatePoints", EmitDefaultValue=false)]
        public IntermediatePoints IntermediatePoints { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RouteResponse {\n");
            sb.Append("  DirectionsStyle: ").Append(DirectionsStyle).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  DistanceUnit: ").Append(DistanceUnit).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  TimeUnit: ").Append(TimeUnit).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  RouteDirections: ").Append(RouteDirections).Append("\n");
            sb.Append("  IntermediatePoints: ").Append(IntermediatePoints).Append("\n");
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
            return this.Equals(input as RouteResponse);
        }

        /// <summary>
        /// Returns true if RouteResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RouteResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RouteResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DirectionsStyle == input.DirectionsStyle ||
                    (this.DirectionsStyle != null &&
                    this.DirectionsStyle.Equals(input.DirectionsStyle))
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.DistanceUnit == input.DistanceUnit ||
                    (this.DistanceUnit != null &&
                    this.DistanceUnit.Equals(input.DistanceUnit))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.TimeUnit == input.TimeUnit ||
                    (this.TimeUnit != null &&
                    this.TimeUnit.Equals(input.TimeUnit))
                ) && 
                (
                    this.Time == input.Time ||
                    (this.Time != null &&
                    this.Time.Equals(input.Time))
                ) && 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
                ) && 
                (
                    this.RouteDirections == input.RouteDirections ||
                    this.RouteDirections != null &&
                    input.RouteDirections != null &&
                    this.RouteDirections.SequenceEqual(input.RouteDirections)
                ) && 
                (
                    this.IntermediatePoints == input.IntermediatePoints ||
                    (this.IntermediatePoints != null &&
                    this.IntermediatePoints.Equals(input.IntermediatePoints))
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
                if (this.DirectionsStyle != null)
                    hashCode = hashCode * 59 + this.DirectionsStyle.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.DistanceUnit != null)
                    hashCode = hashCode * 59 + this.DistanceUnit.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.TimeUnit != null)
                    hashCode = hashCode * 59 + this.TimeUnit.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.RouteDirections != null)
                    hashCode = hashCode * 59 + this.RouteDirections.GetHashCode();
                if (this.IntermediatePoints != null)
                    hashCode = hashCode * 59 + this.IntermediatePoints.GetHashCode();
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

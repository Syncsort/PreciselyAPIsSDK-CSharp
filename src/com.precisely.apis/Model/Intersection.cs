/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 18.1.0
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
    /// Intersection
    /// </summary>
    [DataContract]
    public partial class Intersection :  IEquatable<Intersection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Intersection" /> class.
        /// </summary>
        /// <param name="distance">distance.</param>
        /// <param name="driveTime">driveTime.</param>
        /// <param name="driveDistance">driveDistance.</param>
        /// <param name="geometry">geometry.</param>
        /// <param name="roads">roads.</param>
        public Intersection(Unit distance = default(Unit), Unit driveTime = default(Unit), Unit driveDistance = default(Unit), Geometry geometry = default(Geometry), List<Road> roads = default(List<Road>))
        {
            this.Distance = distance;
            this.DriveTime = driveTime;
            this.DriveDistance = driveDistance;
            this.Geometry = geometry;
            this.Roads = roads;
        }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public Unit Distance { get; set; }

        /// <summary>
        /// Gets or Sets DriveTime
        /// </summary>
        [DataMember(Name="driveTime", EmitDefaultValue=false)]
        public Unit DriveTime { get; set; }

        /// <summary>
        /// Gets or Sets DriveDistance
        /// </summary>
        [DataMember(Name="driveDistance", EmitDefaultValue=false)]
        public Unit DriveDistance { get; set; }

        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public Geometry Geometry { get; set; }

        /// <summary>
        /// Gets or Sets Roads
        /// </summary>
        [DataMember(Name="roads", EmitDefaultValue=false)]
        public List<Road> Roads { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Intersection {\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  DriveTime: ").Append(DriveTime).Append("\n");
            sb.Append("  DriveDistance: ").Append(DriveDistance).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  Roads: ").Append(Roads).Append("\n");
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
            return this.Equals(input as Intersection);
        }

        /// <summary>
        /// Returns true if Intersection instances are equal
        /// </summary>
        /// <param name="input">Instance of Intersection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Intersection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.DriveTime == input.DriveTime ||
                    (this.DriveTime != null &&
                    this.DriveTime.Equals(input.DriveTime))
                ) && 
                (
                    this.DriveDistance == input.DriveDistance ||
                    (this.DriveDistance != null &&
                    this.DriveDistance.Equals(input.DriveDistance))
                ) && 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
                ) && 
                (
                    this.Roads == input.Roads ||
                    this.Roads != null &&
                    input.Roads != null &&
                    this.Roads.SequenceEqual(input.Roads)
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
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.DriveTime != null)
                    hashCode = hashCode * 59 + this.DriveTime.GetHashCode();
                if (this.DriveDistance != null)
                    hashCode = hashCode * 59 + this.DriveDistance.GetHashCode();
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.Roads != null)
                    hashCode = hashCode * 59 + this.Roads.GetHashCode();
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

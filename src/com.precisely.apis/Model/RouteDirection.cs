/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 17.1.0
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
    /// RouteDirection
    /// </summary>
    [DataContract]
    public partial class RouteDirection :  IEquatable<RouteDirection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RouteDirection" /> class.
        /// </summary>
        /// <param name="distance">distance.</param>
        /// <param name="distanceUnit">distanceUnit.</param>
        /// <param name="timeUnit">timeUnit.</param>
        /// <param name="time">time.</param>
        /// <param name="instruction">instruction.</param>
        /// <param name="directionGeometry">directionGeometry.</param>
        public RouteDirection(decimal distance = default(decimal), string distanceUnit = default(string), string timeUnit = default(string), decimal time = default(decimal), string instruction = default(string), RouteGeometry directionGeometry = default(RouteGeometry))
        {
            this.Distance = distance;
            this.DistanceUnit = distanceUnit;
            this.TimeUnit = timeUnit;
            this.Time = time;
            this.Instruction = instruction;
            this.DirectionGeometry = directionGeometry;
        }

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
        /// Gets or Sets Instruction
        /// </summary>
        [DataMember(Name="instruction", EmitDefaultValue=false)]
        public string Instruction { get; set; }

        /// <summary>
        /// Gets or Sets DirectionGeometry
        /// </summary>
        [DataMember(Name="directionGeometry", EmitDefaultValue=false)]
        public RouteGeometry DirectionGeometry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RouteDirection {\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  DistanceUnit: ").Append(DistanceUnit).Append("\n");
            sb.Append("  TimeUnit: ").Append(TimeUnit).Append("\n");
            sb.Append("  Time: ").Append(Time).Append("\n");
            sb.Append("  Instruction: ").Append(Instruction).Append("\n");
            sb.Append("  DirectionGeometry: ").Append(DirectionGeometry).Append("\n");
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
            return this.Equals(input as RouteDirection);
        }

        /// <summary>
        /// Returns true if RouteDirection instances are equal
        /// </summary>
        /// <param name="input">Instance of RouteDirection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RouteDirection input)
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
                    this.DistanceUnit == input.DistanceUnit ||
                    (this.DistanceUnit != null &&
                    this.DistanceUnit.Equals(input.DistanceUnit))
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
                    this.Instruction == input.Instruction ||
                    (this.Instruction != null &&
                    this.Instruction.Equals(input.Instruction))
                ) && 
                (
                    this.DirectionGeometry == input.DirectionGeometry ||
                    (this.DirectionGeometry != null &&
                    this.DirectionGeometry.Equals(input.DirectionGeometry))
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
                if (this.DistanceUnit != null)
                    hashCode = hashCode * 59 + this.DistanceUnit.GetHashCode();
                if (this.TimeUnit != null)
                    hashCode = hashCode * 59 + this.TimeUnit.GetHashCode();
                if (this.Time != null)
                    hashCode = hashCode * 59 + this.Time.GetHashCode();
                if (this.Instruction != null)
                    hashCode = hashCode * 59 + this.Instruction.GetHashCode();
                if (this.DirectionGeometry != null)
                    hashCode = hashCode * 59 + this.DirectionGeometry.GetHashCode();
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

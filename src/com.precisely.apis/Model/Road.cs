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
    /// Road
    /// </summary>
    [DataContract]
    public partial class Road :  IEquatable<Road>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Road" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="altName">altName.</param>
        /// <param name="roadClass">roadClass.</param>
        /// <param name="type">type.</param>
        /// <param name="lengthInMeters">lengthInMeters.</param>
        /// <param name="routeNumber">routeNumber.</param>
        /// <param name="surfaceType">surfaceType.</param>
        /// <param name="trafficFlow">trafficFlow.</param>
        /// <param name="isToll">isToll.</param>
        /// <param name="beginningLevel">beginningLevel.</param>
        /// <param name="endingLevel">endingLevel.</param>
        public Road(string id = default(string), string name = default(string), string altName = default(string), string roadClass = default(string), string type = default(string), string lengthInMeters = default(string), string routeNumber = default(string), string surfaceType = default(string), string trafficFlow = default(string), string isToll = default(string), string beginningLevel = default(string), string endingLevel = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.AltName = altName;
            this.RoadClass = roadClass;
            this.Type = type;
            this.LengthInMeters = lengthInMeters;
            this.RouteNumber = routeNumber;
            this.SurfaceType = surfaceType;
            this.TrafficFlow = trafficFlow;
            this.IsToll = isToll;
            this.BeginningLevel = beginningLevel;
            this.EndingLevel = endingLevel;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets AltName
        /// </summary>
        [DataMember(Name="altName", EmitDefaultValue=false)]
        public string AltName { get; set; }

        /// <summary>
        /// Gets or Sets RoadClass
        /// </summary>
        [DataMember(Name="roadClass", EmitDefaultValue=false)]
        public string RoadClass { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets LengthInMeters
        /// </summary>
        [DataMember(Name="lengthInMeters", EmitDefaultValue=false)]
        public string LengthInMeters { get; set; }

        /// <summary>
        /// Gets or Sets RouteNumber
        /// </summary>
        [DataMember(Name="routeNumber", EmitDefaultValue=false)]
        public string RouteNumber { get; set; }

        /// <summary>
        /// Gets or Sets SurfaceType
        /// </summary>
        [DataMember(Name="surfaceType", EmitDefaultValue=false)]
        public string SurfaceType { get; set; }

        /// <summary>
        /// Gets or Sets TrafficFlow
        /// </summary>
        [DataMember(Name="trafficFlow", EmitDefaultValue=false)]
        public string TrafficFlow { get; set; }

        /// <summary>
        /// Gets or Sets IsToll
        /// </summary>
        [DataMember(Name="isToll", EmitDefaultValue=false)]
        public string IsToll { get; set; }

        /// <summary>
        /// Gets or Sets BeginningLevel
        /// </summary>
        [DataMember(Name="beginningLevel", EmitDefaultValue=false)]
        public string BeginningLevel { get; set; }

        /// <summary>
        /// Gets or Sets EndingLevel
        /// </summary>
        [DataMember(Name="endingLevel", EmitDefaultValue=false)]
        public string EndingLevel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Road {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AltName: ").Append(AltName).Append("\n");
            sb.Append("  RoadClass: ").Append(RoadClass).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  LengthInMeters: ").Append(LengthInMeters).Append("\n");
            sb.Append("  RouteNumber: ").Append(RouteNumber).Append("\n");
            sb.Append("  SurfaceType: ").Append(SurfaceType).Append("\n");
            sb.Append("  TrafficFlow: ").Append(TrafficFlow).Append("\n");
            sb.Append("  IsToll: ").Append(IsToll).Append("\n");
            sb.Append("  BeginningLevel: ").Append(BeginningLevel).Append("\n");
            sb.Append("  EndingLevel: ").Append(EndingLevel).Append("\n");
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
            return this.Equals(input as Road);
        }

        /// <summary>
        /// Returns true if Road instances are equal
        /// </summary>
        /// <param name="input">Instance of Road to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Road input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.AltName == input.AltName ||
                    (this.AltName != null &&
                    this.AltName.Equals(input.AltName))
                ) && 
                (
                    this.RoadClass == input.RoadClass ||
                    (this.RoadClass != null &&
                    this.RoadClass.Equals(input.RoadClass))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.LengthInMeters == input.LengthInMeters ||
                    (this.LengthInMeters != null &&
                    this.LengthInMeters.Equals(input.LengthInMeters))
                ) && 
                (
                    this.RouteNumber == input.RouteNumber ||
                    (this.RouteNumber != null &&
                    this.RouteNumber.Equals(input.RouteNumber))
                ) && 
                (
                    this.SurfaceType == input.SurfaceType ||
                    (this.SurfaceType != null &&
                    this.SurfaceType.Equals(input.SurfaceType))
                ) && 
                (
                    this.TrafficFlow == input.TrafficFlow ||
                    (this.TrafficFlow != null &&
                    this.TrafficFlow.Equals(input.TrafficFlow))
                ) && 
                (
                    this.IsToll == input.IsToll ||
                    (this.IsToll != null &&
                    this.IsToll.Equals(input.IsToll))
                ) && 
                (
                    this.BeginningLevel == input.BeginningLevel ||
                    (this.BeginningLevel != null &&
                    this.BeginningLevel.Equals(input.BeginningLevel))
                ) && 
                (
                    this.EndingLevel == input.EndingLevel ||
                    (this.EndingLevel != null &&
                    this.EndingLevel.Equals(input.EndingLevel))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.AltName != null)
                    hashCode = hashCode * 59 + this.AltName.GetHashCode();
                if (this.RoadClass != null)
                    hashCode = hashCode * 59 + this.RoadClass.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.LengthInMeters != null)
                    hashCode = hashCode * 59 + this.LengthInMeters.GetHashCode();
                if (this.RouteNumber != null)
                    hashCode = hashCode * 59 + this.RouteNumber.GetHashCode();
                if (this.SurfaceType != null)
                    hashCode = hashCode * 59 + this.SurfaceType.GetHashCode();
                if (this.TrafficFlow != null)
                    hashCode = hashCode * 59 + this.TrafficFlow.GetHashCode();
                if (this.IsToll != null)
                    hashCode = hashCode * 59 + this.IsToll.GetHashCode();
                if (this.BeginningLevel != null)
                    hashCode = hashCode * 59 + this.BeginningLevel.GetHashCode();
                if (this.EndingLevel != null)
                    hashCode = hashCode * 59 + this.EndingLevel.GetHashCode();
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

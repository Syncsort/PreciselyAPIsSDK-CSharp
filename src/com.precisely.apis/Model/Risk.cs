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
    /// Risk
    /// </summary>
    [DataContract]
    public partial class Risk :  IEquatable<Risk>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Risk" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="description">description.</param>
        /// <param name="risk50Rating">risk50Rating.</param>
        /// <param name="frequency">frequency.</param>
        /// <param name="nonburn">nonburn.</param>
        /// <param name="pastFires">pastFires.</param>
        /// <param name="severity">severity.</param>
        /// <param name="continuity">continuity.</param>
        /// <param name="adjustment">adjustment.</param>
        /// <param name="aspect">aspect.</param>
        /// <param name="crownFire">crownFire.</param>
        /// <param name="vegetation">vegetation.</param>
        /// <param name="foehn">foehn.</param>
        /// <param name="golfCourse">golfCourse.</param>
        /// <param name="roadDist">roadDist.</param>
        /// <param name="slope">slope.</param>
        /// <param name="waterDist">waterDist.</param>
        /// <param name="tier">tier.</param>
        /// <param name="tierDescription">tierDescription.</param>
        /// <param name="distanceToFireStation">distanceToFireStation.</param>
        public Risk(string type = default(string), string description = default(string), int risk50Rating = default(int), int frequency = default(int), string nonburn = default(string), int pastFires = default(int), int severity = default(int), string continuity = default(string), string adjustment = default(string), string aspect = default(string), string crownFire = default(string), string vegetation = default(string), string foehn = default(string), string golfCourse = default(string), string roadDist = default(string), string slope = default(string), string waterDist = default(string), string tier = default(string), string tierDescription = default(string), int distanceToFireStation = default(int))
        {
            this.Type = type;
            this.Description = description;
            this.Risk50Rating = risk50Rating;
            this.Frequency = frequency;
            this.Nonburn = nonburn;
            this.PastFires = pastFires;
            this.Severity = severity;
            this.Continuity = continuity;
            this.Adjustment = adjustment;
            this.Aspect = aspect;
            this.CrownFire = crownFire;
            this.Vegetation = vegetation;
            this.Foehn = foehn;
            this.GolfCourse = golfCourse;
            this.RoadDist = roadDist;
            this.Slope = slope;
            this.WaterDist = waterDist;
            this.Tier = tier;
            this.TierDescription = tierDescription;
            this.DistanceToFireStation = distanceToFireStation;
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Risk50Rating
        /// </summary>
        [DataMember(Name="risk50Rating", EmitDefaultValue=false)]
        public int Risk50Rating { get; set; }

        /// <summary>
        /// Gets or Sets Frequency
        /// </summary>
        [DataMember(Name="frequency", EmitDefaultValue=false)]
        public int Frequency { get; set; }

        /// <summary>
        /// Gets or Sets Nonburn
        /// </summary>
        [DataMember(Name="nonburn", EmitDefaultValue=false)]
        public string Nonburn { get; set; }

        /// <summary>
        /// Gets or Sets PastFires
        /// </summary>
        [DataMember(Name="pastFires", EmitDefaultValue=false)]
        public int PastFires { get; set; }

        /// <summary>
        /// Gets or Sets Severity
        /// </summary>
        [DataMember(Name="severity", EmitDefaultValue=false)]
        public int Severity { get; set; }

        /// <summary>
        /// Gets or Sets Continuity
        /// </summary>
        [DataMember(Name="continuity", EmitDefaultValue=false)]
        public string Continuity { get; set; }

        /// <summary>
        /// Gets or Sets Adjustment
        /// </summary>
        [DataMember(Name="adjustment", EmitDefaultValue=false)]
        public string Adjustment { get; set; }

        /// <summary>
        /// Gets or Sets Aspect
        /// </summary>
        [DataMember(Name="aspect", EmitDefaultValue=false)]
        public string Aspect { get; set; }

        /// <summary>
        /// Gets or Sets CrownFire
        /// </summary>
        [DataMember(Name="crownFire", EmitDefaultValue=false)]
        public string CrownFire { get; set; }

        /// <summary>
        /// Gets or Sets Vegetation
        /// </summary>
        [DataMember(Name="vegetation", EmitDefaultValue=false)]
        public string Vegetation { get; set; }

        /// <summary>
        /// Gets or Sets Foehn
        /// </summary>
        [DataMember(Name="foehn", EmitDefaultValue=false)]
        public string Foehn { get; set; }

        /// <summary>
        /// Gets or Sets GolfCourse
        /// </summary>
        [DataMember(Name="golfCourse", EmitDefaultValue=false)]
        public string GolfCourse { get; set; }

        /// <summary>
        /// Gets or Sets RoadDist
        /// </summary>
        [DataMember(Name="roadDist", EmitDefaultValue=false)]
        public string RoadDist { get; set; }

        /// <summary>
        /// Gets or Sets Slope
        /// </summary>
        [DataMember(Name="slope", EmitDefaultValue=false)]
        public string Slope { get; set; }

        /// <summary>
        /// Gets or Sets WaterDist
        /// </summary>
        [DataMember(Name="waterDist", EmitDefaultValue=false)]
        public string WaterDist { get; set; }

        /// <summary>
        /// Gets or Sets Tier
        /// </summary>
        [DataMember(Name="tier", EmitDefaultValue=false)]
        public string Tier { get; set; }

        /// <summary>
        /// Gets or Sets TierDescription
        /// </summary>
        [DataMember(Name="tierDescription", EmitDefaultValue=false)]
        public string TierDescription { get; set; }

        /// <summary>
        /// Gets or Sets DistanceToFireStation
        /// </summary>
        [DataMember(Name="distanceToFireStation", EmitDefaultValue=false)]
        public int DistanceToFireStation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Risk {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Risk50Rating: ").Append(Risk50Rating).Append("\n");
            sb.Append("  Frequency: ").Append(Frequency).Append("\n");
            sb.Append("  Nonburn: ").Append(Nonburn).Append("\n");
            sb.Append("  PastFires: ").Append(PastFires).Append("\n");
            sb.Append("  Severity: ").Append(Severity).Append("\n");
            sb.Append("  Continuity: ").Append(Continuity).Append("\n");
            sb.Append("  Adjustment: ").Append(Adjustment).Append("\n");
            sb.Append("  Aspect: ").Append(Aspect).Append("\n");
            sb.Append("  CrownFire: ").Append(CrownFire).Append("\n");
            sb.Append("  Vegetation: ").Append(Vegetation).Append("\n");
            sb.Append("  Foehn: ").Append(Foehn).Append("\n");
            sb.Append("  GolfCourse: ").Append(GolfCourse).Append("\n");
            sb.Append("  RoadDist: ").Append(RoadDist).Append("\n");
            sb.Append("  Slope: ").Append(Slope).Append("\n");
            sb.Append("  WaterDist: ").Append(WaterDist).Append("\n");
            sb.Append("  Tier: ").Append(Tier).Append("\n");
            sb.Append("  TierDescription: ").Append(TierDescription).Append("\n");
            sb.Append("  DistanceToFireStation: ").Append(DistanceToFireStation).Append("\n");
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
            return this.Equals(input as Risk);
        }

        /// <summary>
        /// Returns true if Risk instances are equal
        /// </summary>
        /// <param name="input">Instance of Risk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Risk input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Risk50Rating == input.Risk50Rating ||
                    (this.Risk50Rating != null &&
                    this.Risk50Rating.Equals(input.Risk50Rating))
                ) && 
                (
                    this.Frequency == input.Frequency ||
                    (this.Frequency != null &&
                    this.Frequency.Equals(input.Frequency))
                ) && 
                (
                    this.Nonburn == input.Nonburn ||
                    (this.Nonburn != null &&
                    this.Nonburn.Equals(input.Nonburn))
                ) && 
                (
                    this.PastFires == input.PastFires ||
                    (this.PastFires != null &&
                    this.PastFires.Equals(input.PastFires))
                ) && 
                (
                    this.Severity == input.Severity ||
                    (this.Severity != null &&
                    this.Severity.Equals(input.Severity))
                ) && 
                (
                    this.Continuity == input.Continuity ||
                    (this.Continuity != null &&
                    this.Continuity.Equals(input.Continuity))
                ) && 
                (
                    this.Adjustment == input.Adjustment ||
                    (this.Adjustment != null &&
                    this.Adjustment.Equals(input.Adjustment))
                ) && 
                (
                    this.Aspect == input.Aspect ||
                    (this.Aspect != null &&
                    this.Aspect.Equals(input.Aspect))
                ) && 
                (
                    this.CrownFire == input.CrownFire ||
                    (this.CrownFire != null &&
                    this.CrownFire.Equals(input.CrownFire))
                ) && 
                (
                    this.Vegetation == input.Vegetation ||
                    (this.Vegetation != null &&
                    this.Vegetation.Equals(input.Vegetation))
                ) && 
                (
                    this.Foehn == input.Foehn ||
                    (this.Foehn != null &&
                    this.Foehn.Equals(input.Foehn))
                ) && 
                (
                    this.GolfCourse == input.GolfCourse ||
                    (this.GolfCourse != null &&
                    this.GolfCourse.Equals(input.GolfCourse))
                ) && 
                (
                    this.RoadDist == input.RoadDist ||
                    (this.RoadDist != null &&
                    this.RoadDist.Equals(input.RoadDist))
                ) && 
                (
                    this.Slope == input.Slope ||
                    (this.Slope != null &&
                    this.Slope.Equals(input.Slope))
                ) && 
                (
                    this.WaterDist == input.WaterDist ||
                    (this.WaterDist != null &&
                    this.WaterDist.Equals(input.WaterDist))
                ) && 
                (
                    this.Tier == input.Tier ||
                    (this.Tier != null &&
                    this.Tier.Equals(input.Tier))
                ) && 
                (
                    this.TierDescription == input.TierDescription ||
                    (this.TierDescription != null &&
                    this.TierDescription.Equals(input.TierDescription))
                ) && 
                (
                    this.DistanceToFireStation == input.DistanceToFireStation ||
                    (this.DistanceToFireStation != null &&
                    this.DistanceToFireStation.Equals(input.DistanceToFireStation))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Risk50Rating != null)
                    hashCode = hashCode * 59 + this.Risk50Rating.GetHashCode();
                if (this.Frequency != null)
                    hashCode = hashCode * 59 + this.Frequency.GetHashCode();
                if (this.Nonburn != null)
                    hashCode = hashCode * 59 + this.Nonburn.GetHashCode();
                if (this.PastFires != null)
                    hashCode = hashCode * 59 + this.PastFires.GetHashCode();
                if (this.Severity != null)
                    hashCode = hashCode * 59 + this.Severity.GetHashCode();
                if (this.Continuity != null)
                    hashCode = hashCode * 59 + this.Continuity.GetHashCode();
                if (this.Adjustment != null)
                    hashCode = hashCode * 59 + this.Adjustment.GetHashCode();
                if (this.Aspect != null)
                    hashCode = hashCode * 59 + this.Aspect.GetHashCode();
                if (this.CrownFire != null)
                    hashCode = hashCode * 59 + this.CrownFire.GetHashCode();
                if (this.Vegetation != null)
                    hashCode = hashCode * 59 + this.Vegetation.GetHashCode();
                if (this.Foehn != null)
                    hashCode = hashCode * 59 + this.Foehn.GetHashCode();
                if (this.GolfCourse != null)
                    hashCode = hashCode * 59 + this.GolfCourse.GetHashCode();
                if (this.RoadDist != null)
                    hashCode = hashCode * 59 + this.RoadDist.GetHashCode();
                if (this.Slope != null)
                    hashCode = hashCode * 59 + this.Slope.GetHashCode();
                if (this.WaterDist != null)
                    hashCode = hashCode * 59 + this.WaterDist.GetHashCode();
                if (this.Tier != null)
                    hashCode = hashCode * 59 + this.Tier.GetHashCode();
                if (this.TierDescription != null)
                    hashCode = hashCode * 59 + this.TierDescription.GetHashCode();
                if (this.DistanceToFireStation != null)
                    hashCode = hashCode * 59 + this.DistanceToFireStation.GetHashCode();
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

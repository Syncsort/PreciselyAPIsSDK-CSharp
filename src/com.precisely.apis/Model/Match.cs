/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 11.9.4
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
    /// Match
    /// </summary>
    [DataContract]
    public partial class Match :  IEquatable<Match>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Match" /> class.
        /// </summary>
        /// <param name="confidence">confidence.</param>
        /// <param name="percentGeocode">percentGeocode.</param>
        /// <param name="precisionLevel">precisionLevel.</param>
        /// <param name="locationCode">locationCode.</param>
        /// <param name="matchCode">matchCode.</param>
        public Match(string confidence = default(string), string percentGeocode = default(string), string precisionLevel = default(string), string locationCode = default(string), string matchCode = default(string))
        {
            this.Confidence = confidence;
            this.PercentGeocode = percentGeocode;
            this.PrecisionLevel = precisionLevel;
            this.LocationCode = locationCode;
            this.MatchCode = matchCode;
        }

        /// <summary>
        /// Gets or Sets Confidence
        /// </summary>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public string Confidence { get; set; }

        /// <summary>
        /// Gets or Sets PercentGeocode
        /// </summary>
        [DataMember(Name="percentGeocode", EmitDefaultValue=false)]
        public string PercentGeocode { get; set; }

        /// <summary>
        /// Gets or Sets PrecisionLevel
        /// </summary>
        [DataMember(Name="precisionLevel", EmitDefaultValue=false)]
        public string PrecisionLevel { get; set; }

        /// <summary>
        /// Gets or Sets LocationCode
        /// </summary>
        [DataMember(Name="locationCode", EmitDefaultValue=false)]
        public string LocationCode { get; set; }

        /// <summary>
        /// Gets or Sets MatchCode
        /// </summary>
        [DataMember(Name="matchCode", EmitDefaultValue=false)]
        public string MatchCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Match {\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  PercentGeocode: ").Append(PercentGeocode).Append("\n");
            sb.Append("  PrecisionLevel: ").Append(PrecisionLevel).Append("\n");
            sb.Append("  LocationCode: ").Append(LocationCode).Append("\n");
            sb.Append("  MatchCode: ").Append(MatchCode).Append("\n");
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
            return this.Equals(input as Match);
        }

        /// <summary>
        /// Returns true if Match instances are equal
        /// </summary>
        /// <param name="input">Instance of Match to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Match input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.PercentGeocode == input.PercentGeocode ||
                    (this.PercentGeocode != null &&
                    this.PercentGeocode.Equals(input.PercentGeocode))
                ) && 
                (
                    this.PrecisionLevel == input.PrecisionLevel ||
                    (this.PrecisionLevel != null &&
                    this.PrecisionLevel.Equals(input.PrecisionLevel))
                ) && 
                (
                    this.LocationCode == input.LocationCode ||
                    (this.LocationCode != null &&
                    this.LocationCode.Equals(input.LocationCode))
                ) && 
                (
                    this.MatchCode == input.MatchCode ||
                    (this.MatchCode != null &&
                    this.MatchCode.Equals(input.MatchCode))
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
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.PercentGeocode != null)
                    hashCode = hashCode * 59 + this.PercentGeocode.GetHashCode();
                if (this.PrecisionLevel != null)
                    hashCode = hashCode * 59 + this.PrecisionLevel.GetHashCode();
                if (this.LocationCode != null)
                    hashCode = hashCode * 59 + this.LocationCode.GetHashCode();
                if (this.MatchCode != null)
                    hashCode = hashCode * 59 + this.MatchCode.GetHashCode();
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

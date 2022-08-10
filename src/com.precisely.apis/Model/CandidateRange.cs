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
    /// CandidateRange
    /// </summary>
    [DataContract]
    public partial class CandidateRange :  IEquatable<CandidateRange>, IValidatableObject
    {
        /// <summary>
        /// Defines Side
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SideEnum
        {
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 1,

            /// <summary>
            /// Enum LEFT for value: LEFT
            /// </summary>
            [EnumMember(Value = "LEFT")]
            LEFT = 2,

            /// <summary>
            /// Enum RIGHT for value: RIGHT
            /// </summary>
            [EnumMember(Value = "RIGHT")]
            RIGHT = 3,

            /// <summary>
            /// Enum BOTH for value: BOTH
            /// </summary>
            [EnumMember(Value = "BOTH")]
            BOTH = 4

        }

        /// <summary>
        /// Gets or Sets Side
        /// </summary>
        [DataMember(Name="side", EmitDefaultValue=false)]
        public SideEnum? Side { get; set; }
        /// <summary>
        /// Defines OddEvenIndicator
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OddEvenIndicatorEnum
        {
            /// <summary>
            /// Enum UNKNOWN for value: UNKNOWN
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN = 1,

            /// <summary>
            /// Enum BOTH for value: BOTH
            /// </summary>
            [EnumMember(Value = "BOTH")]
            BOTH = 2,

            /// <summary>
            /// Enum ODD for value: ODD
            /// </summary>
            [EnumMember(Value = "ODD")]
            ODD = 3,

            /// <summary>
            /// Enum EVEN for value: EVEN
            /// </summary>
            [EnumMember(Value = "EVEN")]
            EVEN = 4,

            /// <summary>
            /// Enum IRREGULAR for value: IRREGULAR
            /// </summary>
            [EnumMember(Value = "IRREGULAR")]
            IRREGULAR = 5

        }

        /// <summary>
        /// Gets or Sets OddEvenIndicator
        /// </summary>
        [DataMember(Name="oddEvenIndicator", EmitDefaultValue=false)]
        public OddEvenIndicatorEnum? OddEvenIndicator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CandidateRange" /> class.
        /// </summary>
        /// <param name="placeName">placeName.</param>
        /// <param name="lowHouse">lowHouse.</param>
        /// <param name="highHouse">highHouse.</param>
        /// <param name="side">side.</param>
        /// <param name="oddEvenIndicator">oddEvenIndicator.</param>
        /// <param name="units">units.</param>
        /// <param name="customValues">customValues.</param>
        public CandidateRange(string placeName = default(string), string lowHouse = default(string), string highHouse = default(string), SideEnum? side = default(SideEnum?), OddEvenIndicatorEnum? oddEvenIndicator = default(OddEvenIndicatorEnum?), List<CandidateRangeUnit> units = default(List<CandidateRangeUnit>), Dictionary<string, Object> customValues = default(Dictionary<string, Object>))
        {
            this.PlaceName = placeName;
            this.LowHouse = lowHouse;
            this.HighHouse = highHouse;
            this.Side = side;
            this.OddEvenIndicator = oddEvenIndicator;
            this.Units = units;
            this.CustomValues = customValues;
        }

        /// <summary>
        /// Gets or Sets PlaceName
        /// </summary>
        [DataMember(Name="placeName", EmitDefaultValue=false)]
        public string PlaceName { get; set; }

        /// <summary>
        /// Gets or Sets LowHouse
        /// </summary>
        [DataMember(Name="lowHouse", EmitDefaultValue=false)]
        public string LowHouse { get; set; }

        /// <summary>
        /// Gets or Sets HighHouse
        /// </summary>
        [DataMember(Name="highHouse", EmitDefaultValue=false)]
        public string HighHouse { get; set; }



        /// <summary>
        /// Gets or Sets Units
        /// </summary>
        [DataMember(Name="units", EmitDefaultValue=false)]
        public List<CandidateRangeUnit> Units { get; set; }

        /// <summary>
        /// Gets or Sets CustomValues
        /// </summary>
        [DataMember(Name="customValues", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CandidateRange {\n");
            sb.Append("  PlaceName: ").Append(PlaceName).Append("\n");
            sb.Append("  LowHouse: ").Append(LowHouse).Append("\n");
            sb.Append("  HighHouse: ").Append(HighHouse).Append("\n");
            sb.Append("  Side: ").Append(Side).Append("\n");
            sb.Append("  OddEvenIndicator: ").Append(OddEvenIndicator).Append("\n");
            sb.Append("  Units: ").Append(Units).Append("\n");
            sb.Append("  CustomValues: ").Append(CustomValues).Append("\n");
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
            return this.Equals(input as CandidateRange);
        }

        /// <summary>
        /// Returns true if CandidateRange instances are equal
        /// </summary>
        /// <param name="input">Instance of CandidateRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CandidateRange input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PlaceName == input.PlaceName ||
                    (this.PlaceName != null &&
                    this.PlaceName.Equals(input.PlaceName))
                ) && 
                (
                    this.LowHouse == input.LowHouse ||
                    (this.LowHouse != null &&
                    this.LowHouse.Equals(input.LowHouse))
                ) && 
                (
                    this.HighHouse == input.HighHouse ||
                    (this.HighHouse != null &&
                    this.HighHouse.Equals(input.HighHouse))
                ) && 
                (
                    this.Side == input.Side ||
                    (this.Side != null &&
                    this.Side.Equals(input.Side))
                ) && 
                (
                    this.OddEvenIndicator == input.OddEvenIndicator ||
                    (this.OddEvenIndicator != null &&
                    this.OddEvenIndicator.Equals(input.OddEvenIndicator))
                ) && 
                (
                    this.Units == input.Units ||
                    this.Units != null &&
                    input.Units != null &&
                    this.Units.SequenceEqual(input.Units)
                ) && 
                (
                    this.CustomValues == input.CustomValues ||
                    this.CustomValues != null &&
                    input.CustomValues != null &&
                    this.CustomValues.SequenceEqual(input.CustomValues)
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
                if (this.PlaceName != null)
                    hashCode = hashCode * 59 + this.PlaceName.GetHashCode();
                if (this.LowHouse != null)
                    hashCode = hashCode * 59 + this.LowHouse.GetHashCode();
                if (this.HighHouse != null)
                    hashCode = hashCode * 59 + this.HighHouse.GetHashCode();
                if (this.Side != null)
                    hashCode = hashCode * 59 + this.Side.GetHashCode();
                if (this.OddEvenIndicator != null)
                    hashCode = hashCode * 59 + this.OddEvenIndicator.GetHashCode();
                if (this.Units != null)
                    hashCode = hashCode * 59 + this.Units.GetHashCode();
                if (this.CustomValues != null)
                    hashCode = hashCode * 59 + this.CustomValues.GetHashCode();
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

/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 9.5.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace com.precisely.apis.Model
{
    /// <summary>
    /// CandidateRange
    /// </summary>
    [DataContract]
    public partial class CandidateRange :  IEquatable<CandidateRange>
    {
        /// <summary>
        /// Gets or Sets Side
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SideEnum
        {
            
            /// <summary>
            /// Enum UNKNOWN for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN,
            
            /// <summary>
            /// Enum LEFT for "LEFT"
            /// </summary>
            [EnumMember(Value = "LEFT")]
            LEFT,
            
            /// <summary>
            /// Enum RIGHT for "RIGHT"
            /// </summary>
            [EnumMember(Value = "RIGHT")]
            RIGHT,
            
            /// <summary>
            /// Enum BOTH for "BOTH"
            /// </summary>
            [EnumMember(Value = "BOTH")]
            BOTH
        }

        /// <summary>
        /// Gets or Sets OddEvenIndicator
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum OddEvenIndicatorEnum
        {
            
            /// <summary>
            /// Enum UNKNOWN for "UNKNOWN"
            /// </summary>
            [EnumMember(Value = "UNKNOWN")]
            UNKNOWN,
            
            /// <summary>
            /// Enum BOTH for "BOTH"
            /// </summary>
            [EnumMember(Value = "BOTH")]
            BOTH,
            
            /// <summary>
            /// Enum ODD for "ODD"
            /// </summary>
            [EnumMember(Value = "ODD")]
            ODD,
            
            /// <summary>
            /// Enum EVEN for "EVEN"
            /// </summary>
            [EnumMember(Value = "EVEN")]
            EVEN,
            
            /// <summary>
            /// Enum IRREGULAR for "IRREGULAR"
            /// </summary>
            [EnumMember(Value = "IRREGULAR")]
            IRREGULAR
        }

        /// <summary>
        /// Gets or Sets Side
        /// </summary>
        [DataMember(Name="side", EmitDefaultValue=false)]
        public SideEnum? Side { get; set; }
        /// <summary>
        /// Gets or Sets OddEvenIndicator
        /// </summary>
        [DataMember(Name="oddEvenIndicator", EmitDefaultValue=false)]
        public OddEvenIndicatorEnum? OddEvenIndicator { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CandidateRange" /> class.
        /// </summary>
        /// <param name="PlaceName">PlaceName.</param>
        /// <param name="LowHouse">LowHouse.</param>
        /// <param name="HighHouse">HighHouse.</param>
        /// <param name="Side">Side.</param>
        /// <param name="OddEvenIndicator">OddEvenIndicator.</param>
        /// <param name="Units">Units.</param>
        /// <param name="CustomValues">CustomValues.</param>
        public CandidateRange(string PlaceName = null, string LowHouse = null, string HighHouse = null, SideEnum? Side = null, OddEvenIndicatorEnum? OddEvenIndicator = null, List<CandidateRangeUnit> Units = null, Dictionary<string, Object> CustomValues = null)
        {
            this.PlaceName = PlaceName;
            this.LowHouse = LowHouse;
            this.HighHouse = HighHouse;
            this.Side = Side;
            this.OddEvenIndicator = OddEvenIndicator;
            this.Units = Units;
            this.CustomValues = CustomValues;
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
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as CandidateRange);
        }

        /// <summary>
        /// Returns true if CandidateRange instances are equal
        /// </summary>
        /// <param name="other">Instance of CandidateRange to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CandidateRange other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.PlaceName == other.PlaceName ||
                    this.PlaceName != null &&
                    this.PlaceName.Equals(other.PlaceName)
                ) && 
                (
                    this.LowHouse == other.LowHouse ||
                    this.LowHouse != null &&
                    this.LowHouse.Equals(other.LowHouse)
                ) && 
                (
                    this.HighHouse == other.HighHouse ||
                    this.HighHouse != null &&
                    this.HighHouse.Equals(other.HighHouse)
                ) && 
                (
                    this.Side == other.Side ||
                    this.Side != null &&
                    this.Side.Equals(other.Side)
                ) && 
                (
                    this.OddEvenIndicator == other.OddEvenIndicator ||
                    this.OddEvenIndicator != null &&
                    this.OddEvenIndicator.Equals(other.OddEvenIndicator)
                ) && 
                (
                    this.Units == other.Units ||
                    this.Units != null &&
                    this.Units.SequenceEqual(other.Units)
                ) && 
                (
                    this.CustomValues == other.CustomValues ||
                    this.CustomValues != null &&
                    this.CustomValues.SequenceEqual(other.CustomValues)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.PlaceName != null)
                    hash = hash * 59 + this.PlaceName.GetHashCode();
                if (this.LowHouse != null)
                    hash = hash * 59 + this.LowHouse.GetHashCode();
                if (this.HighHouse != null)
                    hash = hash * 59 + this.HighHouse.GetHashCode();
                if (this.Side != null)
                    hash = hash * 59 + this.Side.GetHashCode();
                if (this.OddEvenIndicator != null)
                    hash = hash * 59 + this.OddEvenIndicator.GetHashCode();
                if (this.Units != null)
                    hash = hash * 59 + this.Units.GetHashCode();
                if (this.CustomValues != null)
                    hash = hash * 59 + this.CustomValues.GetHashCode();
                return hash;
            }
        }
    }

}

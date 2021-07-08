/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.0.1
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
    /// LatLongFields
    /// </summary>
    [DataContract]
    public partial class LatLongFields :  IEquatable<LatLongFields>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LatLongFields" /> class.
        /// </summary>
        /// <param name="MatchCode">MatchCode.</param>
        /// <param name="MatchLevel">MatchLevel.</param>
        /// <param name="StreetMatchCode">StreetMatchCode.</param>
        /// <param name="StreetMatchLevel">StreetMatchLevel.</param>
        /// <param name="Geometry">Geometry.</param>
        public LatLongFields(string MatchCode = null, string MatchLevel = null, string StreetMatchCode = null, string StreetMatchLevel = null, Geometry Geometry = null)
        {
            this.MatchCode = MatchCode;
            this.MatchLevel = MatchLevel;
            this.StreetMatchCode = StreetMatchCode;
            this.StreetMatchLevel = StreetMatchLevel;
            this.Geometry = Geometry;
        }
        
        /// <summary>
        /// Gets or Sets MatchCode
        /// </summary>
        [DataMember(Name="matchCode", EmitDefaultValue=false)]
        public string MatchCode { get; set; }
        /// <summary>
        /// Gets or Sets MatchLevel
        /// </summary>
        [DataMember(Name="matchLevel", EmitDefaultValue=false)]
        public string MatchLevel { get; set; }
        /// <summary>
        /// Gets or Sets StreetMatchCode
        /// </summary>
        [DataMember(Name="streetMatchCode", EmitDefaultValue=false)]
        public string StreetMatchCode { get; set; }
        /// <summary>
        /// Gets or Sets StreetMatchLevel
        /// </summary>
        [DataMember(Name="streetMatchLevel", EmitDefaultValue=false)]
        public string StreetMatchLevel { get; set; }
        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public Geometry Geometry { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LatLongFields {\n");
            sb.Append("  MatchCode: ").Append(MatchCode).Append("\n");
            sb.Append("  MatchLevel: ").Append(MatchLevel).Append("\n");
            sb.Append("  StreetMatchCode: ").Append(StreetMatchCode).Append("\n");
            sb.Append("  StreetMatchLevel: ").Append(StreetMatchLevel).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
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
            return this.Equals(obj as LatLongFields);
        }

        /// <summary>
        /// Returns true if LatLongFields instances are equal
        /// </summary>
        /// <param name="other">Instance of LatLongFields to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LatLongFields other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.MatchCode == other.MatchCode ||
                    this.MatchCode != null &&
                    this.MatchCode.Equals(other.MatchCode)
                ) && 
                (
                    this.MatchLevel == other.MatchLevel ||
                    this.MatchLevel != null &&
                    this.MatchLevel.Equals(other.MatchLevel)
                ) && 
                (
                    this.StreetMatchCode == other.StreetMatchCode ||
                    this.StreetMatchCode != null &&
                    this.StreetMatchCode.Equals(other.StreetMatchCode)
                ) && 
                (
                    this.StreetMatchLevel == other.StreetMatchLevel ||
                    this.StreetMatchLevel != null &&
                    this.StreetMatchLevel.Equals(other.StreetMatchLevel)
                ) && 
                (
                    this.Geometry == other.Geometry ||
                    this.Geometry != null &&
                    this.Geometry.Equals(other.Geometry)
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
                if (this.MatchCode != null)
                    hash = hash * 59 + this.MatchCode.GetHashCode();
                if (this.MatchLevel != null)
                    hash = hash * 59 + this.MatchLevel.GetHashCode();
                if (this.StreetMatchCode != null)
                    hash = hash * 59 + this.StreetMatchCode.GetHashCode();
                if (this.StreetMatchLevel != null)
                    hash = hash * 59 + this.StreetMatchLevel.GetHashCode();
                if (this.Geometry != null)
                    hash = hash * 59 + this.Geometry.GetHashCode();
                return hash;
            }
        }
    }

}

/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.7.0
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
    /// POIByGeometryRequest
    /// </summary>
    [DataContract]
    public partial class POIByGeometryRequest :  IEquatable<POIByGeometryRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="POIByGeometryRequest" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Type">Type.</param>
        /// <param name="CategoryCode">CategoryCode.</param>
        /// <param name="SicCode">SicCode.</param>
        /// <param name="MaxCandidates">MaxCandidates.</param>
        /// <param name="FuzzyOnName">FuzzyOnName.</param>
        /// <param name="Page">Page.</param>
        /// <param name="MatchMode">MatchMode.</param>
        /// <param name="SpecificMatchOn">SpecificMatchOn.</param>
        /// <param name="Geometry">Geometry.</param>
        /// <param name="GeometryAsText">GeometryAsText.</param>
        public POIByGeometryRequest(string Name = null, string Type = null, string CategoryCode = null, string SicCode = null, string MaxCandidates = null, string FuzzyOnName = null, string Page = null, string MatchMode = null, string SpecificMatchOn = null, CommonGeometry Geometry = null, string GeometryAsText = null)
        {
            this.Name = Name;
            this.Type = Type;
            this.CategoryCode = CategoryCode;
            this.SicCode = SicCode;
            this.MaxCandidates = MaxCandidates;
            this.FuzzyOnName = FuzzyOnName;
            this.Page = Page;
            this.MatchMode = MatchMode;
            this.SpecificMatchOn = SpecificMatchOn;
            this.Geometry = Geometry;
            this.GeometryAsText = GeometryAsText;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }
        /// <summary>
        /// Gets or Sets CategoryCode
        /// </summary>
        [DataMember(Name="categoryCode", EmitDefaultValue=false)]
        public string CategoryCode { get; set; }
        /// <summary>
        /// Gets or Sets SicCode
        /// </summary>
        [DataMember(Name="sicCode", EmitDefaultValue=false)]
        public string SicCode { get; set; }
        /// <summary>
        /// Gets or Sets MaxCandidates
        /// </summary>
        [DataMember(Name="maxCandidates", EmitDefaultValue=false)]
        public string MaxCandidates { get; set; }
        /// <summary>
        /// Gets or Sets FuzzyOnName
        /// </summary>
        [DataMember(Name="fuzzyOnName", EmitDefaultValue=false)]
        public string FuzzyOnName { get; set; }
        /// <summary>
        /// Gets or Sets Page
        /// </summary>
        [DataMember(Name="page", EmitDefaultValue=false)]
        public string Page { get; set; }
        /// <summary>
        /// Gets or Sets MatchMode
        /// </summary>
        [DataMember(Name="matchMode", EmitDefaultValue=false)]
        public string MatchMode { get; set; }
        /// <summary>
        /// Gets or Sets SpecificMatchOn
        /// </summary>
        [DataMember(Name="specificMatchOn", EmitDefaultValue=false)]
        public string SpecificMatchOn { get; set; }
        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public CommonGeometry Geometry { get; set; }
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
            sb.Append("class POIByGeometryRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  SicCode: ").Append(SicCode).Append("\n");
            sb.Append("  MaxCandidates: ").Append(MaxCandidates).Append("\n");
            sb.Append("  FuzzyOnName: ").Append(FuzzyOnName).Append("\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  MatchMode: ").Append(MatchMode).Append("\n");
            sb.Append("  SpecificMatchOn: ").Append(SpecificMatchOn).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  GeometryAsText: ").Append(GeometryAsText).Append("\n");
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
            return this.Equals(obj as POIByGeometryRequest);
        }

        /// <summary>
        /// Returns true if POIByGeometryRequest instances are equal
        /// </summary>
        /// <param name="other">Instance of POIByGeometryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(POIByGeometryRequest other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) && 
                (
                    this.CategoryCode == other.CategoryCode ||
                    this.CategoryCode != null &&
                    this.CategoryCode.Equals(other.CategoryCode)
                ) && 
                (
                    this.SicCode == other.SicCode ||
                    this.SicCode != null &&
                    this.SicCode.Equals(other.SicCode)
                ) && 
                (
                    this.MaxCandidates == other.MaxCandidates ||
                    this.MaxCandidates != null &&
                    this.MaxCandidates.Equals(other.MaxCandidates)
                ) && 
                (
                    this.FuzzyOnName == other.FuzzyOnName ||
                    this.FuzzyOnName != null &&
                    this.FuzzyOnName.Equals(other.FuzzyOnName)
                ) && 
                (
                    this.Page == other.Page ||
                    this.Page != null &&
                    this.Page.Equals(other.Page)
                ) && 
                (
                    this.MatchMode == other.MatchMode ||
                    this.MatchMode != null &&
                    this.MatchMode.Equals(other.MatchMode)
                ) && 
                (
                    this.SpecificMatchOn == other.SpecificMatchOn ||
                    this.SpecificMatchOn != null &&
                    this.SpecificMatchOn.Equals(other.SpecificMatchOn)
                ) && 
                (
                    this.Geometry == other.Geometry ||
                    this.Geometry != null &&
                    this.Geometry.Equals(other.Geometry)
                ) && 
                (
                    this.GeometryAsText == other.GeometryAsText ||
                    this.GeometryAsText != null &&
                    this.GeometryAsText.Equals(other.GeometryAsText)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();
                if (this.CategoryCode != null)
                    hash = hash * 59 + this.CategoryCode.GetHashCode();
                if (this.SicCode != null)
                    hash = hash * 59 + this.SicCode.GetHashCode();
                if (this.MaxCandidates != null)
                    hash = hash * 59 + this.MaxCandidates.GetHashCode();
                if (this.FuzzyOnName != null)
                    hash = hash * 59 + this.FuzzyOnName.GetHashCode();
                if (this.Page != null)
                    hash = hash * 59 + this.Page.GetHashCode();
                if (this.MatchMode != null)
                    hash = hash * 59 + this.MatchMode.GetHashCode();
                if (this.SpecificMatchOn != null)
                    hash = hash * 59 + this.SpecificMatchOn.GetHashCode();
                if (this.Geometry != null)
                    hash = hash * 59 + this.Geometry.GetHashCode();
                if (this.GeometryAsText != null)
                    hash = hash * 59 + this.GeometryAsText.GetHashCode();
                return hash;
            }
        }
    }

}

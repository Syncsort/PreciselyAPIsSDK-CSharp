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
    /// RateCenterResponse
    /// </summary>
    [DataContract]
    public partial class RateCenterResponse :  IEquatable<RateCenterResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RateCenterResponse" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="AlternateName">AlternateName.</param>
        /// <param name="AreaName1">AreaName1.</param>
        /// <param name="Geometry">Geometry.</param>
        /// <param name="AreaCodeInfoList">AreaCodeInfoList.</param>
        /// <param name="MatchedAddress">MatchedAddress.</param>
        /// <param name="Match">Match.</param>
        /// <param name="County">County.</param>
        /// <param name="Count">Count.</param>
        /// <param name="ProductCode">ProductCode.</param>
        public RateCenterResponse(string Id = null, string Name = null, string AlternateName = null, string AreaName1 = null, Geometry Geometry = null, List<AreaCodeInfo> AreaCodeInfoList = null, MatchedAddress MatchedAddress = null, Match Match = null, County County = null, int? Count = null, string ProductCode = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.AlternateName = AlternateName;
            this.AreaName1 = AreaName1;
            this.Geometry = Geometry;
            this.AreaCodeInfoList = AreaCodeInfoList;
            this.MatchedAddress = MatchedAddress;
            this.Match = Match;
            this.County = County;
            this.Count = Count;
            this.ProductCode = ProductCode;
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
        /// Gets or Sets AlternateName
        /// </summary>
        [DataMember(Name="alternateName", EmitDefaultValue=false)]
        public string AlternateName { get; set; }
        /// <summary>
        /// Gets or Sets AreaName1
        /// </summary>
        [DataMember(Name="areaName1", EmitDefaultValue=false)]
        public string AreaName1 { get; set; }
        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public Geometry Geometry { get; set; }
        /// <summary>
        /// Gets or Sets AreaCodeInfoList
        /// </summary>
        [DataMember(Name="areaCodeInfoList", EmitDefaultValue=false)]
        public List<AreaCodeInfo> AreaCodeInfoList { get; set; }
        /// <summary>
        /// Gets or Sets MatchedAddress
        /// </summary>
        [DataMember(Name="matchedAddress", EmitDefaultValue=false)]
        public MatchedAddress MatchedAddress { get; set; }
        /// <summary>
        /// Gets or Sets Match
        /// </summary>
        [DataMember(Name="match", EmitDefaultValue=false)]
        public Match Match { get; set; }
        /// <summary>
        /// Gets or Sets County
        /// </summary>
        [DataMember(Name="county", EmitDefaultValue=false)]
        public County County { get; set; }
        /// <summary>
        /// Gets or Sets Count
        /// </summary>
        [DataMember(Name="count", EmitDefaultValue=false)]
        public int? Count { get; set; }
        /// <summary>
        /// Gets or Sets ProductCode
        /// </summary>
        [DataMember(Name="product_code", EmitDefaultValue=false)]
        public string ProductCode { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RateCenterResponse {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AlternateName: ").Append(AlternateName).Append("\n");
            sb.Append("  AreaName1: ").Append(AreaName1).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  AreaCodeInfoList: ").Append(AreaCodeInfoList).Append("\n");
            sb.Append("  MatchedAddress: ").Append(MatchedAddress).Append("\n");
            sb.Append("  Match: ").Append(Match).Append("\n");
            sb.Append("  County: ").Append(County).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  ProductCode: ").Append(ProductCode).Append("\n");
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
            return this.Equals(obj as RateCenterResponse);
        }

        /// <summary>
        /// Returns true if RateCenterResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of RateCenterResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RateCenterResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.AlternateName == other.AlternateName ||
                    this.AlternateName != null &&
                    this.AlternateName.Equals(other.AlternateName)
                ) && 
                (
                    this.AreaName1 == other.AreaName1 ||
                    this.AreaName1 != null &&
                    this.AreaName1.Equals(other.AreaName1)
                ) && 
                (
                    this.Geometry == other.Geometry ||
                    this.Geometry != null &&
                    this.Geometry.Equals(other.Geometry)
                ) && 
                (
                    this.AreaCodeInfoList == other.AreaCodeInfoList ||
                    this.AreaCodeInfoList != null &&
                    this.AreaCodeInfoList.SequenceEqual(other.AreaCodeInfoList)
                ) && 
                (
                    this.MatchedAddress == other.MatchedAddress ||
                    this.MatchedAddress != null &&
                    this.MatchedAddress.Equals(other.MatchedAddress)
                ) && 
                (
                    this.Match == other.Match ||
                    this.Match != null &&
                    this.Match.Equals(other.Match)
                ) && 
                (
                    this.County == other.County ||
                    this.County != null &&
                    this.County.Equals(other.County)
                ) && 
                (
                    this.Count == other.Count ||
                    this.Count != null &&
                    this.Count.Equals(other.Count)
                ) && 
                (
                    this.ProductCode == other.ProductCode ||
                    this.ProductCode != null &&
                    this.ProductCode.Equals(other.ProductCode)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.AlternateName != null)
                    hash = hash * 59 + this.AlternateName.GetHashCode();
                if (this.AreaName1 != null)
                    hash = hash * 59 + this.AreaName1.GetHashCode();
                if (this.Geometry != null)
                    hash = hash * 59 + this.Geometry.GetHashCode();
                if (this.AreaCodeInfoList != null)
                    hash = hash * 59 + this.AreaCodeInfoList.GetHashCode();
                if (this.MatchedAddress != null)
                    hash = hash * 59 + this.MatchedAddress.GetHashCode();
                if (this.Match != null)
                    hash = hash * 59 + this.Match.GetHashCode();
                if (this.County != null)
                    hash = hash * 59 + this.County.GetHashCode();
                if (this.Count != null)
                    hash = hash * 59 + this.Count.GetHashCode();
                if (this.ProductCode != null)
                    hash = hash * 59 + this.ProductCode.GetHashCode();
                return hash;
            }
        }
    }

}

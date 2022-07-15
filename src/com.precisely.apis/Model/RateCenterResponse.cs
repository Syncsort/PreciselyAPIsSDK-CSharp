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
    /// RateCenterResponse
    /// </summary>
    [DataContract]
    public partial class RateCenterResponse :  IEquatable<RateCenterResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RateCenterResponse" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="name">name.</param>
        /// <param name="alternateName">alternateName.</param>
        /// <param name="areaName1">areaName1.</param>
        /// <param name="geometry">geometry.</param>
        /// <param name="areaCodeInfoList">areaCodeInfoList.</param>
        /// <param name="matchedAddress">matchedAddress.</param>
        /// <param name="match">match.</param>
        /// <param name="county">county.</param>
        /// <param name="count">count.</param>
        /// <param name="productCode">productCode.</param>
        public RateCenterResponse(string id = default(string), string name = default(string), string alternateName = default(string), string areaName1 = default(string), Geometry geometry = default(Geometry), List<AreaCodeInfo> areaCodeInfoList = default(List<AreaCodeInfo>), Address matchedAddress = default(Address), Match match = default(Match), County county = default(County), int count = default(int), string productCode = default(string))
        {
            this.Id = id;
            this.Name = name;
            this.AlternateName = alternateName;
            this.AreaName1 = areaName1;
            this.Geometry = geometry;
            this.AreaCodeInfoList = areaCodeInfoList;
            this.MatchedAddress = matchedAddress;
            this.Match = match;
            this.County = county;
            this.Count = count;
            this.ProductCode = productCode;
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
        public Address MatchedAddress { get; set; }

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
        public int Count { get; set; }

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
            return this.Equals(input as RateCenterResponse);
        }

        /// <summary>
        /// Returns true if RateCenterResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of RateCenterResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RateCenterResponse input)
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
                    this.AlternateName == input.AlternateName ||
                    (this.AlternateName != null &&
                    this.AlternateName.Equals(input.AlternateName))
                ) && 
                (
                    this.AreaName1 == input.AreaName1 ||
                    (this.AreaName1 != null &&
                    this.AreaName1.Equals(input.AreaName1))
                ) && 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
                ) && 
                (
                    this.AreaCodeInfoList == input.AreaCodeInfoList ||
                    this.AreaCodeInfoList != null &&
                    input.AreaCodeInfoList != null &&
                    this.AreaCodeInfoList.SequenceEqual(input.AreaCodeInfoList)
                ) && 
                (
                    this.MatchedAddress == input.MatchedAddress ||
                    (this.MatchedAddress != null &&
                    this.MatchedAddress.Equals(input.MatchedAddress))
                ) && 
                (
                    this.Match == input.Match ||
                    (this.Match != null &&
                    this.Match.Equals(input.Match))
                ) && 
                (
                    this.County == input.County ||
                    (this.County != null &&
                    this.County.Equals(input.County))
                ) && 
                (
                    this.Count == input.Count ||
                    (this.Count != null &&
                    this.Count.Equals(input.Count))
                ) && 
                (
                    this.ProductCode == input.ProductCode ||
                    (this.ProductCode != null &&
                    this.ProductCode.Equals(input.ProductCode))
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
                if (this.AlternateName != null)
                    hashCode = hashCode * 59 + this.AlternateName.GetHashCode();
                if (this.AreaName1 != null)
                    hashCode = hashCode * 59 + this.AreaName1.GetHashCode();
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.AreaCodeInfoList != null)
                    hashCode = hashCode * 59 + this.AreaCodeInfoList.GetHashCode();
                if (this.MatchedAddress != null)
                    hashCode = hashCode * 59 + this.MatchedAddress.GetHashCode();
                if (this.Match != null)
                    hashCode = hashCode * 59 + this.Match.GetHashCode();
                if (this.County != null)
                    hashCode = hashCode * 59 + this.County.GetHashCode();
                if (this.Count != null)
                    hashCode = hashCode * 59 + this.Count.GetHashCode();
                if (this.ProductCode != null)
                    hashCode = hashCode * 59 + this.ProductCode.GetHashCode();
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

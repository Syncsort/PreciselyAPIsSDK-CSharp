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
    /// PoiBoundary
    /// </summary>
    [DataContract]
    public partial class PoiBoundary :  IEquatable<PoiBoundary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PoiBoundary" /> class.
        /// </summary>
        /// <param name="objectId">objectId.</param>
        /// <param name="center">center.</param>
        /// <param name="countyfips">countyfips.</param>
        /// <param name="geometry">geometry.</param>
        /// <param name="poiList">poiList.</param>
        /// <param name="matchedAddress">matchedAddress.</param>
        /// <param name="id">id.</param>
        public PoiBoundary(string objectId = default(string), Center center = default(Center), string countyfips = default(string), ZonesPoiGeometry geometry = default(ZonesPoiGeometry), List<ZonesPoi> poiList = default(List<ZonesPoi>), ZonesAddress matchedAddress = default(ZonesAddress), string id = default(string))
        {
            this.ObjectId = objectId;
            this.Center = center;
            this.Countyfips = countyfips;
            this.Geometry = geometry;
            this.PoiList = poiList;
            this.MatchedAddress = matchedAddress;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets Center
        /// </summary>
        [DataMember(Name="center", EmitDefaultValue=false)]
        public Center Center { get; set; }

        /// <summary>
        /// Gets or Sets Countyfips
        /// </summary>
        [DataMember(Name="countyfips", EmitDefaultValue=false)]
        public string Countyfips { get; set; }

        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public ZonesPoiGeometry Geometry { get; set; }

        /// <summary>
        /// Gets or Sets PoiList
        /// </summary>
        [DataMember(Name="poiList", EmitDefaultValue=false)]
        public List<ZonesPoi> PoiList { get; set; }

        /// <summary>
        /// Gets or Sets MatchedAddress
        /// </summary>
        [DataMember(Name="matchedAddress", EmitDefaultValue=false)]
        public ZonesAddress MatchedAddress { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoiBoundary {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  Center: ").Append(Center).Append("\n");
            sb.Append("  Countyfips: ").Append(Countyfips).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  PoiList: ").Append(PoiList).Append("\n");
            sb.Append("  MatchedAddress: ").Append(MatchedAddress).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as PoiBoundary);
        }

        /// <summary>
        /// Returns true if PoiBoundary instances are equal
        /// </summary>
        /// <param name="input">Instance of PoiBoundary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PoiBoundary input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
                ) && 
                (
                    this.Center == input.Center ||
                    (this.Center != null &&
                    this.Center.Equals(input.Center))
                ) && 
                (
                    this.Countyfips == input.Countyfips ||
                    (this.Countyfips != null &&
                    this.Countyfips.Equals(input.Countyfips))
                ) && 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
                ) && 
                (
                    this.PoiList == input.PoiList ||
                    this.PoiList != null &&
                    input.PoiList != null &&
                    this.PoiList.SequenceEqual(input.PoiList)
                ) && 
                (
                    this.MatchedAddress == input.MatchedAddress ||
                    (this.MatchedAddress != null &&
                    this.MatchedAddress.Equals(input.MatchedAddress))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.Center != null)
                    hashCode = hashCode * 59 + this.Center.GetHashCode();
                if (this.Countyfips != null)
                    hashCode = hashCode * 59 + this.Countyfips.GetHashCode();
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.PoiList != null)
                    hashCode = hashCode * 59 + this.PoiList.GetHashCode();
                if (this.MatchedAddress != null)
                    hashCode = hashCode * 59 + this.MatchedAddress.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
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

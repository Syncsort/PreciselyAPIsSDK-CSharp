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
    /// AddressesDTO
    /// </summary>
    [DataContract]
    public partial class AddressesDTO :  IEquatable<AddressesDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressesDTO" /> class.
        /// </summary>
        /// <param name="pbKey">pbKey.</param>
        /// <param name="addressNumber">addressNumber.</param>
        /// <param name="streetName">streetName.</param>
        /// <param name="unitType">unitType.</param>
        /// <param name="unitValue">unitValue.</param>
        /// <param name="type">type.</param>
        /// <param name="areaName1">areaName1.</param>
        /// <param name="areaName2">areaName2.</param>
        /// <param name="areaName3">areaName3.</param>
        /// <param name="areaName4">areaName4.</param>
        /// <param name="postCode">postCode.</param>
        /// <param name="postCodeExt">postCodeExt.</param>
        /// <param name="country">country.</param>
        /// <param name="geometry">geometry.</param>
        /// <param name="propertyType">propertyType.</param>
        /// <param name="propertyTypeDescription">propertyTypeDescription.</param>
        /// <param name="parentPbKey">parentPbKey.</param>
        /// <param name="geoId">geoId.</param>
        public AddressesDTO(string pbKey = default(string), string addressNumber = default(string), string streetName = default(string), string unitType = default(string), string unitValue = default(string), AddressType type = default(AddressType), string areaName1 = default(string), string areaName2 = default(string), string areaName3 = default(string), string areaName4 = default(string), string postCode = default(string), string postCodeExt = default(string), string country = default(string), Geometry geometry = default(Geometry), string propertyType = default(string), string propertyTypeDescription = default(string), string parentPbKey = default(string), string geoId = default(string))
        {
            this.PbKey = pbKey;
            this.AddressNumber = addressNumber;
            this.StreetName = streetName;
            this.UnitType = unitType;
            this.UnitValue = unitValue;
            this.Type = type;
            this.AreaName1 = areaName1;
            this.AreaName2 = areaName2;
            this.AreaName3 = areaName3;
            this.AreaName4 = areaName4;
            this.PostCode = postCode;
            this.PostCodeExt = postCodeExt;
            this.Country = country;
            this.Geometry = geometry;
            this.PropertyType = propertyType;
            this.PropertyTypeDescription = propertyTypeDescription;
            this.ParentPbKey = parentPbKey;
            this.GeoId = geoId;
        }

        /// <summary>
        /// Gets or Sets PbKey
        /// </summary>
        [DataMember(Name="pbKey", EmitDefaultValue=false)]
        public string PbKey { get; set; }

        /// <summary>
        /// Gets or Sets AddressNumber
        /// </summary>
        [DataMember(Name="addressNumber", EmitDefaultValue=false)]
        public string AddressNumber { get; set; }

        /// <summary>
        /// Gets or Sets StreetName
        /// </summary>
        [DataMember(Name="streetName", EmitDefaultValue=false)]
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or Sets UnitType
        /// </summary>
        [DataMember(Name="unitType", EmitDefaultValue=false)]
        public string UnitType { get; set; }

        /// <summary>
        /// Gets or Sets UnitValue
        /// </summary>
        [DataMember(Name="unitValue", EmitDefaultValue=false)]
        public string UnitValue { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public AddressType Type { get; set; }

        /// <summary>
        /// Gets or Sets AreaName1
        /// </summary>
        [DataMember(Name="areaName1", EmitDefaultValue=false)]
        public string AreaName1 { get; set; }

        /// <summary>
        /// Gets or Sets AreaName2
        /// </summary>
        [DataMember(Name="areaName2", EmitDefaultValue=false)]
        public string AreaName2 { get; set; }

        /// <summary>
        /// Gets or Sets AreaName3
        /// </summary>
        [DataMember(Name="areaName3", EmitDefaultValue=false)]
        public string AreaName3 { get; set; }

        /// <summary>
        /// Gets or Sets AreaName4
        /// </summary>
        [DataMember(Name="areaName4", EmitDefaultValue=false)]
        public string AreaName4 { get; set; }

        /// <summary>
        /// Gets or Sets PostCode
        /// </summary>
        [DataMember(Name="postCode", EmitDefaultValue=false)]
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or Sets PostCodeExt
        /// </summary>
        [DataMember(Name="postCodeExt", EmitDefaultValue=false)]
        public string PostCodeExt { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public Geometry Geometry { get; set; }

        /// <summary>
        /// Gets or Sets PropertyType
        /// </summary>
        [DataMember(Name="propertyType", EmitDefaultValue=false)]
        public string PropertyType { get; set; }

        /// <summary>
        /// Gets or Sets PropertyTypeDescription
        /// </summary>
        [DataMember(Name="propertyTypeDescription", EmitDefaultValue=false)]
        public string PropertyTypeDescription { get; set; }

        /// <summary>
        /// Gets or Sets ParentPbKey
        /// </summary>
        [DataMember(Name="parentPbKey", EmitDefaultValue=false)]
        public string ParentPbKey { get; set; }

        /// <summary>
        /// Gets or Sets GeoId
        /// </summary>
        [DataMember(Name="geoId", EmitDefaultValue=false)]
        public string GeoId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddressesDTO {\n");
            sb.Append("  PbKey: ").Append(PbKey).Append("\n");
            sb.Append("  AddressNumber: ").Append(AddressNumber).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            sb.Append("  UnitValue: ").Append(UnitValue).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  AreaName1: ").Append(AreaName1).Append("\n");
            sb.Append("  AreaName2: ").Append(AreaName2).Append("\n");
            sb.Append("  AreaName3: ").Append(AreaName3).Append("\n");
            sb.Append("  AreaName4: ").Append(AreaName4).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
            sb.Append("  PostCodeExt: ").Append(PostCodeExt).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  PropertyType: ").Append(PropertyType).Append("\n");
            sb.Append("  PropertyTypeDescription: ").Append(PropertyTypeDescription).Append("\n");
            sb.Append("  ParentPbKey: ").Append(ParentPbKey).Append("\n");
            sb.Append("  GeoId: ").Append(GeoId).Append("\n");
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
            return this.Equals(input as AddressesDTO);
        }

        /// <summary>
        /// Returns true if AddressesDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AddressesDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AddressesDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PbKey == input.PbKey ||
                    (this.PbKey != null &&
                    this.PbKey.Equals(input.PbKey))
                ) && 
                (
                    this.AddressNumber == input.AddressNumber ||
                    (this.AddressNumber != null &&
                    this.AddressNumber.Equals(input.AddressNumber))
                ) && 
                (
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
                ) && 
                (
                    this.UnitType == input.UnitType ||
                    (this.UnitType != null &&
                    this.UnitType.Equals(input.UnitType))
                ) && 
                (
                    this.UnitValue == input.UnitValue ||
                    (this.UnitValue != null &&
                    this.UnitValue.Equals(input.UnitValue))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.AreaName1 == input.AreaName1 ||
                    (this.AreaName1 != null &&
                    this.AreaName1.Equals(input.AreaName1))
                ) && 
                (
                    this.AreaName2 == input.AreaName2 ||
                    (this.AreaName2 != null &&
                    this.AreaName2.Equals(input.AreaName2))
                ) && 
                (
                    this.AreaName3 == input.AreaName3 ||
                    (this.AreaName3 != null &&
                    this.AreaName3.Equals(input.AreaName3))
                ) && 
                (
                    this.AreaName4 == input.AreaName4 ||
                    (this.AreaName4 != null &&
                    this.AreaName4.Equals(input.AreaName4))
                ) && 
                (
                    this.PostCode == input.PostCode ||
                    (this.PostCode != null &&
                    this.PostCode.Equals(input.PostCode))
                ) && 
                (
                    this.PostCodeExt == input.PostCodeExt ||
                    (this.PostCodeExt != null &&
                    this.PostCodeExt.Equals(input.PostCodeExt))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
                ) && 
                (
                    this.PropertyType == input.PropertyType ||
                    (this.PropertyType != null &&
                    this.PropertyType.Equals(input.PropertyType))
                ) && 
                (
                    this.PropertyTypeDescription == input.PropertyTypeDescription ||
                    (this.PropertyTypeDescription != null &&
                    this.PropertyTypeDescription.Equals(input.PropertyTypeDescription))
                ) && 
                (
                    this.ParentPbKey == input.ParentPbKey ||
                    (this.ParentPbKey != null &&
                    this.ParentPbKey.Equals(input.ParentPbKey))
                ) && 
                (
                    this.GeoId == input.GeoId ||
                    (this.GeoId != null &&
                    this.GeoId.Equals(input.GeoId))
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
                if (this.PbKey != null)
                    hashCode = hashCode * 59 + this.PbKey.GetHashCode();
                if (this.AddressNumber != null)
                    hashCode = hashCode * 59 + this.AddressNumber.GetHashCode();
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                if (this.UnitType != null)
                    hashCode = hashCode * 59 + this.UnitType.GetHashCode();
                if (this.UnitValue != null)
                    hashCode = hashCode * 59 + this.UnitValue.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AreaName1 != null)
                    hashCode = hashCode * 59 + this.AreaName1.GetHashCode();
                if (this.AreaName2 != null)
                    hashCode = hashCode * 59 + this.AreaName2.GetHashCode();
                if (this.AreaName3 != null)
                    hashCode = hashCode * 59 + this.AreaName3.GetHashCode();
                if (this.AreaName4 != null)
                    hashCode = hashCode * 59 + this.AreaName4.GetHashCode();
                if (this.PostCode != null)
                    hashCode = hashCode * 59 + this.PostCode.GetHashCode();
                if (this.PostCodeExt != null)
                    hashCode = hashCode * 59 + this.PostCodeExt.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.PropertyType != null)
                    hashCode = hashCode * 59 + this.PropertyType.GetHashCode();
                if (this.PropertyTypeDescription != null)
                    hashCode = hashCode * 59 + this.PropertyTypeDescription.GetHashCode();
                if (this.ParentPbKey != null)
                    hashCode = hashCode * 59 + this.ParentPbKey.GetHashCode();
                if (this.GeoId != null)
                    hashCode = hashCode * 59 + this.GeoId.GetHashCode();
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

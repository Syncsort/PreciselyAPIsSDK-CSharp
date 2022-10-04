/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 12.0.1
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
    /// GeocodeAddress
    /// </summary>
    [DataContract]
    public partial class GeocodeAddress :  IEquatable<GeocodeAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeocodeAddress" /> class.
        /// </summary>
        /// <param name="objectId">objectId.</param>
        /// <param name="mainAddressLine">mainAddressLine.</param>
        /// <param name="addressLastLine">addressLastLine.</param>
        /// <param name="placeName">placeName.</param>
        /// <param name="areaName1">areaName1.</param>
        /// <param name="areaName2">areaName2.</param>
        /// <param name="areaName3">areaName3.</param>
        /// <param name="areaName4">areaName4.</param>
        /// <param name="postCode1">postCode1.</param>
        /// <param name="postCode2">postCode2.</param>
        /// <param name="country">country.</param>
        /// <param name="addressNumber">addressNumber.</param>
        /// <param name="streetName">streetName.</param>
        /// <param name="unitType">unitType.</param>
        /// <param name="unitValue">unitValue.</param>
        /// <param name="customFields">customFields.</param>
        public GeocodeAddress(string objectId = default(string), string mainAddressLine = default(string), string addressLastLine = default(string), string placeName = default(string), string areaName1 = default(string), string areaName2 = default(string), string areaName3 = default(string), string areaName4 = default(string), string postCode1 = default(string), string postCode2 = default(string), string country = default(string), string addressNumber = default(string), string streetName = default(string), string unitType = default(string), string unitValue = default(string), Dictionary<string, Object> customFields = default(Dictionary<string, Object>))
        {
            this.ObjectId = objectId;
            this.MainAddressLine = mainAddressLine;
            this.AddressLastLine = addressLastLine;
            this.PlaceName = placeName;
            this.AreaName1 = areaName1;
            this.AreaName2 = areaName2;
            this.AreaName3 = areaName3;
            this.AreaName4 = areaName4;
            this.PostCode1 = postCode1;
            this.PostCode2 = postCode2;
            this.Country = country;
            this.AddressNumber = addressNumber;
            this.StreetName = streetName;
            this.UnitType = unitType;
            this.UnitValue = unitValue;
            this.CustomFields = customFields;
        }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets MainAddressLine
        /// </summary>
        [DataMember(Name="mainAddressLine", EmitDefaultValue=false)]
        public string MainAddressLine { get; set; }

        /// <summary>
        /// Gets or Sets AddressLastLine
        /// </summary>
        [DataMember(Name="addressLastLine", EmitDefaultValue=false)]
        public string AddressLastLine { get; set; }

        /// <summary>
        /// Gets or Sets PlaceName
        /// </summary>
        [DataMember(Name="placeName", EmitDefaultValue=false)]
        public string PlaceName { get; set; }

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
        /// Gets or Sets PostCode1
        /// </summary>
        [DataMember(Name="postCode1", EmitDefaultValue=false)]
        public string PostCode1 { get; set; }

        /// <summary>
        /// Gets or Sets PostCode2
        /// </summary>
        [DataMember(Name="postCode2", EmitDefaultValue=false)]
        public string PostCode2 { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

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
        /// Gets or Sets CustomFields
        /// </summary>
        [DataMember(Name="customFields", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeocodeAddress {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  MainAddressLine: ").Append(MainAddressLine).Append("\n");
            sb.Append("  AddressLastLine: ").Append(AddressLastLine).Append("\n");
            sb.Append("  PlaceName: ").Append(PlaceName).Append("\n");
            sb.Append("  AreaName1: ").Append(AreaName1).Append("\n");
            sb.Append("  AreaName2: ").Append(AreaName2).Append("\n");
            sb.Append("  AreaName3: ").Append(AreaName3).Append("\n");
            sb.Append("  AreaName4: ").Append(AreaName4).Append("\n");
            sb.Append("  PostCode1: ").Append(PostCode1).Append("\n");
            sb.Append("  PostCode2: ").Append(PostCode2).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  AddressNumber: ").Append(AddressNumber).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  UnitType: ").Append(UnitType).Append("\n");
            sb.Append("  UnitValue: ").Append(UnitValue).Append("\n");
            sb.Append("  CustomFields: ").Append(CustomFields).Append("\n");
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
            return this.Equals(input as GeocodeAddress);
        }

        /// <summary>
        /// Returns true if GeocodeAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of GeocodeAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeocodeAddress input)
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
                    this.MainAddressLine == input.MainAddressLine ||
                    (this.MainAddressLine != null &&
                    this.MainAddressLine.Equals(input.MainAddressLine))
                ) && 
                (
                    this.AddressLastLine == input.AddressLastLine ||
                    (this.AddressLastLine != null &&
                    this.AddressLastLine.Equals(input.AddressLastLine))
                ) && 
                (
                    this.PlaceName == input.PlaceName ||
                    (this.PlaceName != null &&
                    this.PlaceName.Equals(input.PlaceName))
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
                    this.PostCode1 == input.PostCode1 ||
                    (this.PostCode1 != null &&
                    this.PostCode1.Equals(input.PostCode1))
                ) && 
                (
                    this.PostCode2 == input.PostCode2 ||
                    (this.PostCode2 != null &&
                    this.PostCode2.Equals(input.PostCode2))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                    this.CustomFields == input.CustomFields ||
                    this.CustomFields != null &&
                    input.CustomFields != null &&
                    this.CustomFields.SequenceEqual(input.CustomFields)
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
                if (this.MainAddressLine != null)
                    hashCode = hashCode * 59 + this.MainAddressLine.GetHashCode();
                if (this.AddressLastLine != null)
                    hashCode = hashCode * 59 + this.AddressLastLine.GetHashCode();
                if (this.PlaceName != null)
                    hashCode = hashCode * 59 + this.PlaceName.GetHashCode();
                if (this.AreaName1 != null)
                    hashCode = hashCode * 59 + this.AreaName1.GetHashCode();
                if (this.AreaName2 != null)
                    hashCode = hashCode * 59 + this.AreaName2.GetHashCode();
                if (this.AreaName3 != null)
                    hashCode = hashCode * 59 + this.AreaName3.GetHashCode();
                if (this.AreaName4 != null)
                    hashCode = hashCode * 59 + this.AreaName4.GetHashCode();
                if (this.PostCode1 != null)
                    hashCode = hashCode * 59 + this.PostCode1.GetHashCode();
                if (this.PostCode2 != null)
                    hashCode = hashCode * 59 + this.PostCode2.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.AddressNumber != null)
                    hashCode = hashCode * 59 + this.AddressNumber.GetHashCode();
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                if (this.UnitType != null)
                    hashCode = hashCode * 59 + this.UnitType.GetHashCode();
                if (this.UnitValue != null)
                    hashCode = hashCode * 59 + this.UnitValue.GetHashCode();
                if (this.CustomFields != null)
                    hashCode = hashCode * 59 + this.CustomFields.GetHashCode();
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

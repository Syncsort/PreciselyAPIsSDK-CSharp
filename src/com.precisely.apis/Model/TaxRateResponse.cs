/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 16.0.1
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
    /// TaxRateResponse
    /// </summary>
    [DataContract]
    public partial class TaxRateResponse :  IEquatable<TaxRateResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxRateResponse" /> class.
        /// </summary>
        /// <param name="objectId">objectId.</param>
        /// <param name="vendorName">vendorName.</param>
        /// <param name="gnisCode">gnisCode.</param>
        /// <param name="confidence">confidence.</param>
        /// <param name="jurisdiction">jurisdiction.</param>
        /// <param name="matchedAddress">matchedAddress.</param>
        /// <param name="salesTax">salesTax.</param>
        /// <param name="useTax">useTax.</param>
        /// <param name="census">census.</param>
        /// <param name="latLongFields">latLongFields.</param>
        /// <param name="address">address.</param>
        public TaxRateResponse(string objectId = default(string), string vendorName = default(string), string gnisCode = default(string), double confidence = default(double), TaxJurisdiction jurisdiction = default(TaxJurisdiction), TaxRateMatchedAddress matchedAddress = default(TaxRateMatchedAddress), SalesTax salesTax = default(SalesTax), UseTax useTax = default(UseTax), Census census = default(Census), LatLongFields latLongFields = default(LatLongFields), TaxRateMatchedAddress address = default(TaxRateMatchedAddress))
        {
            this.ObjectId = objectId;
            this.VendorName = vendorName;
            this.GnisCode = gnisCode;
            this.Confidence = confidence;
            this.Jurisdiction = jurisdiction;
            this.MatchedAddress = matchedAddress;
            this.SalesTax = salesTax;
            this.UseTax = useTax;
            this.Census = census;
            this.LatLongFields = latLongFields;
            this.Address = address;
        }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets VendorName
        /// </summary>
        [DataMember(Name="vendorName", EmitDefaultValue=false)]
        public string VendorName { get; set; }

        /// <summary>
        /// Gets or Sets GnisCode
        /// </summary>
        [DataMember(Name="gnisCode", EmitDefaultValue=false)]
        public string GnisCode { get; set; }

        /// <summary>
        /// Gets or Sets Confidence
        /// </summary>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public double Confidence { get; set; }

        /// <summary>
        /// Gets or Sets Jurisdiction
        /// </summary>
        [DataMember(Name="jurisdiction", EmitDefaultValue=false)]
        public TaxJurisdiction Jurisdiction { get; set; }

        /// <summary>
        /// Gets or Sets MatchedAddress
        /// </summary>
        [DataMember(Name="matchedAddress", EmitDefaultValue=false)]
        public TaxRateMatchedAddress MatchedAddress { get; set; }

        /// <summary>
        /// Gets or Sets SalesTax
        /// </summary>
        [DataMember(Name="salesTax", EmitDefaultValue=false)]
        public SalesTax SalesTax { get; set; }

        /// <summary>
        /// Gets or Sets UseTax
        /// </summary>
        [DataMember(Name="useTax", EmitDefaultValue=false)]
        public UseTax UseTax { get; set; }

        /// <summary>
        /// Gets or Sets Census
        /// </summary>
        [DataMember(Name="census", EmitDefaultValue=false)]
        public Census Census { get; set; }

        /// <summary>
        /// Gets or Sets LatLongFields
        /// </summary>
        [DataMember(Name="latLongFields", EmitDefaultValue=false)]
        public LatLongFields LatLongFields { get; set; }

        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public TaxRateMatchedAddress Address { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxRateResponse {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  VendorName: ").Append(VendorName).Append("\n");
            sb.Append("  GnisCode: ").Append(GnisCode).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  Jurisdiction: ").Append(Jurisdiction).Append("\n");
            sb.Append("  MatchedAddress: ").Append(MatchedAddress).Append("\n");
            sb.Append("  SalesTax: ").Append(SalesTax).Append("\n");
            sb.Append("  UseTax: ").Append(UseTax).Append("\n");
            sb.Append("  Census: ").Append(Census).Append("\n");
            sb.Append("  LatLongFields: ").Append(LatLongFields).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
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
            return this.Equals(input as TaxRateResponse);
        }

        /// <summary>
        /// Returns true if TaxRateResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxRateResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxRateResponse input)
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
                    this.VendorName == input.VendorName ||
                    (this.VendorName != null &&
                    this.VendorName.Equals(input.VendorName))
                ) && 
                (
                    this.GnisCode == input.GnisCode ||
                    (this.GnisCode != null &&
                    this.GnisCode.Equals(input.GnisCode))
                ) && 
                (
                    this.Confidence == input.Confidence ||
                    (this.Confidence != null &&
                    this.Confidence.Equals(input.Confidence))
                ) && 
                (
                    this.Jurisdiction == input.Jurisdiction ||
                    (this.Jurisdiction != null &&
                    this.Jurisdiction.Equals(input.Jurisdiction))
                ) && 
                (
                    this.MatchedAddress == input.MatchedAddress ||
                    (this.MatchedAddress != null &&
                    this.MatchedAddress.Equals(input.MatchedAddress))
                ) && 
                (
                    this.SalesTax == input.SalesTax ||
                    (this.SalesTax != null &&
                    this.SalesTax.Equals(input.SalesTax))
                ) && 
                (
                    this.UseTax == input.UseTax ||
                    (this.UseTax != null &&
                    this.UseTax.Equals(input.UseTax))
                ) && 
                (
                    this.Census == input.Census ||
                    (this.Census != null &&
                    this.Census.Equals(input.Census))
                ) && 
                (
                    this.LatLongFields == input.LatLongFields ||
                    (this.LatLongFields != null &&
                    this.LatLongFields.Equals(input.LatLongFields))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
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
                if (this.VendorName != null)
                    hashCode = hashCode * 59 + this.VendorName.GetHashCode();
                if (this.GnisCode != null)
                    hashCode = hashCode * 59 + this.GnisCode.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.Jurisdiction != null)
                    hashCode = hashCode * 59 + this.Jurisdiction.GetHashCode();
                if (this.MatchedAddress != null)
                    hashCode = hashCode * 59 + this.MatchedAddress.GetHashCode();
                if (this.SalesTax != null)
                    hashCode = hashCode * 59 + this.SalesTax.GetHashCode();
                if (this.UseTax != null)
                    hashCode = hashCode * 59 + this.UseTax.GetHashCode();
                if (this.Census != null)
                    hashCode = hashCode * 59 + this.Census.GetHashCode();
                if (this.LatLongFields != null)
                    hashCode = hashCode * 59 + this.LatLongFields.GetHashCode();
                if (this.Address != null)
                    hashCode = hashCode * 59 + this.Address.GetHashCode();
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

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
    /// TaxDistrictResponse
    /// </summary>
    [DataContract]
    public partial class TaxDistrictResponse :  IEquatable<TaxDistrictResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxDistrictResponse" /> class.
        /// </summary>
        /// <param name="vendorName">vendorName.</param>
        /// <param name="objectId">objectId.</param>
        /// <param name="confidence">confidence.</param>
        /// <param name="jurisdiction">jurisdiction.</param>
        /// <param name="numOfIpdsFound">numOfIpdsFound.</param>
        /// <param name="ipds">ipds.</param>
        /// <param name="matchedAddress">matchedAddress.</param>
        /// <param name="census">census.</param>
        /// <param name="latLongFields">latLongFields.</param>
        public TaxDistrictResponse(string vendorName = default(string), string objectId = default(string), double confidence = default(double), IPDTaxJurisdiction jurisdiction = default(IPDTaxJurisdiction), int numOfIpdsFound = default(int), List<Ipd> ipds = default(List<Ipd>), TaxRateMatchedAddress matchedAddress = default(TaxRateMatchedAddress), Census census = default(Census), LatLongFields latLongFields = default(LatLongFields))
        {
            this.VendorName = vendorName;
            this.ObjectId = objectId;
            this.Confidence = confidence;
            this.Jurisdiction = jurisdiction;
            this.NumOfIpdsFound = numOfIpdsFound;
            this.Ipds = ipds;
            this.MatchedAddress = matchedAddress;
            this.Census = census;
            this.LatLongFields = latLongFields;
        }

        /// <summary>
        /// Gets or Sets VendorName
        /// </summary>
        [DataMember(Name="vendorName", EmitDefaultValue=false)]
        public string VendorName { get; set; }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Gets or Sets Confidence
        /// </summary>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public double Confidence { get; set; }

        /// <summary>
        /// Gets or Sets Jurisdiction
        /// </summary>
        [DataMember(Name="jurisdiction", EmitDefaultValue=false)]
        public IPDTaxJurisdiction Jurisdiction { get; set; }

        /// <summary>
        /// Gets or Sets NumOfIpdsFound
        /// </summary>
        [DataMember(Name="numOfIpdsFound", EmitDefaultValue=false)]
        public int NumOfIpdsFound { get; set; }

        /// <summary>
        /// Gets or Sets Ipds
        /// </summary>
        [DataMember(Name="ipds", EmitDefaultValue=false)]
        public List<Ipd> Ipds { get; set; }

        /// <summary>
        /// Gets or Sets MatchedAddress
        /// </summary>
        [DataMember(Name="matchedAddress", EmitDefaultValue=false)]
        public TaxRateMatchedAddress MatchedAddress { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxDistrictResponse {\n");
            sb.Append("  VendorName: ").Append(VendorName).Append("\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  Jurisdiction: ").Append(Jurisdiction).Append("\n");
            sb.Append("  NumOfIpdsFound: ").Append(NumOfIpdsFound).Append("\n");
            sb.Append("  Ipds: ").Append(Ipds).Append("\n");
            sb.Append("  MatchedAddress: ").Append(MatchedAddress).Append("\n");
            sb.Append("  Census: ").Append(Census).Append("\n");
            sb.Append("  LatLongFields: ").Append(LatLongFields).Append("\n");
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
            return this.Equals(input as TaxDistrictResponse);
        }

        /// <summary>
        /// Returns true if TaxDistrictResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxDistrictResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxDistrictResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VendorName == input.VendorName ||
                    (this.VendorName != null &&
                    this.VendorName.Equals(input.VendorName))
                ) && 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
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
                    this.NumOfIpdsFound == input.NumOfIpdsFound ||
                    (this.NumOfIpdsFound != null &&
                    this.NumOfIpdsFound.Equals(input.NumOfIpdsFound))
                ) && 
                (
                    this.Ipds == input.Ipds ||
                    this.Ipds != null &&
                    input.Ipds != null &&
                    this.Ipds.SequenceEqual(input.Ipds)
                ) && 
                (
                    this.MatchedAddress == input.MatchedAddress ||
                    (this.MatchedAddress != null &&
                    this.MatchedAddress.Equals(input.MatchedAddress))
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
                if (this.VendorName != null)
                    hashCode = hashCode * 59 + this.VendorName.GetHashCode();
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
                if (this.Confidence != null)
                    hashCode = hashCode * 59 + this.Confidence.GetHashCode();
                if (this.Jurisdiction != null)
                    hashCode = hashCode * 59 + this.Jurisdiction.GetHashCode();
                if (this.NumOfIpdsFound != null)
                    hashCode = hashCode * 59 + this.NumOfIpdsFound.GetHashCode();
                if (this.Ipds != null)
                    hashCode = hashCode * 59 + this.Ipds.GetHashCode();
                if (this.MatchedAddress != null)
                    hashCode = hashCode * 59 + this.MatchedAddress.GetHashCode();
                if (this.Census != null)
                    hashCode = hashCode * 59 + this.Census.GetHashCode();
                if (this.LatLongFields != null)
                    hashCode = hashCode * 59 + this.LatLongFields.GetHashCode();
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

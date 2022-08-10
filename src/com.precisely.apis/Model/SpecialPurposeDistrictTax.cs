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
    /// SpecialPurposeDistrictTax
    /// </summary>
    [DataContract]
    public partial class SpecialPurposeDistrictTax :  IEquatable<SpecialPurposeDistrictTax>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialPurposeDistrictTax" /> class.
        /// </summary>
        /// <param name="districtNumber">districtNumber.</param>
        /// <param name="taxRate">taxRate.</param>
        /// <param name="taxAmount">taxAmount.</param>
        public SpecialPurposeDistrictTax(string districtNumber = default(string), double taxRate = default(double), double taxAmount = default(double))
        {
            this.DistrictNumber = districtNumber;
            this.TaxRate = taxRate;
            this.TaxAmount = taxAmount;
        }

        /// <summary>
        /// Gets or Sets DistrictNumber
        /// </summary>
        [DataMember(Name="districtNumber", EmitDefaultValue=false)]
        public string DistrictNumber { get; set; }

        /// <summary>
        /// Gets or Sets TaxRate
        /// </summary>
        [DataMember(Name="taxRate", EmitDefaultValue=false)]
        public double TaxRate { get; set; }

        /// <summary>
        /// Gets or Sets TaxAmount
        /// </summary>
        [DataMember(Name="taxAmount", EmitDefaultValue=false)]
        public double TaxAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SpecialPurposeDistrictTax {\n");
            sb.Append("  DistrictNumber: ").Append(DistrictNumber).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
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
            return this.Equals(input as SpecialPurposeDistrictTax);
        }

        /// <summary>
        /// Returns true if SpecialPurposeDistrictTax instances are equal
        /// </summary>
        /// <param name="input">Instance of SpecialPurposeDistrictTax to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SpecialPurposeDistrictTax input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.DistrictNumber == input.DistrictNumber ||
                    (this.DistrictNumber != null &&
                    this.DistrictNumber.Equals(input.DistrictNumber))
                ) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
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
                if (this.DistrictNumber != null)
                    hashCode = hashCode * 59 + this.DistrictNumber.GetHashCode();
                if (this.TaxRate != null)
                    hashCode = hashCode * 59 + this.TaxRate.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
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

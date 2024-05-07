/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 18.1.0
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
    /// TaxPlace
    /// </summary>
    [DataContract]
    public partial class TaxPlace :  IEquatable<TaxPlace>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxPlace" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="code">code.</param>
        /// <param name="gnisCode">gnisCode.</param>
        /// <param name="selfCollected">selfCollected.</param>
        /// <param name="classCode">classCode.</param>
        /// <param name="incorporatedFlag">incorporatedFlag.</param>
        /// <param name="lastAnnexedDate">lastAnnexedDate.</param>
        /// <param name="lastUpdatedDate">lastUpdatedDate.</param>
        /// <param name="lastVerifiedDate">lastVerifiedDate.</param>
        public TaxPlace(string name = default(string), string code = default(string), string gnisCode = default(string), bool selfCollected = default(bool), string classCode = default(string), string incorporatedFlag = default(string), string lastAnnexedDate = default(string), string lastUpdatedDate = default(string), string lastVerifiedDate = default(string))
        {
            this.Name = name;
            this.Code = code;
            this.GnisCode = gnisCode;
            this.SelfCollected = selfCollected;
            this.ClassCode = classCode;
            this.IncorporatedFlag = incorporatedFlag;
            this.LastAnnexedDate = lastAnnexedDate;
            this.LastUpdatedDate = lastUpdatedDate;
            this.LastVerifiedDate = lastVerifiedDate;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Code
        /// </summary>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public string Code { get; set; }

        /// <summary>
        /// Gets or Sets GnisCode
        /// </summary>
        [DataMember(Name="gnisCode", EmitDefaultValue=false)]
        public string GnisCode { get; set; }

        /// <summary>
        /// Gets or Sets SelfCollected
        /// </summary>
        [DataMember(Name="selfCollected", EmitDefaultValue=false)]
        public bool SelfCollected { get; set; }

        /// <summary>
        /// Gets or Sets ClassCode
        /// </summary>
        [DataMember(Name="classCode", EmitDefaultValue=false)]
        public string ClassCode { get; set; }

        /// <summary>
        /// Gets or Sets IncorporatedFlag
        /// </summary>
        [DataMember(Name="incorporatedFlag", EmitDefaultValue=false)]
        public string IncorporatedFlag { get; set; }

        /// <summary>
        /// Gets or Sets LastAnnexedDate
        /// </summary>
        [DataMember(Name="lastAnnexedDate", EmitDefaultValue=false)]
        public string LastAnnexedDate { get; set; }

        /// <summary>
        /// Gets or Sets LastUpdatedDate
        /// </summary>
        [DataMember(Name="lastUpdatedDate", EmitDefaultValue=false)]
        public string LastUpdatedDate { get; set; }

        /// <summary>
        /// Gets or Sets LastVerifiedDate
        /// </summary>
        [DataMember(Name="lastVerifiedDate", EmitDefaultValue=false)]
        public string LastVerifiedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxPlace {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  GnisCode: ").Append(GnisCode).Append("\n");
            sb.Append("  SelfCollected: ").Append(SelfCollected).Append("\n");
            sb.Append("  ClassCode: ").Append(ClassCode).Append("\n");
            sb.Append("  IncorporatedFlag: ").Append(IncorporatedFlag).Append("\n");
            sb.Append("  LastAnnexedDate: ").Append(LastAnnexedDate).Append("\n");
            sb.Append("  LastUpdatedDate: ").Append(LastUpdatedDate).Append("\n");
            sb.Append("  LastVerifiedDate: ").Append(LastVerifiedDate).Append("\n");
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
            return this.Equals(input as TaxPlace);
        }

        /// <summary>
        /// Returns true if TaxPlace instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxPlace to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxPlace input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.GnisCode == input.GnisCode ||
                    (this.GnisCode != null &&
                    this.GnisCode.Equals(input.GnisCode))
                ) && 
                (
                    this.SelfCollected == input.SelfCollected ||
                    (this.SelfCollected != null &&
                    this.SelfCollected.Equals(input.SelfCollected))
                ) && 
                (
                    this.ClassCode == input.ClassCode ||
                    (this.ClassCode != null &&
                    this.ClassCode.Equals(input.ClassCode))
                ) && 
                (
                    this.IncorporatedFlag == input.IncorporatedFlag ||
                    (this.IncorporatedFlag != null &&
                    this.IncorporatedFlag.Equals(input.IncorporatedFlag))
                ) && 
                (
                    this.LastAnnexedDate == input.LastAnnexedDate ||
                    (this.LastAnnexedDate != null &&
                    this.LastAnnexedDate.Equals(input.LastAnnexedDate))
                ) && 
                (
                    this.LastUpdatedDate == input.LastUpdatedDate ||
                    (this.LastUpdatedDate != null &&
                    this.LastUpdatedDate.Equals(input.LastUpdatedDate))
                ) && 
                (
                    this.LastVerifiedDate == input.LastVerifiedDate ||
                    (this.LastVerifiedDate != null &&
                    this.LastVerifiedDate.Equals(input.LastVerifiedDate))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.GnisCode != null)
                    hashCode = hashCode * 59 + this.GnisCode.GetHashCode();
                if (this.SelfCollected != null)
                    hashCode = hashCode * 59 + this.SelfCollected.GetHashCode();
                if (this.ClassCode != null)
                    hashCode = hashCode * 59 + this.ClassCode.GetHashCode();
                if (this.IncorporatedFlag != null)
                    hashCode = hashCode * 59 + this.IncorporatedFlag.GetHashCode();
                if (this.LastAnnexedDate != null)
                    hashCode = hashCode * 59 + this.LastAnnexedDate.GetHashCode();
                if (this.LastUpdatedDate != null)
                    hashCode = hashCode * 59 + this.LastUpdatedDate.GetHashCode();
                if (this.LastVerifiedDate != null)
                    hashCode = hashCode * 59 + this.LastVerifiedDate.GetHashCode();
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

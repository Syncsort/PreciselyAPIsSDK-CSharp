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
    /// OrganizationType
    /// </summary>
    [DataContract]
    public partial class OrganizationType :  IEquatable<OrganizationType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationType" /> class.
        /// </summary>
        /// <param name="naicsCode">naicsCode.</param>
        /// <param name="isicCode">isicCode.</param>
        /// <param name="value">value.</param>
        public OrganizationType(string naicsCode = default(string), string isicCode = default(string), string value = default(string))
        {
            this.NaicsCode = naicsCode;
            this.IsicCode = isicCode;
            this.Value = value;
        }

        /// <summary>
        /// Gets or Sets NaicsCode
        /// </summary>
        [DataMember(Name="naicsCode", EmitDefaultValue=false)]
        public string NaicsCode { get; set; }

        /// <summary>
        /// Gets or Sets IsicCode
        /// </summary>
        [DataMember(Name="isicCode", EmitDefaultValue=false)]
        public string IsicCode { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrganizationType {\n");
            sb.Append("  NaicsCode: ").Append(NaicsCode).Append("\n");
            sb.Append("  IsicCode: ").Append(IsicCode).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
            return this.Equals(input as OrganizationType);
        }

        /// <summary>
        /// Returns true if OrganizationType instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationType input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NaicsCode == input.NaicsCode ||
                    (this.NaicsCode != null &&
                    this.NaicsCode.Equals(input.NaicsCode))
                ) && 
                (
                    this.IsicCode == input.IsicCode ||
                    (this.IsicCode != null &&
                    this.IsicCode.Equals(input.IsicCode))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.NaicsCode != null)
                    hashCode = hashCode * 59 + this.NaicsCode.GetHashCode();
                if (this.IsicCode != null)
                    hashCode = hashCode * 59 + this.IsicCode.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
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

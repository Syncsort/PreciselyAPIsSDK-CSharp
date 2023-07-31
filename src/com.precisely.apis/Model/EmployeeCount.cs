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
    /// EmployeeCount
    /// </summary>
    [DataContract]
    public partial class EmployeeCount :  IEquatable<EmployeeCount>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeCount" /> class.
        /// </summary>
        /// <param name="inLocalBranch">inLocalBranch.</param>
        /// <param name="inOrganization">inOrganization.</param>
        public EmployeeCount(string inLocalBranch = default(string), string inOrganization = default(string))
        {
            this.InLocalBranch = inLocalBranch;
            this.InOrganization = inOrganization;
        }

        /// <summary>
        /// Gets or Sets InLocalBranch
        /// </summary>
        [DataMember(Name="inLocalBranch", EmitDefaultValue=false)]
        public string InLocalBranch { get; set; }

        /// <summary>
        /// Gets or Sets InOrganization
        /// </summary>
        [DataMember(Name="inOrganization", EmitDefaultValue=false)]
        public string InOrganization { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmployeeCount {\n");
            sb.Append("  InLocalBranch: ").Append(InLocalBranch).Append("\n");
            sb.Append("  InOrganization: ").Append(InOrganization).Append("\n");
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
            return this.Equals(input as EmployeeCount);
        }

        /// <summary>
        /// Returns true if EmployeeCount instances are equal
        /// </summary>
        /// <param name="input">Instance of EmployeeCount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmployeeCount input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InLocalBranch == input.InLocalBranch ||
                    (this.InLocalBranch != null &&
                    this.InLocalBranch.Equals(input.InLocalBranch))
                ) && 
                (
                    this.InOrganization == input.InOrganization ||
                    (this.InOrganization != null &&
                    this.InOrganization.Equals(input.InOrganization))
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
                if (this.InLocalBranch != null)
                    hashCode = hashCode * 59 + this.InLocalBranch.GetHashCode();
                if (this.InOrganization != null)
                    hashCode = hashCode * 59 + this.InOrganization.GetHashCode();
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

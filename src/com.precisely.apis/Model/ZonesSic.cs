/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 17.1.0
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
    /// ZonesSic
    /// </summary>
    [DataContract]
    public partial class ZonesSic :  IEquatable<ZonesSic>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZonesSic" /> class.
        /// </summary>
        /// <param name="businessLine">businessLine.</param>
        /// <param name="sicCode">sicCode.</param>
        /// <param name="sicCodeDescription">sicCodeDescription.</param>
        /// <param name="primarySicCode">primarySicCode.</param>
        public ZonesSic(string businessLine = default(string), string sicCode = default(string), string sicCodeDescription = default(string), string primarySicCode = default(string))
        {
            this.BusinessLine = businessLine;
            this.SicCode = sicCode;
            this.SicCodeDescription = sicCodeDescription;
            this.PrimarySicCode = primarySicCode;
        }

        /// <summary>
        /// Gets or Sets BusinessLine
        /// </summary>
        [DataMember(Name="businessLine", EmitDefaultValue=false)]
        public string BusinessLine { get; set; }

        /// <summary>
        /// Gets or Sets SicCode
        /// </summary>
        [DataMember(Name="sicCode", EmitDefaultValue=false)]
        public string SicCode { get; set; }

        /// <summary>
        /// Gets or Sets SicCodeDescription
        /// </summary>
        [DataMember(Name="sicCodeDescription", EmitDefaultValue=false)]
        public string SicCodeDescription { get; set; }

        /// <summary>
        /// Gets or Sets PrimarySicCode
        /// </summary>
        [DataMember(Name="primarySicCode", EmitDefaultValue=false)]
        public string PrimarySicCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ZonesSic {\n");
            sb.Append("  BusinessLine: ").Append(BusinessLine).Append("\n");
            sb.Append("  SicCode: ").Append(SicCode).Append("\n");
            sb.Append("  SicCodeDescription: ").Append(SicCodeDescription).Append("\n");
            sb.Append("  PrimarySicCode: ").Append(PrimarySicCode).Append("\n");
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
            return this.Equals(input as ZonesSic);
        }

        /// <summary>
        /// Returns true if ZonesSic instances are equal
        /// </summary>
        /// <param name="input">Instance of ZonesSic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZonesSic input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BusinessLine == input.BusinessLine ||
                    (this.BusinessLine != null &&
                    this.BusinessLine.Equals(input.BusinessLine))
                ) && 
                (
                    this.SicCode == input.SicCode ||
                    (this.SicCode != null &&
                    this.SicCode.Equals(input.SicCode))
                ) && 
                (
                    this.SicCodeDescription == input.SicCodeDescription ||
                    (this.SicCodeDescription != null &&
                    this.SicCodeDescription.Equals(input.SicCodeDescription))
                ) && 
                (
                    this.PrimarySicCode == input.PrimarySicCode ||
                    (this.PrimarySicCode != null &&
                    this.PrimarySicCode.Equals(input.PrimarySicCode))
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
                if (this.BusinessLine != null)
                    hashCode = hashCode * 59 + this.BusinessLine.GetHashCode();
                if (this.SicCode != null)
                    hashCode = hashCode * 59 + this.SicCode.GetHashCode();
                if (this.SicCodeDescription != null)
                    hashCode = hashCode * 59 + this.SicCodeDescription.GetHashCode();
                if (this.PrimarySicCode != null)
                    hashCode = hashCode * 59 + this.PrimarySicCode.GetHashCode();
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

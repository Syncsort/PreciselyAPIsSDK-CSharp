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
    /// HouseholdsTheme
    /// </summary>
    [DataContract]
    public partial class HouseholdsTheme :  IEquatable<HouseholdsTheme>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HouseholdsTheme" /> class.
        /// </summary>
        /// <param name="boundaryRef">boundaryRef.</param>
        /// <param name="individualValueVariable">individualValueVariable.</param>
        /// <param name="rangeVariable">rangeVariable.</param>
        public HouseholdsTheme(string boundaryRef = default(string), List<IndividualValueVariable> individualValueVariable = default(List<IndividualValueVariable>), List<RangeVariable> rangeVariable = default(List<RangeVariable>))
        {
            this.BoundaryRef = boundaryRef;
            this.IndividualValueVariable = individualValueVariable;
            this.RangeVariable = rangeVariable;
        }

        /// <summary>
        /// Gets or Sets BoundaryRef
        /// </summary>
        [DataMember(Name="boundaryRef", EmitDefaultValue=false)]
        public string BoundaryRef { get; set; }

        /// <summary>
        /// Gets or Sets IndividualValueVariable
        /// </summary>
        [DataMember(Name="individualValueVariable", EmitDefaultValue=false)]
        public List<IndividualValueVariable> IndividualValueVariable { get; set; }

        /// <summary>
        /// Gets or Sets RangeVariable
        /// </summary>
        [DataMember(Name="rangeVariable", EmitDefaultValue=false)]
        public List<RangeVariable> RangeVariable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HouseholdsTheme {\n");
            sb.Append("  BoundaryRef: ").Append(BoundaryRef).Append("\n");
            sb.Append("  IndividualValueVariable: ").Append(IndividualValueVariable).Append("\n");
            sb.Append("  RangeVariable: ").Append(RangeVariable).Append("\n");
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
            return this.Equals(input as HouseholdsTheme);
        }

        /// <summary>
        /// Returns true if HouseholdsTheme instances are equal
        /// </summary>
        /// <param name="input">Instance of HouseholdsTheme to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HouseholdsTheme input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BoundaryRef == input.BoundaryRef ||
                    (this.BoundaryRef != null &&
                    this.BoundaryRef.Equals(input.BoundaryRef))
                ) && 
                (
                    this.IndividualValueVariable == input.IndividualValueVariable ||
                    this.IndividualValueVariable != null &&
                    input.IndividualValueVariable != null &&
                    this.IndividualValueVariable.SequenceEqual(input.IndividualValueVariable)
                ) && 
                (
                    this.RangeVariable == input.RangeVariable ||
                    this.RangeVariable != null &&
                    input.RangeVariable != null &&
                    this.RangeVariable.SequenceEqual(input.RangeVariable)
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
                if (this.BoundaryRef != null)
                    hashCode = hashCode * 59 + this.BoundaryRef.GetHashCode();
                if (this.IndividualValueVariable != null)
                    hashCode = hashCode * 59 + this.IndividualValueVariable.GetHashCode();
                if (this.RangeVariable != null)
                    hashCode = hashCode * 59 + this.RangeVariable.GetHashCode();
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

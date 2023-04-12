/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 15.0.0
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
    /// TravelCostMatrixResponse
    /// </summary>
    [DataContract]
    public partial class TravelCostMatrixResponse :  IEquatable<TravelCostMatrixResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TravelCostMatrixResponse" /> class.
        /// </summary>
        /// <param name="matrix">matrix.</param>
        public TravelCostMatrixResponse(List<Matrix> matrix = default(List<Matrix>))
        {
            this.Matrix = matrix;
        }

        /// <summary>
        /// Gets or Sets Matrix
        /// </summary>
        [DataMember(Name="matrix", EmitDefaultValue=false)]
        public List<Matrix> Matrix { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TravelCostMatrixResponse {\n");
            sb.Append("  Matrix: ").Append(Matrix).Append("\n");
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
            return this.Equals(input as TravelCostMatrixResponse);
        }

        /// <summary>
        /// Returns true if TravelCostMatrixResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TravelCostMatrixResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TravelCostMatrixResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Matrix == input.Matrix ||
                    this.Matrix != null &&
                    input.Matrix != null &&
                    this.Matrix.SequenceEqual(input.Matrix)
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
                if (this.Matrix != null)
                    hashCode = hashCode * 59 + this.Matrix.GetHashCode();
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

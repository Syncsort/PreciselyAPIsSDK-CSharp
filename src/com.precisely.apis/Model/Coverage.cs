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
    /// Coverage
    /// </summary>
    [DataContract]
    public partial class Coverage :  IEquatable<Coverage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Coverage" /> class.
        /// </summary>
        /// <param name="area">area.</param>
        /// <param name="comments">comments.</param>
        /// <param name="exceptions">exceptions.</param>
        public Coverage(string area = default(string), string comments = default(string), string exceptions = default(string))
        {
            this.Area = area;
            this.Comments = comments;
            this.Exceptions = exceptions;
        }

        /// <summary>
        /// Gets or Sets Area
        /// </summary>
        [DataMember(Name="area", EmitDefaultValue=false)]
        public string Area { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets Exceptions
        /// </summary>
        [DataMember(Name="exceptions", EmitDefaultValue=false)]
        public string Exceptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Coverage {\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Exceptions: ").Append(Exceptions).Append("\n");
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
            return this.Equals(input as Coverage);
        }

        /// <summary>
        /// Returns true if Coverage instances are equal
        /// </summary>
        /// <param name="input">Instance of Coverage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Coverage input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Area == input.Area ||
                    (this.Area != null &&
                    this.Area.Equals(input.Area))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.Exceptions == input.Exceptions ||
                    (this.Exceptions != null &&
                    this.Exceptions.Equals(input.Exceptions))
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
                if (this.Area != null)
                    hashCode = hashCode * 59 + this.Area.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.Exceptions != null)
                    hashCode = hashCode * 59 + this.Exceptions.GetHashCode();
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

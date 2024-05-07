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
    /// PropertyInfoResponses
    /// </summary>
    [DataContract]
    public partial class PropertyInfoResponses :  IEquatable<PropertyInfoResponses>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyInfoResponses" /> class.
        /// </summary>
        /// <param name="propertyInfoResponses">propertyInfoResponses.</param>
        public PropertyInfoResponses(List<PropertyInfoResponse> propertyInfoResponses = default(List<PropertyInfoResponse>))
        {
            this._PropertyInfoResponses = propertyInfoResponses;
        }

        /// <summary>
        /// Gets or Sets _PropertyInfoResponses
        /// </summary>
        [DataMember(Name="propertyInfoResponses", EmitDefaultValue=false)]
        public List<PropertyInfoResponse> _PropertyInfoResponses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PropertyInfoResponses {\n");
            sb.Append("  _PropertyInfoResponses: ").Append(_PropertyInfoResponses).Append("\n");
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
            return this.Equals(input as PropertyInfoResponses);
        }

        /// <summary>
        /// Returns true if PropertyInfoResponses instances are equal
        /// </summary>
        /// <param name="input">Instance of PropertyInfoResponses to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PropertyInfoResponses input)
        {
            if (input == null)
                return false;

            return 
                (
                    this._PropertyInfoResponses == input._PropertyInfoResponses ||
                    this._PropertyInfoResponses != null &&
                    input._PropertyInfoResponses != null &&
                    this._PropertyInfoResponses.SequenceEqual(input._PropertyInfoResponses)
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
                if (this._PropertyInfoResponses != null)
                    hashCode = hashCode * 59 + this._PropertyInfoResponses.GetHashCode();
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

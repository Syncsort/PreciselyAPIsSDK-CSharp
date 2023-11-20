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
    /// Proxy
    /// </summary>
    [DataContract]
    public partial class Proxy :  IEquatable<Proxy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Proxy" /> class.
        /// </summary>
        /// <param name="anonymizerStatus">anonymizerStatus.</param>
        /// <param name="level">level.</param>
        /// <param name="lastDetected">lastDetected.</param>
        /// <param name="type">type.</param>
        public Proxy(string anonymizerStatus = default(string), string level = default(string), string lastDetected = default(string), string type = default(string))
        {
            this.AnonymizerStatus = anonymizerStatus;
            this.Level = level;
            this.LastDetected = lastDetected;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets AnonymizerStatus
        /// </summary>
        [DataMember(Name="anonymizerStatus", EmitDefaultValue=false)]
        public string AnonymizerStatus { get; set; }

        /// <summary>
        /// Gets or Sets Level
        /// </summary>
        [DataMember(Name="level", EmitDefaultValue=false)]
        public string Level { get; set; }

        /// <summary>
        /// Gets or Sets LastDetected
        /// </summary>
        [DataMember(Name="lastDetected", EmitDefaultValue=false)]
        public string LastDetected { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Proxy {\n");
            sb.Append("  AnonymizerStatus: ").Append(AnonymizerStatus).Append("\n");
            sb.Append("  Level: ").Append(Level).Append("\n");
            sb.Append("  LastDetected: ").Append(LastDetected).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as Proxy);
        }

        /// <summary>
        /// Returns true if Proxy instances are equal
        /// </summary>
        /// <param name="input">Instance of Proxy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Proxy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AnonymizerStatus == input.AnonymizerStatus ||
                    (this.AnonymizerStatus != null &&
                    this.AnonymizerStatus.Equals(input.AnonymizerStatus))
                ) && 
                (
                    this.Level == input.Level ||
                    (this.Level != null &&
                    this.Level.Equals(input.Level))
                ) && 
                (
                    this.LastDetected == input.LastDetected ||
                    (this.LastDetected != null &&
                    this.LastDetected.Equals(input.LastDetected))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.AnonymizerStatus != null)
                    hashCode = hashCode * 59 + this.AnonymizerStatus.GetHashCode();
                if (this.Level != null)
                    hashCode = hashCode * 59 + this.Level.GetHashCode();
                if (this.LastDetected != null)
                    hashCode = hashCode * 59 + this.LastDetected.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
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

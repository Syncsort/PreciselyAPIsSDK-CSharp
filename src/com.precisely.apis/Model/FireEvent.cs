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
    /// FireEvent
    /// </summary>
    [DataContract]
    public partial class FireEvent :  IEquatable<FireEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FireEvent" /> class.
        /// </summary>
        /// <param name="fireStartDate">fireStartDate.</param>
        /// <param name="fireEndDate">fireEndDate.</param>
        /// <param name="fireName">fireName.</param>
        /// <param name="area">area.</param>
        /// <param name="agency">agency.</param>
        public FireEvent(string fireStartDate = default(string), string fireEndDate = default(string), string fireName = default(string), Area area = default(Area), string agency = default(string))
        {
            this.FireStartDate = fireStartDate;
            this.FireEndDate = fireEndDate;
            this.FireName = fireName;
            this.Area = area;
            this.Agency = agency;
        }

        /// <summary>
        /// Gets or Sets FireStartDate
        /// </summary>
        [DataMember(Name="fireStartDate", EmitDefaultValue=false)]
        public string FireStartDate { get; set; }

        /// <summary>
        /// Gets or Sets FireEndDate
        /// </summary>
        [DataMember(Name="fireEndDate", EmitDefaultValue=false)]
        public string FireEndDate { get; set; }

        /// <summary>
        /// Gets or Sets FireName
        /// </summary>
        [DataMember(Name="fireName", EmitDefaultValue=false)]
        public string FireName { get; set; }

        /// <summary>
        /// Gets or Sets Area
        /// </summary>
        [DataMember(Name="area", EmitDefaultValue=false)]
        public Area Area { get; set; }

        /// <summary>
        /// Gets or Sets Agency
        /// </summary>
        [DataMember(Name="agency", EmitDefaultValue=false)]
        public string Agency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FireEvent {\n");
            sb.Append("  FireStartDate: ").Append(FireStartDate).Append("\n");
            sb.Append("  FireEndDate: ").Append(FireEndDate).Append("\n");
            sb.Append("  FireName: ").Append(FireName).Append("\n");
            sb.Append("  Area: ").Append(Area).Append("\n");
            sb.Append("  Agency: ").Append(Agency).Append("\n");
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
            return this.Equals(input as FireEvent);
        }

        /// <summary>
        /// Returns true if FireEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of FireEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FireEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FireStartDate == input.FireStartDate ||
                    (this.FireStartDate != null &&
                    this.FireStartDate.Equals(input.FireStartDate))
                ) && 
                (
                    this.FireEndDate == input.FireEndDate ||
                    (this.FireEndDate != null &&
                    this.FireEndDate.Equals(input.FireEndDate))
                ) && 
                (
                    this.FireName == input.FireName ||
                    (this.FireName != null &&
                    this.FireName.Equals(input.FireName))
                ) && 
                (
                    this.Area == input.Area ||
                    (this.Area != null &&
                    this.Area.Equals(input.Area))
                ) && 
                (
                    this.Agency == input.Agency ||
                    (this.Agency != null &&
                    this.Agency.Equals(input.Agency))
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
                if (this.FireStartDate != null)
                    hashCode = hashCode * 59 + this.FireStartDate.GetHashCode();
                if (this.FireEndDate != null)
                    hashCode = hashCode * 59 + this.FireEndDate.GetHashCode();
                if (this.FireName != null)
                    hashCode = hashCode * 59 + this.FireName.GetHashCode();
                if (this.Area != null)
                    hashCode = hashCode * 59 + this.Area.GetHashCode();
                if (this.Agency != null)
                    hashCode = hashCode * 59 + this.Agency.GetHashCode();
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

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
    /// CrimeRiskByLocationBatchRequest
    /// </summary>
    [DataContract]
    public partial class CrimeRiskByLocationBatchRequest :  IEquatable<CrimeRiskByLocationBatchRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CrimeRiskByLocationBatchRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CrimeRiskByLocationBatchRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CrimeRiskByLocationBatchRequest" /> class.
        /// </summary>
        /// <param name="locations">locations (required).</param>
        /// <param name="preferences">preferences.</param>
        public CrimeRiskByLocationBatchRequest(List<RiskLocations> locations = default(List<RiskLocations>), CrimeRiskPreferences preferences = default(CrimeRiskPreferences))
        {
            // to ensure "locations" is required (not null)
            if (locations == null)
            {
                throw new InvalidDataException("locations is a required property for CrimeRiskByLocationBatchRequest and cannot be null");
            }
            else
            {
                this.Locations = locations;
            }

            this.Preferences = preferences;
        }

        /// <summary>
        /// Gets or Sets Locations
        /// </summary>
        [DataMember(Name="locations", EmitDefaultValue=true)]
        public List<RiskLocations> Locations { get; set; }

        /// <summary>
        /// Gets or Sets Preferences
        /// </summary>
        [DataMember(Name="preferences", EmitDefaultValue=false)]
        public CrimeRiskPreferences Preferences { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CrimeRiskByLocationBatchRequest {\n");
            sb.Append("  Locations: ").Append(Locations).Append("\n");
            sb.Append("  Preferences: ").Append(Preferences).Append("\n");
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
            return this.Equals(input as CrimeRiskByLocationBatchRequest);
        }

        /// <summary>
        /// Returns true if CrimeRiskByLocationBatchRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CrimeRiskByLocationBatchRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CrimeRiskByLocationBatchRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Locations == input.Locations ||
                    this.Locations != null &&
                    input.Locations != null &&
                    this.Locations.SequenceEqual(input.Locations)
                ) && 
                (
                    this.Preferences == input.Preferences ||
                    (this.Preferences != null &&
                    this.Preferences.Equals(input.Preferences))
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
                if (this.Locations != null)
                    hashCode = hashCode * 59 + this.Locations.GetHashCode();
                if (this.Preferences != null)
                    hashCode = hashCode * 59 + this.Preferences.GetHashCode();
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

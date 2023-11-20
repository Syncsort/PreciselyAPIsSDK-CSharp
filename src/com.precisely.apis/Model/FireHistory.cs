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
    /// FireHistory
    /// </summary>
    [DataContract]
    public partial class FireHistory :  IEquatable<FireHistory>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FireHistory" /> class.
        /// </summary>
        /// <param name="stateCode">stateCode.</param>
        /// <param name="postCode">postCode.</param>
        /// <param name="events">events.</param>
        public FireHistory(string stateCode = default(string), string postCode = default(string), FireEventsResponse events = default(FireEventsResponse))
        {
            this.StateCode = stateCode;
            this.PostCode = postCode;
            this.Events = events;
        }

        /// <summary>
        /// Gets or Sets StateCode
        /// </summary>
        [DataMember(Name="stateCode", EmitDefaultValue=false)]
        public string StateCode { get; set; }

        /// <summary>
        /// Gets or Sets PostCode
        /// </summary>
        [DataMember(Name="postCode", EmitDefaultValue=false)]
        public string PostCode { get; set; }

        /// <summary>
        /// Gets or Sets Events
        /// </summary>
        [DataMember(Name="events", EmitDefaultValue=false)]
        public FireEventsResponse Events { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FireHistory {\n");
            sb.Append("  StateCode: ").Append(StateCode).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
            sb.Append("  Events: ").Append(Events).Append("\n");
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
            return this.Equals(input as FireHistory);
        }

        /// <summary>
        /// Returns true if FireHistory instances are equal
        /// </summary>
        /// <param name="input">Instance of FireHistory to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FireHistory input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StateCode == input.StateCode ||
                    (this.StateCode != null &&
                    this.StateCode.Equals(input.StateCode))
                ) && 
                (
                    this.PostCode == input.PostCode ||
                    (this.PostCode != null &&
                    this.PostCode.Equals(input.PostCode))
                ) && 
                (
                    this.Events == input.Events ||
                    (this.Events != null &&
                    this.Events.Equals(input.Events))
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
                if (this.StateCode != null)
                    hashCode = hashCode * 59 + this.StateCode.GetHashCode();
                if (this.PostCode != null)
                    hashCode = hashCode * 59 + this.PostCode.GetHashCode();
                if (this.Events != null)
                    hashCode = hashCode * 59 + this.Events.GetHashCode();
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

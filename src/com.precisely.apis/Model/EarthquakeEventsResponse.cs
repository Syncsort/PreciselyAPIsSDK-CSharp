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
    /// EarthquakeEventsResponse
    /// </summary>
    [DataContract]
    public partial class EarthquakeEventsResponse :  IEquatable<EarthquakeEventsResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EarthquakeEventsResponse" /> class.
        /// </summary>
        /// <param name="earthuakeEvents">earthuakeEvents.</param>
        /// <param name="_event">_event.</param>
        public EarthquakeEventsResponse(List<EarthquakeEvent> earthuakeEvents = default(List<EarthquakeEvent>), List<EarthquakeEvent> _event = default(List<EarthquakeEvent>))
        {
            this.EarthuakeEvents = earthuakeEvents;
            this.Event = _event;
        }

        /// <summary>
        /// Gets or Sets EarthuakeEvents
        /// </summary>
        [DataMember(Name="earthuakeEvents", EmitDefaultValue=false)]
        public List<EarthquakeEvent> EarthuakeEvents { get; set; }

        /// <summary>
        /// Gets or Sets Event
        /// </summary>
        [DataMember(Name="event", EmitDefaultValue=false)]
        public List<EarthquakeEvent> Event { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EarthquakeEventsResponse {\n");
            sb.Append("  EarthuakeEvents: ").Append(EarthuakeEvents).Append("\n");
            sb.Append("  Event: ").Append(Event).Append("\n");
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
            return this.Equals(input as EarthquakeEventsResponse);
        }

        /// <summary>
        /// Returns true if EarthquakeEventsResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of EarthquakeEventsResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EarthquakeEventsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EarthuakeEvents == input.EarthuakeEvents ||
                    this.EarthuakeEvents != null &&
                    input.EarthuakeEvents != null &&
                    this.EarthuakeEvents.SequenceEqual(input.EarthuakeEvents)
                ) && 
                (
                    this.Event == input.Event ||
                    this.Event != null &&
                    input.Event != null &&
                    this.Event.SequenceEqual(input.Event)
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
                if (this.EarthuakeEvents != null)
                    hashCode = hashCode * 59 + this.EarthuakeEvents.GetHashCode();
                if (this.Event != null)
                    hashCode = hashCode * 59 + this.Event.GetHashCode();
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

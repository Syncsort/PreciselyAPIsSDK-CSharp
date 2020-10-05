/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 9.5.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace com.precisely.apis.Model
{
    /// <summary>
    /// TimezoneLocation
    /// </summary>
    [DataContract]
    public partial class TimezoneLocation :  IEquatable<TimezoneLocation>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TimezoneLocation" /> class.
        /// </summary>
        /// <param name="ObjectId">ObjectId.</param>
        /// <param name="TimezoneName">TimezoneName.</param>
        /// <param name="ZoneType">ZoneType.</param>
        /// <param name="UtcOffset">UtcOffset.</param>
        /// <param name="DstOffset">DstOffset.</param>
        /// <param name="Timestamp">Timestamp.</param>
        public TimezoneLocation(string ObjectId = null, string TimezoneName = null, string ZoneType = null, long? UtcOffset = null, long? DstOffset = null, long? Timestamp = null)
        {
            this.ObjectId = ObjectId;
            this.TimezoneName = TimezoneName;
            this.ZoneType = ZoneType;
            this.UtcOffset = UtcOffset;
            this.DstOffset = DstOffset;
            this.Timestamp = Timestamp;
        }
        
        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }
        /// <summary>
        /// Gets or Sets TimezoneName
        /// </summary>
        [DataMember(Name="timezoneName", EmitDefaultValue=false)]
        public string TimezoneName { get; set; }
        /// <summary>
        /// Gets or Sets ZoneType
        /// </summary>
        [DataMember(Name="zoneType", EmitDefaultValue=false)]
        public string ZoneType { get; set; }
        /// <summary>
        /// Gets or Sets UtcOffset
        /// </summary>
        [DataMember(Name="utcOffset", EmitDefaultValue=false)]
        public long? UtcOffset { get; set; }
        /// <summary>
        /// Gets or Sets DstOffset
        /// </summary>
        [DataMember(Name="dstOffset", EmitDefaultValue=false)]
        public long? DstOffset { get; set; }
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public long? Timestamp { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TimezoneLocation {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  TimezoneName: ").Append(TimezoneName).Append("\n");
            sb.Append("  ZoneType: ").Append(ZoneType).Append("\n");
            sb.Append("  UtcOffset: ").Append(UtcOffset).Append("\n");
            sb.Append("  DstOffset: ").Append(DstOffset).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as TimezoneLocation);
        }

        /// <summary>
        /// Returns true if TimezoneLocation instances are equal
        /// </summary>
        /// <param name="other">Instance of TimezoneLocation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TimezoneLocation other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ObjectId == other.ObjectId ||
                    this.ObjectId != null &&
                    this.ObjectId.Equals(other.ObjectId)
                ) && 
                (
                    this.TimezoneName == other.TimezoneName ||
                    this.TimezoneName != null &&
                    this.TimezoneName.Equals(other.TimezoneName)
                ) && 
                (
                    this.ZoneType == other.ZoneType ||
                    this.ZoneType != null &&
                    this.ZoneType.Equals(other.ZoneType)
                ) && 
                (
                    this.UtcOffset == other.UtcOffset ||
                    this.UtcOffset != null &&
                    this.UtcOffset.Equals(other.UtcOffset)
                ) && 
                (
                    this.DstOffset == other.DstOffset ||
                    this.DstOffset != null &&
                    this.DstOffset.Equals(other.DstOffset)
                ) && 
                (
                    this.Timestamp == other.Timestamp ||
                    this.Timestamp != null &&
                    this.Timestamp.Equals(other.Timestamp)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ObjectId != null)
                    hash = hash * 59 + this.ObjectId.GetHashCode();
                if (this.TimezoneName != null)
                    hash = hash * 59 + this.TimezoneName.GetHashCode();
                if (this.ZoneType != null)
                    hash = hash * 59 + this.ZoneType.GetHashCode();
                if (this.UtcOffset != null)
                    hash = hash * 59 + this.UtcOffset.GetHashCode();
                if (this.DstOffset != null)
                    hash = hash * 59 + this.DstOffset.GetHashCode();
                if (this.Timestamp != null)
                    hash = hash * 59 + this.Timestamp.GetHashCode();
                return hash;
            }
        }
    }

}

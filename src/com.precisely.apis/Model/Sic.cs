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
    /// Sic
    /// </summary>
    [DataContract]
    public partial class Sic :  IEquatable<Sic>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Sic" /> class.
        /// </summary>
        /// <param name="BusinessLine">BusinessLine.</param>
        /// <param name="SicCode">SicCode.</param>
        /// <param name="SicCodeDescription">SicCodeDescription.</param>
        /// <param name="PrimarySicCode">PrimarySicCode.</param>
        /// <param name="SecondarySicCode">SecondarySicCode.</param>
        public Sic(string BusinessLine = null, string SicCode = null, string SicCodeDescription = null, string PrimarySicCode = null, string SecondarySicCode = null)
        {
            this.BusinessLine = BusinessLine;
            this.SicCode = SicCode;
            this.SicCodeDescription = SicCodeDescription;
            this.PrimarySicCode = PrimarySicCode;
            this.SecondarySicCode = SecondarySicCode;
        }
        
        /// <summary>
        /// Gets or Sets BusinessLine
        /// </summary>
        [DataMember(Name="businessLine", EmitDefaultValue=false)]
        public string BusinessLine { get; set; }
        /// <summary>
        /// Gets or Sets SicCode
        /// </summary>
        [DataMember(Name="sicCode", EmitDefaultValue=false)]
        public string SicCode { get; set; }
        /// <summary>
        /// Gets or Sets SicCodeDescription
        /// </summary>
        [DataMember(Name="sicCodeDescription", EmitDefaultValue=false)]
        public string SicCodeDescription { get; set; }
        /// <summary>
        /// Gets or Sets PrimarySicCode
        /// </summary>
        [DataMember(Name="primarySicCode", EmitDefaultValue=false)]
        public string PrimarySicCode { get; set; }
        /// <summary>
        /// Gets or Sets SecondarySicCode
        /// </summary>
        [DataMember(Name="secondarySicCode", EmitDefaultValue=false)]
        public string SecondarySicCode { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Sic {\n");
            sb.Append("  BusinessLine: ").Append(BusinessLine).Append("\n");
            sb.Append("  SicCode: ").Append(SicCode).Append("\n");
            sb.Append("  SicCodeDescription: ").Append(SicCodeDescription).Append("\n");
            sb.Append("  PrimarySicCode: ").Append(PrimarySicCode).Append("\n");
            sb.Append("  SecondarySicCode: ").Append(SecondarySicCode).Append("\n");
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
            return this.Equals(obj as Sic);
        }

        /// <summary>
        /// Returns true if Sic instances are equal
        /// </summary>
        /// <param name="other">Instance of Sic to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Sic other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BusinessLine == other.BusinessLine ||
                    this.BusinessLine != null &&
                    this.BusinessLine.Equals(other.BusinessLine)
                ) && 
                (
                    this.SicCode == other.SicCode ||
                    this.SicCode != null &&
                    this.SicCode.Equals(other.SicCode)
                ) && 
                (
                    this.SicCodeDescription == other.SicCodeDescription ||
                    this.SicCodeDescription != null &&
                    this.SicCodeDescription.Equals(other.SicCodeDescription)
                ) && 
                (
                    this.PrimarySicCode == other.PrimarySicCode ||
                    this.PrimarySicCode != null &&
                    this.PrimarySicCode.Equals(other.PrimarySicCode)
                ) && 
                (
                    this.SecondarySicCode == other.SecondarySicCode ||
                    this.SecondarySicCode != null &&
                    this.SecondarySicCode.Equals(other.SecondarySicCode)
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
                if (this.BusinessLine != null)
                    hash = hash * 59 + this.BusinessLine.GetHashCode();
                if (this.SicCode != null)
                    hash = hash * 59 + this.SicCode.GetHashCode();
                if (this.SicCodeDescription != null)
                    hash = hash * 59 + this.SicCodeDescription.GetHashCode();
                if (this.PrimarySicCode != null)
                    hash = hash * 59 + this.PrimarySicCode.GetHashCode();
                if (this.SecondarySicCode != null)
                    hash = hash * 59 + this.SecondarySicCode.GetHashCode();
                return hash;
            }
        }
    }

}

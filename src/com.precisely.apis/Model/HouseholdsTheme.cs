/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.7.0
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
    /// HouseholdsTheme
    /// </summary>
    [DataContract]
    public partial class HouseholdsTheme :  IEquatable<HouseholdsTheme>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HouseholdsTheme" /> class.
        /// </summary>
        /// <param name="BoundaryRef">BoundaryRef.</param>
        /// <param name="IndividualValueVariable">IndividualValueVariable.</param>
        /// <param name="RangeVariable">RangeVariable.</param>
        public HouseholdsTheme(string BoundaryRef = null, List<IndividualValueVariableV2> IndividualValueVariable = null, List<RangeVariableV2> RangeVariable = null)
        {
            this.BoundaryRef = BoundaryRef;
            this.IndividualValueVariable = IndividualValueVariable;
            this.RangeVariable = RangeVariable;
        }
        
        /// <summary>
        /// Gets or Sets BoundaryRef
        /// </summary>
        [DataMember(Name="boundaryRef", EmitDefaultValue=false)]
        public string BoundaryRef { get; set; }
        /// <summary>
        /// Gets or Sets IndividualValueVariable
        /// </summary>
        [DataMember(Name="individualValueVariable", EmitDefaultValue=false)]
        public List<IndividualValueVariableV2> IndividualValueVariable { get; set; }
        /// <summary>
        /// Gets or Sets RangeVariable
        /// </summary>
        [DataMember(Name="rangeVariable", EmitDefaultValue=false)]
        public List<RangeVariableV2> RangeVariable { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HouseholdsTheme {\n");
            sb.Append("  BoundaryRef: ").Append(BoundaryRef).Append("\n");
            sb.Append("  IndividualValueVariable: ").Append(IndividualValueVariable).Append("\n");
            sb.Append("  RangeVariable: ").Append(RangeVariable).Append("\n");
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
            return this.Equals(obj as HouseholdsTheme);
        }

        /// <summary>
        /// Returns true if HouseholdsTheme instances are equal
        /// </summary>
        /// <param name="other">Instance of HouseholdsTheme to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HouseholdsTheme other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BoundaryRef == other.BoundaryRef ||
                    this.BoundaryRef != null &&
                    this.BoundaryRef.Equals(other.BoundaryRef)
                ) && 
                (
                    this.IndividualValueVariable == other.IndividualValueVariable ||
                    this.IndividualValueVariable != null &&
                    this.IndividualValueVariable.SequenceEqual(other.IndividualValueVariable)
                ) && 
                (
                    this.RangeVariable == other.RangeVariable ||
                    this.RangeVariable != null &&
                    this.RangeVariable.SequenceEqual(other.RangeVariable)
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
                if (this.BoundaryRef != null)
                    hash = hash * 59 + this.BoundaryRef.GetHashCode();
                if (this.IndividualValueVariable != null)
                    hash = hash * 59 + this.IndividualValueVariable.GetHashCode();
                if (this.RangeVariable != null)
                    hash = hash * 59 + this.RangeVariable.GetHashCode();
                return hash;
            }
        }
    }

}

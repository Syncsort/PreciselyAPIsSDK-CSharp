/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.0.0
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
    /// TypeaheadUnit
    /// </summary>
    [DataContract]
    public partial class TypeaheadUnit :  IEquatable<TypeaheadUnit>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TypeaheadUnit" /> class.
        /// </summary>
        /// <param name="UnitInfo">UnitInfo.</param>
        /// <param name="FormattedUnitAddress">FormattedUnitAddress.</param>
        public TypeaheadUnit(string UnitInfo = null, string FormattedUnitAddress = null)
        {
            this.UnitInfo = UnitInfo;
            this.FormattedUnitAddress = FormattedUnitAddress;
        }
        
        /// <summary>
        /// Gets or Sets UnitInfo
        /// </summary>
        [DataMember(Name="unitInfo", EmitDefaultValue=false)]
        public string UnitInfo { get; set; }
        /// <summary>
        /// Gets or Sets FormattedUnitAddress
        /// </summary>
        [DataMember(Name="formattedUnitAddress", EmitDefaultValue=false)]
        public string FormattedUnitAddress { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TypeaheadUnit {\n");
            sb.Append("  UnitInfo: ").Append(UnitInfo).Append("\n");
            sb.Append("  FormattedUnitAddress: ").Append(FormattedUnitAddress).Append("\n");
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
            return this.Equals(obj as TypeaheadUnit);
        }

        /// <summary>
        /// Returns true if TypeaheadUnit instances are equal
        /// </summary>
        /// <param name="other">Instance of TypeaheadUnit to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TypeaheadUnit other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UnitInfo == other.UnitInfo ||
                    this.UnitInfo != null &&
                    this.UnitInfo.Equals(other.UnitInfo)
                ) && 
                (
                    this.FormattedUnitAddress == other.FormattedUnitAddress ||
                    this.FormattedUnitAddress != null &&
                    this.FormattedUnitAddress.Equals(other.FormattedUnitAddress)
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
                if (this.UnitInfo != null)
                    hash = hash * 59 + this.UnitInfo.GetHashCode();
                if (this.FormattedUnitAddress != null)
                    hash = hash * 59 + this.FormattedUnitAddress.GetHashCode();
                return hash;
            }
        }
    }

}

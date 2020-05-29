/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 9.0.0
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
    /// TaxRateLocationResponses
    /// </summary>
    [DataContract]
    public partial class TaxRateLocationResponses :  IEquatable<TaxRateLocationResponses>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxRateLocationResponses" /> class.
        /// </summary>
        /// <param name="TaxResponses">TaxResponses.</param>
        public TaxRateLocationResponses(List<TaxRateBatchLocationResponse> TaxResponses = null)
        {
            this.TaxResponses = TaxResponses;
        }
        
        /// <summary>
        /// Gets or Sets TaxResponses
        /// </summary>
        [DataMember(Name="taxResponses", EmitDefaultValue=false)]
        public List<TaxRateBatchLocationResponse> TaxResponses { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxRateLocationResponses {\n");
            sb.Append("  TaxResponses: ").Append(TaxResponses).Append("\n");
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
            return this.Equals(obj as TaxRateLocationResponses);
        }

        /// <summary>
        /// Returns true if TaxRateLocationResponses instances are equal
        /// </summary>
        /// <param name="other">Instance of TaxRateLocationResponses to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxRateLocationResponses other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.TaxResponses == other.TaxResponses ||
                    this.TaxResponses != null &&
                    this.TaxResponses.SequenceEqual(other.TaxResponses)
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
                if (this.TaxResponses != null)
                    hash = hash * 59 + this.TaxResponses.GetHashCode();
                return hash;
            }
        }
    }

}
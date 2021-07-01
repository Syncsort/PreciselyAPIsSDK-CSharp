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
    /// BoundaryBuffer
    /// </summary>
    [DataContract]
    public partial class BoundaryBuffer :  IEquatable<BoundaryBuffer>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BoundaryBuffer" /> class.
        /// </summary>
        /// <param name="BufferRelation">BufferRelation.</param>
        /// <param name="DistanceToBorder">DistanceToBorder.</param>
        public BoundaryBuffer(BufferRelation BufferRelation = null, DistanceToBorder DistanceToBorder = null)
        {
            this.BufferRelation = BufferRelation;
            this.DistanceToBorder = DistanceToBorder;
        }
        
        /// <summary>
        /// Gets or Sets BufferRelation
        /// </summary>
        [DataMember(Name="bufferRelation", EmitDefaultValue=false)]
        public BufferRelation BufferRelation { get; set; }
        /// <summary>
        /// Gets or Sets DistanceToBorder
        /// </summary>
        [DataMember(Name="distanceToBorder", EmitDefaultValue=false)]
        public DistanceToBorder DistanceToBorder { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BoundaryBuffer {\n");
            sb.Append("  BufferRelation: ").Append(BufferRelation).Append("\n");
            sb.Append("  DistanceToBorder: ").Append(DistanceToBorder).Append("\n");
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
            return this.Equals(obj as BoundaryBuffer);
        }

        /// <summary>
        /// Returns true if BoundaryBuffer instances are equal
        /// </summary>
        /// <param name="other">Instance of BoundaryBuffer to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BoundaryBuffer other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.BufferRelation == other.BufferRelation ||
                    this.BufferRelation != null &&
                    this.BufferRelation.Equals(other.BufferRelation)
                ) && 
                (
                    this.DistanceToBorder == other.DistanceToBorder ||
                    this.DistanceToBorder != null &&
                    this.DistanceToBorder.Equals(other.DistanceToBorder)
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
                if (this.BufferRelation != null)
                    hash = hash * 59 + this.BufferRelation.GetHashCode();
                if (this.DistanceToBorder != null)
                    hash = hash * 59 + this.DistanceToBorder.GetHashCode();
                return hash;
            }
        }
    }

}

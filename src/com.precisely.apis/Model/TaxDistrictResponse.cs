/* 
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * OpenAPI spec version: 11.0.1
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
    /// TaxDistrictResponse
    /// </summary>
    [DataContract]
    public partial class TaxDistrictResponse :  IEquatable<TaxDistrictResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxDistrictResponse" /> class.
        /// </summary>
        /// <param name="ObjectId">ObjectId.</param>
        /// <param name="Confidence">Confidence.</param>
        /// <param name="Jurisdiction">Jurisdiction.</param>
        /// <param name="NumOfIpdsFound">NumOfIpdsFound.</param>
        /// <param name="Ipds">Ipds.</param>
        /// <param name="MatchedAddress">MatchedAddress.</param>
        public TaxDistrictResponse(string ObjectId = null, double? Confidence = null, IPDTaxJurisdiction Jurisdiction = null, int? NumOfIpdsFound = null, List<Ipd> Ipds = null, MatchedAddress MatchedAddress = null)
        {
            this.ObjectId = ObjectId;
            this.Confidence = Confidence;
            this.Jurisdiction = Jurisdiction;
            this.NumOfIpdsFound = NumOfIpdsFound;
            this.Ipds = Ipds;
            this.MatchedAddress = MatchedAddress;
        }
        
        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }
        /// <summary>
        /// Gets or Sets Confidence
        /// </summary>
        [DataMember(Name="confidence", EmitDefaultValue=false)]
        public double? Confidence { get; set; }
        /// <summary>
        /// Gets or Sets Jurisdiction
        /// </summary>
        [DataMember(Name="jurisdiction", EmitDefaultValue=false)]
        public IPDTaxJurisdiction Jurisdiction { get; set; }
        /// <summary>
        /// Gets or Sets NumOfIpdsFound
        /// </summary>
        [DataMember(Name="numOfIpdsFound", EmitDefaultValue=false)]
        public int? NumOfIpdsFound { get; set; }
        /// <summary>
        /// Gets or Sets Ipds
        /// </summary>
        [DataMember(Name="ipds", EmitDefaultValue=false)]
        public List<Ipd> Ipds { get; set; }
        /// <summary>
        /// Gets or Sets MatchedAddress
        /// </summary>
        [DataMember(Name="matchedAddress", EmitDefaultValue=false)]
        public MatchedAddress MatchedAddress { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxDistrictResponse {\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
            sb.Append("  Confidence: ").Append(Confidence).Append("\n");
            sb.Append("  Jurisdiction: ").Append(Jurisdiction).Append("\n");
            sb.Append("  NumOfIpdsFound: ").Append(NumOfIpdsFound).Append("\n");
            sb.Append("  Ipds: ").Append(Ipds).Append("\n");
            sb.Append("  MatchedAddress: ").Append(MatchedAddress).Append("\n");
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
            return this.Equals(obj as TaxDistrictResponse);
        }

        /// <summary>
        /// Returns true if TaxDistrictResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of TaxDistrictResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxDistrictResponse other)
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
                    this.Confidence == other.Confidence ||
                    this.Confidence != null &&
                    this.Confidence.Equals(other.Confidence)
                ) && 
                (
                    this.Jurisdiction == other.Jurisdiction ||
                    this.Jurisdiction != null &&
                    this.Jurisdiction.Equals(other.Jurisdiction)
                ) && 
                (
                    this.NumOfIpdsFound == other.NumOfIpdsFound ||
                    this.NumOfIpdsFound != null &&
                    this.NumOfIpdsFound.Equals(other.NumOfIpdsFound)
                ) && 
                (
                    this.Ipds == other.Ipds ||
                    this.Ipds != null &&
                    this.Ipds.SequenceEqual(other.Ipds)
                ) && 
                (
                    this.MatchedAddress == other.MatchedAddress ||
                    this.MatchedAddress != null &&
                    this.MatchedAddress.Equals(other.MatchedAddress)
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
                if (this.Confidence != null)
                    hash = hash * 59 + this.Confidence.GetHashCode();
                if (this.Jurisdiction != null)
                    hash = hash * 59 + this.Jurisdiction.GetHashCode();
                if (this.NumOfIpdsFound != null)
                    hash = hash * 59 + this.NumOfIpdsFound.GetHashCode();
                if (this.Ipds != null)
                    hash = hash * 59 + this.Ipds.GetHashCode();
                if (this.MatchedAddress != null)
                    hash = hash * 59 + this.MatchedAddress.GetHashCode();
                return hash;
            }
        }
    }

}

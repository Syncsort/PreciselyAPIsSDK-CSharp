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
    /// IdentityDetail
    /// </summary>
    [DataContract]
    public partial class IdentityDetail :  IEquatable<IdentityDetail>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IdentityDetail" /> class.
        /// </summary>
        /// <param name="Name">Name.</param>
        /// <param name="Age">Age.</param>
        /// <param name="Demographics">Demographics.</param>
        /// <param name="Photos">Photos.</param>
        /// <param name="Profiles">Profiles.</param>
        /// <param name="Urls">Urls.</param>
        /// <param name="Education">Education.</param>
        /// <param name="Employment">Employment.</param>
        public IdentityDetail(IdentityName Name = null, Age Age = null, IdentityDemographics Demographics = null, List<Photo> Photos = null, Profiles Profiles = null, List<Url> Urls = null, List<Education> Education = null, List<Employment> Employment = null)
        {
            this.Name = Name;
            this.Age = Age;
            this.Demographics = Demographics;
            this.Photos = Photos;
            this.Profiles = Profiles;
            this.Urls = Urls;
            this.Education = Education;
            this.Employment = Employment;
        }
        
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public IdentityName Name { get; set; }
        /// <summary>
        /// Gets or Sets Age
        /// </summary>
        [DataMember(Name="age", EmitDefaultValue=false)]
        public Age Age { get; set; }
        /// <summary>
        /// Gets or Sets Demographics
        /// </summary>
        [DataMember(Name="demographics", EmitDefaultValue=false)]
        public IdentityDemographics Demographics { get; set; }
        /// <summary>
        /// Gets or Sets Photos
        /// </summary>
        [DataMember(Name="photos", EmitDefaultValue=false)]
        public List<Photo> Photos { get; set; }
        /// <summary>
        /// Gets or Sets Profiles
        /// </summary>
        [DataMember(Name="profiles", EmitDefaultValue=false)]
        public Profiles Profiles { get; set; }
        /// <summary>
        /// Gets or Sets Urls
        /// </summary>
        [DataMember(Name="urls", EmitDefaultValue=false)]
        public List<Url> Urls { get; set; }
        /// <summary>
        /// Gets or Sets Education
        /// </summary>
        [DataMember(Name="education", EmitDefaultValue=false)]
        public List<Education> Education { get; set; }
        /// <summary>
        /// Gets or Sets Employment
        /// </summary>
        [DataMember(Name="employment", EmitDefaultValue=false)]
        public List<Employment> Employment { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IdentityDetail {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Age: ").Append(Age).Append("\n");
            sb.Append("  Demographics: ").Append(Demographics).Append("\n");
            sb.Append("  Photos: ").Append(Photos).Append("\n");
            sb.Append("  Profiles: ").Append(Profiles).Append("\n");
            sb.Append("  Urls: ").Append(Urls).Append("\n");
            sb.Append("  Education: ").Append(Education).Append("\n");
            sb.Append("  Employment: ").Append(Employment).Append("\n");
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
            return this.Equals(obj as IdentityDetail);
        }

        /// <summary>
        /// Returns true if IdentityDetail instances are equal
        /// </summary>
        /// <param name="other">Instance of IdentityDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IdentityDetail other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Age == other.Age ||
                    this.Age != null &&
                    this.Age.Equals(other.Age)
                ) && 
                (
                    this.Demographics == other.Demographics ||
                    this.Demographics != null &&
                    this.Demographics.Equals(other.Demographics)
                ) && 
                (
                    this.Photos == other.Photos ||
                    this.Photos != null &&
                    this.Photos.SequenceEqual(other.Photos)
                ) && 
                (
                    this.Profiles == other.Profiles ||
                    this.Profiles != null &&
                    this.Profiles.Equals(other.Profiles)
                ) && 
                (
                    this.Urls == other.Urls ||
                    this.Urls != null &&
                    this.Urls.SequenceEqual(other.Urls)
                ) && 
                (
                    this.Education == other.Education ||
                    this.Education != null &&
                    this.Education.SequenceEqual(other.Education)
                ) && 
                (
                    this.Employment == other.Employment ||
                    this.Employment != null &&
                    this.Employment.SequenceEqual(other.Employment)
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
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Age != null)
                    hash = hash * 59 + this.Age.GetHashCode();
                if (this.Demographics != null)
                    hash = hash * 59 + this.Demographics.GetHashCode();
                if (this.Photos != null)
                    hash = hash * 59 + this.Photos.GetHashCode();
                if (this.Profiles != null)
                    hash = hash * 59 + this.Profiles.GetHashCode();
                if (this.Urls != null)
                    hash = hash * 59 + this.Urls.GetHashCode();
                if (this.Education != null)
                    hash = hash * 59 + this.Education.GetHashCode();
                if (this.Employment != null)
                    hash = hash * 59 + this.Employment.GetHashCode();
                return hash;
            }
        }
    }

}

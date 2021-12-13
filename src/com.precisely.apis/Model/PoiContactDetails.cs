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
    /// PoiContactDetails
    /// </summary>
    [DataContract]
    public partial class PoiContactDetails :  IEquatable<PoiContactDetails>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PoiContactDetails" /> class.
        /// </summary>
        /// <param name="Address">Address.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Fax">Fax.</param>
        /// <param name="CountryAccessCode">CountryAccessCode.</param>
        /// <param name="Email">Email.</param>
        /// <param name="Url">Url.</param>
        public PoiContactDetails(Address Address = null, string Phone = null, string Fax = null, string CountryAccessCode = null, string Email = null, string Url = null)
        {
            this.Address = Address;
            this.Phone = Phone;
            this.Fax = Fax;
            this.CountryAccessCode = CountryAccessCode;
            this.Email = Email;
            this.Url = Url;
        }
        
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public Address Address { get; set; }
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// Gets or Sets Fax
        /// </summary>
        [DataMember(Name="fax", EmitDefaultValue=false)]
        public string Fax { get; set; }
        /// <summary>
        /// Gets or Sets CountryAccessCode
        /// </summary>
        [DataMember(Name="countryAccessCode", EmitDefaultValue=false)]
        public string CountryAccessCode { get; set; }
        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }
        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PoiContactDetails {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Fax: ").Append(Fax).Append("\n");
            sb.Append("  CountryAccessCode: ").Append(CountryAccessCode).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
            return this.Equals(obj as PoiContactDetails);
        }

        /// <summary>
        /// Returns true if PoiContactDetails instances are equal
        /// </summary>
        /// <param name="other">Instance of PoiContactDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PoiContactDetails other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Fax == other.Fax ||
                    this.Fax != null &&
                    this.Fax.Equals(other.Fax)
                ) && 
                (
                    this.CountryAccessCode == other.CountryAccessCode ||
                    this.CountryAccessCode != null &&
                    this.CountryAccessCode.Equals(other.CountryAccessCode)
                ) && 
                (
                    this.Email == other.Email ||
                    this.Email != null &&
                    this.Email.Equals(other.Email)
                ) && 
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
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
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.Fax != null)
                    hash = hash * 59 + this.Fax.GetHashCode();
                if (this.CountryAccessCode != null)
                    hash = hash * 59 + this.CountryAccessCode.GetHashCode();
                if (this.Email != null)
                    hash = hash * 59 + this.Email.GetHashCode();
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();
                return hash;
            }
        }
    }

}

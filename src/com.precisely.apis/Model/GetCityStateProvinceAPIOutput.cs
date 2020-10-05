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
    /// GetCityStateProvinceAPIOutput
    /// </summary>
    [DataContract]
    public partial class GetCityStateProvinceAPIOutput :  IEquatable<GetCityStateProvinceAPIOutput>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetCityStateProvinceAPIOutput" /> class.
        /// </summary>
        /// <param name="UserFields">These fields are returned, unmodified, in the user_fields section of the response..</param>
        /// <param name="PostalCode">The validated ZIP Code or postal code..</param>
        /// <param name="City">City.</param>
        /// <param name="CityType">City.Type.</param>
        /// <param name="StateProvince">The state or province..</param>
        /// <param name="Status">Reports the success or failure of the match attempt..</param>
        /// <param name="StatusCode">Reason for failure, if there is one..</param>
        /// <param name="StatusDescription">Description of the problem, if there is one..</param>
        public GetCityStateProvinceAPIOutput(List<ValidateMailingAddressInputRowUserFields> UserFields = null, string PostalCode = null, string City = null, string CityType = null, string StateProvince = null, string Status = null, string StatusCode = null, string StatusDescription = null)
        {
            this.UserFields = UserFields;
            this.PostalCode = PostalCode;
            this.City = City;
            this.CityType = CityType;
            this.StateProvince = StateProvince;
            this.Status = Status;
            this.StatusCode = StatusCode;
            this.StatusDescription = StatusDescription;
        }
        
        /// <summary>
        /// These fields are returned, unmodified, in the user_fields section of the response.
        /// </summary>
        /// <value>These fields are returned, unmodified, in the user_fields section of the response.</value>
        [DataMember(Name="user_fields", EmitDefaultValue=false)]
        public List<ValidateMailingAddressInputRowUserFields> UserFields { get; set; }
        /// <summary>
        /// The validated ZIP Code or postal code.
        /// </summary>
        /// <value>The validated ZIP Code or postal code.</value>
        [DataMember(Name="PostalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }
        /// <summary>
        /// City
        /// </summary>
        /// <value>City</value>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }
        /// <summary>
        /// City.Type
        /// </summary>
        /// <value>City.Type</value>
        [DataMember(Name="City.Type", EmitDefaultValue=false)]
        public string CityType { get; set; }
        /// <summary>
        /// The state or province.
        /// </summary>
        /// <value>The state or province.</value>
        [DataMember(Name="StateProvince", EmitDefaultValue=false)]
        public string StateProvince { get; set; }
        /// <summary>
        /// Reports the success or failure of the match attempt.
        /// </summary>
        /// <value>Reports the success or failure of the match attempt.</value>
        [DataMember(Name="Status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Reason for failure, if there is one.
        /// </summary>
        /// <value>Reason for failure, if there is one.</value>
        [DataMember(Name="Status.Code", EmitDefaultValue=false)]
        public string StatusCode { get; set; }
        /// <summary>
        /// Description of the problem, if there is one.
        /// </summary>
        /// <value>Description of the problem, if there is one.</value>
        [DataMember(Name="Status.Description", EmitDefaultValue=false)]
        public string StatusDescription { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetCityStateProvinceAPIOutput {\n");
            sb.Append("  UserFields: ").Append(UserFields).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  CityType: ").Append(CityType).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  StatusDescription: ").Append(StatusDescription).Append("\n");
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
            return this.Equals(obj as GetCityStateProvinceAPIOutput);
        }

        /// <summary>
        /// Returns true if GetCityStateProvinceAPIOutput instances are equal
        /// </summary>
        /// <param name="other">Instance of GetCityStateProvinceAPIOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetCityStateProvinceAPIOutput other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserFields == other.UserFields ||
                    this.UserFields != null &&
                    this.UserFields.SequenceEqual(other.UserFields)
                ) && 
                (
                    this.PostalCode == other.PostalCode ||
                    this.PostalCode != null &&
                    this.PostalCode.Equals(other.PostalCode)
                ) && 
                (
                    this.City == other.City ||
                    this.City != null &&
                    this.City.Equals(other.City)
                ) && 
                (
                    this.CityType == other.CityType ||
                    this.CityType != null &&
                    this.CityType.Equals(other.CityType)
                ) && 
                (
                    this.StateProvince == other.StateProvince ||
                    this.StateProvince != null &&
                    this.StateProvince.Equals(other.StateProvince)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StatusCode == other.StatusCode ||
                    this.StatusCode != null &&
                    this.StatusCode.Equals(other.StatusCode)
                ) && 
                (
                    this.StatusDescription == other.StatusDescription ||
                    this.StatusDescription != null &&
                    this.StatusDescription.Equals(other.StatusDescription)
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
                if (this.UserFields != null)
                    hash = hash * 59 + this.UserFields.GetHashCode();
                if (this.PostalCode != null)
                    hash = hash * 59 + this.PostalCode.GetHashCode();
                if (this.City != null)
                    hash = hash * 59 + this.City.GetHashCode();
                if (this.CityType != null)
                    hash = hash * 59 + this.CityType.GetHashCode();
                if (this.StateProvince != null)
                    hash = hash * 59 + this.StateProvince.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.StatusCode != null)
                    hash = hash * 59 + this.StatusCode.GetHashCode();
                if (this.StatusDescription != null)
                    hash = hash * 59 + this.StatusDescription.GetHashCode();
                return hash;
            }
        }
    }

}

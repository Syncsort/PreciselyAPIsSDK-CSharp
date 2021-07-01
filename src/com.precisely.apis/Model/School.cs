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
    /// School
    /// </summary>
    [DataContract]
    public partial class School :  IEquatable<School>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="School" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="Name">Name.</param>
        /// <param name="Assigned">Assigned.</param>
        /// <param name="Phone">Phone.</param>
        /// <param name="Website">Website.</param>
        /// <param name="AddressType">AddressType.</param>
        /// <param name="Address">Address.</param>
        /// <param name="LowestGrade">LowestGrade.</param>
        /// <param name="HighestGrade">HighestGrade.</param>
        /// <param name="SchoolType">SchoolType.</param>
        /// <param name="SchoolTypeDesc">SchoolTypeDesc.</param>
        /// <param name="SchoolSubType">SchoolSubType.</param>
        /// <param name="SchoolSubTypeDesc">SchoolSubTypeDesc.</param>
        /// <param name="Gender">Gender.</param>
        /// <param name="GenderDesc">GenderDesc.</param>
        /// <param name="EducationLevel">EducationLevel.</param>
        /// <param name="EducationLevelDesc">EducationLevelDesc.</param>
        /// <param name="Greatschools">Greatschools.</param>
        /// <param name="NcesSchoolId">NcesSchoolId.</param>
        /// <param name="NcesDistrictId">NcesDistrictId.</param>
        /// <param name="NcesDataYear">NcesDataYear.</param>
        /// <param name="SchoolRanking">SchoolRanking.</param>
        /// <param name="Students">Students.</param>
        /// <param name="Teachers">Teachers.</param>
        /// <param name="Status">Status.</param>
        /// <param name="StudentTeacherRatio">StudentTeacherRatio.</param>
        /// <param name="Choice">Choice.</param>
        /// <param name="Coextensiv">Coextensiv.</param>
        /// <param name="SchoolDistricts">SchoolDistricts.</param>
        /// <param name="SchoolProfile">SchoolProfile.</param>
        /// <param name="GradeLevelsTaught">GradeLevelsTaught.</param>
        /// <param name="Distance">Distance.</param>
        /// <param name="Geometry">Geometry.</param>
        public School(string Id = null, string Name = null, string Assigned = null, string Phone = null, string Website = null, string AddressType = null, Address Address = null, string LowestGrade = null, string HighestGrade = null, string SchoolType = null, string SchoolTypeDesc = null, string SchoolSubType = null, string SchoolSubTypeDesc = null, string Gender = null, string GenderDesc = null, string EducationLevel = null, string EducationLevelDesc = null, Greatschools Greatschools = null, string NcesSchoolId = null, string NcesDistrictId = null, string NcesDataYear = null, List<SchoolRanking> SchoolRanking = null, string Students = null, string Teachers = null, string Status = null, string StudentTeacherRatio = null, string Choice = null, string Coextensiv = null, SchoolDistrict SchoolDistricts = null, SchoolProfile SchoolProfile = null, GradeLevelsTaught GradeLevelsTaught = null, Distance Distance = null, Geometry Geometry = null)
        {
            this.Id = Id;
            this.Name = Name;
            this.Assigned = Assigned;
            this.Phone = Phone;
            this.Website = Website;
            this.AddressType = AddressType;
            this.Address = Address;
            this.LowestGrade = LowestGrade;
            this.HighestGrade = HighestGrade;
            this.SchoolType = SchoolType;
            this.SchoolTypeDesc = SchoolTypeDesc;
            this.SchoolSubType = SchoolSubType;
            this.SchoolSubTypeDesc = SchoolSubTypeDesc;
            this.Gender = Gender;
            this.GenderDesc = GenderDesc;
            this.EducationLevel = EducationLevel;
            this.EducationLevelDesc = EducationLevelDesc;
            this.Greatschools = Greatschools;
            this.NcesSchoolId = NcesSchoolId;
            this.NcesDistrictId = NcesDistrictId;
            this.NcesDataYear = NcesDataYear;
            this.SchoolRanking = SchoolRanking;
            this.Students = Students;
            this.Teachers = Teachers;
            this.Status = Status;
            this.StudentTeacherRatio = StudentTeacherRatio;
            this.Choice = Choice;
            this.Coextensiv = Coextensiv;
            this.SchoolDistricts = SchoolDistricts;
            this.SchoolProfile = SchoolProfile;
            this.GradeLevelsTaught = GradeLevelsTaught;
            this.Distance = Distance;
            this.Geometry = Geometry;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets Assigned
        /// </summary>
        [DataMember(Name="assigned", EmitDefaultValue=false)]
        public string Assigned { get; set; }
        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }
        /// <summary>
        /// Gets or Sets Website
        /// </summary>
        [DataMember(Name="website", EmitDefaultValue=false)]
        public string Website { get; set; }
        /// <summary>
        /// Gets or Sets AddressType
        /// </summary>
        [DataMember(Name="addressType", EmitDefaultValue=false)]
        public string AddressType { get; set; }
        /// <summary>
        /// Gets or Sets Address
        /// </summary>
        [DataMember(Name="address", EmitDefaultValue=false)]
        public Address Address { get; set; }
        /// <summary>
        /// Gets or Sets LowestGrade
        /// </summary>
        [DataMember(Name="lowestGrade", EmitDefaultValue=false)]
        public string LowestGrade { get; set; }
        /// <summary>
        /// Gets or Sets HighestGrade
        /// </summary>
        [DataMember(Name="highestGrade", EmitDefaultValue=false)]
        public string HighestGrade { get; set; }
        /// <summary>
        /// Gets or Sets SchoolType
        /// </summary>
        [DataMember(Name="schoolType", EmitDefaultValue=false)]
        public string SchoolType { get; set; }
        /// <summary>
        /// Gets or Sets SchoolTypeDesc
        /// </summary>
        [DataMember(Name="schoolTypeDesc", EmitDefaultValue=false)]
        public string SchoolTypeDesc { get; set; }
        /// <summary>
        /// Gets or Sets SchoolSubType
        /// </summary>
        [DataMember(Name="schoolSubType", EmitDefaultValue=false)]
        public string SchoolSubType { get; set; }
        /// <summary>
        /// Gets or Sets SchoolSubTypeDesc
        /// </summary>
        [DataMember(Name="schoolSubTypeDesc", EmitDefaultValue=false)]
        public string SchoolSubTypeDesc { get; set; }
        /// <summary>
        /// Gets or Sets Gender
        /// </summary>
        [DataMember(Name="gender", EmitDefaultValue=false)]
        public string Gender { get; set; }
        /// <summary>
        /// Gets or Sets GenderDesc
        /// </summary>
        [DataMember(Name="genderDesc", EmitDefaultValue=false)]
        public string GenderDesc { get; set; }
        /// <summary>
        /// Gets or Sets EducationLevel
        /// </summary>
        [DataMember(Name="educationLevel", EmitDefaultValue=false)]
        public string EducationLevel { get; set; }
        /// <summary>
        /// Gets or Sets EducationLevelDesc
        /// </summary>
        [DataMember(Name="educationLevelDesc", EmitDefaultValue=false)]
        public string EducationLevelDesc { get; set; }
        /// <summary>
        /// Gets or Sets Greatschools
        /// </summary>
        [DataMember(Name="greatschools", EmitDefaultValue=false)]
        public Greatschools Greatschools { get; set; }
        /// <summary>
        /// Gets or Sets NcesSchoolId
        /// </summary>
        [DataMember(Name="ncesSchoolId", EmitDefaultValue=false)]
        public string NcesSchoolId { get; set; }
        /// <summary>
        /// Gets or Sets NcesDistrictId
        /// </summary>
        [DataMember(Name="ncesDistrictId", EmitDefaultValue=false)]
        public string NcesDistrictId { get; set; }
        /// <summary>
        /// Gets or Sets NcesDataYear
        /// </summary>
        [DataMember(Name="ncesDataYear", EmitDefaultValue=false)]
        public string NcesDataYear { get; set; }
        /// <summary>
        /// Gets or Sets SchoolRanking
        /// </summary>
        [DataMember(Name="schoolRanking", EmitDefaultValue=false)]
        public List<SchoolRanking> SchoolRanking { get; set; }
        /// <summary>
        /// Gets or Sets Students
        /// </summary>
        [DataMember(Name="students", EmitDefaultValue=false)]
        public string Students { get; set; }
        /// <summary>
        /// Gets or Sets Teachers
        /// </summary>
        [DataMember(Name="teachers", EmitDefaultValue=false)]
        public string Teachers { get; set; }
        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name="status", EmitDefaultValue=false)]
        public string Status { get; set; }
        /// <summary>
        /// Gets or Sets StudentTeacherRatio
        /// </summary>
        [DataMember(Name="studentTeacherRatio", EmitDefaultValue=false)]
        public string StudentTeacherRatio { get; set; }
        /// <summary>
        /// Gets or Sets Choice
        /// </summary>
        [DataMember(Name="choice", EmitDefaultValue=false)]
        public string Choice { get; set; }
        /// <summary>
        /// Gets or Sets Coextensiv
        /// </summary>
        [DataMember(Name="coextensiv", EmitDefaultValue=false)]
        public string Coextensiv { get; set; }
        /// <summary>
        /// Gets or Sets SchoolDistricts
        /// </summary>
        [DataMember(Name="schoolDistricts", EmitDefaultValue=false)]
        public SchoolDistrict SchoolDistricts { get; set; }
        /// <summary>
        /// Gets or Sets SchoolProfile
        /// </summary>
        [DataMember(Name="schoolProfile", EmitDefaultValue=false)]
        public SchoolProfile SchoolProfile { get; set; }
        /// <summary>
        /// Gets or Sets GradeLevelsTaught
        /// </summary>
        [DataMember(Name="gradeLevelsTaught", EmitDefaultValue=false)]
        public GradeLevelsTaught GradeLevelsTaught { get; set; }
        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public Distance Distance { get; set; }
        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=false)]
        public Geometry Geometry { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class School {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Assigned: ").Append(Assigned).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Website: ").Append(Website).Append("\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  LowestGrade: ").Append(LowestGrade).Append("\n");
            sb.Append("  HighestGrade: ").Append(HighestGrade).Append("\n");
            sb.Append("  SchoolType: ").Append(SchoolType).Append("\n");
            sb.Append("  SchoolTypeDesc: ").Append(SchoolTypeDesc).Append("\n");
            sb.Append("  SchoolSubType: ").Append(SchoolSubType).Append("\n");
            sb.Append("  SchoolSubTypeDesc: ").Append(SchoolSubTypeDesc).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  GenderDesc: ").Append(GenderDesc).Append("\n");
            sb.Append("  EducationLevel: ").Append(EducationLevel).Append("\n");
            sb.Append("  EducationLevelDesc: ").Append(EducationLevelDesc).Append("\n");
            sb.Append("  Greatschools: ").Append(Greatschools).Append("\n");
            sb.Append("  NcesSchoolId: ").Append(NcesSchoolId).Append("\n");
            sb.Append("  NcesDistrictId: ").Append(NcesDistrictId).Append("\n");
            sb.Append("  NcesDataYear: ").Append(NcesDataYear).Append("\n");
            sb.Append("  SchoolRanking: ").Append(SchoolRanking).Append("\n");
            sb.Append("  Students: ").Append(Students).Append("\n");
            sb.Append("  Teachers: ").Append(Teachers).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StudentTeacherRatio: ").Append(StudentTeacherRatio).Append("\n");
            sb.Append("  Choice: ").Append(Choice).Append("\n");
            sb.Append("  Coextensiv: ").Append(Coextensiv).Append("\n");
            sb.Append("  SchoolDistricts: ").Append(SchoolDistricts).Append("\n");
            sb.Append("  SchoolProfile: ").Append(SchoolProfile).Append("\n");
            sb.Append("  GradeLevelsTaught: ").Append(GradeLevelsTaught).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
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
            return this.Equals(obj as School);
        }

        /// <summary>
        /// Returns true if School instances are equal
        /// </summary>
        /// <param name="other">Instance of School to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(School other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Id == other.Id ||
                    this.Id != null &&
                    this.Id.Equals(other.Id)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.Assigned == other.Assigned ||
                    this.Assigned != null &&
                    this.Assigned.Equals(other.Assigned)
                ) && 
                (
                    this.Phone == other.Phone ||
                    this.Phone != null &&
                    this.Phone.Equals(other.Phone)
                ) && 
                (
                    this.Website == other.Website ||
                    this.Website != null &&
                    this.Website.Equals(other.Website)
                ) && 
                (
                    this.AddressType == other.AddressType ||
                    this.AddressType != null &&
                    this.AddressType.Equals(other.AddressType)
                ) && 
                (
                    this.Address == other.Address ||
                    this.Address != null &&
                    this.Address.Equals(other.Address)
                ) && 
                (
                    this.LowestGrade == other.LowestGrade ||
                    this.LowestGrade != null &&
                    this.LowestGrade.Equals(other.LowestGrade)
                ) && 
                (
                    this.HighestGrade == other.HighestGrade ||
                    this.HighestGrade != null &&
                    this.HighestGrade.Equals(other.HighestGrade)
                ) && 
                (
                    this.SchoolType == other.SchoolType ||
                    this.SchoolType != null &&
                    this.SchoolType.Equals(other.SchoolType)
                ) && 
                (
                    this.SchoolTypeDesc == other.SchoolTypeDesc ||
                    this.SchoolTypeDesc != null &&
                    this.SchoolTypeDesc.Equals(other.SchoolTypeDesc)
                ) && 
                (
                    this.SchoolSubType == other.SchoolSubType ||
                    this.SchoolSubType != null &&
                    this.SchoolSubType.Equals(other.SchoolSubType)
                ) && 
                (
                    this.SchoolSubTypeDesc == other.SchoolSubTypeDesc ||
                    this.SchoolSubTypeDesc != null &&
                    this.SchoolSubTypeDesc.Equals(other.SchoolSubTypeDesc)
                ) && 
                (
                    this.Gender == other.Gender ||
                    this.Gender != null &&
                    this.Gender.Equals(other.Gender)
                ) && 
                (
                    this.GenderDesc == other.GenderDesc ||
                    this.GenderDesc != null &&
                    this.GenderDesc.Equals(other.GenderDesc)
                ) && 
                (
                    this.EducationLevel == other.EducationLevel ||
                    this.EducationLevel != null &&
                    this.EducationLevel.Equals(other.EducationLevel)
                ) && 
                (
                    this.EducationLevelDesc == other.EducationLevelDesc ||
                    this.EducationLevelDesc != null &&
                    this.EducationLevelDesc.Equals(other.EducationLevelDesc)
                ) && 
                (
                    this.Greatschools == other.Greatschools ||
                    this.Greatschools != null &&
                    this.Greatschools.Equals(other.Greatschools)
                ) && 
                (
                    this.NcesSchoolId == other.NcesSchoolId ||
                    this.NcesSchoolId != null &&
                    this.NcesSchoolId.Equals(other.NcesSchoolId)
                ) && 
                (
                    this.NcesDistrictId == other.NcesDistrictId ||
                    this.NcesDistrictId != null &&
                    this.NcesDistrictId.Equals(other.NcesDistrictId)
                ) && 
                (
                    this.NcesDataYear == other.NcesDataYear ||
                    this.NcesDataYear != null &&
                    this.NcesDataYear.Equals(other.NcesDataYear)
                ) && 
                (
                    this.SchoolRanking == other.SchoolRanking ||
                    this.SchoolRanking != null &&
                    this.SchoolRanking.SequenceEqual(other.SchoolRanking)
                ) && 
                (
                    this.Students == other.Students ||
                    this.Students != null &&
                    this.Students.Equals(other.Students)
                ) && 
                (
                    this.Teachers == other.Teachers ||
                    this.Teachers != null &&
                    this.Teachers.Equals(other.Teachers)
                ) && 
                (
                    this.Status == other.Status ||
                    this.Status != null &&
                    this.Status.Equals(other.Status)
                ) && 
                (
                    this.StudentTeacherRatio == other.StudentTeacherRatio ||
                    this.StudentTeacherRatio != null &&
                    this.StudentTeacherRatio.Equals(other.StudentTeacherRatio)
                ) && 
                (
                    this.Choice == other.Choice ||
                    this.Choice != null &&
                    this.Choice.Equals(other.Choice)
                ) && 
                (
                    this.Coextensiv == other.Coextensiv ||
                    this.Coextensiv != null &&
                    this.Coextensiv.Equals(other.Coextensiv)
                ) && 
                (
                    this.SchoolDistricts == other.SchoolDistricts ||
                    this.SchoolDistricts != null &&
                    this.SchoolDistricts.Equals(other.SchoolDistricts)
                ) && 
                (
                    this.SchoolProfile == other.SchoolProfile ||
                    this.SchoolProfile != null &&
                    this.SchoolProfile.Equals(other.SchoolProfile)
                ) && 
                (
                    this.GradeLevelsTaught == other.GradeLevelsTaught ||
                    this.GradeLevelsTaught != null &&
                    this.GradeLevelsTaught.Equals(other.GradeLevelsTaught)
                ) && 
                (
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
                ) && 
                (
                    this.Geometry == other.Geometry ||
                    this.Geometry != null &&
                    this.Geometry.Equals(other.Geometry)
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
                if (this.Id != null)
                    hash = hash * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.Assigned != null)
                    hash = hash * 59 + this.Assigned.GetHashCode();
                if (this.Phone != null)
                    hash = hash * 59 + this.Phone.GetHashCode();
                if (this.Website != null)
                    hash = hash * 59 + this.Website.GetHashCode();
                if (this.AddressType != null)
                    hash = hash * 59 + this.AddressType.GetHashCode();
                if (this.Address != null)
                    hash = hash * 59 + this.Address.GetHashCode();
                if (this.LowestGrade != null)
                    hash = hash * 59 + this.LowestGrade.GetHashCode();
                if (this.HighestGrade != null)
                    hash = hash * 59 + this.HighestGrade.GetHashCode();
                if (this.SchoolType != null)
                    hash = hash * 59 + this.SchoolType.GetHashCode();
                if (this.SchoolTypeDesc != null)
                    hash = hash * 59 + this.SchoolTypeDesc.GetHashCode();
                if (this.SchoolSubType != null)
                    hash = hash * 59 + this.SchoolSubType.GetHashCode();
                if (this.SchoolSubTypeDesc != null)
                    hash = hash * 59 + this.SchoolSubTypeDesc.GetHashCode();
                if (this.Gender != null)
                    hash = hash * 59 + this.Gender.GetHashCode();
                if (this.GenderDesc != null)
                    hash = hash * 59 + this.GenderDesc.GetHashCode();
                if (this.EducationLevel != null)
                    hash = hash * 59 + this.EducationLevel.GetHashCode();
                if (this.EducationLevelDesc != null)
                    hash = hash * 59 + this.EducationLevelDesc.GetHashCode();
                if (this.Greatschools != null)
                    hash = hash * 59 + this.Greatschools.GetHashCode();
                if (this.NcesSchoolId != null)
                    hash = hash * 59 + this.NcesSchoolId.GetHashCode();
                if (this.NcesDistrictId != null)
                    hash = hash * 59 + this.NcesDistrictId.GetHashCode();
                if (this.NcesDataYear != null)
                    hash = hash * 59 + this.NcesDataYear.GetHashCode();
                if (this.SchoolRanking != null)
                    hash = hash * 59 + this.SchoolRanking.GetHashCode();
                if (this.Students != null)
                    hash = hash * 59 + this.Students.GetHashCode();
                if (this.Teachers != null)
                    hash = hash * 59 + this.Teachers.GetHashCode();
                if (this.Status != null)
                    hash = hash * 59 + this.Status.GetHashCode();
                if (this.StudentTeacherRatio != null)
                    hash = hash * 59 + this.StudentTeacherRatio.GetHashCode();
                if (this.Choice != null)
                    hash = hash * 59 + this.Choice.GetHashCode();
                if (this.Coextensiv != null)
                    hash = hash * 59 + this.Coextensiv.GetHashCode();
                if (this.SchoolDistricts != null)
                    hash = hash * 59 + this.SchoolDistricts.GetHashCode();
                if (this.SchoolProfile != null)
                    hash = hash * 59 + this.SchoolProfile.GetHashCode();
                if (this.GradeLevelsTaught != null)
                    hash = hash * 59 + this.GradeLevelsTaught.GetHashCode();
                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();
                if (this.Geometry != null)
                    hash = hash * 59 + this.Geometry.GetHashCode();
                return hash;
            }
        }
    }

}

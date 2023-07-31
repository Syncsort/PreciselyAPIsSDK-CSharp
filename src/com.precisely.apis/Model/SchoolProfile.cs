/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 16.0.1
 * 
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = com.precisely.apis.Client.OpenAPIDateConverter;

namespace com.precisely.apis.Model
{
    /// <summary>
    /// SchoolProfile
    /// </summary>
    [DataContract]
    public partial class SchoolProfile :  IEquatable<SchoolProfile>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolProfile" /> class.
        /// </summary>
        /// <param name="blueRibbon">blueRibbon.</param>
        /// <param name="internationalBaccalaureate">internationalBaccalaureate.</param>
        /// <param name="titleI">titleI.</param>
        /// <param name="expensePerStudent">expensePerStudent.</param>
        /// <param name="studentBelowPovertyPct">studentBelowPovertyPct.</param>
        /// <param name="advancePlacementClasses">advancePlacementClasses.</param>
        /// <param name="freeOrReducedPriceLunches">freeOrReducedPriceLunches.</param>
        /// <param name="studentEthnicity">studentEthnicity.</param>
        public SchoolProfile(string blueRibbon = default(string), string internationalBaccalaureate = default(string), string titleI = default(string), string expensePerStudent = default(string), string studentBelowPovertyPct = default(string), string advancePlacementClasses = default(string), FreeOrReducedPriceLunches freeOrReducedPriceLunches = default(FreeOrReducedPriceLunches), StudentEthnicity studentEthnicity = default(StudentEthnicity))
        {
            this.BlueRibbon = blueRibbon;
            this.InternationalBaccalaureate = internationalBaccalaureate;
            this.TitleI = titleI;
            this.ExpensePerStudent = expensePerStudent;
            this.StudentBelowPovertyPct = studentBelowPovertyPct;
            this.AdvancePlacementClasses = advancePlacementClasses;
            this.FreeOrReducedPriceLunches = freeOrReducedPriceLunches;
            this.StudentEthnicity = studentEthnicity;
        }

        /// <summary>
        /// Gets or Sets BlueRibbon
        /// </summary>
        [DataMember(Name="blueRibbon", EmitDefaultValue=false)]
        public string BlueRibbon { get; set; }

        /// <summary>
        /// Gets or Sets InternationalBaccalaureate
        /// </summary>
        [DataMember(Name="internationalBaccalaureate", EmitDefaultValue=false)]
        public string InternationalBaccalaureate { get; set; }

        /// <summary>
        /// Gets or Sets TitleI
        /// </summary>
        [DataMember(Name="titleI", EmitDefaultValue=false)]
        public string TitleI { get; set; }

        /// <summary>
        /// Gets or Sets ExpensePerStudent
        /// </summary>
        [DataMember(Name="expensePerStudent", EmitDefaultValue=false)]
        public string ExpensePerStudent { get; set; }

        /// <summary>
        /// Gets or Sets StudentBelowPovertyPct
        /// </summary>
        [DataMember(Name="studentBelowPovertyPct", EmitDefaultValue=false)]
        public string StudentBelowPovertyPct { get; set; }

        /// <summary>
        /// Gets or Sets AdvancePlacementClasses
        /// </summary>
        [DataMember(Name="advancePlacementClasses", EmitDefaultValue=false)]
        public string AdvancePlacementClasses { get; set; }

        /// <summary>
        /// Gets or Sets FreeOrReducedPriceLunches
        /// </summary>
        [DataMember(Name="freeOrReducedPriceLunches", EmitDefaultValue=false)]
        public FreeOrReducedPriceLunches FreeOrReducedPriceLunches { get; set; }

        /// <summary>
        /// Gets or Sets StudentEthnicity
        /// </summary>
        [DataMember(Name="studentEthnicity", EmitDefaultValue=false)]
        public StudentEthnicity StudentEthnicity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SchoolProfile {\n");
            sb.Append("  BlueRibbon: ").Append(BlueRibbon).Append("\n");
            sb.Append("  InternationalBaccalaureate: ").Append(InternationalBaccalaureate).Append("\n");
            sb.Append("  TitleI: ").Append(TitleI).Append("\n");
            sb.Append("  ExpensePerStudent: ").Append(ExpensePerStudent).Append("\n");
            sb.Append("  StudentBelowPovertyPct: ").Append(StudentBelowPovertyPct).Append("\n");
            sb.Append("  AdvancePlacementClasses: ").Append(AdvancePlacementClasses).Append("\n");
            sb.Append("  FreeOrReducedPriceLunches: ").Append(FreeOrReducedPriceLunches).Append("\n");
            sb.Append("  StudentEthnicity: ").Append(StudentEthnicity).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SchoolProfile);
        }

        /// <summary>
        /// Returns true if SchoolProfile instances are equal
        /// </summary>
        /// <param name="input">Instance of SchoolProfile to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchoolProfile input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BlueRibbon == input.BlueRibbon ||
                    (this.BlueRibbon != null &&
                    this.BlueRibbon.Equals(input.BlueRibbon))
                ) && 
                (
                    this.InternationalBaccalaureate == input.InternationalBaccalaureate ||
                    (this.InternationalBaccalaureate != null &&
                    this.InternationalBaccalaureate.Equals(input.InternationalBaccalaureate))
                ) && 
                (
                    this.TitleI == input.TitleI ||
                    (this.TitleI != null &&
                    this.TitleI.Equals(input.TitleI))
                ) && 
                (
                    this.ExpensePerStudent == input.ExpensePerStudent ||
                    (this.ExpensePerStudent != null &&
                    this.ExpensePerStudent.Equals(input.ExpensePerStudent))
                ) && 
                (
                    this.StudentBelowPovertyPct == input.StudentBelowPovertyPct ||
                    (this.StudentBelowPovertyPct != null &&
                    this.StudentBelowPovertyPct.Equals(input.StudentBelowPovertyPct))
                ) && 
                (
                    this.AdvancePlacementClasses == input.AdvancePlacementClasses ||
                    (this.AdvancePlacementClasses != null &&
                    this.AdvancePlacementClasses.Equals(input.AdvancePlacementClasses))
                ) && 
                (
                    this.FreeOrReducedPriceLunches == input.FreeOrReducedPriceLunches ||
                    (this.FreeOrReducedPriceLunches != null &&
                    this.FreeOrReducedPriceLunches.Equals(input.FreeOrReducedPriceLunches))
                ) && 
                (
                    this.StudentEthnicity == input.StudentEthnicity ||
                    (this.StudentEthnicity != null &&
                    this.StudentEthnicity.Equals(input.StudentEthnicity))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.BlueRibbon != null)
                    hashCode = hashCode * 59 + this.BlueRibbon.GetHashCode();
                if (this.InternationalBaccalaureate != null)
                    hashCode = hashCode * 59 + this.InternationalBaccalaureate.GetHashCode();
                if (this.TitleI != null)
                    hashCode = hashCode * 59 + this.TitleI.GetHashCode();
                if (this.ExpensePerStudent != null)
                    hashCode = hashCode * 59 + this.ExpensePerStudent.GetHashCode();
                if (this.StudentBelowPovertyPct != null)
                    hashCode = hashCode * 59 + this.StudentBelowPovertyPct.GetHashCode();
                if (this.AdvancePlacementClasses != null)
                    hashCode = hashCode * 59 + this.AdvancePlacementClasses.GetHashCode();
                if (this.FreeOrReducedPriceLunches != null)
                    hashCode = hashCode * 59 + this.FreeOrReducedPriceLunches.GetHashCode();
                if (this.StudentEthnicity != null)
                    hashCode = hashCode * 59 + this.StudentEthnicity.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}

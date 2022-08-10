/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 12.0.0
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
    /// DemographicsThemesV2
    /// </summary>
    [DataContract]
    public partial class DemographicsThemesV2 :  IEquatable<DemographicsThemesV2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DemographicsThemesV2" /> class.
        /// </summary>
        /// <param name="boundaryId">boundaryId.</param>
        /// <param name="populationTheme">populationTheme.</param>
        /// <param name="raceAndEthnicityTheme">raceAndEthnicityTheme.</param>
        /// <param name="healthTheme">healthTheme.</param>
        /// <param name="educationTheme">educationTheme.</param>
        /// <param name="incomeTheme">incomeTheme.</param>
        /// <param name="assetsAndWealthTheme">assetsAndWealthTheme.</param>
        /// <param name="householdsTheme">householdsTheme.</param>
        /// <param name="housingTheme">housingTheme.</param>
        /// <param name="employmentTheme">employmentTheme.</param>
        /// <param name="expenditureTheme">expenditureTheme.</param>
        /// <param name="supplyAndDemandTheme">supplyAndDemandTheme.</param>
        public DemographicsThemesV2(string boundaryId = default(string), PopulationTheme populationTheme = default(PopulationTheme), RaceAndEthnicityTheme raceAndEthnicityTheme = default(RaceAndEthnicityTheme), HealthTheme healthTheme = default(HealthTheme), EducationTheme educationTheme = default(EducationTheme), IncomeTheme incomeTheme = default(IncomeTheme), AssetsAndWealthTheme assetsAndWealthTheme = default(AssetsAndWealthTheme), HouseholdsTheme householdsTheme = default(HouseholdsTheme), HousingTheme housingTheme = default(HousingTheme), EmploymentTheme employmentTheme = default(EmploymentTheme), ExpenditureTheme expenditureTheme = default(ExpenditureTheme), SupplyAndDemandTheme supplyAndDemandTheme = default(SupplyAndDemandTheme))
        {
            this.BoundaryId = boundaryId;
            this.PopulationTheme = populationTheme;
            this.RaceAndEthnicityTheme = raceAndEthnicityTheme;
            this.HealthTheme = healthTheme;
            this.EducationTheme = educationTheme;
            this.IncomeTheme = incomeTheme;
            this.AssetsAndWealthTheme = assetsAndWealthTheme;
            this.HouseholdsTheme = householdsTheme;
            this.HousingTheme = housingTheme;
            this.EmploymentTheme = employmentTheme;
            this.ExpenditureTheme = expenditureTheme;
            this.SupplyAndDemandTheme = supplyAndDemandTheme;
        }

        /// <summary>
        /// Gets or Sets BoundaryId
        /// </summary>
        [DataMember(Name="boundaryId", EmitDefaultValue=false)]
        public string BoundaryId { get; set; }

        /// <summary>
        /// Gets or Sets PopulationTheme
        /// </summary>
        [DataMember(Name="populationTheme", EmitDefaultValue=false)]
        public PopulationTheme PopulationTheme { get; set; }

        /// <summary>
        /// Gets or Sets RaceAndEthnicityTheme
        /// </summary>
        [DataMember(Name="raceAndEthnicityTheme", EmitDefaultValue=false)]
        public RaceAndEthnicityTheme RaceAndEthnicityTheme { get; set; }

        /// <summary>
        /// Gets or Sets HealthTheme
        /// </summary>
        [DataMember(Name="healthTheme", EmitDefaultValue=false)]
        public HealthTheme HealthTheme { get; set; }

        /// <summary>
        /// Gets or Sets EducationTheme
        /// </summary>
        [DataMember(Name="educationTheme", EmitDefaultValue=false)]
        public EducationTheme EducationTheme { get; set; }

        /// <summary>
        /// Gets or Sets IncomeTheme
        /// </summary>
        [DataMember(Name="incomeTheme", EmitDefaultValue=false)]
        public IncomeTheme IncomeTheme { get; set; }

        /// <summary>
        /// Gets or Sets AssetsAndWealthTheme
        /// </summary>
        [DataMember(Name="assetsAndWealthTheme", EmitDefaultValue=false)]
        public AssetsAndWealthTheme AssetsAndWealthTheme { get; set; }

        /// <summary>
        /// Gets or Sets HouseholdsTheme
        /// </summary>
        [DataMember(Name="householdsTheme", EmitDefaultValue=false)]
        public HouseholdsTheme HouseholdsTheme { get; set; }

        /// <summary>
        /// Gets or Sets HousingTheme
        /// </summary>
        [DataMember(Name="housingTheme", EmitDefaultValue=false)]
        public HousingTheme HousingTheme { get; set; }

        /// <summary>
        /// Gets or Sets EmploymentTheme
        /// </summary>
        [DataMember(Name="employmentTheme", EmitDefaultValue=false)]
        public EmploymentTheme EmploymentTheme { get; set; }

        /// <summary>
        /// Gets or Sets ExpenditureTheme
        /// </summary>
        [DataMember(Name="expenditureTheme", EmitDefaultValue=false)]
        public ExpenditureTheme ExpenditureTheme { get; set; }

        /// <summary>
        /// Gets or Sets SupplyAndDemandTheme
        /// </summary>
        [DataMember(Name="supplyAndDemandTheme", EmitDefaultValue=false)]
        public SupplyAndDemandTheme SupplyAndDemandTheme { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DemographicsThemesV2 {\n");
            sb.Append("  BoundaryId: ").Append(BoundaryId).Append("\n");
            sb.Append("  PopulationTheme: ").Append(PopulationTheme).Append("\n");
            sb.Append("  RaceAndEthnicityTheme: ").Append(RaceAndEthnicityTheme).Append("\n");
            sb.Append("  HealthTheme: ").Append(HealthTheme).Append("\n");
            sb.Append("  EducationTheme: ").Append(EducationTheme).Append("\n");
            sb.Append("  IncomeTheme: ").Append(IncomeTheme).Append("\n");
            sb.Append("  AssetsAndWealthTheme: ").Append(AssetsAndWealthTheme).Append("\n");
            sb.Append("  HouseholdsTheme: ").Append(HouseholdsTheme).Append("\n");
            sb.Append("  HousingTheme: ").Append(HousingTheme).Append("\n");
            sb.Append("  EmploymentTheme: ").Append(EmploymentTheme).Append("\n");
            sb.Append("  ExpenditureTheme: ").Append(ExpenditureTheme).Append("\n");
            sb.Append("  SupplyAndDemandTheme: ").Append(SupplyAndDemandTheme).Append("\n");
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
            return this.Equals(input as DemographicsThemesV2);
        }

        /// <summary>
        /// Returns true if DemographicsThemesV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of DemographicsThemesV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DemographicsThemesV2 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BoundaryId == input.BoundaryId ||
                    (this.BoundaryId != null &&
                    this.BoundaryId.Equals(input.BoundaryId))
                ) && 
                (
                    this.PopulationTheme == input.PopulationTheme ||
                    (this.PopulationTheme != null &&
                    this.PopulationTheme.Equals(input.PopulationTheme))
                ) && 
                (
                    this.RaceAndEthnicityTheme == input.RaceAndEthnicityTheme ||
                    (this.RaceAndEthnicityTheme != null &&
                    this.RaceAndEthnicityTheme.Equals(input.RaceAndEthnicityTheme))
                ) && 
                (
                    this.HealthTheme == input.HealthTheme ||
                    (this.HealthTheme != null &&
                    this.HealthTheme.Equals(input.HealthTheme))
                ) && 
                (
                    this.EducationTheme == input.EducationTheme ||
                    (this.EducationTheme != null &&
                    this.EducationTheme.Equals(input.EducationTheme))
                ) && 
                (
                    this.IncomeTheme == input.IncomeTheme ||
                    (this.IncomeTheme != null &&
                    this.IncomeTheme.Equals(input.IncomeTheme))
                ) && 
                (
                    this.AssetsAndWealthTheme == input.AssetsAndWealthTheme ||
                    (this.AssetsAndWealthTheme != null &&
                    this.AssetsAndWealthTheme.Equals(input.AssetsAndWealthTheme))
                ) && 
                (
                    this.HouseholdsTheme == input.HouseholdsTheme ||
                    (this.HouseholdsTheme != null &&
                    this.HouseholdsTheme.Equals(input.HouseholdsTheme))
                ) && 
                (
                    this.HousingTheme == input.HousingTheme ||
                    (this.HousingTheme != null &&
                    this.HousingTheme.Equals(input.HousingTheme))
                ) && 
                (
                    this.EmploymentTheme == input.EmploymentTheme ||
                    (this.EmploymentTheme != null &&
                    this.EmploymentTheme.Equals(input.EmploymentTheme))
                ) && 
                (
                    this.ExpenditureTheme == input.ExpenditureTheme ||
                    (this.ExpenditureTheme != null &&
                    this.ExpenditureTheme.Equals(input.ExpenditureTheme))
                ) && 
                (
                    this.SupplyAndDemandTheme == input.SupplyAndDemandTheme ||
                    (this.SupplyAndDemandTheme != null &&
                    this.SupplyAndDemandTheme.Equals(input.SupplyAndDemandTheme))
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
                if (this.BoundaryId != null)
                    hashCode = hashCode * 59 + this.BoundaryId.GetHashCode();
                if (this.PopulationTheme != null)
                    hashCode = hashCode * 59 + this.PopulationTheme.GetHashCode();
                if (this.RaceAndEthnicityTheme != null)
                    hashCode = hashCode * 59 + this.RaceAndEthnicityTheme.GetHashCode();
                if (this.HealthTheme != null)
                    hashCode = hashCode * 59 + this.HealthTheme.GetHashCode();
                if (this.EducationTheme != null)
                    hashCode = hashCode * 59 + this.EducationTheme.GetHashCode();
                if (this.IncomeTheme != null)
                    hashCode = hashCode * 59 + this.IncomeTheme.GetHashCode();
                if (this.AssetsAndWealthTheme != null)
                    hashCode = hashCode * 59 + this.AssetsAndWealthTheme.GetHashCode();
                if (this.HouseholdsTheme != null)
                    hashCode = hashCode * 59 + this.HouseholdsTheme.GetHashCode();
                if (this.HousingTheme != null)
                    hashCode = hashCode * 59 + this.HousingTheme.GetHashCode();
                if (this.EmploymentTheme != null)
                    hashCode = hashCode * 59 + this.EmploymentTheme.GetHashCode();
                if (this.ExpenditureTheme != null)
                    hashCode = hashCode * 59 + this.ExpenditureTheme.GetHashCode();
                if (this.SupplyAndDemandTheme != null)
                    hashCode = hashCode * 59 + this.SupplyAndDemandTheme.GetHashCode();
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

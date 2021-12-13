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
    /// POIPlaces
    /// </summary>
    [DataContract]
    public partial class POIPlaces :  IEquatable<POIPlaces>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="POIPlaces" /> class.
        /// </summary>
        /// <param name="Id">Id.</param>
        /// <param name="PoiId">PoiId.</param>
        /// <param name="Pbkey">Pbkey.</param>
        /// <param name="ParentPbkey">ParentPbkey.</param>
        /// <param name="GeocodeConfidence">GeocodeConfidence.</param>
        /// <param name="CeoName">CeoName.</param>
        /// <param name="CeoTitle">CeoTitle.</param>
        /// <param name="Name">Name.</param>
        /// <param name="BrandName">BrandName.</param>
        /// <param name="TradeName">TradeName.</param>
        /// <param name="FranchiseName">FranchiseName.</param>
        /// <param name="Open24Hours">Open24Hours.</param>
        /// <param name="Distance">Distance.</param>
        /// <param name="BusinessId">BusinessId.</param>
        /// <param name="RelevanceScore">RelevanceScore.</param>
        /// <param name="ContactDetails">ContactDetails.</param>
        /// <param name="PoiClassification">PoiClassification.</param>
        /// <param name="SalesVolume">SalesVolume.</param>
        /// <param name="EmployeeCount">EmployeeCount.</param>
        /// <param name="YearStart">YearStart.</param>
        /// <param name="GoodsAgentCode">GoodsAgentCode.</param>
        /// <param name="GoodsAgentCodeDescription">GoodsAgentCodeDescription.</param>
        /// <param name="LegalStatusCode">LegalStatusCode.</param>
        /// <param name="OrganizationStatusCode">OrganizationStatusCode.</param>
        /// <param name="OrganizationStatusCodeDescription">OrganizationStatusCodeDescription.</param>
        /// <param name="SubsidaryIndicator">SubsidaryIndicator.</param>
        /// <param name="SubsidaryIndicatorDescription">SubsidaryIndicatorDescription.</param>
        /// <param name="ParentBusiness">ParentBusiness.</param>
        /// <param name="DomesticUltimateBusiness">DomesticUltimateBusiness.</param>
        /// <param name="GlobalUltimateIndicator">GlobalUltimateIndicator.</param>
        /// <param name="GlobalUltimateBusiness">GlobalUltimateBusiness.</param>
        /// <param name="FamilyMembers">FamilyMembers.</param>
        /// <param name="HierarchyCode">HierarchyCode.</param>
        /// <param name="TickerSymbol">TickerSymbol.</param>
        /// <param name="ExchangeName">ExchangeName.</param>
        /// <param name="Geometry">Geometry.</param>
        public POIPlaces(string Id = null, string PoiId = null, string Pbkey = null, string ParentPbkey = null, string GeocodeConfidence = null, string CeoName = null, string CeoTitle = null, string Name = null, string BrandName = null, string TradeName = null, string FranchiseName = null, string Open24Hours = null, Distance Distance = null, BusinessId BusinessId = null, string RelevanceScore = null, PoiContactDetails ContactDetails = null, PoiClassification PoiClassification = null, List<SalesVolume> SalesVolume = null, EmployeeCount EmployeeCount = null, string YearStart = null, string GoodsAgentCode = null, string GoodsAgentCodeDescription = null, string LegalStatusCode = null, string OrganizationStatusCode = null, string OrganizationStatusCodeDescription = null, string SubsidaryIndicator = null, string SubsidaryIndicatorDescription = null, ParentBusiness ParentBusiness = null, DomesticUltimateBusiness DomesticUltimateBusiness = null, string GlobalUltimateIndicator = null, GlobalUltimateBusiness GlobalUltimateBusiness = null, string FamilyMembers = null, string HierarchyCode = null, string TickerSymbol = null, string ExchangeName = null, Geometry Geometry = null)
        {
            this.Id = Id;
            this.PoiId = PoiId;
            this.Pbkey = Pbkey;
            this.ParentPbkey = ParentPbkey;
            this.GeocodeConfidence = GeocodeConfidence;
            this.CeoName = CeoName;
            this.CeoTitle = CeoTitle;
            this.Name = Name;
            this.BrandName = BrandName;
            this.TradeName = TradeName;
            this.FranchiseName = FranchiseName;
            this.Open24Hours = Open24Hours;
            this.Distance = Distance;
            this.BusinessId = BusinessId;
            this.RelevanceScore = RelevanceScore;
            this.ContactDetails = ContactDetails;
            this.PoiClassification = PoiClassification;
            this.SalesVolume = SalesVolume;
            this.EmployeeCount = EmployeeCount;
            this.YearStart = YearStart;
            this.GoodsAgentCode = GoodsAgentCode;
            this.GoodsAgentCodeDescription = GoodsAgentCodeDescription;
            this.LegalStatusCode = LegalStatusCode;
            this.OrganizationStatusCode = OrganizationStatusCode;
            this.OrganizationStatusCodeDescription = OrganizationStatusCodeDescription;
            this.SubsidaryIndicator = SubsidaryIndicator;
            this.SubsidaryIndicatorDescription = SubsidaryIndicatorDescription;
            this.ParentBusiness = ParentBusiness;
            this.DomesticUltimateBusiness = DomesticUltimateBusiness;
            this.GlobalUltimateIndicator = GlobalUltimateIndicator;
            this.GlobalUltimateBusiness = GlobalUltimateBusiness;
            this.FamilyMembers = FamilyMembers;
            this.HierarchyCode = HierarchyCode;
            this.TickerSymbol = TickerSymbol;
            this.ExchangeName = ExchangeName;
            this.Geometry = Geometry;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }
        /// <summary>
        /// Gets or Sets PoiId
        /// </summary>
        [DataMember(Name="poiId", EmitDefaultValue=false)]
        public string PoiId { get; set; }
        /// <summary>
        /// Gets or Sets Pbkey
        /// </summary>
        [DataMember(Name="pbkey", EmitDefaultValue=false)]
        public string Pbkey { get; set; }
        /// <summary>
        /// Gets or Sets ParentPbkey
        /// </summary>
        [DataMember(Name="parentPbkey", EmitDefaultValue=false)]
        public string ParentPbkey { get; set; }
        /// <summary>
        /// Gets or Sets GeocodeConfidence
        /// </summary>
        [DataMember(Name="geocodeConfidence", EmitDefaultValue=false)]
        public string GeocodeConfidence { get; set; }
        /// <summary>
        /// Gets or Sets CeoName
        /// </summary>
        [DataMember(Name="ceoName", EmitDefaultValue=false)]
        public string CeoName { get; set; }
        /// <summary>
        /// Gets or Sets CeoTitle
        /// </summary>
        [DataMember(Name="ceoTitle", EmitDefaultValue=false)]
        public string CeoTitle { get; set; }
        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }
        /// <summary>
        /// Gets or Sets BrandName
        /// </summary>
        [DataMember(Name="brandName", EmitDefaultValue=false)]
        public string BrandName { get; set; }
        /// <summary>
        /// Gets or Sets TradeName
        /// </summary>
        [DataMember(Name="tradeName", EmitDefaultValue=false)]
        public string TradeName { get; set; }
        /// <summary>
        /// Gets or Sets FranchiseName
        /// </summary>
        [DataMember(Name="franchiseName", EmitDefaultValue=false)]
        public string FranchiseName { get; set; }
        /// <summary>
        /// Gets or Sets Open24Hours
        /// </summary>
        [DataMember(Name="open24Hours", EmitDefaultValue=false)]
        public string Open24Hours { get; set; }
        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=false)]
        public Distance Distance { get; set; }
        /// <summary>
        /// Gets or Sets BusinessId
        /// </summary>
        [DataMember(Name="businessId", EmitDefaultValue=false)]
        public BusinessId BusinessId { get; set; }
        /// <summary>
        /// Gets or Sets RelevanceScore
        /// </summary>
        [DataMember(Name="relevanceScore", EmitDefaultValue=false)]
        public string RelevanceScore { get; set; }
        /// <summary>
        /// Gets or Sets ContactDetails
        /// </summary>
        [DataMember(Name="contactDetails", EmitDefaultValue=false)]
        public PoiContactDetails ContactDetails { get; set; }
        /// <summary>
        /// Gets or Sets PoiClassification
        /// </summary>
        [DataMember(Name="poiClassification", EmitDefaultValue=false)]
        public PoiClassification PoiClassification { get; set; }
        /// <summary>
        /// Gets or Sets SalesVolume
        /// </summary>
        [DataMember(Name="salesVolume", EmitDefaultValue=false)]
        public List<SalesVolume> SalesVolume { get; set; }
        /// <summary>
        /// Gets or Sets EmployeeCount
        /// </summary>
        [DataMember(Name="employeeCount", EmitDefaultValue=false)]
        public EmployeeCount EmployeeCount { get; set; }
        /// <summary>
        /// Gets or Sets YearStart
        /// </summary>
        [DataMember(Name="yearStart", EmitDefaultValue=false)]
        public string YearStart { get; set; }
        /// <summary>
        /// Gets or Sets GoodsAgentCode
        /// </summary>
        [DataMember(Name="goodsAgentCode", EmitDefaultValue=false)]
        public string GoodsAgentCode { get; set; }
        /// <summary>
        /// Gets or Sets GoodsAgentCodeDescription
        /// </summary>
        [DataMember(Name="goodsAgentCodeDescription", EmitDefaultValue=false)]
        public string GoodsAgentCodeDescription { get; set; }
        /// <summary>
        /// Gets or Sets LegalStatusCode
        /// </summary>
        [DataMember(Name="legalStatusCode", EmitDefaultValue=false)]
        public string LegalStatusCode { get; set; }
        /// <summary>
        /// Gets or Sets OrganizationStatusCode
        /// </summary>
        [DataMember(Name="organizationStatusCode", EmitDefaultValue=false)]
        public string OrganizationStatusCode { get; set; }
        /// <summary>
        /// Gets or Sets OrganizationStatusCodeDescription
        /// </summary>
        [DataMember(Name="organizationStatusCodeDescription", EmitDefaultValue=false)]
        public string OrganizationStatusCodeDescription { get; set; }
        /// <summary>
        /// Gets or Sets SubsidaryIndicator
        /// </summary>
        [DataMember(Name="subsidaryIndicator", EmitDefaultValue=false)]
        public string SubsidaryIndicator { get; set; }
        /// <summary>
        /// Gets or Sets SubsidaryIndicatorDescription
        /// </summary>
        [DataMember(Name="subsidaryIndicatorDescription", EmitDefaultValue=false)]
        public string SubsidaryIndicatorDescription { get; set; }
        /// <summary>
        /// Gets or Sets ParentBusiness
        /// </summary>
        [DataMember(Name="parentBusiness", EmitDefaultValue=false)]
        public ParentBusiness ParentBusiness { get; set; }
        /// <summary>
        /// Gets or Sets DomesticUltimateBusiness
        /// </summary>
        [DataMember(Name="domesticUltimateBusiness", EmitDefaultValue=false)]
        public DomesticUltimateBusiness DomesticUltimateBusiness { get; set; }
        /// <summary>
        /// Gets or Sets GlobalUltimateIndicator
        /// </summary>
        [DataMember(Name="globalUltimateIndicator", EmitDefaultValue=false)]
        public string GlobalUltimateIndicator { get; set; }
        /// <summary>
        /// Gets or Sets GlobalUltimateBusiness
        /// </summary>
        [DataMember(Name="globalUltimateBusiness", EmitDefaultValue=false)]
        public GlobalUltimateBusiness GlobalUltimateBusiness { get; set; }
        /// <summary>
        /// Gets or Sets FamilyMembers
        /// </summary>
        [DataMember(Name="familyMembers", EmitDefaultValue=false)]
        public string FamilyMembers { get; set; }
        /// <summary>
        /// Gets or Sets HierarchyCode
        /// </summary>
        [DataMember(Name="hierarchyCode", EmitDefaultValue=false)]
        public string HierarchyCode { get; set; }
        /// <summary>
        /// Gets or Sets TickerSymbol
        /// </summary>
        [DataMember(Name="tickerSymbol", EmitDefaultValue=false)]
        public string TickerSymbol { get; set; }
        /// <summary>
        /// Gets or Sets ExchangeName
        /// </summary>
        [DataMember(Name="exchangeName", EmitDefaultValue=false)]
        public string ExchangeName { get; set; }
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
            sb.Append("class POIPlaces {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PoiId: ").Append(PoiId).Append("\n");
            sb.Append("  Pbkey: ").Append(Pbkey).Append("\n");
            sb.Append("  ParentPbkey: ").Append(ParentPbkey).Append("\n");
            sb.Append("  GeocodeConfidence: ").Append(GeocodeConfidence).Append("\n");
            sb.Append("  CeoName: ").Append(CeoName).Append("\n");
            sb.Append("  CeoTitle: ").Append(CeoTitle).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  BrandName: ").Append(BrandName).Append("\n");
            sb.Append("  TradeName: ").Append(TradeName).Append("\n");
            sb.Append("  FranchiseName: ").Append(FranchiseName).Append("\n");
            sb.Append("  Open24Hours: ").Append(Open24Hours).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  BusinessId: ").Append(BusinessId).Append("\n");
            sb.Append("  RelevanceScore: ").Append(RelevanceScore).Append("\n");
            sb.Append("  ContactDetails: ").Append(ContactDetails).Append("\n");
            sb.Append("  PoiClassification: ").Append(PoiClassification).Append("\n");
            sb.Append("  SalesVolume: ").Append(SalesVolume).Append("\n");
            sb.Append("  EmployeeCount: ").Append(EmployeeCount).Append("\n");
            sb.Append("  YearStart: ").Append(YearStart).Append("\n");
            sb.Append("  GoodsAgentCode: ").Append(GoodsAgentCode).Append("\n");
            sb.Append("  GoodsAgentCodeDescription: ").Append(GoodsAgentCodeDescription).Append("\n");
            sb.Append("  LegalStatusCode: ").Append(LegalStatusCode).Append("\n");
            sb.Append("  OrganizationStatusCode: ").Append(OrganizationStatusCode).Append("\n");
            sb.Append("  OrganizationStatusCodeDescription: ").Append(OrganizationStatusCodeDescription).Append("\n");
            sb.Append("  SubsidaryIndicator: ").Append(SubsidaryIndicator).Append("\n");
            sb.Append("  SubsidaryIndicatorDescription: ").Append(SubsidaryIndicatorDescription).Append("\n");
            sb.Append("  ParentBusiness: ").Append(ParentBusiness).Append("\n");
            sb.Append("  DomesticUltimateBusiness: ").Append(DomesticUltimateBusiness).Append("\n");
            sb.Append("  GlobalUltimateIndicator: ").Append(GlobalUltimateIndicator).Append("\n");
            sb.Append("  GlobalUltimateBusiness: ").Append(GlobalUltimateBusiness).Append("\n");
            sb.Append("  FamilyMembers: ").Append(FamilyMembers).Append("\n");
            sb.Append("  HierarchyCode: ").Append(HierarchyCode).Append("\n");
            sb.Append("  TickerSymbol: ").Append(TickerSymbol).Append("\n");
            sb.Append("  ExchangeName: ").Append(ExchangeName).Append("\n");
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
            return this.Equals(obj as POIPlaces);
        }

        /// <summary>
        /// Returns true if POIPlaces instances are equal
        /// </summary>
        /// <param name="other">Instance of POIPlaces to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(POIPlaces other)
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
                    this.PoiId == other.PoiId ||
                    this.PoiId != null &&
                    this.PoiId.Equals(other.PoiId)
                ) && 
                (
                    this.Pbkey == other.Pbkey ||
                    this.Pbkey != null &&
                    this.Pbkey.Equals(other.Pbkey)
                ) && 
                (
                    this.ParentPbkey == other.ParentPbkey ||
                    this.ParentPbkey != null &&
                    this.ParentPbkey.Equals(other.ParentPbkey)
                ) && 
                (
                    this.GeocodeConfidence == other.GeocodeConfidence ||
                    this.GeocodeConfidence != null &&
                    this.GeocodeConfidence.Equals(other.GeocodeConfidence)
                ) && 
                (
                    this.CeoName == other.CeoName ||
                    this.CeoName != null &&
                    this.CeoName.Equals(other.CeoName)
                ) && 
                (
                    this.CeoTitle == other.CeoTitle ||
                    this.CeoTitle != null &&
                    this.CeoTitle.Equals(other.CeoTitle)
                ) && 
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) && 
                (
                    this.BrandName == other.BrandName ||
                    this.BrandName != null &&
                    this.BrandName.Equals(other.BrandName)
                ) && 
                (
                    this.TradeName == other.TradeName ||
                    this.TradeName != null &&
                    this.TradeName.Equals(other.TradeName)
                ) && 
                (
                    this.FranchiseName == other.FranchiseName ||
                    this.FranchiseName != null &&
                    this.FranchiseName.Equals(other.FranchiseName)
                ) && 
                (
                    this.Open24Hours == other.Open24Hours ||
                    this.Open24Hours != null &&
                    this.Open24Hours.Equals(other.Open24Hours)
                ) && 
                (
                    this.Distance == other.Distance ||
                    this.Distance != null &&
                    this.Distance.Equals(other.Distance)
                ) && 
                (
                    this.BusinessId == other.BusinessId ||
                    this.BusinessId != null &&
                    this.BusinessId.Equals(other.BusinessId)
                ) && 
                (
                    this.RelevanceScore == other.RelevanceScore ||
                    this.RelevanceScore != null &&
                    this.RelevanceScore.Equals(other.RelevanceScore)
                ) && 
                (
                    this.ContactDetails == other.ContactDetails ||
                    this.ContactDetails != null &&
                    this.ContactDetails.Equals(other.ContactDetails)
                ) && 
                (
                    this.PoiClassification == other.PoiClassification ||
                    this.PoiClassification != null &&
                    this.PoiClassification.Equals(other.PoiClassification)
                ) && 
                (
                    this.SalesVolume == other.SalesVolume ||
                    this.SalesVolume != null &&
                    this.SalesVolume.SequenceEqual(other.SalesVolume)
                ) && 
                (
                    this.EmployeeCount == other.EmployeeCount ||
                    this.EmployeeCount != null &&
                    this.EmployeeCount.Equals(other.EmployeeCount)
                ) && 
                (
                    this.YearStart == other.YearStart ||
                    this.YearStart != null &&
                    this.YearStart.Equals(other.YearStart)
                ) && 
                (
                    this.GoodsAgentCode == other.GoodsAgentCode ||
                    this.GoodsAgentCode != null &&
                    this.GoodsAgentCode.Equals(other.GoodsAgentCode)
                ) && 
                (
                    this.GoodsAgentCodeDescription == other.GoodsAgentCodeDescription ||
                    this.GoodsAgentCodeDescription != null &&
                    this.GoodsAgentCodeDescription.Equals(other.GoodsAgentCodeDescription)
                ) && 
                (
                    this.LegalStatusCode == other.LegalStatusCode ||
                    this.LegalStatusCode != null &&
                    this.LegalStatusCode.Equals(other.LegalStatusCode)
                ) && 
                (
                    this.OrganizationStatusCode == other.OrganizationStatusCode ||
                    this.OrganizationStatusCode != null &&
                    this.OrganizationStatusCode.Equals(other.OrganizationStatusCode)
                ) && 
                (
                    this.OrganizationStatusCodeDescription == other.OrganizationStatusCodeDescription ||
                    this.OrganizationStatusCodeDescription != null &&
                    this.OrganizationStatusCodeDescription.Equals(other.OrganizationStatusCodeDescription)
                ) && 
                (
                    this.SubsidaryIndicator == other.SubsidaryIndicator ||
                    this.SubsidaryIndicator != null &&
                    this.SubsidaryIndicator.Equals(other.SubsidaryIndicator)
                ) && 
                (
                    this.SubsidaryIndicatorDescription == other.SubsidaryIndicatorDescription ||
                    this.SubsidaryIndicatorDescription != null &&
                    this.SubsidaryIndicatorDescription.Equals(other.SubsidaryIndicatorDescription)
                ) && 
                (
                    this.ParentBusiness == other.ParentBusiness ||
                    this.ParentBusiness != null &&
                    this.ParentBusiness.Equals(other.ParentBusiness)
                ) && 
                (
                    this.DomesticUltimateBusiness == other.DomesticUltimateBusiness ||
                    this.DomesticUltimateBusiness != null &&
                    this.DomesticUltimateBusiness.Equals(other.DomesticUltimateBusiness)
                ) && 
                (
                    this.GlobalUltimateIndicator == other.GlobalUltimateIndicator ||
                    this.GlobalUltimateIndicator != null &&
                    this.GlobalUltimateIndicator.Equals(other.GlobalUltimateIndicator)
                ) && 
                (
                    this.GlobalUltimateBusiness == other.GlobalUltimateBusiness ||
                    this.GlobalUltimateBusiness != null &&
                    this.GlobalUltimateBusiness.Equals(other.GlobalUltimateBusiness)
                ) && 
                (
                    this.FamilyMembers == other.FamilyMembers ||
                    this.FamilyMembers != null &&
                    this.FamilyMembers.Equals(other.FamilyMembers)
                ) && 
                (
                    this.HierarchyCode == other.HierarchyCode ||
                    this.HierarchyCode != null &&
                    this.HierarchyCode.Equals(other.HierarchyCode)
                ) && 
                (
                    this.TickerSymbol == other.TickerSymbol ||
                    this.TickerSymbol != null &&
                    this.TickerSymbol.Equals(other.TickerSymbol)
                ) && 
                (
                    this.ExchangeName == other.ExchangeName ||
                    this.ExchangeName != null &&
                    this.ExchangeName.Equals(other.ExchangeName)
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
                if (this.PoiId != null)
                    hash = hash * 59 + this.PoiId.GetHashCode();
                if (this.Pbkey != null)
                    hash = hash * 59 + this.Pbkey.GetHashCode();
                if (this.ParentPbkey != null)
                    hash = hash * 59 + this.ParentPbkey.GetHashCode();
                if (this.GeocodeConfidence != null)
                    hash = hash * 59 + this.GeocodeConfidence.GetHashCode();
                if (this.CeoName != null)
                    hash = hash * 59 + this.CeoName.GetHashCode();
                if (this.CeoTitle != null)
                    hash = hash * 59 + this.CeoTitle.GetHashCode();
                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();
                if (this.BrandName != null)
                    hash = hash * 59 + this.BrandName.GetHashCode();
                if (this.TradeName != null)
                    hash = hash * 59 + this.TradeName.GetHashCode();
                if (this.FranchiseName != null)
                    hash = hash * 59 + this.FranchiseName.GetHashCode();
                if (this.Open24Hours != null)
                    hash = hash * 59 + this.Open24Hours.GetHashCode();
                if (this.Distance != null)
                    hash = hash * 59 + this.Distance.GetHashCode();
                if (this.BusinessId != null)
                    hash = hash * 59 + this.BusinessId.GetHashCode();
                if (this.RelevanceScore != null)
                    hash = hash * 59 + this.RelevanceScore.GetHashCode();
                if (this.ContactDetails != null)
                    hash = hash * 59 + this.ContactDetails.GetHashCode();
                if (this.PoiClassification != null)
                    hash = hash * 59 + this.PoiClassification.GetHashCode();
                if (this.SalesVolume != null)
                    hash = hash * 59 + this.SalesVolume.GetHashCode();
                if (this.EmployeeCount != null)
                    hash = hash * 59 + this.EmployeeCount.GetHashCode();
                if (this.YearStart != null)
                    hash = hash * 59 + this.YearStart.GetHashCode();
                if (this.GoodsAgentCode != null)
                    hash = hash * 59 + this.GoodsAgentCode.GetHashCode();
                if (this.GoodsAgentCodeDescription != null)
                    hash = hash * 59 + this.GoodsAgentCodeDescription.GetHashCode();
                if (this.LegalStatusCode != null)
                    hash = hash * 59 + this.LegalStatusCode.GetHashCode();
                if (this.OrganizationStatusCode != null)
                    hash = hash * 59 + this.OrganizationStatusCode.GetHashCode();
                if (this.OrganizationStatusCodeDescription != null)
                    hash = hash * 59 + this.OrganizationStatusCodeDescription.GetHashCode();
                if (this.SubsidaryIndicator != null)
                    hash = hash * 59 + this.SubsidaryIndicator.GetHashCode();
                if (this.SubsidaryIndicatorDescription != null)
                    hash = hash * 59 + this.SubsidaryIndicatorDescription.GetHashCode();
                if (this.ParentBusiness != null)
                    hash = hash * 59 + this.ParentBusiness.GetHashCode();
                if (this.DomesticUltimateBusiness != null)
                    hash = hash * 59 + this.DomesticUltimateBusiness.GetHashCode();
                if (this.GlobalUltimateIndicator != null)
                    hash = hash * 59 + this.GlobalUltimateIndicator.GetHashCode();
                if (this.GlobalUltimateBusiness != null)
                    hash = hash * 59 + this.GlobalUltimateBusiness.GetHashCode();
                if (this.FamilyMembers != null)
                    hash = hash * 59 + this.FamilyMembers.GetHashCode();
                if (this.HierarchyCode != null)
                    hash = hash * 59 + this.HierarchyCode.GetHashCode();
                if (this.TickerSymbol != null)
                    hash = hash * 59 + this.TickerSymbol.GetHashCode();
                if (this.ExchangeName != null)
                    hash = hash * 59 + this.ExchangeName.GetHashCode();
                if (this.Geometry != null)
                    hash = hash * 59 + this.Geometry.GetHashCode();
                return hash;
            }
        }
    }

}

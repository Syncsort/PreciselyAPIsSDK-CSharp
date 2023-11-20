/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 17.1.0
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
    /// Poi
    /// </summary>
    [DataContract]
    public partial class Poi :  IEquatable<Poi>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Poi" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="poiId">poiId.</param>
        /// <param name="name">name.</param>
        /// <param name="pbkey">pbkey.</param>
        /// <param name="parentPbkey">parentPbkey.</param>
        /// <param name="geocodeConfidence">geocodeConfidence.</param>
        /// <param name="brandName">brandName.</param>
        /// <param name="tradeName">tradeName.</param>
        /// <param name="franchiseName">franchiseName.</param>
        /// <param name="open24Hours">open24Hours.</param>
        /// <param name="distance">distance.</param>
        /// <param name="businessId">businessId.</param>
        /// <param name="relevanceScore">relevanceScore.</param>
        /// <param name="contactDetails">contactDetails.</param>
        /// <param name="poiClassification">poiClassification.</param>
        /// <param name="salesVolume">salesVolume.</param>
        /// <param name="employeeCount">employeeCount.</param>
        /// <param name="yearStart">yearStart.</param>
        /// <param name="goodsAgentCode">goodsAgentCode.</param>
        /// <param name="goodsAgentCodeDescription">goodsAgentCodeDescription.</param>
        /// <param name="legalStatusCode">legalStatusCode.</param>
        /// <param name="organizationStatusCode">organizationStatusCode.</param>
        /// <param name="organizationStatusCodeDescription">organizationStatusCodeDescription.</param>
        /// <param name="subsidaryIndicator">subsidaryIndicator.</param>
        /// <param name="subsidaryIndicatorDescription">subsidaryIndicatorDescription.</param>
        /// <param name="parentBusiness">parentBusiness.</param>
        /// <param name="domesticUltimateBusiness">domesticUltimateBusiness.</param>
        /// <param name="globalUltimateIndicator">globalUltimateIndicator.</param>
        /// <param name="globalUltimateBusiness">globalUltimateBusiness.</param>
        /// <param name="familyMembers">familyMembers.</param>
        /// <param name="hierarchyCode">hierarchyCode.</param>
        /// <param name="tickerSymbol">tickerSymbol.</param>
        /// <param name="exchangeName">exchangeName.</param>
        /// <param name="ceoName">ceoName.</param>
        /// <param name="ceoTitle">ceoTitle.</param>
        /// <param name="geometry">geometry.</param>
        public Poi(string id = default(string), string poiId = default(string), string name = default(string), string pbkey = default(string), string parentPbkey = default(string), string geocodeConfidence = default(string), string brandName = default(string), string tradeName = default(string), string franchiseName = default(string), string open24Hours = default(string), Distance distance = default(Distance), BusinessId businessId = default(BusinessId), string relevanceScore = default(string), ContactDetails contactDetails = default(ContactDetails), PoiClassification poiClassification = default(PoiClassification), List<SalesVolume> salesVolume = default(List<SalesVolume>), EmployeeCount employeeCount = default(EmployeeCount), string yearStart = default(string), string goodsAgentCode = default(string), string goodsAgentCodeDescription = default(string), string legalStatusCode = default(string), string organizationStatusCode = default(string), string organizationStatusCodeDescription = default(string), string subsidaryIndicator = default(string), string subsidaryIndicatorDescription = default(string), ParentBusiness parentBusiness = default(ParentBusiness), DomesticUltimateBusiness domesticUltimateBusiness = default(DomesticUltimateBusiness), string globalUltimateIndicator = default(string), GlobalUltimateBusiness globalUltimateBusiness = default(GlobalUltimateBusiness), string familyMembers = default(string), string hierarchyCode = default(string), string tickerSymbol = default(string), string exchangeName = default(string), string ceoName = default(string), string ceoTitle = default(string), Geometry geometry = default(Geometry))
        {
            this.Id = id;
            this.PoiId = poiId;
            this.Name = name;
            this.Pbkey = pbkey;
            this.ParentPbkey = parentPbkey;
            this.GeocodeConfidence = geocodeConfidence;
            this.BrandName = brandName;
            this.TradeName = tradeName;
            this.FranchiseName = franchiseName;
            this.Open24Hours = open24Hours;
            this.Distance = distance;
            this.BusinessId = businessId;
            this.RelevanceScore = relevanceScore;
            this.ContactDetails = contactDetails;
            this.PoiClassification = poiClassification;
            this.SalesVolume = salesVolume;
            this.EmployeeCount = employeeCount;
            this.YearStart = yearStart;
            this.GoodsAgentCode = goodsAgentCode;
            this.GoodsAgentCodeDescription = goodsAgentCodeDescription;
            this.LegalStatusCode = legalStatusCode;
            this.OrganizationStatusCode = organizationStatusCode;
            this.OrganizationStatusCodeDescription = organizationStatusCodeDescription;
            this.SubsidaryIndicator = subsidaryIndicator;
            this.SubsidaryIndicatorDescription = subsidaryIndicatorDescription;
            this.ParentBusiness = parentBusiness;
            this.DomesticUltimateBusiness = domesticUltimateBusiness;
            this.GlobalUltimateIndicator = globalUltimateIndicator;
            this.GlobalUltimateBusiness = globalUltimateBusiness;
            this.FamilyMembers = familyMembers;
            this.HierarchyCode = hierarchyCode;
            this.TickerSymbol = tickerSymbol;
            this.ExchangeName = exchangeName;
            this.CeoName = ceoName;
            this.CeoTitle = ceoTitle;
            this.Geometry = geometry;
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
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

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
        public ContactDetails ContactDetails { get; set; }

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
            sb.Append("class Poi {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  PoiId: ").Append(PoiId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Pbkey: ").Append(Pbkey).Append("\n");
            sb.Append("  ParentPbkey: ").Append(ParentPbkey).Append("\n");
            sb.Append("  GeocodeConfidence: ").Append(GeocodeConfidence).Append("\n");
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
            sb.Append("  CeoName: ").Append(CeoName).Append("\n");
            sb.Append("  CeoTitle: ").Append(CeoTitle).Append("\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
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
            return this.Equals(input as Poi);
        }

        /// <summary>
        /// Returns true if Poi instances are equal
        /// </summary>
        /// <param name="input">Instance of Poi to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Poi input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.PoiId == input.PoiId ||
                    (this.PoiId != null &&
                    this.PoiId.Equals(input.PoiId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Pbkey == input.Pbkey ||
                    (this.Pbkey != null &&
                    this.Pbkey.Equals(input.Pbkey))
                ) && 
                (
                    this.ParentPbkey == input.ParentPbkey ||
                    (this.ParentPbkey != null &&
                    this.ParentPbkey.Equals(input.ParentPbkey))
                ) && 
                (
                    this.GeocodeConfidence == input.GeocodeConfidence ||
                    (this.GeocodeConfidence != null &&
                    this.GeocodeConfidence.Equals(input.GeocodeConfidence))
                ) && 
                (
                    this.BrandName == input.BrandName ||
                    (this.BrandName != null &&
                    this.BrandName.Equals(input.BrandName))
                ) && 
                (
                    this.TradeName == input.TradeName ||
                    (this.TradeName != null &&
                    this.TradeName.Equals(input.TradeName))
                ) && 
                (
                    this.FranchiseName == input.FranchiseName ||
                    (this.FranchiseName != null &&
                    this.FranchiseName.Equals(input.FranchiseName))
                ) && 
                (
                    this.Open24Hours == input.Open24Hours ||
                    (this.Open24Hours != null &&
                    this.Open24Hours.Equals(input.Open24Hours))
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.BusinessId == input.BusinessId ||
                    (this.BusinessId != null &&
                    this.BusinessId.Equals(input.BusinessId))
                ) && 
                (
                    this.RelevanceScore == input.RelevanceScore ||
                    (this.RelevanceScore != null &&
                    this.RelevanceScore.Equals(input.RelevanceScore))
                ) && 
                (
                    this.ContactDetails == input.ContactDetails ||
                    (this.ContactDetails != null &&
                    this.ContactDetails.Equals(input.ContactDetails))
                ) && 
                (
                    this.PoiClassification == input.PoiClassification ||
                    (this.PoiClassification != null &&
                    this.PoiClassification.Equals(input.PoiClassification))
                ) && 
                (
                    this.SalesVolume == input.SalesVolume ||
                    this.SalesVolume != null &&
                    input.SalesVolume != null &&
                    this.SalesVolume.SequenceEqual(input.SalesVolume)
                ) && 
                (
                    this.EmployeeCount == input.EmployeeCount ||
                    (this.EmployeeCount != null &&
                    this.EmployeeCount.Equals(input.EmployeeCount))
                ) && 
                (
                    this.YearStart == input.YearStart ||
                    (this.YearStart != null &&
                    this.YearStart.Equals(input.YearStart))
                ) && 
                (
                    this.GoodsAgentCode == input.GoodsAgentCode ||
                    (this.GoodsAgentCode != null &&
                    this.GoodsAgentCode.Equals(input.GoodsAgentCode))
                ) && 
                (
                    this.GoodsAgentCodeDescription == input.GoodsAgentCodeDescription ||
                    (this.GoodsAgentCodeDescription != null &&
                    this.GoodsAgentCodeDescription.Equals(input.GoodsAgentCodeDescription))
                ) && 
                (
                    this.LegalStatusCode == input.LegalStatusCode ||
                    (this.LegalStatusCode != null &&
                    this.LegalStatusCode.Equals(input.LegalStatusCode))
                ) && 
                (
                    this.OrganizationStatusCode == input.OrganizationStatusCode ||
                    (this.OrganizationStatusCode != null &&
                    this.OrganizationStatusCode.Equals(input.OrganizationStatusCode))
                ) && 
                (
                    this.OrganizationStatusCodeDescription == input.OrganizationStatusCodeDescription ||
                    (this.OrganizationStatusCodeDescription != null &&
                    this.OrganizationStatusCodeDescription.Equals(input.OrganizationStatusCodeDescription))
                ) && 
                (
                    this.SubsidaryIndicator == input.SubsidaryIndicator ||
                    (this.SubsidaryIndicator != null &&
                    this.SubsidaryIndicator.Equals(input.SubsidaryIndicator))
                ) && 
                (
                    this.SubsidaryIndicatorDescription == input.SubsidaryIndicatorDescription ||
                    (this.SubsidaryIndicatorDescription != null &&
                    this.SubsidaryIndicatorDescription.Equals(input.SubsidaryIndicatorDescription))
                ) && 
                (
                    this.ParentBusiness == input.ParentBusiness ||
                    (this.ParentBusiness != null &&
                    this.ParentBusiness.Equals(input.ParentBusiness))
                ) && 
                (
                    this.DomesticUltimateBusiness == input.DomesticUltimateBusiness ||
                    (this.DomesticUltimateBusiness != null &&
                    this.DomesticUltimateBusiness.Equals(input.DomesticUltimateBusiness))
                ) && 
                (
                    this.GlobalUltimateIndicator == input.GlobalUltimateIndicator ||
                    (this.GlobalUltimateIndicator != null &&
                    this.GlobalUltimateIndicator.Equals(input.GlobalUltimateIndicator))
                ) && 
                (
                    this.GlobalUltimateBusiness == input.GlobalUltimateBusiness ||
                    (this.GlobalUltimateBusiness != null &&
                    this.GlobalUltimateBusiness.Equals(input.GlobalUltimateBusiness))
                ) && 
                (
                    this.FamilyMembers == input.FamilyMembers ||
                    (this.FamilyMembers != null &&
                    this.FamilyMembers.Equals(input.FamilyMembers))
                ) && 
                (
                    this.HierarchyCode == input.HierarchyCode ||
                    (this.HierarchyCode != null &&
                    this.HierarchyCode.Equals(input.HierarchyCode))
                ) && 
                (
                    this.TickerSymbol == input.TickerSymbol ||
                    (this.TickerSymbol != null &&
                    this.TickerSymbol.Equals(input.TickerSymbol))
                ) && 
                (
                    this.ExchangeName == input.ExchangeName ||
                    (this.ExchangeName != null &&
                    this.ExchangeName.Equals(input.ExchangeName))
                ) && 
                (
                    this.CeoName == input.CeoName ||
                    (this.CeoName != null &&
                    this.CeoName.Equals(input.CeoName))
                ) && 
                (
                    this.CeoTitle == input.CeoTitle ||
                    (this.CeoTitle != null &&
                    this.CeoTitle.Equals(input.CeoTitle))
                ) && 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.PoiId != null)
                    hashCode = hashCode * 59 + this.PoiId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Pbkey != null)
                    hashCode = hashCode * 59 + this.Pbkey.GetHashCode();
                if (this.ParentPbkey != null)
                    hashCode = hashCode * 59 + this.ParentPbkey.GetHashCode();
                if (this.GeocodeConfidence != null)
                    hashCode = hashCode * 59 + this.GeocodeConfidence.GetHashCode();
                if (this.BrandName != null)
                    hashCode = hashCode * 59 + this.BrandName.GetHashCode();
                if (this.TradeName != null)
                    hashCode = hashCode * 59 + this.TradeName.GetHashCode();
                if (this.FranchiseName != null)
                    hashCode = hashCode * 59 + this.FranchiseName.GetHashCode();
                if (this.Open24Hours != null)
                    hashCode = hashCode * 59 + this.Open24Hours.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.BusinessId != null)
                    hashCode = hashCode * 59 + this.BusinessId.GetHashCode();
                if (this.RelevanceScore != null)
                    hashCode = hashCode * 59 + this.RelevanceScore.GetHashCode();
                if (this.ContactDetails != null)
                    hashCode = hashCode * 59 + this.ContactDetails.GetHashCode();
                if (this.PoiClassification != null)
                    hashCode = hashCode * 59 + this.PoiClassification.GetHashCode();
                if (this.SalesVolume != null)
                    hashCode = hashCode * 59 + this.SalesVolume.GetHashCode();
                if (this.EmployeeCount != null)
                    hashCode = hashCode * 59 + this.EmployeeCount.GetHashCode();
                if (this.YearStart != null)
                    hashCode = hashCode * 59 + this.YearStart.GetHashCode();
                if (this.GoodsAgentCode != null)
                    hashCode = hashCode * 59 + this.GoodsAgentCode.GetHashCode();
                if (this.GoodsAgentCodeDescription != null)
                    hashCode = hashCode * 59 + this.GoodsAgentCodeDescription.GetHashCode();
                if (this.LegalStatusCode != null)
                    hashCode = hashCode * 59 + this.LegalStatusCode.GetHashCode();
                if (this.OrganizationStatusCode != null)
                    hashCode = hashCode * 59 + this.OrganizationStatusCode.GetHashCode();
                if (this.OrganizationStatusCodeDescription != null)
                    hashCode = hashCode * 59 + this.OrganizationStatusCodeDescription.GetHashCode();
                if (this.SubsidaryIndicator != null)
                    hashCode = hashCode * 59 + this.SubsidaryIndicator.GetHashCode();
                if (this.SubsidaryIndicatorDescription != null)
                    hashCode = hashCode * 59 + this.SubsidaryIndicatorDescription.GetHashCode();
                if (this.ParentBusiness != null)
                    hashCode = hashCode * 59 + this.ParentBusiness.GetHashCode();
                if (this.DomesticUltimateBusiness != null)
                    hashCode = hashCode * 59 + this.DomesticUltimateBusiness.GetHashCode();
                if (this.GlobalUltimateIndicator != null)
                    hashCode = hashCode * 59 + this.GlobalUltimateIndicator.GetHashCode();
                if (this.GlobalUltimateBusiness != null)
                    hashCode = hashCode * 59 + this.GlobalUltimateBusiness.GetHashCode();
                if (this.FamilyMembers != null)
                    hashCode = hashCode * 59 + this.FamilyMembers.GetHashCode();
                if (this.HierarchyCode != null)
                    hashCode = hashCode * 59 + this.HierarchyCode.GetHashCode();
                if (this.TickerSymbol != null)
                    hashCode = hashCode * 59 + this.TickerSymbol.GetHashCode();
                if (this.ExchangeName != null)
                    hashCode = hashCode * 59 + this.ExchangeName.GetHashCode();
                if (this.CeoName != null)
                    hashCode = hashCode * 59 + this.CeoName.GetHashCode();
                if (this.CeoTitle != null)
                    hashCode = hashCode * 59 + this.CeoTitle.GetHashCode();
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
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

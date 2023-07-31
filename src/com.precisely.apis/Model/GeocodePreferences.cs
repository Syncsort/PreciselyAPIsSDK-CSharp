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
    /// GeocodePreferences
    /// </summary>
    [DataContract]
    public partial class GeocodePreferences :  IEquatable<GeocodePreferences>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GeocodePreferences" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GeocodePreferences() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GeocodePreferences" /> class.
        /// </summary>
        /// <param name="returnAllCandidateInfo">returnAllCandidateInfo (required).</param>
        /// <param name="fallbackToGeographic">fallbackToGeographic (required).</param>
        /// <param name="fallbackToPostal">fallbackToPostal (required).</param>
        /// <param name="maxReturnedCandidates">maxReturnedCandidates (required).</param>
        /// <param name="distance">distance (required).</param>
        /// <param name="streetOffset">streetOffset (required).</param>
        /// <param name="cornerOffset">cornerOffset (required).</param>
        /// <param name="matchMode">matchMode.</param>
        /// <param name="clientLocale">clientLocale.</param>
        /// <param name="clientCoordSysName">clientCoordSysName.</param>
        /// <param name="distanceUnits">distanceUnits.</param>
        /// <param name="streetOffsetUnits">streetOffsetUnits.</param>
        /// <param name="cornerOffsetUnits">cornerOffsetUnits.</param>
        /// <param name="mustMatchFields">mustMatchFields.</param>
        /// <param name="returnFieldsDescriptor">returnFieldsDescriptor.</param>
        /// <param name="outputRecordType">outputRecordType.</param>
        /// <param name="customPreferences">customPreferences.</param>
        /// <param name="preferredDictionaryOrders">preferredDictionaryOrders.</param>
        /// <param name="outputCasing">outputCasing.</param>
        /// <param name="latLongOffset">latLongOffset.</param>
        /// <param name="squeeze">squeeze.</param>
        /// <param name="returnLatLongFields">returnLatLongFields.</param>
        /// <param name="useGeoTaxAuxiliaryFile">useGeoTaxAuxiliaryFile.</param>
        /// <param name="latLongFormat">latLongFormat.</param>
        /// <param name="defaultBufferWidth">defaultBufferWidth.</param>
        /// <param name="returnCensusFields">returnCensusFields.</param>
        public GeocodePreferences(bool returnAllCandidateInfo = default(bool), string fallbackToGeographic = default(string), string fallbackToPostal = default(string), string maxReturnedCandidates = default(string), string distance = default(string), string streetOffset = default(string), string cornerOffset = default(string), string matchMode = default(string), string clientLocale = default(string), string clientCoordSysName = default(string), string distanceUnits = default(string), string streetOffsetUnits = default(string), string cornerOffsetUnits = default(string), FieldsMatching mustMatchFields = default(FieldsMatching), ReturnFieldsDescriptor returnFieldsDescriptor = default(ReturnFieldsDescriptor), string outputRecordType = default(string), Dictionary<string, Object> customPreferences = default(Dictionary<string, Object>), List<string> preferredDictionaryOrders = default(List<string>), string outputCasing = default(string), string latLongOffset = default(string), string squeeze = default(string), string returnLatLongFields = default(string), string useGeoTaxAuxiliaryFile = default(string), string latLongFormat = default(string), string defaultBufferWidth = default(string), string returnCensusFields = default(string))
        {
            // to ensure "returnAllCandidateInfo" is required (not null)
            if (returnAllCandidateInfo == null)
            {
                throw new InvalidDataException("returnAllCandidateInfo is a required property for GeocodePreferences and cannot be null");
            }
            else
            {
                this.ReturnAllCandidateInfo = returnAllCandidateInfo;
            }

            // to ensure "fallbackToGeographic" is required (not null)
            if (fallbackToGeographic == null)
            {
                throw new InvalidDataException("fallbackToGeographic is a required property for GeocodePreferences and cannot be null");
            }
            else
            {
                this.FallbackToGeographic = fallbackToGeographic;
            }

            // to ensure "fallbackToPostal" is required (not null)
            if (fallbackToPostal == null)
            {
                throw new InvalidDataException("fallbackToPostal is a required property for GeocodePreferences and cannot be null");
            }
            else
            {
                this.FallbackToPostal = fallbackToPostal;
            }

            // to ensure "maxReturnedCandidates" is required (not null)
            if (maxReturnedCandidates == null)
            {
                throw new InvalidDataException("maxReturnedCandidates is a required property for GeocodePreferences and cannot be null");
            }
            else
            {
                this.MaxReturnedCandidates = maxReturnedCandidates;
            }

            // to ensure "distance" is required (not null)
            if (distance == null)
            {
                throw new InvalidDataException("distance is a required property for GeocodePreferences and cannot be null");
            }
            else
            {
                this.Distance = distance;
            }

            // to ensure "streetOffset" is required (not null)
            if (streetOffset == null)
            {
                throw new InvalidDataException("streetOffset is a required property for GeocodePreferences and cannot be null");
            }
            else
            {
                this.StreetOffset = streetOffset;
            }

            // to ensure "cornerOffset" is required (not null)
            if (cornerOffset == null)
            {
                throw new InvalidDataException("cornerOffset is a required property for GeocodePreferences and cannot be null");
            }
            else
            {
                this.CornerOffset = cornerOffset;
            }

            this.MatchMode = matchMode;
            this.ClientLocale = clientLocale;
            this.ClientCoordSysName = clientCoordSysName;
            this.DistanceUnits = distanceUnits;
            this.StreetOffsetUnits = streetOffsetUnits;
            this.CornerOffsetUnits = cornerOffsetUnits;
            this.MustMatchFields = mustMatchFields;
            this.ReturnFieldsDescriptor = returnFieldsDescriptor;
            this.OutputRecordType = outputRecordType;
            this.CustomPreferences = customPreferences;
            this.PreferredDictionaryOrders = preferredDictionaryOrders;
            this.OutputCasing = outputCasing;
            this.LatLongOffset = latLongOffset;
            this.Squeeze = squeeze;
            this.ReturnLatLongFields = returnLatLongFields;
            this.UseGeoTaxAuxiliaryFile = useGeoTaxAuxiliaryFile;
            this.LatLongFormat = latLongFormat;
            this.DefaultBufferWidth = defaultBufferWidth;
            this.ReturnCensusFields = returnCensusFields;
        }

        /// <summary>
        /// Gets or Sets ReturnAllCandidateInfo
        /// </summary>
        [DataMember(Name="returnAllCandidateInfo", EmitDefaultValue=true)]
        public bool ReturnAllCandidateInfo { get; set; }

        /// <summary>
        /// Gets or Sets FallbackToGeographic
        /// </summary>
        [DataMember(Name="fallbackToGeographic", EmitDefaultValue=true)]
        public string FallbackToGeographic { get; set; }

        /// <summary>
        /// Gets or Sets FallbackToPostal
        /// </summary>
        [DataMember(Name="fallbackToPostal", EmitDefaultValue=true)]
        public string FallbackToPostal { get; set; }

        /// <summary>
        /// Gets or Sets MaxReturnedCandidates
        /// </summary>
        [DataMember(Name="maxReturnedCandidates", EmitDefaultValue=true)]
        public string MaxReturnedCandidates { get; set; }

        /// <summary>
        /// Gets or Sets Distance
        /// </summary>
        [DataMember(Name="distance", EmitDefaultValue=true)]
        public string Distance { get; set; }

        /// <summary>
        /// Gets or Sets StreetOffset
        /// </summary>
        [DataMember(Name="streetOffset", EmitDefaultValue=true)]
        public string StreetOffset { get; set; }

        /// <summary>
        /// Gets or Sets CornerOffset
        /// </summary>
        [DataMember(Name="cornerOffset", EmitDefaultValue=true)]
        public string CornerOffset { get; set; }

        /// <summary>
        /// Gets or Sets MatchMode
        /// </summary>
        [DataMember(Name="matchMode", EmitDefaultValue=false)]
        public string MatchMode { get; set; }

        /// <summary>
        /// Gets or Sets ClientLocale
        /// </summary>
        [DataMember(Name="clientLocale", EmitDefaultValue=false)]
        public string ClientLocale { get; set; }

        /// <summary>
        /// Gets or Sets ClientCoordSysName
        /// </summary>
        [DataMember(Name="clientCoordSysName", EmitDefaultValue=false)]
        public string ClientCoordSysName { get; set; }

        /// <summary>
        /// Gets or Sets DistanceUnits
        /// </summary>
        [DataMember(Name="distanceUnits", EmitDefaultValue=false)]
        public string DistanceUnits { get; set; }

        /// <summary>
        /// Gets or Sets StreetOffsetUnits
        /// </summary>
        [DataMember(Name="streetOffsetUnits", EmitDefaultValue=false)]
        public string StreetOffsetUnits { get; set; }

        /// <summary>
        /// Gets or Sets CornerOffsetUnits
        /// </summary>
        [DataMember(Name="cornerOffsetUnits", EmitDefaultValue=false)]
        public string CornerOffsetUnits { get; set; }

        /// <summary>
        /// Gets or Sets MustMatchFields
        /// </summary>
        [DataMember(Name="mustMatchFields", EmitDefaultValue=false)]
        public FieldsMatching MustMatchFields { get; set; }

        /// <summary>
        /// Gets or Sets ReturnFieldsDescriptor
        /// </summary>
        [DataMember(Name="returnFieldsDescriptor", EmitDefaultValue=false)]
        public ReturnFieldsDescriptor ReturnFieldsDescriptor { get; set; }

        /// <summary>
        /// Gets or Sets OutputRecordType
        /// </summary>
        [DataMember(Name="outputRecordType", EmitDefaultValue=false)]
        public string OutputRecordType { get; set; }

        /// <summary>
        /// Gets or Sets CustomPreferences
        /// </summary>
        [DataMember(Name="customPreferences", EmitDefaultValue=false)]
        public Dictionary<string, Object> CustomPreferences { get; set; }

        /// <summary>
        /// Gets or Sets PreferredDictionaryOrders
        /// </summary>
        [DataMember(Name="preferredDictionaryOrders", EmitDefaultValue=false)]
        public List<string> PreferredDictionaryOrders { get; set; }

        /// <summary>
        /// Gets or Sets OutputCasing
        /// </summary>
        [DataMember(Name="outputCasing", EmitDefaultValue=false)]
        public string OutputCasing { get; set; }

        /// <summary>
        /// Gets or Sets LatLongOffset
        /// </summary>
        [DataMember(Name="latLongOffset", EmitDefaultValue=false)]
        public string LatLongOffset { get; set; }

        /// <summary>
        /// Gets or Sets Squeeze
        /// </summary>
        [DataMember(Name="squeeze", EmitDefaultValue=false)]
        public string Squeeze { get; set; }

        /// <summary>
        /// Gets or Sets ReturnLatLongFields
        /// </summary>
        [DataMember(Name="returnLatLongFields", EmitDefaultValue=false)]
        public string ReturnLatLongFields { get; set; }

        /// <summary>
        /// Gets or Sets UseGeoTaxAuxiliaryFile
        /// </summary>
        [DataMember(Name="useGeoTaxAuxiliaryFile", EmitDefaultValue=false)]
        public string UseGeoTaxAuxiliaryFile { get; set; }

        /// <summary>
        /// Gets or Sets LatLongFormat
        /// </summary>
        [DataMember(Name="latLongFormat", EmitDefaultValue=false)]
        public string LatLongFormat { get; set; }

        /// <summary>
        /// Gets or Sets DefaultBufferWidth
        /// </summary>
        [DataMember(Name="defaultBufferWidth", EmitDefaultValue=false)]
        public string DefaultBufferWidth { get; set; }

        /// <summary>
        /// Gets or Sets ReturnCensusFields
        /// </summary>
        [DataMember(Name="returnCensusFields", EmitDefaultValue=false)]
        public string ReturnCensusFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeocodePreferences {\n");
            sb.Append("  ReturnAllCandidateInfo: ").Append(ReturnAllCandidateInfo).Append("\n");
            sb.Append("  FallbackToGeographic: ").Append(FallbackToGeographic).Append("\n");
            sb.Append("  FallbackToPostal: ").Append(FallbackToPostal).Append("\n");
            sb.Append("  MaxReturnedCandidates: ").Append(MaxReturnedCandidates).Append("\n");
            sb.Append("  Distance: ").Append(Distance).Append("\n");
            sb.Append("  StreetOffset: ").Append(StreetOffset).Append("\n");
            sb.Append("  CornerOffset: ").Append(CornerOffset).Append("\n");
            sb.Append("  MatchMode: ").Append(MatchMode).Append("\n");
            sb.Append("  ClientLocale: ").Append(ClientLocale).Append("\n");
            sb.Append("  ClientCoordSysName: ").Append(ClientCoordSysName).Append("\n");
            sb.Append("  DistanceUnits: ").Append(DistanceUnits).Append("\n");
            sb.Append("  StreetOffsetUnits: ").Append(StreetOffsetUnits).Append("\n");
            sb.Append("  CornerOffsetUnits: ").Append(CornerOffsetUnits).Append("\n");
            sb.Append("  MustMatchFields: ").Append(MustMatchFields).Append("\n");
            sb.Append("  ReturnFieldsDescriptor: ").Append(ReturnFieldsDescriptor).Append("\n");
            sb.Append("  OutputRecordType: ").Append(OutputRecordType).Append("\n");
            sb.Append("  CustomPreferences: ").Append(CustomPreferences).Append("\n");
            sb.Append("  PreferredDictionaryOrders: ").Append(PreferredDictionaryOrders).Append("\n");
            sb.Append("  OutputCasing: ").Append(OutputCasing).Append("\n");
            sb.Append("  LatLongOffset: ").Append(LatLongOffset).Append("\n");
            sb.Append("  Squeeze: ").Append(Squeeze).Append("\n");
            sb.Append("  ReturnLatLongFields: ").Append(ReturnLatLongFields).Append("\n");
            sb.Append("  UseGeoTaxAuxiliaryFile: ").Append(UseGeoTaxAuxiliaryFile).Append("\n");
            sb.Append("  LatLongFormat: ").Append(LatLongFormat).Append("\n");
            sb.Append("  DefaultBufferWidth: ").Append(DefaultBufferWidth).Append("\n");
            sb.Append("  ReturnCensusFields: ").Append(ReturnCensusFields).Append("\n");
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
            return this.Equals(input as GeocodePreferences);
        }

        /// <summary>
        /// Returns true if GeocodePreferences instances are equal
        /// </summary>
        /// <param name="input">Instance of GeocodePreferences to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GeocodePreferences input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ReturnAllCandidateInfo == input.ReturnAllCandidateInfo ||
                    (this.ReturnAllCandidateInfo != null &&
                    this.ReturnAllCandidateInfo.Equals(input.ReturnAllCandidateInfo))
                ) && 
                (
                    this.FallbackToGeographic == input.FallbackToGeographic ||
                    (this.FallbackToGeographic != null &&
                    this.FallbackToGeographic.Equals(input.FallbackToGeographic))
                ) && 
                (
                    this.FallbackToPostal == input.FallbackToPostal ||
                    (this.FallbackToPostal != null &&
                    this.FallbackToPostal.Equals(input.FallbackToPostal))
                ) && 
                (
                    this.MaxReturnedCandidates == input.MaxReturnedCandidates ||
                    (this.MaxReturnedCandidates != null &&
                    this.MaxReturnedCandidates.Equals(input.MaxReturnedCandidates))
                ) && 
                (
                    this.Distance == input.Distance ||
                    (this.Distance != null &&
                    this.Distance.Equals(input.Distance))
                ) && 
                (
                    this.StreetOffset == input.StreetOffset ||
                    (this.StreetOffset != null &&
                    this.StreetOffset.Equals(input.StreetOffset))
                ) && 
                (
                    this.CornerOffset == input.CornerOffset ||
                    (this.CornerOffset != null &&
                    this.CornerOffset.Equals(input.CornerOffset))
                ) && 
                (
                    this.MatchMode == input.MatchMode ||
                    (this.MatchMode != null &&
                    this.MatchMode.Equals(input.MatchMode))
                ) && 
                (
                    this.ClientLocale == input.ClientLocale ||
                    (this.ClientLocale != null &&
                    this.ClientLocale.Equals(input.ClientLocale))
                ) && 
                (
                    this.ClientCoordSysName == input.ClientCoordSysName ||
                    (this.ClientCoordSysName != null &&
                    this.ClientCoordSysName.Equals(input.ClientCoordSysName))
                ) && 
                (
                    this.DistanceUnits == input.DistanceUnits ||
                    (this.DistanceUnits != null &&
                    this.DistanceUnits.Equals(input.DistanceUnits))
                ) && 
                (
                    this.StreetOffsetUnits == input.StreetOffsetUnits ||
                    (this.StreetOffsetUnits != null &&
                    this.StreetOffsetUnits.Equals(input.StreetOffsetUnits))
                ) && 
                (
                    this.CornerOffsetUnits == input.CornerOffsetUnits ||
                    (this.CornerOffsetUnits != null &&
                    this.CornerOffsetUnits.Equals(input.CornerOffsetUnits))
                ) && 
                (
                    this.MustMatchFields == input.MustMatchFields ||
                    (this.MustMatchFields != null &&
                    this.MustMatchFields.Equals(input.MustMatchFields))
                ) && 
                (
                    this.ReturnFieldsDescriptor == input.ReturnFieldsDescriptor ||
                    (this.ReturnFieldsDescriptor != null &&
                    this.ReturnFieldsDescriptor.Equals(input.ReturnFieldsDescriptor))
                ) && 
                (
                    this.OutputRecordType == input.OutputRecordType ||
                    (this.OutputRecordType != null &&
                    this.OutputRecordType.Equals(input.OutputRecordType))
                ) && 
                (
                    this.CustomPreferences == input.CustomPreferences ||
                    this.CustomPreferences != null &&
                    input.CustomPreferences != null &&
                    this.CustomPreferences.SequenceEqual(input.CustomPreferences)
                ) && 
                (
                    this.PreferredDictionaryOrders == input.PreferredDictionaryOrders ||
                    this.PreferredDictionaryOrders != null &&
                    input.PreferredDictionaryOrders != null &&
                    this.PreferredDictionaryOrders.SequenceEqual(input.PreferredDictionaryOrders)
                ) && 
                (
                    this.OutputCasing == input.OutputCasing ||
                    (this.OutputCasing != null &&
                    this.OutputCasing.Equals(input.OutputCasing))
                ) && 
                (
                    this.LatLongOffset == input.LatLongOffset ||
                    (this.LatLongOffset != null &&
                    this.LatLongOffset.Equals(input.LatLongOffset))
                ) && 
                (
                    this.Squeeze == input.Squeeze ||
                    (this.Squeeze != null &&
                    this.Squeeze.Equals(input.Squeeze))
                ) && 
                (
                    this.ReturnLatLongFields == input.ReturnLatLongFields ||
                    (this.ReturnLatLongFields != null &&
                    this.ReturnLatLongFields.Equals(input.ReturnLatLongFields))
                ) && 
                (
                    this.UseGeoTaxAuxiliaryFile == input.UseGeoTaxAuxiliaryFile ||
                    (this.UseGeoTaxAuxiliaryFile != null &&
                    this.UseGeoTaxAuxiliaryFile.Equals(input.UseGeoTaxAuxiliaryFile))
                ) && 
                (
                    this.LatLongFormat == input.LatLongFormat ||
                    (this.LatLongFormat != null &&
                    this.LatLongFormat.Equals(input.LatLongFormat))
                ) && 
                (
                    this.DefaultBufferWidth == input.DefaultBufferWidth ||
                    (this.DefaultBufferWidth != null &&
                    this.DefaultBufferWidth.Equals(input.DefaultBufferWidth))
                ) && 
                (
                    this.ReturnCensusFields == input.ReturnCensusFields ||
                    (this.ReturnCensusFields != null &&
                    this.ReturnCensusFields.Equals(input.ReturnCensusFields))
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
                if (this.ReturnAllCandidateInfo != null)
                    hashCode = hashCode * 59 + this.ReturnAllCandidateInfo.GetHashCode();
                if (this.FallbackToGeographic != null)
                    hashCode = hashCode * 59 + this.FallbackToGeographic.GetHashCode();
                if (this.FallbackToPostal != null)
                    hashCode = hashCode * 59 + this.FallbackToPostal.GetHashCode();
                if (this.MaxReturnedCandidates != null)
                    hashCode = hashCode * 59 + this.MaxReturnedCandidates.GetHashCode();
                if (this.Distance != null)
                    hashCode = hashCode * 59 + this.Distance.GetHashCode();
                if (this.StreetOffset != null)
                    hashCode = hashCode * 59 + this.StreetOffset.GetHashCode();
                if (this.CornerOffset != null)
                    hashCode = hashCode * 59 + this.CornerOffset.GetHashCode();
                if (this.MatchMode != null)
                    hashCode = hashCode * 59 + this.MatchMode.GetHashCode();
                if (this.ClientLocale != null)
                    hashCode = hashCode * 59 + this.ClientLocale.GetHashCode();
                if (this.ClientCoordSysName != null)
                    hashCode = hashCode * 59 + this.ClientCoordSysName.GetHashCode();
                if (this.DistanceUnits != null)
                    hashCode = hashCode * 59 + this.DistanceUnits.GetHashCode();
                if (this.StreetOffsetUnits != null)
                    hashCode = hashCode * 59 + this.StreetOffsetUnits.GetHashCode();
                if (this.CornerOffsetUnits != null)
                    hashCode = hashCode * 59 + this.CornerOffsetUnits.GetHashCode();
                if (this.MustMatchFields != null)
                    hashCode = hashCode * 59 + this.MustMatchFields.GetHashCode();
                if (this.ReturnFieldsDescriptor != null)
                    hashCode = hashCode * 59 + this.ReturnFieldsDescriptor.GetHashCode();
                if (this.OutputRecordType != null)
                    hashCode = hashCode * 59 + this.OutputRecordType.GetHashCode();
                if (this.CustomPreferences != null)
                    hashCode = hashCode * 59 + this.CustomPreferences.GetHashCode();
                if (this.PreferredDictionaryOrders != null)
                    hashCode = hashCode * 59 + this.PreferredDictionaryOrders.GetHashCode();
                if (this.OutputCasing != null)
                    hashCode = hashCode * 59 + this.OutputCasing.GetHashCode();
                if (this.LatLongOffset != null)
                    hashCode = hashCode * 59 + this.LatLongOffset.GetHashCode();
                if (this.Squeeze != null)
                    hashCode = hashCode * 59 + this.Squeeze.GetHashCode();
                if (this.ReturnLatLongFields != null)
                    hashCode = hashCode * 59 + this.ReturnLatLongFields.GetHashCode();
                if (this.UseGeoTaxAuxiliaryFile != null)
                    hashCode = hashCode * 59 + this.UseGeoTaxAuxiliaryFile.GetHashCode();
                if (this.LatLongFormat != null)
                    hashCode = hashCode * 59 + this.LatLongFormat.GetHashCode();
                if (this.DefaultBufferWidth != null)
                    hashCode = hashCode * 59 + this.DefaultBufferWidth.GetHashCode();
                if (this.ReturnCensusFields != null)
                    hashCode = hashCode * 59 + this.ReturnCensusFields.GetHashCode();
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

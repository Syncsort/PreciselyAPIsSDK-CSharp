/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 12.0.1
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
    /// ValidateMailingAddressOutput
    /// </summary>
    [DataContract]
    public partial class ValidateMailingAddressOutput :  IEquatable<ValidateMailingAddressOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateMailingAddressOutput" /> class.
        /// </summary>
        /// <param name="userFields">These fields are returned, unmodified, in the user_fields section of the response..</param>
        /// <param name="addressLine1">The first line of the validated address..</param>
        /// <param name="addressLine2">The second line of the validated address..</param>
        /// <param name="firmName">The validated firm or company name..</param>
        /// <param name="city">The validated city name..</param>
        /// <param name="postalCode">The validated ZIP Code or postal code..</param>
        /// <param name="country">The country name in English..</param>
        /// <param name="stateProvince">The validated state or province abbreviation..</param>
        /// <param name="blockAddress">The formatted address, as it would appear on a physical mail piece..</param>
        /// <param name="additionalInputData">Input data not used by the address validation process..</param>
        /// <param name="postalCodeBase">The 5-digit ZIP Code..</param>
        /// <param name="postalCodeAddOn">The 4-digit add-on part of the ZIP Code..</param>
        /// <param name="status">Reports the success or failure of the match attempt..</param>
        /// <param name="statusCode">Reason for failure, if there is one..</param>
        /// <param name="statusDescription">Description of the problem, if there is one..</param>
        public ValidateMailingAddressOutput(List<GetPostalCodesAPIOutputUserFields> userFields = default(List<GetPostalCodesAPIOutputUserFields>), string addressLine1 = default(string), string addressLine2 = default(string), string firmName = default(string), string city = default(string), string postalCode = default(string), string country = default(string), string stateProvince = default(string), string blockAddress = default(string), string additionalInputData = default(string), string postalCodeBase = default(string), string postalCodeAddOn = default(string), string status = default(string), string statusCode = default(string), string statusDescription = default(string))
        {
            this.UserFields = userFields;
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.FirmName = firmName;
            this.City = city;
            this.PostalCode = postalCode;
            this.Country = country;
            this.StateProvince = stateProvince;
            this.BlockAddress = blockAddress;
            this.AdditionalInputData = additionalInputData;
            this.PostalCodeBase = postalCodeBase;
            this.PostalCodeAddOn = postalCodeAddOn;
            this.Status = status;
            this.StatusCode = statusCode;
            this.StatusDescription = statusDescription;
        }

        /// <summary>
        /// These fields are returned, unmodified, in the user_fields section of the response.
        /// </summary>
        /// <value>These fields are returned, unmodified, in the user_fields section of the response.</value>
        [DataMember(Name="user_fields", EmitDefaultValue=false)]
        public List<GetPostalCodesAPIOutputUserFields> UserFields { get; set; }

        /// <summary>
        /// The first line of the validated address.
        /// </summary>
        /// <value>The first line of the validated address.</value>
        [DataMember(Name="AddressLine1", EmitDefaultValue=false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// The second line of the validated address.
        /// </summary>
        /// <value>The second line of the validated address.</value>
        [DataMember(Name="AddressLine2", EmitDefaultValue=false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// The validated firm or company name.
        /// </summary>
        /// <value>The validated firm or company name.</value>
        [DataMember(Name="FirmName", EmitDefaultValue=false)]
        public string FirmName { get; set; }

        /// <summary>
        /// The validated city name.
        /// </summary>
        /// <value>The validated city name.</value>
        [DataMember(Name="City", EmitDefaultValue=false)]
        public string City { get; set; }

        /// <summary>
        /// The validated ZIP Code or postal code.
        /// </summary>
        /// <value>The validated ZIP Code or postal code.</value>
        [DataMember(Name="PostalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The country name in English.
        /// </summary>
        /// <value>The country name in English.</value>
        [DataMember(Name="Country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// The validated state or province abbreviation.
        /// </summary>
        /// <value>The validated state or province abbreviation.</value>
        [DataMember(Name="StateProvince", EmitDefaultValue=false)]
        public string StateProvince { get; set; }

        /// <summary>
        /// The formatted address, as it would appear on a physical mail piece.
        /// </summary>
        /// <value>The formatted address, as it would appear on a physical mail piece.</value>
        [DataMember(Name="BlockAddress", EmitDefaultValue=false)]
        public string BlockAddress { get; set; }

        /// <summary>
        /// Input data not used by the address validation process.
        /// </summary>
        /// <value>Input data not used by the address validation process.</value>
        [DataMember(Name="AdditionalInputData", EmitDefaultValue=false)]
        public string AdditionalInputData { get; set; }

        /// <summary>
        /// The 5-digit ZIP Code.
        /// </summary>
        /// <value>The 5-digit ZIP Code.</value>
        [DataMember(Name="PostalCode.Base", EmitDefaultValue=false)]
        public string PostalCodeBase { get; set; }

        /// <summary>
        /// The 4-digit add-on part of the ZIP Code.
        /// </summary>
        /// <value>The 4-digit add-on part of the ZIP Code.</value>
        [DataMember(Name="PostalCode.AddOn", EmitDefaultValue=false)]
        public string PostalCodeAddOn { get; set; }

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
            sb.Append("class ValidateMailingAddressOutput {\n");
            sb.Append("  UserFields: ").Append(UserFields).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  FirmName: ").Append(FirmName).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
            sb.Append("  BlockAddress: ").Append(BlockAddress).Append("\n");
            sb.Append("  AdditionalInputData: ").Append(AdditionalInputData).Append("\n");
            sb.Append("  PostalCodeBase: ").Append(PostalCodeBase).Append("\n");
            sb.Append("  PostalCodeAddOn: ").Append(PostalCodeAddOn).Append("\n");
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
            return this.Equals(input as ValidateMailingAddressOutput);
        }

        /// <summary>
        /// Returns true if ValidateMailingAddressOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidateMailingAddressOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateMailingAddressOutput input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserFields == input.UserFields ||
                    this.UserFields != null &&
                    input.UserFields != null &&
                    this.UserFields.SequenceEqual(input.UserFields)
                ) && 
                (
                    this.AddressLine1 == input.AddressLine1 ||
                    (this.AddressLine1 != null &&
                    this.AddressLine1.Equals(input.AddressLine1))
                ) && 
                (
                    this.AddressLine2 == input.AddressLine2 ||
                    (this.AddressLine2 != null &&
                    this.AddressLine2.Equals(input.AddressLine2))
                ) && 
                (
                    this.FirmName == input.FirmName ||
                    (this.FirmName != null &&
                    this.FirmName.Equals(input.FirmName))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
                ) && 
                (
                    this.StateProvince == input.StateProvince ||
                    (this.StateProvince != null &&
                    this.StateProvince.Equals(input.StateProvince))
                ) && 
                (
                    this.BlockAddress == input.BlockAddress ||
                    (this.BlockAddress != null &&
                    this.BlockAddress.Equals(input.BlockAddress))
                ) && 
                (
                    this.AdditionalInputData == input.AdditionalInputData ||
                    (this.AdditionalInputData != null &&
                    this.AdditionalInputData.Equals(input.AdditionalInputData))
                ) && 
                (
                    this.PostalCodeBase == input.PostalCodeBase ||
                    (this.PostalCodeBase != null &&
                    this.PostalCodeBase.Equals(input.PostalCodeBase))
                ) && 
                (
                    this.PostalCodeAddOn == input.PostalCodeAddOn ||
                    (this.PostalCodeAddOn != null &&
                    this.PostalCodeAddOn.Equals(input.PostalCodeAddOn))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
                ) && 
                (
                    this.StatusDescription == input.StatusDescription ||
                    (this.StatusDescription != null &&
                    this.StatusDescription.Equals(input.StatusDescription))
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
                if (this.UserFields != null)
                    hashCode = hashCode * 59 + this.UserFields.GetHashCode();
                if (this.AddressLine1 != null)
                    hashCode = hashCode * 59 + this.AddressLine1.GetHashCode();
                if (this.AddressLine2 != null)
                    hashCode = hashCode * 59 + this.AddressLine2.GetHashCode();
                if (this.FirmName != null)
                    hashCode = hashCode * 59 + this.FirmName.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
                if (this.StateProvince != null)
                    hashCode = hashCode * 59 + this.StateProvince.GetHashCode();
                if (this.BlockAddress != null)
                    hashCode = hashCode * 59 + this.BlockAddress.GetHashCode();
                if (this.AdditionalInputData != null)
                    hashCode = hashCode * 59 + this.AdditionalInputData.GetHashCode();
                if (this.PostalCodeBase != null)
                    hashCode = hashCode * 59 + this.PostalCodeBase.GetHashCode();
                if (this.PostalCodeAddOn != null)
                    hashCode = hashCode * 59 + this.PostalCodeAddOn.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StatusCode != null)
                    hashCode = hashCode * 59 + this.StatusCode.GetHashCode();
                if (this.StatusDescription != null)
                    hashCode = hashCode * 59 + this.StatusDescription.GetHashCode();
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

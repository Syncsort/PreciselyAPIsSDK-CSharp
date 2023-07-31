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
    /// GetPostalCodesAPIOutput
    /// </summary>
    [DataContract]
    public partial class GetPostalCodesAPIOutput :  IEquatable<GetPostalCodesAPIOutput>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetPostalCodesAPIOutput" /> class.
        /// </summary>
        /// <param name="userFields">These fields are returned, unmodified, in the user_fields section of the response..</param>
        /// <param name="postalCode">The validated ZIP Code or postal code..</param>
        /// <param name="cityType">City.Type.</param>
        /// <param name="status">Reports the success or failure of the match attempt..</param>
        /// <param name="statusCode">Reason for failure, if there is one..</param>
        /// <param name="statusDescription">Description of the problem, if there is one..</param>
        public GetPostalCodesAPIOutput(List<GetPostalCodesAPIOutputUserFields> userFields = default(List<GetPostalCodesAPIOutputUserFields>), string postalCode = default(string), string cityType = default(string), string status = default(string), string statusCode = default(string), string statusDescription = default(string))
        {
            this.UserFields = userFields;
            this.PostalCode = postalCode;
            this.CityType = cityType;
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
        /// The validated ZIP Code or postal code.
        /// </summary>
        /// <value>The validated ZIP Code or postal code.</value>
        [DataMember(Name="PostalCode", EmitDefaultValue=false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// City.Type
        /// </summary>
        /// <value>City.Type</value>
        [DataMember(Name="City.Type", EmitDefaultValue=false)]
        public string CityType { get; set; }

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
            sb.Append("class GetPostalCodesAPIOutput {\n");
            sb.Append("  UserFields: ").Append(UserFields).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CityType: ").Append(CityType).Append("\n");
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
            return this.Equals(input as GetPostalCodesAPIOutput);
        }

        /// <summary>
        /// Returns true if GetPostalCodesAPIOutput instances are equal
        /// </summary>
        /// <param name="input">Instance of GetPostalCodesAPIOutput to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetPostalCodesAPIOutput input)
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
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.CityType == input.CityType ||
                    (this.CityType != null &&
                    this.CityType.Equals(input.CityType))
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
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                if (this.CityType != null)
                    hashCode = hashCode * 59 + this.CityType.GetHashCode();
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

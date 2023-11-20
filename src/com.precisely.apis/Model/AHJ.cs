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
    /// AHJ
    /// </summary>
    [DataContract]
    public partial class AHJ :  IEquatable<AHJ>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AHJ" /> class.
        /// </summary>
        /// <param name="ahjType">ahjType.</param>
        /// <param name="ahjId">ahjId.</param>
        /// <param name="type">type.</param>
        /// <param name="fccId">fccId.</param>
        /// <param name="agency">agency.</param>
        /// <param name="phone">phone.</param>
        /// <param name="comments">comments.</param>
        /// <param name="coverage">coverage.</param>
        /// <param name="contactPerson">contactPerson.</param>
        /// <param name="mailingAddress">mailingAddress.</param>
        public AHJ(string ahjType = default(string), string ahjId = default(string), string type = default(string), string fccId = default(string), string agency = default(string), string phone = default(string), string comments = default(string), Coverage coverage = default(Coverage), ContactPerson contactPerson = default(ContactPerson), AHJmailingAddress mailingAddress = default(AHJmailingAddress))
        {
            this.AhjType = ahjType;
            this.AhjId = ahjId;
            this.Type = type;
            this.FccId = fccId;
            this.Agency = agency;
            this.Phone = phone;
            this.Comments = comments;
            this.Coverage = coverage;
            this.ContactPerson = contactPerson;
            this.MailingAddress = mailingAddress;
        }

        /// <summary>
        /// Gets or Sets AhjType
        /// </summary>
        [DataMember(Name="ahjType", EmitDefaultValue=false)]
        public string AhjType { get; set; }

        /// <summary>
        /// Gets or Sets AhjId
        /// </summary>
        [DataMember(Name="ahjId", EmitDefaultValue=false)]
        public string AhjId { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name="type", EmitDefaultValue=false)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets FccId
        /// </summary>
        [DataMember(Name="fccId", EmitDefaultValue=false)]
        public string FccId { get; set; }

        /// <summary>
        /// Gets or Sets Agency
        /// </summary>
        [DataMember(Name="agency", EmitDefaultValue=false)]
        public string Agency { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        [DataMember(Name="phone", EmitDefaultValue=false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public string Comments { get; set; }

        /// <summary>
        /// Gets or Sets Coverage
        /// </summary>
        [DataMember(Name="coverage", EmitDefaultValue=false)]
        public Coverage Coverage { get; set; }

        /// <summary>
        /// Gets or Sets ContactPerson
        /// </summary>
        [DataMember(Name="contactPerson", EmitDefaultValue=false)]
        public ContactPerson ContactPerson { get; set; }

        /// <summary>
        /// Gets or Sets MailingAddress
        /// </summary>
        [DataMember(Name="mailingAddress", EmitDefaultValue=false)]
        public AHJmailingAddress MailingAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AHJ {\n");
            sb.Append("  AhjType: ").Append(AhjType).Append("\n");
            sb.Append("  AhjId: ").Append(AhjId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FccId: ").Append(FccId).Append("\n");
            sb.Append("  Agency: ").Append(Agency).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Coverage: ").Append(Coverage).Append("\n");
            sb.Append("  ContactPerson: ").Append(ContactPerson).Append("\n");
            sb.Append("  MailingAddress: ").Append(MailingAddress).Append("\n");
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
            return this.Equals(input as AHJ);
        }

        /// <summary>
        /// Returns true if AHJ instances are equal
        /// </summary>
        /// <param name="input">Instance of AHJ to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AHJ input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AhjType == input.AhjType ||
                    (this.AhjType != null &&
                    this.AhjType.Equals(input.AhjType))
                ) && 
                (
                    this.AhjId == input.AhjId ||
                    (this.AhjId != null &&
                    this.AhjId.Equals(input.AhjId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.FccId == input.FccId ||
                    (this.FccId != null &&
                    this.FccId.Equals(input.FccId))
                ) && 
                (
                    this.Agency == input.Agency ||
                    (this.Agency != null &&
                    this.Agency.Equals(input.Agency))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.Coverage == input.Coverage ||
                    (this.Coverage != null &&
                    this.Coverage.Equals(input.Coverage))
                ) && 
                (
                    this.ContactPerson == input.ContactPerson ||
                    (this.ContactPerson != null &&
                    this.ContactPerson.Equals(input.ContactPerson))
                ) && 
                (
                    this.MailingAddress == input.MailingAddress ||
                    (this.MailingAddress != null &&
                    this.MailingAddress.Equals(input.MailingAddress))
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
                if (this.AhjType != null)
                    hashCode = hashCode * 59 + this.AhjType.GetHashCode();
                if (this.AhjId != null)
                    hashCode = hashCode * 59 + this.AhjId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.FccId != null)
                    hashCode = hashCode * 59 + this.FccId.GetHashCode();
                if (this.Agency != null)
                    hashCode = hashCode * 59 + this.Agency.GetHashCode();
                if (this.Phone != null)
                    hashCode = hashCode * 59 + this.Phone.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.Coverage != null)
                    hashCode = hashCode * 59 + this.Coverage.GetHashCode();
                if (this.ContactPerson != null)
                    hashCode = hashCode * 59 + this.ContactPerson.GetHashCode();
                if (this.MailingAddress != null)
                    hashCode = hashCode * 59 + this.MailingAddress.GetHashCode();
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

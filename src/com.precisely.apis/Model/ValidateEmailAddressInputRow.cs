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
    /// ValidateEmailAddressInputRow
    /// </summary>
    [DataContract]
    public partial class ValidateEmailAddressInputRow :  IEquatable<ValidateEmailAddressInputRow>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateEmailAddressInputRow" /> class.
        /// </summary>
        /// <param name="userFields">These fields are returned, unmodified, in the user_fields section of the response..</param>
        /// <param name="rtc">Enables or disables real-time confirmation. If the deliverability of an email address cannot be determined via our knowledge base, a real-time confirmation can be attempted..</param>
        /// <param name="bogus">Specifies whether to check if the email address is fictitious. For example, bgates@microsoft.com..</param>
        /// <param name="role">Specifies whether to check if the email address has a non-personal handle, such as info@, sales@, or webmaster@. For example, sales@example.com..</param>
        /// <param name="emps">Specifies whether to check if the email address appears on the Direct Marketing Association&#39;s Do Not Email list (Electronic Mail Preference Service)..</param>
        /// <param name="fccwireless">Specifies whether to check if the email address is associated with a domain that has restrictions on commercial email per the FCC..</param>
        /// <param name="language">Specifies whether to check if the email address handle contains derogatory words..</param>
        /// <param name="complain">Specifies whether to check if the owner of the email address is known to submit spam complaints..</param>
        /// <param name="disposable">Specifies whether to check if the email address originates from a website that provides temporary email addresses, or if the email address appears to be temporary.</param>
        /// <param name="atc">One character code controlling the advanced suggestion behavior.The possible values are: a, c, and n.</param>
        /// <param name="emailAddress">The email address you want to validate..</param>
        /// <param name="rtcTimeout">Specifies the timeout for real-time confirmation. See the description of the rtc parameter. Specify the timeout value in milliseconds. Valid values are 0 to 4000. By default, the system allows 1200 milliseconds for this check..</param>
        public ValidateEmailAddressInputRow(List<GetPostalCodesAPIOutputUserFields> userFields = default(List<GetPostalCodesAPIOutputUserFields>), string rtc = default(string), string bogus = default(string), string role = default(string), string emps = default(string), string fccwireless = default(string), string language = default(string), string complain = default(string), string disposable = default(string), string atc = default(string), string emailAddress = default(string), string rtcTimeout = default(string))
        {
            this.UserFields = userFields;
            this.Rtc = rtc;
            this.Bogus = bogus;
            this.Role = role;
            this.Emps = emps;
            this.Fccwireless = fccwireless;
            this.Language = language;
            this.Complain = complain;
            this.Disposable = disposable;
            this.Atc = atc;
            this.EmailAddress = emailAddress;
            this.RtcTimeout = rtcTimeout;
        }

        /// <summary>
        /// These fields are returned, unmodified, in the user_fields section of the response.
        /// </summary>
        /// <value>These fields are returned, unmodified, in the user_fields section of the response.</value>
        [DataMember(Name="user_fields", EmitDefaultValue=false)]
        public List<GetPostalCodesAPIOutputUserFields> UserFields { get; set; }

        /// <summary>
        /// Enables or disables real-time confirmation. If the deliverability of an email address cannot be determined via our knowledge base, a real-time confirmation can be attempted.
        /// </summary>
        /// <value>Enables or disables real-time confirmation. If the deliverability of an email address cannot be determined via our knowledge base, a real-time confirmation can be attempted.</value>
        [DataMember(Name="rtc", EmitDefaultValue=false)]
        public string Rtc { get; set; }

        /// <summary>
        /// Specifies whether to check if the email address is fictitious. For example, bgates@microsoft.com.
        /// </summary>
        /// <value>Specifies whether to check if the email address is fictitious. For example, bgates@microsoft.com.</value>
        [DataMember(Name="bogus", EmitDefaultValue=false)]
        public string Bogus { get; set; }

        /// <summary>
        /// Specifies whether to check if the email address has a non-personal handle, such as info@, sales@, or webmaster@. For example, sales@example.com.
        /// </summary>
        /// <value>Specifies whether to check if the email address has a non-personal handle, such as info@, sales@, or webmaster@. For example, sales@example.com.</value>
        [DataMember(Name="role", EmitDefaultValue=false)]
        public string Role { get; set; }

        /// <summary>
        /// Specifies whether to check if the email address appears on the Direct Marketing Association&#39;s Do Not Email list (Electronic Mail Preference Service).
        /// </summary>
        /// <value>Specifies whether to check if the email address appears on the Direct Marketing Association&#39;s Do Not Email list (Electronic Mail Preference Service).</value>
        [DataMember(Name="emps", EmitDefaultValue=false)]
        public string Emps { get; set; }

        /// <summary>
        /// Specifies whether to check if the email address is associated with a domain that has restrictions on commercial email per the FCC.
        /// </summary>
        /// <value>Specifies whether to check if the email address is associated with a domain that has restrictions on commercial email per the FCC.</value>
        [DataMember(Name="fccwireless", EmitDefaultValue=false)]
        public string Fccwireless { get; set; }

        /// <summary>
        /// Specifies whether to check if the email address handle contains derogatory words.
        /// </summary>
        /// <value>Specifies whether to check if the email address handle contains derogatory words.</value>
        [DataMember(Name="language", EmitDefaultValue=false)]
        public string Language { get; set; }

        /// <summary>
        /// Specifies whether to check if the owner of the email address is known to submit spam complaints.
        /// </summary>
        /// <value>Specifies whether to check if the owner of the email address is known to submit spam complaints.</value>
        [DataMember(Name="complain", EmitDefaultValue=false)]
        public string Complain { get; set; }

        /// <summary>
        /// Specifies whether to check if the email address originates from a website that provides temporary email addresses, or if the email address appears to be temporary
        /// </summary>
        /// <value>Specifies whether to check if the email address originates from a website that provides temporary email addresses, or if the email address appears to be temporary</value>
        [DataMember(Name="disposable", EmitDefaultValue=false)]
        public string Disposable { get; set; }

        /// <summary>
        /// One character code controlling the advanced suggestion behavior.The possible values are: a, c, and n
        /// </summary>
        /// <value>One character code controlling the advanced suggestion behavior.The possible values are: a, c, and n</value>
        [DataMember(Name="atc", EmitDefaultValue=false)]
        public string Atc { get; set; }

        /// <summary>
        /// The email address you want to validate.
        /// </summary>
        /// <value>The email address you want to validate.</value>
        [DataMember(Name="emailAddress", EmitDefaultValue=false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Specifies the timeout for real-time confirmation. See the description of the rtc parameter. Specify the timeout value in milliseconds. Valid values are 0 to 4000. By default, the system allows 1200 milliseconds for this check.
        /// </summary>
        /// <value>Specifies the timeout for real-time confirmation. See the description of the rtc parameter. Specify the timeout value in milliseconds. Valid values are 0 to 4000. By default, the system allows 1200 milliseconds for this check.</value>
        [DataMember(Name="rtc_timeout", EmitDefaultValue=false)]
        public string RtcTimeout { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateEmailAddressInputRow {\n");
            sb.Append("  UserFields: ").Append(UserFields).Append("\n");
            sb.Append("  Rtc: ").Append(Rtc).Append("\n");
            sb.Append("  Bogus: ").Append(Bogus).Append("\n");
            sb.Append("  Role: ").Append(Role).Append("\n");
            sb.Append("  Emps: ").Append(Emps).Append("\n");
            sb.Append("  Fccwireless: ").Append(Fccwireless).Append("\n");
            sb.Append("  Language: ").Append(Language).Append("\n");
            sb.Append("  Complain: ").Append(Complain).Append("\n");
            sb.Append("  Disposable: ").Append(Disposable).Append("\n");
            sb.Append("  Atc: ").Append(Atc).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  RtcTimeout: ").Append(RtcTimeout).Append("\n");
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
            return this.Equals(input as ValidateEmailAddressInputRow);
        }

        /// <summary>
        /// Returns true if ValidateEmailAddressInputRow instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidateEmailAddressInputRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateEmailAddressInputRow input)
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
                    this.Rtc == input.Rtc ||
                    (this.Rtc != null &&
                    this.Rtc.Equals(input.Rtc))
                ) && 
                (
                    this.Bogus == input.Bogus ||
                    (this.Bogus != null &&
                    this.Bogus.Equals(input.Bogus))
                ) && 
                (
                    this.Role == input.Role ||
                    (this.Role != null &&
                    this.Role.Equals(input.Role))
                ) && 
                (
                    this.Emps == input.Emps ||
                    (this.Emps != null &&
                    this.Emps.Equals(input.Emps))
                ) && 
                (
                    this.Fccwireless == input.Fccwireless ||
                    (this.Fccwireless != null &&
                    this.Fccwireless.Equals(input.Fccwireless))
                ) && 
                (
                    this.Language == input.Language ||
                    (this.Language != null &&
                    this.Language.Equals(input.Language))
                ) && 
                (
                    this.Complain == input.Complain ||
                    (this.Complain != null &&
                    this.Complain.Equals(input.Complain))
                ) && 
                (
                    this.Disposable == input.Disposable ||
                    (this.Disposable != null &&
                    this.Disposable.Equals(input.Disposable))
                ) && 
                (
                    this.Atc == input.Atc ||
                    (this.Atc != null &&
                    this.Atc.Equals(input.Atc))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.RtcTimeout == input.RtcTimeout ||
                    (this.RtcTimeout != null &&
                    this.RtcTimeout.Equals(input.RtcTimeout))
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
                if (this.Rtc != null)
                    hashCode = hashCode * 59 + this.Rtc.GetHashCode();
                if (this.Bogus != null)
                    hashCode = hashCode * 59 + this.Bogus.GetHashCode();
                if (this.Role != null)
                    hashCode = hashCode * 59 + this.Role.GetHashCode();
                if (this.Emps != null)
                    hashCode = hashCode * 59 + this.Emps.GetHashCode();
                if (this.Fccwireless != null)
                    hashCode = hashCode * 59 + this.Fccwireless.GetHashCode();
                if (this.Language != null)
                    hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Complain != null)
                    hashCode = hashCode * 59 + this.Complain.GetHashCode();
                if (this.Disposable != null)
                    hashCode = hashCode * 59 + this.Disposable.GetHashCode();
                if (this.Atc != null)
                    hashCode = hashCode * 59 + this.Atc.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.RtcTimeout != null)
                    hashCode = hashCode * 59 + this.RtcTimeout.GetHashCode();
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

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
    /// ValidateEmailAddressInputRow
    /// </summary>
    [DataContract]
    public partial class ValidateEmailAddressInputRow :  IEquatable<ValidateEmailAddressInputRow>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateEmailAddressInputRow" /> class.
        /// </summary>
        /// <param name="UserFields">These fields are returned, unmodified, in the user_fields section of the response..</param>
        /// <param name="Rtc">Enables or disables real-time confirmation. If the deliverability of an email address cannot be determined via our knowledge base, a real-time confirmation can be attempted..</param>
        /// <param name="Bogus">Specifies whether to check if the email address is fictitious. For example, bgates@microsoft.com..</param>
        /// <param name="Role">Specifies whether to check if the email address has a non-personal handle, such as info@, sales@, or webmaster@. For example, sales@example.com..</param>
        /// <param name="Emps">Specifies whether to check if the email address appears on the Direct Marketing Association&#39;s Do Not Email list (Electronic Mail Preference Service)..</param>
        /// <param name="Fccwireless">Specifies whether to check if the email address is associated with a domain that has restrictions on commercial email per the FCC..</param>
        /// <param name="Language">Specifies whether to check if the email address handle contains derogatory words..</param>
        /// <param name="Complain">Specifies whether to check if the owner of the email address is known to submit spam complaints..</param>
        /// <param name="Disposable">Specifies whether to check if the email address originates from a website that provides temporary email addresses, or if the email address appears to be temporary.</param>
        /// <param name="Atc">One character code controlling the advanced suggestion behavior.The possible values are: a, c, and n.</param>
        /// <param name="EmailAddress">The email address you want to validate..</param>
        /// <param name="RtcTimeout">Specifies the timeout for real-time confirmation. See the description of the rtc parameter. Specify the timeout value in milliseconds. Valid values are 0 to 4000. By default, the system allows 1200 milliseconds for this check..</param>
        public ValidateEmailAddressInputRow(List<ValidateMailingAddressInputRowUserFields> UserFields = null, string Rtc = null, string Bogus = null, string Role = null, string Emps = null, string Fccwireless = null, string Language = null, string Complain = null, string Disposable = null, string Atc = null, string EmailAddress = null, string RtcTimeout = null)
        {
            this.UserFields = UserFields;
            this.Rtc = Rtc;
            this.Bogus = Bogus;
            this.Role = Role;
            this.Emps = Emps;
            this.Fccwireless = Fccwireless;
            this.Language = Language;
            this.Complain = Complain;
            this.Disposable = Disposable;
            this.Atc = Atc;
            this.EmailAddress = EmailAddress;
            this.RtcTimeout = RtcTimeout;
        }
        
        /// <summary>
        /// These fields are returned, unmodified, in the user_fields section of the response.
        /// </summary>
        /// <value>These fields are returned, unmodified, in the user_fields section of the response.</value>
        [DataMember(Name="user_fields", EmitDefaultValue=false)]
        public List<ValidateMailingAddressInputRowUserFields> UserFields { get; set; }
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
            return this.Equals(obj as ValidateEmailAddressInputRow);
        }

        /// <summary>
        /// Returns true if ValidateEmailAddressInputRow instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidateEmailAddressInputRow to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateEmailAddressInputRow other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.UserFields == other.UserFields ||
                    this.UserFields != null &&
                    this.UserFields.SequenceEqual(other.UserFields)
                ) && 
                (
                    this.Rtc == other.Rtc ||
                    this.Rtc != null &&
                    this.Rtc.Equals(other.Rtc)
                ) && 
                (
                    this.Bogus == other.Bogus ||
                    this.Bogus != null &&
                    this.Bogus.Equals(other.Bogus)
                ) && 
                (
                    this.Role == other.Role ||
                    this.Role != null &&
                    this.Role.Equals(other.Role)
                ) && 
                (
                    this.Emps == other.Emps ||
                    this.Emps != null &&
                    this.Emps.Equals(other.Emps)
                ) && 
                (
                    this.Fccwireless == other.Fccwireless ||
                    this.Fccwireless != null &&
                    this.Fccwireless.Equals(other.Fccwireless)
                ) && 
                (
                    this.Language == other.Language ||
                    this.Language != null &&
                    this.Language.Equals(other.Language)
                ) && 
                (
                    this.Complain == other.Complain ||
                    this.Complain != null &&
                    this.Complain.Equals(other.Complain)
                ) && 
                (
                    this.Disposable == other.Disposable ||
                    this.Disposable != null &&
                    this.Disposable.Equals(other.Disposable)
                ) && 
                (
                    this.Atc == other.Atc ||
                    this.Atc != null &&
                    this.Atc.Equals(other.Atc)
                ) && 
                (
                    this.EmailAddress == other.EmailAddress ||
                    this.EmailAddress != null &&
                    this.EmailAddress.Equals(other.EmailAddress)
                ) && 
                (
                    this.RtcTimeout == other.RtcTimeout ||
                    this.RtcTimeout != null &&
                    this.RtcTimeout.Equals(other.RtcTimeout)
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
                if (this.UserFields != null)
                    hash = hash * 59 + this.UserFields.GetHashCode();
                if (this.Rtc != null)
                    hash = hash * 59 + this.Rtc.GetHashCode();
                if (this.Bogus != null)
                    hash = hash * 59 + this.Bogus.GetHashCode();
                if (this.Role != null)
                    hash = hash * 59 + this.Role.GetHashCode();
                if (this.Emps != null)
                    hash = hash * 59 + this.Emps.GetHashCode();
                if (this.Fccwireless != null)
                    hash = hash * 59 + this.Fccwireless.GetHashCode();
                if (this.Language != null)
                    hash = hash * 59 + this.Language.GetHashCode();
                if (this.Complain != null)
                    hash = hash * 59 + this.Complain.GetHashCode();
                if (this.Disposable != null)
                    hash = hash * 59 + this.Disposable.GetHashCode();
                if (this.Atc != null)
                    hash = hash * 59 + this.Atc.GetHashCode();
                if (this.EmailAddress != null)
                    hash = hash * 59 + this.EmailAddress.GetHashCode();
                if (this.RtcTimeout != null)
                    hash = hash * 59 + this.RtcTimeout.GetHashCode();
                return hash;
            }
        }
    }

}

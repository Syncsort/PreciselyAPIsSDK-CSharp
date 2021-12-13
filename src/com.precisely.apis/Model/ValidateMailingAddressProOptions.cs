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
    /// ValidateMailingAddressProOptions
    /// </summary>
    [DataContract]
    public partial class ValidateMailingAddressProOptions :  IEquatable<ValidateMailingAddressProOptions>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidateMailingAddressProOptions" /> class.
        /// </summary>
        /// <param name="OutputAddressBlocks">Specifies whether to return a formatted version of the address as it would be printed on a physical mail piece. (default to &quot;Y&quot;).</param>
        /// <param name="KeepMultimatch">Specifies whether to return multiple address for those input addresses that have more than one possible match. (default to &quot;N&quot;).</param>
        /// <param name="OutputCountryFormat">Specifies the format to use for the country name returned in the Country output field. (default to &quot;E&quot;).</param>
        /// <param name="OutputScript">Specifies the alphabet or script in which the output should be returned. (default to &quot;InputScript&quot;).</param>
        /// <param name="OutputCasing">Specify the casing of the output data. (default to &quot;M&quot;).</param>
        /// <param name="MaximumResults">A number between 1 and 10 that indicates the maximum number of addresses to return. (default to &quot;10&quot;).</param>
        public ValidateMailingAddressProOptions(string OutputAddressBlocks = null, string KeepMultimatch = null, string OutputCountryFormat = null, string OutputScript = null, string OutputCasing = null, string MaximumResults = null)
        {
            // use default value if no "OutputAddressBlocks" provided
            if (OutputAddressBlocks == null)
            {
                this.OutputAddressBlocks = "Y";
            }
            else
            {
                this.OutputAddressBlocks = OutputAddressBlocks;
            }
            // use default value if no "KeepMultimatch" provided
            if (KeepMultimatch == null)
            {
                this.KeepMultimatch = "N";
            }
            else
            {
                this.KeepMultimatch = KeepMultimatch;
            }
            // use default value if no "OutputCountryFormat" provided
            if (OutputCountryFormat == null)
            {
                this.OutputCountryFormat = "E";
            }
            else
            {
                this.OutputCountryFormat = OutputCountryFormat;
            }
            // use default value if no "OutputScript" provided
            if (OutputScript == null)
            {
                this.OutputScript = "InputScript";
            }
            else
            {
                this.OutputScript = OutputScript;
            }
            // use default value if no "OutputCasing" provided
            if (OutputCasing == null)
            {
                this.OutputCasing = "M";
            }
            else
            {
                this.OutputCasing = OutputCasing;
            }
            // use default value if no "MaximumResults" provided
            if (MaximumResults == null)
            {
                this.MaximumResults = "10";
            }
            else
            {
                this.MaximumResults = MaximumResults;
            }
        }
        
        /// <summary>
        /// Specifies whether to return a formatted version of the address as it would be printed on a physical mail piece.
        /// </summary>
        /// <value>Specifies whether to return a formatted version of the address as it would be printed on a physical mail piece.</value>
        [DataMember(Name="OutputAddressBlocks", EmitDefaultValue=false)]
        public string OutputAddressBlocks { get; set; }
        /// <summary>
        /// Specifies whether to return multiple address for those input addresses that have more than one possible match.
        /// </summary>
        /// <value>Specifies whether to return multiple address for those input addresses that have more than one possible match.</value>
        [DataMember(Name="KeepMultimatch", EmitDefaultValue=false)]
        public string KeepMultimatch { get; set; }
        /// <summary>
        /// Specifies the format to use for the country name returned in the Country output field.
        /// </summary>
        /// <value>Specifies the format to use for the country name returned in the Country output field.</value>
        [DataMember(Name="OutputCountryFormat", EmitDefaultValue=false)]
        public string OutputCountryFormat { get; set; }
        /// <summary>
        /// Specifies the alphabet or script in which the output should be returned.
        /// </summary>
        /// <value>Specifies the alphabet or script in which the output should be returned.</value>
        [DataMember(Name="OutputScript", EmitDefaultValue=false)]
        public string OutputScript { get; set; }
        /// <summary>
        /// Specify the casing of the output data.
        /// </summary>
        /// <value>Specify the casing of the output data.</value>
        [DataMember(Name="OutputCasing", EmitDefaultValue=false)]
        public string OutputCasing { get; set; }
        /// <summary>
        /// A number between 1 and 10 that indicates the maximum number of addresses to return.
        /// </summary>
        /// <value>A number between 1 and 10 that indicates the maximum number of addresses to return.</value>
        [DataMember(Name="MaximumResults", EmitDefaultValue=false)]
        public string MaximumResults { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateMailingAddressProOptions {\n");
            sb.Append("  OutputAddressBlocks: ").Append(OutputAddressBlocks).Append("\n");
            sb.Append("  KeepMultimatch: ").Append(KeepMultimatch).Append("\n");
            sb.Append("  OutputCountryFormat: ").Append(OutputCountryFormat).Append("\n");
            sb.Append("  OutputScript: ").Append(OutputScript).Append("\n");
            sb.Append("  OutputCasing: ").Append(OutputCasing).Append("\n");
            sb.Append("  MaximumResults: ").Append(MaximumResults).Append("\n");
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
            return this.Equals(obj as ValidateMailingAddressProOptions);
        }

        /// <summary>
        /// Returns true if ValidateMailingAddressProOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of ValidateMailingAddressProOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidateMailingAddressProOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.OutputAddressBlocks == other.OutputAddressBlocks ||
                    this.OutputAddressBlocks != null &&
                    this.OutputAddressBlocks.Equals(other.OutputAddressBlocks)
                ) && 
                (
                    this.KeepMultimatch == other.KeepMultimatch ||
                    this.KeepMultimatch != null &&
                    this.KeepMultimatch.Equals(other.KeepMultimatch)
                ) && 
                (
                    this.OutputCountryFormat == other.OutputCountryFormat ||
                    this.OutputCountryFormat != null &&
                    this.OutputCountryFormat.Equals(other.OutputCountryFormat)
                ) && 
                (
                    this.OutputScript == other.OutputScript ||
                    this.OutputScript != null &&
                    this.OutputScript.Equals(other.OutputScript)
                ) && 
                (
                    this.OutputCasing == other.OutputCasing ||
                    this.OutputCasing != null &&
                    this.OutputCasing.Equals(other.OutputCasing)
                ) && 
                (
                    this.MaximumResults == other.MaximumResults ||
                    this.MaximumResults != null &&
                    this.MaximumResults.Equals(other.MaximumResults)
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
                if (this.OutputAddressBlocks != null)
                    hash = hash * 59 + this.OutputAddressBlocks.GetHashCode();
                if (this.KeepMultimatch != null)
                    hash = hash * 59 + this.KeepMultimatch.GetHashCode();
                if (this.OutputCountryFormat != null)
                    hash = hash * 59 + this.OutputCountryFormat.GetHashCode();
                if (this.OutputScript != null)
                    hash = hash * 59 + this.OutputScript.GetHashCode();
                if (this.OutputCasing != null)
                    hash = hash * 59 + this.OutputCasing.GetHashCode();
                if (this.MaximumResults != null)
                    hash = hash * 59 + this.MaximumResults.GetHashCode();
                return hash;
            }
        }
    }

}

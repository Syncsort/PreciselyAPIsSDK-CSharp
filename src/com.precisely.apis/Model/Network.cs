/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 15.0.0
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
    /// Network
    /// </summary>
    [DataContract]
    public partial class Network :  IEquatable<Network>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Network" /> class.
        /// </summary>
        /// <param name="connectionFromHome">connectionFromHome.</param>
        /// <param name="organization">organization.</param>
        /// <param name="carrier">carrier.</param>
        /// <param name="organizationType">organizationType.</param>
        /// <param name="connectionType">connectionType.</param>
        /// <param name="lineSpeed">lineSpeed.</param>
        /// <param name="ipRouteType">ipRouteType.</param>
        /// <param name="hostingFacility">hostingFacility.</param>
        public Network(string connectionFromHome = default(string), string organization = default(string), Carrier carrier = default(Carrier), OrganizationType organizationType = default(OrganizationType), string connectionType = default(string), string lineSpeed = default(string), string ipRouteType = default(string), string hostingFacility = default(string))
        {
            this.ConnectionFromHome = connectionFromHome;
            this.Organization = organization;
            this.Carrier = carrier;
            this.OrganizationType = organizationType;
            this.ConnectionType = connectionType;
            this.LineSpeed = lineSpeed;
            this.IpRouteType = ipRouteType;
            this.HostingFacility = hostingFacility;
        }

        /// <summary>
        /// Gets or Sets ConnectionFromHome
        /// </summary>
        [DataMember(Name="connectionFromHome", EmitDefaultValue=false)]
        public string ConnectionFromHome { get; set; }

        /// <summary>
        /// Gets or Sets Organization
        /// </summary>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public string Organization { get; set; }

        /// <summary>
        /// Gets or Sets Carrier
        /// </summary>
        [DataMember(Name="carrier", EmitDefaultValue=false)]
        public Carrier Carrier { get; set; }

        /// <summary>
        /// Gets or Sets OrganizationType
        /// </summary>
        [DataMember(Name="organizationType", EmitDefaultValue=false)]
        public OrganizationType OrganizationType { get; set; }

        /// <summary>
        /// Gets or Sets ConnectionType
        /// </summary>
        [DataMember(Name="connectionType", EmitDefaultValue=false)]
        public string ConnectionType { get; set; }

        /// <summary>
        /// Gets or Sets LineSpeed
        /// </summary>
        [DataMember(Name="lineSpeed", EmitDefaultValue=false)]
        public string LineSpeed { get; set; }

        /// <summary>
        /// Gets or Sets IpRouteType
        /// </summary>
        [DataMember(Name="ipRouteType", EmitDefaultValue=false)]
        public string IpRouteType { get; set; }

        /// <summary>
        /// Gets or Sets HostingFacility
        /// </summary>
        [DataMember(Name="hostingFacility", EmitDefaultValue=false)]
        public string HostingFacility { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Network {\n");
            sb.Append("  ConnectionFromHome: ").Append(ConnectionFromHome).Append("\n");
            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  OrganizationType: ").Append(OrganizationType).Append("\n");
            sb.Append("  ConnectionType: ").Append(ConnectionType).Append("\n");
            sb.Append("  LineSpeed: ").Append(LineSpeed).Append("\n");
            sb.Append("  IpRouteType: ").Append(IpRouteType).Append("\n");
            sb.Append("  HostingFacility: ").Append(HostingFacility).Append("\n");
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
            return this.Equals(input as Network);
        }

        /// <summary>
        /// Returns true if Network instances are equal
        /// </summary>
        /// <param name="input">Instance of Network to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Network input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConnectionFromHome == input.ConnectionFromHome ||
                    (this.ConnectionFromHome != null &&
                    this.ConnectionFromHome.Equals(input.ConnectionFromHome))
                ) && 
                (
                    this.Organization == input.Organization ||
                    (this.Organization != null &&
                    this.Organization.Equals(input.Organization))
                ) && 
                (
                    this.Carrier == input.Carrier ||
                    (this.Carrier != null &&
                    this.Carrier.Equals(input.Carrier))
                ) && 
                (
                    this.OrganizationType == input.OrganizationType ||
                    (this.OrganizationType != null &&
                    this.OrganizationType.Equals(input.OrganizationType))
                ) && 
                (
                    this.ConnectionType == input.ConnectionType ||
                    (this.ConnectionType != null &&
                    this.ConnectionType.Equals(input.ConnectionType))
                ) && 
                (
                    this.LineSpeed == input.LineSpeed ||
                    (this.LineSpeed != null &&
                    this.LineSpeed.Equals(input.LineSpeed))
                ) && 
                (
                    this.IpRouteType == input.IpRouteType ||
                    (this.IpRouteType != null &&
                    this.IpRouteType.Equals(input.IpRouteType))
                ) && 
                (
                    this.HostingFacility == input.HostingFacility ||
                    (this.HostingFacility != null &&
                    this.HostingFacility.Equals(input.HostingFacility))
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
                if (this.ConnectionFromHome != null)
                    hashCode = hashCode * 59 + this.ConnectionFromHome.GetHashCode();
                if (this.Organization != null)
                    hashCode = hashCode * 59 + this.Organization.GetHashCode();
                if (this.Carrier != null)
                    hashCode = hashCode * 59 + this.Carrier.GetHashCode();
                if (this.OrganizationType != null)
                    hashCode = hashCode * 59 + this.OrganizationType.GetHashCode();
                if (this.ConnectionType != null)
                    hashCode = hashCode * 59 + this.ConnectionType.GetHashCode();
                if (this.LineSpeed != null)
                    hashCode = hashCode * 59 + this.LineSpeed.GetHashCode();
                if (this.IpRouteType != null)
                    hashCode = hashCode * 59 + this.IpRouteType.GetHashCode();
                if (this.HostingFacility != null)
                    hashCode = hashCode * 59 + this.HostingFacility.GetHashCode();
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

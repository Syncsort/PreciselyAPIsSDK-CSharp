/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 18.1.0
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
    /// StudentEthnicity
    /// </summary>
    [DataContract]
    public partial class StudentEthnicity :  IEquatable<StudentEthnicity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StudentEthnicity" /> class.
        /// </summary>
        /// <param name="indianAlaskaNative">indianAlaskaNative.</param>
        /// <param name="asian">asian.</param>
        /// <param name="hispanic">hispanic.</param>
        /// <param name="black">black.</param>
        /// <param name="white">white.</param>
        /// <param name="hawaiianPacificlslander">hawaiianPacificlslander.</param>
        /// <param name="twoOrMoreRaces">twoOrMoreRaces.</param>
        public StudentEthnicity(string indianAlaskaNative = default(string), string asian = default(string), string hispanic = default(string), string black = default(string), string white = default(string), string hawaiianPacificlslander = default(string), string twoOrMoreRaces = default(string))
        {
            this.IndianAlaskaNative = indianAlaskaNative;
            this.Asian = asian;
            this.Hispanic = hispanic;
            this.Black = black;
            this.White = white;
            this.HawaiianPacificlslander = hawaiianPacificlslander;
            this.TwoOrMoreRaces = twoOrMoreRaces;
        }

        /// <summary>
        /// Gets or Sets IndianAlaskaNative
        /// </summary>
        [DataMember(Name="indianAlaskaNative", EmitDefaultValue=false)]
        public string IndianAlaskaNative { get; set; }

        /// <summary>
        /// Gets or Sets Asian
        /// </summary>
        [DataMember(Name="asian", EmitDefaultValue=false)]
        public string Asian { get; set; }

        /// <summary>
        /// Gets or Sets Hispanic
        /// </summary>
        [DataMember(Name="hispanic", EmitDefaultValue=false)]
        public string Hispanic { get; set; }

        /// <summary>
        /// Gets or Sets Black
        /// </summary>
        [DataMember(Name="black", EmitDefaultValue=false)]
        public string Black { get; set; }

        /// <summary>
        /// Gets or Sets White
        /// </summary>
        [DataMember(Name="white", EmitDefaultValue=false)]
        public string White { get; set; }

        /// <summary>
        /// Gets or Sets HawaiianPacificlslander
        /// </summary>
        [DataMember(Name="hawaiianPacificlslander", EmitDefaultValue=false)]
        public string HawaiianPacificlslander { get; set; }

        /// <summary>
        /// Gets or Sets TwoOrMoreRaces
        /// </summary>
        [DataMember(Name="twoOrMoreRaces", EmitDefaultValue=false)]
        public string TwoOrMoreRaces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StudentEthnicity {\n");
            sb.Append("  IndianAlaskaNative: ").Append(IndianAlaskaNative).Append("\n");
            sb.Append("  Asian: ").Append(Asian).Append("\n");
            sb.Append("  Hispanic: ").Append(Hispanic).Append("\n");
            sb.Append("  Black: ").Append(Black).Append("\n");
            sb.Append("  White: ").Append(White).Append("\n");
            sb.Append("  HawaiianPacificlslander: ").Append(HawaiianPacificlslander).Append("\n");
            sb.Append("  TwoOrMoreRaces: ").Append(TwoOrMoreRaces).Append("\n");
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
            return this.Equals(input as StudentEthnicity);
        }

        /// <summary>
        /// Returns true if StudentEthnicity instances are equal
        /// </summary>
        /// <param name="input">Instance of StudentEthnicity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StudentEthnicity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.IndianAlaskaNative == input.IndianAlaskaNative ||
                    (this.IndianAlaskaNative != null &&
                    this.IndianAlaskaNative.Equals(input.IndianAlaskaNative))
                ) && 
                (
                    this.Asian == input.Asian ||
                    (this.Asian != null &&
                    this.Asian.Equals(input.Asian))
                ) && 
                (
                    this.Hispanic == input.Hispanic ||
                    (this.Hispanic != null &&
                    this.Hispanic.Equals(input.Hispanic))
                ) && 
                (
                    this.Black == input.Black ||
                    (this.Black != null &&
                    this.Black.Equals(input.Black))
                ) && 
                (
                    this.White == input.White ||
                    (this.White != null &&
                    this.White.Equals(input.White))
                ) && 
                (
                    this.HawaiianPacificlslander == input.HawaiianPacificlslander ||
                    (this.HawaiianPacificlslander != null &&
                    this.HawaiianPacificlslander.Equals(input.HawaiianPacificlslander))
                ) && 
                (
                    this.TwoOrMoreRaces == input.TwoOrMoreRaces ||
                    (this.TwoOrMoreRaces != null &&
                    this.TwoOrMoreRaces.Equals(input.TwoOrMoreRaces))
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
                if (this.IndianAlaskaNative != null)
                    hashCode = hashCode * 59 + this.IndianAlaskaNative.GetHashCode();
                if (this.Asian != null)
                    hashCode = hashCode * 59 + this.Asian.GetHashCode();
                if (this.Hispanic != null)
                    hashCode = hashCode * 59 + this.Hispanic.GetHashCode();
                if (this.Black != null)
                    hashCode = hashCode * 59 + this.Black.GetHashCode();
                if (this.White != null)
                    hashCode = hashCode * 59 + this.White.GetHashCode();
                if (this.HawaiianPacificlslander != null)
                    hashCode = hashCode * 59 + this.HawaiianPacificlslander.GetHashCode();
                if (this.TwoOrMoreRaces != null)
                    hashCode = hashCode * 59 + this.TwoOrMoreRaces.GetHashCode();
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

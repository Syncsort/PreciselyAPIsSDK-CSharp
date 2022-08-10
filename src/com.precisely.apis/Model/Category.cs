/*
 * Precisely APIs
 *
 * Enhance & enrich your data, applications, business processes, and workflows with rich location, information, and identify APIs.
 *
 * The version of the OpenAPI document: 12.0.0
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
    /// Category
    /// </summary>
    [DataContract]
    public partial class Category :  IEquatable<Category>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Category" /> class.
        /// </summary>
        /// <param name="categoryCode">categoryCode.</param>
        /// <param name="tradeDivision">tradeDivision.</param>
        /// <param name="tradeGroup">tradeGroup.</param>
        /// <param name="subClass">subClass.</param>
        /// <param name="_class">_class.</param>
        public Category(string categoryCode = default(string), string tradeDivision = default(string), string tradeGroup = default(string), string subClass = default(string), string _class = default(string))
        {
            this.CategoryCode = categoryCode;
            this.TradeDivision = tradeDivision;
            this.TradeGroup = tradeGroup;
            this.SubClass = subClass;
            this.Class = _class;
        }

        /// <summary>
        /// Gets or Sets CategoryCode
        /// </summary>
        [DataMember(Name="categoryCode", EmitDefaultValue=false)]
        public string CategoryCode { get; set; }

        /// <summary>
        /// Gets or Sets TradeDivision
        /// </summary>
        [DataMember(Name="tradeDivision", EmitDefaultValue=false)]
        public string TradeDivision { get; set; }

        /// <summary>
        /// Gets or Sets TradeGroup
        /// </summary>
        [DataMember(Name="tradeGroup", EmitDefaultValue=false)]
        public string TradeGroup { get; set; }

        /// <summary>
        /// Gets or Sets SubClass
        /// </summary>
        [DataMember(Name="subClass", EmitDefaultValue=false)]
        public string SubClass { get; set; }

        /// <summary>
        /// Gets or Sets Class
        /// </summary>
        [DataMember(Name="class", EmitDefaultValue=false)]
        public string Class { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Category {\n");
            sb.Append("  CategoryCode: ").Append(CategoryCode).Append("\n");
            sb.Append("  TradeDivision: ").Append(TradeDivision).Append("\n");
            sb.Append("  TradeGroup: ").Append(TradeGroup).Append("\n");
            sb.Append("  SubClass: ").Append(SubClass).Append("\n");
            sb.Append("  Class: ").Append(Class).Append("\n");
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
            return this.Equals(input as Category);
        }

        /// <summary>
        /// Returns true if Category instances are equal
        /// </summary>
        /// <param name="input">Instance of Category to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Category input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CategoryCode == input.CategoryCode ||
                    (this.CategoryCode != null &&
                    this.CategoryCode.Equals(input.CategoryCode))
                ) && 
                (
                    this.TradeDivision == input.TradeDivision ||
                    (this.TradeDivision != null &&
                    this.TradeDivision.Equals(input.TradeDivision))
                ) && 
                (
                    this.TradeGroup == input.TradeGroup ||
                    (this.TradeGroup != null &&
                    this.TradeGroup.Equals(input.TradeGroup))
                ) && 
                (
                    this.SubClass == input.SubClass ||
                    (this.SubClass != null &&
                    this.SubClass.Equals(input.SubClass))
                ) && 
                (
                    this.Class == input.Class ||
                    (this.Class != null &&
                    this.Class.Equals(input.Class))
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
                if (this.CategoryCode != null)
                    hashCode = hashCode * 59 + this.CategoryCode.GetHashCode();
                if (this.TradeDivision != null)
                    hashCode = hashCode * 59 + this.TradeDivision.GetHashCode();
                if (this.TradeGroup != null)
                    hashCode = hashCode * 59 + this.TradeGroup.GetHashCode();
                if (this.SubClass != null)
                    hashCode = hashCode * 59 + this.SubClass.GetHashCode();
                if (this.Class != null)
                    hashCode = hashCode * 59 + this.Class.GetHashCode();
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

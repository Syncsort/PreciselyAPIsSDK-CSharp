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
    /// TaxLocations
    /// </summary>
    [DataContract]
    public partial class TaxLocations :  IEquatable<TaxLocations>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxLocations" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaxLocations() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxLocations" /> class.
        /// </summary>
        /// <param name="geometry">geometry (required).</param>
        /// <param name="purchaseAmount">purchaseAmount.</param>
        /// <param name="objectId">objectId.</param>
        public TaxLocations(TaxGeometry geometry = default(TaxGeometry), string purchaseAmount = default(string), string objectId = default(string))
        {
            // to ensure "geometry" is required (not null)
            if (geometry == null)
            {
                throw new InvalidDataException("geometry is a required property for TaxLocations and cannot be null");
            }
            else
            {
                this.Geometry = geometry;
            }

            this.PurchaseAmount = purchaseAmount;
            this.ObjectId = objectId;
        }

        /// <summary>
        /// Gets or Sets Geometry
        /// </summary>
        [DataMember(Name="geometry", EmitDefaultValue=true)]
        public TaxGeometry Geometry { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseAmount
        /// </summary>
        [DataMember(Name="purchaseAmount", EmitDefaultValue=false)]
        public string PurchaseAmount { get; set; }

        /// <summary>
        /// Gets or Sets ObjectId
        /// </summary>
        [DataMember(Name="objectId", EmitDefaultValue=false)]
        public string ObjectId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaxLocations {\n");
            sb.Append("  Geometry: ").Append(Geometry).Append("\n");
            sb.Append("  PurchaseAmount: ").Append(PurchaseAmount).Append("\n");
            sb.Append("  ObjectId: ").Append(ObjectId).Append("\n");
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
            return this.Equals(input as TaxLocations);
        }

        /// <summary>
        /// Returns true if TaxLocations instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxLocations to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxLocations input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Geometry == input.Geometry ||
                    (this.Geometry != null &&
                    this.Geometry.Equals(input.Geometry))
                ) && 
                (
                    this.PurchaseAmount == input.PurchaseAmount ||
                    (this.PurchaseAmount != null &&
                    this.PurchaseAmount.Equals(input.PurchaseAmount))
                ) && 
                (
                    this.ObjectId == input.ObjectId ||
                    (this.ObjectId != null &&
                    this.ObjectId.Equals(input.ObjectId))
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
                if (this.Geometry != null)
                    hashCode = hashCode * 59 + this.Geometry.GetHashCode();
                if (this.PurchaseAmount != null)
                    hashCode = hashCode * 59 + this.PurchaseAmount.GetHashCode();
                if (this.ObjectId != null)
                    hashCode = hashCode * 59 + this.ObjectId.GetHashCode();
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

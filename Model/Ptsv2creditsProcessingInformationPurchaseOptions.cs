/* 
 * CyberSource Merged Spec
 *
 * All CyberSource API specs merged together. These are available at https://developer.cybersource.com/api/reference/api-reference.html
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = CyberSource.Client.SwaggerDateConverter;

namespace CyberSource.Model
{
    /// <summary>
    /// Ptsv2creditsProcessingInformationPurchaseOptions
    /// </summary>
    [DataContract]
    public partial class Ptsv2creditsProcessingInformationPurchaseOptions :  IEquatable<Ptsv2creditsProcessingInformationPurchaseOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ptsv2creditsProcessingInformationPurchaseOptions" /> class.
        /// </summary>
        /// <param name="IsElectronicBenefitsTransfer">Flag that indicates that this transaction is an EBT transaction.Possible values: - **true** - **false** .</param>
        public Ptsv2creditsProcessingInformationPurchaseOptions(bool? IsElectronicBenefitsTransfer = default(bool?))
        {
            this.IsElectronicBenefitsTransfer = IsElectronicBenefitsTransfer;
        }
        
        /// <summary>
        /// Flag that indicates that this transaction is an EBT transaction.Possible values: - **true** - **false** 
        /// </summary>
        /// <value>Flag that indicates that this transaction is an EBT transaction.Possible values: - **true** - **false** </value>
        [DataMember(Name="isElectronicBenefitsTransfer", EmitDefaultValue=false)]
        public bool? IsElectronicBenefitsTransfer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Ptsv2creditsProcessingInformationPurchaseOptions {\n");
            sb.Append("  IsElectronicBenefitsTransfer: ").Append(IsElectronicBenefitsTransfer).Append("\n");
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
            return this.Equals(obj as Ptsv2creditsProcessingInformationPurchaseOptions);
        }

        /// <summary>
        /// Returns true if Ptsv2creditsProcessingInformationPurchaseOptions instances are equal
        /// </summary>
        /// <param name="other">Instance of Ptsv2creditsProcessingInformationPurchaseOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Ptsv2creditsProcessingInformationPurchaseOptions other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.IsElectronicBenefitsTransfer == other.IsElectronicBenefitsTransfer ||
                    this.IsElectronicBenefitsTransfer != null &&
                    this.IsElectronicBenefitsTransfer.Equals(other.IsElectronicBenefitsTransfer)
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
                if (this.IsElectronicBenefitsTransfer != null)
                    hash = hash * 59 + this.IsElectronicBenefitsTransfer.GetHashCode();
                return hash;
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

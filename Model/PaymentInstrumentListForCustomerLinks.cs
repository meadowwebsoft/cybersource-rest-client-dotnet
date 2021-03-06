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
    /// PaymentInstrumentListForCustomerLinks
    /// </summary>
    [DataContract]
    public partial class PaymentInstrumentListForCustomerLinks :  IEquatable<PaymentInstrumentListForCustomerLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentInstrumentListForCustomerLinks" /> class.
        /// </summary>
        /// <param name="Self">Self.</param>
        /// <param name="First">First.</param>
        /// <param name="Prev">Prev.</param>
        /// <param name="Next">Next.</param>
        /// <param name="Last">Last.</param>
        public PaymentInstrumentListForCustomerLinks(PaymentInstrumentListForCustomerLinksSelf Self = default(PaymentInstrumentListForCustomerLinksSelf), PaymentInstrumentListForCustomerLinksFirst First = default(PaymentInstrumentListForCustomerLinksFirst), PaymentInstrumentListForCustomerLinksPrev Prev = default(PaymentInstrumentListForCustomerLinksPrev), PaymentInstrumentListForCustomerLinksNext Next = default(PaymentInstrumentListForCustomerLinksNext), PaymentInstrumentListForCustomerLinksLast Last = default(PaymentInstrumentListForCustomerLinksLast))
        {
            this.Self = Self;
            this.First = First;
            this.Prev = Prev;
            this.Next = Next;
            this.Last = Last;
        }
        
        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name="self", EmitDefaultValue=false)]
        public PaymentInstrumentListForCustomerLinksSelf Self { get; set; }

        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name="first", EmitDefaultValue=false)]
        public PaymentInstrumentListForCustomerLinksFirst First { get; set; }

        /// <summary>
        /// Gets or Sets Prev
        /// </summary>
        [DataMember(Name="prev", EmitDefaultValue=false)]
        public PaymentInstrumentListForCustomerLinksPrev Prev { get; set; }

        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [DataMember(Name="next", EmitDefaultValue=false)]
        public PaymentInstrumentListForCustomerLinksNext Next { get; set; }

        /// <summary>
        /// Gets or Sets Last
        /// </summary>
        [DataMember(Name="last", EmitDefaultValue=false)]
        public PaymentInstrumentListForCustomerLinksLast Last { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentInstrumentListForCustomerLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Prev: ").Append(Prev).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
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
            return this.Equals(obj as PaymentInstrumentListForCustomerLinks);
        }

        /// <summary>
        /// Returns true if PaymentInstrumentListForCustomerLinks instances are equal
        /// </summary>
        /// <param name="other">Instance of PaymentInstrumentListForCustomerLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentInstrumentListForCustomerLinks other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Self == other.Self ||
                    this.Self != null &&
                    this.Self.Equals(other.Self)
                ) && 
                (
                    this.First == other.First ||
                    this.First != null &&
                    this.First.Equals(other.First)
                ) && 
                (
                    this.Prev == other.Prev ||
                    this.Prev != null &&
                    this.Prev.Equals(other.Prev)
                ) && 
                (
                    this.Next == other.Next ||
                    this.Next != null &&
                    this.Next.Equals(other.Next)
                ) && 
                (
                    this.Last == other.Last ||
                    this.Last != null &&
                    this.Last.Equals(other.Last)
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
                if (this.Self != null)
                    hash = hash * 59 + this.Self.GetHashCode();
                if (this.First != null)
                    hash = hash * 59 + this.First.GetHashCode();
                if (this.Prev != null)
                    hash = hash * 59 + this.Prev.GetHashCode();
                if (this.Next != null)
                    hash = hash * 59 + this.Next.GetHashCode();
                if (this.Last != null)
                    hash = hash * 59 + this.Last.GetHashCode();
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

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
    /// Riskv1decisionsCardVerification
    /// </summary>
    [DataContract]
    public partial class Riskv1decisionsCardVerification :  IEquatable<Riskv1decisionsCardVerification>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Riskv1decisionsCardVerification" /> class.
        /// </summary>
        /// <param name="ResultCode">Result of card verification. Returned by the authorization service in the &#x60;processorInformation.cardVerification.resultCode&#x60; reply field. If ics_auth and ics_score are requested at the same time, the value is automatically passed from ics_auth to ics_score. For more information on using this field, see \&quot;\&quot;Sending the Results of Address and Card Verification Tests,\&quot;\&quot; page 16. The field contains one of the following values:   - &#x60;I&#x60;: Card verification number failed processor&#39;s data   validation check.   - &#x60;M&#x60;: Card verification number matched.   - &#x60;N&#x60;: Card verification number not matched.   - &#x60;P&#x60;: Card verification number not processed.   - &#x60;S&#x60;: Card verification number is on the card but was not included in the request.   - &#x60;U&#x60;: Card verification is not supported by the issuing bank.   - &#x60;X&#x60;: Card verification is not supported by the payment card company.   - Space Character: Deprecated. Ignore this value.   - &#x60;1&#x60;: CyberSource does not support card verification for this processor or card type.   - &#x60;2&#x60;: Processor returned value unrecognized for card verification response.   - &#x60;3&#x60;: Processor did not return card verification result code. .</param>
        public Riskv1decisionsCardVerification(string ResultCode = default(string))
        {
            this.ResultCode = ResultCode;
        }
        
        /// <summary>
        /// Result of card verification. Returned by the authorization service in the &#x60;processorInformation.cardVerification.resultCode&#x60; reply field. If ics_auth and ics_score are requested at the same time, the value is automatically passed from ics_auth to ics_score. For more information on using this field, see \&quot;\&quot;Sending the Results of Address and Card Verification Tests,\&quot;\&quot; page 16. The field contains one of the following values:   - &#x60;I&#x60;: Card verification number failed processor&#39;s data   validation check.   - &#x60;M&#x60;: Card verification number matched.   - &#x60;N&#x60;: Card verification number not matched.   - &#x60;P&#x60;: Card verification number not processed.   - &#x60;S&#x60;: Card verification number is on the card but was not included in the request.   - &#x60;U&#x60;: Card verification is not supported by the issuing bank.   - &#x60;X&#x60;: Card verification is not supported by the payment card company.   - Space Character: Deprecated. Ignore this value.   - &#x60;1&#x60;: CyberSource does not support card verification for this processor or card type.   - &#x60;2&#x60;: Processor returned value unrecognized for card verification response.   - &#x60;3&#x60;: Processor did not return card verification result code. 
        /// </summary>
        /// <value>Result of card verification. Returned by the authorization service in the &#x60;processorInformation.cardVerification.resultCode&#x60; reply field. If ics_auth and ics_score are requested at the same time, the value is automatically passed from ics_auth to ics_score. For more information on using this field, see \&quot;\&quot;Sending the Results of Address and Card Verification Tests,\&quot;\&quot; page 16. The field contains one of the following values:   - &#x60;I&#x60;: Card verification number failed processor&#39;s data   validation check.   - &#x60;M&#x60;: Card verification number matched.   - &#x60;N&#x60;: Card verification number not matched.   - &#x60;P&#x60;: Card verification number not processed.   - &#x60;S&#x60;: Card verification number is on the card but was not included in the request.   - &#x60;U&#x60;: Card verification is not supported by the issuing bank.   - &#x60;X&#x60;: Card verification is not supported by the payment card company.   - Space Character: Deprecated. Ignore this value.   - &#x60;1&#x60;: CyberSource does not support card verification for this processor or card type.   - &#x60;2&#x60;: Processor returned value unrecognized for card verification response.   - &#x60;3&#x60;: Processor did not return card verification result code. </value>
        [DataMember(Name="resultCode", EmitDefaultValue=false)]
        public string ResultCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Riskv1decisionsCardVerification {\n");
            sb.Append("  ResultCode: ").Append(ResultCode).Append("\n");
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
            return this.Equals(obj as Riskv1decisionsCardVerification);
        }

        /// <summary>
        /// Returns true if Riskv1decisionsCardVerification instances are equal
        /// </summary>
        /// <param name="other">Instance of Riskv1decisionsCardVerification to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Riskv1decisionsCardVerification other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ResultCode == other.ResultCode ||
                    this.ResultCode != null &&
                    this.ResultCode.Equals(other.ResultCode)
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
                if (this.ResultCode != null)
                    hash = hash * 59 + this.ResultCode.GetHashCode();
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
            // ResultCode (string) maxLength
            if(this.ResultCode != null && this.ResultCode.Length > 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ResultCode, length must be less than 1.", new [] { "ResultCode" });
            }

            yield break;
        }
    }

}
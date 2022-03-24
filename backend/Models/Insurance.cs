/* 
 * Получение публичной информации о банковских продуктах
 *
 * Содержит описываются API для Открытых банковских интерфейсов для получения публичной информации о банковских продуктах.
 *
 * OpenAPI spec version: 1.3.1
 * Contact: info@fintechru.org
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
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Описание бизнес-правил заполнения информации о страховой программе для оформления продукта
    /// </summary>
    [DataContract]
        public partial class Insurance :  IEquatable<Insurance>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Insurance" /> class.
        /// </summary>
        /// <param name="insuranceId">Идентификатор страховой программы.</param>
        /// <param name="insuranceName">Наименование страховой программы (required).</param>
        /// <param name="comments">comments.</param>
        /// <param name="companyName">Название компании, предоставляющей услуги по страхованию (required).</param>
        /// <param name="amountRate">amountRate.</param>
        /// <param name="agreementURL">Ссылка на информацию с условиями страховой программы.</param>
        /// <param name="riskComments">riskComments.</param>
        public Insurance(string insuranceId = default(string), string insuranceName = default(string), Comments comments = default(Comments), string companyName = default(string), string amountRate = default(string), string agreementURL = default(string), Comments riskComments = default(Comments))
        {
            // to ensure "insuranceName" is required (not null)
            if (insuranceName == null)
            {
                throw new InvalidDataException("insuranceName is a required property for Insurance and cannot be null");
            }
            else
            {
                this.InsuranceName = insuranceName;
            }
            // to ensure "companyName" is required (not null)
            if (companyName == null)
            {
                throw new InvalidDataException("companyName is a required property for Insurance and cannot be null");
            }
            else
            {
                this.CompanyName = companyName;
            }
            this.InsuranceId = insuranceId;
            this.Comments = comments;
            this.AmountRate = amountRate;
            this.AgreementURL = agreementURL;
            this.RiskComments = riskComments;
        }
        
        /// <summary>
        /// Идентификатор страховой программы
        /// </summary>
        /// <value>Идентификатор страховой программы</value>
        [DataMember(Name="insuranceId", EmitDefaultValue=false)]
        public string InsuranceId { get; set; }

        /// <summary>
        /// Наименование страховой программы
        /// </summary>
        /// <value>Наименование страховой программы</value>
        [DataMember(Name="insuranceName", EmitDefaultValue=false)]
        public string InsuranceName { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public Comments Comments { get; set; }

        /// <summary>
        /// Название компании, предоставляющей услуги по страхованию
        /// </summary>
        /// <value>Название компании, предоставляющей услуги по страхованию</value>
        [DataMember(Name="companyName", EmitDefaultValue=false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or Sets AmountRate
        /// </summary>
        [DataMember(Name="amountRate", EmitDefaultValue=false)]
        public string AmountRate { get; set; }

        /// <summary>
        /// Ссылка на информацию с условиями страховой программы
        /// </summary>
        /// <value>Ссылка на информацию с условиями страховой программы</value>
        [DataMember(Name="agreementURL", EmitDefaultValue=false)]
        public string AgreementURL { get; set; }

        /// <summary>
        /// Gets or Sets RiskComments
        /// </summary>
        [DataMember(Name="riskComments", EmitDefaultValue=false)]
        public Comments RiskComments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Insurance {\n");
            sb.Append("  InsuranceId: ").Append(InsuranceId).Append("\n");
            sb.Append("  InsuranceName: ").Append(InsuranceName).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  AmountRate: ").Append(AmountRate).Append("\n");
            sb.Append("  AgreementURL: ").Append(AgreementURL).Append("\n");
            sb.Append("  RiskComments: ").Append(RiskComments).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Insurance);
        }

        /// <summary>
        /// Returns true if Insurance instances are equal
        /// </summary>
        /// <param name="input">Instance of Insurance to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Insurance input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InsuranceId == input.InsuranceId ||
                    (this.InsuranceId != null &&
                    this.InsuranceId.Equals(input.InsuranceId))
                ) && 
                (
                    this.InsuranceName == input.InsuranceName ||
                    (this.InsuranceName != null &&
                    this.InsuranceName.Equals(input.InsuranceName))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.AmountRate == input.AmountRate ||
                    (this.AmountRate != null &&
                    this.AmountRate.Equals(input.AmountRate))
                ) && 
                (
                    this.AgreementURL == input.AgreementURL ||
                    (this.AgreementURL != null &&
                    this.AgreementURL.Equals(input.AgreementURL))
                ) && 
                (
                    this.RiskComments == input.RiskComments ||
                    (this.RiskComments != null &&
                    this.RiskComments.Equals(input.RiskComments))
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
                if (this.InsuranceId != null)
                    hashCode = hashCode * 59 + this.InsuranceId.GetHashCode();
                if (this.InsuranceName != null)
                    hashCode = hashCode * 59 + this.InsuranceName.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.CompanyName != null)
                    hashCode = hashCode * 59 + this.CompanyName.GetHashCode();
                if (this.AmountRate != null)
                    hashCode = hashCode * 59 + this.AmountRate.GetHashCode();
                if (this.AgreementURL != null)
                    hashCode = hashCode * 59 + this.AgreementURL.GetHashCode();
                if (this.RiskComments != null)
                    hashCode = hashCode * 59 + this.RiskComments.GetHashCode();
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
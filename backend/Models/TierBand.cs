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
    /// Подробная информация об уровнях процентной ставки
    /// </summary>
    [DataContract]
        public partial class TierBand :  IEquatable<TierBand>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TierBand" /> class.
        /// </summary>
        /// <param name="aER">aER (required).</param>
        /// <param name="comments">comments.</param>
        /// <param name="identification">Уникальная и однозначная идентификация диапазона уровней процентной ставки.</param>
        /// <param name="tierCurrency">tierCurrency.</param>
        /// <param name="interestRate">interestRate.</param>
        /// <param name="tierValueMinimum">tierValueMinimum (required).</param>
        /// <param name="tierValueMaximum">tierValueMaximum.</param>
        /// <param name="tierPrimaryValueMinimum">tierPrimaryValueMinimum.</param>
        /// <param name="tierPrimaryValueMaximum">tierPrimaryValueMaximum.</param>
        /// <param name="tierRemainValueMinimum">tierRemainValueMinimum.</param>
        /// <param name="tierValueMinTerm">Минимальный срок, на которой применяется уровень процентной ставки.</param>
        /// <param name="minTermPeriod">minTermPeriod.</param>
        /// <param name="tierValueMaxTerm">Максимальный срок, для которой применяется уровень процентной ставки.</param>
        /// <param name="maxTermPeriod">maxTermPeriod.</param>
        /// <param name="applicationFrequency">applicationFrequency (required).</param>
        /// <param name="otherApplicationFrequency">otherApplicationFrequency.</param>
        /// <param name="calculationFrequency">calculationFrequency.</param>
        /// <param name="otherCalculationFrequency">otherCalculationFrequency.</param>
        /// <param name="interestFeesCharges">Информация о комиссиях и сборах.</param>
        public TierBand(string aER = default(string), Comments comments = default(Comments), string identification = default(string), string tierCurrency = default(string), string interestRate = default(string), string tierValueMinimum = default(string), string tierValueMaximum = default(string), string tierPrimaryValueMinimum = default(string), string tierPrimaryValueMaximum = default(string), string tierRemainValueMinimum = default(string), int? tierValueMinTerm = default(int?), PeriodUnit minTermPeriod = default(PeriodUnit), int? tierValueMaxTerm = default(int?), PeriodUnit maxTermPeriod = default(PeriodUnit), FrequencyType applicationFrequency = default(FrequencyType), OtherTypeCode otherApplicationFrequency = default(OtherTypeCode), FrequencyType calculationFrequency = default(FrequencyType), OtherTypeCode otherCalculationFrequency = default(OtherTypeCode), List<InterestFeesCharges> interestFeesCharges = default(List<InterestFeesCharges>))
        {
            // to ensure "aER" is required (not null)
            if (aER == null)
            {
                throw new InvalidDataException("aER is a required property for TierBand and cannot be null");
            }
            else
            {
                this.AER = aER;
            }
            // to ensure "tierValueMinimum" is required (not null)
            if (tierValueMinimum == null)
            {
                throw new InvalidDataException("tierValueMinimum is a required property for TierBand and cannot be null");
            }
            else
            {
                this.TierValueMinimum = tierValueMinimum;
            }
            // to ensure "applicationFrequency" is required (not null)
            if (applicationFrequency == null)
            {
                throw new InvalidDataException("applicationFrequency is a required property for TierBand and cannot be null");
            }
            else
            {
                this.ApplicationFrequency = applicationFrequency;
            }
            this.Comments = comments;
            this.Identification = identification;
            this.TierCurrency = tierCurrency;
            this.InterestRate = interestRate;
            this.TierValueMaximum = tierValueMaximum;
            this.TierPrimaryValueMinimum = tierPrimaryValueMinimum;
            this.TierPrimaryValueMaximum = tierPrimaryValueMaximum;
            this.TierRemainValueMinimum = tierRemainValueMinimum;
            this.TierValueMinTerm = tierValueMinTerm;
            this.MinTermPeriod = minTermPeriod;
            this.TierValueMaxTerm = tierValueMaxTerm;
            this.MaxTermPeriod = maxTermPeriod;
            this.OtherApplicationFrequency = otherApplicationFrequency;
            this.CalculationFrequency = calculationFrequency;
            this.OtherCalculationFrequency = otherCalculationFrequency;
            this.InterestFeesCharges = interestFeesCharges;
        }
        
        /// <summary>
        /// Gets or Sets AER
        /// </summary>
        [DataMember(Name="AER", EmitDefaultValue=false)]
        public string AER { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public Comments Comments { get; set; }

        /// <summary>
        /// Уникальная и однозначная идентификация диапазона уровней процентной ставки
        /// </summary>
        /// <value>Уникальная и однозначная идентификация диапазона уровней процентной ставки</value>
        [DataMember(Name="identification", EmitDefaultValue=false)]
        public string Identification { get; set; }

        /// <summary>
        /// Gets or Sets TierCurrency
        /// </summary>
        [DataMember(Name="tierCurrency", EmitDefaultValue=false)]
        public string TierCurrency { get; set; }

        /// <summary>
        /// Gets or Sets InterestRate
        /// </summary>
        [DataMember(Name="interestRate", EmitDefaultValue=false)]
        public string InterestRate { get; set; }

        /// <summary>
        /// Gets or Sets TierValueMinimum
        /// </summary>
        [DataMember(Name="tierValueMinimum", EmitDefaultValue=false)]
        public string TierValueMinimum { get; set; }

        /// <summary>
        /// Gets or Sets TierValueMaximum
        /// </summary>
        [DataMember(Name="tierValueMaximum", EmitDefaultValue=false)]
        public string TierValueMaximum { get; set; }

        /// <summary>
        /// Gets or Sets TierPrimaryValueMinimum
        /// </summary>
        [DataMember(Name="tierPrimaryValueMinimum", EmitDefaultValue=false)]
        public string TierPrimaryValueMinimum { get; set; }

        /// <summary>
        /// Gets or Sets TierPrimaryValueMaximum
        /// </summary>
        [DataMember(Name="tierPrimaryValueMaximum", EmitDefaultValue=false)]
        public string TierPrimaryValueMaximum { get; set; }

        /// <summary>
        /// Gets or Sets TierRemainValueMinimum
        /// </summary>
        [DataMember(Name="tierRemainValueMinimum", EmitDefaultValue=false)]
        public string TierRemainValueMinimum { get; set; }

        /// <summary>
        /// Минимальный срок, на которой применяется уровень процентной ставки
        /// </summary>
        /// <value>Минимальный срок, на которой применяется уровень процентной ставки</value>
        [DataMember(Name="tierValueMinTerm", EmitDefaultValue=false)]
        public int? TierValueMinTerm { get; set; }

        /// <summary>
        /// Gets or Sets MinTermPeriod
        /// </summary>
        [DataMember(Name="minTermPeriod", EmitDefaultValue=false)]
        public PeriodUnit MinTermPeriod { get; set; }

        /// <summary>
        /// Максимальный срок, для которой применяется уровень процентной ставки
        /// </summary>
        /// <value>Максимальный срок, для которой применяется уровень процентной ставки</value>
        [DataMember(Name="tierValueMaxTerm", EmitDefaultValue=false)]
        public int? TierValueMaxTerm { get; set; }

        /// <summary>
        /// Gets or Sets MaxTermPeriod
        /// </summary>
        [DataMember(Name="maxTermPeriod", EmitDefaultValue=false)]
        public PeriodUnit MaxTermPeriod { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationFrequency
        /// </summary>
        [DataMember(Name="applicationFrequency", EmitDefaultValue=false)]
        public FrequencyType ApplicationFrequency { get; set; }

        /// <summary>
        /// Gets or Sets OtherApplicationFrequency
        /// </summary>
        [DataMember(Name="OtherApplicationFrequency", EmitDefaultValue=false)]
        public OtherTypeCode OtherApplicationFrequency { get; set; }

        /// <summary>
        /// Gets or Sets CalculationFrequency
        /// </summary>
        [DataMember(Name="calculationFrequency", EmitDefaultValue=false)]
        public FrequencyType CalculationFrequency { get; set; }

        /// <summary>
        /// Gets or Sets OtherCalculationFrequency
        /// </summary>
        [DataMember(Name="OtherCalculationFrequency", EmitDefaultValue=false)]
        public OtherTypeCode OtherCalculationFrequency { get; set; }

        /// <summary>
        /// Информация о комиссиях и сборах
        /// </summary>
        /// <value>Информация о комиссиях и сборах</value>
        [DataMember(Name="InterestFeesCharges", EmitDefaultValue=false)]
        public List<InterestFeesCharges> InterestFeesCharges { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TierBand {\n");
            sb.Append("  AER: ").Append(AER).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
            sb.Append("  TierCurrency: ").Append(TierCurrency).Append("\n");
            sb.Append("  InterestRate: ").Append(InterestRate).Append("\n");
            sb.Append("  TierValueMinimum: ").Append(TierValueMinimum).Append("\n");
            sb.Append("  TierValueMaximum: ").Append(TierValueMaximum).Append("\n");
            sb.Append("  TierPrimaryValueMinimum: ").Append(TierPrimaryValueMinimum).Append("\n");
            sb.Append("  TierPrimaryValueMaximum: ").Append(TierPrimaryValueMaximum).Append("\n");
            sb.Append("  TierRemainValueMinimum: ").Append(TierRemainValueMinimum).Append("\n");
            sb.Append("  TierValueMinTerm: ").Append(TierValueMinTerm).Append("\n");
            sb.Append("  MinTermPeriod: ").Append(MinTermPeriod).Append("\n");
            sb.Append("  TierValueMaxTerm: ").Append(TierValueMaxTerm).Append("\n");
            sb.Append("  MaxTermPeriod: ").Append(MaxTermPeriod).Append("\n");
            sb.Append("  ApplicationFrequency: ").Append(ApplicationFrequency).Append("\n");
            sb.Append("  OtherApplicationFrequency: ").Append(OtherApplicationFrequency).Append("\n");
            sb.Append("  CalculationFrequency: ").Append(CalculationFrequency).Append("\n");
            sb.Append("  OtherCalculationFrequency: ").Append(OtherCalculationFrequency).Append("\n");
            sb.Append("  InterestFeesCharges: ").Append(InterestFeesCharges).Append("\n");
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
            return this.Equals(input as TierBand);
        }

        /// <summary>
        /// Returns true if TierBand instances are equal
        /// </summary>
        /// <param name="input">Instance of TierBand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TierBand input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AER == input.AER ||
                    (this.AER != null &&
                    this.AER.Equals(input.AER))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
                ) && 
                (
                    this.Identification == input.Identification ||
                    (this.Identification != null &&
                    this.Identification.Equals(input.Identification))
                ) && 
                (
                    this.TierCurrency == input.TierCurrency ||
                    (this.TierCurrency != null &&
                    this.TierCurrency.Equals(input.TierCurrency))
                ) && 
                (
                    this.InterestRate == input.InterestRate ||
                    (this.InterestRate != null &&
                    this.InterestRate.Equals(input.InterestRate))
                ) && 
                (
                    this.TierValueMinimum == input.TierValueMinimum ||
                    (this.TierValueMinimum != null &&
                    this.TierValueMinimum.Equals(input.TierValueMinimum))
                ) && 
                (
                    this.TierValueMaximum == input.TierValueMaximum ||
                    (this.TierValueMaximum != null &&
                    this.TierValueMaximum.Equals(input.TierValueMaximum))
                ) && 
                (
                    this.TierPrimaryValueMinimum == input.TierPrimaryValueMinimum ||
                    (this.TierPrimaryValueMinimum != null &&
                    this.TierPrimaryValueMinimum.Equals(input.TierPrimaryValueMinimum))
                ) && 
                (
                    this.TierPrimaryValueMaximum == input.TierPrimaryValueMaximum ||
                    (this.TierPrimaryValueMaximum != null &&
                    this.TierPrimaryValueMaximum.Equals(input.TierPrimaryValueMaximum))
                ) && 
                (
                    this.TierRemainValueMinimum == input.TierRemainValueMinimum ||
                    (this.TierRemainValueMinimum != null &&
                    this.TierRemainValueMinimum.Equals(input.TierRemainValueMinimum))
                ) && 
                (
                    this.TierValueMinTerm == input.TierValueMinTerm ||
                    (this.TierValueMinTerm != null &&
                    this.TierValueMinTerm.Equals(input.TierValueMinTerm))
                ) && 
                (
                    this.MinTermPeriod == input.MinTermPeriod ||
                    (this.MinTermPeriod != null &&
                    this.MinTermPeriod.Equals(input.MinTermPeriod))
                ) && 
                (
                    this.TierValueMaxTerm == input.TierValueMaxTerm ||
                    (this.TierValueMaxTerm != null &&
                    this.TierValueMaxTerm.Equals(input.TierValueMaxTerm))
                ) && 
                (
                    this.MaxTermPeriod == input.MaxTermPeriod ||
                    (this.MaxTermPeriod != null &&
                    this.MaxTermPeriod.Equals(input.MaxTermPeriod))
                ) && 
                (
                    this.ApplicationFrequency == input.ApplicationFrequency ||
                    (this.ApplicationFrequency != null &&
                    this.ApplicationFrequency.Equals(input.ApplicationFrequency))
                ) && 
                (
                    this.OtherApplicationFrequency == input.OtherApplicationFrequency ||
                    (this.OtherApplicationFrequency != null &&
                    this.OtherApplicationFrequency.Equals(input.OtherApplicationFrequency))
                ) && 
                (
                    this.CalculationFrequency == input.CalculationFrequency ||
                    (this.CalculationFrequency != null &&
                    this.CalculationFrequency.Equals(input.CalculationFrequency))
                ) && 
                (
                    this.OtherCalculationFrequency == input.OtherCalculationFrequency ||
                    (this.OtherCalculationFrequency != null &&
                    this.OtherCalculationFrequency.Equals(input.OtherCalculationFrequency))
                ) && 
                (
                    this.InterestFeesCharges == input.InterestFeesCharges ||
                    this.InterestFeesCharges != null &&
                    input.InterestFeesCharges != null &&
                    this.InterestFeesCharges.SequenceEqual(input.InterestFeesCharges)
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
                if (this.AER != null)
                    hashCode = hashCode * 59 + this.AER.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
                if (this.Identification != null)
                    hashCode = hashCode * 59 + this.Identification.GetHashCode();
                if (this.TierCurrency != null)
                    hashCode = hashCode * 59 + this.TierCurrency.GetHashCode();
                if (this.InterestRate != null)
                    hashCode = hashCode * 59 + this.InterestRate.GetHashCode();
                if (this.TierValueMinimum != null)
                    hashCode = hashCode * 59 + this.TierValueMinimum.GetHashCode();
                if (this.TierValueMaximum != null)
                    hashCode = hashCode * 59 + this.TierValueMaximum.GetHashCode();
                if (this.TierPrimaryValueMinimum != null)
                    hashCode = hashCode * 59 + this.TierPrimaryValueMinimum.GetHashCode();
                if (this.TierPrimaryValueMaximum != null)
                    hashCode = hashCode * 59 + this.TierPrimaryValueMaximum.GetHashCode();
                if (this.TierRemainValueMinimum != null)
                    hashCode = hashCode * 59 + this.TierRemainValueMinimum.GetHashCode();
                if (this.TierValueMinTerm != null)
                    hashCode = hashCode * 59 + this.TierValueMinTerm.GetHashCode();
                if (this.MinTermPeriod != null)
                    hashCode = hashCode * 59 + this.MinTermPeriod.GetHashCode();
                if (this.TierValueMaxTerm != null)
                    hashCode = hashCode * 59 + this.TierValueMaxTerm.GetHashCode();
                if (this.MaxTermPeriod != null)
                    hashCode = hashCode * 59 + this.MaxTermPeriod.GetHashCode();
                if (this.ApplicationFrequency != null)
                    hashCode = hashCode * 59 + this.ApplicationFrequency.GetHashCode();
                if (this.OtherApplicationFrequency != null)
                    hashCode = hashCode * 59 + this.OtherApplicationFrequency.GetHashCode();
                if (this.CalculationFrequency != null)
                    hashCode = hashCode * 59 + this.CalculationFrequency.GetHashCode();
                if (this.OtherCalculationFrequency != null)
                    hashCode = hashCode * 59 + this.OtherCalculationFrequency.GetHashCode();
                if (this.InterestFeesCharges != null)
                    hashCode = hashCode * 59 + this.InterestFeesCharges.GetHashCode();
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

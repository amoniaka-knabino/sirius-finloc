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
    /// Детальное описание информации о продукте
    /// </summary>
    [DataContract]
        public partial class ProductDetails :  IEquatable<ProductDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductDetails" /> class.
        /// </summary>
        /// <param name="active">Признак активности продукта.</param>
        /// <param name="activeFrom">activeFrom.</param>
        /// <param name="activeTo">activeTo.</param>
        /// <param name="feeFreeLength">Продолжительность бесплатного или рекламного периода.</param>
        /// <param name="feeFreeLengthPeriod">feeFreeLengthPeriod.</param>
        /// <param name="productInsurance">Обязательность страхования продукта или залогового имущества.</param>
        /// <param name="deliveryRegions">Информация о доступности продукта и возможности доставки.</param>
        /// <param name="featureAndBenefit">featureAndBenefit.</param>
        /// <param name="eligibility">Ограничения на продукт в целом.</param>
        /// <param name="insurances">insurances.</param>
        /// <param name="comments">comments.</param>
        public ProductDetails(bool? active = default(bool?), DateTime? activeFrom = default(DateTime?), DateTime? activeTo = default(DateTime?), int? feeFreeLength = default(int?), PeriodUnit feeFreeLengthPeriod = default(PeriodUnit), bool? productInsurance = default(bool?), List<DeliveryRegions> deliveryRegions = default(List<DeliveryRegions>), FeatureAndBenefit featureAndBenefit = default(FeatureAndBenefit), List<Eligibility> eligibility = default(List<Eligibility>), Insurances insurances = default(Insurances), Comments comments = default(Comments))
        {
            this.Active = active;
            this.ActiveFrom = activeFrom;
            this.ActiveTo = activeTo;
            this.FeeFreeLength = feeFreeLength;
            this.FeeFreeLengthPeriod = feeFreeLengthPeriod;
            this.ProductInsurance = productInsurance;
            this.DeliveryRegions = deliveryRegions;
            this.FeatureAndBenefit = featureAndBenefit;
            this.Eligibility = eligibility;
            this.Insurances = insurances;
            this.Comments = comments;
        }
        
        /// <summary>
        /// Признак активности продукта
        /// </summary>
        /// <value>Признак активности продукта</value>
        [DataMember(Name="active", EmitDefaultValue=false)]
        public bool? Active { get; set; }

        /// <summary>
        /// Gets or Sets ActiveFrom
        /// </summary>
        [DataMember(Name="activeFrom", EmitDefaultValue=false)]
        public DateTime? ActiveFrom { get; set; }

        /// <summary>
        /// Gets or Sets ActiveTo
        /// </summary>
        [DataMember(Name="activeTo", EmitDefaultValue=false)]
        public DateTime? ActiveTo { get; set; }

        /// <summary>
        /// Продолжительность бесплатного или рекламного периода
        /// </summary>
        /// <value>Продолжительность бесплатного или рекламного периода</value>
        [DataMember(Name="feeFreeLength", EmitDefaultValue=false)]
        public int? FeeFreeLength { get; set; }

        /// <summary>
        /// Gets or Sets FeeFreeLengthPeriod
        /// </summary>
        [DataMember(Name="feeFreeLengthPeriod", EmitDefaultValue=false)]
        public PeriodUnit FeeFreeLengthPeriod { get; set; }

        /// <summary>
        /// Обязательность страхования продукта или залогового имущества
        /// </summary>
        /// <value>Обязательность страхования продукта или залогового имущества</value>
        [DataMember(Name="productInsurance", EmitDefaultValue=false)]
        public bool? ProductInsurance { get; set; }

        /// <summary>
        /// Информация о доступности продукта и возможности доставки
        /// </summary>
        /// <value>Информация о доступности продукта и возможности доставки</value>
        [DataMember(Name="DeliveryRegions", EmitDefaultValue=false)]
        public List<DeliveryRegions> DeliveryRegions { get; set; }

        /// <summary>
        /// Gets or Sets FeatureAndBenefit
        /// </summary>
        [DataMember(Name="FeatureAndBenefit", EmitDefaultValue=false)]
        public FeatureAndBenefit FeatureAndBenefit { get; set; }

        /// <summary>
        /// Ограничения на продукт в целом
        /// </summary>
        /// <value>Ограничения на продукт в целом</value>
        [DataMember(Name="Eligibility", EmitDefaultValue=false)]
        public List<Eligibility> Eligibility { get; set; }

        /// <summary>
        /// Gets or Sets Insurances
        /// </summary>
        [DataMember(Name="Insurances", EmitDefaultValue=false)]
        public Insurances Insurances { get; set; }

        /// <summary>
        /// Gets or Sets Comments
        /// </summary>
        [DataMember(Name="comments", EmitDefaultValue=false)]
        public Comments Comments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductDetails {\n");
            sb.Append("  Active: ").Append(Active).Append("\n");
            sb.Append("  ActiveFrom: ").Append(ActiveFrom).Append("\n");
            sb.Append("  ActiveTo: ").Append(ActiveTo).Append("\n");
            sb.Append("  FeeFreeLength: ").Append(FeeFreeLength).Append("\n");
            sb.Append("  FeeFreeLengthPeriod: ").Append(FeeFreeLengthPeriod).Append("\n");
            sb.Append("  ProductInsurance: ").Append(ProductInsurance).Append("\n");
            sb.Append("  DeliveryRegions: ").Append(DeliveryRegions).Append("\n");
            sb.Append("  FeatureAndBenefit: ").Append(FeatureAndBenefit).Append("\n");
            sb.Append("  Eligibility: ").Append(Eligibility).Append("\n");
            sb.Append("  Insurances: ").Append(Insurances).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
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
            return this.Equals(input as ProductDetails);
        }

        /// <summary>
        /// Returns true if ProductDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductDetails input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Active == input.Active ||
                    (this.Active != null &&
                    this.Active.Equals(input.Active))
                ) && 
                (
                    this.ActiveFrom == input.ActiveFrom ||
                    (this.ActiveFrom != null &&
                    this.ActiveFrom.Equals(input.ActiveFrom))
                ) && 
                (
                    this.ActiveTo == input.ActiveTo ||
                    (this.ActiveTo != null &&
                    this.ActiveTo.Equals(input.ActiveTo))
                ) && 
                (
                    this.FeeFreeLength == input.FeeFreeLength ||
                    (this.FeeFreeLength != null &&
                    this.FeeFreeLength.Equals(input.FeeFreeLength))
                ) && 
                (
                    this.FeeFreeLengthPeriod == input.FeeFreeLengthPeriod ||
                    (this.FeeFreeLengthPeriod != null &&
                    this.FeeFreeLengthPeriod.Equals(input.FeeFreeLengthPeriod))
                ) && 
                (
                    this.ProductInsurance == input.ProductInsurance ||
                    (this.ProductInsurance != null &&
                    this.ProductInsurance.Equals(input.ProductInsurance))
                ) && 
                (
                    this.DeliveryRegions == input.DeliveryRegions ||
                    this.DeliveryRegions != null &&
                    input.DeliveryRegions != null &&
                    this.DeliveryRegions.SequenceEqual(input.DeliveryRegions)
                ) && 
                (
                    this.FeatureAndBenefit == input.FeatureAndBenefit ||
                    (this.FeatureAndBenefit != null &&
                    this.FeatureAndBenefit.Equals(input.FeatureAndBenefit))
                ) && 
                (
                    this.Eligibility == input.Eligibility ||
                    this.Eligibility != null &&
                    input.Eligibility != null &&
                    this.Eligibility.SequenceEqual(input.Eligibility)
                ) && 
                (
                    this.Insurances == input.Insurances ||
                    (this.Insurances != null &&
                    this.Insurances.Equals(input.Insurances))
                ) && 
                (
                    this.Comments == input.Comments ||
                    (this.Comments != null &&
                    this.Comments.Equals(input.Comments))
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
                if (this.Active != null)
                    hashCode = hashCode * 59 + this.Active.GetHashCode();
                if (this.ActiveFrom != null)
                    hashCode = hashCode * 59 + this.ActiveFrom.GetHashCode();
                if (this.ActiveTo != null)
                    hashCode = hashCode * 59 + this.ActiveTo.GetHashCode();
                if (this.FeeFreeLength != null)
                    hashCode = hashCode * 59 + this.FeeFreeLength.GetHashCode();
                if (this.FeeFreeLengthPeriod != null)
                    hashCode = hashCode * 59 + this.FeeFreeLengthPeriod.GetHashCode();
                if (this.ProductInsurance != null)
                    hashCode = hashCode * 59 + this.ProductInsurance.GetHashCode();
                if (this.DeliveryRegions != null)
                    hashCode = hashCode * 59 + this.DeliveryRegions.GetHashCode();
                if (this.FeatureAndBenefit != null)
                    hashCode = hashCode * 59 + this.FeatureAndBenefit.GetHashCode();
                if (this.Eligibility != null)
                    hashCode = hashCode * 59 + this.Eligibility.GetHashCode();
                if (this.Insurances != null)
                    hashCode = hashCode * 59 + this.Insurances.GetHashCode();
                if (this.Comments != null)
                    hashCode = hashCode * 59 + this.Comments.GetHashCode();
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

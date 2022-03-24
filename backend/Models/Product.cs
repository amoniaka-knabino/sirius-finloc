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
    /// Общая информация о продукте кредитной организации, его характеристиках, зависимостях от уровней процентных ставок, условиях приобретения. Объект детально определяет, какие могут быть начисления, списания, комиссии и сборы, а также применяемые при этом ограничения для каждого уровня процентных ставок.
    /// </summary>
    [DataContract]
        public partial class Product :  IEquatable<Product>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Product" /> class.
        /// </summary>
        /// <param name="productId">Уникальный идентификатор, присвоенный финансовым учреждением внутри компании каждому из банковских  продуктов (required).</param>
        /// <param name="productName">Название продукта, используемого в маркетинговых целях (required).</param>
        /// <param name="productType">productType (required).</param>
        /// <param name="productVersion">Версия продукта.</param>
        /// <param name="brand">brand.</param>
        /// <param name="productDetails">productDetails (required).</param>
        /// <param name="debitInterest">debitInterest.</param>
        /// <param name="creditInterest">creditInterest.</param>
        /// <param name="overdraft">overdraft.</param>
        /// <param name="repayment">repayment.</param>
        /// <param name="otherFeesCharges">Информация о комиссиях и сборах, в том числе по тарифу обслуживания.</param>
        /// <param name="supplementaryData">supplementaryData.</param>
        public Product(string productId = default(string), string productName = default(string), ProductType productType = default(ProductType), string productVersion = default(string), Brand brand = default(Brand), ProductDetails productDetails = default(ProductDetails), DebitInterest debitInterest = default(DebitInterest), CreditInterest creditInterest = default(CreditInterest), Overdraft overdraft = default(Overdraft), Repayment repayment = default(Repayment), List<OtherFeesCharges> otherFeesCharges = default(List<OtherFeesCharges>), SupplementaryData supplementaryData = default(SupplementaryData))
        {
            // to ensure "productId" is required (not null)
            if (productId == null)
            {
                throw new InvalidDataException("productId is a required property for Product and cannot be null");
            }
            else
            {
                this.ProductId = productId;
            }
            // to ensure "productName" is required (not null)
            if (productName == null)
            {
                throw new InvalidDataException("productName is a required property for Product and cannot be null");
            }
            else
            {
                this.ProductName = productName;
            }
            // to ensure "productType" is required (not null)
            if (productType == null)
            {
                throw new InvalidDataException("productType is a required property for Product and cannot be null");
            }
            else
            {
                this.ProductType = productType;
            }
            // to ensure "productDetails" is required (not null)
            if (productDetails == null)
            {
                throw new InvalidDataException("productDetails is a required property for Product and cannot be null");
            }
            else
            {
                this.ProductDetails = productDetails;
            }
            this.ProductVersion = productVersion;
            this.Brand = brand;
            this.DebitInterest = debitInterest;
            this.CreditInterest = creditInterest;
            this.Overdraft = overdraft;
            this.Repayment = repayment;
            this.OtherFeesCharges = otherFeesCharges;
            this.SupplementaryData = supplementaryData;
        }
        
        /// <summary>
        /// Уникальный идентификатор, присвоенный финансовым учреждением внутри компании каждому из банковских  продуктов
        /// </summary>
        /// <value>Уникальный идентификатор, присвоенный финансовым учреждением внутри компании каждому из банковских  продуктов</value>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// Название продукта, используемого в маркетинговых целях
        /// </summary>
        /// <value>Название продукта, используемого в маркетинговых целях</value>
        [DataMember(Name="productName", EmitDefaultValue=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or Sets ProductType
        /// </summary>
        [DataMember(Name="productType", EmitDefaultValue=false)]
        public ProductType ProductType { get; set; }

        /// <summary>
        /// Версия продукта
        /// </summary>
        /// <value>Версия продукта</value>
        [DataMember(Name="productVersion", EmitDefaultValue=false)]
        public string ProductVersion { get; set; }

        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name="Brand", EmitDefaultValue=false)]
        public Brand Brand { get; set; }

        /// <summary>
        /// Gets or Sets ProductDetails
        /// </summary>
        [DataMember(Name="ProductDetails", EmitDefaultValue=false)]
        public ProductDetails ProductDetails { get; set; }

        /// <summary>
        /// Gets or Sets DebitInterest
        /// </summary>
        [DataMember(Name="DebitInterest", EmitDefaultValue=false)]
        public DebitInterest DebitInterest { get; set; }

        /// <summary>
        /// Gets or Sets CreditInterest
        /// </summary>
        [DataMember(Name="CreditInterest", EmitDefaultValue=false)]
        public CreditInterest CreditInterest { get; set; }

        /// <summary>
        /// Gets or Sets Overdraft
        /// </summary>
        [DataMember(Name="Overdraft", EmitDefaultValue=false)]
        public Overdraft Overdraft { get; set; }

        /// <summary>
        /// Gets or Sets Repayment
        /// </summary>
        [DataMember(Name="Repayment", EmitDefaultValue=false)]
        public Repayment Repayment { get; set; }

        /// <summary>
        /// Информация о комиссиях и сборах, в том числе по тарифу обслуживания
        /// </summary>
        /// <value>Информация о комиссиях и сборах, в том числе по тарифу обслуживания</value>
        [DataMember(Name="OtherFeesCharges", EmitDefaultValue=false)]
        public List<OtherFeesCharges> OtherFeesCharges { get; set; }

        /// <summary>
        /// Gets or Sets SupplementaryData
        /// </summary>
        [DataMember(Name="SupplementaryData", EmitDefaultValue=false)]
        public SupplementaryData SupplementaryData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Product {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  ProductVersion: ").Append(ProductVersion).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
            sb.Append("  ProductDetails: ").Append(ProductDetails).Append("\n");
            sb.Append("  DebitInterest: ").Append(DebitInterest).Append("\n");
            sb.Append("  CreditInterest: ").Append(CreditInterest).Append("\n");
            sb.Append("  Overdraft: ").Append(Overdraft).Append("\n");
            sb.Append("  Repayment: ").Append(Repayment).Append("\n");
            sb.Append("  OtherFeesCharges: ").Append(OtherFeesCharges).Append("\n");
            sb.Append("  SupplementaryData: ").Append(SupplementaryData).Append("\n");
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
            return this.Equals(input as Product);
        }

        /// <summary>
        /// Returns true if Product instances are equal
        /// </summary>
        /// <param name="input">Instance of Product to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Product input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.ProductName == input.ProductName ||
                    (this.ProductName != null &&
                    this.ProductName.Equals(input.ProductName))
                ) && 
                (
                    this.ProductType == input.ProductType ||
                    (this.ProductType != null &&
                    this.ProductType.Equals(input.ProductType))
                ) && 
                (
                    this.ProductVersion == input.ProductVersion ||
                    (this.ProductVersion != null &&
                    this.ProductVersion.Equals(input.ProductVersion))
                ) && 
                (
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
                ) && 
                (
                    this.ProductDetails == input.ProductDetails ||
                    (this.ProductDetails != null &&
                    this.ProductDetails.Equals(input.ProductDetails))
                ) && 
                (
                    this.DebitInterest == input.DebitInterest ||
                    (this.DebitInterest != null &&
                    this.DebitInterest.Equals(input.DebitInterest))
                ) && 
                (
                    this.CreditInterest == input.CreditInterest ||
                    (this.CreditInterest != null &&
                    this.CreditInterest.Equals(input.CreditInterest))
                ) && 
                (
                    this.Overdraft == input.Overdraft ||
                    (this.Overdraft != null &&
                    this.Overdraft.Equals(input.Overdraft))
                ) && 
                (
                    this.Repayment == input.Repayment ||
                    (this.Repayment != null &&
                    this.Repayment.Equals(input.Repayment))
                ) && 
                (
                    this.OtherFeesCharges == input.OtherFeesCharges ||
                    this.OtherFeesCharges != null &&
                    input.OtherFeesCharges != null &&
                    this.OtherFeesCharges.SequenceEqual(input.OtherFeesCharges)
                ) && 
                (
                    this.SupplementaryData == input.SupplementaryData ||
                    (this.SupplementaryData != null &&
                    this.SupplementaryData.Equals(input.SupplementaryData))
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
                if (this.ProductId != null)
                    hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ProductName != null)
                    hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.ProductType != null)
                    hashCode = hashCode * 59 + this.ProductType.GetHashCode();
                if (this.ProductVersion != null)
                    hashCode = hashCode * 59 + this.ProductVersion.GetHashCode();
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
                if (this.ProductDetails != null)
                    hashCode = hashCode * 59 + this.ProductDetails.GetHashCode();
                if (this.DebitInterest != null)
                    hashCode = hashCode * 59 + this.DebitInterest.GetHashCode();
                if (this.CreditInterest != null)
                    hashCode = hashCode * 59 + this.CreditInterest.GetHashCode();
                if (this.Overdraft != null)
                    hashCode = hashCode * 59 + this.Overdraft.GetHashCode();
                if (this.Repayment != null)
                    hashCode = hashCode * 59 + this.Repayment.GetHashCode();
                if (this.OtherFeesCharges != null)
                    hashCode = hashCode * 59 + this.OtherFeesCharges.GetHashCode();
                if (this.SupplementaryData != null)
                    hashCode = hashCode * 59 + this.SupplementaryData.GetHashCode();
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
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
    /// Сведения о продукте
    /// </summary>
    [DataContract]
        public partial class ProductList :  IEquatable<ProductList>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductList" /> class.
        /// </summary>
        /// <param name="productId">Уникальный идентификатор, присвоенный финансовым  учреждением внутри компании каждому из банковских  продуктов (required).</param>
        /// <param name="productName">Название продукта, используемого в маркетинговых  целях (с точки зрения клиента) (required).</param>
        /// <param name="productType">productType (required).</param>
        /// <param name="brand">brand.</param>
        public ProductList(string productId = default(string), string productName = default(string), ProductType productType = default(ProductType), Brand brand = default(Brand))
        {
            // to ensure "productId" is required (not null)
            if (productId == null)
            {
                throw new InvalidDataException("productId is a required property for ProductList and cannot be null");
            }
            else
            {
                this.ProductId = productId;
            }
            // to ensure "productName" is required (not null)
            if (productName == null)
            {
                throw new InvalidDataException("productName is a required property for ProductList and cannot be null");
            }
            else
            {
                this.ProductName = productName;
            }
            // to ensure "productType" is required (not null)
            if (productType == null)
            {
                throw new InvalidDataException("productType is a required property for ProductList and cannot be null");
            }
            else
            {
                this.ProductType = productType;
            }
            this.Brand = brand;
        }
        
        /// <summary>
        /// Уникальный идентификатор, присвоенный финансовым  учреждением внутри компании каждому из банковских  продуктов
        /// </summary>
        /// <value>Уникальный идентификатор, присвоенный финансовым  учреждением внутри компании каждому из банковских  продуктов</value>
        [DataMember(Name="productId", EmitDefaultValue=false)]
        public string ProductId { get; set; }

        /// <summary>
        /// Название продукта, используемого в маркетинговых  целях (с точки зрения клиента)
        /// </summary>
        /// <value>Название продукта, используемого в маркетинговых  целях (с точки зрения клиента)</value>
        [DataMember(Name="productName", EmitDefaultValue=false)]
        public string ProductName { get; set; }

        /// <summary>
        /// Gets or Sets ProductType
        /// </summary>
        [DataMember(Name="productType", EmitDefaultValue=false)]
        public ProductType ProductType { get; set; }

        /// <summary>
        /// Gets or Sets Brand
        /// </summary>
        [DataMember(Name="Brand", EmitDefaultValue=false)]
        public Brand Brand { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductList {\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  ProductType: ").Append(ProductType).Append("\n");
            sb.Append("  Brand: ").Append(Brand).Append("\n");
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
            return this.Equals(input as ProductList);
        }

        /// <summary>
        /// Returns true if ProductList instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductList to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductList input)
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
                    this.Brand == input.Brand ||
                    (this.Brand != null &&
                    this.Brand.Equals(input.Brand))
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
                if (this.Brand != null)
                    hashCode = hashCode * 59 + this.Brand.GetHashCode();
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

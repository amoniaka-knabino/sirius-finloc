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
    /// Раздел данных для информации о банковском продукте
    /// </summary>
    [DataContract]
        public partial class ProductListResponseData :  IEquatable<ProductListResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductListResponseData" /> class.
        /// </summary>
        /// <param name="products">Информация о продуктах, которые доступны для предложений.</param>
        public ProductListResponseData(List<ProductList> products = default(List<ProductList>))
        {
            this.Products = products;
        }
        
        /// <summary>
        /// Информация о продуктах, которые доступны для предложений
        /// </summary>
        /// <value>Информация о продуктах, которые доступны для предложений</value>
        [DataMember(Name="Products", EmitDefaultValue=false)]
        public List<ProductList> Products { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductListResponseData {\n");
            sb.Append("  Products: ").Append(Products).Append("\n");
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
            return this.Equals(input as ProductListResponseData);
        }

        /// <summary>
        /// Returns true if ProductListResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductListResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductListResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Products == input.Products ||
                    this.Products != null &&
                    input.Products != null &&
                    this.Products.SequenceEqual(input.Products)
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
                if (this.Products != null)
                    hashCode = hashCode * 59 + this.Products.GetHashCode();
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
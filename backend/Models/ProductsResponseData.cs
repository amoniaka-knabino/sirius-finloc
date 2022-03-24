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
        public partial class ProductsResponseData :  IEquatable<ProductsResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProductsResponseData" /> class.
        /// </summary>
        /// <param name="product">product.</param>
        public ProductsResponseData(Product product = default(Product))
        {
            this.Product = product;
        }
        
        /// <summary>
        /// Gets or Sets Product
        /// </summary>
        [DataMember(Name="Product", EmitDefaultValue=false)]
        public Product Product { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProductsResponseData {\n");
            sb.Append("  Product: ").Append(Product).Append("\n");
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
            return this.Equals(input as ProductsResponseData);
        }

        /// <summary>
        /// Returns true if ProductsResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of ProductsResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProductsResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Product == input.Product ||
                    (this.Product != null &&
                    this.Product.Equals(input.Product))
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
                if (this.Product != null)
                    hashCode = hashCode * 59 + this.Product.GetHashCode();
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

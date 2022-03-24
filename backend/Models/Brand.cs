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
    /// Торговая марка продукта
    /// </summary>
    [DataContract]
        public partial class Brand :  IEquatable<Brand>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Brand" /> class.
        /// </summary>
        /// <param name="brandName">Наименование собственного брэнда продукта или брэнд организации, который используется для продвижения продукта (required).</param>
        /// <param name="applicationUri">URL-адрес для получения информации об условиях приобретения продукта (required).</param>
        public Brand(string brandName = default(string), string applicationUri = default(string))
        {
            // to ensure "brandName" is required (not null)
            if (brandName == null)
            {
                throw new InvalidDataException("brandName is a required property for Brand and cannot be null");
            }
            else
            {
                this.BrandName = brandName;
            }
            // to ensure "applicationUri" is required (not null)
            if (applicationUri == null)
            {
                throw new InvalidDataException("applicationUri is a required property for Brand and cannot be null");
            }
            else
            {
                this.ApplicationUri = applicationUri;
            }
        }
        
        /// <summary>
        /// Наименование собственного брэнда продукта или брэнд организации, который используется для продвижения продукта
        /// </summary>
        /// <value>Наименование собственного брэнда продукта или брэнд организации, который используется для продвижения продукта</value>
        [DataMember(Name="brandName", EmitDefaultValue=false)]
        public string BrandName { get; set; }

        /// <summary>
        /// URL-адрес для получения информации об условиях приобретения продукта
        /// </summary>
        /// <value>URL-адрес для получения информации об условиях приобретения продукта</value>
        [DataMember(Name="applicationUri", EmitDefaultValue=false)]
        public string ApplicationUri { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Brand {\n");
            sb.Append("  BrandName: ").Append(BrandName).Append("\n");
            sb.Append("  ApplicationUri: ").Append(ApplicationUri).Append("\n");
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
            return this.Equals(input as Brand);
        }

        /// <summary>
        /// Returns true if Brand instances are equal
        /// </summary>
        /// <param name="input">Instance of Brand to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Brand input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.BrandName == input.BrandName ||
                    (this.BrandName != null &&
                    this.BrandName.Equals(input.BrandName))
                ) && 
                (
                    this.ApplicationUri == input.ApplicationUri ||
                    (this.ApplicationUri != null &&
                    this.ApplicationUri.Equals(input.ApplicationUri))
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
                if (this.BrandName != null)
                    hashCode = hashCode * 59 + this.BrandName.GetHashCode();
                if (this.ApplicationUri != null)
                    hashCode = hashCode * 59 + this.ApplicationUri.GetHashCode();
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
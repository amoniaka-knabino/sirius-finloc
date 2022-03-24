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
    /// Информация о населенном пункте, где продукт доступен либо куда возможна доставка
    /// </summary>
    [DataContract]
        public partial class PostalAddressAndAdmZone :  IEquatable<PostalAddressAndAdmZone>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostalAddressAndAdmZone" /> class.
        /// </summary>
        /// <param name="administrationZone">Код по Общероссийскому классификатору территорий муниципальных образований ОКТМО.</param>
        /// <param name="postalAddress">postalAddress.</param>
        public PostalAddressAndAdmZone(string administrationZone = default(string), PostalAddress postalAddress = default(PostalAddress))
        {
            this.AdministrationZone = administrationZone;
            this.PostalAddress = postalAddress;
        }
        
        /// <summary>
        /// Код по Общероссийскому классификатору территорий муниципальных образований ОКТМО
        /// </summary>
        /// <value>Код по Общероссийскому классификатору территорий муниципальных образований ОКТМО</value>
        [DataMember(Name="administrationZone", EmitDefaultValue=false)]
        public string AdministrationZone { get; set; }

        /// <summary>
        /// Gets or Sets PostalAddress
        /// </summary>
        [DataMember(Name="PostalAddress", EmitDefaultValue=false)]
        public PostalAddress PostalAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostalAddressAndAdmZone {\n");
            sb.Append("  AdministrationZone: ").Append(AdministrationZone).Append("\n");
            sb.Append("  PostalAddress: ").Append(PostalAddress).Append("\n");
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
            return this.Equals(input as PostalAddressAndAdmZone);
        }

        /// <summary>
        /// Returns true if PostalAddressAndAdmZone instances are equal
        /// </summary>
        /// <param name="input">Instance of PostalAddressAndAdmZone to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostalAddressAndAdmZone input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AdministrationZone == input.AdministrationZone ||
                    (this.AdministrationZone != null &&
                    this.AdministrationZone.Equals(input.AdministrationZone))
                ) && 
                (
                    this.PostalAddress == input.PostalAddress ||
                    (this.PostalAddress != null &&
                    this.PostalAddress.Equals(input.PostalAddress))
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
                if (this.AdministrationZone != null)
                    hashCode = hashCode * 59 + this.AdministrationZone.GetHashCode();
                if (this.PostalAddress != null)
                    hashCode = hashCode * 59 + this.PostalAddress.GetHashCode();
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

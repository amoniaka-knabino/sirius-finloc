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
    /// Почтовый адрес
    /// </summary>
    [DataContract]
        public partial class PostalAddress :  IEquatable<PostalAddress>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostalAddress" /> class.
        /// </summary>
        /// <param name="addressType">addressType.</param>
        /// <param name="addressLine">Строка адреса.</param>
        /// <param name="streetName">Наименование улицы или проспекта.</param>
        /// <param name="buildingNumber">Номер, который определяет положение здания на улице.</param>
        /// <param name="postCode">Почтовый индекс.</param>
        /// <param name="townName">Наименование населённого пункта или территории, находящейся вне границ поселений.</param>
        /// <param name="countrySubDivision">Наименование и тип субъекта Российской Федерации.</param>
        /// <param name="country">country.</param>
        public PostalAddress(AddressTypeCode addressType = default(AddressTypeCode), List<string> addressLine = default(List<string>), string streetName = default(string), string buildingNumber = default(string), string postCode = default(string), string townName = default(string), string countrySubDivision = default(string), string country = default(string))
        {
            this.AddressType = addressType;
            this.AddressLine = addressLine;
            this.StreetName = streetName;
            this.BuildingNumber = buildingNumber;
            this.PostCode = postCode;
            this.TownName = townName;
            this.CountrySubDivision = countrySubDivision;
            this.Country = country;
        }
        
        /// <summary>
        /// Gets or Sets AddressType
        /// </summary>
        [DataMember(Name="addressType", EmitDefaultValue=false)]
        public AddressTypeCode AddressType { get; set; }

        /// <summary>
        /// Строка адреса
        /// </summary>
        /// <value>Строка адреса</value>
        [DataMember(Name="addressLine", EmitDefaultValue=false)]
        public List<string> AddressLine { get; set; }

        /// <summary>
        /// Наименование улицы или проспекта
        /// </summary>
        /// <value>Наименование улицы или проспекта</value>
        [DataMember(Name="streetName", EmitDefaultValue=false)]
        public string StreetName { get; set; }

        /// <summary>
        /// Номер, который определяет положение здания на улице
        /// </summary>
        /// <value>Номер, который определяет положение здания на улице</value>
        [DataMember(Name="buildingNumber", EmitDefaultValue=false)]
        public string BuildingNumber { get; set; }

        /// <summary>
        /// Почтовый индекс
        /// </summary>
        /// <value>Почтовый индекс</value>
        [DataMember(Name="postCode", EmitDefaultValue=false)]
        public string PostCode { get; set; }

        /// <summary>
        /// Наименование населённого пункта или территории, находящейся вне границ поселений
        /// </summary>
        /// <value>Наименование населённого пункта или территории, находящейся вне границ поселений</value>
        [DataMember(Name="townName", EmitDefaultValue=false)]
        public string TownName { get; set; }

        /// <summary>
        /// Наименование и тип субъекта Российской Федерации
        /// </summary>
        /// <value>Наименование и тип субъекта Российской Федерации</value>
        [DataMember(Name="countrySubDivision", EmitDefaultValue=false)]
        public string CountrySubDivision { get; set; }

        /// <summary>
        /// Gets or Sets Country
        /// </summary>
        [DataMember(Name="country", EmitDefaultValue=false)]
        public string Country { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostalAddress {\n");
            sb.Append("  AddressType: ").Append(AddressType).Append("\n");
            sb.Append("  AddressLine: ").Append(AddressLine).Append("\n");
            sb.Append("  StreetName: ").Append(StreetName).Append("\n");
            sb.Append("  BuildingNumber: ").Append(BuildingNumber).Append("\n");
            sb.Append("  PostCode: ").Append(PostCode).Append("\n");
            sb.Append("  TownName: ").Append(TownName).Append("\n");
            sb.Append("  CountrySubDivision: ").Append(CountrySubDivision).Append("\n");
            sb.Append("  Country: ").Append(Country).Append("\n");
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
            return this.Equals(input as PostalAddress);
        }

        /// <summary>
        /// Returns true if PostalAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of PostalAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostalAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddressType == input.AddressType ||
                    (this.AddressType != null &&
                    this.AddressType.Equals(input.AddressType))
                ) && 
                (
                    this.AddressLine == input.AddressLine ||
                    this.AddressLine != null &&
                    input.AddressLine != null &&
                    this.AddressLine.SequenceEqual(input.AddressLine)
                ) && 
                (
                    this.StreetName == input.StreetName ||
                    (this.StreetName != null &&
                    this.StreetName.Equals(input.StreetName))
                ) && 
                (
                    this.BuildingNumber == input.BuildingNumber ||
                    (this.BuildingNumber != null &&
                    this.BuildingNumber.Equals(input.BuildingNumber))
                ) && 
                (
                    this.PostCode == input.PostCode ||
                    (this.PostCode != null &&
                    this.PostCode.Equals(input.PostCode))
                ) && 
                (
                    this.TownName == input.TownName ||
                    (this.TownName != null &&
                    this.TownName.Equals(input.TownName))
                ) && 
                (
                    this.CountrySubDivision == input.CountrySubDivision ||
                    (this.CountrySubDivision != null &&
                    this.CountrySubDivision.Equals(input.CountrySubDivision))
                ) && 
                (
                    this.Country == input.Country ||
                    (this.Country != null &&
                    this.Country.Equals(input.Country))
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
                if (this.AddressType != null)
                    hashCode = hashCode * 59 + this.AddressType.GetHashCode();
                if (this.AddressLine != null)
                    hashCode = hashCode * 59 + this.AddressLine.GetHashCode();
                if (this.StreetName != null)
                    hashCode = hashCode * 59 + this.StreetName.GetHashCode();
                if (this.BuildingNumber != null)
                    hashCode = hashCode * 59 + this.BuildingNumber.GetHashCode();
                if (this.PostCode != null)
                    hashCode = hashCode * 59 + this.PostCode.GetHashCode();
                if (this.TownName != null)
                    hashCode = hashCode * 59 + this.TownName.GetHashCode();
                if (this.CountrySubDivision != null)
                    hashCode = hashCode * 59 + this.CountrySubDivision.GetHashCode();
                if (this.Country != null)
                    hashCode = hashCode * 59 + this.Country.GetHashCode();
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
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
    /// Раздел данных ответа информации об отделениях кредитной организации
    /// </summary>
    [DataContract]
        public partial class DataBranchesResponse :  IEquatable<DataBranchesResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataBranchesResponse" /> class.
        /// </summary>
        /// <param name="branch">Подразделение финансовой организации (required).</param>
        public DataBranchesResponse(List<Branch> branch = default(List<Branch>))
        {
            // to ensure "branch" is required (not null)
            if (branch == null)
            {
                throw new InvalidDataException("branch is a required property for DataBranchesResponse and cannot be null");
            }
            else
            {
                this.Branch = branch;
            }
        }
        
        /// <summary>
        /// Подразделение финансовой организации
        /// </summary>
        /// <value>Подразделение финансовой организации</value>
        [DataMember(Name="Branch", EmitDefaultValue=false)]
        public List<Branch> Branch { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DataBranchesResponse {\n");
            sb.Append("  Branch: ").Append(Branch).Append("\n");
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
            return this.Equals(input as DataBranchesResponse);
        }

        /// <summary>
        /// Returns true if DataBranchesResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DataBranchesResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DataBranchesResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Branch == input.Branch ||
                    this.Branch != null &&
                    input.Branch != null &&
                    this.Branch.SequenceEqual(input.Branch)
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
                if (this.Branch != null)
                    hashCode = hashCode * 59 + this.Branch.GetHashCode();
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
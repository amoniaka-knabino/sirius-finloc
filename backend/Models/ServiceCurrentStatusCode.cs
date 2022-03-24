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
    /// Статус доступности услуги
    /// </summary>
    /// <value>Статус доступности услуги</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum ServiceCurrentStatusCode
    {
        /// <summary>
        /// Enum Active for value: Active | Доступно
        /// </summary>
        [EnumMember(Value = "Active | Доступно")]
        Active = 1,
        /// <summary>
        /// Enum Inactive for value: Inactive  | Недоступно
        /// </summary>
        [EnumMember(Value = "Inactive  | Недоступно")]
        Inactive = 2,
        /// <summary>
        /// Enum Archived for value: Archived | Архив
        /// </summary>
        [EnumMember(Value = "Archived | Архив")]
        Archived = 3    }
}
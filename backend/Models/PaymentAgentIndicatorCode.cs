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
    /// Код признака банковского платежного агента (субагента)
    /// </summary>
    /// <value>Код признака банковского платежного агента (субагента)</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum PaymentAgentIndicatorCode
    {
        /// <summary>
        /// Enum  for value: БПА | банкомат (касса) банковского платежного агента, привлеченного кредитной организацией;
        /// </summary>
        [EnumMember(Value = "БПА | банкомат (касса) банковского платежного агента, привлеченного кредитной организацией;")]
         = 1,
        /// <summary>
        /// Enum  for value: БПС | банкомат (касса) банковского платежного субагента, привлеченного банковским платежным агентом, привлеченным кредитной организацией
        /// </summary>
        [EnumMember(Value = "БПС | банкомат (касса) банковского платежного субагента, привлеченного банковским платежным агентом, привлеченным кредитной организацией")]
         = 2    }
}

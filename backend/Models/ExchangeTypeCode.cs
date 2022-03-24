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
    /// Тип обмена валюты.
    /// </summary>
    /// <value>Тип обмена валюты.</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum ExchangeTypeCode
    {
        /// <summary>
        /// Enum Online for value: Online | Онлайн
        /// </summary>
        [EnumMember(Value = "Online | Онлайн")]
        Online = 1,
        /// <summary>
        /// Enum Cash for value: Cash | Наличные
        /// </summary>
        [EnumMember(Value = "Cash | Наличные")]
        Cash = 2,
        /// <summary>
        /// Enum Device for value: Device | Банкомат
        /// </summary>
        [EnumMember(Value = "Device | Банкомат")]
        Device = 3,
        /// <summary>
        /// Enum Cashless for value: Cashless | Безналичный
        /// </summary>
        [EnumMember(Value = "Cashless | Безналичный")]
        Cashless = 4    }
}
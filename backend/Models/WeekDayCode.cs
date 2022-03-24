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
    /// Дни недели.
    /// </summary>
    /// <value>Дни недели.</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum WeekDayCode
    {
        /// <summary>
        /// Enum _01 for value: 01 | Понедельник
        /// </summary>
        [EnumMember(Value = "01 | Понедельник")]
        _01 = 1,
        /// <summary>
        /// Enum _02 for value: 02 | Вторник
        /// </summary>
        [EnumMember(Value = "02 | Вторник")]
        _02 = 2,
        /// <summary>
        /// Enum _03 for value: 03 | Среда
        /// </summary>
        [EnumMember(Value = "03 | Среда")]
        _03 = 3,
        /// <summary>
        /// Enum _04 for value: 04 | Четверг
        /// </summary>
        [EnumMember(Value = "04 | Четверг")]
        _04 = 4,
        /// <summary>
        /// Enum _05 for value: 05 | Пятница
        /// </summary>
        [EnumMember(Value = "05 | Пятница")]
        _05 = 5,
        /// <summary>
        /// Enum _06 for value: 06 | Суббота
        /// </summary>
        [EnumMember(Value = "06 | Суббота")]
        _06 = 6,
        /// <summary>
        /// Enum _07 for value: 07 | Воскресенье
        /// </summary>
        [EnumMember(Value = "07 | Воскресенье")]
        _07 = 7    }
}

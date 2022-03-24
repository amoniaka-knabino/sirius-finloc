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
    /// Тип адреса
    /// </summary>
    /// <value>Тип адреса</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum AddressTypeCode
    {
        /// <summary>
        /// Enum Business for value: Business | Рабочий адрес
        /// </summary>
        [EnumMember(Value = "Business | Рабочий адрес")]
        Business = 1,
        /// <summary>
        /// Enum Correspondence for value: Correspondence | Адрес для корреспонденции
        /// </summary>
        [EnumMember(Value = "Correspondence | Адрес для корреспонденции")]
        Correspondence = 2,
        /// <summary>
        /// Enum DeliveryTo for value: DeliveryTo | Адрес доставки
        /// </summary>
        [EnumMember(Value = "DeliveryTo | Адрес доставки")]
        DeliveryTo = 3,
        /// <summary>
        /// Enum MailTo for value: MailTo | Почтовый ящик
        /// </summary>
        [EnumMember(Value = "MailTo | Почтовый ящик")]
        MailTo = 4,
        /// <summary>
        /// Enum POBox for value: POBox | Абонентский ящик
        /// </summary>
        [EnumMember(Value = "POBox | Абонентский ящик")]
        POBox = 5,
        /// <summary>
        /// Enum Postal for value: Postal | Почтовый адрес
        /// </summary>
        [EnumMember(Value = "Postal | Почтовый адрес")]
        Postal = 6,
        /// <summary>
        /// Enum Residential for value: Residential | Адрес проживания
        /// </summary>
        [EnumMember(Value = "Residential | Адрес проживания")]
        Residential = 7,
        /// <summary>
        /// Enum Statement for value: Statement | Адрес пребывания
        /// </summary>
        [EnumMember(Value = "Statement | Адрес пребывания")]
        Statement = 8    }
}
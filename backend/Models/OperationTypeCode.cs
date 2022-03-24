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
    /// Виды операций
    /// </summary>
    /// <value>Виды операций</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum OperationTypeCode
    {
        /// <summary>
        /// Enum CashWithdrawal for value: CashWithdrawal | НВ | Выдача наличных денежных средств
        /// </summary>
        [EnumMember(Value = "CashWithdrawal | НВ | Выдача наличных денежных средств")]
        CashWithdrawal = 1,
        /// <summary>
        /// Enum CashAcceptanceGoods for value: CashAcceptanceGoods | НО | Прием наличных денежных средств в целях оплаты товаров (работ, услуг)
        /// </summary>
        [EnumMember(Value = "CashAcceptanceGoods | НО | Прием наличных денежных средств в целях оплаты товаров (работ, услуг)")]
        CashAcceptanceGoods = 2,
        /// <summary>
        /// Enum CashAcceptanceOther for value: CashAcceptanceOther | НП | Прием наличных денежных средств не в целях оплаты товаров (работ, услуг) (например, погашение кредитов, зачисление на счета физических лиц, увеличение остатка электронных денежных средств)
        /// </summary>
        [EnumMember(Value = "CashAcceptanceOther | НП | Прием наличных денежных средств не в целях оплаты товаров (работ, услуг) (например, погашение кредитов, зачисление на счета физических лиц, увеличение остатка электронных денежных средств)")]
        CashAcceptanceOther = 3,
        /// <summary>
        /// Enum CashlessPaymentGoods for value: CashlessPaymentGoods | БО | Безналичная оплата товаров (работ, услуг)
        /// </summary>
        [EnumMember(Value = "CashlessPaymentGoods | БО | Безналичная оплата товаров (работ, услуг)")]
        CashlessPaymentGoods = 4,
        /// <summary>
        /// Enum CashlessPaymentOther for value: CashlessPaymentOther | БП | Прочие безналичные операции
        /// </summary>
        [EnumMember(Value = "CashlessPaymentOther | БП | Прочие безналичные операции")]
        CashlessPaymentOther = 5    }
}

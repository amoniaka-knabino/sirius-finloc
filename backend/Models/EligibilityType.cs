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
    /// тип соответствия - метод, с помощью которого группируются права на участие в целях сравнения
    /// </summary>
    /// <value>тип соответствия - метод, с помощью которого группируются права на участие в целях сравнения</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum EligibilityType
    {
        /// <summary>
        /// Enum NewCustomersOnly for value: NewCustomersOnly | Продукт доступен только новым клиентам
        /// </summary>
        [EnumMember(Value = "NewCustomersOnly | Продукт доступен только новым клиентам")]
        NewCustomersOnly = 1,
        /// <summary>
        /// Enum MinimumAge for value: MinimumAge | Минимальный возраст для получения продукта
        /// </summary>
        [EnumMember(Value = "MinimumAge | Минимальный возраст для получения продукта")]
        MinimumAge = 2,
        /// <summary>
        /// Enum MaximumAge for value: MaximumAge | Максимальный возраст для получения продукта
        /// </summary>
        [EnumMember(Value = "MaximumAge | Максимальный возраст для получения продукта")]
        MaximumAge = 3,
        /// <summary>
        /// Enum BusinessOnly for value: BusinessOnly | Только для малоо и среднего бизнеса
        /// </summary>
        [EnumMember(Value = "BusinessOnly | Только для малоо и среднего бизнеса")]
        BusinessOnly = 4,
        /// <summary>
        /// Enum CreditScoring for value: CreditScoring | Для прошедших кредитных скоринг
        /// </summary>
        [EnumMember(Value = "CreditScoring | Для прошедших кредитных скоринг")]
        CreditScoring = 5,
        /// <summary>
        /// Enum ExistingCustomers for value: ExistingCustomers | Для клиентов кредитной организации
        /// </summary>
        [EnumMember(Value = "ExistingCustomers | Для клиентов кредитной организации")]
        ExistingCustomers = 6,
        /// <summary>
        /// Enum IdAndV for value: IdAndV | Для идентифицированных клиентов
        /// </summary>
        [EnumMember(Value = "IdAndV | Для идентифицированных клиентов")]
        IdAndV = 7,
        /// <summary>
        /// Enum Mortgage for value: Mortgage | Клиент должен иметь ипотеку в кредитной организации
        /// </summary>
        [EnumMember(Value = "Mortgage | Клиент должен иметь ипотеку в кредитной организации")]
        Mortgage = 8,
        /// <summary>
        /// Enum NoArrearsOnLoan for value: NoArrearsOnLoan | Продукт недоступен для клиента, имеющего задолженность по кредиту
        /// </summary>
        [EnumMember(Value = "NoArrearsOnLoan | Продукт недоступен для клиента, имеющего задолженность по кредиту")]
        NoArrearsOnLoan = 9,
        /// <summary>
        /// Enum NoCustomerInArrears for value: NoCustomerInArrears | Продукт недоступен для клиента с какой-либо просроченной задолженностью
        /// </summary>
        [EnumMember(Value = "NoCustomerInArrears | Продукт недоступен для клиента с какой-либо просроченной задолженностью")]
        NoCustomerInArrears = 10,
        /// <summary>
        /// Enum OtherOtherEligibilityType for value: Other | Использовать OtherEligibilityType для любых не охваченных критериев соответствия
        /// </summary>
        [EnumMember(Value = "Other | Использовать OtherEligibilityType для любых не охваченных критериев соответствия")]
        OtherOtherEligibilityType = 11,
        /// <summary>
        /// Enum StartUp for value: StartUp | На открытие малого и среднего бизнесо
        /// </summary>
        [EnumMember(Value = "StartUp | На открытие малого и среднего бизнесо")]
        StartUp = 12,
        /// <summary>
        /// Enum Turnover for value: Turnover | Ограничено по уровню оборота компании
        /// </summary>
        [EnumMember(Value = "Turnover | Ограничено по уровню оборота компании")]
        Turnover = 13,
        /// <summary>
        /// Enum MinimumBalanceAmont for value: MinimumBalanceAmont | По минимальной сумме остатка
        /// </summary>
        [EnumMember(Value = "MinimumBalanceAmont | По минимальной сумме остатка")]
        MinimumBalanceAmont = 14,
        /// <summary>
        /// Enum MinimumTotalDebit for value: MinimumTotalDebit | По минимальной сумме списания
        /// </summary>
        [EnumMember(Value = "MinimumTotalDebit | По минимальной сумме списания")]
        MinimumTotalDebit = 15,
        /// <summary>
        /// Enum MinimumTotalCredit for value: MinimumTotalCredit | По минимальной сумме начисления
        /// </summary>
        [EnumMember(Value = "MinimumTotalCredit | По минимальной сумме начисления")]
        MinimumTotalCredit = 16    }
}
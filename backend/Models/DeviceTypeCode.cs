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
    /// Тип устройства
    /// </summary>
    /// <value>Тип устройства</value>
    [JsonConverter(typeof(StringEnumConverter))]
        public enum DeviceTypeCode
    {
        /// <summary>
        /// Enum ATM for value: ATM | БК | Банкомат, посредством которого осуществляются операции выдачи наличных денежных средств и (или) безналичные операции с использованием платежных карт (их реквизитов). При этом указанный банкомат может быть также оснащен другими функциями (например, функцией приема наличных денег с использованием и без использования платежных карт (их реквизитов), функцией оплаты товаров (работ, услуг) без использования платежных карт (их реквизитов)
        /// </summary>
        [EnumMember(Value = "ATM | БК | Банкомат, посредством которого осуществляются операции выдачи наличных денежных средств и (или) безналичные операции с использованием платежных карт (их реквизитов). При этом указанный банкомат может быть также оснащен другими функциями (например, функцией приема наличных денег с использованием и без использования платежных карт (их реквизитов), функцией оплаты товаров (работ, услуг) без использования платежных карт (их реквизитов)")]
        ATM = 1,
        /// <summary>
        /// Enum ATMAcceptanceOnly for value: ATMAcceptanceOnly | Банкомат, посредством которого осуществляются только операции по приему наличных денежных средств без использования платежных карт (их реквизитов). При этом указанный банкомат не может быть оснащен другими функциями (например, функцией выдачи (приема) наличных денег с использованием платежных карт (их реквизитов), функцией оплаты товаров (работ, услуг) с использования платежных карт (их реквизитов)
        /// </summary>
        [EnumMember(Value = "ATMAcceptanceOnly | Банкомат, посредством которого осуществляются только операции по приему наличных денежных средств без использования платежных карт (их реквизитов). При этом указанный банкомат не может быть оснащен другими функциями (например, функцией выдачи (приема) наличных денег с использованием платежных карт (их реквизитов), функцией оплаты товаров (работ, услуг) с использования платежных карт (их реквизитов)")]
        ATMAcceptanceOnly = 2,
        /// <summary>
        /// Enum ElectronicTerminalFixed for value: ElectronicTerminalFixed | С | Электронное устройство, работающее в пределах помещения организации торговли и услуг, в котором оно установлено, с применением как проводной, так и беспроводной технологии (стационарный электронный терминал)
        /// </summary>
        [EnumMember(Value = "ElectronicTerminalFixed | С | Электронное устройство, работающее в пределах помещения организации торговли и услуг, в котором оно установлено, с применением как проводной, так и беспроводной технологии (стационарный электронный терминал)")]
        ElectronicTerminalFixed = 3,
        /// <summary>
        /// Enum ElectronicTerminalMobile for value: ElectronicTerminalMobile | М | Электронное устройство, работающее с применением каналов удаленного соединения, в том числе информационно-телекоммуникационной сети «Интернет», абонентское устройство мобильной связи, оборудованное картридером и специальным мобильным приложением (мобильный (переносной) электронный терминал)
        /// </summary>
        [EnumMember(Value = "ElectronicTerminalMobile | М | Электронное устройство, работающее с применением каналов удаленного соединения, в том числе информационно-телекоммуникационной сети «Интернет», абонентское устройство мобильной связи, оборудованное картридером и специальным мобильным приложением (мобильный (переносной) электронный терминал)")]
        ElectronicTerminalMobile = 4,
        /// <summary>
        /// Enum Imprinter for value: Imprinter | И | Механическое устройство, предназначенное для переноса оттиска рельефных реквизитов платежной карты на документ, составленный на бумажном носителе (импринтер)
        /// </summary>
        [EnumMember(Value = "Imprinter | И | Механическое устройство, предназначенное для переноса оттиска рельефных реквизитов платежной карты на документ, составленный на бумажном носителе (импринтер)")]
        Imprinter = 5,
        /// <summary>
        /// Enum Terminal for value: Terminal | Т | Автоматическое устройство, посредством которого держатель платежных карт самостоятельно, без участия уполномоченного сотрудника кредитной организации, организации торговли и услуг, может совершать безналичные операции с использованием платежных карт, конструкция которого не предусматривает выдачу (прием) наличных денег (терминал безналичной оплаты)
        /// </summary>
        [EnumMember(Value = "Terminal | Т | Автоматическое устройство, посредством которого держатель платежных карт самостоятельно, без участия уполномоченного сотрудника кредитной организации, организации торговли и услуг, может совершать безналичные операции с использованием платежных карт, конструкция которого не предусматривает выдачу (прием) наличных денег (терминал безналичной оплаты)")]
        Terminal = 6,
        /// <summary>
        /// Enum Cashbox for value: Cashbox | К | Касса в организации торговли и услуг
        /// </summary>
        [EnumMember(Value = "Cashbox | К | Касса в организации торговли и услуг")]
        Cashbox = 7,
        /// <summary>
        /// Enum CashboxModile for value: CashboxModile | КМ | Мобильная (передвижная) касса
        /// </summary>
        [EnumMember(Value = "CashboxModile | КМ | Мобильная (передвижная) касса")]
        CashboxModile = 8    }
}
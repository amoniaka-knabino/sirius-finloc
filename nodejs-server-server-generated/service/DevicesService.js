'use strict';


/**
 * Получение списока устройств кредитной организации и банковских платежных агентов (субагентов)
 * Конечная точка позволяет получить подробную информацию об устройствах кредитной организации и банковских платежных агентов (субагентов), включающую их характеристики и местоположение (адрес и геолокация).
 *
 * page Integer Номер страницы (optional)
 * xFapiCustomerIpAddress String IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему Поставщику (залогинен в приложении Стороннего Поставщика). (optional)
 * xIfModifiedSince ISODateTime Фильтрации по времени модификации. Возвращает только те ресурсы, которые были изменены с указанного времени обращения (optional)
 * ifModifiedSince String Фильтрации по идентификатору данных. Возвращает ресурс только в случае если представленное значение Etag не совпадает с текущим (optional)
 * xCustomerUserAgent String В заголовке указывается тип устройства (user-agent), который использует Пользователь. Сторонний Поставщик может заполнить это поле значением типа устройства (user-agent), указанным Пользователем. Если Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера (optional)
 * returns DeviceResponse
 **/
exports.getDevices = function(page,xFapiCustomerIpAddress,xIfModifiedSince,ifModifiedSince,xCustomerUserAgent) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "Meta" : {
    "totalPages" : 2
  },
  "Links" : {
    "next" : "http://example.com/aeiou",
    "last" : "http://example.com/aeiou",
    "prev" : "http://example.com/aeiou",
    "self" : "http://example.com/aeiou",
    "first" : "http://example.com/aeiou"
  },
  "Data" : {
    "Device" : [ 
      {
        "deviceType" : "ATM | БК | Банкомат, посредством которого осуществляются операции выдачи наличных денежных средств и (или) безналичные операции с использованием платежных карт (их реквизитов). При этом указанный банкомат может быть также оснащен другими функциями (например, функцией приема наличных денег с использованием и без использования платежных карт (их реквизитов), функцией оплаты товаров (работ, услуг) без использования платежных карт (их реквизитов)",
        "Availability" : {
          "StandardAvailability" : {
            "Day" : [ {
              "dayCode" : "01 | Понедельник",
              "openingTime" : "2021-06-05T15:15:13Z",
              "BreakTime" : [ { }, { } ]
            }, {
              "dayCode" : "01 | Понедельник",
              "openingTime" : "2021-06-05T15:15:13Z",
              "BreakTime" : [ { }, { } ]
            } ]
          },
          "sameAsOrganization" : true,
          "description" : "description",
          "NonStandardAvailability" : [ {
            "name" : "name",
            "description" : "description",
            "Day" : [ null, null ]
          }, {
            "name" : "name",
            "description" : "description",
            "Day" : [ null, null ]
          } ],
          "isRestricted" : true,
          "access24Hours" : true
        },
        "PaymentAgent" : {
          "name" : "СириусБанкомат",
          "Identification" : [ {
            "identification" : "7728240240",
            "schemeName" : "RU.CBR.TXID | Идентификационный номер налогоплательщика (ИНН)"
          }, {
            "identification" : "7728240240",
            "schemeName" : "RU.CBR.TXID | Идентификационный номер налогоплательщика (ИНН)"
          } ],
          "paymentAgentIndicator" : "БПА | банкомат (касса) банковского платежного агента, привлеченного кредитной организацией;"
        },
        "qr" : true,
        "cards" : [ "AmericanExpress | Международная платежная система", "AmericanExpress | Международная платежная система" ],
        "Address" : {
          "PostalAddressAndAdmZone" : {
            "PostalAddress" : {
              "country" : "RU",
              "streetName" : "Садовая",
              "townName" : "Бигсити",
              "countrySubDivision" : "Мой край",
              "addressType" : "DeliveryTo",
              "buildingNumber" : "11",
              "postCode" : "0100010",
              "addressLine" : [ "addressLine", "addressLine" ]
            },
            "administrationZone" : "45388000"
          },
          "Geolocation" : {
            "GeographicCoordinates" : {
              "latitude" : 43.414761,
              "longitude" : 39.949039
            }
          },
          "fias" : "fias"
        },
        "currentStatus" : "On | Доступно",
        "description" : "description",
        "nfc" : true,
        "recirculation" : true,
        "CurrencyExchange" : [ {
          "amountMax" : 1.4658129,
          "scaleCurrency" : 1,
          "exchangeRate" : 1,
          "amountMin" : 6.0274563,
          "fee" : 0.8008282,
          "exchangeType" : "Online | Онлайн",
          "direction" : "Sell | Кредитная организация продает валюту"
        }, {
          "amountMax" : 1.4658129,
          "scaleCurrency" : 1,
          "exchangeRate" : 1,
          "amountMin" : 6.0274563,
          "fee" : 0.8008282,
          "exchangeType" : "Online | Онлайн",
          "direction" : "Sell | Кредитная организация продает валюту"
        } ],
        "deviceId" : "deviceId",
        "baseCurrency" : "RUB",
        "Services" : {
          "Service" : [ {
            "serviceType" : "CashWithdrawal",
            "serviceName" : "serviceName"
          }, {
            "serviceType" : "CashWithdrawal",
            "serviceName" : "serviceName"
          } ]
        },
        "BanknoteIn" : [ {
          "banknoteType" : "banknoteType"
        }, {
          "banknoteType" : "banknoteType"
        } ],
        "ContactDetails" : {
          "emailAddress" : "emailAddress",
          "other" : "other",
          "phoneNumber" : "phoneNumber",
          "mobileNumber" : "mobileNumber",
          "SocialNetworks" : [ {
            "networkName" : "VK | ВКонтакте",
            "description" : "description",
            "url" : "url"
          }, {
            "networkName" : "VK | ВКонтакте",
            "description" : "description",
            "url" : "url"
          } ]
        },
        "BanknoteOut" : [ null, null ],
        "operationType" : [ "", "" ],
        "Accessibilities" : {
          "Accessibility" : [ {
            "description" : "description",
            "type" : "Braille | Шрифт Брайля"
          }, {
            "description" : "description",
            "type" : "Braille | Шрифт Брайля"
          } ]
        }
      }, {
      "deviceType" : "ATM | БК | Банкомат, посредством которого осуществляются операции выдачи наличных денежных средств и (или) безналичные операции с использованием платежных карт (их реквизитов). При этом указанный банкомат может быть также оснащен другими функциями (например, функцией приема наличных денег с использованием и без использования платежных карт (их реквизитов), функцией оплаты товаров (работ, услуг) без использования платежных карт (их реквизитов)",
      "Availability" : {
        "StandardAvailability" : {
          "Day" : [ {
            "dayCode" : "01 | Понедельник",
            "openingTime" : "2021-06-05T15:15:13Z",
            "BreakTime" : [ { }, { } ]
          }, {
            "dayCode" : "01 | Понедельник",
            "openingTime" : "2021-06-05T15:15:13Z",
            "BreakTime" : [ { }, { } ]
          } ]
        },
        "sameAsOrganization" : true,
        "description" : "description",
        "NonStandardAvailability" : [ {
          "name" : "name",
          "description" : "description",
          "Day" : [ null, null ]
        }, {
          "name" : "name",
          "description" : "description",
          "Day" : [ null, null ]
        } ],
        "isRestricted" : true,
        "access24Hours" : true
      },
      "PaymentAgent" : {
        "name" : "МемБанк",
        "Identification" : [ {
          "identification" : "7728240240",
          "schemeName" : "RU.CBR.TXID | Идентификационный номер налогоплательщика (ИНН)"
        }, {
          "identification" : "7728240240",
          "schemeName" : "RU.CBR.TXID | Идентификационный номер налогоплательщика (ИНН)"
        } ],
        "paymentAgentIndicator" : "БПА | банкомат (касса) банковского платежного агента, привлеченного кредитной организацией;"
      },
      "qr" : true,
      "cards" : [ "AmericanExpress | Международная платежная система", "AmericanExpress | Международная платежная система" ],
      "Address" : {
        "PostalAddressAndAdmZone" : {
          "PostalAddress" : {
            "country" : "RU",
            "streetName" : "Садовая",
            "townName" : "Бигсити",
            "countrySubDivision" : "Мой край",
            "addressType" : "DeliveryTo",
            "buildingNumber" : "11",
            "postCode" : "0100010",
            "addressLine" : [ "addressLine", "addressLine" ]
          },
          "administrationZone" : "45388000"
        },
        "Geolocation" : {
          "GeographicCoordinates" : {
            "latitude" : 43.411340, 
            "longitude" : 39.943626
          }
        },
        "fias" : "fias"
      },
      "currentStatus" : "On | Доступно",
      "description" : "description",
      "nfc" : true,
      "recirculation" : true,
      "CurrencyExchange" : [ {
        "amountMax" : 1.4658129,
        "scaleCurrency" : 1,
        "exchangeRate" : 1,
        "amountMin" : 6.0274563,
        "fee" : 0.8008282,
        "exchangeType" : "Online | Онлайн",
        "direction" : "Sell | Кредитная организация продает валюту"
      }, {
        "amountMax" : 1.4658129,
        "scaleCurrency" : 1,
        "exchangeRate" : 1,
        "amountMin" : 6.0274563,
        "fee" : 0.8008282,
        "exchangeType" : "Online | Онлайн",
        "direction" : "Sell | Кредитная организация продает валюту"
      } ],
      "deviceId" : "deviceId",
      "baseCurrency" : "RUB",
      "Services" : {
        "Service" : [ {
          "serviceType" : "CashWithdrawal",
          "serviceName" : "serviceName"
        }, {
          "serviceType" : "CashWithdrawal",
          "serviceName" : "serviceName"
        } ]
      },
      "BanknoteIn" : [ {
        "banknoteType" : "banknoteType"
      }, {
        "banknoteType" : "banknoteType"
      } ],
      "ContactDetails" : {
        "emailAddress" : "emailAddress",
        "other" : "other",
        "phoneNumber" : "phoneNumber",
        "mobileNumber" : "mobileNumber",
        "SocialNetworks" : [ {
          "networkName" : "VK | ВКонтакте",
          "description" : "description",
          "url" : "url"
        }, {
          "networkName" : "VK | ВКонтакте",
          "description" : "description",
          "url" : "url"
        } ]
      },
      "BanknoteOut" : [ null, null ],
      "operationType" : [ "", "" ],
      "Accessibilities" : {
        "Accessibility" : [ {
          "description" : "description",
          "type" : "Braille | Шрифт Брайля"
        }, {
          "description" : "description",
          "type" : "Braille | Шрифт Брайля"
        } ]
      }
    }, {
      "deviceType" : "ATM | БК | Банкомат, посредством которого осуществляются операции выдачи наличных денежных средств и (или) безналичные операции с использованием платежных карт (их реквизитов). При этом указанный банкомат может быть также оснащен другими функциями (например, функцией приема наличных денег с использованием и без использования платежных карт (их реквизитов), функцией оплаты товаров (работ, услуг) без использования платежных карт (их реквизитов)",
      "Availability" : {
        "StandardAvailability" : {
          "Day" : [ {
            "dayCode" : "01 | Понедельник",
            "openingTime" : "2021-06-05T15:15:13Z",
            "BreakTime" : [ { }, { } ]
          }, {
            "dayCode" : "01 | Понедельник",
            "openingTime" : "2021-06-05T15:15:13Z",
            "BreakTime" : [ { }, { } ]
          } ]
        },
        "sameAsOrganization" : true,
        "description" : "description",
        "NonStandardAvailability" : [ {
          "name" : "name",
          "description" : "description",
          "Day" : [ null, null ]
        }, {
          "name" : "name",
          "description" : "description",
          "Day" : [ null, null ]
        } ],
        "isRestricted" : true,
        "access24Hours" : true
      },
      "PaymentAgent" : {
        "name" : "Смирнофф",
        "Identification" : [ {
          "identification" : "7728240240",
          "schemeName" : "RU.CBR.TXID | Идентификационный номер налогоплательщика (ИНН)"
        }, {
          "identification" : "7728240240",
          "schemeName" : "RU.CBR.TXID | Идентификационный номер налогоплательщика (ИНН)"
        } ],
        "paymentAgentIndicator" : "БПА | банкомат (касса) банковского платежного агента, привлеченного кредитной организацией;"
      },
      "qr" : true,
      "cards" : [ "AmericanExpress | Международная платежная система", "AmericanExpress | Международная платежная система" ],
      "Address" : {
        "PostalAddressAndAdmZone" : {
          "PostalAddress" : {
            "country" : "RU",
            "streetName" : "Садовая",
            "townName" : "Бигсити",
            "countrySubDivision" : "Мой край",
            "addressType" : "DeliveryTo",
            "buildingNumber" : "11",
            "postCode" : "0100010",
            "addressLine" : [ "addressLine", "addressLine" ]
          },
          "administrationZone" : "45388000"
        },
        "Geolocation" : {
          "GeographicCoordinates" : {
            "latitude" : 43.411512,
            "longitude" : 39.950106
          }
        },
        "fias" : "fias"
      },
      "currentStatus" : "On | Доступно",
      "description" : "description",
      "nfc" : true,
      "recirculation" : true,
      "CurrencyExchange" : [ {
        "amountMax" : 1.4658129,
        "scaleCurrency" : 1,
        "exchangeRate" : 1,
        "amountMin" : 6.0274563,
        "fee" : 0.8008282,
        "exchangeType" : "Online | Онлайн",
        "direction" : "Sell | Кредитная организация продает валюту"
      }, {
        "amountMax" : 1.4658129,
        "scaleCurrency" : 1,
        "exchangeRate" : 1,
        "amountMin" : 6.0274563,
        "fee" : 0.8008282,
        "exchangeType" : "Online | Онлайн",
        "direction" : "Sell | Кредитная организация продает валюту"
      } ],
      "deviceId" : "deviceId",
      "baseCurrency" : "RUB",
      "Services" : {
        "Service" : [ {
          "serviceType" : "CashWithdrawal",
          "serviceName" : "serviceName"
        }, {
          "serviceType" : "CashWithdrawal",
          "serviceName" : "serviceName"
        } ]
      },
      "BanknoteIn" : [ {
        "banknoteType" : "banknoteType"
      }, {
        "banknoteType" : "banknoteType"
      } ],
      "ContactDetails" : {
        "emailAddress" : "emailAddress",
        "other" : "other",
        "phoneNumber" : "phoneNumber",
        "mobileNumber" : "mobileNumber",
        "SocialNetworks" : [ {
          "networkName" : "VK | ВКонтакте",
          "description" : "description",
          "url" : "url"
        }, {
          "networkName" : "VK | ВКонтакте",
          "description" : "description",
          "url" : "url"
        } ]
      },
      "BanknoteOut" : [ null, null ],
      "operationType" : [ "", "" ],
      "Accessibilities" : {
        "Accessibility" : [ {
          "description" : "description",
          "type" : "Braille | Шрифт Брайля"
        }, {
          "description" : "description",
          "type" : "Braille | Шрифт Брайля"
        } ]
      }
    } ]
  }
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}


'use strict';


/**
 * Получение списка отделений кредитных организаций
 * Конечная точка позволяет получить список всех подразделений, принадлежащие кредитной организации.
 *
 * page Integer Номер страницы (optional)
 * xFapiCustomerIpAddress String IP-адрес Пользователя, если Пользователь в данный момент подключен к Стороннему Поставщику (залогинен в приложении Стороннего Поставщика). (optional)
 * xIfModifiedSince ISODateTime Фильтрации по времени модификации. Возвращает только те ресурсы, которые были изменены с указанного времени обращения (optional)
 * ifModifiedSince String Фильтрации по идентификатору данных. Возвращает ресурс только в случае если представленное значение Etag не совпадает с текущим (optional)
 * xCustomerUserAgent String В заголовке указывается тип устройства (user-agent), который использует Пользователь. Сторонний Поставщик может заполнить это поле значением типа устройства (user-agent), указанным Пользователем. Если Пользователь использует мобильное приложение Стороннего Поставщика, Сторонний Поставщик проверяет, что строка типа устройства (user-agent) отличается от строки типа устройства (user-agent) на основе браузера (optional)
 * returns BranchesResponse
 **/
exports.getBranches = function(page,xFapiCustomerIpAddress,xIfModifiedSince,ifModifiedSince,xCustomerUserAgent) {
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
    "Branch" : [ 
      {
        "branchId" : "branchId",
        "Services" : {
          "Service" : [ {
            "dateTime" : "2021-06-05T15:15:13Z",
            "currentStatus" : "Active | Доступно",
            "segment" : "segment",
            "name" : "name",
            "description" : "description",
            "serviceId" : "serviceId",
            "type" : "Loan | Кредит",
            "url" : "url"
          }, {
            "dateTime" : "2021-06-05T15:15:13Z",
            "currentStatus" : "Active | Доступно",
            "segment" : "segment",
            "name" : "name",
            "description" : "description",
            "serviceId" : "serviceId",
            "type" : "Loan | Кредит",
            "url" : "url"
          } ],
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
          } ]
        },
        "wifi" : true,
        "equeue" : true,
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
              "latitude" : 43.427948, 
              "longitude" : 39.922915
            }
          },
          "fias" : "fias"
        },
        "name" : "АдлерБанк",
        "Information" : {
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
          "ContactDetails" : [ {
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
          }, {
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
          } ]
        },
        "Accessibilities" : {
          "Accessibility" : [  ]
        }
      }, {
      "branchId" : "branchId",
      "Services" : {
        "Service" : [ {
          "dateTime" : "2021-06-05T15:15:13Z",
          "currentStatus" : "Active | Доступно",
          "segment" : "segment",
          "name" : "name",
          "description" : "description",
          "serviceId" : "serviceId",
          "type" : "Loan | Кредит",
          "url" : "url"
        }, {
          "dateTime" : "2021-06-05T15:15:13Z",
          "currentStatus" : "Active | Доступно",
          "segment" : "segment",
          "name" : "name",
          "description" : "description",
          "serviceId" : "serviceId",
          "type" : "Loan | Кредит",
          "url" : "url"
        } ],
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
        } ]
      },
      "wifi" : true,
      "equeue" : true,
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
            "latitude" : 43.415798, 
            "longitude" : 39.948840
          }
        },
        "fias" : "fias"
      },
      "name" : "СириусБанк",
      "Information" : {
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
        "ContactDetails" : [ {
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
        }, {
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
        } ]
      },
      "Accessibilities" : {
        "Accessibility" : [ {
          "description" : "description",
          "type" : "Braille | Шрифт Брайля"
        }, {
          "description" : "description",
          "type" : "InternalRamp | Внутренний пандус"
        }, {
          "description" : "description",
          "type" : "ExternalRamp | Внешний пандус"
        }, {
          "description" : "description",
          "type" : "WheelchairAccess | Доступность для инвалидных колясок"
        } ]
      }
    }, {
      "branchId" : "branchId",
      "Services" : {
        "Service" : [ {
          "dateTime" : "2021-06-05T15:15:13Z",
          "currentStatus" : "Active | Доступно",
          "segment" : "segment",
          "name" : "name",
          "description" : "description",
          "serviceId" : "serviceId",
          "type" : "Loan | Кредит",
          "url" : "url"
        }, {
          "dateTime" : "2021-06-05T15:15:13Z",
          "currentStatus" : "Active | Доступно",
          "segment" : "segment",
          "name" : "name",
          "description" : "description",
          "serviceId" : "serviceId",
          "type" : "Loan | Кредит",
          "url" : "url"
        } ],
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
        } ]
      },
      "wifi" : true,
      "equeue" : true,
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
            "latitude" : 43.405348,
            "longitude" : 39.943926
          }
        },
        "fias" : "fias"
      },
      "name" : "СочиЧилл",
      "Information" : {
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
        "ContactDetails" : [ {
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
        }, {
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
        } ]
      },
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


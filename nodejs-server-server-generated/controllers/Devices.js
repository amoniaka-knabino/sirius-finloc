'use strict';

var utils = require('../utils/writer.js');
var Devices = require('../service/DevicesService');

module.exports.getDevices = function getDevices (req, res, next, page, xFapiCustomerIpAddress, xIfModifiedSince, ifModifiedSince, xCustomerUserAgent) {
  Devices.getDevices(page, xFapiCustomerIpAddress, xIfModifiedSince, ifModifiedSince, xCustomerUserAgent)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

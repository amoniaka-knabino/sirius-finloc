'use strict';

var utils = require('../utils/writer.js');
var Branches = require('../service/BranchesService');

module.exports.getBranches = function getBranches (req, res, next, page, xFapiCustomerIpAddress, xIfModifiedSince, ifModifiedSince, xCustomerUserAgent) {
  Branches.getBranches(page, xFapiCustomerIpAddress, xIfModifiedSince, ifModifiedSince, xCustomerUserAgent)
    .then(function (response) {
      utils.writeJson(res, response);
    })
    .catch(function (response) {
      utils.writeJson(res, response);
    });
};

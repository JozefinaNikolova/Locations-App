var $ = require('jquery');
var Q = require('q');

function makeRequest(method, url, data) {
    var defer = Q.defer();

    data = data || null;

    var options = {
        method: method,
        url: url,
        data: JSON.stringify(data),
        success: function(data) {
            defer.resolve(data);
        },
        error: function(error) {
            defer.reject(error);
        }
    };

    options.beforeSend = function(xhr) {
        xhr.setRequestHeader('Content-Type', 'application/json');
    };

    $.ajax(options);

    return defer.promise;
};

module.exports = makeRequest;
(function () {
    'use strict';

    var serviceId = 'dataservice';
    angular.module('inspinia').factory(serviceId, ['$q', '$http', dataservice]);

    function dataservice($q, $http) {
        var service = {
            getSettings: getSettings,          
            addSettings: addSettings,
            getCategories: getCategories
        };

        return service;

        function getSettings() {
            var deffered = $q.defer();
            $http.get(dataUri + "settings").then(function (result) {
                deffered.resolve(result);
            }, function (err) {
                deffered.reject(err);
            });

            return deffered.promise;
        }

        function addSettings(name, desc) {
            var deffered = $q.defer();
            $http.get(dataUri + "settings", name, desc).then(function (result) {
                deffered.resolve(result);
            }, function (err) {
                deffered.reject(err);
            });

            return deffered.promise;
        }

        function getCategories(category) {
            var deffered = $q.defer();
            $http.get(dataUri + "categories", category).then(function (result) {
                deffered.resolve(result);
            }, function (err) {
                deffered.reject(err);
            });

            return deffered.promise;
        }

    }

})();

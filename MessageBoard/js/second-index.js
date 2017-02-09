//home-index.js
'use strict';
var app = angular.module("appLuc", []);

(function (app) {
    "use strict";
    app.controller("secondIndexController", function ($scope, $http) {
        $scope.dataCount = 0;
        $scope.data = [];
        $scope.isBusy = true;

        $http.get("http://localhost:39210/api/v1/topics")
        .then(function (result) {
            //succes
            angular.copy(result.data, $scope.data);
            $scope.dataCount = result.data.length;
        },
        function () {
            //error
            alert("Something bad happened");
        }
        ).then(function () {
            $scope.isBusy = false;
        });
    });
})(app);

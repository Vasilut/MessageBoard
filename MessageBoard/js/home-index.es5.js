//home-index.js
'use strict';
var myApp = angular.module("appLuc", []);

(function (app) {
    "use strict";
    app.controller("homeIndexController", function ($scope, $http) {
        $scope.name = "Lucian";
        alert("Hello Lucian");
    });
})(myApp);


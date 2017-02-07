//home-index.js
'use strict';
var app = angular.module("appLuc", []);

(function (app) {
    "use strict";
    app.controller("secondIndexController", function ($scope, $http) {
        $scope.name = "Lucian Vasilut";

        $scope.data = [
            {
                title: "This is a message",
                body: "I'm right about this",
                created: "4/24/2013"
            },
            {
                title: "This is a second message",
                body: "I'm right about this second",
                created: "4/24/2013"
            },
            {
                title: "This is a third message",
                body: "I'm right about this third",
                created: "4/24/2013"
            },
        ]
    });
})(app);

(function () {
    var app = angular.module("Patients", []);

    var PatientController = function ($scope, $http) {

        $scope.Header = "Patients";
        $scope.Patients = [
            {
                FirstName: "John",
                LastName: "Conrad"
            },
            {
                FirstName: "Serene",
                LastName: "Danielle"
            }]
    };
    app.controller("PatientController", PatientController);
}());
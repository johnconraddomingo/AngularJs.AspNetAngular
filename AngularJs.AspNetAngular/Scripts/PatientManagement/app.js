(function () {
    var app = angular.module("Patients", []);

    var PatientController = function ($scope, $http) {

        $scope.Header = "Patients";


        $http.get("Patients")
            .then(function (response) {
                $scope.Patients = response.data;
            });

 
        //$scope.Patients = [
        //    {
        //        FirstName: "John",
        //        LastName: "Conrad"
        //    },
        //    {
        //        FirstName: "Serene",
        //        LastName: "Danielle"
        //    }]


        $scope.search = function (searchTerm) {
              


            $http.get("Patient/Search/" + searchTerm)
                .then(function (response) {
                    $scope.Patients = response.data; 
                });

        };

        $scope.search = function (searchTerm) {



            $http.get("Patient/Search/" + searchTerm)
                .then(function (response) {
                    $scope.Patients = response.data;
                });

        };


        $scope.resetSearch = function () {
 
            $http.get("Patient/Search/undefined")
                .then(function (response) {
                    $scope.Patients = response.data;
                });

        };
    };

    app.controller("PatientController", PatientController);
}());
var myApp = angular.module('ppcredentials', []);

myApp.controller("dropdownCtrl", 
    function($scope){
        $scope.selectedItem = document.getElementById("role").value;

        $scope.onChangeDrop = function () {
            $scope.selectedItem = document.getElementById("role").value;
        }
    }
);




var app = angular.module('myApp', ['autocomplte-alt']);
app.controller('ngAutoComplteController', ['$scope','$http', function($scope, $http) {
    $scope.FirstNames = [];
    $scope.SelectdFirstName = null;


    //After Select Name
    $scope.AfterSeletedFirstName=function(selected) {
        if (selected) {
            $scope.SelectdFirstName = selected.originalObject;
        }
    }

    // Populate Data from database
    $http({
        method: 'Get',
        url: 'api/information/AutoCompleteGet'
    }).then(function(data) {
        $scope.FirstNames = data.data;
    }, function() {
        alert('Error');
    });
}]);



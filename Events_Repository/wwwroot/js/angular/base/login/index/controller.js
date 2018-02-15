eveApp.controller('FirstController', function ($scope, $http) {
    $scope.signInForm= { login: "", password: "" }
    $scope.signUpForm= { login: "", email:"", password: "" }
    $scope.loginMode = true;

    $scope.changeMode = function() {
        $scope.loginMode = !$scope.loginMode;
    }





    $scope.init = function() {

    }
});
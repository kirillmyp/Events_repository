eveApp.controller('LoginIndexController', function ($scope, $http) {
    $scope.signInForm = { login: "", password: "" }
    $scope.signUpForm = { login: "", email: "", password: "" }
    $scope.loginMode = true;
    $scope.signIn = () => { $("#signIn").submit(); }
    $('#signIn').on('submit', (e) => {
        e.preventDefault();
        var $form = $(this);
        var url = $form.attr("action");

        if (!signInForm.login || !signInForm.password) {
            $('.err_signIn').show();
        }
        var data = $scope.signInForm;

        $http.post(url, data).then((request) => {
            if (request.isSuccess) {
                window.location = "/";
            } else {
                //showMessage("Something is going bad");
            }
            
        });

    });

    $scope.signUp = () => { $("#signUp").submit(); }
    $('#signUp').on('submit', (e) => {
        e.preventDefault();
        var $form = $(this);
        var url = $form.attr("action");

        if (!signInForm.login || !signInForm.password) {
            $('.err_signIn').show();
        }
        var data = $scope.signInForm;

        $http.post(url, data).then((request) => {
            if (request.isSuccess) {
                $scope.signInForm = $scope.signUpForm;
                $scope.changeMode();
            }
            
        });

    });
    $scope.ProcessSignInForm = () => { }
    $scope.changeMode = () => {
        $scope.loginMode = !$scope.loginMode;
    }





    function controller() {

    }

    controller();
});
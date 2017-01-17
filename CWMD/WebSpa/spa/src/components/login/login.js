'use strict';
app
    .component('login',
    {
        templateUrl: 'spa/src/components/login/login.html',
        controller: function ($scope, $state, LoginService, SweetAlert) {
            const $ctrl = this;
            $ctrl.title = 'Login';
            $ctrl.logIn = (username, password) => LoginService.login(username, password)
                .then(response => {
                    if (response.status === 200) {
                        angular.copy(response, $scope.token);
                        $state.go('dashboard');
                    }
                    if (response.status === 404) {
                        SweetAlert.swal("Email or passwrod incorect");
                        $ctrl.password = '';
                        $ctrl.username = '';
                    }
                });
            $ctrl.goToHome = () => $state.go('dashboard');
        }
    });
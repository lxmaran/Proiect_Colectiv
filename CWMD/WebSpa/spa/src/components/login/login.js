'use strict';
app
    .component('login',
    {
        templateUrl: 'spa/src/components/login/login.html',
        controller: function ($scope, $state, LoginService) {
            const $ctrl = this;
            $ctrl.title = 'asd';
            $ctrl.logIn = (username, password) => LoginService.login(username, password)
                .then(response => {
                    if (response.status === 200) {
                        angular.copy(response, $scope.token);
                        $state.go('home');
                    }
                    if (response.status === 401) {
                        alert('you are not autorized');
                    }
                    console.log(response.status);
                });
            $ctrl.goToHome = () => $state.go('/dashboard');
        }
    });
'use strict';
app
    .component('signUp',
    {
        templateUrl: 'spa/src/components/sign-up/sign-up.html',
        controller: function (SignUpService, $state) {
            const $ctrl = this;
            $ctrl.confirmPassword = "";
            $ctrl.user = {
                username: "",
                password: "",
                Person: {
                    name: ""
                }
            };

            $ctrl.signUp = function () {
                if ($ctrl.user.password !== "" &&
                    $ctrl.user.username !== "" &&
                    $ctrl.user.Person.name !== "") {
                    if ($ctrl.user.password === $ctrl.confirmPassword) {
                        SignUpService.signUp($ctrl.user)
                            .then(response => {
                                $state.go('login');
                            });
                    } else {
                        alert("Passwords don't match !");
                    }
                } else {
                    alert("Please complete all the inputs !");
                }
            }

        }
    });
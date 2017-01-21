app
    .service('SignUpService', function ($http) {

        const service = this;

        service.signUp = (user) =>
            $http
            .put('http://localhost:50776/' + `api/users/sign-up`, user)
            .then(response => response, errno => errno);
    });
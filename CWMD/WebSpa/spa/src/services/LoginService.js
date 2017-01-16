app
    .service('LoginService', function ($http) {

        const service = this;

        service.login = (user, password) =>
            $http
            .post('http://localhost:50776/' + `api/auth`, { username: user, password: password })
            .then(response => response, errno => errno);
    });
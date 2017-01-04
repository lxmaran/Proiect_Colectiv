app
    .service('LoginService', function ($http) {

        const service = this;

        service.login = (user,password) =>
            $http
                .get('http://localhost:50776/' + `api/login/${user+';'+password}`)
                .then(response => response.data);
    });
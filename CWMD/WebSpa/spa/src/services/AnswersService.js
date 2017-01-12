app
    .service('AnswersService', function ($http) {

        const service = this;

        service.getAnswers = () =>
            $http
                .get('http://localhost:50776/' + `api/answers`)
                .then(response => response.data);
    });
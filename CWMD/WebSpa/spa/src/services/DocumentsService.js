app
    .service('DocumentsService', function ($http) {

        const service = this;

        service.getDocuments = () =>
            $http
                .get('http://localhost:50776/' + `api/documents`)
                .then(response => response.data);

    });
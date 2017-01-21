app
    .service('DocumentsService', function ($http) {

        const service = this;

        service.uploadDocument = (doc) =>
            $http
            .post('http://localhost:50776/' + `api/documents`, {data: doc})
            .then(response => response, errno => errno);
    });
app
    .service('DocumentsService', function ($http) {

        const service = this;

        service.getDocuments = () =>
            $http
                .get('http://localhost:50776/' + `api/documents`)
                .then(response => response.data);

    });
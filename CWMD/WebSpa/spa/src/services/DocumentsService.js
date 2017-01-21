app
    .service('DocumentsService', function ($http) {

        const service = this;

        service.uploadDocument = (doc, filename) =>
            $http
            .post('http://localhost:50776/' + `api/documents`, {data: doc, name:filename})
            .then(response => response, errno => errno);

        service.getDocuments = () =>
            $http
                .get('http://localhost:50776/' + `api/documents`)
                .then(response => response.data);

        service.startFlow = task =>
            $http.post('http://localhost:50776/' + `api/flow`, { documentId: task.documentId, flowTypeId: task.flowTypeId });


    });
app
    .service('TasksService', function ($http) {

        const service = this;

        service.getTasks = () =>
            $http
                .get('http://localhost:50776/' + `api/tasks`)
                .then(response => response.data);

        service.updateTask = task =>
            $http.put('http://localhost:50776/' + `api/tasks/${task.taskId}`, task);
    });
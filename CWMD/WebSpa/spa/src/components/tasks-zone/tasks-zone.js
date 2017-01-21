'use strict';
app
    .component('tasksZone',
    {
        templateUrl: 'spa/src/components/tasks-zone/tasks-zone.html',
        controller: function (TasksService, AnswersService) {
            const $ctrl = this;
            $ctrl.answerOptions = [{ optionId: 1, name: 'option1' }, { optionId: 2, name: 'option2' }, { optionId: 3, name: 'option3' }];
            $ctrl.tasks = [{ taskId: 1, flux: 'flux1', document: 'doc1', answer: 'answer' }, { taskId: 2, flux: 'flux2', document: 'doc2', answer: 'answer2' }, { taskId: 3, flux: 'flux3', document: 'doc3', answer: 'answer3' }];
            $ctrl.selectedOption = 'fucken';

            TasksService.getTasks().then(response => $ctrl.tasks = response);

            AnswersService.getAnswers().then(response => $ctrl.answerOptions = response);

            $ctrl.updateAnswer = task => TasksService.updateTask(task);

            $ctrl.startFlow = task => TasksService.startFlow(task);
        }
    });
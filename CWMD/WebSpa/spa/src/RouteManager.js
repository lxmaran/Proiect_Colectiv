app.config(function ($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise("login");

    $stateProvider
        .state('login',
        {
            url: '/login',
            template: '<login></login>'
        })
        .state('dashboard',
        {
            url: '/dashboard',
            template: '<dashboard></dashboard>'
        })
        .state('dashboard.initial-tasks',
        {
            url: '/initial-tasks',
            template: '<initial-tasks></initial-tasks>'
        })
        .state('dashboard.finished-tasks',
        {
            url: '/finished-tasks',
            template: '<finished-tasks></finished-tasks>'
        })
        .state('dashboard.tasks-zone',
        {
            url: '/tasks-zone',
            template: '<tasks-zone></tasks-zone>'
        })
        .state('dashboard.work-zone',
        {
            url: '/work-zone',
            template: '<work-zone></work-zone>'
        })
        .state('sign-up',
        {
            url: '/sign-up',
            template: '<sign-up></sign-up>'
        });
});

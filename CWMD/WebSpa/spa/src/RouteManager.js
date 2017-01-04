app.config(function ($stateProvider, $urlRouterProvider) {
    $urlRouterProvider.otherwise("/login");

    $stateProvider
        .state('/login',
        {
            url: '/login',
            template: '<login></login>'
        })
        .state('/dashboard',
        {
            url: '/dashboard',
            template: '<dashboard></dashboard>'
        });;
});
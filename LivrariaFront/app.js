var app = angular.module("app", ["ngRoute"]);

app.config(function($routeProvider) {
    $routeProvider
    .when('/', {
        templateUrl:"templates/home.html",
        controller:"mainController"
    })
    .when('/livro', {
        templateUrl:"templates/livro.html",
        controller:"livroController"
    })
    .when('/livro/cadastrar', {
        templateUrl:"templates/livro-form.html",
        controller:"livroController"
    })
    .when('/livro/:code/editar', {
        templateUrl:"templates/livro-form.html",
        controller:"livroEditController"
    })
    .otherwise({
        redirectTo: "/"
    });
});

app.config(function($locationProvider){
    $locationProvider.hashPrefix('');
});


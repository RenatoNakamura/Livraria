app.controller("livroEditController", livroEditController);

function livroEditController($scope, $routeParams, livroService, $location) {
    var codigo = $routeParams.code;
    $scope.title = "Editar";
    $scope.livro = {};

    function buscarLivroPorCodigo(codigo){
        livroService.buscarLivroPorCodigo(codigo)
        .then(function sucess(response){
            $scope.livro = response.data;
        },function error(response) {
            console.log(response)
        });
    }

    function salvar(livro) {
        livroService.editar(livro)
        .then(function sucess(response){
            $location.path('livro');
        },function error(response) {
            console.log(response)
        });
    }

    buscarLivroPorCodigo(codigo);
    $scope.salvar = salvar;

}
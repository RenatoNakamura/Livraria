app.controller("livroController", livroController);

function livroController(livroService, $scope, $location){
    $scope.livro = {};
    $scope.title = "Cadastrar";
    $scope.salvar = salvar;
    $scope.remover = remover;
    
    listar();
    
    function salvar(livro) {
        livroService.salvar(livro)
        .then(function sucess(response){
            $location.path('livro')
        },function error(response) {
            console.log(response)
        });
    }

    function listar() {
        livroService.buscarLivros()
        .then(function sucess(response){
            $scope.listaDeLivros = response.data;
        },function error(response) {
            console.log(response)
        });
    }

    function remover(codigo) {
        livroService.remover(codigo)
        .then(function sucess(response){
            listar();
        },function error(response) {
            console.log(response)
        });
    }    
}
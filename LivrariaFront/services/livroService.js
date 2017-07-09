app.factory("livroService", livroService);

function livroService($http){
    var produtos = [];
    var url = 'http://localhost:60660/livro';
    function buscarLivros(){
        return $http.get(url);
    } 

    function buscarLivroPorCodigo(codigo){
        return $http.get(url+"/"+ codigo);
    }

    function salvar(livro){
        return $http.post(url, livro);
    }

    function editar(livro){
        return $http.put(url, livro);
    }

    function remover(id){
        return $http.post(url+"Remover/"+ id);
    }

    return {
        buscarLivros: buscarLivros,
        salvar: salvar,
        buscarLivroPorCodigo: buscarLivroPorCodigo,
        editar: editar,
        remover: remover
    }
}
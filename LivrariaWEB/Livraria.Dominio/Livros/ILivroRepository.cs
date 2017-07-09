using System;
using System.Collections.Generic;

namespace Livraria.Dominio.Livros
{
    public interface ILivroRepository
    {
        DTOLivro Buscar(Guid id);
        Livro BuscarLivro(Guid id);
        IList<DTOLivro> Buscar();
        void Salvar(Livro livro);
        void Alterar(Livro livro);
        void Remover(Livro livro);
    }
}

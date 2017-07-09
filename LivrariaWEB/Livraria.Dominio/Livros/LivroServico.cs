using System;

namespace Livraria.Dominio.Livros
{
    public class LivroServico : ILivroServico
    {
        private readonly ILivroRepository _repositorio;

        public LivroServico(ILivroRepository repositorio)
        {
            _repositorio = repositorio;
        }

        public void Alterar(DTOLivro dtoLivro)
        {
            var livro = _repositorio.BuscarLivro(dtoLivro.ID);
            if (livro == null)
                new Exception("Livro não encontrado.");

            livro.AlterarValores(dtoLivro.Titulo, dtoLivro.Autor, dtoLivro.Valor, dtoLivro.Quantidade);
            _repositorio.Alterar(livro);
        }

        public void Remover(Guid id)
        {
            var livro = _repositorio.BuscarLivro(id);
            if (livro == null)
                new Exception("Livro não encontrado.");

            _repositorio.Remover(livro);
        }

        public void Salvar(DTOLivro dtoLivro)
        {
            var livro = new Livro(dtoLivro.Titulo, dtoLivro.Autor, dtoLivro.Valor, dtoLivro.Quantidade);
            _repositorio.Salvar(livro);            
        }
    }
}

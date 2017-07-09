using Livraria.Dominio.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Livraria.Dominio.Livros
{
    public class LivroRepository : ILivroRepository
    {
        private readonly LivrariaContexto _contexto;

        public LivroRepository(LivrariaContexto contexto)
        {
            _contexto = contexto;
        }

        public void Alterar(Livro livro)
        {
            _contexto.Entry(livro).State = EntityState.Modified;
        }

        public DTOLivro Buscar(Guid id)
        {
            return _contexto.Livros
                            .Select(livro => new DTOLivro { ID = livro.ID, Titulo = livro.Titulo, Autor = livro.Autor, Valor = livro.Valor, Quantidade = livro.Quantidade })
                            .FirstOrDefault(livro => livro.ID == id);
        }

        public IList<DTOLivro> Buscar()
        {
            var resultado = (from livro in _contexto.Livros
                             orderby livro.Titulo ascending
                             select new DTOLivro { ID = livro.ID, Titulo = livro.Titulo, Autor = livro.Autor, Valor = livro.Valor, Quantidade = livro.Quantidade });

            return resultado.ToList();
        }

        public Livro BuscarLivro(Guid id)
        {
            return _contexto.Livros.FirstOrDefault(l => l.ID == id);
        }

        public void Remover(Livro livro)
        {
            _contexto.Livros.Remove(livro);
        }

        public void Salvar(Livro livro)
        {
            _contexto.Livros.Add(livro);
        }
    }
}

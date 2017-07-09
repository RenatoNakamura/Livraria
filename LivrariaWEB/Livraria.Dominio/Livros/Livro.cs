using System;

namespace Livraria.Dominio.Livros
{
    public class Livro
    {
        public Guid ID { get; private set; }
        public string Titulo { get; private set; }
        public string Autor { get; private set; }
        public decimal Valor { get; private set; }
        public int Quantidade { get; private set; }

        protected Livro() { }

        public Livro(string titulo, string autor, decimal valor, int quantidade)
        {
            ID = Guid.NewGuid();
            Titulo = titulo;
            Autor = autor;
            Valor = valor;
            Quantidade = quantidade;
        }

        public void AlterarValores(string titulo, string autor, decimal valor, int quantidade)
        {
            Titulo = titulo;
            Autor = autor;
            Valor = valor;
            Quantidade = quantidade;
        }
    }
}

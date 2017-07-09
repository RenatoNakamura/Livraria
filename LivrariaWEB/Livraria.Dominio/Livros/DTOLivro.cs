using System;

namespace Livraria.Dominio.Livros
{
    public class DTOLivro
    {
        public Guid ID { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }

        public DTOLivro()
        {

        }

        public DTOLivro(Guid id, string titulo, string autor, decimal valor, int quantidade)
        {
            ID = id;
            Titulo = titulo;
            Autor = autor;
            Valor = valor;
            Quantidade = quantidade;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Dominio.Livros
{
    public interface ILivroServico
    {
        void Salvar(DTOLivro dtoLivro);
        void Alterar(DTOLivro dtoLivro);
        void Remover(Guid id);
    }
}

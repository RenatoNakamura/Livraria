using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Livraria.Dominio.Base
{
    public interface IUow
    {
        void Commit();
        void RollBack();
    }
}

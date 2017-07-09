using System;

namespace Livraria.Dominio.Base
{
    public class Uow : IUow
    {
        private readonly LivrariaContexto _contexto;

        public Uow(LivrariaContexto contexto)
        {
            _contexto = contexto;
        }

        public void Commit()
        {
            _contexto.SaveChanges();
        }

        public void RollBack()
        {
            
        }
    }
}

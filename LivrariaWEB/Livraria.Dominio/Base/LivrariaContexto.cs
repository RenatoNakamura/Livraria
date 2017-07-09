using Livraria.Dominio.Livros;
using System.Data.Entity;

namespace Livraria.Dominio.Base
{
    public class LivrariaContexto : DbContext
    {
        public LivrariaContexto() : base(Runtime.ConnectionString)
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<Livro> Livros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

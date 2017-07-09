using System.Data.Entity.ModelConfiguration;

namespace Livraria.Dominio.Livros
{
    public class LivroMapeamento : EntityTypeConfiguration<Livro>
    {
        public LivroMapeamento()
        {
            ToTable("Livro");
            HasKey(x => x.ID);

            Property(x => x.Titulo).IsRequired().HasMaxLength(150).HasColumnName("Titulo");
            Property(x => x.Autor).IsRequired().HasMaxLength(100).HasColumnName("Autor");
            Property(x => x.Valor).IsRequired().HasColumnType("money").HasColumnName("Valor");
            Property(x => x.Quantidade).IsRequired();
        }
    }
}

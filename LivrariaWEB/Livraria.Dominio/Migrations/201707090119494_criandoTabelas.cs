namespace Livraria.Dominio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class criandoTabelas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Livroes",
                c => new
                    {
                        ID = c.Guid(nullable: false),
                        Titulo = c.String(),
                        Autor = c.String(),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Quantidade = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Livroes");
        }
    }
}

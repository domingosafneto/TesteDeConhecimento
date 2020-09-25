namespace TesteDeConhecimento.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Inicio : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Fornecedor",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RazaoSocial = c.String(nullable: false, maxLength: 80),
                        Nomefantasia = c.String(nullable: false, maxLength: 60),
                        Cnpj = c.String(nullable: false, maxLength: 14),
                        Cep = c.String(nullable: false, maxLength: 8),
                        Localidade = c.String(nullable: false, maxLength: 40),
                        Numero = c.String(nullable: false, maxLength: 4),
                        Complemento = c.String(maxLength: 12),
                        Bairro = c.String(nullable: false, maxLength: 15),
                        DataDeInclusao = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fornecedor");
        }
    }
}

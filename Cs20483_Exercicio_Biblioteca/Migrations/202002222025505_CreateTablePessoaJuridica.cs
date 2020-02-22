namespace Cs20483_Exercicio_Biblioteca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTablePessoaJuridica : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PessoaJuridicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cnpj = c.String(),
                        InscricaoEstadual = c.String(),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PessoaJuridicas");
        }
    }
}

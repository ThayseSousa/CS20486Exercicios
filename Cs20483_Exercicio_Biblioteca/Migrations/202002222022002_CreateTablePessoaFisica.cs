namespace Cs20483_Exercicio_Biblioteca.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTablePessoaFisica : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PessoaFisicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Sobrenome = c.String(),
                        Idade = c.Byte(nullable: false),
                        Cpf = c.String(),
                        Rg = c.String(),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PessoaFisicas");
        }
    }
}

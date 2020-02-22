using Cs20483_Exercicio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio_Biblioteca.Context
{
    public class Cs20483Context : DbContext  //---DbContext é uma biblioteca que está dentro do EF
    {
        //--vamos utilizar essa classe context com o entity framework (E.F.)
        //Framework é um conjunto de bibliotecas de classes
        //neste caso o EF é um conjunto de bibliotecas de classes voltado as entidades do banco de dados
        //EF = ORM
        //o EF te mostra os erros em tempo de compilação


        //----temos que indicar em que servidor o nosso banco de dados irá manipular
        //podemos usar o SQL instalado em um sevidor (fisico ou em nuvem)
        //neste caso podemos usar uma versão mais simples de MySQL que roda dentro de própria aplicação (Banco local)
        //depois é só fazer um apontamento para um banco de dados mais robusto

        //---criamos uma propriedade do tipo DbSet que irá gerar uma nova tabela no banco de dados
        //a tabela será gerada de acordo com as propriedades da classe dominio
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Estoque> Estoque { get; set; }
        public DbSet<PessoaFisica> PessoaFisica { get; set; }
        public DbSet<PessoaJuridica> PessoaJuridica { get; set; }

        public Cs20483Context():base(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\61096\Documents\Cs20483\Cs20483_Exercicio\Cs20483_Exercicio_Biblioteca\DataBse\Cs2483DataBase.mdf;Integrated Security = True")
        //quando eu criar um objeto dessa classe ele vai chamar esse construtor que vai chamar o construtor da mãe
        {
        }

    }
}

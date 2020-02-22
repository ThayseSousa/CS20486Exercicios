using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio.Domain.Entities
{
    public class PessoaJuridica : Pessoa
    {

        //---String com "S" maiusculo é uma classe do .NET e o string com "s" minusculo é um tipo do c# (tanto faz usar um ou o outro)
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }

    }
}

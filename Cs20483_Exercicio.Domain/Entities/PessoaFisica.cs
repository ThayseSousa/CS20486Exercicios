using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio.Domain.Entities
{
    public class PessoaFisica : Pessoa //Herança da classe pessoa
    {
        public string Sobrenome { get; set; }

        //---- Propriedade do tipo Byte (0-255)
        public byte Idade { get; set; }

        //---mantemos como string pois o int "comeria" os zeros à esquerda
        //----No caso do CPF: 090... o int guardaria como 90...
        public string Cpf { get; set; }
        public string Rg { get; set; }
    }
}

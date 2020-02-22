using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio.Domain.Entities
{
    public class Produto : Base
    {
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public decimal PrecoUnitario { get; set; } //sempre que vamos trabalhar com valores em reais o ideal é trabalhar com tipo decimal

        public string CodigoProduto { get; set; }


        public override string ToString()
        {
            return $"{Id} - {this.Nome} - {this.Descricao} - {this.CodigoProduto} - {this.PrecoUnitario}";
        }
    }
}

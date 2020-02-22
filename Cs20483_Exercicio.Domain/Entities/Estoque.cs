using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio.Domain.Entities
{
    public class Estoque : Base
    {
        public Produto Produto { get; set; } //---COMPOSIÇÃO -- quando o tipo for uma classe existente ele terá os dados daquela classe (um objeto referenciando outro objeto)

        public short Quantidade { get; set; } //levando em consideração que o estoque poderá ser negativo
                
    }
}

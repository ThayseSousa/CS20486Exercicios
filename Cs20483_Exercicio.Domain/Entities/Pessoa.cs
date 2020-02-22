using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio.Domain.Entities
{

    //--- Pode ser: public, private, internal, static, protected
    //-----Modificador padrão durante uma criação (se não for alterado = internal
    //------A internal só é visivel dentro desse projeto (Domain) neste caso
    public class Pessoa : Base //----a classe mãe deve ser mais acessível (ela não poderá ser private ou alguma outra, sempre terá que ser public
    {
        //----Propriedade do tipo string (atalho para criar = prop + tab + tab)
        //----String é um tipo por referência
        public string Nome { get; set; }

    }
}

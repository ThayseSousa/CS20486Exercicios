using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio.Domain.Entities
{
    public class Base
    {
        //--- O ID foi criado separadamente para que não seja necessário criar um ID para cada tipo de pessoa
        //----sempre que criamos uma propriedade com nome "Id" ele vai automaticamente identificar que aquilo será um autoincrement
        public int Id { get; set; }

    }
}

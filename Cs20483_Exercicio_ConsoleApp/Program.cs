using Cs20483_Exercicio.Domain.Entities;
using Cs20483_Exercicio_Biblioteca.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdutoRepository repositorio = new ProdutoRepository();

            Produto produto = new Produto { 
                                            Nome = "Nokia", 
                                            Descricao = "Indestrutivel, bateria infinita", 
                                            CodigoProduto =  "JP1995", 
                                            PrecoUnitario = 1000.00m
                                        };

            //DESCOMENTE PARA EXECUTAR

            //repositorio.Create(produto);

            //var prodUpdate = repositorio.GetById(2);
            //prodUpdate.Nome = "Iphone";
            //prodUpdate.Descricao = "Destrutivel, sem bateria";
            //repositorio.UpDate(prodUpdate);

            //repositorio.Delete(3);

            foreach (var item in repositorio.ListAll())
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

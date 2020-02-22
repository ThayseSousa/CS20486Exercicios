using Cs20483_Exercicio.Domain.Entities;
using Cs20483_Exercicio_Biblioteca.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cs20483_Exercicio_Biblioteca.Repository
{
    public class BaseRepository<T> where T : Base //Genérico
    {
        //criar os métodos do CRUD
        public List<T> ListAll()
        //public List<Produto> ListAll(string digitado)
        {
            List<T> list = new List<T>();
            using (Cs20483Context context = new Cs20483Context()) //quando usamos o using ele já vai limpando as conexões
            {
                list = context.Set<T>().ToList(); //vai pegar a tabela, selecionar todos, converter para o objeto e vai listar todos
                                                 //lambda = context.Produto.Where(a=>a.Id ==10).ToList();
                                                 //list = context.Produto.Where(a=>a.Nome.Contains(Digitado)).ToList()

                //var query = context.Produto.Where(p => p.Id == 10);
                //    query.Where().... ---seria possível fazer varias regras, podemos também fazer varios ifs e dependendo do resultado executar a função no final dos ifs
            }

            return list;
        }
        public T GetById(int id)
        {
            T model;
            using (Cs20483Context context = new Cs20483Context())
            {
                model = context.Set<T>().Find(id);
                //ou
                //model = context.Produto.where(p=>p.Id==id).FirstOrDefault(); //você deve oscolher o que ele deve trazer (primeiro, ultimo, unico...)
            }

            return model;
        }
        public string Create(T model)
        {
            using (Cs20483Context context = new Cs20483Context())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
            return "Cadastrado com sucesso";
        }
        public string UpDate(T model)
        {
            using (Cs20483Context context = new Cs20483Context())
            {
                context.Entry<T>(model).State = EntityState.Modified;
                context.SaveChanges();
            }
            return "Alterado com sucesso";
        }

        public string Delete(int id)
        {
            using (Cs20483Context context = new Cs20483Context())
            {
                var model = GetById(id);
                context.Entry<T>(model).State = EntityState.Deleted;
                context.Set<T>().Remove(model);
                context.SaveChanges();
            }
            return "Deletado com sucesso";
        }
    }
}

using Interfaces.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class Repositorio<T> : IDisposable, IRepositorio<T> where T : class
    {

        protected readonly Context context = new Context();
        public void Atualizar(T entidade)
        {
            context.Entry(entidade).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public IQueryable<T> BuscarTodos()
        {
            return context.Set<T>();
        }

        public void Deletar(int id)
        {
            var entidade = context.Set<T>().Find(id);
            context.Entry(entidade).State = System.Data.Entity.EntityState.Deleted;
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public T Inserir(T entidade)
        {
            context.Set<T>().Add(entidade);
            context.SaveChanges();
            return entidade;
        }

        public T Procurar(int? codigo)
        {
            return context.Set<T>().Find(codigo);
        }
    }
}

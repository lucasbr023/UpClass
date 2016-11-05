using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Repositorio
{
    public interface IRepositorio<T> where T : class
    {
        T Inserir(T entidade);
        void Deletar(int id);
        void Atualizar(T entidade);
        T Procurar(int? codigo);
        IQueryable<T> BuscarTodos();
        void Dispose();

    }
}

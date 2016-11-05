using Interfaces.Repositorio;
using Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class Service<T> : IService<T> where T : class
    {
        protected readonly IRepositorio<T> _repository;

        public Service(IRepositorio<T> repository) {
            _repository = repository;
        } 
        public void Atualizar(T entidade)
        {
            _repository.Atualizar(entidade);
        }

        public IQueryable<T> BuscarTodos()
        {
            return _repository.BuscarTodos();
        }

        public void Deletar(int id)
        {
            _repository.Deletar(id);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public T Inserir(T entidade)
        {
            return _repository.Inserir(entidade);
        }

        public T Procurar(int? codigo)
        {
            return _repository.Procurar(codigo);
        }
    }
}

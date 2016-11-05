using Entidades.Veiculo;
using Interfaces.Repositorio;
using Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ServiceVeiculo : Service<Veiculo>, IServiceVeiculo
    {

        protected readonly IRepositorioVeiculo _repository;

        public ServiceVeiculo(IRepositorioVeiculo repositorio) : base(repositorio) {
            _repository = repositorio;
        }

    }
}

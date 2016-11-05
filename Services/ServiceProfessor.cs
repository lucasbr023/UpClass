using Entidades;
using Interfaces.Repositorio;
using Interfaces.Service;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Services
{
    public class ServiceProfessor : Service<Professor>, IServiceProfessor
    {
        protected readonly IRepositorioProfessor _repository;

        public ServiceProfessor(IRepositorioProfessor repositorio) : base(repositorio) {
            _repository = repositorio;
        }
        
        public void GerarXML() {
            
        }

        
        public IList<Professor> GetDriversList()
        {
            var drivers = _repository.BuscarTodos().ToList();
            return drivers;
        }
    }
}

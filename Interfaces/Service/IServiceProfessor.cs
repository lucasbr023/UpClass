﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Service
{
    public interface IServiceProfessor : IService<Professor>
    {
        IList<Professor> GetDriversList();
        void GerarXML();
    }
}

using Castle.MicroKernel.Registration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using UpClass.Controllers;
using Interfaces.Service;
using Services;
using Interfaces.Repositorio;
using Repositorio;

namespace UpClass.Castle_Windsor
{
    public class Installers : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {

            container.Register(Component.For<ProfessorController>().LifestylePerWebRequest());
            container.Register(Component.For<IServiceProfessor>().ImplementedBy<ServiceProfessor>().LifestyleTransient());
            container.Register(Component.For<IRepositorioProfessor>().ImplementedBy<RepositorioProfessor>().LifestyleTransient());

            container.Register(Component.For<PostagemController>().LifestylePerWebRequest());
            container.Register(Component.For<IServicePostagem>().ImplementedBy<ServicePostagem>().LifestyleTransient());
            container.Register(Component.For<IRepositorioPostagem>().ImplementedBy<RepositorioPostagem>().LifestyleTransient());

            container.Register(Component.For<AccountController>().LifestylePerWebRequest());

            container.Register(Component.For<HomeController>().LifestylePerWebRequest());

            container.Register(Component.For<ManageController>().LifestylePerWebRequest());

            container.Register(Component.For<LaunchScreenController>().LifestylePerWebRequest());
            
            
        }
    }
}
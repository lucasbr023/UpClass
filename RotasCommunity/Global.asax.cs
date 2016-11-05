using Castle.Windsor;
using Castle.Windsor.Installer;
using Repositorio;
using UpClass.AutoMapper;
using UpClass.Castle_Windsor;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace UpClass
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            InitializeWindsor();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            Database.SetInitializer<Context>(new InicializarDatabase());
            AutoMapperConfig.RegisterMapping();

        }
        private WindsorContainer _windsorContainer;
        private void InitializeWindsor()
        {
            _windsorContainer = new WindsorContainer();
            _windsorContainer.Install(FromAssembly.This());

            ControllerBuilder.Current.SetControllerFactory(new WindsorControllerFactory(_windsorContainer.Kernel));
        }

        protected void Application_End()
        {
            if (_windsorContainer != null)
            {
                _windsorContainer.Dispose();
            }
        }


    }
}

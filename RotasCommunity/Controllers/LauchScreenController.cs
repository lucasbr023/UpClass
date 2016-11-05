using AutoMapper;
using Entidades;
using Interfaces.Service;
using UpClass.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UpClass.Controllers
{
    public class LaunchScreenController : Controller
    {

        public readonly IServiceProfessor _service;

        public LaunchScreenController(IServiceProfessor service)
        {
            _service = service;
        }
        
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(DriverViewModel driver)
        {
            if (ModelState.IsValid)
            {
                var model = Mapper.Map<DriverViewModel, Professor>(driver);
                _service.Inserir(model);
                return RedirectToAction("Index");
            }

            return View(driver);
        }

    }
}
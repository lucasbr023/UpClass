using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Xml;
using Entidades;
using Repositorio;
using Interfaces.Service;
using UpClass.ViewModels;
using AutoMapper;
using Newtonsoft.Json;
using Formatting = System.Xml.Formatting;

namespace UpClass.Controllers
{
    public class ProfessorController : Controller
    {
        public readonly IServiceProfessor _service;
        public ProfessorController(IServiceProfessor service)
        {
            _service = service;
        }

        // GET: Drivers
        public ActionResult Index()
        {
            return View();
        }
    }
}


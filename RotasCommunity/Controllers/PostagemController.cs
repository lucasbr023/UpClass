using System.Net;
using System.Web.Mvc;
using Repositorio;
using Interfaces.Service;
using AutoMapper;
using Entidades.Postagens;
using UpClass.ViewModels;

namespace UpClass.Controllers
{
    public class PostagemController : Controller
    {
        private readonly IServicePostagem _service;

        public PostagemController(IServicePostagem service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            PostagemModel model = new PostagemModel();
            model.Postagens = _service.ObterPostagens();
            return View(model);
        }

        public ActionResult SalvarMensagem(string mensagem)
        {
            var mensagemIncluida = _service.IncluirMensagem(mensagem);
            
            return Json(mensagemIncluida, JsonRequestBehavior.AllowGet);
        }

        public ActionResult ExcluirPostagem(int idPostagem)
        {
            _service.Deletar(idPostagem);

            return Json("Sucesso", JsonRequestBehavior.AllowGet);
        }
        
    }
}

using System;
using Interfaces.Repositorio;
using Interfaces.Service;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using Entidades;
using Entidades.DTO.Postagem;
using Entidades.Postagens;

namespace Services
{
    public class ServicePostagem : Service<Postagem>, IServicePostagem
    {

        protected readonly IRepositorioPostagem _repository;
        protected readonly IRepositorioProfessor _repositoryDriver;

        public ServicePostagem(IRepositorioPostagem repositorio, IRepositorioProfessor repositoryDriver) : base(repositorio)
        {
            _repository = repositorio;
            _repositoryDriver = repositoryDriver;
        }

        public IList<PostagemDTO> ObterPostagens()
        {
            var postagem = _repository.BuscarTodos().Select(p => new PostagemDTO()
            {
                Mensagem  =  p.Mensagem,
                PostagemId = p.PostagemId
            }).ToList();
            return postagem;
        }

        public string IncluirMensagem(string mensagem)
        {
            Postagem postagem = new Postagem()
            {
                DataPublicacao = DateTime.Now,
                Mensagem = mensagem,
                Professor = new Professor()
            };
            _repository.Inserir(postagem);

            return mensagem;
        }
    }
}

using System;
using System.Collections.Generic;
using Entidades.DTO.Postagem;
using Entidades.Postagens;

namespace UpClass.ViewModels
{
    public class PostagemModel
    {
        public PostagemModel()
        {
            Postagens = new List<PostagemDTO>();
        }
        public string Mensagem { get; set; }
        public IList<PostagemDTO> Postagens { get; set; }

     
    }
}
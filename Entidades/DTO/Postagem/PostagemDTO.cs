using System;
using System.ComponentModel.DataAnnotations;
using Entidades;

namespace Entidades.DTO.Postagem
{
    public class PostagemDTO
    {
        public int PostagemId { get; set; }
        public string Mensagem { get; set; }
    }
}

using System;
using System.ComponentModel.DataAnnotations;

namespace Entidades.Postagens
{
    public class Postagem
    {
        [Key]
        public int PostagemId { get; set; }
        public DateTime DataPublicacao { get; set; }
        public string Mensagem { get; set; }
        public virtual Professor Professor { get; set; }
    }
}

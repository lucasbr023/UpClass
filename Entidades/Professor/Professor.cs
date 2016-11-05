using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Entidades.Postagens;

namespace Entidades
{
    public class Professor
    {
        [Key]
        public int ProfessorId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public virtual IList<Postagem> Postagens { get; set; }

    }
}

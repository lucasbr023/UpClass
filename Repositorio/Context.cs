using Entidades;
using System.Data.Entity;
using Entidades.Postagens;


namespace Repositorio
{
    public class Context : DbContext
    {
        public Context() : base("DefaultConnection")
        {
            //Database.SetInitializer<Context>();
        }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Postagem> Postagens { get; set; }
        
    }
}

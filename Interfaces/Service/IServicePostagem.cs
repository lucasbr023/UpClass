
using System.Collections.Generic;
using Entidades.Postagens;

namespace Interfaces.Service
{
    public interface IServicePostagem : IService<Postagem>
    {
        IList<string> ObterPostagens();
        string IncluirMensagem(string mensagem);
    }
}

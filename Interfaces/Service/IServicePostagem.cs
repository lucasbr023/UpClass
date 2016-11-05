
using System.Collections.Generic;
using Entidades.DTO.Postagem;
using Entidades.Postagens;

namespace Interfaces.Service
{
    public interface IServicePostagem : IService<Postagem>
    {
        IList<PostagemDTO> ObterPostagens();
        string IncluirMensagem(string mensagem);
    }
}

using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public interface IUsuarioServico : IBaseServico<Usuario, UsuarioCadastrarViewModel, UsuarioEditarViewModel, UsuarioViewModel>
    {
    }
}

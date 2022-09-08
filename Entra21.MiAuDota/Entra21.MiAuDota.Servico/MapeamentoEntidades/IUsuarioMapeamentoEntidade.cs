using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;

namespace Entra21.MiAuDota.Servico.MapeamentoEntidades
{
    public interface IUsuarioMapeamentoEntidade : IBaseMapeamentoEntidade<Usuario, UsuarioCadastrarViewModel, UsuarioEditarViewModel, UsuarioViewModel>
    {
    }
}
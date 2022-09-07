using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;

namespace Entra21.MiAuDota.Servico.MapeamentoEntidades
{
    public class UsuarioMapeamentoEntidade : IBaseMapeamentoEntidade<Usuario, UsuarioCadastrarViewModel, UsuarioEditarViewModel>
    {
        public void AtualizarCampos(Usuario entity, UsuarioEditarViewModel viewModel)
        {
            throw new NotImplementedException();
        }

        public Usuario ConstruirCom(UsuarioCadastrarViewModel viewModel)
        {
            throw new NotImplementedException();
        }
    }
}

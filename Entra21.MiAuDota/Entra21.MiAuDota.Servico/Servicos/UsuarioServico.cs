using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class UsuarioServico : BaseServico<Usuario, UsuarioCadastrarViewModel, UsuarioEditarViewModel>
    {
        public UsuarioServico(
            IBaseRepositorio<Usuario> baseRepositorio,
            IBaseMapeamentoEntidade<Usuario, UsuarioCadastrarViewModel, UsuarioEditarViewModel> baseMapeamentoEntidade) 
                : base(baseRepositorio, baseMapeamentoEntidade)
        {
        }
    }
}

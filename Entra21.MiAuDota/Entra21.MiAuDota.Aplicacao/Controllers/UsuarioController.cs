using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;

namespace Entra21.MiAuDota.Aplicacao.Controllers
{
    public class UsuarioController : BaseController<Usuario, UsuarioRepositorio, UsuarioServico, UsuarioCadastrarViewModel, UsuarioEditarViewModel, UsuarioViewModel>
    {
        public UsuarioController(UsuarioServico servico) : base(servico)
        {
        }
    }
}

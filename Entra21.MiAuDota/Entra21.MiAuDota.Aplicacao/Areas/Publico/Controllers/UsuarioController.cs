using Entra21.MiAuDota.Aplicacao.Controllers;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Publico.Controllers
{
    [Area("Publico")]
    [Route("/usuario")]
    public class UsuarioController
        : BaseController<Usuario, Usuario, IUsuarioServico, UsuarioCadastrarViewModel, UsuarioEditarViewModel, UsuarioViewModel, IUsuarioRepositorio, IUsuarioMapeamentoEntidade, IUsuarioMapeamentoViewModel>
    {
        public UsuarioController(IUsuarioServico servico) : base(servico)
        {
        }
    }
}

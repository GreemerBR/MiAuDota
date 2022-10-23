using Entra21.MiAuDota.Aplicacao.Controllers;
using Entra21.MiAuDota.Aplicacao.FiltroLogin;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.Autenticacao;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Protetores.Controllers
{
    [ProtetorEstaLogado]
    [Area("Protetores")]
    [Route("protetores/usuario")]
    public class UsuarioController
        : BaseController<Usuario, Usuario, IUsuarioServico, UsuarioCadastrarViewModel, UsuarioEditarViewModel, UsuarioEditarViewModel, UsuarioSenhaViewModel, UsuarioViewModel, IUsuarioRepositorio, IUsuarioMapeamentoEntidade, IUsuarioMapeamentoViewModel>
    {

        public UsuarioController(ISessionManager sessionManager, IUsuarioServico servico) : base(servico, sessionManager)
        {
        }

        [HttpGet("editar")]
        public override IActionResult Editar()
        {
            var usuarioLogado = _sessionManager.GetUser<Usuario>();

            var usuarioEditarViewModel = new UsuarioEditarViewModel
            {
                Id = usuarioLogado.Id,
                Nome = usuarioLogado.Nome,
                Endereco = usuarioLogado.Endereco,
                Celular = usuarioLogado.Celular,
                Especialidade = usuarioLogado.Especialidade,
                EhVoluntario = usuarioLogado.EhVoluntario
            };

            return View("usuario/Editar", usuarioEditarViewModel);
        }

        [HttpGet("listaUsuarios")]
        public IActionResult MeusAnimais()
        {
            return View("Usuarios");
        }
    }
}
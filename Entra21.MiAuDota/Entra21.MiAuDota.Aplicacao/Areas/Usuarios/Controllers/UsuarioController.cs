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

namespace Entra21.MiAuDota.Aplicacao.Areas.Usuarios.Controllers
{
    [UsuarioEstaLogado]
    [Area("Usuarios")]
    [Route("/usuarios/usuario")]
    public class UsuarioController
        : BaseController<Usuario, Usuario, IUsuarioServico, UsuarioCadastrarViewModel, UsuarioEditarViewModel, UsuarioEditarViewModel, UsuarioSenhaViewModel, UsuarioViewModel, IUsuarioRepositorio, IUsuarioMapeamentoEntidade, IUsuarioMapeamentoViewModel>
    {
        private readonly ISessionManager _sessionManager;

        public UsuarioController(ISessionManager sessionManage, IUsuarioServico servico) : base(servico)
        {
            _sessionManager = sessionManage;
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
    }
}

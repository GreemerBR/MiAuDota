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
        : BaseController<Usuario, IUsuarioServico, UsuarioCadastrarViewModel, UsuarioEditarViewModel, UsuarioViewModel, IUsuarioRepositorio, IUsuarioMapeamentoEntidade, IUsuarioMapeamentoViewModel>
    {
        private readonly ISessionManager _sessionManager;
        private readonly IUsuarioServico _usuarioServico;

        public UsuarioController(IUsuarioServico servico, ISessionManager sessionManage) : base(servico)
        {
            _sessionManager = sessionManage;
            _usuarioServico = servico;
        }

        public override IActionResult Editar()
        {
            var usuarioLogado = _sessionManager.GetUser<Usuario>();

            var usuarioEditarViewModel = new UsuarioEditarViewModel
            {
                Id = usuarioLogado.Id,
                Nome = usuarioLogado.Nome,
                Endereco = usuarioLogado.Endereco,
                Celular = usuarioLogado.Celular,
                Senha = usuarioLogado.Senha,
                ConfirmarSenha = usuarioLogado.ConfirmarSenha,
                Especialidade = usuarioLogado.Especialidade,
                EhVoluntario = usuarioLogado.EhVoluntario
            };

            return View("usuario/Editar", usuarioEditarViewModel);
        }

        public override IActionResult Editar([FromBody] UsuarioEditarViewModel updateViewModel)
        {
            var alterou = _usuarioServico.Editar(updateViewModel);

            if (!alterou)
                return NotFound();

            return RedirectToAction("Index", "Home", new { area = "Usuarios" });
        }
    }
}

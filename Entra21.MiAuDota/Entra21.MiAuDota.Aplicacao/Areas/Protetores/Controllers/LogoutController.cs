using Entra21.MiAuDota.Aplicacao.Areas.Publico.Dtos;
using Entra21.MiAuDota.Aplicacao.FiltroLogin;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Protetores.Controllers
{
    [ProtetorEstaLogado]
    [Area("Protetores")]
    [Route("protetores/Logout")]
    public class LogoutController : Controller
    {
        private readonly ILogonServico _logonServico;

        public LogoutController(ILogonServico logonServico)
        {
            _logonServico = logonServico;
        }

        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            _logonServico.Logout<Protetor>();
            return RedirectToAction("Index", "Home", "Publico");
        }
    }
}


using Entra21.MiAuDota.Aplicacao.Areas.Publico.Dtos;
using Entra21.MiAuDota.Servico.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Publico.Controllers
{
    [Area("Publico")]
    [Route("publico/Logon")]
    public class LogonController : Controller
    {
        private readonly ILogonServico _logonServico;

        [HttpGet("Logon")]
        public IActionResult Index()
        {
            return View("Logon");
        }

        [HttpPost("Logon")]
        public IActionResult Logon([FromForm] LogonDto logonDto)
        {
            var result = _logonServico.Logon(logonDto.Email, logonDto.Senha);            

            return RedirectToAction("Index", "Home", new { area = result });
        }
    }
}

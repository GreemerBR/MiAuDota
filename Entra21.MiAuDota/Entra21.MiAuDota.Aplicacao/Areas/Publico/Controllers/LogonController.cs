
using Entra21.MiAuDota.Aplicacao.Areas.Publico.Dtos;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Publico.Controllers
{
    [Area("Publico")]
    [Route("/logon")]
    public class LogonController : Controller
    {
        private readonly ILogonServico _logonServico;

        public LogonController(ILogonServico logonServico)
        {
            _logonServico = logonServico;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        public IActionResult Logon([FromForm] LogonDto logonDto, LogonViewModel logonViewModel)
        {
            if (!ModelState.IsValid)
                return View(logonViewModel);

            var result = _logonServico.Logon(logonDto.Email, logonDto.Senha);            

            return RedirectToAction("Index", "Home", new { area = result });
        }
    }
}

using Entra21.MiAuDota.Aplicacao.FiltroLogin;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Protetores.Controllers
{
    [ProtetorEstaLogado]
    [Area("Protetores")]
    [Route("/protetores")]
    public class HomeController: Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}

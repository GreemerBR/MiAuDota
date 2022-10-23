using Entra21.MiAuDota.Aplicacao.FiltroLogin;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Administradores.Controllers
{
    [AdministradorEstaLogado]
    [Area("Administradores")]
    [Route("/administradores")]
    public class HomeController: Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
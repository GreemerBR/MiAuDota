using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Administradores.Controllers
{
    [Area("Administrador")]
    [Route("/administrador")]
    public class HomeController: Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}

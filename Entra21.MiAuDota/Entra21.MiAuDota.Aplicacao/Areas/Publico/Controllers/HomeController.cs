using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Publico.Controllers
{
    [Area("Publico")]
    [Route("/")]
    public class HomeController: Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace Entra21.TrabalhoFinal.Aplicacao.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

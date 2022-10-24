using Entra21.MiAuDota.Aplicacao.FiltroLogin;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Usuarios.Controllers
{
    [UsuarioEstaLogado]
    [Area("Usuarios")]
    [Route("/usuarios")]
    public class HomeController: Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            
            return View();
        }
    }
}
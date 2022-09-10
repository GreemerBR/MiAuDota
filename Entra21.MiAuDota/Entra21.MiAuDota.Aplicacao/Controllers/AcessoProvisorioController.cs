using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Controllers
{
    [Route("AcessoProvisorio")]
    public class AcessoProvisorioController : Controller
    {
        [HttpGet("Login")]
        public IActionResult Index()
        {
            return View("login");
        }
    }
}

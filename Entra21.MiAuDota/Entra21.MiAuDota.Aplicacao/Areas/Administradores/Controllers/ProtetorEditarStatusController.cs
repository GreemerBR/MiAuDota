using Entra21.MiAuDota.Aplicacao.Controllers;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Publico.Controllers
{
    [Area("Administrador")]
    [Route("administrador/protetor")]
    public class ProtetorControllerAcessoProtetorController : Controller
    {
        private readonly IProtetorServico _protetorServico;
        
        [HttpGet("editar")]
        public IActionResult Editar()
        {
            return View(new ProtetorEditarViewModel());
        }

        [HttpPost("editar")]
        public IActionResult Editar([FromBody] ProtetorEditarViewModel updateViewModel)
        {
            var alterou = _protetorServico.Editar(updateViewModel);

            if (!alterou)
                return NotFound();

            return RedirectToAction("Index", "Home", new { area = "Usuarios" });
        }
    }
}

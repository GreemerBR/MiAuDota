using Entra21.MiAuDota.Aplicacao.Areas.Administradores.Dtos;
using Entra21.MiAuDota.Aplicacao.FiltroLogin;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Administradores.Controllers
{
    [AdministradorEstaLogado]
    [Area("Administradores")]
    [Route("administradores/protetor")]
    public class ProtetorControllerAcessoProtetorController : Controller
    {
        private readonly IProtetorServico _protetorServico;

        [HttpGet("editar")]
        public IActionResult Editar()
        {
            return View(new ProtetorEditarViewModel());
        }

        [HttpPost("editar")]
        public IActionResult Editar([FromBody] ProtetorEditarViewModel updateViewModel, ProtetorStatusDto statusDto)
        {
            updateViewModel.IsActive = statusDto.IsActive;
            var alterou = _protetorServico.Editar(updateViewModel);

            if (!alterou)
                return NotFound();

            return RedirectToAction("Index", "Home", new { area = "Administradores" });
        }
    }
}

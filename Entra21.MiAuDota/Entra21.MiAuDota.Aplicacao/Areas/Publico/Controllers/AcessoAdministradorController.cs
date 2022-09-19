using Entra21.MiAuDota.Aplicacao.Areas.Publico.Dtos;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Publico.Controllers
{
    [Area("Publico")]
    [Route("publico/AcessoAdministrador")]
    public class AcessoAdministradorController : Controller
    {
        private readonly IAdministradorServico _administradorServico;

        public AcessoAdministradorController(IAdministradorServico administradorServico)
        {
            _administradorServico = administradorServico;
        }

        [HttpGet("Logon")]
        public IActionResult Index()
        {
            return View("LogonAdministrador");
        }

        [HttpPost("Logon")]
        public Administrador Logon([FromForm] AdministradorDto administradorDto)
        {
            var user = _administradorServico.Logon(administradorDto.Email, administradorDto.Senha);

            return user;
        }
    }
}

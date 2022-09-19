using Entra21.MiAuDota.Aplicacao.Areas.Publico.Dtos;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Publico.Controllers
{
    [Area("Publico")]
    [Route("publico/AcessoProtetor")]
    public class AcessoProtetorController : Controller
    {
        private readonly IProtetorServico _protetorServico;

        public AcessoProtetorController(IProtetorServico protetorServico)
        {
            _protetorServico = protetorServico;
        }

        [HttpGet("Logon")]
        public IActionResult Index()
        {
            return View("LogonProtetor");
        }

        [HttpPost("Logon")]
        public Protetor Logon([FromForm] ProtetorDto protetorDto)
        {
            var user = _protetorServico.Logon(protetorDto.Email, protetorDto.Senha);

            return user;
        }
    }
}

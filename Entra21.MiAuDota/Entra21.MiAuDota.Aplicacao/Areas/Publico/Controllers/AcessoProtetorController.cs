using Entra21.MiAuDota.Aplicacao.Areas.Publico.Dtos;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Publico.Controllers
{
    [Area("Publico")]
    [Route("publico/acessoprotetor")]
    public class AcessoProtetorController : Controller
    {
        private readonly IProtetorServico _servico;

        public AcessoProtetorController(IProtetorServico servico)
        {
            _servico = servico ?? throw new ArgumentNullException(nameof(servico));
        }

        [HttpGet("Logon")]
        public IActionResult Index()
        {
            return View("LogonProtetor");
        }

        [HttpPost("Logon")]
        public Protetor Logon(ProtetorDto protetorDto)
        {
            var protetor = _servico.Logon(protetorDto.Email, protetorDto.Senha);

            return protetor;
        }
    }
}

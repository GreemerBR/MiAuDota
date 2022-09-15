using Entra21.MiAuDota.AplicacaoProtetor.DTO;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.AplicacaoProtetor.Controllers
{
    [Route("AcessoProtetor")]
    public class AcessoProtetorController : Controller
    {
        private readonly IBaseRepositorio<BaseEntity> _repositorio;


        [HttpGet("Logon")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Logon")]
        public BaseEntity Logon(ProtetorDto protetorDto)
        {
            var protetor = _repositorio.Logon(protetorDto.Email, protetorDto.Senha);

            return protetor;
        }
    }
}

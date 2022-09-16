using Entra21.MiAuDota.Aplicacao.DTO;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Controllers
{
    [Route("AcessoUsuario")]
    public class AcessoUsuarioController : Controller
    {
        private readonly IProtetorServico _servico;

        public AcessoUsuarioController(IProtetorServico servico)
        {
            _servico = servico ?? throw new ArgumentNullException(nameof(servico));
        }

        [HttpGet("Logon")]
        public IActionResult Index()
        {
            return View("LogonUsuario");
        }

        [HttpPost("Logon")]
        public BaseEntity Logon(UsuarioDto userDto)
        {
            var user = _servico.Logon(userDto.Email, userDto.Senha);

            return user;
        }
    }
}

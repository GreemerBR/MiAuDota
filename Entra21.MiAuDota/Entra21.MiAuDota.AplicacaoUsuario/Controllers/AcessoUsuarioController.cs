using Entra21.MiAuDota.AplicacaoUsuario.DTO;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Controllers
{
    [Route("AcessoUsuario")]
    public class AcessoUsuarioController : Controller
    {
        private readonly IBaseRepositorio<BaseEntity> _repositorio;


        [HttpGet("Logon")]
        public IActionResult Index()
        {
            return View("Logon");
        }

        [HttpPost("Logon")]
        public BaseEntity Logon(UsuarioDto userDto)
        {
            var user = _repositorio.Logon(userDto.Email, userDto.Senha);

            return user;
        }
    }
}

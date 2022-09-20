using Entra21.MiAuDota.Aplicacao.Areas.Publico.Dtos;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.Servicos;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Publico.Controllers
{
    [Area("Publico")]
    [Route("publico/AcessoUsuario")]
    public class AcessoUsuarioController : Controller
    {
        private readonly IUsuarioServico _usuarioServico;

        public AcessoUsuarioController(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        [HttpGet("Logon")]
        public IActionResult Index()
        {
            //return View("LogonUsuario");
            return RedirectToAction("Index", "Usuario", new { area = "Usuarios" });
        }

        [HttpPost("Logon")]
        public Usuario Logon([FromForm]UsuarioDto userDto)
        {
            var user = _usuarioServico.Logon(userDto.Email, userDto.Senha);

            return user;
        }
    }
}

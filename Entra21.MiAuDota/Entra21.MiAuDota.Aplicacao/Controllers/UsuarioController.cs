using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Controllers
{
    [Route("/usuario")]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioServico _usuarioServico;

        public UsuarioController(IUsuarioServico usuarioServico)
        {
            _usuarioServico = usuarioServico;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("obterTodos")]
        public IActionResult ObterTodos([FromQuery] string pesquisa)
        {
            var usuarios = _usuarioServico.ObterTodos(pesquisa).ToList();

            return Ok(usuarios);
        }

        [HttpPost("cadastrar")]
        public IActionResult Cadastrar([FromBody] UsuarioCadastrarViewModel viewModel)
        {
            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var usuario = _usuarioServico.Cadastrar(viewModel);

            return Ok(usuario);
        }

        [HttpGet("obterPorId")]
        public IActionResult ObterPorId([FromQuery] int id)
        {
            var usuario = _usuarioServico.ObterPorId(id);

            if (usuario == null)
                return NotFound();

            return Ok(usuario);
        }

        [HttpPost("editar")]
        public IActionResult Editar([FromBody] UsuarioEditarViewModel usuarioEditarViewModel)
        {
            var alterou = _usuarioServico.Editar(usuarioEditarViewModel);

            if (!alterou)
                return NotFound();

            return Ok();
        }

        [HttpGet("apagar")]
        public IActionResult Apagar([FromQuery] int id)
        {
            var apagou = _usuarioServico.Apagar(id);

            if (!apagou)
                return NotFound();

            return Ok();
        }

    }
}

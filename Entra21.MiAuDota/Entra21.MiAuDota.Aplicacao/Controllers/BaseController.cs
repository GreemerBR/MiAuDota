using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.Autenticacao;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Controllers
{
    public class BaseController<TEntity, TServico, TCreateViewModel, TUpdateViewModel, TViewModel, TRepositorio, TMapeamentoEntidade, TMapeamentoViewModel> : Controller
        where TEntity : BaseEntity
        where TViewModel : BaseViewModel
        where TCreateViewModel : BaseViewModel, new()
        where TUpdateViewModel : BaseEditarViewModel<TViewModel>, new()
        where TRepositorio : IBaseRepositorio<TEntity>
        where TMapeamentoEntidade : IBaseMapeamentoEntidade<TEntity, TCreateViewModel, TUpdateViewModel, TViewModel>
        where TServico : IBaseServico<TEntity, TCreateViewModel, TUpdateViewModel, TViewModel, TRepositorio, TMapeamentoEntidade, TMapeamentoViewModel>
        where TMapeamentoViewModel : IBaseMapeamentoViewModel<TEntity, TUpdateViewModel, TViewModel>

    {
        private readonly TServico _servico;

        public BaseController(TServico servico)
        {
            _servico = servico;
        }

        [HttpGet]
        public virtual IActionResult Index()
        {
            var entities = _servico.ObterTodos();
            return View(entities);
        }

        [HttpGet("obterTodosComFiltro")]
        public virtual IActionResult ObterTodosComFiltro([FromQuery] string pesquisa)
        {
            var entities = _servico.ObterTodosComFiltro(pesquisa);

            return Ok(entities);
        }

        [HttpGet("obterTodos")]
        public virtual IActionResult ObterTodos()
        {
            var entities = _servico.ObterTodos();

            return Ok(entities);
        }

        [HttpGet("cadastrar")]
        public virtual IActionResult Cadastrar()
        {
            return View(new TCreateViewModel());
        }

        [HttpPost("cadastrar")]
        public virtual IActionResult Cadastrar([FromForm] TCreateViewModel creatViewModel)
        {
            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var entity = _servico.Cadastrar(creatViewModel);

            return RedirectToAction("Index", "Logon", new { area = "Publico" });
        }

        [HttpGet("obterPorId")]
        public virtual IActionResult ObterPorId([FromQuery] int id)
        {
            var entity = _servico.ObterPorId(id);

            if (entity == null)
                return NotFound();

            return Ok(entity);
        }

        [HttpGet("editar")]
        public virtual IActionResult Editar()
        {
            return View();
        }

        [HttpPost("editar")]
        public virtual IActionResult Editar([FromBody] TUpdateViewModel updateViewModel)
        {
            var alterou = _servico.Editar(updateViewModel);

            if (!alterou)
                return NotFound();

            return RedirectToAction("Index", "Home", new { area = "Publico" });
        }
        [HttpGet("apagar")]
        public virtual IActionResult Apagar([FromQuery] int id)
        {
            var apagou = _servico.Apagar(id);

            if (!apagou)
                return NotFound();

            return Ok();
        }
    }
}

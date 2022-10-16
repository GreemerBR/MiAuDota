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
    public class BaseController<TEntity, TBaseModel, TServico, TCreateViewModel, TUpdateViewModel, TUpdateStatusViewModel, TUpdateSenhaViewModel,  TViewModel, TRepositorio, TMapeamentoEntidade, TMapeamentoViewModel> : Controller
        where TEntity : BaseEntity
        where TBaseModel : UsuarioBase
        where TViewModel : BaseViewModel
        where TCreateViewModel : BaseViewModel, new()
        where TUpdateViewModel : BaseEditarViewModel<TViewModel>, new()
        where TUpdateStatusViewModel : BaseEditarViewModel<TViewModel>, new()
        where TUpdateSenhaViewModel : BaseEditarViewModel<TViewModel>, new()
        where TRepositorio : IBaseRepositorio<TEntity>
        where TMapeamentoEntidade : IBaseMapeamentoEntidade<TEntity, TCreateViewModel, TUpdateViewModel, TUpdateStatusViewModel, TUpdateSenhaViewModel, TViewModel>
        where TServico : IBaseServico<TEntity, TBaseModel, TCreateViewModel, TUpdateViewModel, TUpdateStatusViewModel, TUpdateSenhaViewModel, TViewModel, TRepositorio, TMapeamentoEntidade, TMapeamentoViewModel>
        where TMapeamentoViewModel : IBaseMapeamentoViewModel<TEntity, TUpdateViewModel, TUpdateStatusViewModel, TUpdateSenhaViewModel, TViewModel>

    {
        protected readonly TServico _servico;
        protected readonly ISessionManager _sessionManager;

        public BaseController(TServico servico, ISessionManager sessionManager)
        {
            _servico = servico;
            _sessionManager = sessionManager;
        }

        [HttpGet]
        public virtual IActionResult Index()
        {
            var entities = _servico.ObterTodos();
            return View(entities);
        }

        [HttpGet("obterTodosComFiltro")]
        public virtual IActionResult ObterTodosComFiltro([FromQuery] string especie, string raca, byte idade, byte porte, byte genero)
        {
            var entities = _servico.ObterTodosComFiltro(especie, raca, idade, porte, genero);

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

            _servico.Cadastrar(creatViewModel);

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
        public virtual IActionResult Editar(TUpdateViewModel updateViewModel)
        {
            var id = _sessionManager.GetUser<TBaseModel>().Id;

            updateViewModel.Id = id;

            var alterou = _servico.EditarCampos(updateViewModel);

            if (!alterou)
                return NotFound();

            return View("home/Index");
        }

        [HttpGet("alterarSenha")]
        public virtual IActionResult EditarSenha()
        {
            return View();
        }

        [HttpPost("alterarSenha")]
        public virtual IActionResult EditarSenha([FromForm] TUpdateViewModel updateViewModel)
        {
            var alterou = _servico.EditarCampos(updateViewModel);

            if (!alterou)
                return NotFound();

            return View("Home/Index");
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

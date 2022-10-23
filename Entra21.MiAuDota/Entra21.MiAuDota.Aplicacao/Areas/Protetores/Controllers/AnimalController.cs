using Entra21.MiAuDota.Aplicacao.Controllers;
using Entra21.MiAuDota.Aplicacao.FiltroLogin;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.Autenticacao;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Animais;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Protetores.Controllers
{
    [ProtetorEstaLogado]
    [Area("Protetores")]
    [Route("protetores/animal")]
    public class AnimalController
        : BaseController<Animal, Administrador, IAnimalServico, AnimalCadastrarViewModel, AnimalEditarViewModel, AnimalEditarViewModel, AnimalEditarViewModel, AnimalViewModel, IAnimalRepositorio, IAnimalMapeamentoEntidade, IAnimalMapeamentoViewModel>
    {
        private readonly IAnimalServico _animalServico;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AnimalController(IAnimalServico servico, ISessionManager sessionManager, IWebHostEnvironment webHostEnvironment) : base(servico, sessionManager)
        {
            _animalServico = servico;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpPost("cadastrar")]
        public override IActionResult Cadastrar([FromForm] AnimalCadastrarViewModel creatViewModel)
        {

            if (!ModelState.IsValid)
                return View(creatViewModel);

            _servico.CadastrarAnimal(creatViewModel, _webHostEnvironment.WebRootPath);

            return RedirectToAction("MeusAnimais", "Animal", new { area = "Protetores" });
        }

        [HttpPost("editarAnimal")]
        public IActionResult EditarAnimal(AnimalEditarViewModel updateViewModel)
        {
            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);


            var alterou = _animalServico.EditarAnimal(updateViewModel, _webHostEnvironment.WebRootPath);

            if (!alterou)
                return NotFound();

            return Ok();
        }

        [HttpGet("meus-animais")]
        public IActionResult MeusAnimais()
        {
            return View("MeusAnimais");
        }

        [HttpGet("obterTodos")]
        public override IActionResult ObterTodos()
        {
            var protetorId = _sessionManager.GetUser<Protetor>().Id;
            var entities = _servico.ObterTodosPorProtetorId(protetorId);

            return Ok(entities);
        }
    }
}
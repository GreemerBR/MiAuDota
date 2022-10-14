using Entra21.MiAuDota.Aplicacao.Controllers;
using Entra21.MiAuDota.Aplicacao.FiltroLogin;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
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

        public AnimalController(IAnimalServico servico) : base(servico)
        {
            _animalServico = servico;
        }

        public override IActionResult Cadastrar([FromForm] AnimalCadastrarViewModel creatViewModel)
        {
            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            _animalServico.Cadastrar(creatViewModel);

            return RedirectToAction("Index", "Home", new { area = "Protetores" });
        }

        [HttpGet("meus-animais")]
        public IActionResult MeusAnimais()
        {
            return View("MeusAnimais");
        }
    }
}

using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Animais;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Controllers
{
    [Route("Animal")]
    public class AnimalController
        : BaseController<Animal, IAnimalServico, AnimalCadastrarViewModel, AnimalEditarViewModel, AnimalViewModel>
    {
        public AnimalController(IAnimalServico servico) : base(servico)
        {
        }
    }
}

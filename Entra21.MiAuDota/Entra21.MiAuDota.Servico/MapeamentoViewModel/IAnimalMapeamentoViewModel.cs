using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels.Animais;

namespace Entra21.MiAuDota.Servico.MapeamentoViewModel
{
    public interface IAnimalMapeamentoViewModel : IBaseMapeamentoViewModel<Animal, AnimalEditarViewModel, AnimalViewModel>
    {
    }
}
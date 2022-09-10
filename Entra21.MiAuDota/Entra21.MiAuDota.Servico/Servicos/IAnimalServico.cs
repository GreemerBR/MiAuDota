using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels.Animais;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public interface IAnimalServico : IBaseServico<Animal, AnimalCadastrarViewModel, AnimalEditarViewModel, AnimalViewModel>
    {
    }
}
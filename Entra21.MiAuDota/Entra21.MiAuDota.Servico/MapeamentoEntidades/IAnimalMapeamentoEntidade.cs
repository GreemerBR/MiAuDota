using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels.Animais;

namespace Entra21.MiAuDota.Servico.MapeamentoEntidades
{
    public interface IAnimalMapeamentoEntidade : IBaseMapeamentoEntidade<Animal, AnimalCadastrarViewModel, AnimalEditarViewModel, AnimalEditarViewModel, AnimalEditarViewModel, AnimalViewModel>
    {
    }
}
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.ViewModels.Animais;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class AnimalServico
        : BaseServico<Animal, AnimalCadastrarViewModel, AnimalEditarViewModel, AnimalViewModel, IAnimalRepositorio, IAnimalMapeamentoEntidade, IAnimalMapeamentoViewModel>,
        IAnimalServico
    {
        public AnimalServico(
            IAnimalRepositorio baseRepositorio,
            IAnimalMapeamentoEntidade baseMapeamentoEntidade,
            IAnimalMapeamentoViewModel mapeamentoViewModel)
            : base(baseRepositorio, baseMapeamentoEntidade, mapeamentoViewModel)
        {
        }
    }
}

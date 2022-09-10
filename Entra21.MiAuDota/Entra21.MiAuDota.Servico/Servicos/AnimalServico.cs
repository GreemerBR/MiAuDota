using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.ViewModels.Animais;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class AnimalServico
        : BaseServico<Animal, AnimalCadastrarViewModel, AnimalEditarViewModel, AnimalViewModel>,
        IAnimalServico
    {
        public AnimalServico(
            IBaseRepositorio<Animal> baseRepositorio, 
            IBaseMapeamentoEntidade<Animal, AnimalCadastrarViewModel, AnimalEditarViewModel, AnimalViewModel> baseMapeamentoEntidade) 
            : base(baseRepositorio, baseMapeamentoEntidade)
        {
        }
    }
}

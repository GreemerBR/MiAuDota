using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.ViewModels.Animais;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class AnimalServico
        : BaseServico<Animal, AnimalCadastrarViewModel, AnimalEditarViewModel, AnimalViewModel, IAnimalRepositorio, IAnimalMapeamentoEntidade>,
        IAnimalServico
    {
        public AnimalServico(IAnimalRepositorio baseRepositorio, 
            IAnimalMapeamentoEntidade baseMapeamentoEntidade) 
            : base(baseRepositorio, baseMapeamentoEntidade)
        {
        }
    }
}

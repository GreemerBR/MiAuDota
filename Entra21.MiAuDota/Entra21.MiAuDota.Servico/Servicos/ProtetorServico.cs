using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class ProtetorServico
        : BaseServico<Protetor, ProtetorCadastrarViewModel, ProtetorEditarViewModel, ProtetorViewModel>,
        IProtetorServico
    {
        public ProtetorServico(
            IProtetorRepositorio baseRepositorio,
            IProtetorMapeamentoEntidade baseMapeamentoEntidade)
            : base(baseRepositorio, baseMapeamentoEntidade)
        {
        }
    }
}

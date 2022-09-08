using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;

namespace Entra21.MiAuDota.Servico.MapeamentoEntidades
{
    public interface IProtetorMapeamentoEntidade : IBaseMapeamentoEntidade<Protetor, ProtetorCadastrarViewModel, ProtetorEditarViewModel, ProtetorViewModel>
    {
    }
}
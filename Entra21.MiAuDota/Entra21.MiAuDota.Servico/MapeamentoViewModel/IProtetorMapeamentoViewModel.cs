using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;

namespace Entra21.MiAuDota.Servico.MapeamentoViewModel
{
    public interface IProtetorMapeamentoViewModel : IBaseMapeamentoViewModel<Protetor, ProtetorEditarViewModel, ProtetorStatusViewModel, ProtetorSenhaViewModel, ProtetorViewModel>
    {
    }
}
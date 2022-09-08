using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public interface IProtetorServico : IBaseServico<Protetor, ProtetorCadastrarViewModel, ProtetorEditarViewModel, ProtetorViewModel>
    {
    }
}
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public interface IProtetorServico : IBaseServico<Protetor, Protetor, ProtetorCadastrarViewModel, ProtetorEditarViewModel, ProtetorStatusViewModel, ProtetorSenhaViewModel, ProtetorViewModel, IProtetorRepositorio, IProtetorMapeamentoEntidade, IProtetorMapeamentoViewModel>
    {
        Protetor? Logon(string email, string senha);
        void AlterarStatus(ProtetorStatusViewModel viewModel);
    }
}
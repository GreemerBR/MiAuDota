using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.Autenticacao;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class ProtetorServico
        : BaseServico<Protetor, Protetor, ProtetorCadastrarViewModel, ProtetorEditarViewModel, ProtetorViewModel, IProtetorRepositorio, IProtetorMapeamentoEntidade, IProtetorMapeamentoViewModel>,
        IProtetorServico
    {
        public ProtetorServico(
            IProtetorRepositorio baseRepositorio, 
            IProtetorMapeamentoEntidade baseMapeamentoEntidade, 
            IProtetorMapeamentoViewModel mapeamentoViewModel, 
            ISessionManager sessionManager) 
            : base(
                  baseRepositorio, 
                  baseMapeamentoEntidade, 
                  mapeamentoViewModel, 
                  sessionManager)
        {
        }

        public Protetor? Logon(string email, string senha)
        {
            var entity = _baseRepositorio.Logon(email, senha);

            return entity;
        }

        public void AlterarStatus(ProtetorStatusViewModel viewModel)
        {
            var protetor = _baseRepositorio.ObterPorId(viewModel.Id);

            if (protetor == null)
                throw new Exception("Protetor não encontrado");

            protetor.AlterarStatus();

            _baseRepositorio.Editar(protetor);
        }
    }
}

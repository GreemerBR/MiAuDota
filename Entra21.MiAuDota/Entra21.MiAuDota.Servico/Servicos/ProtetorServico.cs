using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class ProtetorServico
        : BaseServico<Protetor, ProtetorCadastrarViewModel, ProtetorEditarViewModel, ProtetorViewModel, IProtetorRepositorio, IProtetorMapeamentoEntidade, IProtetorMapeamentoViewModel>,
        IProtetorServico
    {
        public ProtetorServico(
            IProtetorRepositorio baseRepositorio, 
            IProtetorMapeamentoEntidade baseMapeamentoEntidade, 
            IProtetorMapeamentoViewModel mapeamentoViewModel) 
            : base(baseRepositorio, baseMapeamentoEntidade, mapeamentoViewModel)
        {
        }

        public Protetor? Logon(string email, string senha)
        {
            var entity = _baseRepositorio.Logon(email, senha);

            return entity;
        }
    }
}

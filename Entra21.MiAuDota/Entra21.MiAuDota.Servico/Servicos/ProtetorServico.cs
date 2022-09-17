using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class ProtetorServico
        : BaseServico<Protetor, ProtetorCadastrarViewModel, ProtetorEditarViewModel, ProtetorViewModel, IProtetorRepositorio, IProtetorMapeamentoEntidade>,
        IProtetorServico
    {
        private readonly IProtetorRepositorio _protetorRepositorio;

        public ProtetorServico(IProtetorRepositorio baseRepositorio,
            IProtetorMapeamentoEntidade baseMapeamentoEntidade)
            : base(baseRepositorio, baseMapeamentoEntidade)
        {
            if (baseRepositorio is null)
            {
                throw new ArgumentNullException(nameof(baseRepositorio));
            }

            if (baseMapeamentoEntidade is null)
            {
                throw new ArgumentNullException(nameof(baseMapeamentoEntidade));
            }
        }

        public Protetor? Logon(string email, string senha)
        {
            var entity = _protetorRepositorio.Logon(email, senha);

            return entity;
        }
    }
}

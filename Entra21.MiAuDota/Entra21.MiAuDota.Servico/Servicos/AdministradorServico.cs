using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.ViewModels.Administrador;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class AdministradorServico : BaseServico<Administrador, AdministradorCadastrarViewModel, AdministradorEditarViewModel, AdministradorViewModel, IAdministradorRepositorio, IAdministradorMapeamentoEntidade>,
        IAdministradorServico
    {
        public AdministradorServico(
            IAdministradorRepositorio baseRepositorio, 
            IAdministradorMapeamentoEntidade baseMapeamentoEntidade) 
            : base(baseRepositorio, baseMapeamentoEntidade)
        {
        }

        public Administrador Logon(string email, string senha)
        {
            var entity = _baseRepositorio.Logon(email, senha);

            return entity;
        }
    }
}

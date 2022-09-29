using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.Autenticacao;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.ViewModels.Administrador;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public class AdministradorServico : 
        BaseServico<
            Administrador,
            Administrador,
            AdministradorCadastrarViewModel, 
            AdministradorEditarViewModel,
            AdministradorViewModel,
            IAdministradorRepositorio,
            IAdministradorMapeamentoEntidade,
            IAdministradorMapeamentoViewModel>,
        IAdministradorServico
    {
        public AdministradorServico(
                IAdministradorRepositorio baseRepositorio, 
                IAdministradorMapeamentoEntidade baseMapeamentoEntidade, 
                IAdministradorMapeamentoViewModel mapeamentoViewModel, 
                ISessionManager sessionManager) 
            : base(
                  baseRepositorio, 
                  baseMapeamentoEntidade, 
                  mapeamentoViewModel, 
                  sessionManager)
        {
        }

        public Administrador? Logon(string email, string senha)
        {
            var entity = _baseRepositorio.Logon(email, senha);

            return entity;
        }
    }
}

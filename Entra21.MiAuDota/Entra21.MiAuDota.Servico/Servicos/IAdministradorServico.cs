using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.ViewModels.Administrador;

namespace Entra21.MiAuDota.Servico.Servicos
{
    public interface IAdministradorServico : IBaseServico<Administrador, AdministradorCadastrarViewModel, AdministradorEditarViewModel, AdministradorViewModel, IAdministradorRepositorio, IAdministradorMapeamentoEntidade, IAdministradorMapeamentoViewModel>
    {
        Administrador? Logon(string email, string senha);
    }
}
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels.Administrador;

namespace Entra21.MiAuDota.Servico.MapeamentoEntidades
{
    public interface IAdministradorMapeamentoEntidade : IBaseMapeamentoEntidade<Administrador, AdministradorCadastrarViewModel, AdministradorEditarViewModel, AdministradorEditarViewModel, AdministradorEditarViewModel, AdministradorViewModel>
    {
    }
}
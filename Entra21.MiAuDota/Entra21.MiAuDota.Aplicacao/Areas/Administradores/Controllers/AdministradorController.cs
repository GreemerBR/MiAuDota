using Entra21.MiAuDota.Aplicacao.Controllers;
using Entra21.MiAuDota.Aplicacao.FiltroLogin;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Administrador;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Administradores.Controllers
{
    [AdministradorEstaLogado]
    [Area("Administradores")]
    [Route("administradores/protetor")]
    public class AdministradorController
        : BaseController<Administrador, Administrador, IAdministradorServico, AdministradorCadastrarViewModel, AdministradorEditarViewModel, AdministradorEditarViewModel, AdministradorEditarViewModel, AdministradorViewModel, IAdministradorRepositorio, IAdministradorMapeamentoEntidade, IAdministradorMapeamentoViewModel>
    {
        public AdministradorController(IAdministradorServico servico) : base(servico)
        {
        }
    }
}

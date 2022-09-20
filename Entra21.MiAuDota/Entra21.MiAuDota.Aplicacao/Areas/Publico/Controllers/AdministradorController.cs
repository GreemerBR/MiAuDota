using Entra21.MiAuDota.Aplicacao.Controllers;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Administrador;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Publico.Controllers
{
    [Area("Publico")]
    [Route("publico/administrador")]
    public class AdministradorController
        : BaseController<Administrador, IAdministradorServico, AdministradorCadastrarViewModel, AdministradorEditarViewModel, AdministradorViewModel, IAdministradorRepositorio, IAdministradorMapeamentoEntidade>
    {
        public AdministradorController(IAdministradorServico servico) : base(servico)
        {
        }
    }
}

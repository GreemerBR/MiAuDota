using Entra21.MiAuDota.Aplicacao.Controllers;
using Entra21.MiAuDota.Aplicacao.FiltroLogin;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Administradores.Controllers
{
    [AdministradorEstaLogado]
    [Area("Administradores")]
    [Route("administradores/protetor")]
    public class ProtetorController
        : BaseController<Protetor, Protetor, IProtetorServico, ProtetorCadastrarViewModel, ProtetorEditarViewModel, ProtetorViewModel, IProtetorRepositorio, IProtetorMapeamentoEntidade, IProtetorMapeamentoViewModel>
    {

        public ProtetorController(IProtetorServico servico) : base(servico)
        {
        }

        [HttpPost("alterarStatus")]
        public IActionResult AlterarStatus(ProtetorStatusViewModel viewModel)
        {
            _servico.AlterarStatus(viewModel);

            return Ok();
        }
    }
}

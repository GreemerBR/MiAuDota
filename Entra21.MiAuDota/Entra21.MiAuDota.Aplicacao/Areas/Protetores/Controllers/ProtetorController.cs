using Entra21.MiAuDota.Aplicacao.Controllers;
using Entra21.MiAuDota.Aplicacao.FiltroLogin;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.Autenticacao;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Protetores.Controllers
{
    [ProtetorEstaLogado]
    [Area("Protetores")]
    [Route("protetores/protetor")]
    public class ProtetorController
        : BaseController<Protetor, Protetor, IProtetorServico, ProtetorCadastrarViewModel, ProtetorEditarViewModel, ProtetorStatusViewModel, ProtetorSenhaViewModel, ProtetorViewModel, IProtetorRepositorio, IProtetorMapeamentoEntidade, IProtetorMapeamentoViewModel>
    {

        public ProtetorController(IProtetorServico servico, ISessionManager sessionManager) : base(servico, sessionManager)
        {
        }

        [HttpGet("editar")]
        public override IActionResult Editar()
        {
            var protetorLogado = _sessionManager.GetUser<Protetor>();

            var protetorEditarViewModel = new ProtetorEditarViewModel
            {
                Id = protetorLogado.Id,
                Nome = protetorLogado.Nome,
                Endereco = protetorLogado.Endereco,
                Celular = protetorLogado.Celular,
                Telefone = protetorLogado.Telefone,
                Pix = protetorLogado.Pix,
                Instagram = protetorLogado.Instagram,
                Facebook = protetorLogado.Facebook,
            };

            return View("protetor/Editar", protetorEditarViewModel);
        }
    }
}

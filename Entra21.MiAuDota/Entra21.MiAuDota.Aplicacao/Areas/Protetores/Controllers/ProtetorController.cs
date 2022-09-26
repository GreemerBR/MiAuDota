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
        : BaseController<Protetor, IProtetorServico, ProtetorCadastrarViewModel, ProtetorEditarViewModel, ProtetorViewModel, IProtetorRepositorio, IProtetorMapeamentoEntidade, IProtetorMapeamentoViewModel>
    {
        private readonly ISessionManager _sessionManager;

        public ProtetorController(IProtetorServico servico) : base(servico)
        {
        }

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
                Sobre = protetorLogado.Sobre,
                Instagram = protetorLogado.Instagram,
                Facebook = protetorLogado.Facebook,
            };

            return View("protetor/Editar", protetorEditarViewModel);
        }
    }
}

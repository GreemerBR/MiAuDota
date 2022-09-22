using Entra21.MiAuDota.Aplicacao.Controllers;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Areas.Publico.Controllers
{
    [Area("Publico")]
    [Route("publico/protetor")]
    public class ProtetorControllers
        : BaseController<Protetor, IProtetorServico, ProtetorCadastrarViewModel, ProtetorEditarViewModel, ProtetorViewModel, IProtetorRepositorio, IProtetorMapeamentoEntidade, IProtetorMapeamentoViewModel>
    {
        public ProtetorControllers(IProtetorServico servico) : base(servico)
        {
        }
    }
}

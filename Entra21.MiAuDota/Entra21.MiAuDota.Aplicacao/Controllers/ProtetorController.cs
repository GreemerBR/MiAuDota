using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Controllers
{
    [Route("Protetor")]
    public class ProtetorController 
        : BaseController<Protetor, IProtetorServico, ProtetorCadastrarViewModel, ProtetorEditarViewModel, ProtetorViewModel>
    {
        public ProtetorController(IProtetorServico servico) : base(servico)
        {
        }
    }
}

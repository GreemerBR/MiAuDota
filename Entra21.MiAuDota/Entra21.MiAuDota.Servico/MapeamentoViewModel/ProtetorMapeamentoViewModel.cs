using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;

namespace Entra21.MiAuDota.Servico.MapeamentoViewModel
{
    public class ProtetorMapeamentoViewModel : IProtetorMapeamentoViewModel
    {
        public ProtetorEditarViewModel ConstruirCom(Protetor entity)
        {
            return new ProtetorEditarViewModel
            {
                Endereco = entity.Endereco,
                Celular = entity.Celular,
                Telefone = entity.Telefone,
                Pix = entity.Pix,
                Sobre = entity.Sobre,
                Instagram = entity.Instagram,
                Facebook = entity.Facebook,
            };
        }
    }
}
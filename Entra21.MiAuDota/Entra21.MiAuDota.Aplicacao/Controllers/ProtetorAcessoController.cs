using Entra21.MiAuDota.Aplicacao.DTO;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Controllers
{
    [Route("AcessoProtetor")]
    public class ProtetorAcessoController<TDto, TEntity>
        : BaseAcessoController<TDto, TEntity>
        where TDto : ProtetorDto
        where TEntity : Protetor
    {
        public ProtetorAcessoController(
            IBaseRepositorio<BaseEntity> repositorio) 
            : base(repositorio)
        {
        }
    }
}

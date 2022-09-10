using Entra21.MiAuDota.Aplicacao.DTO;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Controllers
{
    [Route("AcessoUsuario")]
    public class UsuarioAcessoController<TDto, TEntity>
        : BaseAcessoController<TDto, TEntity>
        where TDto : UsuarioDto
        where TEntity : Usuario
    {
        public UsuarioAcessoController(
            IBaseRepositorio<BaseEntity> repositorio) 
            : base(repositorio)
        {
        }
    }
}

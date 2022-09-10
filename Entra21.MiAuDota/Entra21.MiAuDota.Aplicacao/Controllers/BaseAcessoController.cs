using Entra21.MiAuDota.Aplicacao.DTO;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Microsoft.AspNetCore.Mvc;

namespace Entra21.MiAuDota.Aplicacao.Controllers
{    
    public class BaseAcessoController<TDto, TEntity> : Controller
        where TDto : BaseDto
        where TEntity : BaseEntity
    {
        private readonly IBaseRepositorio<BaseEntity> _repositorio;

        public BaseAcessoController(IBaseRepositorio<BaseEntity> repositorio)
        {
            _repositorio = repositorio;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("Logon")]
        public BaseEntity Logon(BaseDto baseDto)
        {
            var entity = _repositorio.Logon(baseDto.Email, baseDto.Senha);
            
            return entity;
        }
    }
}

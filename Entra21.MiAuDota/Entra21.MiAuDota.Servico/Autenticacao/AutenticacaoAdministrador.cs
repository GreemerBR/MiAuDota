using Entra21.MiAuDota.Repositorio.Entidades;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Entra21.MiAuDota.Servico.Autenticacao
{
    public class AutenticacaoAdministrador : IAutenticacaoAdministrador
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public void CriarSessao(Administrador admin)
        {
            var adminString = JsonConvert.SerializeObject(admin);

            _httpContextAccessor.HttpContext.Session.SetString("adminSession", adminString);
        }

        public Administrador LocalizarSessao()
        {
            var session = _httpContextAccessor.HttpContext.Session.GetString("adminSession");

            if (string.IsNullOrEmpty(session))
                return null;

            return JsonConvert.DeserializeObject<Administrador>(session);
        }

        public void RemoverSessao()
        {
            _httpContextAccessor.HttpContext.Session.Remove("adminSession");
        }
    }
}

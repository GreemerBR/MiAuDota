using Entra21.MiAuDota.Repositorio.Entidades;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Entra21.MiAuDota.Servico.Autenticacao
{
    public class AutenticacaoUsuario : IAutenticacaoUsuario
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public void CriarSessao(Usuario usuario)
        {
            var usuarioString = JsonConvert.SerializeObject(usuario);

            _httpContextAccessor.HttpContext.Session.SetString("usuarioSession", usuarioString);
        }

        public Usuario LocalizarSessao()
        {
            var session = _httpContextAccessor.HttpContext.Session.GetString("usuarioSession");

            if (string.IsNullOrEmpty(session))
                return null;

            return JsonConvert.DeserializeObject<Usuario>(session);
        }

        public void RemoverSessao()
        {
            _httpContextAccessor.HttpContext.Session.Remove("usuarioSession");
        }
    }
}

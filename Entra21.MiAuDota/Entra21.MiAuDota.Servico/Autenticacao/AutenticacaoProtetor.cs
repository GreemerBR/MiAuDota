using Entra21.MiAuDota.Repositorio.Entidades;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Text;

namespace Entra21.MiAuDota.Servico.Autenticacao
{
    public class AutenticacaoProtetor : IAutenticacaoProtetor
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public void CriarSessao(Protetor protetor)
        {
            var protetorString = JsonConvert.SerializeObject(protetor);

            _httpContextAccessor.HttpContext.Session.SetString("protetorSession", protetorString);
        }

        public Protetor LocalizarSessao()
        {
            var session = _httpContextAccessor.HttpContext.Session.GetString("protetorSession");

            if (string.IsNullOrEmpty(session))
                return null;

            return JsonConvert.DeserializeObject<Protetor>(session);
        }

        public void RemoverSessao()
        {
            _httpContextAccessor.HttpContext.Session.Remove("protetorSession");
        }
    }
}
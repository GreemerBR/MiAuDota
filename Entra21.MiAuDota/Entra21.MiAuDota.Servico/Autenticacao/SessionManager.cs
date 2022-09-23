using Entra21.MiAuDota.Repositorio.Entidades;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Entra21.MiAuDota.Servico.Autenticacao
{
    public class SessionManager : ISessionManager
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private const string SessionKeyAdministrator = "administratorSession";
        private const string SessionKeyProtector = "protectorSession";
        private const string SessionKeyUser = "userSession";

        public SessionManager(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void Store<TUserBase>(TUserBase userBase) where TUserBase : UsuarioBase
        {
            var userBaseString = JsonConvert.SerializeObject(userBase);

            var sessionKey = GetSessionKey<TUserBase>();

            GetSession().SetString(sessionKey, userBaseString);
        }

        public TUserBase? GetUser<TUserBase>() where TUserBase : UsuarioBase
        {
            var sessionKey = GetSessionKey<TUserBase>();

            var session = GetSession().GetString(sessionKey);

            if (string.IsNullOrEmpty(session))
                return default;

            return JsonConvert.DeserializeObject<TUserBase>(session);
        }

        public void Logout<TUserBase>() where TUserBase : UsuarioBase
        {
            var sessionKey = GetSessionKey<TUserBase>();

            GetSession().Remove(sessionKey);
        }

        private string GetSessionKey<TUserBase>() where TUserBase : UsuarioBase
        {
            var type = typeof(TUserBase);

            if (type == typeof(Administrador))
                return SessionKeyAdministrator;

            if (type == typeof(Protetor))
                return SessionKeyProtector;

            return SessionKeyUser;
        }

        private ISession GetSession() =>
            _httpContextAccessor.HttpContext.Session;
    }
}

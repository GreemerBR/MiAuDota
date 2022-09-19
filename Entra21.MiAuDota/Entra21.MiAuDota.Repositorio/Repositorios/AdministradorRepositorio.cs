using Entra21.MiAuDota.Repositorio.BancoDados;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Utils;

namespace Entra21.MiAuDota.Repositorio.Repositorios
{
    public class AdministradorRepositorio : BaseRepositorio<Administrador>,
        IAdministradorRepositorio
    {
        private readonly MiAuDotaContexto _contexto;

        public AdministradorRepositorio(MiAuDotaContexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public Protetor Logon(string email, string senha)
        {
            senha = Criptografia.Criptografar(senha);

            return _contexto.Protetores.Where(administrador => administrador.Email == email && administrador.Senha == senha).FirstOrDefault();
        }
    }
}

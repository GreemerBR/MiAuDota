using Entra21.MiAuDota.Repositorio.BancoDados;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Utils;

namespace Entra21.MiAuDota.Repositorio.Repositorios
{
    public class UsuarioRepositorio
        : BaseRepositorio<Usuario>,
        IUsuarioRepositorio
    {
        private readonly MiAuDotaContexto _contexto;

        public UsuarioRepositorio(MiAuDotaContexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public override Usuario Cadastrar(Usuario entity)
        {
            entity.Senha = Criptografia.Criptografar(entity.Senha);
            entity.ConfirmarSenha = Criptografia.Criptografar(entity.ConfirmarSenha);
            return base.Cadastrar(entity);
        }

        public override void Editar(Usuario entity)
        {
            entity.Senha = Criptografia.Criptografar(entity.Senha);
            entity.ConfirmarSenha = Criptografia.Criptografar(entity.ConfirmarSenha);
            base.Editar(entity);
        }

        public override Usuario Logon(string email, string senha)
        {
            senha = Criptografia.Criptografar(senha);
            Usuario usuario = new();

            return _contexto.Usuarios.Where(usuario => usuario.Email == email && usuario.Senha == senha).FirstOrDefault();
        }
    }
}

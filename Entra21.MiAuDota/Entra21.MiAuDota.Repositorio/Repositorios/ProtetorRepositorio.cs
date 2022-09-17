using Entra21.MiAuDota.Repositorio.BancoDados;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Utils;

namespace Entra21.MiAuDota.Repositorio.Repositorios
{
    public class ProtetorRepositorio
        : BaseRepositorio<Protetor>,
        IProtetorRepositorio
    {
        private readonly MiAuDotaContexto _contexto;

        public ProtetorRepositorio(MiAuDotaContexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public override Protetor Cadastrar(Protetor entity)
        {
            entity.Senha = Criptografia.Criptografar(entity.Senha);
            entity.ConfirmarSenha = Criptografia.Criptografar(entity.ConfirmarSenha);
            return base.Cadastrar(entity);
        }

        public override void Editar(Protetor entity)
        {
            entity.Senha = Criptografia.Criptografar(entity.Senha);
            entity.ConfirmarSenha = Criptografia.Criptografar(entity.ConfirmarSenha);
            base.Editar(entity);
        }

        public Protetor Logon(string email, string senha)
        {
            senha = Criptografia.Criptografar(senha);
            Protetor protetor = new();

            return _contexto.Protetores.Where(protetor => protetor.Email == email && protetor.Senha == senha).FirstOrDefault();
        }
    }
}

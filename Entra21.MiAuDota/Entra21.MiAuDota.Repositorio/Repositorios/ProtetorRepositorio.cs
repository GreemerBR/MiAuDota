using Entra21.MiAuDota.Repositorio.BancoDados;
using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Utils;
using Microsoft.EntityFrameworkCore;

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

        public override void EditarCampos(Protetor entity)
        {
            entity.Senha = Criptografia.Criptografar(entity.Senha);
            entity.ConfirmarSenha = Criptografia.Criptografar(entity.ConfirmarSenha);
            base.EditarCampos(entity);
        }

        public Protetor Logon(string email, string senha)
        {
            senha = Criptografia.Criptografar(senha);

            var protetor = _contexto.Protetores.FirstOrDefault(protetor => protetor.Email == email && protetor.Senha == senha && protetor.IsActive == true);

            return protetor;
        }
    }
}

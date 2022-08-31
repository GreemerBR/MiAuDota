using Entra21.TrabalhoFinal.Repositorio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Entra21.TrabalhoFinal.Repositorio.BancoDados
{
    public class MiAuDotaContexto : DbContext
    {
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Protetor> Protetores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        //public MiAuDotaContexto(DbSet<NomeIndefinidoContexto> options) : base(options)
        //{
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new IndefinidoMapeamento());
        }
    }
}

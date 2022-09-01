using Entra21.MiAuDota.Repositorio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Entra21.MiAuDota.Repositorio.BancoDados
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

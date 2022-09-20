using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Mapeamentos;
using Microsoft.EntityFrameworkCore;

namespace Entra21.MiAuDota.Repositorio.BancoDados
{
    public class MiAuDotaContexto : DbContext
    {
        public DbSet<Administrador> Administrador { get; set; }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Protetor> Protetores { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        public MiAuDotaContexto(DbContextOptions<MiAuDotaContexto> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdministradorMapeamento());
            modelBuilder.ApplyConfiguration(new AnimaisMapeamento());
            modelBuilder.ApplyConfiguration(new ProtetoresMapeamento());
            modelBuilder.ApplyConfiguration(new UsuariosMapeamento());
        }
    }
}

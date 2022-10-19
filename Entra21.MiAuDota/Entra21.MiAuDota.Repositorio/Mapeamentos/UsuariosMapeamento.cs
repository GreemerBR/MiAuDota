using Entra21.MiAuDota.Repositorio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entra21.MiAuDota.Repositorio.Mapeamentos
{
    public class UsuariosMapeamento : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("usuarios");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("VARCHAR")
                .HasMaxLength(45)
                .IsRequired()
                .HasColumnName("nome");

            builder.Property(x => x.Cpf)
                .HasColumnType("VARCHAR")
                .HasMaxLength(14)
                .HasColumnName("cpf");

            builder.HasIndex(x => x.Cpf)
            .IsUnique();

            builder.Property(x => x.Endereco)
                .HasColumnType("VARCHAR")
                .HasMaxLength(45)
                .HasColumnName("endereco");

            builder.Property(x => x.Celular)
                .HasColumnType("VARCHAR")
                .HasMaxLength(15)
                .HasColumnName("celular");

            builder.Property(x => x.Email)
                .HasColumnType("VARCHAR")
                .HasMaxLength(45)
                .IsRequired()
                .HasColumnName("email");

            builder.HasIndex(x => x.Email)
            .IsUnique();

            builder.Property(x => x.Senha)
                .HasColumnType("VARCHAR")
                .HasMaxLength(45)
                .IsRequired()
                .HasColumnName("senha");

            builder.Property(x => x.ConfirmarSenha)
                .HasColumnType("VARCHAR")
                .HasMaxLength(45)
                .IsRequired()
                .HasColumnName("confirmar_senha");

            builder.Property(x => x.Especialidade)
                .HasColumnType("VARCHAR")
                .HasMaxLength(45)
                .HasColumnName("especialidade");

            builder.Property(x => x.EhVoluntario)
                .HasColumnType("BIT")
                .HasColumnName("eh_voluntario");

            builder.Property(x => x.DataNascimento)
                .HasColumnType("DATETIME2")
                .HasColumnName("data_nascimento");      

            builder.Property(x => x.IsActive)
                .HasColumnType("BIT")
                .HasColumnName("conta_esta_ativa");
        }
    }
}
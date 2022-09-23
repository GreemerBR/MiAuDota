using Entra21.MiAuDota.Repositorio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entra21.MiAuDota.Repositorio.Mapeamentos
{
    public class ProtetoresMapeamento : IEntityTypeConfiguration<Protetor>
    {
        public void Configure(EntityTypeBuilder<Protetor> builder)
        {
            builder.ToTable("protetores");

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

            builder.Property(x => x.Cnpj)
                .HasColumnType("VARCHAR")
                .HasMaxLength(18)
                .HasColumnName("cnpj");

            builder.Property(x => x.Endereco)
                .HasColumnType("VARCHAR")
                .HasMaxLength(45)
                .HasColumnName("endereco");

            builder.Property(x => x.Celular)
                .HasColumnType("VARCHAR")
                .HasMaxLength(15)
                .HasColumnName("celular");

            builder.Property(x => x.Telefone)
                .HasColumnType("VARCHAR")
                .HasMaxLength(14)
                .HasColumnName("telefone");

            builder.Property(x => x.Email)
                .HasColumnType("VARCHAR")
                .HasMaxLength(45)
                .IsRequired()
                .HasColumnName("email");

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

            builder.Property(x => x.Pix)
                .HasColumnType("VARCHAR")
                .HasMaxLength(45)
                .HasColumnName("pix");

            builder.Property(x => x.Sobre)
                .HasColumnType("TEXT")
                .HasColumnName("sobre");

            builder.Property(x => x.Instagram)
                .HasColumnType("VARCHAR")
                .HasMaxLength(45)
                .HasColumnName("instagram");

            builder.Property(x => x.Facebook)
                .HasColumnType("VARCHAR")
                .HasMaxLength(45)
                .HasColumnName("facebook");

            builder.Property(x => x.IsActive)
                .HasColumnType("BIT")
                .HasColumnName("conta_esta_ativa");
        }
    }
}

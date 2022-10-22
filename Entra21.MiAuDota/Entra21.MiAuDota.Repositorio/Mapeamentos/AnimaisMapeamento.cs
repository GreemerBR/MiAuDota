using Entra21.MiAuDota.Repositorio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entra21.MiAuDota.Repositorio.Mapeamentos
{
    public class AnimaisMapeamento : IEntityTypeConfiguration<Animal>
    {
        public void Configure(EntityTypeBuilder<Animal> builder)
        {
            builder.ToTable("animais");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Nome)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("nome");

            builder.Property(x => x.Raca)
                .HasColumnType("VARCHAR")
                .HasMaxLength(50)
                .IsRequired()
                .HasColumnName("raca");

            builder.Property(x => x.Especie)
                .HasColumnType("TINYINT")                
                .IsRequired()
                .HasColumnName("especie");

            builder.Property(x => x.Sobre)
                .HasColumnType("TEXT")
                .IsRequired()
                .HasColumnName("sobre");

            builder.Property(x => x.Foto)
                .HasColumnType("VARCHAR")
                .HasMaxLength(300)
                .HasColumnName("caminho_arquivo");

            builder.Property(x => x.Idade)
                .HasColumnType("TINYINT")
                .IsRequired()
                .HasColumnName("idade");

            builder.Property(x => x.Peso)
                .HasColumnType("DECIMAL")
                .HasPrecision(5, 2)
                .IsRequired()
                .HasColumnName("peso");

            builder.Property(x => x.Altura)
                .HasColumnType("DECIMAL")
                .HasPrecision(3, 2)
                .IsRequired()
                .HasColumnName("altura");

            builder.Property(x => x.Castrado)
                .HasColumnType("BIT")
                .IsRequired()
                .HasColumnName("castrado");

            builder.Property(x => x.DataAdocao)
                .HasColumnType("DATETIME2")
                .HasColumnName("data_adocao");

            builder.Property(x => x.Genero)
                .HasColumnType("TINYINT")
                .IsRequired()
                .HasColumnName("genero");
            
            builder.Property(x => x.Porte)
                .HasColumnType("TINYINT")
                .IsRequired()
                .HasColumnName("porte");

            builder.Property(x => x.Status)
                .HasColumnType("TINYINT")
                .IsRequired()
                .HasColumnName("status");

            builder.Property(x => x.ProtetorId)
                .HasColumnType("INT")
                .IsRequired()
                .HasColumnName("protetor_id");

            builder.HasOne(x => x.Protetor)
                .WithMany(x => x.Animais)
                .HasForeignKey(x => x.ProtetorId);

            builder.Property(x => x.UsuarioId)
                .HasColumnType("INT")
                .HasColumnName("usuario_id");
                       
            builder.HasOne(x => x.Usuario)
                .WithMany(x => x.Animais)
                .HasForeignKey(x => x.UsuarioId);
        }
    }
}
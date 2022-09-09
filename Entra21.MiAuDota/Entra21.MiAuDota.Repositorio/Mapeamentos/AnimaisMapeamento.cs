using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Enum;
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
               .HasMaxLength(45)
               .IsRequired()
               .HasColumnName("nome");

            builder.Property(x => x.Raca)
               .HasColumnType("VARCHAR")
               .HasMaxLength(45)
               .IsRequired()
               .HasColumnName("raca");

            builder.Property(x => x.Especie)
               .HasColumnType("VARCHAR")
               .HasMaxLength(45)
               .IsRequired()
               .HasColumnName("especie");

            builder.Property(x => x.Sobre)
               .HasColumnType("TEXT")
               .IsRequired()
               .HasColumnName("sobre");

            builder.Property(x => x.Genero)
            .HasColumnType("TINYINT")
            .IsRequired()
            .HasColumnName("genero");

            builder.Property(x => x.Status)
               .HasColumnType("TINYINT")
               .IsRequired()
               .HasColumnName("status");

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

            builder.Property(x => x.Vacinas)
               .HasColumnType("VARCHAR")
               .HasMaxLength(45)
               .IsRequired()
               .HasColumnName("vacinas");

            builder.Property(x => x.Castrado)
             .HasColumnType("BIT")
             .IsRequired()
             .HasColumnName("cadastro");

            builder.Property(x => x.Alergias)
               .HasColumnType("VARCHAR")
               .HasMaxLength(45)
               .IsRequired()
               .HasColumnName("alergias");

            builder.Property(x => x.OutrasInformacoesMedicas)
               .HasColumnType("TEXT")
               .HasColumnName("outras_infos_medicas");

            builder.Property(x => x.Foto)
            .HasColumnType("VARCHAR")
            .HasMaxLength(300)
            .HasColumnName("caminho_arquivo");

            builder.Property(x => x.UsuarioId)
             .HasColumnType("INT")
             .IsRequired()
             .HasColumnName("usuario_id");

            builder.Property(x => x.ProtetorId)
             .HasColumnType("INT")
             .IsRequired()
             .HasColumnName("protetor_id");

            builder.Property(x => x.DataAdocao)
            .HasColumnType("DATETIME2")
            .HasColumnName("data_adocao");

            builder.HasOne(x => x.Usuario)
            .WithMany(x => x.Animais)
            .HasForeignKey(x => x.UsuarioId);

            builder.HasOne(x => x.Protetor)
            .WithMany(x => x.Animais)
            .HasForeignKey(x => x.ProtetorId);

            builder.HasData(
            new Animal
            {
                Id = 1,
                Nome = "bob",
                Raca = "Pastor",
                Especie = "Cão",
                Sobre = "bonito",
                Vacinas = "Gripe",
                Alergias = "nenhuma",
                Foto = "8BE47EBF-0F7A-455F-B4DB-58001DD9D577.jpg",
                Idade = 1,
                Peso = 2.3,
                Altura = 0.7,
                Castrado = true,
                DataAdocao = new DateTime(2022,8,22),
                Genero = GeneroAnimal.Macho,
                Status = StatusInstituicao.Adotado,
                ProtetorId = 1,
                UsuarioId = 1

            });
        }
    }
}

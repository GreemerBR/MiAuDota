using Entra21.TrabalhoFinal.Repositorio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entra21.TrabalhoFinal.Repositorio.Mapeamentos
{
    internal class ProtetoresMapeamento : IEntityTypeConfiguration<Protetor>
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

            builder.Property(x => x.Cnpj)
                .HasColumnType("VARCHAR")
                .HasMaxLength(18)
                .HasColumnName("cnpf");

            builder.Property(x => x.Cpf)
                .HasColumnType("VARCHAR")
                .HasMaxLength(14)
                .HasColumnName("cpf");

            builder.Property(x => x.Endereco)
                .HasColumnType("VARCHAR")
                .HasMaxLength(45)
                .IsRequired()
                .HasColumnName("endereco");

            builder.Property(x => x.Celular)
                .HasColumnType("VARCHAR")
                .HasMaxLength(14)
                .IsRequired()
                .HasColumnName("celular");

            builder.Property(x => x.Telefone)
                .HasColumnType("VARCHAR")
                .HasMaxLength(13)
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

            builder.Property(x => x.Pix)
               .HasColumnType("VARCHAR")
               .HasColumnName("pix");

            builder.Property(x => x.Sobre)
             .HasColumnType("TEXT")
             .IsRequired()
             .HasColumnName("sobre");

            builder.Property(x => x.Instagram)
             .HasColumnType("VARCHAR")
             .HasMaxLength(45)
             .HasColumnName("instagram");

            builder.Property(x => x.Facebook)
             .HasColumnType("VARCHAR")
             .HasMaxLength(45)
             .HasColumnName("facebook");

            builder.Property(x => x.EhProtetor)
             .HasColumnType("BIT")
             .IsRequired()
             .HasColumnName("ehprotetor");

            builder.HasData(
            new Protetor
            {
                Id = 1,
                Nome = "Greg",
                Cpf = "123.123.123-00",
                Endereco = "Rua tãnãnã",
                Celular = "47 99999-1246",
                Email = "greg@gmail.com",
                Senha = "123123123",
                Sobre = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                EhProtetor = false
            }
            );

        }
    }
}

using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Enum;
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
                .IsRequired()
                .HasColumnName("cpf");

            builder.Property(x => x.Endereco)
                .HasColumnType("VARCHAR")
                .HasMaxLength(45)
                .IsRequired()
                .HasColumnName("endereco");

            builder.Property(x => x.Celular)
                .HasColumnType("VARCHAR")
                .HasMaxLength(15)
                .IsRequired()
                .HasColumnName("celular");

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

            builder.Property(x => x.Especialidade)
                .HasColumnType("VARCHAR")
                .HasMaxLength(45)
                .HasColumnName("especialidade");

            builder.Property(x => x.EhVoluntario)
                .HasColumnType("BIT")
                .IsRequired()
                .HasColumnName("eh_voluntario");

            builder.Property(x => x.EhUsuario)
                .HasColumnType("BIT")
                .IsRequired()
                .HasColumnName("eh_usuario");

            builder.Property(x => x.DataNascimento)
                .HasColumnType("DATETIME2")
                .IsRequired()
                .HasColumnName("data_nascimento");      

            builder.Property(x => x.StatusConta)
                .HasColumnType("TINYINT")
                .IsRequired()
                .HasColumnName("status_conta"); 

            builder.HasData(
            new Usuario
            {
                Id = 1,
                Nome = "Ana",
                Cpf = "145.889.265-00",
                Endereco = "Rua tal",
                Celular = "47 99888-1246",
                Email = "ana@gmail.com",
                Senha = "123123123",
                ConfirmarSenha = "123123123",
                Especialidade = "Salto em distância",
                EhVoluntario = false,
                EhUsuario = true,
                DataNascimento = new DateTime(1992,04,02),
                StatusConta = StatusConta.Ativada
            },

            new Usuario
            {
                Id = 2,
                Nome = "Amanda",
                Endereco = "Rua alt",
                Cpf = "189.456.789-00",
                Celular = "47 98865-1246",
                Email = "amanda@gmail.com",
                Senha = "123123123",
                ConfirmarSenha = "123123123",
                Especialidade = "Corrida",
                EhVoluntario = true,
                EhUsuario = true,
                DataNascimento = new DateTime(1993,07,03),
                StatusConta = StatusConta.Ativada
            }
            );
        }
    }
}

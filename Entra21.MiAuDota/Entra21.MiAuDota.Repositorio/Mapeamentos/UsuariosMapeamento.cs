using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Enum;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            builder.Property(x => x.DataNascimento)
                .HasColumnType("DATE")
                .IsRequired()
                .HasColumnName("data_nascimento");

            builder.Property(x => x.Endereco)
               .HasColumnType("VARCHAR")
               .HasMaxLength(14)
               .IsRequired()
               .HasColumnName("endereco");

            builder.Property(x => x.Email)
               .HasColumnType("VARCHAR")
               .HasMaxLength(45)
               .IsRequired()
               .HasColumnName("email");

            builder.Property(x => x.Especialidade)
               .HasColumnType("VARCHAR")
               .HasMaxLength(45)
               .HasColumnName("especialidade");

            builder.Property(x => x.EhVoluntario)
               .HasColumnType("BIT")
               .IsRequired()
               .HasColumnName("ehVoluntario");

            builder.Property(x => x.Celular)
               .HasColumnType("VARCHAR")
               .HasMaxLength(14)
               .IsRequired()
               .HasColumnName("celular");

            builder.Property(x => x.EhUsuario)
               .HasColumnType("BIT")
                .IsRequired()
               .HasColumnName("ehUsuario");

            //builder.Property(x => x.StatusConta)
            //   .WithMany(x => x.StatusConta)
            //   .IsRequired()
            //   .HasColumnName("statusConta"); ///---------------------------------

            builder.HasData(
            new Usuario
            {
                Id = 1,
                Nome = "Ana",
                Cpf = "145.889.265-00",
                //DataNascimento = 08/04/1992,
                Endereco = "Rua tal",
                Email = "ana@gmail.com",
                Especialidade = "Salto em distância",
                EhVoluntario = false,
                Celular = "47 9986588-1246",
                EhUsuario = true,
                StatusConta = StatusConta.Ativada//--------------------------------------
            },

            new Usuario
            {
                Id = 1,
                Nome = "Amanda",
                Cpf = "189.456.789-00",
                //DataNascimento = 08 / 04 / 1992,
                Endereco = "Rua alt",
                Email = "amanda@gmail.com",
                Especialidade = "Corrida",
                EhVoluntario = true,
                Celular = "47 9884565-1246",
                EhUsuario = true,
                StatusConta = StatusConta.Ativada
            }
            );
        }
    }
}

using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Usuarios;
using FluentAssertions;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.Unit.Servico.Servicos
{
    public class UsuarioServicoTest
    {
        private readonly IUsuarioServico _usuarioServico;
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        private readonly IUsuarioMapeamentoEntidade _mapeamentoEntidade;
        private readonly IUsuarioMapeamentoViewModel _mapeamentoViewModel;

        public UsuarioServicoTest()
        {
            
            _usuarioRepositorio = Substitute.For<IUsuarioRepositorio>();
            _mapeamentoEntidade = Substitute.For<IUsuarioMapeamentoEntidade>();
            _mapeamentoViewModel = Substitute.For<IUsuarioMapeamentoViewModel>();
            _usuarioServico = new UsuarioServico(_usuarioRepositorio, _mapeamentoEntidade, _mapeamentoViewModel);
        }

        [Fact]
        public void Test_Apagar()
        {
            // Arrange
            var id = 10;

            // Act
            _usuarioServico.Apagar(id);

            // Assert
            _usuarioRepositorio
                .Received()
                .Apagar(Arg.Is(10));
        }

        [Fact]
        public void Test_Cadastrar()
        {
            // Arrange
            var viewModel = new UsuarioCadastrarViewModel
            {
                Nome = "Chico",
                Endereco = "Rua Amazonas",
                Celular = "4799999999",
                Email = "chico@gmail.com",
                Senha = "12345678",
                ConfirmarSenha = "12345678",
                Cpf = "12312312300",
                Especialidade = "aaa",
                EhVoluntario = true,
                DataNascimento = new DateTime(2000, 1, 6),
                IsActive = true,
            };
            // Act
            _usuarioServico.Cadastrar(viewModel);

            // Assert
            _usuarioRepositorio.Received(1).Cadastrar(Arg.Is<Usuario>(
                usuario => ValidarUser(viewModel)));
        }
        private bool ValidarUser(UsuarioCadastrarViewModel viewModel)
        {
            var user = new Usuario()
            {
                Nome = viewModel.Nome,
                Endereco = viewModel.Endereco,
                Celular = viewModel.Celular,
                Email = viewModel.Email,
                Senha = viewModel.Senha,
                ConfirmarSenha = viewModel.ConfirmarSenha,
                Cpf = viewModel.Cpf,
                Especialidade = viewModel.Especialidade,
                EhVoluntario = viewModel.EhVoluntario,
                DataNascimento = viewModel.DataNascimento,
                IsActive = viewModel.IsActive,
            };
            user.Nome.Should().Be(viewModel.Nome);
            user.Endereco.Should().Be(viewModel.Endereco);
            user.Celular.Should().Be(viewModel.Celular);
            user.Email.Should().Be(viewModel.Email);
            user.Senha.Should().Be(viewModel.Senha);
            user.ConfirmarSenha.Should().Be(viewModel.ConfirmarSenha);
            user.Cpf.Should().Be(viewModel.Cpf);
            user.EhVoluntario.Should().Be(viewModel.EhVoluntario);
            user.DataNascimento.Should().Be(viewModel.DataNascimento);
            user.IsActive.Should().Be(viewModel.IsActive);
            return true;
        }
    }
}

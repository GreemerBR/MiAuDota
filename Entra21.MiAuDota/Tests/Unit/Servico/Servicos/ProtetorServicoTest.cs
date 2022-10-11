using Entra21.MiAuDota.Repositorio.Entidades;
using Entra21.MiAuDota.Repositorio.Repositorios;
using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.MapeamentoViewModel;
using Entra21.MiAuDota.Servico.Servicos;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;
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
    public class ProtetorServicoTest
    {
        private readonly IProtetorServico _protetorServico;
        private readonly IProtetorRepositorio _protetorRepositorio;
        private readonly IProtetorMapeamentoEntidade _mapeamentoEntidade;
        private readonly IProtetorMapeamentoViewModel _mapeamentoViewModel;

        public ProtetorServicoTest()
        {

            _protetorRepositorio = Substitute.For<IProtetorRepositorio>();
            _mapeamentoEntidade = Substitute.For<IProtetorMapeamentoEntidade>();
            _mapeamentoViewModel = Substitute.For<IProtetorMapeamentoViewModel>();

            _protetorServico = new ProtetorServico(_protetorRepositorio, _mapeamentoEntidade, _mapeamentoViewModel);
        }

        [Fact]
        public void Test_Apagar()
        {
            // Arrange
            var id = 10;

            // Act
            _protetorServico.Apagar(id);

            // Assert
            _protetorRepositorio
                .Received()
                .Apagar(Arg.Is(10));
        }

        [Fact]
        public void Test_Cadastrar()
        {
            // Arrange
            var viewModel = new ProtetorCadastrarViewModel
            {
                Nome = "Ana",
                Endereco = "Rua do mar",
                Celular = "47999999999",
                Telefone = "33302828",
                Email = "ana@gmail.com",
                Senha = "protetor123",
                ConfirmarSenha = "protetor123",
                Cpf = null,
                Cnpj = null,
                Pix = "ana@gmail.com",
                Sobre = "abcdef",
                Facebook = "@ana145",
                Instagram = "@ana145",
                IsActive = true,
            };


            // Act
            _protetorServico.Cadastrar(viewModel);

            // Assert
            _protetorRepositorio
                .Received(1).
                Cadastrar(Arg.Is<Protetor>(protetor => ValidarRaca(viewModel)));
        }
        private bool ValidarRaca(ProtetorCadastrarViewModel viewModel)
        {
            var protetor = new Protetor()
            {
                Nome = viewModel.Nome,
                Endereco = viewModel.Endereco,
                Celular = viewModel.Celular,
                Telefone = viewModel.Telefone,
                Email = viewModel.Email,
                Senha = viewModel.Senha,
                Cpf = viewModel.Cpf,
                Cnpj = viewModel.Cnpj,
                Pix = viewModel.Pix,
                Facebook = viewModel.Facebook,
                Instagram = viewModel.Instagram,
                Sobre = viewModel.Sobre,
                IsActive = viewModel.IsActive,
            };
            protetor.Nome.Should().Be(viewModel.Nome);
            protetor.Endereco.Should().Be(viewModel.Endereco);
            protetor.Celular.Should().Be(viewModel.Celular);
            protetor.Telefone.Should().Be(viewModel.Telefone);
            protetor.Email.Should().Be(viewModel.Email);
            protetor.Senha.Should().Be(viewModel.Senha);
            protetor.Cpf.Should().BeNull();
            protetor.Cnpj.Should().BeNull();
            protetor.Pix.Should().Be(viewModel.Pix);
            protetor.Facebook.Should().Be(viewModel.Facebook);
            protetor.Instagram.Should().Be(viewModel.Instagram);
            protetor.Sobre.Should().Be(viewModel.Sobre);
            protetor.IsActive.Should().Be(viewModel.IsActive);

            // Informar que a validação da raça foi executada com sucesso
            return true;
        }
    }
}

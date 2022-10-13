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
            var viewModelEsperado = new ProtetorCadastrarViewModel
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
            };

            var protetorEsperado = new Protetor()
            {
                Nome = viewModelEsperado.Nome,
                Endereco = viewModelEsperado.Endereco,
                Celular = viewModelEsperado.Celular,
                Telefone = viewModelEsperado.Telefone,
                Email = viewModelEsperado.Email,
                Senha = viewModelEsperado.Senha,
                ConfirmarSenha = viewModelEsperado.ConfirmarSenha,
                Cpf = viewModelEsperado.Cpf,
                Cnpj = viewModelEsperado.Cpf,
                Pix = viewModelEsperado.Pix,
                Sobre = viewModelEsperado.Sobre,
                Facebook = viewModelEsperado.Facebook,
                Instagram = viewModelEsperado.Instagram
            };

            _mapeamentoEntidade.ConstruirCom(
                Arg.Is<ProtetorCadastrarViewModel>(viewModel =>
                    viewModel.Nome == viewModelEsperado.Nome))
                .Returns(protetorEsperado);


            // Act
            _protetorServico.Cadastrar(viewModelEsperado);

            // Assert
            _protetorRepositorio
                .Received(1).
                Cadastrar(Arg.Is<Protetor>(protetor => ValidarRaca(protetor, protetorEsperado)));
        }

        private bool ValidarRaca(Protetor protetor, Protetor protetorEsperado)
        {
            protetor.Nome.Should().Be(protetorEsperado.Nome);
            protetor.Endereco.Should().Be(protetorEsperado.Endereco);
            protetor.Celular.Should().Be(protetorEsperado.Celular);
            protetor.Telefone.Should().Be(protetorEsperado.Telefone);
            protetor.Email.Should().Be(protetorEsperado.Email);
            protetor.Senha.Should().Be(protetorEsperado.Senha);
            protetor.Cpf.Should().BeNull();
            protetor.Cnpj.Should().BeNull();
            protetor.Pix.Should().Be(protetorEsperado.Pix);
            protetor.Facebook.Should().Be(protetorEsperado.Facebook);
            protetor.Instagram.Should().Be(protetorEsperado.Instagram);
            protetor.Sobre.Should().Be(protetorEsperado.Sobre);

            // Informar que a validação da raça foi executada com sucesso
            return true;
        }
    }
}

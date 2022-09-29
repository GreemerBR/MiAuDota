using Entra21.MiAuDota.Servico.MapeamentoEntidades;
using Entra21.MiAuDota.Servico.ViewModels.Protetores;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Tests.Unit.Servico.MapeamentoEntidades
{
    public class ProtetorMapeamentoEntidadeTests
    {
        private readonly IProtetorMapeamentoEntidade _protetorMapeamentoEntidade;

        public ProtetorMapeamentoEntidadeTests()
        {
            _protetorMapeamentoEntidade = new ProtetorMapeamentoEntidade();
        }
        [Fact]
        public void Test_ConstruirCom()
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
                Cpf = "12345678900",
                Cnpj = "12.345.678/0001-00",
                Pix = "ana@gmail.com",
                Facebook = "@ana145",
                Instagram = "@ana145",
                Sobre = "abcdef"

            };

            // Act
            var protetor = _protetorMapeamentoEntidade.ConstruirCom(viewModel);
            
            // Assert
            protetor.Nome.Should().Be(viewModel.Nome);
            protetor.Endereco.Should().Be(viewModel.Endereco);
            protetor.Celular.Should().Be(viewModel.Celular);
            protetor.Telefone.Should().Be(viewModel.Telefone);
            protetor.Email.Should().Be(viewModel.Email);
            protetor.Senha.Should().Be(viewModel.Senha);
            protetor.ConfirmarSenha.Should().Be(viewModel.ConfirmarSenha);
            protetor.Cpf.Should().BeNull();
            protetor.Cnpj.Should().BeNull();
            protetor.Pix.Should().Be(viewModel.Pix);
            protetor.Facebook.Should().Be(viewModel.Facebook);
            protetor.Instagram.Should().Be(viewModel.Instagram);
            protetor.Sobre.Should().Be(viewModel.Sobre);

        }

    }
}

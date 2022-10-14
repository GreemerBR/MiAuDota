using Entra21.MiAuDota.Repositorio.Entidades;
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
            protetor.Cpf.Should().Be(viewModel.Cpf);
            protetor.Cnpj.Should().Be(viewModel.Cnpj);
            protetor.Pix.Should().Be(viewModel.Pix);
            protetor.Facebook.Should().Be(viewModel.Facebook);
            protetor.Instagram.Should().Be(viewModel.Instagram);
            protetor.Sobre.Should().Be(viewModel.Sobre);

        }
        [Fact]
        public void Test_AtualizarCampos()
        {
            // Arrange
            var protetor = new Protetor()
            {
                Endereco = "Rua Amazonas",
                Celular = "47999929999",
                Telefone = "3330-3033",
                Senha = "brasil?",
                ConfirmarSenha = "brasil?",
                Pix = null,
                Sobre = null,
                Instagram = null,
                Facebook = null
            };

            var viewModelSenha = new ProtetorSenhaViewModel
            {
                Senha = "brasil!",
                ConfirmarSenha = "brasil!",
            };
            var viewModelEditar = new ProtetorEditarViewModel
            {
                Endereco = "Rua Grécia",
                Celular = "47999929940",
                Telefone = "3330-7070",
                Pix = "47999929940",
                Sobre = "protetor new protetor",
                Instagram = "@nomedapessoa",
                Facebook = "@nomedapessoa"
            };


            // Act
            _protetorMapeamentoEntidade.AtualizarCampos(protetor, viewModelEditar);
            _protetorMapeamentoEntidade.AtualizarSenha(protetor, viewModelSenha);


            // Assert
            protetor.Endereco.Should().Be(viewModelEditar.Endereco);
            protetor.Celular.Should().Be(viewModelEditar.Celular);
            protetor.Telefone.Should().Be(viewModelEditar.Telefone);
            protetor.Senha.Should().Be(viewModelSenha.Senha);
            protetor.ConfirmarSenha.Should().Be(viewModelSenha.ConfirmarSenha);
            protetor.Pix.Should().Be(viewModelEditar.Pix);
            protetor.Sobre.Should().Be(viewModelEditar.Sobre);
            protetor.Instagram.Should().Be(viewModelEditar.Instagram);
            protetor.Facebook.Should().Be(viewModelEditar.Facebook);
        }

    }
}

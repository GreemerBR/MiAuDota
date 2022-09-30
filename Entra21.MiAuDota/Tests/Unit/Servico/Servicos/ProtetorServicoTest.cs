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
                Cpf = "12345678900",
                Cnpj = "12.345.678/0001-00",
                Pix = "ana@gmail.com",
                Facebook = "@ana145",
                Instagram = "@ana145",
                Sobre = "abcdef"

            };

            // Act
            _protetorServico.Cadastrar(viewModel);

            // Assert
            _protetorRepositorio.Received(1).Cadastrar(Arg.Is<Protetor>(
                protetor => ValidarRaca(protetor, viewModel)));
        }
        private bool ValidarRaca(Protetor protetor, ProtetorCadastrarViewModel viewModel)
        {
            protetor.Nome.Should().Be(viewModel.Nome);
            protetor.Endereco.Should().Be(viewModel.Endereco);
            protetor.Celular.Should().Be(viewModel.Celular);
            protetor.Telefone.Should().Be(viewModel.Telefone);
            protetor.Email.Should().Be(viewModel.Email);
            protetor.Senha.Should().Be(viewModel.Senha);
            protetor.Cpf.Should().Be(viewModel.Cpf);
            protetor.Cnpj.Should().Be(viewModel.Cnpj);
            protetor.Pix.Should().Be(viewModel.Pix);
            protetor.Facebook.Should().Be(viewModel.Facebook);
            protetor.Instagram.Should().Be(viewModel.Instagram);
            protetor.Sobre.Should().Be(viewModel.Sobre);

            // Informar que a validação da raça foi executada com sucesso
            return true;
        }
    }
}

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
    public class ProtetorServicoTests
    {
        private readonly IProtetorServico _protetorServico;
        private readonly IProtetorRepositorio _protetorRepositorio;
        private readonly IProtetorMapeamentoEntidade _protetorMapeamentoEntidade;
        private readonly IProtetorMapeamentoViewModel _protetorMapeamentoViewModel;
        public ProtetorServicoTests()
        {
            _protetorRepositorio = Substitute.For<IProtetorRepositorio>();
            _protetorServico = new ProtetorServico(_protetorRepositorio, _protetorMapeamentoEntidade, _protetorMapeamentoViewModel);
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
                protetor => ValidarProtetor(protetor, viewModel)));
        }
        private bool ValidarProtetor(Protetor protetor, ProtetorCadastrarViewModel viewModel)
        {
            protetor.Nome.Should().Be(viewModel.Nome);

            return true;
        }
    }
}
